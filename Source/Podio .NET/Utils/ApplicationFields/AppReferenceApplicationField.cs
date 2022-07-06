using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using PodioAPI.Models;

namespace PodioAPI.Utils.ApplicationFields
{
    public class AppReferenceApplicationField : ApplicationField
    {
        private IEnumerable<long> _referenceableTypes;

        /// <summary>
        ///     List of ids of the apps that can be referenced.
        /// </summary>
        public IEnumerable<long> ReferenceableTypes
        {
            get
            {
                if (_referenceableTypes == null)
                {
                    _referenceableTypes = this.GetSettingsAs<long>("referenceable_types");
                }
                return _referenceableTypes;
            }
            set
            {
                InitializeFieldSettings();
                this.internalConfig.Settings["referenceable_types"] = value != null ? JToken.FromObject(value) : null;
            }
        }

        /// <summary>
        ///     True if multiple references should be allowed, False otherwise
        /// </summary>
        public bool Multiple
        {
            get { return (bool)this.GetSetting("multiple"); }
            set
            {
                InitializeFieldSettings();
                this.internalConfig.Settings["multiple"] = value;
            }
        }
    }
}