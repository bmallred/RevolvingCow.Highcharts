using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart axis event.
    /// </summary>
    [DataContract]
    public class HighchartAxisEvent
    {
        /// <summary>
        /// Gets or sets a function to handle after setting extremes.
        /// </summary>
        [DataMember(Name = "afterSetExtremes", EmitDefaultValue = false, IsRequired = false)]
        public string AfterSetExtremes { get; set; }

        /// <summary>
        /// Gets or sets a function to set extremes.
        /// </summary>
        [DataMember(Name = "setExtremes", EmitDefaultValue = false, IsRequired = false)]
        public string SetExtremes { get; set; }
    }
}