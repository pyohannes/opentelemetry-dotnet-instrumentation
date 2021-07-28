// ReSharper disable InconsistentNaming - Name is used for integration names
namespace OpenTelemetry.AutoInstrumentation.ClrProfiler.Managed.Configuration
{
    /// <summary>
    /// Enum representing supported instrumentations.
    /// </summary>
    public enum Instrumentation
    {
        /// <summary>
        /// HttpClient instrumentation.
        /// </summary>
        HttpClient,

        /// <summary>
        /// ASP.NET instrumentation.
        /// </summary>
        AspNet,

        /// <summary>
        /// SqlClient instrumentation.
        /// </summary>
        SqlClient,

        /// <summary>
        /// MongoDb instrumentation.
        /// </summary>
        MongoDb
    }
}