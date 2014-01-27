using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart exporting context button.
    /// </summary>
    [DataContract]
    public class HighchartExportingContextButton : HighchartButtonOptions
    {
        /// <summary>
        /// Gets or sets the menu items.
        /// </summary>
        [DataMember(Name = "menuItems", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<string> MenuItems { get; set; }

        /// <summary>
        /// Gets or sets the OnClick function.
        /// </summary>
        [DataMember(Name = "onclick", EmitDefaultValue = false, IsRequired = false)]
        public string OnClick { get; set; }

        /// <summary>
        /// Gets or sets the symbol size.
        /// </summary>
        [DataMember(Name = "symbolSize", EmitDefaultValue = false, IsRequired = false)]
        public int SymbolSize { get; set; }
    }
}