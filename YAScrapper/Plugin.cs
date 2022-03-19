using System;
using System.Collections.Generic;
using System.Text;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;
using YAScrapper.Configuration;
namespace YAScrapper
{
    public class Plugin : BasePlugin<PluginConfiguration> , IHasWebPages
    {
        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer)
        {
            Instance = this;

        }
        


        public static string PluginName = "YAScrapper";
        public IEnumerable<PluginPageInfo> GetPages()
        {
            return new[]
            {
                new PluginPageInfo
                {
                    Name = "YAScrapper",
                    EmbeddedResourcePath = $"{this.GetType().Namespace}.Configuration.configPage.html"
                }
            };
        }
        private Guid _id = new Guid("EF3B097A-C1A7-457E-BC96-DE916C16D568");
        public override Guid Id
        {
            get { return _id; }
        }


       
        /// <summary>
        /// Gets the name of the plugin
        /// </summary>
        /// <value>The name.</value>
        public override string Name
        {
            get { return PluginName; }
        }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>The description.</value>
        public override string Description
        {
            get
            {
                return "Plugin to crawl websites.";
            }
        }

        // public string PluginName { get; private set; }
        public static Plugin Instance { get; private set; }
    }
}
