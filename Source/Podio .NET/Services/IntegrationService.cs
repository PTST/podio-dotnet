using System.Collections.Generic;
using PodioAPI.Models;
using System.Threading.Tasks;

namespace PodioAPI.Services
{
    public class longegrationService
    {
        private readonly Podio _podio;

        public longegrationService(Podio currentInstance)
        {
            _podio = currentInstance;
        }

        /// <summary>
        ///     Creates a new longegration on the app.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/longegrations/create-longegration-86839 </para>
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="type">The type of longegration, see the area for available types</param>
        /// <param name="silent">True if updates should be silent, false otherwise</param>
        /// <param name="config">The configuration of the longegration, which depends on the above type,</param>
        /// <returns></returns>
        public async Task<long> Createlongegration(long appId, string type, bool silent, dynamic config)
        {
            string url = string.Format("/longegration/{0}", appId);
            dynamic requestData = new
            {
                type = type,
                silent = silent,
                config = config
            };
            dynamic response = await  _podio.Post<dynamic>(url, requestData);
            return (long) response["longegration_id"];
        }

        /// <summary>
        ///     Deletes the longegration from the given app.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/longegrations/delete-longegration-86876 </para>
        /// </summary>
        /// <param name="appId"></param>
        public async Task<dynamic> Deletelongegration(long appId)
        {
            string url = string.Format("/longegration/{0}", appId);
            return await  _podio.Delete<dynamic>(url);
        }

        /// <summary>
        ///     Returns the fields available from the configuration.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/longegrations/get-available-fields-86890 </para>
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        public async Task<List<longegrationAvailableAppField>> GetAvailableFields(long appId)
        {
            string url = string.Format("/longegration/{0}/field/", appId);
            return await  _podio.Get<List<longegrationAvailableAppField>>(url);
        }

        /// <summary>
        ///     Returns the longegration with the given id.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/longegrations/get-longegration-86821 </para>
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        public async Task<longegration> Getlongegration(long appId)
        {
            string url = string.Format("/longegration/{0}", appId);
            return await  _podio.Get<longegration>(url);
        }

        /// <summary>
        ///     Refreshes the longegration. This will update all items in the background.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/longegrations/refresh-longegration-86987 </para>
        /// </summary>
        /// <param name="appId"></param>
        public async Task<dynamic> Refreshlongegration(long appId)
        {
            string url = string.Format("/longegration/{0}/refresh", appId);
            return await  _podio.Post<dynamic>(url);
        }

        /// <summary>
        ///     Updates the configuration of the longegration. The configuration depends on the type of longegration.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/longegrations/update-longegration-86843 </para>
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="silent"></param>
        /// <param name="config"></param>
        public async Task<dynamic> Updatelongegration(long appId, bool? silent, dynamic config)
        {
            string url = string.Format("/longegration/{0}", appId);
            dynamic requestData = new
            {
                silent = silent,
                config = config
            };
            return await  _podio.Put<dynamic>(url, requestData);
        }

        /// <summary>
        ///     Updates the mapping between the fields of the app and the fields available from the longegration.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/longegrations/update-longegration-mapping-86865 </para>
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="fields"> Field id and the external id for the given field id</param>
        public async Task<dynamic> UpdatelongegrationMapping(long appId, Dictionary<long, string> fields)
        {
            string url = string.Format("/longegration/{0}/mapping", appId);
            return await  _podio.Put<dynamic>(url, fields);
        }
    }
}