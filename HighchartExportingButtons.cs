using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart exporting buttons.
    /// </summary>
    [DataContract]
    public class HighchartExportingButtons
    {
        /// <summary>
        /// Gets or sets the context button.
        /// </summary>
        [DataMember(Name = "contextButton", EmitDefaultValue = false, IsRequired = false)]
        public HighchartExportingContextButton ContextButton { get; set; }
    }
}