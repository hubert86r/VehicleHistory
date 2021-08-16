
namespace VehicleHistory.UserInterface.Forms.Cars
{
    partial class CarAddForm
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
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.txtGeneration = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblGeneration = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.gbIdentification = new System.Windows.Forms.GroupBox();
            this.dtpProductionDate = new System.Windows.Forms.DateTimePicker();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.lblProductionDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbTechnical = new System.Windows.Forms.GroupBox();
            this.cbFuelType = new System.Windows.Forms.ComboBox();
            this.txtPaintCode = new System.Windows.Forms.TextBox();
            this.lblPaintCode = new System.Windows.Forms.Label();
            this.txtEngineCode = new System.Windows.Forms.TextBox();
            this.lblEngineCode = new System.Windows.Forms.Label();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbCar = new System.Windows.Forms.PictureBox();
            this.gbGeneral.SuspendLayout();
            this.gbIdentification.SuspendLayout();
            this.gbTechnical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.cbBrand);
            this.gbGeneral.Controls.Add(this.txtGeneration);
            this.gbGeneral.Controls.Add(this.txtModel);
            this.gbGeneral.Controls.Add(this.lblGeneration);
            this.gbGeneral.Controls.Add(this.lblModel);
            this.gbGeneral.Controls.Add(this.lblBrand);
            this.gbGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbGeneral.Location = new System.Drawing.Point(14, 108);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(416, 159);
            this.gbGeneral.TabIndex = 0;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "Dane ogólne";
            // 
            // cbBrand
            // 
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(230, 40);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(180, 28);
            this.cbBrand.TabIndex = 6;
            // 
            // txtGeneration
            // 
            this.txtGeneration.Location = new System.Drawing.Point(230, 116);
            this.txtGeneration.Name = "txtGeneration";
            this.txtGeneration.Size = new System.Drawing.Size(180, 27);
            this.txtGeneration.TabIndex = 5;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(230, 79);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(180, 27);
            this.txtModel.TabIndex = 4;
            // 
            // lblGeneration
            // 
            this.lblGeneration.AutoSize = true;
            this.lblGeneration.Location = new System.Drawing.Point(33, 115);
            this.lblGeneration.Name = "lblGeneration";
            this.lblGeneration.Size = new System.Drawing.Size(36, 20);
            this.lblGeneration.TabIndex = 2;
            this.lblGeneration.Text = "Typ";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(33, 78);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(54, 20);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(33, 42);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(55, 20);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Marka";
            // 
            // gbIdentification
            // 
            this.gbIdentification.Controls.Add(this.dtpProductionDate);
            this.gbIdentification.Controls.Add(this.txtLicensePlate);
            this.gbIdentification.Controls.Add(this.lblLicensePlate);
            this.gbIdentification.Controls.Add(this.lblProductionDate);
            this.gbIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbIdentification.Location = new System.Drawing.Point(474, 108);
            this.gbIdentification.Name = "gbIdentification";
            this.gbIdentification.Size = new System.Drawing.Size(416, 159);
            this.gbIdentification.TabIndex = 3;
            this.gbIdentification.TabStop = false;
            this.gbIdentification.Text = "Dane identyfikacyjne";
            // 
            // dtpProductionDate
            // 
            this.dtpProductionDate.CustomFormat = " ";
            this.dtpProductionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpProductionDate.Location = new System.Drawing.Point(230, 38);
            this.dtpProductionDate.Name = "dtpProductionDate";
            this.dtpProductionDate.Size = new System.Drawing.Size(180, 27);
            this.dtpProductionDate.TabIndex = 6;
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(230, 78);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(180, 27);
            this.txtLicensePlate.TabIndex = 5;
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Location = new System.Drawing.Point(33, 78);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(159, 20);
            this.lblLicensePlate.TabIndex = 1;
            this.lblLicensePlate.Text = "Numer rejestracyjny";
            // 
            // lblProductionDate
            // 
            this.lblProductionDate.AutoSize = true;
            this.lblProductionDate.Location = new System.Drawing.Point(33, 42);
            this.lblProductionDate.Name = "lblProductionDate";
            this.lblProductionDate.Size = new System.Drawing.Size(117, 20);
            this.lblProductionDate.TabIndex = 0;
            this.lblProductionDate.Text = "Data produkcji";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(46, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nazwa";
            // 
            // gbTechnical
            // 
            this.gbTechnical.Controls.Add(this.cbFuelType);
            this.gbTechnical.Controls.Add(this.txtPaintCode);
            this.gbTechnical.Controls.Add(this.lblPaintCode);
            this.gbTechnical.Controls.Add(this.txtEngineCode);
            this.gbTechnical.Controls.Add(this.lblEngineCode);
            this.gbTechnical.Controls.Add(this.lblFuelType);
            this.gbTechnical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbTechnical.Location = new System.Drawing.Point(14, 291);
            this.gbTechnical.Name = "gbTechnical";
            this.gbTechnical.Size = new System.Drawing.Size(416, 159);
            this.gbTechnical.TabIndex = 3;
            this.gbTechnical.TabStop = false;
            this.gbTechnical.Text = "Dane techniczne";
            // 
            // cbFuelType
            // 
            this.cbFuelType.FormattingEnabled = true;
            this.cbFuelType.Location = new System.Drawing.Point(230, 28);
            this.cbFuelType.Name = "cbFuelType";
            this.cbFuelType.Size = new System.Drawing.Size(180, 28);
            this.cbFuelType.TabIndex = 7;
            // 
            // txtPaintCode
            // 
            this.txtPaintCode.Location = new System.Drawing.Point(230, 104);
            this.txtPaintCode.Name = "txtPaintCode";
            this.txtPaintCode.Size = new System.Drawing.Size(180, 27);
            this.txtPaintCode.TabIndex = 8;
            // 
            // lblPaintCode
            // 
            this.lblPaintCode.AutoSize = true;
            this.lblPaintCode.Location = new System.Drawing.Point(33, 115);
            this.lblPaintCode.Name = "lblPaintCode";
            this.lblPaintCode.Size = new System.Drawing.Size(92, 20);
            this.lblPaintCode.TabIndex = 2;
            this.lblPaintCode.Text = "Kod lakieru";
            // 
            // txtEngineCode
            // 
            this.txtEngineCode.Location = new System.Drawing.Point(230, 66);
            this.txtEngineCode.Name = "txtEngineCode";
            this.txtEngineCode.Size = new System.Drawing.Size(180, 27);
            this.txtEngineCode.TabIndex = 7;
            // 
            // lblEngineCode
            // 
            this.lblEngineCode.AutoSize = true;
            this.lblEngineCode.Location = new System.Drawing.Point(33, 78);
            this.lblEngineCode.Name = "lblEngineCode";
            this.lblEngineCode.Size = new System.Drawing.Size(90, 20);
            this.lblEngineCode.TabIndex = 1;
            this.lblEngineCode.Text = "Kod silnika";
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Location = new System.Drawing.Point(33, 42);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(113, 20);
            this.lblFuelType.TabIndex = 0;
            this.lblFuelType.Text = "Rodzaj paliwa";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(243, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 24);
            this.txtName.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(678, 453);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(784, 453);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbCar
            // 
            this.pbCar.Image = global::VehicleHistory.UserInterface.Properties.Resources.car2;
            this.pbCar.Location = new System.Drawing.Point(830, 14);
            this.pbCar.Name = "pbCar";
            this.pbCar.Size = new System.Drawing.Size(53, 56);
            this.pbCar.TabIndex = 7;
            this.pbCar.TabStop = false;
            // 
            // CarAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbCar);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gbTechnical);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.gbIdentification);
            this.Controls.Add(this.gbGeneral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KeyPreview = true;
            this.Name = "CarAddForm";
            this.Text = "Dodaj pojazd";
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            this.gbIdentification.ResumeLayout(false);
            this.gbIdentification.PerformLayout();
            this.gbTechnical.ResumeLayout(false);
            this.gbTechnical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.Label lblGeneration;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.GroupBox gbIdentification;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.Label lblProductionDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbTechnical;
        private System.Windows.Forms.Label lblPaintCode;
        private System.Windows.Forms.Label lblEngineCode;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.TextBox txtGeneration;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.TextBox txtPaintCode;
        private System.Windows.Forms.TextBox txtEngineCode;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.ComboBox cbFuelType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpProductionDate;
        private System.Windows.Forms.PictureBox pbCar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}