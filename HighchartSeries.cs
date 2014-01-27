using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart series.
    /// </summary>
    [DataContract]
    public class HighchartSeries
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [DataMember(Name = "Data", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<HighchartSeriesData> Data { get; set; }

        /// <summary>
        /// Gets or sets the data parser.
        /// </summary>
        [DataMember(Name = "dataParser", EmitDefaultValue = false, IsRequired = false)]
        public string DataParser { get; set; }

        /// <summary>
        /// Gets or sets the data URL.
        /// </summary>
        [DataMember(Name = "dataURL", EmitDefaultValue = false, IsRequired = false)]
        public string DataURL { get; set; }

        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false, IsRequired = false)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or sets the legend index.
        /// </summary>
        [DataMember(Name = "legendIndex", EmitDefaultValue = false, IsRequired = false)]
        public int LegendIndex { get; set; }

        /// <summary>
        /// Gets or sets the series name.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the stack.
        /// </summary>
        [DataMember(Name = "stack", EmitDefaultValue = false, IsRequired = false)]
        public string Stack { get; set; }

        /// <summary>
        /// Gets or sets the series type.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false, IsRequired = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the x-axis.
        /// </summary>
        [DataMember(Name = "xAxis", EmitDefaultValue = false, IsRequired = false)]
        public string XAxis { get; set; }

        /// <summary>
        /// Gets or sets the y-axis.
        /// </summary>
        [DataMember(Name = "yAxis", EmitDefaultValue = false, IsRequired = false)]
        public string YAxis { get; set; }

        /// <summary>
        /// Gets or sets the z-index.
        /// </summary>
        [DataMember(Name = "zIndex", EmitDefaultValue = false, IsRequired = false)]
        public int ZIndex { get; set; }
    }
}