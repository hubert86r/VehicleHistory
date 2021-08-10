
namespace VehicleHistory.UserInterface.Forms.Cars
{
    partial class CarsForm
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
            this.tlpCars = new System.Windows.Forms.TableLayoutPanel();
            this.pCars = new System.Windows.Forms.Panel();
            this.btnRefresch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCars = new System.Windows.Forms.BindingSource(this.components);
            this.tlpCars.SuspendLayout();
            this.pCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCars)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpCars
            // 
            this.tlpCars.ColumnCount = 1;
            this.tlpCars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCars.Controls.Add(this.pCars, 0, 0);
            this.tlpCars.Controls.Add(this.dgvCars, 0, 1);
            this.tlpCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCars.Location = new System.Drawing.Point(0, 0);
            this.tlpCars.Name = "tlpCars";
            this.tlpCars.RowCount = 2;
            this.tlpCars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCars.Size = new System.Drawing.Size(800, 450);
            this.tlpCars.TabIndex = 0;
            // 
            // pCars
            // 
            this.pCars.Controls.Add(this.btnRefresch);
            this.pCars.Controls.Add(this.btnDelete);
            this.pCars.Controls.Add(this.btnEdit);
            this.pCars.Controls.Add(this.btnAdd);
            this.pCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCars.Location = new System.Drawing.Point(3, 3);
            this.pCars.Name = "pCars";
            this.pCars.Size = new System.Drawing.Size(794, 34);
            this.pCars.TabIndex = 0;
            // 
            // btnRefresch
            // 
            this.btnRefresch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresch.Image = global::VehicleHistory.UserInterface.Properties.Resources.refresh24;
            this.btnRefresch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresch.Location = new System.Drawing.Point(300, 0);
            this.btnRefresch.Name = "btnRefresch";
            this.btnRefresch.Size = new System.Drawing.Size(100, 34);
            this.btnRefresch.TabIndex = 3;
            this.btnRefresch.Text = "Odśwież";
            this.btnRefresch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Image = global::VehicleHistory.UserInterface.Properties.Resources.delete24;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(200, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.Image = global::VehicleHistory.UserInterface.Properties.Resources.edit24;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(100, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 34);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Image = global::VehicleHistory.UserInterface.Properties.Resources.add24;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvCars
            // 
            this.dgvCars.AllowUserToAddRows = false;
            this.dgvCars.AllowUserToDeleteRows = false;
            this.dgvCars.AutoGenerateColumns = false;
            this.dgvCars.BackgroundColor = System.Drawing.Color.White;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colBrand,
            this.colModel});
            this.dgvCars.DataSource = this.bsCars;
            this.dgvCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCars.Location = new System.Drawing.Point(3, 43);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.RowHeadersVisible = false;
            this.dgvCars.RowHeadersWidth = 51;
            this.dgvCars.RowTemplate.Height = 24;
            this.dgvCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCars.Size = new System.Drawing.Size(794, 404);
            this.dgvCars.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            this.colId.Width = 125;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Nazwa";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 125;
            // 
            // colBrand
            // 
            this.colBrand.DataPropertyName = "Brand";
            this.colBrand.HeaderText = "Marka";
            this.colBrand.MinimumWidth = 6;
            this.colBrand.Name = "colBrand";
            this.colBrand.ReadOnly = true;
            this.colBrand.Width = 125;
            // 
            // colModel
            // 
            this.colModel.DataPropertyName = "Model";
            this.colModel.HeaderText = "Model";
            this.colModel.MinimumWidth = 6;
            this.colModel.Name = "colModel";
            this.colModel.ReadOnly = true;
            this.colModel.Width = 125;
            // 
            // bsCars
            // 
            this.bsCars.DataSource = typeof(VehicleHistory.DataAccessLayer.ViewModel.CarViewModel);
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpCars);
            this.Name = "CarsForm";
            this.Text = "Pojazdy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CarsForm_FormClosed);
            this.tlpCars.ResumeLayout(false);
            this.pCars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCars;
        private System.Windows.Forms.Panel pCars;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRefresch;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.BindingSource bsCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
    }
}