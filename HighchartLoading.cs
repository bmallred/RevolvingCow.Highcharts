using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart loading.
    /// </summary>
    [DataContract]
    public class HighchartLoading
    {
        /// <summary>
        /// Gets or sets the hide duration.
        /// </summary>
        [DataMember(Name = "hideDuration", EmitDefaultValue = false, IsRequired = false)]
        public int HideDuration { get; set; }

        /// <summary>
        /// Gets or sets the label style.
        /// </summary>
        [DataMember(Name = "labelStyle", EmitDefaultValue = false, IsRequired = false)]
        public string LabelStyle { get; set; }

        /// <summary>
        /// Gets or sets the show duration.
        /// </summary>
        [DataMember(Name = "showDuration", EmitDefaultValue = false, IsRequired = false)]
        public int ShowDuration { get; set; }

        /// <summary>
        /// Gets or sets the CSS style.
        /// </summary>
        [DataMember(Name = "style", EmitDefaultValue = false, IsRequired = false)]
        public string Style { get; set; }
    }
}