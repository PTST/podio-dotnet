using PodioAPI.Models;
using System.Threading.Tasks;

namespace PodioAPI.Services
{
    public class SubscriptionService
    {
        private readonly Podio _podio;

        public SubscriptionService(Podio currentInstance)
        {
            _podio = currentInstance;
        }

        /// <summary>
        ///     Returns the subscription with the given id.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/subscriptions/get-subscription-by-id-22446 </para>
        /// </summary>
        /// <param name="subscriptionId"></param>
        /// <returns></returns>
        public async Task<Subscription> GetSubscriptionById(long subscriptionId)
        {
            string url = string.Format("/subscription/{0}", subscriptionId);
            return await  _podio.Get<Subscription>(url);
        }

        /// <summary>
        ///     Subscribes the user to the given object. Based on the object type, the user will receive notifications when actions
        ///     are performed on the object. See the area for more details.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/subscriptions/subscribe-22409 </para>
        /// </summary>
        /// <param name="refType"></param>
        /// <param name="refId"></param>
        /// <returns></returns>
        public async Task<long> Subscribe(string refType, long refId)
        {
            string url = string.Format("/subscription/{0}/{1}", refType, refId);
            dynamic response = await  _podio.Post<dynamic>(url);
            return (long) response["subscription_id"];
        }

        /// <summary>
        ///     Unsubscribe from getting notifications on actions on the given object.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/subscriptions/unsubscribe-by-reference-22410 </para>
        /// </summary>
        /// <param name="refType"></param>
        /// <param name="refId"></param>
        public async Task<dynamic> UnsubscribeByReference(string refType, long refId)
        {
            string url = string.Format("/subscription/{0}/{1}", refType, refId);
            return await  _podio.Delete<dynamic>(url);
        }

        /// <summary>
        ///     Get the subscription for the given object.
        ///     <para>Podio API Reference: https://developers.podio.com/doc/subscriptions/get-subscription-by-reference-22408 </para>
        /// </summary>
        /// <param name="refType"></param>
        /// <param name="refId"></param>
        /// <returns></returns>
        public async Task<Subscription> GetSubscriptionByReference(string refType, long refId)
        {
            string url = string.Format("/subscription/{0}/{1}", refType, refId);
            return await  _podio.Get<Subscription>(url);
        }

        /// <summary>
        ///     Stops the subscription with the given id
        ///     <para>Podio API Reference: https://developers.podio.com/doc/subscriptions/unsubscribe-by-id-22445 </para>
        /// </summary>
        /// <param name="subscriptionId"></param>
        public async Task<dynamic> UnsubscribeById(long subscriptionId)
        {
            string url = string.Format("/subscription/{0}", subscriptionId);
            return await  _podio.Delete<dynamic>(url);
        }
    }
}