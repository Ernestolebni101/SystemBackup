using balin.Repository._01.Interfaces;
using LiveCharts;
using LiveCharts.Wpf;
using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runner.App.Views
{
    public partial class Main : MaterialForm
    {
        private MaterialSkinManager material;
       
        private readonly IDatabaseRepositoryPattern _db;
        private readonly IBackupRepositoryPattern _bk;
        public Main(IDatabaseRepositoryPattern db, IBackupRepositoryPattern bk)
        {
            _db = db;
            _bk = bk;
            InitializeComponent();
            initThemes();
        }

        private void initThemes()
        {
            material = MaterialSkinManager.Instance;
            material.EnforceBackcolorOnAllComponents = true;
            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.LIGHT;
            material.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
            showChart(_db.GetDatabases());
        }

        private void tab2_Click(object sender, EventArgs e)
        {
            
        }
        public void showChart(IReadOnlyList<Database> dbinfo)
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
               string.Format("{0} ({1:P}) MB", chartPoint.Y, chartPoint.Participation);

            foreach (var src in dbinfo)
            {
                var s = double.Parse(src.Sizeindisk.Trim());
                pieChart1.Series.Add
                    (
                        new PieSeries
                        {
                            Title = src.Databasename,
                            Values = new ChartValues<double> { s },
                            PushOut = 4,
                            DataLabels = true,
                            LabelPoint = labelPoint,
                        }
                    );
            }
            pieChart1.LegendLocation = LegendLocation.Bottom;
            
        }
        private void materialTabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            
            
        }
    }
}
