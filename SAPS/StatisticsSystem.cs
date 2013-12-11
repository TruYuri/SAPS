using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.ComponentModel;

namespace SAPS
{
    class StatisticsSystem
    {
        private static StatisticsSystem _instance;
        private BindingList<DatabaseEntry> _source;

        // limit from all chart types since some are problematic
        public static List<string> ChartTypes = new List<string>() 
        {
            SeriesChartType.Area.ToString(),
            SeriesChartType.Bar.ToString(),
            SeriesChartType.Bubble.ToString(),
            SeriesChartType.Column.ToString(),
            SeriesChartType.Doughnut.ToString(),
            SeriesChartType.Line.ToString(),
            SeriesChartType.Pie.ToString(),
            SeriesChartType.Point.ToString(),
            SeriesChartType.Radar.ToString(),
            SeriesChartType.Spline.ToString(),
            SeriesChartType.SplineArea.ToString(),
            SeriesChartType.StepLine.ToString(),
            SeriesChartType.Stock.ToString(),
        };

        public static StatisticsSystem Instance
        {
            get
            {
                return _instance;
            }
        }

        public BindingList<DatabaseEntry> Source
        {
            set
            {
                _source = value;
            }
        }

        public StatisticsSystem()
        {
            _instance = this;
        }

        public void GenerateDefaultCharts(Chart chartCollege, Chart chartACT, Chart chartCustom)
        {
            // progress through dictionary, <major, college>. Each time college is found, add to n.  
            Dictionary<string, int> colleges = new Dictionary<string, int>();

            foreach(string college in CollegeData.Colleges)
            {
                colleges.Add(college, 0);
            }

            foreach (DatabaseEntry entry in _source)
            {
                foreach(string major in entry.Majors)
                {
                    colleges[CollegeData.Majors[major]]++;
                }
            }

            // all data found, plot chartCollege bar graph
            chartCollege.Series.Clear();
            chartCollege.ChartAreas.Clear();

            chartCollege.Series.Add(new Series("Series"));
            chartCollege.Series["Series"].ChartType = SeriesChartType.Bar;
            chartCollege.ChartAreas.Add(new ChartArea("ChartArea"));
            chartCollege.ChartAreas["ChartArea"].AxisX.LabelStyle.IsEndLabelVisible = false;
            chartCollege.ChartAreas["ChartArea"].AxisY.LabelStyle.IsEndLabelVisible = false;
            foreach(KeyValuePair<string, int> pair in colleges)
            {
                chartCollege.Series["Series"].Points.AddXY(pair.Key, pair.Value);
            }         

            // histogram 11-36 ACT. If SAT, convert to ACT
            Dictionary<int, int> scores = new Dictionary<int, int>();

            for (int i = 11; i <= 36; i++) // default out the dictionary
            {
                scores.Add(i, 0);
            }

            foreach (DatabaseEntry entry in _source)
            {
                if (entry.ACTSAT >= 11 && entry.ACTSAT <= 36)
                {
                    scores[entry.ACTSAT]++;
                }
                else
                {
                    foreach (KeyValuePair<int[], int> pair in CollegeData.SATtoACT)
                    {
                        if (pair.Key.Contains(entry.ACTSAT))
                        {
                            scores[pair.Value]++;
                            break;
                        }
                    }
                }
            }
            
            // all data found, plot chartACT histogram
            chartACT.Series.Clear();
            chartACT.ChartAreas.Clear();

            chartACT.Series.Add(new Series("Series"));
            chartACT.Series["Series"].ChartType = SeriesChartType.Column;
            chartACT.ChartAreas.Add(new ChartArea("ChartArea"));
            chartACT.ChartAreas["ChartArea"].AxisX.Interval = 1.0;
            chartACT.ChartAreas["ChartArea"].AxisX.LabelStyle.IsEndLabelVisible = false;
            chartACT.ChartAreas["ChartArea"].AxisY.LabelStyle.IsEndLabelVisible = false;
            foreach (KeyValuePair<int, int> pair in scores)
            {
                chartACT.Series["Series"].Points.AddXY(pair.Key, pair.Value);
            }

            // default custom chart
            chartCustom.Series.Clear();
            chartCustom.ChartAreas.Clear();
            chartCustom.Series.Add(new Series("Series"));
            chartCustom.Series["Series"].ChartType = SeriesChartType.Bar;
            UpdateCustomChart(chartCustom, "Gender", "StudentType");
        }

        public void ChangeChartType(Chart chart, string type)
        {
            SeriesChartType chartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), type, true);

            if (chart.Series.Count > 0)
            {
                chart.Series["Series"].ChartType = chartType;
            }

            chart.Legends.Clear();

            if (chartType == SeriesChartType.Pie || chartType == SeriesChartType.Doughnut)
            {
                // add a legend
                chart.Legends.Add(new Legend("Legend"));
                chart.Series["Series"]["PieLabelStyle"] = "Disabled";
            }
        }

        public void ChangeChartColor(Chart chart, string color)
        {
            if (chart.Series.Count > 0)
            {
                chart.Series["Series"].Color = Color.FromName(color);
            }
        }

        // this function is the crown jewel achievement of this program.
        // it maps any two data sets against eachother. the data sets can be lists or single values. it all works perfectly.
        public void UpdateCustomChart(Chart chart, string xProperty, string yProperty)
        {
            SeriesChartType type;
            if (chart.Series.Count != 0)
            {
                type = chart.Series["Series"].ChartType;
            }
            else
            {
                type = SeriesChartType.Bar;
            }
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Series.Add(new Series("Series"));
            chart.Series["Series"].ChartType = type;
            chart.ChartAreas.Add(new ChartArea("ChartArea"));
            chart.ChartAreas["ChartArea"].AxisX.Interval = 1.0;
            chart.ChartAreas["ChartArea"].AxisX.LabelStyle.IsEndLabelVisible = false;
            chart.ChartAreas["ChartArea"].AxisY.LabelStyle.IsEndLabelVisible = false;

            // List<object> xList = new List<object>();
            Dictionary<string, Dictionary<string, int>> list = new Dictionary<string, Dictionary<string, int>>();

            // count up stuff first just like before
            foreach (DatabaseEntry entry in _source)
            {
                object key;
                object value;

                // Special Logic for Majors/Minors
                if (xProperty == "Majors" || xProperty == "Minors")
                {
                    BindingList<string> keyList = (BindingList<string>)entry.GetType().GetProperty(xProperty).GetValue(entry);

                    foreach (string major in keyList)
                    {
                        if (yProperty == "Majors" || yProperty == "Minors")
                        {
                            BindingList<string> valueList = (BindingList<string>)entry.GetType().GetProperty(yProperty).GetValue(entry);

                            foreach (string minor in valueList)
                            {
                                ChartAdditionLogic(list, major, minor);
                            }
                        }
                        else
                        {
                            value = entry.GetType().GetProperty(yProperty).GetValue(entry);

                            if (value != null)
                            {
                                ChartAdditionLogic(list, major, value.ToString());
                            }
                        }
                    }
                }
                else if (yProperty == "Majors" || yProperty == "Minors")
                {
                    BindingList<string> valueList = (BindingList<string>)entry.GetType().GetProperty(yProperty).GetValue(entry);

                    foreach (string major in valueList)
                    {
                        if (xProperty == "Majors" || xProperty == "Minors")
                        {
                            BindingList<string> keyList = (BindingList<string>)entry.GetType().GetProperty(xProperty).GetValue(entry);

                            foreach (string minor in keyList)
                            {
                                ChartAdditionLogic(list, major, minor);
                            }
                        }
                        else
                        {
                            value = entry.GetType().GetProperty(xProperty).GetValue(entry);

                            if (value != null)
                            {
                                ChartAdditionLogic(list, major, value.ToString());
                            }
                        }
                    }
                }
                else
                {
                    key = entry.GetType().GetProperty(xProperty).GetValue(entry);
                    value = entry.GetType().GetProperty(yProperty).GetValue(entry);

                    if (key != null && value != null)
                    {
                        ChartAdditionLogic(list, key.ToString(), value.ToString());
                    }
                }
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> xpair in list)
            {
                foreach (KeyValuePair<string, int> ypair in xpair.Value)
                {
                    if (xProperty != yProperty)
                    {
                        chart.Series["Series"].Points.AddXY(xpair.Key + ", " + ypair.Key, ypair.Value);
                    }
                    else
                    {
                        chart.Series["Series"].Points.AddXY(xpair.Key, ypair.Value);
                    }
                }
            }
        }

        private void ChartAdditionLogic(Dictionary<string, Dictionary<string, int>> list, string key, string value)
        {
            if (list.ContainsKey(key))
            {
                if (list[key].ContainsKey(value))
                {
                    list[key][value]++;
                }
                else
                {
                    list[key].Add(value, 1);
                }
            }
            else
            {
                list.Add(key, new Dictionary<string, int>());
                list[key].Add(value, 1);
            }
        }

        public void SaveChart(Chart chart, string filename, string extension)
        {
            switch(extension)
            {
                case ".bmp":
                    chart.SaveImage(filename, ChartImageFormat.Bmp);
                    break;
                case ".emf":
                    chart.SaveImage(filename, ChartImageFormat.Emf);
                    break;
                case ".emf-dual":
                    chart.SaveImage(filename, ChartImageFormat.EmfDual);
                    break;
                case ".emf+":
                    chart.SaveImage(filename, ChartImageFormat.EmfPlus);
                    break;
                case ".gif":
                    chart.SaveImage(filename, ChartImageFormat.Gif);
                    break;
                case ".jpeg":
                    chart.SaveImage(filename, ChartImageFormat.Jpeg);
                    break;
                case ".png":
                    chart.SaveImage(filename, ChartImageFormat.Png);
                    break;
                case ".tiff":
                    chart.SaveImage(filename, ChartImageFormat.Tiff);
                    break;
            }
        }
    }
}