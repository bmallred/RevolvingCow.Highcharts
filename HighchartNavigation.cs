using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart navigation.
    /// </summary>
    [DataContract]
    public class HighchartNavigation
    {
        /// <summary>
        /// Gets or sets the button options.
        /// </summary>
        [DataMember(Name = "buttonOptions", EmitDefaultValue = false, IsRequired = false)]
        public HighchartButtonOptions ButtonOptions { get; set; }

        /// <summary>
        /// Gets or sets the menu item hover style.
        /// </summary>
        [DataMember(Name = "menuItemHoverStyle", EmitDefaultValue = false, IsRequired = false)]
        public string MenuItemHoverStyle { get; set; }

        /// <summary>
        /// Gets or sets the menu item style.
        /// </summary>
        [DataMember(Name = "menuItemStyle", EmitDefaultValue = false, IsRequired = false)]
        public string MenuItemStyle { get; set; }

        /// <summary>
        /// Gets or sets the menu style.
        /// </summary>
        [DataMember(Name = "menuStyle", EmitDefaultValue = false, IsRequired = false)]
        public string MenuStyle { get; set; }
    }
}