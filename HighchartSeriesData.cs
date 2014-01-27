using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart series data.
    /// </summary>
    [DataContract]
    public class HighchartSeriesData
    {
        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false, IsRequired = false)]
        public string Color { get; set; }
        
        /// <summary>
        /// Gets or sets the data labels.
        /// </summary>
        [DataMember(Name = "dataLabels", EmitDefaultValue = false, IsRequired = false)]
        public HighchartDataLabel DataLabels { get; set; }

        /// <summary>
        /// Gets or sets the  drill down.
        /// </summary>
        [DataMember(Name = "drilldown", EmitDefaultValue = false, IsRequired = false)]
        public string Drilldown { get; set; }

        /// <summary>
        /// Gets or sets the events.
        /// </summary>
        [DataMember(Name = "events", EmitDefaultValue = false, IsRequired = false)]
        public HighchartSeriesDataEvent Events { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the legen index.
        /// </summary>
        [DataMember(Name = "legendIndex", EmitDefaultValue = false, IsRequired = false)]
        public int LegendIndex { get; set; }

        /// <summary>
        /// Gets or sets the marker.
        /// </summary>
        [DataMember(Name = "marker", EmitDefaultValue = false, IsRequired = false)]
        public HighchartSeriesDataMarker Marker { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the data is sliced.
        /// </summary>
        [DataMember(Name = "sliced", EmitDefaultValue = false, IsRequired = false)]
        public bool Sliced { get; set; }

        /// <summary>
        /// Gets or sets the X value.
        /// </summary>
        [DataMember(Name = "x", EmitDefaultValue = false, IsRequired = false)]
        public int X { get; set; }
        
        /// <summary>
        /// Gets or sets the Y value.
        /// </summary>
        [DataMember(Name = "y", EmitDefaultValue = false, IsRequired = false)]
        public int Y { get; set; }
    }
}