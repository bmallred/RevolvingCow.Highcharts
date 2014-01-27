using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace RevolvingCow.Highcharts
{
    /// <summary>
    /// Highchart graph object.
    /// </summary>
    [DataContract]
    public class Highchart
    {
        /// <summary>
        /// Gets or sets the chart.
        /// </summary>
        [DataMember(Name = "chart", EmitDefaultValue = false, IsRequired = false)]
        public HighchartChart Chart { get; set; }

        /// <summary>
        /// Gets or sets a list of colors.
        /// </summary>
        [DataMember(Name = "colors", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<string> Colors { get; set; }

        /// <summary>
        /// Gets or sets the credits.
        /// </summary>
        [DataMember(Name = "credits", EmitDefaultValue = false, IsRequired = false)]
        public HighchartCredits Credits { get; set; }

        /// <summary>
        /// Gets or sets the drilldown configuration.
        /// </summary>
        [DataMember(Name = "drilldown", EmitDefaultValue = false, IsRequired = false)]
        public HighchartDrilldown Drilldown { get; set; }

        /// <summary>
        /// Gets or sets the exporting options.
        /// </summary>
        [DataMember(Name = "exporting", EmitDefaultValue = false, IsRequired = false)]
        public HighchartExporting Exporting { get; set; }

        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = false, IsRequired = false)]
        public HighchartLabels Labels { get; set; }

        /// <summary>
        /// Gets or sets the legend.
        /// </summary>
        [DataMember(Name = "legend", EmitDefaultValue = false, IsRequired = false)]
        public HighchartLegend Legend { get; set; }

        /// <summary>
        /// Gets or sets the loading options.
        /// </summary>
        [DataMember(Name = "loading", EmitDefaultValue = false, IsRequired = false)]
        public HighchartLoading Loading { get; set; }

        /// <summary>
        /// Gets or sets the navigation.
        /// </summary>
        [DataMember(Name = "navigation", EmitDefaultValue = false, IsRequired = false)]
        public HighchartNavigation Navigation { get; set; }

        /// <summary>
        /// Gets or sets the "no data" options.
        /// </summary>
        /// <remarks>Requires the "no data" plugin.</remarks>
        [DataMember(Name = "noData", EmitDefaultValue = false, IsRequired = false)]
        public HighchartNoData NoData { get; set; }

        /// <summary>
        /// Gets or sets the pane.
        /// </summary>
        [DataMember(Name = "pane", EmitDefaultValue = false, IsRequired = false)]
        public HighchartPane Pane { get; set; }

        /// <summary>
        /// Gets or sets the plot options.
        /// </summary>
        [DataMember(Name = "plotOptions", EmitDefaultValue = false, IsRequired = false)]
        public HighchartPlotOptions PlotOptions { get; set; }

        /// <summary>
        /// Gets or sets the series.
        /// </summary>
        [DataMember(Name = "series", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<HighchartSeries> Series { get; set; }

        /// <summary>
        /// Gets or sets the subtitle.
        /// </summary>
        [DataMember(Name = "subtitle", EmitDefaultValue = false, IsRequired = false)]
        public HighchartSubtitle Subtitle { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false, IsRequired = false)]
        public HighchartTitle Title { get; set; }

        /// <summary>
        /// Gets or sets the tooltip.
        /// </summary>
        [DataMember(Name = "tooltip", EmitDefaultValue = false, IsRequired = false)]
        public HighchartTooltip Tooltip { get; set; }

        /// <summary>
        /// Gets or sets the x-axis.
        /// </summary>
        [DataMember(Name = "xAxis", EmitDefaultValue = false, IsRequired = false)]
        public HighchartAxis XAxis { get; set; }

        /// <summary>
        /// Gets or sets the y-axis.
        /// </summary>
        [DataMember(Name = "yAxis", EmitDefaultValue = false, IsRequired = false)]
        public HighchartAxis YAxis { get; set; }

        /// <summary>
        /// Returns the graph in a JSON format.
        /// </summary>
        /// <returns>JSON format of the object.</returns>
        public override string ToString()
        {
            string json = null;

            using (var memoryStream = new MemoryStream())
            {
                var serializer = new DataContractJsonSerializer(this.GetType());
                serializer.WriteObject(memoryStream, this);

                memoryStream.Position = 0;
                using (var reader = new StreamReader(memoryStream))
                {
                    json = reader.ReadToEnd();
                }
            }

            return json;
        }
    }
}