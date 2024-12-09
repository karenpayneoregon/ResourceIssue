﻿using Microsoft.Extensions.Options;
using WinFormsApp1.Models.Configuration;

namespace WinFormsApp1.Classes.Configuration
{
    internal class SetupServices
    {
        private readonly EntityConfiguration _settings;
        private readonly ConnectionStrings _options;

        public SetupServices(IOptions<ConnectionStrings> options, IOptions<EntityConfiguration> settings)
        {
            _options = options.Value;
            _settings = settings.Value;
        }
        /// <summary>
        /// Read connection strings from appsettings
        /// </summary>
        public void GetConnectionStrings()
        {
            DataConnections.Instance.MainConnection = _options.MainConnection;
        }
        public void GetEntitySettings()
        {
            EntitySettings.Instance.CreateNew = _settings.CreateNew;
        }
    }
}
