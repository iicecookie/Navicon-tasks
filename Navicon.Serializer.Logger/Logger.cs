﻿using log4net;
using log4net.Config;

namespace Navicon.Serializer.Logging
{
    public static class Logger
    {
        public static readonly ILog Log;

        static Logger()
        {
            Log = LogManager.GetLogger("LOGGER");

            XmlConfigurator.Configure();
        }

        public static ILog GetLogger() => Log;
    }
}
