using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart data label.
    /// </summary>
    [DataContract]
    public class HighchartDataLabel
    {
        /// <summary>
        /// Gets or sets the alignment.
        /// </summary>
        [DataMember(Name = "align", EmitDefaultValue = false, IsRequired = false)]
        public string Align { get; set; }

        /// <summary>
        /// Gets or sets the background color.
        /// </summary>
        [DataMember(Name = "backgroundColor", EmitDefaultValue = false, IsRequired = false)]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the border color.
        /// </summary>
        [DataMember(Name = "borderColor", EmitDefaultValue = false, IsRequired = false)]
        public string BorderColor { get; set; }

        /// <summary>
        /// Gets or sets the border radius.
        /// </summary>
        [DataMember(Name = "borderRadius", EmitDefaultValue = false, IsRequired = false)]
        public int BorderRadius { get; set; }

        /// <summary>
        /// Gets or sets the border width.
        /// </summary>
        [DataMember(Name = "borderWidth", EmitDefaultValue = false, IsRequired = false)]
        public int BorderWidth { get; set; }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false, IsRequired = false)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to crop.
        /// </summary>
        [DataMember(Name = "crop", EmitDefaultValue = false, IsRequired = false)]
        public bool Crop { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the label is enabled.
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false, IsRequired = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the format.
        /// </summary>
        [DataMember(Name = "format", EmitDefaultValue = false, IsRequired = false)]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets the formatter.
        /// </summary>
        [DataMember(Name = "formatter", EmitDefaultValue = false, IsRequired = false)]
        public string Formatter { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the label is inside.
        /// </summary>
        [DataMember(Name = "inside", EmitDefaultValue = false, IsRequired = false)]
        public bool Inside { get; set; }

        /// <summary>
        /// Gets or sets the overflow.
        /// </summary>
        [DataMember(Name = "overflow", EmitDefaultValue = false, IsRequired = false)]
        public string Overflow { get; set; }

        /// <summary>
        /// Gets or sets the padding.
        /// </summary>
        [DataMember(Name = "padding", EmitDefaultValue = false, IsRequired = false)]
        public int Padding { get; set; }

        /// <summary>
        /// Gets or sets the rotation.
        /// </summary>
        [DataMember(Name = "rotation", EmitDefaultValue = false, IsRequired = false)]
        public int Rotation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use a shadow.
        /// </summary>
        [DataMember(Name = "shadow", EmitDefaultValue = false, IsRequired = false)]
        public bool Shadow { get; set; }

        /// <summary>
        /// Gets or sets the style.
        /// </summary>
        [DataMember(Name = "style", EmitDefaultValue = false, IsRequired = false)]
        public string Style { get; set; }

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

        /// <summary>
        /// Gets or sets the z-index.
        /// </summary>
        [DataMember(Name = "zIndex", EmitDefaultValue = false, IsRequired = false)]
        public int ZIndex { get; set; }
    }
}