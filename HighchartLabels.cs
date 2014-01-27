using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart labels.
    /// </summary>
    [DataContract]
    public class HighchartLabels
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<HighchartLabelItem> Items { get; set; }

        /// <summary>
        /// Gets or sets the CSS style.
        /// </summary>
        [DataMember(Name = "style", EmitDefaultValue = false, IsRequired = false)]
        public string Style { get; set; }
    }
}