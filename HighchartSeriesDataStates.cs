using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart series data states.
    /// </summary>
    [DataContract]
    public class HighchartSeriesDataStates
    {
        /// <summary>
        /// Gets or sets the hover state.
        /// </summary>
        [DataMember(Name = "hover", EmitDefaultValue = false, IsRequired = false)]
        public HighchartState Hover { get; set; }

        /// <summary>
        /// Gets or sets the select state.
        /// </summary>
        [DataMember(Name = "select", EmitDefaultValue = false, IsRequired = false)]
        public HighchartState Select { get; set; }
    }
}