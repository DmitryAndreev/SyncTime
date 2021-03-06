﻿using System;

namespace SyncTime.Infrastructure
{
    public static class DateTimeJavaScriptExtension
    {
        private static readonly long DatetimeMinTimeTicks =
            (new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).Ticks;

        public static long ToJavaScriptMilliseconds(this DateTime dt)
        {
            return (dt.ToUniversalTime().Ticks - DatetimeMinTimeTicks)/10000;
        }
    }
}