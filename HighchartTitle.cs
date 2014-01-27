using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart title.
    /// </summary>
    [DataContract]
    public class HighchartTitle : HighchartSubtitle
    {
        /// <summary>
        /// Gets or sets the margin.
        /// </summary>
        [DataMember(Name = "margin", EmitDefaultValue = false, IsRequired = false)]
        public string Margin { get; set; }
    }
}