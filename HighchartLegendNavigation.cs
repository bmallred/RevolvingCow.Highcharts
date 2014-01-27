using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart legend navigation.
    /// </summary>
    [DataContract]
    public class HighchartLegendNavigation
    {
        /// <summary>
        /// Gets or sets the active color.
        /// </summary>
        [DataMember(Name = "activeColor", EmitDefaultValue = false, IsRequired = false)]
        public string ActiveColor { get; set; }

        /// <summary>
        /// Gets or sets a value indicatingg whether to use animation.
        /// </summary>
        [DataMember(Name = "animation", EmitDefaultValue = false, IsRequired = false)]
        public bool Animation { get; set; }

        /// <summary>
        /// Gets or sets the arrow size.
        /// </summary>
        [DataMember(Name = "arrowSize", EmitDefaultValue = false, IsRequired = false)]
        public int ArrowSize { get; set; }

        /// <summary>
        /// Gets or sets the inactive color.
        /// </summary>
        [DataMember(Name = "inactiveColor", EmitDefaultValue = false, IsRequired = false)]
        public string InactiveColor { get; set; }

        /// <summary>
        /// Gets or sets the CSS style.
        /// </summary>
        [DataMember(Name = "style", EmitDefaultValue = false, IsRequired = false)]
        public string Style { get; set; }
    }
}