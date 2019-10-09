using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;
using System;
using System.Linq;
using System.Configuration;
using System.Xml;
using System.Web;
using Identity = zAppDev.DotNet.Framework.Identity;
using zAppDev.DotNet.Framework.Identity;
using DSS2_SynchromodalityCapacityOptimisation.Security.Encryption;
using zAppDev.DotNet.Framework.Mvc;

namespace AppCode
{
    public class BaseViewPage<T> : System.Web.Mvc.WebViewPage<T>
    {
        private string _formName;

        private string _lang;

        private string _localeNumberGroupSeparator;
        public string LocaleNumberGroupSeparator
        {
            get
            {
                if (_localeNumberGroupSeparator == null)
                {
                    _localeNumberGroupSeparator = ProfileHelper.GetLocaleNumberGroupSeparator();
                }
                return _localeNumberGroupSeparator;
            }
        }

        private string _localeNumberDecimalSeparator;
        public string LocaleNumberDecimalSeparator
        {
            get
            {
                if (_localeNumberDecimalSeparator == null)
                {
                    _localeNumberDecimalSeparator = ProfileHelper.GetLocaleDecimalSeparator();
                }
                return _localeNumberDecimalSeparator;
            }
        }

        public static string EncryptValue(object value)
        {
            return EncryptionManager.Instance.EncryptString((string)value);
        }

        private static string _appVersion;
        private static readonly object SyncRoot = new Object();

        public static string AppVersion
        {
            get
            {
                if (string.IsNullOrEmpty(_appVersion))
                {
                    lock (SyncRoot)
                    {
                        if (string.IsNullOrEmpty(_appVersion))
                        {
                            var dir = System.Web.Hosting.HostingEnvironment.MapPath("~");
                            var path = Path.Combine(dir, "projectInfo.json");
                            var watcher = new FileSystemWatcher
                            {
                                Path = dir,
                                NotifyFilter = NotifyFilters.LastWrite,
                                Filter = "*.json",
                                IncludeSubdirectories = false
                            };
                            watcher.Changed += new FileSystemEventHandler(OnChanged);
                            watcher.EnableRaisingEvents = true;
                            UpdateAppVersion(path);
                        }
                    }
                }
                return _appVersion;
            }
        }

        private static long _lastOnChange;

        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            var diff = (DateTime.Now.Ticks - _lastOnChange) / TimeSpan.TicksPerMillisecond;
            if (diff < 500)
            {
                return;
            }
            _lastOnChange = DateTime.Now.Ticks;
            log4net.LogManager.GetLogger(typeof(BaseViewPage<IControllerBase>)).Info("Project Info Changed, updating app version");
            UpdateAppVersion(e.FullPath);
        }

        private static void UpdateAppVersion(string path, int @try = 0)
        {
            try
            {
                using (var stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        var pi = Newtonsoft.Json.JsonConvert.DeserializeObject<ProjectInfo>(reader.ReadToEnd());
                        _appVersion = pi.Version ?? Guid.NewGuid().ToString();
                        ClearLocalesCache();
                    }
                }
            }
            catch (Exception e)
            {
                if (@try < 5)
                {
                    Thread.Sleep(100);
                    log4net.LogManager.GetLogger(typeof(BaseViewPage<IControllerBase>)).Info($"Failed to read Project Info, retry... ({@try + 1})");
                    UpdateAppVersion(path, ++@try);
                    return;
                }
                _appVersion = Guid.NewGuid().ToString();
                log4net.LogManager.GetLogger(typeof(BaseViewPage<IControllerBase>)).Error($"Failed to get app version from path {path}", e);
            }
        }

        private static bool? _zipRequests;

        public static bool ZipRequests
        {
            get
            {
                if (_zipRequests == null)
                {
                    var setting = ConfigurationManager.AppSettings["ZipWebRequests"];
                    if (setting == null)
                    {
                        _zipRequests = false;
                    }
                    else
                    {
                        _zipRequests = setting.ToString().ToLower() == "true";
                    }
                }
                return _zipRequests.Value;
            }
        }

        public void Init(string formName)
        {
            _formName = formName;
            _lang = GetCurrentLanguage();
        }

        public static string GetCurrentLanguage()
        {
            var cultureInfo = new CultureInfo((int)ProfileHelper.GetCurrentProfileLanguageLCID());
            return string.IsNullOrWhiteSpace(cultureInfo?.Name)
                   ? _defaultLang
                   : cultureInfo.Name.ToLowerInvariant();
        }

        public override void Execute()
        {
        }

        public string GetResource(string resourceKey)
        {
            return GetResourceValue(_formName, resourceKey, _lang);
        }

        public string GetResource(string resourceKey, string fallback)
        {
            return GetResourceValue(_formName, resourceKey, _lang, GetGlobalResource(fallback));
        }

        public string GetGlobalResource(string resourceKey)
        {
            return GetResourceValue("GlobalResources", resourceKey, _lang);
        }

        public string GetContentWithVersion(string url, bool ignoreVersion = false)
        {
            var version = ignoreVersion ? "" : "?ver=" + AppVersion;
            return Url.Content(url + version);
        }

        public string GetTokenHeaderValue()
        {
            string cookieToken, formToken;
            System.Web.Helpers.AntiForgery.GetTokens(null, out cookieToken, out formToken);
            return cookieToken + ":" + formToken;
        }

        public string GetThemeMainStyle(string url)
        {
            var fixedUrl = BrowserIsInternetExplorer()
                           ? $"{url}_ie.css"
                           : $"{url}.css";
            return GetContentWithVersion(fixedUrl);
        }

        public bool BrowserIsInternetExplorer()
        {
            var browser = Request?.Browser?.Browser;
            return !string.IsNullOrWhiteSpace(browser) && (browser.Contains("InternetExplorer") || browser.StartsWith("IE"));
        }

        public static void SendApplicationUserCreationErrorReponse(string error)
        {
            error = error ?? "";
            error = error.Replace("NOT_CREATED", new BaseViewPage<int>().GetGlobalResource("RES_AUTH_NOT_CREATED"));
            SendRawReponseMessage(
                new BaseViewPage<int>().GetGlobalResource("RES_AUTH_ERROR_TITLE"),
                new BaseViewPage<int>().GetGlobalResource("RES_AUTH_ERROR_SUBTITLE"),
                error,
                new BaseViewPage<int>().GetGlobalResource("RES_AUTH_ERROR_FOOTER"));
        }

        public static void SendSecurityErrorReponse(string error)
        {
            error = error ?? "";
            error = error.Replace("NOT_CREATED", new BaseViewPage<int>().GetGlobalResource("RES_AUTH_NOT_CREATED"));
            SendRawReponseMessage(
                new BaseViewPage<int>().GetGlobalResource("RES_SECURITY_ERROR_TITLE"),
                new BaseViewPage<int>().GetGlobalResource("RES_SECURITY_ERROR_SUBTITLE"),
                error,
                new BaseViewPage<int>().GetGlobalResource("RES_SECURITY_ERROR_FOOTER"));
        }

        public static void SendRawReponseMessage(string title, string header, string error, string subTitle)
        {
            var content = GetFriendlyErrorPageMarkUp(
                              title,
                              header,
                              error,
                              subTitle);
            HttpContext.Current?.Response?.Clear();
            HttpContext.Current?.Response?.Write(content);
            HttpContext.Current?.Response?.Flush();
            HttpContext.Current?.Response?.End();
        }

        private static string GetFriendlyErrorPageMarkUp(string title, string header, string error, string subTitle)
        {
            return $@"
<!doctype html>
<html lang='en'>
<head>
  <meta charset='utf-8'>
  <title>{title}</title>
  <style>
    body {{
        font-family: monospace;
        background-color: #263238;
        color: #bfbfbf;
    }}

    h1 {{
        color: #F44336;
    }}

    h2 {{
        color: #FFC107;
    }}    
  </style>
</head>
<body>
    <h1>{header}</h1>
    <h2>{error}</h2>
    <h3>{subTitle}</h3>
</body>
</html>";
        }

        #region Locales

        private static Dictionary<string, XmlDocument> _cache = new Dictionary<string, XmlDocument>();
        private static Dictionary<string, Dictionary<string, string>> _formToResources = new Dictionary<string, Dictionary<string, string>>();
        private static List<string> _availiableLanguages = new List<string> { "en-us","el" };
        private static string _defaultLang = "en-us";

        public static void ClearLocalesCache()
        {
            _cache = new Dictionary<string, XmlDocument>();
            _formToResources = new Dictionary<string, Dictionary<string, string>>();
        }

        static readonly object _LockGetLocalesAsDictionaryObject = new object();

        private static Dictionary<string, string> GetLocalesAsDictionary(string formName, string lang = null)
        {
            //this method will be called when the page is loading and the _cashe will be cleared
            if (string.IsNullOrEmpty(_appVersion))
            {
                _appVersion = AppVersion;
            }
            lock (_LockGetLocalesAsDictionaryObject)
            {
                var key = GetFormResourcesKey(formName, lang);
                // Create Dictionary
                if (!_formToResources.ContainsKey(key))
                {
                    var doc = GetLocales(formName, lang);
                    var resourceNodes = doc.SelectNodes("/Locales/Loc");
                    var innerDictionary = new Dictionary<string, string>();
                    foreach (XmlElement node in resourceNodes)
                    {
                        var resourceKey = node.GetAttribute("Key");
                        var resourceValue = node.GetAttribute("Value");
                        if (innerDictionary.ContainsKey(resourceKey)) continue;
                        innerDictionary.Add(resourceKey, resourceValue);
                    }
                    _formToResources[key] = innerDictionary;
                }
                var dic = _formToResources[key];
                return dic;
            }
        }

        private static string GetFormResourcesKey(string formName, string lang = null)
        {
            if (!_availiableLanguages.Contains(_defaultLang))
            {
                _defaultLang = _availiableLanguages[0];
            }
            if (lang == null)
            {
                lang = GetCurrentLanguage();
            }
            if (!_availiableLanguages.Contains(lang))
            {
                try
                {
                    var bestMatch = _availiableLanguages.FirstOrDefault(l => l.Split('-').First() == lang.Split('-').First());
                    lang = bestMatch == null
                           ? _defaultLang
                           : bestMatch;
                }
                catch (Exception e)
                {
                    log4net.LogManager.GetLogger(typeof(BaseViewPage<IControllerBase>)).Error("Could not get best language match!", e);
                    lang = _defaultLang;
                }
            }
            var key = formName + "_" + lang;
            return key;
        }

        public static XmlDocument GetLocales(string formName, string lang = null)
        {
            var key = GetFormResourcesKey(formName, lang);
            if (_cache.ContainsKey(key))
            {
                return _cache[key].CloneNode(true) as XmlDocument;
            }
            var doc = new XmlDocument();
            doc.LoadXml(GetResourceContents(key + "_res.xml"));
            if (lang != _defaultLang)
            {
                MergeWithDefaultResources(formName, doc);
            }
            if (!_cache.ContainsKey(key))
            {
                _cache.Add(key, doc);
            }
            return doc.CloneNode(true) as XmlDocument;
        }

        private static void MergeWithDefaultResources(string formName, XmlDocument doc)
        {
            var defaultResources = GetLocales(formName, _defaultLang);
            foreach (XmlElement node in defaultResources.SelectNodes("/Locales/Loc"))
            {
                var translated = doc.SelectSingleNode("/Locales/Loc[@Key='" + node.GetAttribute("Key") + "']");
                if (string.IsNullOrWhiteSpace(translated?.Attributes["Value"]?.Value))
                {
                    var imported = doc.ImportNode(node, true) as XmlElement;
                    doc.DocumentElement.AppendChild(imported);
                    if (translated != null)
                    {
                        doc.DocumentElement.RemoveChild(translated);
                    }
                }
            }
        }

        public static string GetResourceValue(string formName, string name, string lang = null, string fallback = "")
        {
            var formResources = GetLocalesAsDictionary(formName, lang);
            return formResources.ContainsKey(name)
                   ? formResources[name]
                   : fallback;
        }

        private static string GetResourceContents(string fullPath)
        {
            return File.ReadAllText(System.Web.HttpContext.Current.Server.MapPath("~/Locales/" + fullPath));
        }

        public XmlDocument PrepareResources(string form, string master, bool addGlobal = true)
        {
            var resources = GetLocales(form);
            if (!string.IsNullOrWhiteSpace(master))
            {
                // Merge Master Page Resources
                var masterResources = GetLocales(master);
                foreach (XmlElement node in masterResources.SelectNodes("//Loc"))
                {
                    var copied = resources.ImportNode(node, true) as XmlElement;
                    copied.SetAttribute("Key", "MASTER_" + copied.GetAttribute("Key"));
                    resources.DocumentElement.AppendChild(copied);
                }
            }
            if (addGlobal)
            {
                // Merge Global Resources
                var globalResources = GetLocales("GlobalResources");
                foreach (XmlElement node in globalResources.SelectNodes("//Loc"))
                {
                    var copied = resources.ImportNode(node, true) as XmlElement;
                    copied.SetAttribute("Key", "GLOBAL_" + copied.GetAttribute("Key"));
                    resources.DocumentElement.AppendChild(copied);
                }
            }
            return resources;
        }

        #endregion
    }

    public static class Extensions
    {
        public static string ToSanitizedJs(this string @this, bool withXssSanitazation = true)
        {
            if (string.IsNullOrWhiteSpace(@this)) return @this;
            var replacements = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("\\", "\\\\")
            };
            try
            {
                var sanitized = @this;
                foreach (var tuple in replacements)
                {
                    sanitized = sanitized.Replace(tuple.Item1, tuple.Item2);
                }
                return withXssSanitazation ? sanitized.ToXssSafeString() : sanitized;
            }
            catch (Exception e)
            {
                log4net.LogManager.GetLogger(typeof(BaseViewPage<IControllerBase>))
                .Error("JS string sanitization failed!", e);
                return withXssSanitazation ? @this.ToXssSafeString() : @this;
            }
        }

        public static string ToXssSafeString(this object @this, string closeString = "'")
        {
            var str = @this?.ToString();
            if (string.IsNullOrWhiteSpace(str)) return str;
            if (str.Contains(closeString))
            {
                str = str.Replace(closeString, "");
            }
            return Utilities.StringContainsHtml(str)
                   ? System.Web.Security.AntiXss.AntiXssEncoder.HtmlEncode(str, true)
                   : str;
        }
    }

    class ProjectInfo
    {
        public string Name
        {
            get;
            set;
        }
        public string Version
        {
            get;
            set;
        }
    }
}