using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart tooltip.
    /// </summary>
    [DataContract]
    public class HighchartTooltip
    {
        /// <summary>
        /// Gets or sets a value indicating whether to use animation.
        /// </summary>
        [DataMember(Name = "animation", EmitDefaultValue = false, IsRequired = false)]
        public bool Animation { get; set; }

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
        /// Gets or sets the border width.
        /// </summary>
        [DataMember(Name = "borderWidth", EmitDefaultValue = false, IsRequired = false)]
        public int BorderWidth { get; set; }

        /// <summary>
        /// Gets or sets the crosshairs.
        /// </summary>
        [DataMember(Name = "crosshairs", EmitDefaultValue = false, IsRequired = false)]
        public string Crosshairs { get; set; }

        /// <summary>
        /// Gets or sets the date time label formats.
        /// </summary>
        [DataMember(Name = "dateTimeLabelFormats", EmitDefaultValue = false, IsRequired = false)]
        public string DateTimeLabelFormats { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the tooltip is enabled.
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false, IsRequired = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to follow the pointer as it moves.
        /// </summary>
        [DataMember(Name = "followPointer", EmitDefaultValue = false, IsRequired = false)]
        public bool FollowPointer { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to follow the finger as it moves.
        /// </summary>
        [DataMember(Name = "followTouchMove", EmitDefaultValue = false, IsRequired = false)]
        public bool FollowTouchMove { get; set; }

        /// <summary>
        /// Gets or sets the footer format.
        /// </summary>
        [DataMember(Name = "footerFormat", EmitDefaultValue = false, IsRequired = false)]
        public string FooterFormat { get; set; }

        /// <summary>
        /// Gets or sets the formatter function.
        /// </summary>
        [DataMember(Name = "formatter", EmitDefaultValue = false, IsRequired = false)]
        public string Formatter { get; set; }

        /// <summary>
        /// Gets or sets the header format.
        /// </summary>
        [DataMember(Name = "headerFormat", EmitDefaultValue = false, IsRequired = false)]
        public string HeaderFormat { get; set; }

        /// <summary>
        /// Gets or sets the hide delay.
        /// </summary>
        [DataMember(Name = "hideDelay", EmitDefaultValue = false, IsRequired = false)]
        public int HideDelay { get; set; }

        /// <summary>
        /// Gets or sets the point format.
        /// </summary>
        [DataMember(Name = "pointFormat", EmitDefaultValue = false, IsRequired = false)]
        public string PointFormat { get; set; }

        /// <summary>
        /// Gets or sets the positioner function.
        /// </summary>
        [DataMember(Name = "positioner", EmitDefaultValue = false, IsRequired = false)]
        public string Positioner { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use a shadow.
        /// </summary>
        [DataMember(Name = "shadow", EmitDefaultValue = false, IsRequired = false)]
        public bool Shadow { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the tooltip is shared.
        /// </summary>
        [DataMember(Name = "shared", EmitDefaultValue = false, IsRequired = false)]
        public bool Shared { get; set; }

        /// <summary>
        /// Gets or sets the snap value.
        /// </summary>
        [DataMember(Name = "snap", EmitDefaultValue = false, IsRequired = false)]
        public int Snap { get; set; }

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
        /// Gets or sets the number of decimals to display.
        /// </summary>
        [DataMember(Name = "valueDecimals", EmitDefaultValue = false, IsRequired = false)]
        public int ValueDecimals { get; set; }

        /// <summary>
        /// Gets or sets the value prefix.
        /// </summary>
        [DataMember(Name = "valuePrefix", EmitDefaultValue = false, IsRequired = false)]
        public string ValuePrefix { get; set; }

        /// <summary>
        /// Gets or sets the value suffix.
        /// </summary>
        [DataMember(Name = "valueSuffix", EmitDefaultValue = false, IsRequired = false)]
        public string ValueSuffix { get; set; }

        /// <summary>
        /// Gets or sets the x-axis date format.
        /// </summary>
        [DataMember(Name = "xDateFormat", EmitDefaultValue = false, IsRequired = false)]
        public string XDateFormat { get; set; }
    }
}