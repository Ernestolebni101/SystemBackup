
namespace Runner.App.Views
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tab2 = new System.Windows.Forms.TabPage();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.tb1 = new System.Windows.Forms.TabPage();
            this.materialTabControl1 = new MaterialSkin2DotNet.Controls.MaterialTabControl();
            this.tab2.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.White;
            this.imageList.Images.SetKeyName(0, "backup.png");
            this.imageList.Images.SetKeyName(1, "pie-chart.png");
            // 
            // tab2
            // 
            this.tab2.BackColor = System.Drawing.Color.White;
            this.tab2.Controls.Add(this.pieChart1);
            this.tab2.ImageKey = "pie-chart.png";
            this.tab2.Location = new System.Drawing.Point(4, 39);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(668, 371);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Statistics";
            this.tab2.Click += new System.EventHandler(this.tab2_Click);
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(19, 15);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(605, 335);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // tb1
            // 
            this.tb1.BackColor = System.Drawing.Color.White;
            this.tb1.ImageKey = "backup.png";
            this.tb1.Location = new System.Drawing.Point(4, 39);
            this.tb1.Name = "tb1";
            this.tb1.Padding = new System.Windows.Forms.Padding(3);
            this.tb1.Size = new System.Drawing.Size(668, 371);
            this.tb1.TabIndex = 0;
            this.tb1.Text = "Backup";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tb1);
            this.materialTabControl1.Controls.Add(this.tab2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(676, 414);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.materialTabControl1_MouseClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(676, 414);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MaximumSize = new System.Drawing.Size(676, 414);
            this.MinimumSize = new System.Drawing.Size(676, 414);
            this.Name = "Main";
            this.PrimaryColor = MaterialSkin2DotNet.Primary.Indigo400;
            this.PrimaryDarkColor = MaterialSkin2DotNet.Primary.Indigo800;
            this.PrimaryLightColor = MaterialSkin2DotNet.Primary.Blue50;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemBackup";
            this.tab2.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabPage tb1;
        private MaterialSkin2DotNet.Controls.MaterialTabControl materialTabControl1;
        private LiveCharts.WinForms.PieChart pieChart1;
    }
}