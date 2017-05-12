using Microsoft.WindowsAzure.MobileServices;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamagram.Models;

namespace Xamagram.Services
{
    public class XamagramMobileService
    {
        private MobileServiceClient _client;
        private IMobileServiceTable<XamagramItem> _xamagramItemTable;
        private static XamagramMobileService _instance;

        public static XamagramMobileService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new XamagramMobileService();
                }

                return _instance;
            }
        }

        public XamagramMobileService()
        {
            if (_client != null)
                return;

            _client = new MobileServiceClient(GlobalSettings.AzureUrl);
            _xamagramItemTable = _client.GetTable<XamagramItem>();
        }

        public Task<IEnumerable<XamagramItem>> ReadXamagramItemsAsync()
        {
            return _xamagramItemTable.ReadAsync();
        }
    }
}
