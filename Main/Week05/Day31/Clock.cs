using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Humanizer; // .NET needs for manipulating and displaying strings, enums, dates, times, timespans, numbers and quantities

namespace Day31
{
    public class Clock
    {
        public static string WhatTimeIsIt(int hour, int min) {
            var timeTeller = string.Empty;
            var culture = new CultureInfo("en-US");

            if(hour > 0 && hour <= 12  && min >= 0 && min < 60) {

                if(min == 0) {
                    timeTeller = $"{hour.ToWords(culture)} o'clock";
                } else if(min <= 30) {
                    var minWritten = min == 30 ? "half" :
                        min == 15 ? "quarter" : min.ToWords(culture);
                    timeTeller = $"{minWritten} past {hour.ToWords(culture)}";
                } else {
                    var minWritten = min == 45 ? "quarter" : (60 - min).ToWords(culture);
                    var hourWritten = hour == 12 ? "one" : (hour + 1).ToWords(culture); 
                    timeTeller = $"{minWritten} to {hourWritten}";
                }
                
            }

            return timeTeller;
        }
    }
}