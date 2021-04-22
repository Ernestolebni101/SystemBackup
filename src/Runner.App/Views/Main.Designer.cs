
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
            this.txtmask = new System.Windows.Forms.MaskedTextBox();
            this.cbdb = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            this.bttnSave = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.ds = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.bttnbrowser = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.cbbackup = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            this.fefef = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.ddd = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.txtfilename = new MaterialSkin2DotNet.Controls.MaterialMultiLineTextBox();
            this.materialLabel3 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.txtlogin = new MaterialSkin2DotNet.Controls.MaterialMultiLineTextBox();
            this.materialLabel1 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.txtservername = new MaterialSkin2DotNet.Controls.MaterialMultiLineTextBox();
            this.materialTabControl1 = new MaterialSkin2DotNet.Controls.MaterialTabControl();
            this.tab2.SuspendLayout();
            this.tb1.SuspendLayout();
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
            this.tb1.Controls.Add(this.txtmask);
            this.tb1.Controls.Add(this.cbdb);
            this.tb1.Controls.Add(this.bttnSave);
            this.tb1.Controls.Add(this.ds);
            this.tb1.Controls.Add(this.bttnbrowser);
            this.tb1.Controls.Add(this.cbbackup);
            this.tb1.Controls.Add(this.fefef);
            this.tb1.Controls.Add(this.ddd);
            this.tb1.Controls.Add(this.txtfilename);
            this.tb1.Controls.Add(this.materialLabel3);
            this.tb1.Controls.Add(this.materialLabel2);
            this.tb1.Controls.Add(this.txtlogin);
            this.tb1.Controls.Add(this.materialLabel1);
            this.tb1.Controls.Add(this.txtservername);
            this.tb1.ImageKey = "backup.png";
            this.tb1.Location = new System.Drawing.Point(4, 39);
            this.tb1.Name = "tb1";
            this.tb1.Padding = new System.Windows.Forms.Padding(3);
            this.tb1.Size = new System.Drawing.Size(668, 371);
            this.tb1.TabIndex = 0;
            this.tb1.Text = "Backup";
            this.tb1.Click += new System.EventHandler(this.tb1_Click_1);
            // 
            // txtmask
            // 
            this.txtmask.Location = new System.Drawing.Point(398, 67);
            this.txtmask.Name = "txtmask";
            this.txtmask.Size = new System.Drawing.Size(157, 23);
            this.txtmask.TabIndex = 13;
            // 
            // cbdb
            // 
            this.cbdb.AutoResize = false;
            this.cbdb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbdb.Depth = 0;
            this.cbdb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbdb.DropDownHeight = 174;
            this.cbdb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdb.DropDownWidth = 121;
            this.cbdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbdb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbdb.FormattingEnabled = true;
            this.cbdb.IntegralHeight = false;
            this.cbdb.ItemHeight = 43;
            this.cbdb.Location = new System.Drawing.Point(433, 169);
            this.cbdb.MaxDropDownItems = 4;
            this.cbdb.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.cbdb.Name = "cbdb";
            this.cbdb.Size = new System.Drawing.Size(122, 49);
            this.cbdb.TabIndex = 12;
            // 
            // bttnSave
            // 
            this.bttnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnSave.Depth = 0;
            this.bttnSave.DrawShadows = true;
            this.bttnSave.HighEmphasis = true;
            this.bttnSave.Icon = null;
            this.bttnSave.Location = new System.Drawing.Point(398, 301);
            this.bttnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bttnSave.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(88, 36);
            this.bttnSave.TabIndex = 12;
            this.bttnSave.Text = "Guardar";
            this.bttnSave.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bttnSave.UseAccentColor = false;
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // ds
            // 
            this.ds.AutoSize = true;
            this.ds.Depth = 0;
            this.ds.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ds.Location = new System.Drawing.Point(436, 146);
            this.ds.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.ds.Name = "ds";
            this.ds.Size = new System.Drawing.Size(101, 19);
            this.ds.TabIndex = 11;
            this.ds.Text = "Base de datos";
            // 
            // bttnbrowser
            // 
            this.bttnbrowser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnbrowser.Depth = 0;
            this.bttnbrowser.DrawShadows = true;
            this.bttnbrowser.HighEmphasis = true;
            this.bttnbrowser.Icon = null;
            this.bttnbrowser.Location = new System.Drawing.Point(398, 253);
            this.bttnbrowser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bttnbrowser.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.bttnbrowser.Name = "bttnbrowser";
            this.bttnbrowser.Size = new System.Drawing.Size(170, 36);
            this.bttnbrowser.TabIndex = 11;
            this.bttnbrowser.Text = "Seleccione la ruta";
            this.bttnbrowser.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bttnbrowser.UseAccentColor = false;
            this.bttnbrowser.UseVisualStyleBackColor = true;
            this.bttnbrowser.Click += new System.EventHandler(this.bttnbrowser_Click);
            // 
            // cbbackup
            // 
            this.cbbackup.AutoResize = false;
            this.cbbackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbackup.Depth = 0;
            this.cbbackup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbackup.DropDownHeight = 174;
            this.cbbackup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbackup.DropDownWidth = 121;
            this.cbbackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbackup.FormattingEnabled = true;
            this.cbbackup.IntegralHeight = false;
            this.cbbackup.ItemHeight = 43;
            this.cbbackup.Items.AddRange(new object[] {
            "Full",
            "Differential",
            "Log Transactional"});
            this.cbbackup.Location = new System.Drawing.Point(222, 169);
            this.cbbackup.MaxDropDownItems = 4;
            this.cbbackup.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.cbbackup.Name = "cbbackup";
            this.cbbackup.Size = new System.Drawing.Size(122, 49);
            this.cbbackup.TabIndex = 10;
            // 
            // fefef
            // 
            this.fefef.AutoSize = true;
            this.fefef.Depth = 0;
            this.fefef.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fefef.Location = new System.Drawing.Point(234, 147);
            this.fefef.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.fefef.Name = "fefef";
            this.fefef.Size = new System.Drawing.Size(110, 19);
            this.fefef.TabIndex = 9;
            this.fefef.Text = "Tipo de backup";
            // 
            // ddd
            // 
            this.ddd.AutoSize = true;
            this.ddd.Depth = 0;
            this.ddd.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ddd.Location = new System.Drawing.Point(17, 146);
            this.ddd.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.ddd.Name = "ddd";
            this.ddd.Size = new System.Drawing.Size(139, 19);
            this.ddd.TabIndex = 7;
            this.ddd.Text = "Nombre del Archivo";
            // 
            // txtfilename
            // 
            this.txtfilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtfilename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfilename.Depth = 0;
            this.txtfilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtfilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtfilename.Hint = "";
            this.txtfilename.Location = new System.Drawing.Point(17, 168);
            this.txtfilename.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(142, 21);
            this.txtfilename.TabIndex = 6;
            this.txtfilename.Text = "";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(425, 45);
            this.materialLabel3.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(71, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Password";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(238, 45);
            this.materialLabel2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(54, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "usuario";
            // 
            // txtlogin
            // 
            this.txtlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtlogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlogin.Depth = 0;
            this.txtlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtlogin.Hint = "";
            this.txtlogin.Location = new System.Drawing.Point(238, 67);
            this.txtlogin.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(142, 21);
            this.txtlogin.TabIndex = 2;
            this.txtlogin.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(21, 45);
            this.materialLabel1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(142, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Nombre del servidor";
            // 
            // txtservername
            // 
            this.txtservername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtservername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtservername.Depth = 0;
            this.txtservername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtservername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtservername.Hint = "";
            this.txtservername.Location = new System.Drawing.Point(21, 67);
            this.txtservername.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.txtservername.Name = "txtservername";
            this.txtservername.Size = new System.Drawing.Size(142, 21);
            this.txtservername.TabIndex = 0;
            this.txtservername.Text = "";
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
            this.tb1.ResumeLayout(false);
            this.tb1.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabPage tb1;
        private MaterialSkin2DotNet.Controls.MaterialTabControl materialTabControl1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private MaterialSkin2DotNet.Controls.MaterialMultiLineTextBox txtservername;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel1;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel2;
        private MaterialSkin2DotNet.Controls.MaterialMultiLineTextBox txtlogin;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel3;
        private MaterialSkin2DotNet.Controls.MaterialLabel ddd;
        private MaterialSkin2DotNet.Controls.MaterialMultiLineTextBox txtfilename;
        private MaterialSkin2DotNet.Controls.MaterialLabel fefef;
        private MaterialSkin2DotNet.Controls.MaterialButton bttnbrowser;
        private MaterialSkin2DotNet.Controls.MaterialComboBox cbbackup;
        private MaterialSkin2DotNet.Controls.MaterialButton bttnSave;
        private MaterialSkin2DotNet.Controls.MaterialComboBox cbdb;
        private MaterialSkin2DotNet.Controls.MaterialLabel ds;
        private System.Windows.Forms.MaskedTextBox txtmask;
    }
}