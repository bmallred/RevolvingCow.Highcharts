using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart button options.
    /// </summary>
    [DataContract]
    public class HighchartButtonOptions
    {
        /// <summary>
        /// Gets or sets the alignment.
        /// </summary>
        [DataMember(Name = "align", EmitDefaultValue = false, IsRequired = false)]
        public string Align { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the button is enabled.
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false, IsRequired = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = false, IsRequired = false)]
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the symbol filling.
        /// </summary>
        [DataMember(Name = "symbolFill", EmitDefaultValue = false, IsRequired = false)]
        public string SymbolFill { get; set; }

        /// <summary>
        /// Gets or sets the symbol stroke balue.
        /// </summary>
        [DataMember(Name = "symbolStoke", EmitDefaultValue = false, IsRequired = false)]
        public string SymbolStroke { get; set; }

        /// <summary>
        /// Gets or sets the symbol stroke width.
        /// </summary>
        [DataMember(Name = "symbolStrokeWidth", EmitDefaultValue = false, IsRequired = false)]
        public int SymbolStrokeWidth { get; set; }

        /// <summary>
        /// Gets or sets the X symbol.
        /// </summary>
        [DataMember(Name = "symbolX", EmitDefaultValue = false, IsRequired = false)]
        public double SymbolX { get; set; }

        /// <summary>
        /// Gets or sets the Y symbol.
        /// </summary>
        [DataMember(Name = "symbolY", EmitDefaultValue = false, IsRequired = false)]
        public double SymbolY { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = false, IsRequired = false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the theme.
        /// </summary>
        [DataMember(Name = "theme", EmitDefaultValue = false, IsRequired = false)]
        public string Theme { get; set; }

        /// <summary>
        /// Gets or sets the vertical alignment.
        /// </summary>
        [DataMember(Name = "verticalAlign", EmitDefaultValue = false, IsRequired = false)]
        public string VerticalAlign { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false, IsRequired = false)]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the Y value.
        /// </summary>
        [DataMember(Name = "y", EmitDefaultValue = false, IsRequired = false)]
        public int Y { get; set; }
    }
}