# About

Simple TraceListener wrapped in a singleton class.

# Notes

1. Requires a reference to System.Configuration.
2. Requires a reference to the project (in this solution). LogLibrary
3. See initialization and finalization code in ApplicationEvents
4. See how app.config configures the TraceListener
5. Information is written to applicationLog.txt in the executable folder

### app.config

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <startup>
    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
  </startup>
  <system.diagnostics>
    <trace autoflush="false" indentsize="4">
      <listeners>
        <add name="myListener" type="System.Diagnostics.TextWriterTraceListener" initializeData="TextWriterOutput.log" />
        <remove name="Default" />
      </listeners>
    </trace>
  </system.diagnostics>

  <appSettings>
    <add key="SidesListenerName" value="PayneListener" />
    <add key="SidesListenerLogName" value="applicationLog.txt" />
  </appSettings>

</configuration>
```


