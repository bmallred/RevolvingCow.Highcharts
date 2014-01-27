using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highclass exporting.
    /// </summary>
    [DataContract]
    public class HighchartExporting
    {
        /// <summary>
        /// Gets or sets the buttons.
        /// </summary>
        [DataMember(Name = "buttons", EmitDefaultValue = false, IsRequired = false)]
        public HighchartExportingButtons Buttons { get; set; }

        /// <summary>
        /// Gets or sets the chart options.
        /// </summary>
        [DataMember(Name = "chartOptions", EmitDefaultValue = false, IsRequired = false)]
        public string ChartOptions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether exporting is enabled.
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false, IsRequired = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the file name.
        /// </summary>
        [DataMember(Name = "filename", EmitDefaultValue = false, IsRequired = false)]
        public string Filename { get; set; }

        /// <summary>
        /// Gets or sets the form attributes.
        /// </summary>
        [DataMember(Name = "formAttributes", EmitDefaultValue = false, IsRequired = false)]
        public string FormAttributes { get; set; }

        /// <summary>
        /// Gets or sets the scale.
        /// </summary>
        [DataMember(Name = "scale", EmitDefaultValue = false, IsRequired = false)]
        public int Scale { get; set; }

        /// <summary>
        /// Gets or sets the source height.
        /// </summary>
        [DataMember(Name = "sourceHeight", EmitDefaultValue = false, IsRequired = false)]
        public int SourceHeight { get; set; }

        /// <summary>
        /// Gets or sets the source width.
        /// </summary>
        [DataMember(Name = "sourceWidth", EmitDefaultValue = false, IsRequired = false)]
        public int SourceWidth { get; set; }

        /// <summary>
        /// Gets or sets the export type.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false, IsRequired = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false, IsRequired = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false, IsRequired = false)]
        public int Width { get; set; }
    }
}