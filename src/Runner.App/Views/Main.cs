using balin.Repository._01.Interfaces;
using LiveCharts;
using LiveCharts.Wpf;
using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;
using Models;
using Runner.App.StaticResource;
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
        string finfolder;
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
           
            ConfigCb();
        }

        public void ConfigCb()
        {
            #region Cb Databases
            var list = _db.GetDatabases();
            this.cbdb.DataSource = list.Except();
            this.cbdb.ValueMember = "ID";
            this.cbdb.DisplayMember = "Databasename";

            #endregion

            #region Cb Backup
            var src = new List<Typebak>()
            {
                new Typebak{ Id = 0, type= "Seleccione una opción"},
                new Typebak{ Id = 1, type= "Full"},
                new Typebak{ Id = 2, type= "Differential"},
                new Typebak{ Id = 2, type= "Log Transactional"}
            };

            this.cbbackup.DataSource = src;
            this.cbbackup.ValueMember = "Id";
            this.cbbackup.DisplayMember = "type";
            #endregion
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


        private Backup Createnew(string dbname, int backtype, string name, string path)
        {
            return new Backup()
            {
                DatabaseName = dbname,
                BackupType = backtype,
                Name = name,
                Path = path
            };
        }
        private bool Save(Backup model)
        {
            return _bk.Insert(model);
        }

        private void GenerateBrowser()
        {
            var folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                finfolder = folder.SelectedPath;
            }
        }

        private void DoAction()
        {
            if (!string.IsNullOrEmpty(txtfilename.Text))
            {
                var bak = Createnew(cbdb.Text, cbbackup.SelectedIndex, txtfilename.Text, finfolder);
                Save(bak);
            }
            else
                throw new Exception();
        }
        private void bttnbrowser_Click(object sender, EventArgs e)
        {
            GenerateBrowser();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DoAction();
                MessageBox.Show("Respaldo exitoso!!", "IMessage", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error \n\tSugerencias: \t\n Verifique el nombre de su archivo de respaldo \n Seleccione el tipo de respaldo", "IMessage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
