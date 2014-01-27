using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart label item.
    /// </summary>
    [DataContract]
    public class HighchartLabelItem
    {
        /// <summary>
        /// Gets or sets the HTML.
        /// </summary>
        [DataMember(Name = "html", EmitDefaultValue = false, IsRequired = false)]
        public string Html { get; set; }

        /// <summary>
        /// Gets or sets the CSS style.
        /// </summary>
        [DataMember(Name = "style", EmitDefaultValue = false, IsRequired = false)]
        public string Style { get; set; }
    }
}