using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart button.
    /// </summary>
    [DataContract]
    public class HighchartButton
    {
        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        [DataMember(Name = "Position", EmitDefaultValue = false, IsRequired = false)]
        public string Position { get; set; }

        /// <summary>
        /// Gets or sets the relative to value.
        /// </summary>
        [DataMember(Name = "relativeTo", EmitDefaultValue = false, IsRequired = false)]
        public string RelativeTo { get; set; }

        /// <summary>
        /// Gets or sets the theme.
        /// </summary>
        [DataMember(Name = "theme", EmitDefaultValue = false, IsRequired = false)]
        public string Theme { get; set; }
    }
}