using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart Drilldown.
    /// </summary>
    [DataContract]
    public class HighchartDrilldown
    {
        /// <summary>
        /// Gets or sets the active axis label style.
        /// </summary>
        [DataMember(Name = "activeAxisLabelStyle", EmitDefaultValue = false, IsRequired = false)]
        public string ActiveAxisLabelStyle { get; set; }

        /// <summary>
        /// Gets or sets the active data label style.
        /// </summary>
        [DataMember(Name = "activeDataLabelStye", EmitDefaultValue = false, IsRequired = false)]
        public string ActiveDataLabelStyle { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use an animation.
        /// </summary>
        [DataMember(Name = "animation", EmitDefaultValue = false, IsRequired = false)]
        public bool Animation { get; set; }

        /// <summary>
        /// Gets or sets the drill up button.
        /// </summary>
        [DataMember(Name = "drillUpButton", EmitDefaultValue = false, IsRequired = false)]
        public HighchartButton DrillUpButton { get; set; }

        /// <summary>
        /// Gets or sets the series.
        /// </summary>
        [DataMember(Name = "series", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<HighchartSeries> Series { get; set; }
    }
}