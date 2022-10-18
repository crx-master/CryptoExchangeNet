using Microsoft.Extensions.Logging;
using System;

namespace SharpCryptoExchange.Logging
{
    /// <summary>
    /// Uses the LoggerMessage attribute pattern to generate code that log messages wih good performance
    /// </summary>
    public static partial class LogHelper
    {

        #region Generic log messages

        /// <summary>
        /// Log a critical message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        [LoggerMessage(EventId = 99001, Level = LogLevel.Critical, EventName = "GENERIC CRITICAL MESSAGE", Message = "{message}")]
        public static partial void LogCriticalMessage(ILogger logger, string message, Exception ex);

        /// <summary>
        /// Log a generic error message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        [LoggerMessage(EventId = 90001, Level = LogLevel.Error, EventName = "GENERIC ERROR MESSAGE", Message = "{message}")]
        public static partial void LogErrorMessage(ILogger logger, string message);

        /// <summary>
        /// Log a generic warning message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        [LoggerMessage(EventId = 50001, Level = LogLevel.Warning, EventName = "GENERIC WARNING MESSAGE", Message = "{message}")]
        public static partial void LogWarningMessage(ILogger logger, string message);

        /// <summary>
        /// Log a generic information message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        [LoggerMessage(EventId = 20001, Level = LogLevel.Information, EventName = "GENERIC INFORMATION MESSAGE", Message = "{message}")]
        public static partial void LogInformationMessage(ILogger logger, string message);

        /// <summary>
        /// Log a generic debug message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        [LoggerMessage(EventId = 10001, Level = LogLevel.Debug, EventName = "GENERIC DEBUG MESSAGE", Message = "{message}")]
        public static partial void LogDebugMessage(ILogger logger, string message);

        /// <summary>
        /// Log a generic trace message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        [LoggerMessage(EventId = 1001, Level = LogLevel.Trace, EventName = "GENERIC TRACE MESSAGE", Message = "{message}")]
        public static partial void LogTraceMessage(ILogger logger, string message);

        #endregion

        /// <summary>
        /// Log a latency check information message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="latencyCheckCount"></param>
        /// <param name="latency"></param>
        /// <param name="currentTimeDelta"></param>
        /// <param name="averageTimeDelta"></param>
        /// <param name="syncTime"></param>
        [LoggerMessage(
            EventId = 20002, 
            Level = LogLevel.Information, 
            EventName = "LATENCY CHECK", 
            Message = "[{latencyCheckCount:n0}] Latency check: latency: {latency:n3}ms; current time delta: {currentTimeDelta:n3}ms; average time delta: {averageTimeDelta:n3}ms: sync time: {syncTime:o}"
        )]
        public static partial void LogLatencyCheck(ILogger logger, int latencyCheckCount, double latency, double currentTimeDelta, double averageTimeDelta, DateTimeOffset syncTime);

        /// <summary>
        /// Log a "creating request" event
        /// </summary>
        /// <param name="logger">The logger instance</param>
        /// <param name="requestId">Request ID</param>
        /// <param name="uri">URI instance to request for</param>
        [LoggerMessage(
            EventId = 10002,
            Level = LogLevel.Debug,
            EventName = "CREATING REQUEST",
            Message = "[{requestId}] Creating request for [URL]({uri})"
        )]
        public static partial void LogCreatingRequest(ILogger logger, int requestId, Uri uri);

        /// <summary>
        /// Trace data string
        /// </summary>
        /// <remarks>
        /// do not use in production, may contain sensitive data
        /// </remarks>
        /// <param name="logger">The logger instance</param>
        /// <param name="dataString">JSON data string to log</param>
        [LoggerMessage(EventId = 1002, Level = LogLevel.Trace, EventName = "TRACE DATA", Message = "JSON data: \"{dataString}\"")]
        public static partial void TraceJsonString(ILogger logger, string dataString);

    }

}
