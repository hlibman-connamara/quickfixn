﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QuickFix;

namespace Executor
{
    public class Executor : QuickFix.Application
    {
        #region QuickFix.Application Methods
        
        public void FromAdmin(Message message, SessionID sessionID)
        {
            Console.WriteLine("FromAdmin: " + message);
        }

        public void FromApp(Message message, SessionID sessionID)
        {
            Console.WriteLine("FromApp: " + message);
        }

        public void OnCreate(SessionID sessionID) { }
        public void OnLogout(SessionID sessionID) { }
        public void OnLogon(SessionID sessionID) { }
        public void ToAdmin(Message message, SessionID sessionID) { }
        public void ToApp(Message message, SessionID sessionID) { }

        #endregion
    }
}