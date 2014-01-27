using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// The Highchart axis class.
    /// </summary>
    [DataContract]
    public class HighchartAxis
    {
        /// <summary>
        /// Gets or sets a value indicating whether decimal values are allowed.
        /// </summary>
        [DataMember(Name = "allowDecimals", EmitDefaultValue = false, IsRequired = false)]
        public bool AllowDecimals { get; set; }

        /// <summary>
        /// Gets or sets the alternate grid color.
        /// </summary>
        [DataMember(Name = "alternateGridColor", EmitDefaultValue = false, IsRequired = false)]
        public string AlternateGridColor { get; set; }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        [DataMember(Name = "categories", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<string> Categories { get; set; }

        /// <summary>
        /// Gets or sets the date time label formats.
        /// </summary>
        [DataMember(Name = "dateTimeLabelFormats", EmitDefaultValue = false, IsRequired = false)]
        public string DateTimeLabelFormats { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to end on a tick.
        /// </summary>
        [DataMember(Name = "endOnTick", EmitDefaultValue = false, IsRequired = false)]
        public bool EndOnTick { get; set; }

        /// <summary>
        /// Gets or sets the events.
        /// </summary>
        [DataMember(Name = "events", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<HighchartAxisEvent> Events { get; set; }

        /// <summary>
        /// Gets or sets the grid line color.
        /// </summary>
        [DataMember(Name = "gridLineColor", EmitDefaultValue = false, IsRequired = false)]
        public string GridLineColor { get; set; }

        /// <summary>
        /// Gets or sets the grid line dash style.
        /// </summary>
        [DataMember(Name = "gridLineDashStyle", EmitDefaultValue = false, IsRequired = false)]
        public string GridLineDashStyle { get; set; }

        /// <summary>
        /// Gets or sets the grid line width.
        /// </summary>
        [DataMember(Name = "gridLineWidth", EmitDefaultValue = false, IsRequired = false)]
        public int GridLineWidth { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = false, IsRequired = false)]
        public HighchartAxisLabels Labels { get; set; }

        /// <summary>
        /// Gets or sets the line color.
        /// </summary>
        [DataMember(Name = "lineColor", EmitDefaultValue = false, IsRequired = false)]
        public string LineColor { get; set; }

        /// <summary>
        /// Gets or sets the line width.
        /// </summary>
        [DataMember(Name = "lineWidth", EmitDefaultValue = false, IsRequired = false)]
        public int LineWidth { get; set; }

        /// <summary>
        /// Gets or sets the linked to value.
        /// </summary>
        [DataMember(Name = "linkedTo", EmitDefaultValue = false, IsRequired = false)]
        public int LinkedTo { get; set; }

        /// <summary>
        /// Gets or sets the maximum.
        /// </summary>
        [DataMember(Name = "max", EmitDefaultValue = false, IsRequired = false)]
        public int? Max { get; set; }

        /// <summary>
        /// Gets or sets the maximum padding.
        /// </summary>
        [DataMember(Name = "maxPadding", EmitDefaultValue = false, IsRequired = false)]
        public int MaxPadding { get; set; }

        /// <summary>
        /// Gets or sets the maximum zoom.
        /// </summary>
        [DataMember(Name = "maxZoom", EmitDefaultValue = false, IsRequired = false)]
        public int MaxZoom { get; set; }

        /// <summary>
        /// Gets or sets the minimum.
        /// </summary>
        [DataMember(Name = "min", EmitDefaultValue = false, IsRequired = false)]
        public int? Min { get; set; }

        /// <summary>
        /// Gets or sets the minimum padding.
        /// </summary>
        [DataMember(Name = "minPadding", EmitDefaultValue = false, IsRequired = false)]
        public int MinPadding { get; set; }

        /// <summary>
        /// Gets or sets the minimum range.
        /// </summary>
        [DataMember(Name = "minRange", EmitDefaultValue = false, IsRequired = false)]
        public int MinRange { get; set; }

        /// <summary>
        /// Gets or sets the minimum tick interval.
        /// </summary>
        [DataMember(Name = "minTickInterval", EmitDefaultValue = false, IsRequired = false)]
        public int MinTickInterval { get; set; }

        /// <summary>
        /// Gets or sets the minor grid line color.
        /// </summary>
        [DataMember(Name = "minorGridLineColor", EmitDefaultValue = false, IsRequired = false)]
        public string MinorGridLineColor { get; set; }

        /// <summary>
        /// Gets or sets the minor grid line dash color.
        /// </summary>
        [DataMember(Name = "minorGridLineDashColor", EmitDefaultValue = false, IsRequired = false)]
        public string MinorGridLineDashColor { get; set; }

        /// <summary>
        /// Gets or sets the minor grid line width.
        /// </summary>
        [DataMember(Name = "minorGridLineWidth", EmitDefaultValue = false, IsRequired = false)]
        public int MinorGridLineWidth { get; set; }

        /// <summary>
        /// Gets or sets the minor tick color.
        /// </summary>
        [DataMember(Name = "minorTickColor", EmitDefaultValue = false, IsRequired = false)]
        public string MinorTickColor { get; set; }

        /// <summary>
        /// Gets or sets the minor tick interval.
        /// </summary>
        [DataMember(Name = "minorTickInterval", EmitDefaultValue = false, IsRequired = false)]
        public string MinorTickInterval { get; set; }

        /// <summary>
        /// Gets or sets the minor tick length.
        /// </summary>
        [DataMember(Name = "minorTickLength", EmitDefaultValue = false, IsRequired = false)]
        public string MinorTickLength { get; set; }

        /// <summary>
        /// Gets or sets the minor tick position.
        /// </summary>
        [DataMember(Name = "minorTickPosition", EmitDefaultValue = false, IsRequired = false)]
        public string MinorTickPosition { get; set; }

        /// <summary>
        /// Gets or sets the minor tick width.
        /// </summary>
        [DataMember(Name = "minorTickWidth", EmitDefaultValue = false, IsRequired = false)]
        public int MinorTickWidth { get; set; }

        /// <summary>
        /// Gets or sets the offset.
        /// </summary>
        [DataMember(Name = "offset", EmitDefaultValue = false, IsRequired = false)]
        public int Offset { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the axis is opposite.
        /// </summary>
        [DataMember(Name = "opposite", EmitDefaultValue = false, IsRequired = false)]
        public bool Opposite { get; set; }
        
        /// <summary>
        /// Gets or sets the plot bands.
        /// </summary>
        [DataMember(Name = "plotBands", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<HighchartPlotBand> PlotBands { get; set; }

        /// <summary>
        /// Gets or sets the plot lines.
        /// </summary>
        [DataMember(Name = "plotLines", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<HighchartPlotLine> PlotLines { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the values are reversed.
        /// </summary>
        [DataMember(Name = "reversed", EmitDefaultValue = false, IsRequired = false)]
        public bool Reversed { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show empty values.
        /// </summary>
        [DataMember(Name = "showEmpty", EmitDefaultValue = false, IsRequired = false)]
        public bool ShowEmpty { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show the first label.
        /// </summary>
        [DataMember(Name = "showFirstLabel", EmitDefaultValue = false, IsRequired = false)]
        public bool ShowFirstLabel { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show the last label.
        /// </summary>
        [DataMember(Name = "showLastLabel", EmitDefaultValue = false, IsRequired = false)]
        public bool ShowLastLabel { get; set; }

        /// <summary>
        /// Gets or sets the start of the week.
        /// </summary>
        /// <remarks>The value of 0 is Monday.</remarks>
        [DataMember(Name = "startOfWeek", EmitDefaultValue = false, IsRequired = false)]
        public int StartOfWeek { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to start on a tick.
        /// </summary>
        [DataMember(Name = "startOnTick", EmitDefaultValue = false, IsRequired = false)]
        public bool StartOnTick { get; set; }

        /// <summary>
        /// Gets or sets the tick color.
        /// </summary>
        [DataMember(Name = "tickColor", EmitDefaultValue = false, IsRequired = false)]
        public string TickColor { get; set; }

        /// <summary>
        /// Gets or sets the tick interval.
        /// </summary>
        [DataMember(Name = "tickInterval", EmitDefaultValue = false, IsRequired = false)]
        public string TickInterval { get; set; }

        /// <summary>
        /// Gets or sets the tick length.
        /// </summary>
        [DataMember(Name = "tickLength", EmitDefaultValue = false, IsRequired = false)]
        public int TickLength { get; set; }

        /// <summary>
        /// Gets or sets the tick pixel interval.
        /// </summary>
        [DataMember(Name = "tickPixelInterval", EmitDefaultValue = false, IsRequired = false)]
        public string TickPixelInterval { get; set; }

        /// <summary>
        /// Gets or sets the tick position.
        /// </summary>
        [DataMember(Name = "tickPosition", EmitDefaultValue = false, IsRequired = false)]
        public string TickPosition { get; set; }

        /// <summary>
        /// Gets or sets the tick positioner.
        /// </summary>
        [DataMember(Name = "tickPositioner", EmitDefaultValue = false, IsRequired = false)]
        public string TickPositioner { get; set; }

        /// <summary>
        /// Gets or sets the tick positions.
        /// </summary>
        [DataMember(Name = "tickPositions", EmitDefaultValue = false, IsRequired = false)]
        public string TickPositions { get; set; }

        /// <summary>
        /// Gets or sets the tick width.
        /// </summary>
        [DataMember(Name = "tickWidth", EmitDefaultValue = false, IsRequired = false)]
        public string TickWidth { get; set; }

        /// <summary>
        /// Gets or sets the tickmark placement.
        /// </summary>
        [DataMember(Name = "tickmarkPlacement", EmitDefaultValue = false, IsRequired = false)]
        public string TickmarkPlacement { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false, IsRequired = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the axis type.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false, IsRequired = false)]
        public string Type { get; set; }
    }
}