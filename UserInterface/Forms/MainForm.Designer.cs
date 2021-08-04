
namespace VehicleHistory.UserInterface.Forms
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.pMain = new System.Windows.Forms.Panel();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.btnCurrentStatus = new System.Windows.Forms.Button();
            this.btnRefuelingHistory = new System.Windows.Forms.Button();
            this.btnServiceHistory = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpGeneral);
            this.tabControl1.Controls.Add(this.tpConfiguration);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 21);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(872, 90);
            this.tabControl1.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.btnCurrentStatus);
            this.tpGeneral.Controls.Add(this.splitter3);
            this.tpGeneral.Controls.Add(this.btnRefuelingHistory);
            this.tpGeneral.Controls.Add(this.splitter2);
            this.tpGeneral.Controls.Add(this.btnServiceHistory);
            this.tpGeneral.Controls.Add(this.splitter1);
            this.tpGeneral.Controls.Add(this.btnVehicle);
            this.tpGeneral.Location = new System.Drawing.Point(4, 25);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(864, 61);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Ogólne";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(489, 3);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 55);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(296, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 55);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(123, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 55);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // tpConfiguration
            // 
            this.tpConfiguration.Location = new System.Drawing.Point(4, 25);
            this.tpConfiguration.Name = "tpConfiguration";
            this.tpConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfiguration.Size = new System.Drawing.Size(864, 61);
            this.tpConfiguration.TabIndex = 1;
            this.tpConfiguration.Text = "Konfiguracja";
            this.tpConfiguration.UseVisualStyleBackColor = true;
            // 
            // ssMain
            // 
            this.ssMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersion,
            this.tsslDatabase,
            this.tsslUser});
            this.ssMain.Location = new System.Drawing.Point(0, 527);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(872, 26);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(90, 20);
            this.tsslVersion.Text = "Wersja: 1.0.0";
            // 
            // tsslDatabase
            // 
            this.tsslDatabase.Name = "tsslDatabase";
            this.tsslDatabase.Size = new System.Drawing.Size(142, 20);
            this.tsslDatabase.Text = "Baza: VehicleHistory";
            // 
            // tsslUser
            // 
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(184, 20);
            this.tsslUser.Text = "Użytkownik: Hubert Czajka";
            this.tsslUser.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.tcTabs);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 90);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(872, 437);
            this.pMain.TabIndex = 2;
            // 
            // tcTabs
            // 
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcTabs.ItemSize = new System.Drawing.Size(105, 21);
            this.tcTabs.Location = new System.Drawing.Point(0, 0);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(872, 437);
            this.tcTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcTabs.TabIndex = 0;
            this.tcTabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcTabs_DrawItem);
            this.tcTabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tcTabs_MouseDown);
            // 
            // btnCurrentStatus
            // 
            this.btnCurrentStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCurrentStatus.Image = global::VehicleHistory.UserInterface.Properties.Resources.fuel2;
            this.btnCurrentStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrentStatus.Location = new System.Drawing.Point(492, 3);
            this.btnCurrentStatus.Name = "btnCurrentStatus";
            this.btnCurrentStatus.Size = new System.Drawing.Size(180, 55);
            this.btnCurrentStatus.TabIndex = 6;
            this.btnCurrentStatus.Text = "Aktualny status";
            this.btnCurrentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCurrentStatus.UseVisualStyleBackColor = true;
            // 
            // btnRefuelingHistory
            // 
            this.btnRefuelingHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefuelingHistory.Image = global::VehicleHistory.UserInterface.Properties.Resources.fuel1;
            this.btnRefuelingHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefuelingHistory.Location = new System.Drawing.Point(299, 3);
            this.btnRefuelingHistory.Name = "btnRefuelingHistory";
            this.btnRefuelingHistory.Size = new System.Drawing.Size(190, 55);
            this.btnRefuelingHistory.TabIndex = 4;
            this.btnRefuelingHistory.Text = "Historia tankowania";
            this.btnRefuelingHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefuelingHistory.UseVisualStyleBackColor = true;
            // 
            // btnServiceHistory
            // 
            this.btnServiceHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnServiceHistory.Image = global::VehicleHistory.UserInterface.Properties.Resources.service2;
            this.btnServiceHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServiceHistory.Location = new System.Drawing.Point(126, 3);
            this.btnServiceHistory.Name = "btnServiceHistory";
            this.btnServiceHistory.Size = new System.Drawing.Size(170, 55);
            this.btnServiceHistory.TabIndex = 2;
            this.btnServiceHistory.Text = "Historia serwisowa";
            this.btnServiceHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServiceHistory.UseVisualStyleBackColor = true;
            this.btnServiceHistory.Click += new System.EventHandler(this.btnServiceHistory_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVehicle.Image = global::VehicleHistory.UserInterface.Properties.Resources.car3;
            this.btnVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicle.Location = new System.Drawing.Point(3, 3);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(120, 55);
            this.btnVehicle.TabIndex = 0;
            this.btnVehicle.Text = "Pojazdy";
            this.btnVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 553);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle History";
            this.tabControl1.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.Button btnCurrentStatus;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button btnRefuelingHistory;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btnServiceHistory;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.TabPage tpConfiguration;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsslDatabase;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.TabControl tcTabs;
    }
}