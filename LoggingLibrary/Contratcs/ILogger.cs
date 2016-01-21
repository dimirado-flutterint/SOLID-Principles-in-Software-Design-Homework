﻿using System.Collections.Generic;

namespace LoggingLibrary.Contratcs
{
    public interface ILogger
    {
        IList<IAppender> Appenders { get; }

        void Info(string message);

        void Warn(string message);

        void Error(string message);

        void Critical(string message);

        void Fatal(string message);
    }
}
