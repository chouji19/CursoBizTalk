using Microsoft.BizTalk.SSOClient.Interop;
using System;
using System.Collections.Specialized;

namespace CursoBizTalk.Utilidades
{

    public static class SSOClientHelper
    {
        private static string idenifierGUID = "ConfigProperties";

        public static string Read(string appName, string propName)
        {
            try
            {
                SSOConfigStore ssoStore = new SSOConfigStore();
                ConfigurationPropertyBag appMgmtBag = new ConfigurationPropertyBag();
                ((ISSOConfigStore)ssoStore).GetConfigInfo(appName, idenifierGUID, SSOFlag.SSO_FLAG_RUNTIME, (IPropertyBag)appMgmtBag);
                object propertyValue = null;
                appMgmtBag.Read(propName, out propertyValue, 0);
                return (string)propertyValue;
            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.WriteLine(e.Message);
                throw;
            }
        }


        
    }

    


    public class ConfigurationPropertyBag : IPropertyBag
   {
      private HybridDictionary properties;
    internal ConfigurationPropertyBag()
    {
        properties = new HybridDictionary();
    }
    public void Read(string propName, out object ptrVar, int errLog)
    {
        ptrVar = properties[propName];
    }
    public void Write(string propName, ref object ptrVar)
    {
        properties.Add(propName, ptrVar);
    }
    public bool Contains(string key)
    {
        return properties.Contains(key);
    }
    public void Remove(string key)
    {
        properties.Remove(key);
    }
}

}