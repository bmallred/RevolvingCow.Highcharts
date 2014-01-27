using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart credits.
    /// </summary>
    [DataContract]
    public class HighchartCredits
    {
        /// <summary>
        /// Gets or sets a value indicating whether the credits are enabled.
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false, IsRequired = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the hyperlink reference.
        /// </summary>
        [DataMember(Name = "href", EmitDefaultValue = false, IsRequired = false)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false, IsRequired = false)]
        public string Position { get; set; }

        /// <summary>
        /// Gets or sets the CSS style.
        /// </summary>
        [DataMember(Name = "style", EmitDefaultValue = false, IsRequired = false)]
        public string Style { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = false, IsRequired = false)]
        public string Text { get; set; }
    }
}