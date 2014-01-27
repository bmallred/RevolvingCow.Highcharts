using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart pane.
    /// </summary>
    [DataContract]
    public class HighchartPane
    {
        /// <summary>
        /// Gets or sets the background.
        /// </summary>
        [DataMember(Name = "background", EmitDefaultValue = false, IsRequired = false)]
        public string Background { get; set; }

        /// <summary>
        /// Gets or sets the center.
        /// </summary>
        [DataMember(Name = "center", EmitDefaultValue = false, IsRequired = false)]
        public string[] Center { get; set; }

        /// <summary>
        /// Gets or sets the end angle.
        /// </summary>
        [DataMember(Name = "endAngle", EmitDefaultValue = false, IsRequired = false)]
        public int EndAngle { get; set; }

        /// <summary>
        /// Gets or sets the start angle.
        /// </summary>
        [DataMember(Name = "startAngle", EmitDefaultValue = false, IsRequired = false)]
        public int StartAngle { get; set; }
    }
}