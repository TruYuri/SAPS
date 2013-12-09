using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.ComponentModel;

namespace SAPS
{
    class StatisticsSystem
    {
        private static StatisticsSystem _instance;
        private BindingList<DatabaseEntry> _source;

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

        public void GenerateDefaultCharts(Chart chartCollege, Chart chartACT)
        {
            // progress through dictionary, <major, college>. Each time college is found, add to n.
            Dictionary<string, int> colleges = new Dictionary<string, int>();

            foreach(string college in CollegeData.Colleges)
            {
                colleges.Add(college, 0);
            }

            foreach (DatabaseEntry entry in _source)
            {
                foreach(string major in entry.majors)
                {
                    colleges[CollegeData.Majors[major]]++;
                }
            }

            // all data found, plot chartCollege bar graph

            chartCollege.Series.Add(new Series("Colleges"));
            chartCollege.Series[0].ChartType = SeriesChartType.Bar;
            // chartCollege.ChartAreas.Add(new ChartArea("Colleges"));
            // chartCollege.ChartAreas["Colleges"].AxisX.Interval = 1;
            foreach(KeyValuePair<string, int> pair in colleges)
            {
                if(pair.Value != 0)
                {
                    chartCollege.Series["Colleges"].Points.AddXY(pair.Key, pair.Value);
                }
            }         

            // histogram 11-36 ACT. If SAT, convert to ACT
            Dictionary<int, int> scores = new Dictionary<int, int>();

            for (int i = 11; i <= 36; i++) // default out the dictionary
            {
                scores.Add(i, 0);
            }

            foreach (DatabaseEntry entry in _source)
            {
                if (entry.actSAT >= 11 && entry.actSAT <= 36)
                {
                    scores[entry.actSAT]++;
                }
                else
                {
                    foreach (KeyValuePair<int[], int> pair in CollegeData.SATtoACT)
                    {
                        if (pair.Key.Contains(entry.actSAT))
                        {
                            scores[pair.Value]++;
                            break;
                        }
                    }
                }
            }

            // all data found, plot chartACT histogram
            chartACT.Series.Add(new Series("ACT Scores"));
            chartACT.Series[0].ChartType = SeriesChartType.Column;
            // chartACT.ChartAreas.Add(new ChartArea("ACT Scores"));
            // chartACT.ChartAreas["ACT Scores"].AxisX.Interval = 1;
            // chartACT.ChartAreas["ACT Scores"].Position.Height = 100;
            // chartACT.ChartAreas["ACT Scores"].Position.Width = 100;
            foreach (KeyValuePair<int, int> pair in scores)
            {
                chartACT.Series["ACT Scores"].Points.AddXY(pair.Key, pair.Value);
            }         
        }

        public void ChangeChartType(Chart chart, string type)
        {
            chart.Series[0].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), type, true);
        }
    }
}
