﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.Fields.Converters
{
    /// <summary>
    ///  convert Int64 to/from string
    /// </summary>
    public static class IntConverter
    {
        /// <summary>
        /// Converts string to int
        /// </summary>
        /// <exception cref="BadConversionException"/>
        public static int Convert(string i)
        {
            try
            {
                return System.Convert.ToInt32(i);
            }
            catch (FormatException e)
            {
                throw new FieldConvertError("could not convert string to int", e);
            }
            catch (OverflowException e)
            {
                throw new FieldConvertError("could not convert string to int", e);
            }
        }

        /// <summary>
        /// convert integer to string
        /// </summary>
        public static string Convert(Int64 i)
        {
            return i.ToString();
        }
    }
}
