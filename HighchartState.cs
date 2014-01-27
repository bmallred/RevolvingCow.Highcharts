using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart state.
    /// </summary>
    [DataContract]
    public class HighchartState
    {
        /// <summary>
        /// Gets or sets a value indicating whether the state is enabled.
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false, IsRequired = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the fill color.
        /// </summary>
        [DataMember(Name = "fillColor", EmitDefaultValue = false, IsRequired = false)]
        public string FillColor { get; set; }
        
        /// <summary>
        /// Gets or sets the line color.
        /// </summary>
        [DataMember(Name = "lineColor", EmitDefaultValue = false, IsRequired = false)]
        public string LineColor { get; set; }

        /// <summary>
        /// Gets or sets the line width.
        /// </summary>
        [DataMember(Name = "lineWidth", EmitDefaultValue = false, IsRequired = false)]
        public int LineWidth { get; set; }

        /// <summary>
        /// Gets or sets the radius.
        /// </summary>
        [DataMember(Name = "radius", EmitDefaultValue = false, IsRequired = false)]
        public int Radius { get; set; }
    }
}