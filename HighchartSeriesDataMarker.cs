using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart series data marker.
    /// </summary>
    [DataContract]
    public class HighchartSeriesDataMarker : HighchartState
    {
        /// <summary>
        /// Gets or sets the states.
        /// </summary>
        [DataMember(Name = "states", EmitDefaultValue = false, IsRequired = false)]
        public HighchartSeriesDataStates States { get; set; }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        [DataMember(Name = "symbol", EmitDefaultValue = false, IsRequired = false)]
        public string Symbol { get; set; }
    }
}