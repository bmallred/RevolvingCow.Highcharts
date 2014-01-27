using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart legend title.
    /// </summary>
    [DataContract]
    public class HighchartLegendTitle
    {
        /// <summary>
        /// Gets or sets the CSS style.
        /// </summary>
        [DataMember(Name = "style", EmitDefaultValue = false, IsRequired = false)]
        public string Style { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = false, IsRequired = false)]
        public string Text { get; set; }
    }
}