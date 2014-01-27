using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart plot band.
    /// </summary>
    [DataContract]
    public class HighchartPlotBand
    {
        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false, IsRequired = false)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets the events.
        /// </summary>
        [DataMember(Name = "events", EmitDefaultValue = false, IsRequired = false)]
        public string Events { get; set; }

        /// <summary>
        /// Gets or sets the from value.
        /// </summary>
        [DataMember(Name = "from", EmitDefaultValue = false, IsRequired = false)]
        public int From { get; set; }

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
        /// Gets or sets the to value.
        /// </summary>
        [DataMember(Name = "to", EmitDefaultValue = false, IsRequired = false)]
        public int To { get; set; }

        /// <summary>
        /// Gets or sets the z-index.
        /// </summary>
        [DataMember(Name = "zIndex", EmitDefaultValue = false, IsRequired = false)]
        public int ZIndex { get; set; }
    }
}