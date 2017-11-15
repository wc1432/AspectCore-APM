﻿using System;
using AspectCore.DynamicProxy;

namespace AspectCore.APM.Logger
{
    [NonAspect]
    public interface ILogger
    {
        void LogInformation(string message);
        void LogWarning(string message);
        void LogError(string message, Exception exception);
    }
}
