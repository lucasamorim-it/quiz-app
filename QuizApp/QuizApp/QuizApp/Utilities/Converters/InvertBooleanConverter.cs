﻿using System;
using Xamarin.Forms;

namespace QuizApp.Utilities.Converters
{
    public class InvertBooleanConverter : IValueConverter
    {
        #region IValueConverter implementation

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is bool)
            {
                return !(bool)value;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is bool)
            {
                return !(bool)value;
            }
            return value;
        }

        #endregion
    }
}
