using Microsoft.AspNetCore.Builder;

namespace simple_framework;
public static class SimpleExtensions
{
    /// <summary>
    /// Defaults is:
    /// **  1. configs loaded from url, passed by env varible
    ///     2. all dependend variblve now readable from specified url
    ///     3. meta file, passed to root folder is accesible by specified url
    /// *** 4. OTEL metrics is accessible from specified url (+ prometheus ? )
    /// *** 5. ZIPkin metrics \ tracing is passed to specified url (off by defaults)
    /// ****6. logs is serialized by JSONserializer and written to console \ stdout + masking!
    ///         - may be logs exporting to somewhere
    ///         - log level management
    /// ****7. AOP\Decorator is added to services
    ///     8. Everything is decorated by STOPWATCH decorator
    ///     9. Everything is decorated by logger decorator
    ///     10. default middlware injected
    ///         - for logging (with masking? and may be thru default logger)
    ///         - for measuring
    ///         - for hooks and triggers (that can be easily moddified \ added \ tweeked)
    ///     11. default RMQ \ MT ?
    ///     12. default Redis ?
    ///     13. default DB context ?
    ///     14. default service discovery \ httpBindings config ?
    ///     15. default scheduller \ hangfire \ BGWorker's stuff ?
    ///     16. scopes \ auth management
    ///     17. healthchecks - very deep hole
    ///     18. dumps autocollection on crashes
    /// *   19. default httpclient (factory) with propper polly
    ///     20. default migrations tools is set up
    ///     21. automigrations (if up and not local)
    ///     22. in memory DB context
    ///     23. add project template (with docker compose)
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    public static WebApplicationBuilder AddSimpleDefaults(this WebApplicationBuilder builder){

        Console.WriteLine("check");
        return builder;
    }
}
