* [log4net introduction manual](http://logging.apache.org/log4net/release/manual/introduction.html)
* http://stackoverflow.com/questions/1713043/what-is-the-best-pattern-for-using-same-log4net-logger-across-many-assemblies-in
  * A logger can have many appenders. And many loggers can also write to the SAME appender. So, you could configure loggers "A", "B", and "C" to all log to file "X".

Log4net makes it easy to name loggers by software component. This can be accomplished by statically instantiating a logger in each class, with the logger name equal to the fully qualified name of the class. This is a useful and straightforward method of defining loggers. As the log output bears the name of the generating logger, this naming strategy makes it easy to identify the origin of a log message