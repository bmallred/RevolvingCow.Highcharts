using System.Runtime.Serialization;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart chart.
    /// </summary>
    [DataContract]
    public class HighchartChart
    {
        /// <summary>
        /// Gets or sets a value indicating whether to align on the ticks.
        /// </summary>
        [DataMember(Name = "alignTicks", EmitDefaultValue = false, IsRequired = false)]
        public bool AlignTicks { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use animations.
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
        /// Gets or sets the class name.
        /// </summary>
        [DataMember(Name = "className", EmitDefaultValue = false, IsRequired = false)]
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or sets the default series type.
        /// </summary>
        [DataMember(Name = "defaultSeriesType", EmitDefaultValue = false, IsRequired = false)]
        public string DefaultSeriesType { get; set; }

        /// <summary>
        /// Gets or sets the events.
        /// </summary>
        [DataMember(Name = "events", EmitDefaultValue = false, IsRequired = false)]
        public HighchartChartEvents Events { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = false, IsRequired = false)]
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to ignore hidden series.
        /// </summary>
        [DataMember(Name = "ignoreHiddenSeries", EmitDefaultValue = false, IsRequired = false)]
        public bool IgnoreHiddenSeries { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the graph is inverted.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public bool Inverted { get; set; }

        /// <summary>
        /// Gets or sets the margin.
        /// </summary>
        [DataMember(Name = "margin", EmitDefaultValue = false, IsRequired = false)]
        public int[] Margin { get; set; }

        /// <summary>
        /// Gets or sets the bottom margin.
        /// </summary>
        [DataMember(Name = "marginBottom", EmitDefaultValue = false, IsRequired = false)]
        public int MarginBottom { get; set; }

        /// <summary>
        /// Gets or sets the left margin.
        /// </summary>
        [DataMember(Name = "marginLeft", EmitDefaultValue = false, IsRequired = false)]
        public int MarginLeft { get; set; }

        /// <summary>
        /// Gets or sets the right margin.
        /// </summary>
        [DataMember(Name = "marginRight", EmitDefaultValue = false, IsRequired = false)]
        public int MarginRight { get; set; }

        /// <summary>
        /// Gets or sets the top margin.
        /// </summary>
        [DataMember(Name = "marginTop", EmitDefaultValue = false, IsRequired = false)]
        public string MarginTop { get; set; }

        /// <summary>
        /// Gets or sets the pinch type.
        /// </summary>
        [DataMember(Name = "pinchType", EmitDefaultValue = false, IsRequired = false)]
        public string PinchType { get; set; }

        /// <summary>
        /// Gets or sets the plot background color.
        /// </summary>
        [DataMember(Name = "plotBackgroundColor", EmitDefaultValue = false, IsRequired = false)]
        public string PlotBackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the plot background image.
        /// </summary>
        [DataMember(Name = "plotBackgroundImage", EmitDefaultValue = false, IsRequired = false)]
        public string PlotBackgroundImage { get; set; }

        /// <summary>
        /// Gets or sets the plot border color.
        /// </summary>
        [DataMember(Name = "plotBorderColor", EmitDefaultValue = false, IsRequired = false)]
        public string PlotBorderColor { get; set; }

        /// <summary>
        /// Gets or sets the plot border width.
        /// </summary>
        [DataMember(Name = "plotBorderWidth", EmitDefaultValue = false, IsRequired = false)]
        public int PlotBorderWidth { get; set; }

        /// <summary>
        /// Gets or sets the plot border shadow.
        /// </summary>
        [DataMember(Name = "plotBorderShadow", EmitDefaultValue = false, IsRequired = false)]
        public bool PlotBorderShadow { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the chart is polar.
        /// </summary>
        [DataMember(Name = "polar", EmitDefaultValue = false, IsRequired = false)]
        public bool Polar { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the chart is reflow.
        /// </summary>
        [DataMember(Name = "reflow", EmitDefaultValue = false, IsRequired = false)]
        public bool Reflow { get; set; }

        /// <summary>
        /// Gets or sets the render to value.
        /// </summary>
        [DataMember(Name = "renderTo", EmitDefaultValue = false, IsRequired = false)]
        public string RenderTo { get; set; }
        
        /// <summary>
        /// Gets or sets the reset zoom button.
        /// </summary>
        [DataMember(Name = "resetZoomButton", EmitDefaultValue = false, IsRequired = false)]
        public HighchartButton ResetZoomButton { get; set; }

        /// <summary>
        /// Gets or sets the selection marker fill.
        /// </summary>
        [DataMember(Name = "selectionMarkerFill", EmitDefaultValue = false, IsRequired = false)]
        public string SelectionMarkerFill { get; set; }

        /// <summary>
        /// Gets or sets a value indicating to use a shadow.
        /// </summary>
        [DataMember(Name = "shadow", EmitDefaultValue = false, IsRequired = false)]
        public bool Shadow { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show the axes.
        /// </summary>
        [DataMember(Name = "showAxes", EmitDefaultValue = false, IsRequired = false)]
        public bool ShowAxes { get; set; }

        /// <summary>
        /// Gets or sets the spacing.
        /// </summary>
        [DataMember(Name = "spacing", EmitDefaultValue = false, IsRequired = false)]
        public int[] Spacing { get; set; }

        /// <summary>
        /// Gets or sets the bottom spacing.
        /// </summary>
        [DataMember(Name = "spacingBottom", EmitDefaultValue = false, IsRequired = false)]
        public int SpacingBottom { get; set; }

        /// <summary>
        /// Gets or sets the left spacing.
        /// </summary>
        [DataMember(Name = "spacingLeft", EmitDefaultValue = false, IsRequired = false)]
        public int SpacingLeft { get; set; }

        /// <summary>
        /// Gets or sets the right spacing.
        /// </summary>
        [DataMember(Name = "spacingRight", EmitDefaultValue = false, IsRequired = false)]
        public int SpacingRight { get; set; }

        /// <summary>
        /// Gets or sets the top spacing.
        /// </summary>
        [DataMember(Name = "spacingTop", EmitDefaultValue = false, IsRequired = false)]
        public int SpacingTop { get; set; }

        /// <summary>
        /// Gets or sets the CSS style.
        /// </summary>
        [DataMember(Name = "style", EmitDefaultValue = false, IsRequired = false)]
        public string Style { get; set; }

        /// <summary>
        /// Gets or sets the chart type.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false, IsRequired = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false, IsRequired = false)]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the zoom type.
        /// </summary>
        [DataMember(Name = "zoomType", EmitDefaultValue = false, IsRequired = false)]
        public string ZoomType { get; set; }
    }
}