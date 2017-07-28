using Newtonsoft.Json.Serialization;
using System.Diagnostics;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace Angular4Api
{
    public static class GlobalConfig
    {
            public static void CustomizeConfig(HttpConfiguration config)
            {
                config.Formatters.Remove(config.Formatters.XmlFormatter);

                var json = config.Formatters.JsonFormatter;
                json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

                
                var oldDefault = GlobalConfiguration.Configuration.Formatters.JsonFormatter.SupportedEncodings[0];
                GlobalConfiguration.Configuration.Formatters.JsonFormatter.SupportedEncodings.Add(oldDefault);
                GlobalConfiguration.Configuration.Formatters.JsonFormatter.SupportedEncodings.RemoveAt(0);

            }
    }
}