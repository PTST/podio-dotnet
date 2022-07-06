using PodioAPI.Models;

namespace PodioAPI.Utils.ApplicationFields
{
    public class NumericApplicationField : ApplicationField
    {
        /// <summary>
        ///     The number of decimals displayed
        /// </summary>
        public long? Decimals
        {
            get { return (long?) this.GetSetting("decimals"); }
            set
            {
                InitializeFieldSettings();
                this.internalConfig.Settings["decimals"] = value;
            }
        }
    }
}