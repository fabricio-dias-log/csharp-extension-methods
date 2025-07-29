using System.Globalization;

namespace System;

static class DateTimeExtensions {
    public static string ElapsedTime(this DateTime dateTime) {
        TimeSpan elapsed = DateTime.Now.Subtract(dateTime);
        
        if (elapsed.TotalHours <= 24.0) {
            return $"{elapsed.TotalHours.ToString("F1", CultureInfo.InvariantCulture)} Hours";
        }
        else {
            return $"{elapsed.TotalDays.ToString("F1", CultureInfo.InvariantCulture)} Days";
        }
    }
    
}