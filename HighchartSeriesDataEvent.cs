using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart series data event.
    /// </summary>
    [DataContract]
    public class HighchartSeriesDataEvent
    {
        /// <summary>
        /// Gets or sets the click function.
        /// </summary>
        [DataMember(Name = "click", EmitDefaultValue = false, IsRequired = false)]
        public string Click { get; set; }

        /// <summary>
        /// Gets or sets the mouse out function.
        /// </summary>
        [DataMember(Name = "mouseOut", EmitDefaultValue = false, IsRequired = false)]
        public string MouseOut { get; set; }

        /// <summary>
        /// Gets or sets the mouse over function.
        /// </summary>
        [DataMember(Name = "mouseOver", EmitDefaultValue = false, IsRequired = false)]
        public string MouseOver { get; set; }

        /// <summary>
        /// Gets or sets the remove function.
        /// </summary>
        [DataMember(Name = "remove", EmitDefaultValue = false, IsRequired = false)]
        public string Remove { get; set; }

        /// <summary>
        /// Gets or sets the select function.
        /// </summary>
        [DataMember(Name = "select", EmitDefaultValue = false, IsRequired = false)]
        public string Select { get; set; }

        /// <summary>
        /// Gets or sets the unselect function.
        /// </summary>
        [DataMember(Name = "unselect", EmitDefaultValue = false, IsRequired = false)]
        public string Unselect { get; set; }

        /// <summary>
        /// Gets or sets the update function.
        /// </summary>
        [DataMember(Name = "update", EmitDefaultValue = false, IsRequired = false)]
        public string Update { get; set; }
    }
}