# Simple service framework

##

This is simple as possible (i'll try hard to avoid any external dependencies) microservice framework template, that focus on "default" things.

## "Defaults things" is:

* configs loaded from url, passed by env variable **
* all dependent variable now readable from specified url
* meta file, passed to root folder is accessible by specified url
* OTEL metrics is accessible from specified url (+ prometheus ? ) ***
* ZIPKIN metrics \ tracing is passed to specified url (off by defaults) ***
* logs is serialized by JSON serializer and written to console \ stdout + masking! ****
  - may be logs exporting to somewhere
  - log level management
* AOP\Decorator is added to services ****
* Everything is decorated by STOPWATCH decorator
* Everything is decorated by logger decorator
* default middleware injected
  - for logging (with masking? and may be thru default logger)
  - for measuring
  - for hooks and triggers (that can be easily modified \ added \ tweaked)
* default RMQ \ MT ?
* default Redis ?
* default DB context ?
* default service discovery \ httpBindings config ?
* default scheduler \ hangfire \ BGWorker's stuff ?
* scopes \ auth management
* health checks - very deep hole
* dumps auto-collection on crashes
* default httpclient (factory) with proper polly *
* default migrations tools is set up
* auto migrations (if up and not local)
* in memory DB context, when launched in debug
* add project template (with docker compose)