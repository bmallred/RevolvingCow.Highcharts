using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart label.
    /// </summary>
    [DataContract]
    public class HighchartLabel
    {
        /// <summary>
        /// Gets or sets the alignment.
        /// </summary>
        [DataMember(Name = "align", EmitDefaultValue = false, IsRequired = false)]
        public string Align { get; set; }

        /// <summary>
        /// Gets or sets the rotation.
        /// </summary>
        [DataMember(Name = "rotation", EmitDefaultValue = false, IsRequired = false)]
        public int Rotation { get; set; }

        /// <summary>
        /// Gets or sets the style.
        /// </summary>
        [DataMember(Name = "style", EmitDefaultValue = false, IsRequired = false)]
        public string Style { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = false, IsRequired = false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the text alignment.
        /// </summary>
        [DataMember(Name = "textAlign", EmitDefaultValue = false, IsRequired = false)]
        public string TextAlign { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use HTML.
        /// </summary>
        [DataMember(Name = "useHTML", EmitDefaultValue = false, IsRequired = false)]
        public bool UseHTML { get; set; }

        /// <summary>
        /// Gets or sets the vertical alignment.
        /// </summary>
        [DataMember(Name = "verticalAlign", EmitDefaultValue = false, IsRequired = false)]
        public string VerticalAlign { get; set; }

        /// <summary>
        /// Gets or sets the X value.
        /// </summary>
        [DataMember(Name = "x", EmitDefaultValue = false, IsRequired = false)]
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the Y value.
        /// </summary>
        [DataMember(Name = "y", EmitDefaultValue = false, IsRequired = false)]
        public int Y { get; set; }
    }
}