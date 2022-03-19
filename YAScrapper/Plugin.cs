using System;
using System.Collections.Generic;
using System.Text;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;
using YAScrapper.Configuration;
using HtmlAgilityPack;

using MediaBrowser.Common.Net;
using MediaBrowser.Model.Logging;




namespace YAScrapper
{
    public class Plugin : BasePlugin<PluginConfiguration> , IHasWebPages
    {
        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer , IHttpClient http, ILogManager logger) : base(applicationPaths, xmlSerializer)
        {
            Instance = this;

        }
        


       
   


        public static IHttpClient Http { get; set; }

        public static ILogger Log { get; set; }

        public static Plugin Instance { get; private set; }

        public override string Name => "YAScrapper";

        public override Guid Id => Guid.Parse("EF3B097A-C1A7-457E-BC96-DE916C16D568");

        public IEnumerable<PluginPageInfo> GetPages()
            => new[]
            {
                new PluginPageInfo
                {
                    Name = this.Name,
                    EmbeddedResourcePath = $"{this.GetType().Namespace}.Configuration.configPage.html",
                },
            };
    }
}
