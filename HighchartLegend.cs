using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart legend.
    /// </summary>
    [DataContract]
    public class HighchartLegend
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
        /// Gets or sets a value indicating whether the legend is enabled.
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false, IsRequired = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the legend should float.
        /// </summary>
        [DataMember(Name = "floating", EmitDefaultValue = false, IsRequired = false)]
        public bool Floating { get; set; }

        /// <summary>
        /// Gets or sets the item distance.
        /// </summary>
        [DataMember(Name = "itemDistance", EmitDefaultValue = false, IsRequired = false)]
        public int ItemDistance { get; set; }

        /// <summary>
        /// Gets or sets the item hidden style.
        /// </summary>
        [DataMember(Name = "itemHiddenStyle", EmitDefaultValue = false, IsRequired = false)]
        public string ItemHiddenStyle { get; set; }

        /// <summary>
        /// Gets or sets the item hover style.
        /// </summary>
        [DataMember(Name = "itemHoverStyle", EmitDefaultValue = false, IsRequired = false)]
        public string ItemHoverStyle { get; set; }

        /// <summary>
        /// Gets or sets the item margin bottom.
        /// </summary>
        [DataMember(Name = "itemMarginBottom", EmitDefaultValue = false, IsRequired = false)]
        public int ItemMarginBottom { get; set; }

        /// <summary>
        /// Gets or sets the item margin top.
        /// </summary>
        [DataMember(Name = "itemMarginTop", EmitDefaultValue = false, IsRequired = false)]
        public int ItemMarginTop { get; set; }

        /// <summary>
        /// Gets or sets the item style.
        /// </summary>
        [DataMember(Name = "itemStyle", EmitDefaultValue = false, IsRequired = false)]
        public string ItemStyle { get; set; }

        /// <summary>
        /// Gets or sets the item width.
        /// </summary>
        [DataMember(Name = "itemWidth", EmitDefaultValue = false, IsRequired = false)]
        public int ItemWidth { get; set; }

        /// <summary>
        /// Gets or sets the label format.
        /// </summary>
        [DataMember(Name = "labelFormat", EmitDefaultValue = false, IsRequired = false)]
        public string LabelFormat { get; set; }

        /// <summary>
        /// Gets or sets the label formatter.
        /// </summary>
        [DataMember(Name = "labelFormatter", EmitDefaultValue = false, IsRequired = false)]
        public string LabelFormatter { get; set; }

        /// <summary>
        /// Gets or sets the layout.
        /// </summary>
        [DataMember(Name = "layout", EmitDefaultValue = false, IsRequired = false)]
        public string Layout { get; set; }

        /// <summary>
        /// Gets or sets the line height.
        /// </summary>
        [DataMember(Name = "lineHeight", EmitDefaultValue = false, IsRequired = false)]
        public int LineHeight { get; set; }

        /// <summary>
        /// Gets or sets the margin.
        /// </summary>
        [DataMember(Name = "margin", EmitDefaultValue = false, IsRequired = false)]
        public int Margin { get; set; }

        /// <summary>
        /// Gets or sets the maximum height.
        /// </summary>
        [DataMember(Name = "maxHeight", EmitDefaultValue = false, IsRequired = false)]
        public int MaxHeight { get; set; }

        /// <summary>
        /// Gets or sets the navigation.
        /// </summary>
        [DataMember(Name = "navigation", EmitDefaultValue = false, IsRequired = false)]
        public HighchartLegendNavigation Navigation { get; set; }

        /// <summary>
        /// Gets or sets the padding.
        /// </summary>
        [DataMember(Name = "padding", EmitDefaultValue = false, IsRequired = false)]
        public int Padding { get; set; }

        /// <summary>
        /// Gets or sets a value whether the legend is reversed.
        /// </summary>
        [DataMember(Name = "reversed", EmitDefaultValue = false, IsRequired = false)]
        public bool Reversed { get; set; }

        /// <summary>
        /// Gets or sets a value whether to use right-to-left text.
        /// </summary>
        [DataMember(Name = "rtl", EmitDefaultValue = false, IsRequired = false)]
        public bool Rtl { get; set; }

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
        /// Gets or sets the symbol height.
        /// </summary>
        [DataMember(Name = "symbolHeight", EmitDefaultValue = false, IsRequired = false)]
        public int SymbolHeight { get; set; }

        /// <summary>
        /// Gets or sets the symbol padding.
        /// </summary>
        [DataMember(Name = "symbolPadding", EmitDefaultValue = false, IsRequired = false)]
        public int SymbolPadding { get; set; }

        /// <summary>
        /// Gets or sets the symbol radius.
        /// </summary>
        [DataMember(Name = "symbolRadius", EmitDefaultValue = false, IsRequired = false)]
        public int SymbolRadius { get; set; }

        /// <summary>
        /// Gets or sets the symbol width.
        /// </summary>
        [DataMember(Name = "symbolWidth", EmitDefaultValue = false, IsRequired = false)]
        public int SymbolWidth { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false, IsRequired = false)]
        public HighchartLegendTitle Title { get; set; }

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
        /// Gets or sets the width.
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false, IsRequired = false)]
        public int Width { get; set; }

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