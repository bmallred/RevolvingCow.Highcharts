using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart plot line.
    /// </summary>
    [DataContract]
    public class HighchartPlotLine
    {
        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false, IsRequired = false)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets the dash style.
        /// </summary>
        [DataMember(Name = "dashStyle", EmitDefaultValue = false, IsRequired = false)]
        public string DashStyle { get; set; }

        /// <summary>
        /// Gets or sets the events.
        /// </summary>
        [DataMember(Name = "events", EmitDefaultValue = false, IsRequired = false)]
        public string Events { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false, IsRequired = false)]
        public HighchartLabel Label { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false, IsRequired = false)]
        public int Value { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false, IsRequired = false)]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the z-index.
        /// </summary>
        [DataMember(Name = "zIndex", EmitDefaultValue = false, IsRequired = false)]
        public int ZIndex { get; set; }
    }
}