using System;
using System.Collections.Concurrent;
using Splitio.Services.Client.Classes;
using Splitio.Services.Client.Interfaces;

namespace SplitProjectApp
{
    public class SplitSDK
    {
        SplitFactory factory;
        SplitClient client;
        string apiKey;

        public SplitSDK(string apiKey)
        {
            this.apiKey = apiKey;
        }
        public SplitClient GetSplitClient()
        {
            if (this.Factory is null)
            {
                GetFactoryInstance();
            }
            return this.Client;
        }
        void GetFactoryInstance()
        {
            var config = new ConfigurationOptions();
            //            config.MetricsRefreshRate = 18000;
            this.Factory = new SplitFactory(this.apiKey, config);
            this.Client = (SplitClient)this.Factory.Client();
            this.Client.BlockUntilReady(10000);

        }
        void Destry()
        {
            this.Factory.Client().Destroy();
        }
    }
}