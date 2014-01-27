using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart axis labels.
    /// </summary>
    [DataContract]
    public class HighchartAxisLabels
    {
        /// <summary>
        /// Gets or sets the align value.
        /// </summary>
        [DataMember(Name = "align", EmitDefaultValue = false, IsRequired = false)]
        public string Align { get; set; }

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
        /// Gets or sets the maximum number of stagger lines.
        /// </summary>
        [DataMember(Name = "maxStaggerLines", EmitDefaultValue = false, IsRequired = false)]
        public int MaxStaggerLines { get; set; }

        /// <summary>
        /// Gets or sets the overflow value.
        /// </summary>
        [DataMember(Name = "overflow", EmitDefaultValue = false, IsRequired = false)]
        public string Overflow { get; set; }

        /// <summary>
        /// Gets or sets the rotation.
        /// </summary>
        [DataMember(Name = "rotation", EmitDefaultValue = false, IsRequired = false)]
        public int Rotation { get; set; }

        /// <summary>
        /// Gets or sets the stagger lines value.
        /// </summary>
        [DataMember(Name = "staggerLines", EmitDefaultValue = false, IsRequired = false)]
        public int StaggerLines { get; set; }

        /// <summary>
        /// Gets or sets the step value.
        /// </summary>
        [DataMember(Name = "step", EmitDefaultValue = false, IsRequired = false)]
        public int Step { get; set; }

        /// <summary>
        /// Gets or sets the CSS style.
        /// </summary>
        [DataMember(Name = "style", EmitDefaultValue = false, IsRequired = false)]
        public string Style { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use HTML.
        /// </summary>
        [DataMember(Name = "useHTML", EmitDefaultValue = false, IsRequired = false)]
        public bool UseHTML { get; set; }

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