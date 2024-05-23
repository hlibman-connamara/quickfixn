﻿using System;
using System.Linq;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class SessionScheduleTests
    {
        #region Properties
        /// <summary>
        /// Windows/*nix-agnostic time zone ID
        /// (because it would be too easy if they could settle on a standard list of ids, right?)
        /// </summary>
        public string EASTERN_STANDARD_TIME_ZONE_ID
        {
            get
            {
                if (!TimeZoneInfo.GetSystemTimeZones().Any(x => x.Id == "Eastern Standard Time"))
                    return "US/Eastern";
                else
                    return "Eastern Standard Time";
            }
        }

        /// <summary>
        /// Windows/*nix-agnostic time zone ID
        /// (because it would be too easy if they could settle on a standard list of ids, right?)
        /// </summary>
        public string PACIFIC_STANDARD_TIME_ZONE_ID
        {
            get
            {
                if (!TimeZoneInfo.GetSystemTimeZones().Any(x => x.Id == "Pacific Standard Time"))
                    return "US/Pacific";
                else
                    return "Pacific Standard Time";
            }
        }
        #endregion

        const string FMT = "yyyyMMdd-HH:mm:ss";

        [Test]
        public void TestCtor_BasicDailySchedule()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            var ex = Assert.Throws(typeof(QuickFix.ConfigError), delegate { new QuickFix.SessionSchedule(settings); });
            StringAssert.Contains("No value for key: StartTime", ex.Message);

            settings.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
            ex = Assert.Throws(typeof(QuickFix.ConfigError), delegate { new QuickFix.SessionSchedule(settings); });
            StringAssert.Contains("No value for key: EndTime", ex.Message);

            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:0blkajsdf");
            ex = Assert.Throws(typeof(QuickFix.ConfigError), delegate { new QuickFix.SessionSchedule(settings); });
            StringAssert.Contains("String '00:0blkajsdf' was not recognized as a valid TimeSpan", ex.Message);

            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");
            Assert.DoesNotThrow(delegate { new QuickFix.SessionSchedule(settings); });
        }

        [Test]
        public void TestCtor_WeeklongSession()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");

            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Thursday);
            var ex = Assert.Throws(typeof(QuickFix.ConfigError), delegate { new QuickFix.SessionSchedule(settings); });
            StringAssert.Contains("StartDay used without EndDay", ex.Message);

            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Friday);
            Assert.DoesNotThrow(delegate { new QuickFix.SessionSchedule(settings); });
        }

        [Test]
        public void TestCtor_WeekdaysSession() {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.WEEKDAYS, "Sun,Tue,Fri");

            var ex = Assert.Throws(typeof(QuickFix.ConfigError), delegate { new QuickFix.SessionSchedule(settings); });
            StringAssert.Contains("No value for key: StartTime", ex.Message);

            settings.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");
            Assert.DoesNotThrow(delegate { new QuickFix.SessionSchedule(settings); });

            settings.SetString(QuickFix.SessionSettings.START_DAY, "Tue");
            ex = Assert.Throws(typeof(QuickFix.ConfigError), delegate { new QuickFix.SessionSchedule(settings); });
            StringAssert.Contains("StartDay/EndDay are not compatible with 'Weekdays' setting", ex.Message);
        }

        [Test]
        public void TestDailyIsSessionTimeAllDay()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 0, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 23, 59, 59, DateTimeKind.Utc)));
        }

        [Test]
        public void TestWeeklySessionSameDayAllWeek()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");

            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Monday);
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);
	    
            //a sunday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 16, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 16, 23, 59, 59, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 16, 0, 0, 0, DateTimeKind.Utc)));

            //a monday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 23, 59, 59, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 0, 0, 0, DateTimeKind.Utc)));

            //a tuesday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 0, 0, DateTimeKind.Utc)));
        }

        [Test]
        public void TestWeeklySessionSameDayMostWeek()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "05:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");

            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Monday);
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);
	    
            //a sunday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 16, 23, 59, 59, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 16, 0, 0, 0, DateTimeKind.Utc)));

            //a monday
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 0, 0, 1, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 4, 0, 1, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 23, 59, 59, DateTimeKind.Utc)));

            //a tuesday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 0, 0, DateTimeKind.Utc)));
        }

        [Test]
        public void TestWeeklySessionSameDayOneDay()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "05:00:00");

            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Monday);
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);
	    
            //a sunday
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 16, 23, 59, 59, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 16, 0, 0, 0, DateTimeKind.Utc)));

            //a monday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 0, 0, 1, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 4, 0, 1, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 6, 59, 59, DateTimeKind.Utc)));

            //a tuesday
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 0, 0, DateTimeKind.Utc)));
        }


        [Test]
        public void TestWeeklySessionMultiDay()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");

            //only on monday-thur (note end time)
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Friday);

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            //a monday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 0, 0, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 9, 43, 0, DateTimeKind.Utc)));

            // a thursday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 20, 23, 59, 59, DateTimeKind.Utc)));

            //a fri, sat, sun
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 21, 23, 59, 59, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 0, 0, 0, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 16, 9, 43, 0, DateTimeKind.Utc)));
        }

        [Test]
        public void TestWeeklySessionMultiDayOverlap()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");

            //only on wed-sunday night
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Wednesday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Monday);

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            //wed-monday
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 19, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 20, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 21, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 22, 9, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 16, 9, 43, 0, DateTimeKind.Utc)));

            //monday
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 9, 43, 0, DateTimeKind.Utc)));

            //tuesday
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 9, 43, 0, DateTimeKind.Utc)));
        }

        [Test]
        public void TestWeeklySessionMultiDayHours()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "07:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "15:00:00");

            //only on monday-fri
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Friday);

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            //Monday Scenarios
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 6, 59, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 7, 30, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 15, 30, 0, DateTimeKind.Utc)));

            //Midweek Scenarios
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 19, 6, 59, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 19, 7, 30, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 19, 15, 30, 0, DateTimeKind.Utc)));

            //Friday Scenarios
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 21, 6, 59, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 21, 7, 30, 0, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 21, 15, 30, 0, DateTimeKind.Utc)));

            //Weekend
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 6, 59, 0, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 7, 30, 0, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 15, 30, 0, DateTimeKind.Utc)));
        }

        [Test]
        public void TestWeeklySessionMultiDayHoursOverlap()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "15:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "07:00:00");

            //only on monday-fri
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Friday);

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            //weekdays
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 15, 30, 0, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 6, 30, 0, DateTimeKind.Utc)), "foo");

            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 21, 5, 30, 59, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 21, 15, 30, 59, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 6, 59, 59, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 7, 00, 1, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 22, 15, 30, 0, DateTimeKind.Utc)));
        }
        

        [Test]
        public void TestDailyIsSessionTime()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "00:12:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "06:00:23");

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 0, 12, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 5, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 6, 0, 23, DateTimeKind.Utc)));

            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 11, 0, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 6, 0, 24, DateTimeKind.Utc)));
        }

        [Test]
        public void TestDailyIsSessionTimeWrapAround()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "06:00:23");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:12:00");

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 6, 0, 23, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 8, 43, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 12, 00, DateTimeKind.Utc)));

            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 0, 12, 1, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 18, 6, 0, 22, DateTimeKind.Utc)));

        }

        [Test]
        public void TestInvalidTimeZone()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "06:00:23");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:12:00");
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, "Doh");

            Assert.Throws(typeof (TimeZoneNotFoundException), delegate { new QuickFix.SessionSchedule(settings); });
        }

        [Test]
        public void TestLocalTimeTimeZoneConflict()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "06:00:23");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "00:12:00");
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, "Doh");
            settings.SetString(QuickFix.SessionSettings.USE_LOCAL_TIME, "Y");
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, EASTERN_STANDARD_TIME_ZONE_ID);

            Assert.Throws(typeof (QuickFix.ConfigError), delegate { new QuickFix.SessionSchedule(settings); });
        }

        [Test]
        public void TestTimeZone()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "09:30:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "16:00:00");
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, EASTERN_STANDARD_TIME_ZONE_ID);

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 13, 29, 59, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 13, 30, 0, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2011, 10, 17, 20, 0, 0, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2011, 10, 17, 20, 0, 1, DateTimeKind.Utc)));
        }

        [Test]
        public void TestNextEndTime_takesUtcOnly()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "09:30:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "16:00:00");
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            DateTime local = new DateTime(2001, 1, 1, 1, 1, 1, DateTimeKind.Local);
            DateTime none = new DateTime(2001, 1, 1, 1, 1, 1, DateTimeKind.Unspecified);

            Assert.Throws<ArgumentException>(delegate { sched.NextEndTime(local); });
            Assert.Throws<ArgumentException>(delegate { sched.NextEndTime(none); });
        }

        [Test]
        public void TestNextEndTime_Daily()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "09:30:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "16:00:00");
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            Assert.AreEqual("20121018-16:00:00",
                sched.NextEndTime(new DateTime(2012, 10, 18, 15, 59, 59, DateTimeKind.Utc)).ToString(FMT));
            Assert.AreEqual("20121018-16:00:00",
                sched.NextEndTime(new DateTime(2012, 10, 18, 16, 00, 00, DateTimeKind.Utc)).ToString(FMT));
            Assert.AreEqual("20121019-16:00:00",
                sched.NextEndTime(new DateTime(2012, 10, 18, 16, 00, 01, DateTimeKind.Utc)).ToString(FMT));

            // ==========
            // Settings file is specified in a zone (est, -5)
            settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "04:30:00"); // 09:30:00 utc
            settings.SetString(QuickFix.SessionSettings.END_TIME, "11:00:00");   // 16:00:00 utc
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, EASTERN_STANDARD_TIME_ZONE_ID); //-5
            sched = new QuickFix.SessionSchedule(settings);

            Assert.AreEqual("20121218-11:00:00",
                sched.NextEndTime(new DateTime(2012, 12, 18, 15, 59, 59, DateTimeKind.Utc)).ToString(FMT));
            Assert.AreEqual("20121218-11:00:00",
                sched.NextEndTime(new DateTime(2012, 12, 18, 16, 00, 00, DateTimeKind.Utc)).ToString(FMT));
            Assert.AreEqual("20121219-11:00:00",
                sched.NextEndTime(new DateTime(2012, 12, 18, 16, 00, 01, DateTimeKind.Utc)).ToString(FMT));

            // ==========
            // Time zone during Daylight Savings
            settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "05:30:00"); // 09:30:00 utc
            settings.SetString(QuickFix.SessionSettings.END_TIME, "12:00:00");   // 16:00:00 utc
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, EASTERN_STANDARD_TIME_ZONE_ID); //-4 for DST
            sched = new QuickFix.SessionSchedule(settings);

            Assert.AreEqual("20120618-12:00:00",
                sched.NextEndTime(new DateTime(2012, 06, 18, 15, 59, 59, DateTimeKind.Utc)).ToString(FMT));
            Assert.AreEqual("20120618-12:00:00",
                sched.NextEndTime(new DateTime(2012, 06, 18, 16, 00, 00, DateTimeKind.Utc)).ToString(FMT));
            Assert.AreEqual("20120619-12:00:00",
                sched.NextEndTime(new DateTime(2012, 06, 18, 16, 00, 01, DateTimeKind.Utc)).ToString(FMT));
        }

        [Test]
        public void TestNextEndTime_Weekly()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "09:30:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "16:00:00");
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Friday);
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            // Oct 15 and 22 are Mondays, 19 and 26 are Fridays
            Assert.AreEqual("20121019-16:00:00",
                sched.NextEndTime(new DateTime(2012, 10, 19, 15, 59, 59, DateTimeKind.Utc)).ToString(FMT));
            Assert.AreEqual("20121019-16:00:00",
                sched.NextEndTime(new DateTime(2012, 10, 19, 16, 00, 00, DateTimeKind.Utc)).ToString(FMT));
            Assert.AreEqual("20121026-16:00:00",
                sched.NextEndTime(new DateTime(2012, 10, 19, 16, 00, 01, DateTimeKind.Utc)).ToString(FMT));

            // ==========
            // Settings file is specified in a zone (est, -5)
            settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "04:30:00"); // 09:30:00 utc
            settings.SetString(QuickFix.SessionSettings.END_TIME, "11:00:00");   // 16:00:00 utc
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, EASTERN_STANDARD_TIME_ZONE_ID); //-5
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Friday);
            sched = new QuickFix.SessionSchedule(settings);

            // Dec 14 and 21 are Fridays
            Assert.AreEqual("20121214-11:00:00",
                sched.NextEndTime(new DateTime(2012, 12, 14, 15, 59, 59, DateTimeKind.Utc)).ToString(FMT));
            Assert.AreEqual("20121214-11:00:00",
                sched.NextEndTime(new DateTime(2012, 12, 14, 16, 00, 00, DateTimeKind.Utc)).ToString(FMT));
            Assert.AreEqual("20121221-11:00:00",
                sched.NextEndTime(new DateTime(2012, 12, 14, 16, 00, 01, DateTimeKind.Utc)).ToString(FMT));

            // ==========
            // Time zone during Daylight Savings
            settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "05:30:00"); // 09:30:00 utc
            settings.SetString(QuickFix.SessionSettings.END_TIME, "12:00:00");   // 16:00:00 utc
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, EASTERN_STANDARD_TIME_ZONE_ID); //-4 for DST
            settings.SetDay(QuickFix.SessionSettings.START_DAY, System.DayOfWeek.Monday);
            settings.SetDay(QuickFix.SessionSettings.END_DAY, System.DayOfWeek.Friday);
            sched = new QuickFix.SessionSchedule(settings);

            // June 15 and 22 are Fridays
            Assert.AreEqual("20120615-12:00:00",
                sched.NextEndTime(new DateTime(2012, 06, 15, 15, 59, 59, DateTimeKind.Utc)).ToString(FMT));
            Assert.AreEqual("20120615-12:00:00",
                sched.NextEndTime(new DateTime(2012, 06, 15, 16, 00, 00, DateTimeKind.Utc)).ToString(FMT));
            Assert.AreEqual("20120622-12:00:00",
                sched.NextEndTime(new DateTime(2012, 06, 15, 16, 00, 01, DateTimeKind.Utc)).ToString(FMT));

        }

        [Test]
        public void TestIsNewSession_takesUtcOnly()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "09:30:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "16:00:00");
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            DateTime local = new DateTime(2001, 1, 1, 1, 1, 1, DateTimeKind.Local);
            DateTime utc = new DateTime(2001, 1, 1, 1, 1, 1, DateTimeKind.Utc);
            DateTime none = new DateTime(2001, 1, 1, 1, 1, 1, DateTimeKind.Unspecified);

            Assert.Throws<ArgumentException>(delegate { sched.IsNewSession(local, utc); });
            Assert.Throws<ArgumentException>(delegate { sched.IsNewSession(utc, local); });
            Assert.Throws<ArgumentException>(delegate { sched.IsNewSession(none, utc); });
            Assert.Throws<ArgumentException>(delegate { sched.IsNewSession(utc, none); });
        }

        [Test]
        public void TestIsNewSession_Daily()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "09:30:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "16:00:00");
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            Assert.False(sched.IsNewSession(
                new DateTime(2012, 10, 18, 15, 59, 58, DateTimeKind.Utc),
                new DateTime(2012, 10, 18, 15, 59, 59, DateTimeKind.Utc)));
            Assert.False(sched.IsNewSession(
                new DateTime(2012, 10, 18, 15, 59, 59, DateTimeKind.Utc),
                new DateTime(2012, 10, 18, 16, 00, 00, DateTimeKind.Utc)));
            Assert.True(sched.IsNewSession(
                new DateTime(2012, 10, 18, 16, 00, 00, DateTimeKind.Utc),
                new DateTime(2012, 10, 18, 16, 00, 01, DateTimeKind.Utc)));
            Assert.False(sched.IsNewSession(
                new DateTime(2012, 10, 18, 16, 00, 01, DateTimeKind.Utc),
                new DateTime(2012, 10, 18, 16, 00, 02, DateTimeKind.Utc)));

            // ==========
            // Settings file is specified in a zone (est, -5)
            settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "04:30:00"); // 09:30:00 utc
            settings.SetString(QuickFix.SessionSettings.END_TIME, "11:00:00");   // 16:00:00 utc
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, EASTERN_STANDARD_TIME_ZONE_ID); //-5
            sched = new QuickFix.SessionSchedule(settings);

            Assert.False(sched.IsNewSession(
                new DateTime(2012, 12, 18, 15, 59, 58, DateTimeKind.Utc),
                new DateTime(2012, 12, 18, 15, 59, 59, DateTimeKind.Utc)));
            Assert.False(sched.IsNewSession(
                new DateTime(2012, 12, 18, 15, 59, 59, DateTimeKind.Utc),
                new DateTime(2012, 12, 18, 16, 00, 00, DateTimeKind.Utc)));
            Assert.True(sched.IsNewSession(
                new DateTime(2012, 12, 18, 16, 00, 00, DateTimeKind.Utc),
                new DateTime(2012, 12, 18, 16, 00, 01, DateTimeKind.Utc)));
            Assert.False(sched.IsNewSession(
                new DateTime(2012, 12, 18, 16, 00, 01, DateTimeKind.Utc),
                new DateTime(2012, 12, 18, 16, 00, 02, DateTimeKind.Utc)));

            // ==========
            // Time zone during Daylight savings
            settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "05:30:00"); // 09:30:00 utc
            settings.SetString(QuickFix.SessionSettings.END_TIME, "12:00:00");   // 16:00:00 utc
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, EASTERN_STANDARD_TIME_ZONE_ID); //-4 during dst
            sched = new QuickFix.SessionSchedule(settings);

            Assert.False(sched.IsNewSession(
                new DateTime(2012, 06, 18, 15, 59, 58, DateTimeKind.Utc),
                new DateTime(2012, 06, 18, 15, 59, 59, DateTimeKind.Utc)));
            Assert.False(sched.IsNewSession(
                new DateTime(2012, 06, 18, 15, 59, 59, DateTimeKind.Utc),
                new DateTime(2012, 06, 18, 16, 00, 00, DateTimeKind.Utc)));
            Assert.True(sched.IsNewSession(
                new DateTime(2012, 06, 18, 16, 00, 00, DateTimeKind.Utc),
                new DateTime(2012, 06, 18, 16, 00, 01, DateTimeKind.Utc)));
            Assert.False(sched.IsNewSession(
                new DateTime(2012, 06, 18, 16, 00, 01, DateTimeKind.Utc),
                new DateTime(2012, 06, 18, 16, 00, 02, DateTimeKind.Utc)));
        }

        [Test]
        public void TestAdjustDateTime()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "09:30:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "16:00:00");
            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            // 1) reject if param is not utc
            Assert.Throws<ArgumentException>(
                delegate { sched.AdjustUtcDateTime(new DateTime(2012, 10, 18, 12, 00, 00, DateTimeKind.Local)); });
            Assert.Throws<ArgumentException>(
                delegate { sched.AdjustUtcDateTime(new DateTime(2012, 10, 18, 12, 00, 00, DateTimeKind.Unspecified)); });

            // 2) if settings is UTC, don't convert
            DateTime d2 = new DateTime(2013, 01, 15, 12, 00, 00, DateTimeKind.Utc);
            Assert.AreEqual(d2, sched.AdjustUtcDateTime(d2));

            // 3) if settings has a TimeZone, convert to TimeZone
            settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "04:30:00"); // 09:30:00 utc
            settings.SetString(QuickFix.SessionSettings.END_TIME, "11:00:00");   // 16:00:00 utc
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, EASTERN_STANDARD_TIME_ZONE_ID); //-5
            sched = new QuickFix.SessionSchedule(settings);

            DateTime d3 = new DateTime(2013, 01, 15, 03, 00, 00, DateTimeKind.Utc);
            DateTime d3expected = new DateTime(2013, 01, 14, 22, 00, 00, DateTimeKind.Unspecified);
            DateTime d3actual = sched.AdjustUtcDateTime(d3);
            Util.UtcDateTimeSerializerTests.AssertHackyDateTimeEquality(d3expected, d3actual);

            //    now with Pacific Standard Time
            settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "04:30:00"); // 09:30:00 utc
            settings.SetString(QuickFix.SessionSettings.END_TIME, "11:00:00");   // 16:00:00 utc
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, PACIFIC_STANDARD_TIME_ZONE_ID); //-5
            sched = new QuickFix.SessionSchedule(settings);

            d3 = new DateTime(2013, 01, 15, 03, 00, 00, DateTimeKind.Utc);
            d3expected = new DateTime(2013, 01, 14, 19, 00, 00, DateTimeKind.Unspecified);
            d3actual = sched.AdjustUtcDateTime(d3);
            Util.UtcDateTimeSerializerTests.AssertHackyDateTimeEquality(d3expected, d3actual);

            // 4) TimeZone with daylight savings
            settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "04:30:00"); // 09:30:00 utc
            settings.SetString(QuickFix.SessionSettings.END_TIME, "11:00:00");   // 16:00:00 utc
            settings.SetString(QuickFix.SessionSettings.TIME_ZONE, EASTERN_STANDARD_TIME_ZONE_ID); //-4 in June
            sched = new QuickFix.SessionSchedule(settings);

            DateTime d4 = new DateTime(2013, 06, 15, 03, 00, 00, DateTimeKind.Utc);
            DateTime d4expected = new DateTime(2013, 06, 14, 23, 00, 00, DateTimeKind.Unspecified);
            DateTime d4actual = sched.AdjustUtcDateTime(d4);
            Util.UtcDateTimeSerializerTests.AssertHackyDateTimeEquality(d4expected, d4actual);

            // 5) if settings has UseLocalTime, convert to local time
            settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.START_TIME, "04:30:00"); // 09:30:00 utc
            settings.SetString(QuickFix.SessionSettings.END_TIME, "11:00:00");   // 16:00:00 utc
            settings.SetString(QuickFix.SessionSettings.USE_LOCAL_TIME, "Y");
            sched = new QuickFix.SessionSchedule(settings);

            DateTime d5 = new DateTime(2013, 01, 15, 16, 00, 00, DateTimeKind.Utc);
            DateTime d5expected = d5.ToLocalTime();
            DateTime d5actual = sched.AdjustUtcDateTime(d5);
            Util.UtcDateTimeSerializerTests.AssertHackyDateTimeEquality(d5expected, d5actual);
            Assert.AreEqual(DateTimeKind.Local, d5actual.Kind);
        }

        [Test]
        public void TestWeekdaysSession()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.WEEKDAYS, "Tue,Th");
            settings.SetString(QuickFix.SessionSettings.START_TIME, "08:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "17:00:00");

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            // bounds of Tuesday
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2024, 05, 21, 07, 59, 59, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2024, 05, 21, 08, 00, 00, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2024, 05, 21, 08, 00, 10, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2024, 05, 21, 16, 59, 59, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2024, 05, 21, 17, 00, 00, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2024, 05, 21, 17, 00, 10, DateTimeKind.Utc)));

            // bounds of Thursday
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2024, 05, 23, 07, 59, 59, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2024, 05, 23, 08, 00, 00, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2024, 05, 23, 08, 00, 10, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2024, 05, 23, 16, 59, 59, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2024, 05, 23, 17, 00, 00, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2024, 05, 23, 17, 00, 10, DateTimeKind.Utc)));
        }

        [Test]
        public void TestWeekdaysSession_ThatCrossesMidnight()
        {
            QuickFix.SettingsDictionary settings = new QuickFix.SettingsDictionary();
            settings.SetString(QuickFix.SessionSettings.WEEKDAYS, "Tue,Th");
            settings.SetString(QuickFix.SessionSettings.START_TIME, "17:00:00");
            settings.SetString(QuickFix.SessionSettings.END_TIME, "11:00:00");

            QuickFix.SessionSchedule sched = new QuickFix.SessionSchedule(settings);

            // bounds of Tuesday-Wednesday
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2024, 05, 21, 16, 59, 59, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2024, 05, 21, 17, 00, 00, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2024, 05, 21, 17, 00, 10, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2024, 05, 22, 10, 59, 59, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2024, 05, 22, 11, 00, 00, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2024, 05, 22, 11, 00, 10, DateTimeKind.Utc)));

            // bounds of Thursday-Friday
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2024, 05, 23, 16, 59, 59, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2024, 05, 23, 17, 00, 00, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2024, 05, 23, 17, 00, 10, DateTimeKind.Utc)));
            Assert.IsTrue(sched.IsSessionTime(new DateTime(2024, 05, 24, 10, 59, 59, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2024, 05, 24, 11, 00, 00, DateTimeKind.Utc)));
            Assert.IsFalse(sched.IsSessionTime(new DateTime(2024, 05, 24, 11, 00, 10, DateTimeKind.Utc)));
        }
    }
}
