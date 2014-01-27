using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart chart events.
    /// </summary>
    [DataContract]
    public class HighchartChartEvents
    {
        /// <summary>
        /// Gets or sets the add series function.
        /// </summary>
        [DataMember(Name = "addSeries", EmitDefaultValue = false, IsRequired = false)]
        public string AddSeries { get; set; }

        /// <summary>
        /// Gets or sets the click function.
        /// </summary>
        [DataMember(Name = "click", EmitDefaultValue = false, IsRequired = false)]
        public string Click { get; set; }

        /// <summary>
        /// Gets or sets the drill down function.
        /// </summary>
        [DataMember(Name = "drilldown", EmitDefaultValue = false, IsRequired = false)]
        public string DrillDown { get; set; }

        /// <summary>
        /// Gets or sets the drill up function.
        /// </summary>
        [DataMember(Name = "drillup", EmitDefaultValue = false, IsRequired = false)]
        public string DrillUp { get; set; }

        /// <summary>
        /// Gets or sets the load function.
        /// </summary>
        [DataMember(Name = "load", EmitDefaultValue = false, IsRequired = false)]
        public string Load { get; set; }

        /// <summary>
        /// Gets or sets the redraw function.
        /// </summary>
        [DataMember(Name = "redraw", EmitDefaultValue = false, IsRequired = false)]
        public string Redraw { get; set; }

        /// <summary>
        /// Gets or sets the selection function.
        /// </summary>
        [DataMember(Name = "selection", EmitDefaultValue = false, IsRequired = false)]
        public string Selection { get; set; }
    }
}