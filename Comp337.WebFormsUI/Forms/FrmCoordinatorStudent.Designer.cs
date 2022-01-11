
namespace Comp337.WebFormsUI.Forms
{
    partial class FrmCoordinatorStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCoordinatorStudent));
            this.gcStudent = new DevExpress.XtraGrid.GridControl();
            this.gvStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpcAdd = new DevExpress.XtraEditors.GroupControl();
            this.txteEMailAdd = new DevExpress.XtraEditors.TextEdit();
            this.lblcEMailAdd = new DevExpress.XtraEditors.LabelControl();
            this.txtePhoneNumberAdd = new DevExpress.XtraEditors.TextEdit();
            this.lblcPhoneNumberAdd = new DevExpress.XtraEditors.LabelControl();
            this.sbtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.lueDepartmentAdd = new DevExpress.XtraEditors.LookUpEdit();
            this.txteLastNameAdd = new DevExpress.XtraEditors.TextEdit();
            this.txteFirstNameAdd = new DevExpress.XtraEditors.TextEdit();
            this.txtePersonalIdAdd = new DevExpress.XtraEditors.TextEdit();
            this.lblcDepartmentAdd = new DevExpress.XtraEditors.LabelControl();
            this.lblcLastNameAdd = new DevExpress.XtraEditors.LabelControl();
            this.lblcFirsNameAdd = new DevExpress.XtraEditors.LabelControl();
            this.lblcPersonalIdAdd = new DevExpress.XtraEditors.LabelControl();
            this.grpcUpdate = new DevExpress.XtraEditors.GroupControl();
            this.txteEMailUpdate = new DevExpress.XtraEditors.TextEdit();
            this.lblcEMailUpdate = new DevExpress.XtraEditors.LabelControl();
            this.txtePhoneNumberUpdate = new DevExpress.XtraEditors.TextEdit();
            this.lblcPhoneNumberUpdate = new DevExpress.XtraEditors.LabelControl();
            this.sbtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.lueDepartmentUpdate = new DevExpress.XtraEditors.LookUpEdit();
            this.txteLastNameUpdate = new DevExpress.XtraEditors.TextEdit();
            this.txteFirstNameUpdate = new DevExpress.XtraEditors.TextEdit();
            this.txtePersonalIdUpdate = new DevExpress.XtraEditors.TextEdit();
            this.lblcDepartmentUpdate = new DevExpress.XtraEditors.LabelControl();
            this.lblcLastNameUpdate = new DevExpress.XtraEditors.LabelControl();
            this.lblcFirstNameUpdate = new DevExpress.XtraEditors.LabelControl();
            this.lblcPersonalIdUpdate = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpcAdd)).BeginInit();
            this.grpcAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteEMailAdd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtePhoneNumberAdd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDepartmentAdd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteLastNameAdd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteFirstNameAdd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtePersonalIdAdd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpcUpdate)).BeginInit();
            this.grpcUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteEMailUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtePhoneNumberUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDepartmentUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteLastNameUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteFirstNameUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtePersonalIdUpdate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcStudent
            // 
            this.gcStudent.Location = new System.Drawing.Point(12, 12);
            this.gcStudent.MainView = this.gvStudent;
            this.gcStudent.Name = "gcStudent";
            this.gcStudent.Size = new System.Drawing.Size(820, 210);
            this.gcStudent.TabIndex = 2;
            this.gcStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStudent});
            // 
            // gvStudent
            // 
            this.gvStudent.GridControl = this.gcStudent;
            this.gvStudent.Name = "gvStudent";
            this.gvStudent.OptionsBehavior.Editable = false;
            this.gvStudent.OptionsView.ShowGroupPanel = false;
            this.gvStudent.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvStudent_RowClick);
            // 
            // grpcAdd
            // 
            this.grpcAdd.Controls.Add(this.txteEMailAdd);
            this.grpcAdd.Controls.Add(this.lblcEMailAdd);
            this.grpcAdd.Controls.Add(this.txtePhoneNumberAdd);
            this.grpcAdd.Controls.Add(this.lblcPhoneNumberAdd);
            this.grpcAdd.Controls.Add(this.sbtnAdd);
            this.grpcAdd.Controls.Add(this.lueDepartmentAdd);
            this.grpcAdd.Controls.Add(this.txteLastNameAdd);
            this.grpcAdd.Controls.Add(this.txteFirstNameAdd);
            this.grpcAdd.Controls.Add(this.txtePersonalIdAdd);
            this.grpcAdd.Controls.Add(this.lblcDepartmentAdd);
            this.grpcAdd.Controls.Add(this.lblcLastNameAdd);
            this.grpcAdd.Controls.Add(this.lblcFirsNameAdd);
            this.grpcAdd.Controls.Add(this.lblcPersonalIdAdd);
            this.grpcAdd.Location = new System.Drawing.Point(12, 230);
            this.grpcAdd.Name = "grpcAdd";
            this.grpcAdd.Size = new System.Drawing.Size(400, 243);
            this.grpcAdd.TabIndex = 7;
            this.grpcAdd.Text = "Add";
            // 
            // txteEMailAdd
            // 
            this.txteEMailAdd.Location = new System.Drawing.Point(136, 167);
            this.txteEMailAdd.Name = "txteEMailAdd";
            this.txteEMailAdd.Size = new System.Drawing.Size(180, 20);
            this.txteEMailAdd.TabIndex = 20;
            // 
            // lblcEMailAdd
            // 
            this.lblcEMailAdd.Location = new System.Drawing.Point(93, 170);
            this.lblcEMailAdd.Name = "lblcEMailAdd";
            this.lblcEMailAdd.Size = new System.Drawing.Size(28, 13);
            this.lblcEMailAdd.TabIndex = 19;
            this.lblcEMailAdd.Text = "E-Mail";
            // 
            // txtePhoneNumberAdd
            // 
            this.txtePhoneNumberAdd.Location = new System.Drawing.Point(136, 141);
            this.txtePhoneNumberAdd.Name = "txtePhoneNumberAdd";
            this.txtePhoneNumberAdd.Size = new System.Drawing.Size(180, 20);
            this.txtePhoneNumberAdd.TabIndex = 16;
            // 
            // lblcPhoneNumberAdd
            // 
            this.lblcPhoneNumberAdd.Location = new System.Drawing.Point(51, 144);
            this.lblcPhoneNumberAdd.Name = "lblcPhoneNumberAdd";
            this.lblcPhoneNumberAdd.Size = new System.Drawing.Size(70, 13);
            this.lblcPhoneNumberAdd.TabIndex = 15;
            this.lblcPhoneNumberAdd.Text = "Phone Number";
            // 
            // sbtnAdd
            // 
            this.sbtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnAdd.ImageOptions.Image")));
            this.sbtnAdd.Location = new System.Drawing.Point(136, 196);
            this.sbtnAdd.Name = "sbtnAdd";
            this.sbtnAdd.Size = new System.Drawing.Size(180, 35);
            this.sbtnAdd.TabIndex = 14;
            this.sbtnAdd.Text = "Add";
            this.sbtnAdd.Click += new System.EventHandler(this.sbtnAdd_Click);
            // 
            // lueDepartmentAdd
            // 
            this.lueDepartmentAdd.Location = new System.Drawing.Point(136, 115);
            this.lueDepartmentAdd.Name = "lueDepartmentAdd";
            this.lueDepartmentAdd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDepartmentAdd.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "Department Name", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueDepartmentAdd.Properties.DropDownRows = 2;
            this.lueDepartmentAdd.Size = new System.Drawing.Size(180, 20);
            this.lueDepartmentAdd.TabIndex = 13;
            // 
            // txteLastNameAdd
            // 
            this.txteLastNameAdd.Location = new System.Drawing.Point(136, 89);
            this.txteLastNameAdd.Name = "txteLastNameAdd";
            this.txteLastNameAdd.Properties.Mask.EditMask = "f0";
            this.txteLastNameAdd.Size = new System.Drawing.Size(180, 20);
            this.txteLastNameAdd.TabIndex = 11;
            // 
            // txteFirstNameAdd
            // 
            this.txteFirstNameAdd.Location = new System.Drawing.Point(136, 63);
            this.txteFirstNameAdd.Name = "txteFirstNameAdd";
            this.txteFirstNameAdd.Size = new System.Drawing.Size(180, 20);
            this.txteFirstNameAdd.TabIndex = 10;
            // 
            // txtePersonalIdAdd
            // 
            this.txtePersonalIdAdd.Location = new System.Drawing.Point(136, 37);
            this.txtePersonalIdAdd.Name = "txtePersonalIdAdd";
            this.txtePersonalIdAdd.Size = new System.Drawing.Size(180, 20);
            this.txtePersonalIdAdd.TabIndex = 9;
            // 
            // lblcDepartmentAdd
            // 
            this.lblcDepartmentAdd.Location = new System.Drawing.Point(64, 118);
            this.lblcDepartmentAdd.Name = "lblcDepartmentAdd";
            this.lblcDepartmentAdd.Size = new System.Drawing.Size(57, 13);
            this.lblcDepartmentAdd.TabIndex = 8;
            this.lblcDepartmentAdd.Text = "Department";
            // 
            // lblcLastNameAdd
            // 
            this.lblcLastNameAdd.Location = new System.Drawing.Point(71, 92);
            this.lblcLastNameAdd.Name = "lblcLastNameAdd";
            this.lblcLastNameAdd.Size = new System.Drawing.Size(50, 13);
            this.lblcLastNameAdd.TabIndex = 7;
            this.lblcLastNameAdd.Text = "Last Name";
            // 
            // lblcFirsNameAdd
            // 
            this.lblcFirsNameAdd.Location = new System.Drawing.Point(70, 66);
            this.lblcFirsNameAdd.Name = "lblcFirsNameAdd";
            this.lblcFirsNameAdd.Size = new System.Drawing.Size(51, 13);
            this.lblcFirsNameAdd.TabIndex = 6;
            this.lblcFirsNameAdd.Text = "First Name";
            // 
            // lblcPersonalIdAdd
            // 
            this.lblcPersonalIdAdd.Location = new System.Drawing.Point(67, 40);
            this.lblcPersonalIdAdd.Name = "lblcPersonalIdAdd";
            this.lblcPersonalIdAdd.Size = new System.Drawing.Size(54, 13);
            this.lblcPersonalIdAdd.TabIndex = 5;
            this.lblcPersonalIdAdd.Text = "Personal Id";
            // 
            // grpcUpdate
            // 
            this.grpcUpdate.Controls.Add(this.txteEMailUpdate);
            this.grpcUpdate.Controls.Add(this.lblcEMailUpdate);
            this.grpcUpdate.Controls.Add(this.txtePhoneNumberUpdate);
            this.grpcUpdate.Controls.Add(this.lblcPhoneNumberUpdate);
            this.grpcUpdate.Controls.Add(this.sbtnDelete);
            this.grpcUpdate.Controls.Add(this.sbtnUpdate);
            this.grpcUpdate.Controls.Add(this.lueDepartmentUpdate);
            this.grpcUpdate.Controls.Add(this.txteLastNameUpdate);
            this.grpcUpdate.Controls.Add(this.txteFirstNameUpdate);
            this.grpcUpdate.Controls.Add(this.txtePersonalIdUpdate);
            this.grpcUpdate.Controls.Add(this.lblcDepartmentUpdate);
            this.grpcUpdate.Controls.Add(this.lblcLastNameUpdate);
            this.grpcUpdate.Controls.Add(this.lblcFirstNameUpdate);
            this.grpcUpdate.Controls.Add(this.lblcPersonalIdUpdate);
            this.grpcUpdate.Location = new System.Drawing.Point(432, 230);
            this.grpcUpdate.Name = "grpcUpdate";
            this.grpcUpdate.Size = new System.Drawing.Size(400, 243);
            this.grpcUpdate.TabIndex = 17;
            this.grpcUpdate.Text = "Update and Delete";
            // 
            // txteEMailUpdate
            // 
            this.txteEMailUpdate.Location = new System.Drawing.Point(136, 163);
            this.txteEMailUpdate.Name = "txteEMailUpdate";
            this.txteEMailUpdate.Size = new System.Drawing.Size(180, 20);
            this.txteEMailUpdate.TabIndex = 26;
            // 
            // lblcEMailUpdate
            // 
            this.lblcEMailUpdate.Location = new System.Drawing.Point(91, 166);
            this.lblcEMailUpdate.Name = "lblcEMailUpdate";
            this.lblcEMailUpdate.Size = new System.Drawing.Size(28, 13);
            this.lblcEMailUpdate.TabIndex = 25;
            this.lblcEMailUpdate.Text = "E-Mail";
            // 
            // txtePhoneNumberUpdate
            // 
            this.txtePhoneNumberUpdate.Location = new System.Drawing.Point(136, 141);
            this.txtePhoneNumberUpdate.Name = "txtePhoneNumberUpdate";
            this.txtePhoneNumberUpdate.Size = new System.Drawing.Size(180, 20);
            this.txtePhoneNumberUpdate.TabIndex = 22;
            // 
            // lblcPhoneNumberUpdate
            // 
            this.lblcPhoneNumberUpdate.Location = new System.Drawing.Point(49, 144);
            this.lblcPhoneNumberUpdate.Name = "lblcPhoneNumberUpdate";
            this.lblcPhoneNumberUpdate.Size = new System.Drawing.Size(70, 13);
            this.lblcPhoneNumberUpdate.TabIndex = 21;
            this.lblcPhoneNumberUpdate.Text = "Phone Number";
            // 
            // sbtnDelete
            // 
            this.sbtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnDelete.ImageOptions.Image")));
            this.sbtnDelete.Location = new System.Drawing.Point(231, 189);
            this.sbtnDelete.Name = "sbtnDelete";
            this.sbtnDelete.Size = new System.Drawing.Size(85, 35);
            this.sbtnDelete.TabIndex = 15;
            this.sbtnDelete.Text = "Delete";
            this.sbtnDelete.Click += new System.EventHandler(this.sbtnDelete_Click);
            // 
            // sbtnUpdate
            // 
            this.sbtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnUpdate.ImageOptions.Image")));
            this.sbtnUpdate.Location = new System.Drawing.Point(136, 189);
            this.sbtnUpdate.Name = "sbtnUpdate";
            this.sbtnUpdate.Size = new System.Drawing.Size(85, 35);
            this.sbtnUpdate.TabIndex = 14;
            this.sbtnUpdate.Text = "Update";
            this.sbtnUpdate.Click += new System.EventHandler(this.sbtnUpdate_Click);
            // 
            // lueDepartmentUpdate
            // 
            this.lueDepartmentUpdate.Location = new System.Drawing.Point(136, 115);
            this.lueDepartmentUpdate.Name = "lueDepartmentUpdate";
            this.lueDepartmentUpdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDepartmentUpdate.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "Department Name", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueDepartmentUpdate.Properties.DropDownRows = 2;
            this.lueDepartmentUpdate.Size = new System.Drawing.Size(180, 20);
            this.lueDepartmentUpdate.TabIndex = 13;
            // 
            // txteLastNameUpdate
            // 
            this.txteLastNameUpdate.Location = new System.Drawing.Point(136, 89);
            this.txteLastNameUpdate.Name = "txteLastNameUpdate";
            this.txteLastNameUpdate.Size = new System.Drawing.Size(180, 20);
            this.txteLastNameUpdate.TabIndex = 11;
            // 
            // txteFirstNameUpdate
            // 
            this.txteFirstNameUpdate.Location = new System.Drawing.Point(136, 63);
            this.txteFirstNameUpdate.Name = "txteFirstNameUpdate";
            this.txteFirstNameUpdate.Size = new System.Drawing.Size(180, 20);
            this.txteFirstNameUpdate.TabIndex = 10;
            // 
            // txtePersonalIdUpdate
            // 
            this.txtePersonalIdUpdate.Location = new System.Drawing.Point(136, 37);
            this.txtePersonalIdUpdate.Name = "txtePersonalIdUpdate";
            this.txtePersonalIdUpdate.Size = new System.Drawing.Size(180, 20);
            this.txtePersonalIdUpdate.TabIndex = 9;
            // 
            // lblcDepartmentUpdate
            // 
            this.lblcDepartmentUpdate.Location = new System.Drawing.Point(62, 118);
            this.lblcDepartmentUpdate.Name = "lblcDepartmentUpdate";
            this.lblcDepartmentUpdate.Size = new System.Drawing.Size(57, 13);
            this.lblcDepartmentUpdate.TabIndex = 8;
            this.lblcDepartmentUpdate.Text = "Department";
            // 
            // lblcLastNameUpdate
            // 
            this.lblcLastNameUpdate.Location = new System.Drawing.Point(69, 92);
            this.lblcLastNameUpdate.Name = "lblcLastNameUpdate";
            this.lblcLastNameUpdate.Size = new System.Drawing.Size(50, 13);
            this.lblcLastNameUpdate.TabIndex = 7;
            this.lblcLastNameUpdate.Text = "Last Name";
            // 
            // lblcFirstNameUpdate
            // 
            this.lblcFirstNameUpdate.Location = new System.Drawing.Point(68, 66);
            this.lblcFirstNameUpdate.Name = "lblcFirstNameUpdate";
            this.lblcFirstNameUpdate.Size = new System.Drawing.Size(51, 13);
            this.lblcFirstNameUpdate.TabIndex = 6;
            this.lblcFirstNameUpdate.Text = "First Name";
            // 
            // lblcPersonalIdUpdate
            // 
            this.lblcPersonalIdUpdate.Location = new System.Drawing.Point(65, 40);
            this.lblcPersonalIdUpdate.Name = "lblcPersonalIdUpdate";
            this.lblcPersonalIdUpdate.Size = new System.Drawing.Size(54, 13);
            this.lblcPersonalIdUpdate.TabIndex = 5;
            this.lblcPersonalIdUpdate.Text = "Personal Id";
            // 
            // FrmCoordinatorStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 487);
            this.Controls.Add(this.grpcUpdate);
            this.Controls.Add(this.grpcAdd);
            this.Controls.Add(this.gcStudent);
            this.Name = "FrmCoordinatorStudent";
            this.Text = "FrmCoordinatorStudent";
            this.Load += new System.EventHandler(this.FrmCoordinatorStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpcAdd)).EndInit();
            this.grpcAdd.ResumeLayout(false);
            this.grpcAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteEMailAdd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtePhoneNumberAdd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDepartmentAdd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteLastNameAdd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteFirstNameAdd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtePersonalIdAdd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpcUpdate)).EndInit();
            this.grpcUpdate.ResumeLayout(false);
            this.grpcUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteEMailUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtePhoneNumberUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDepartmentUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteLastNameUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteFirstNameUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtePersonalIdUpdate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStudent;
        private DevExpress.XtraEditors.GroupControl grpcAdd;
        private DevExpress.XtraEditors.TextEdit txteEMailAdd;
        private DevExpress.XtraEditors.LabelControl lblcEMailAdd;
        private DevExpress.XtraEditors.TextEdit txtePhoneNumberAdd;
        private DevExpress.XtraEditors.LabelControl lblcPhoneNumberAdd;
        private DevExpress.XtraEditors.SimpleButton sbtnAdd;
        private DevExpress.XtraEditors.LookUpEdit lueDepartmentAdd;
        private DevExpress.XtraEditors.TextEdit txteLastNameAdd;
        private DevExpress.XtraEditors.TextEdit txteFirstNameAdd;
        private DevExpress.XtraEditors.TextEdit txtePersonalIdAdd;
        private DevExpress.XtraEditors.LabelControl lblcDepartmentAdd;
        private DevExpress.XtraEditors.LabelControl lblcLastNameAdd;
        private DevExpress.XtraEditors.LabelControl lblcFirsNameAdd;
        private DevExpress.XtraEditors.LabelControl lblcPersonalIdAdd;
        private DevExpress.XtraEditors.GroupControl grpcUpdate;
        private DevExpress.XtraEditors.TextEdit txteEMailUpdate;
        private DevExpress.XtraEditors.LabelControl lblcEMailUpdate;
        private DevExpress.XtraEditors.TextEdit txtePhoneNumberUpdate;
        private DevExpress.XtraEditors.LabelControl lblcPhoneNumberUpdate;
        private DevExpress.XtraEditors.SimpleButton sbtnDelete;
        private DevExpress.XtraEditors.SimpleButton sbtnUpdate;
        private DevExpress.XtraEditors.LookUpEdit lueDepartmentUpdate;
        private DevExpress.XtraEditors.TextEdit txteLastNameUpdate;
        private DevExpress.XtraEditors.TextEdit txteFirstNameUpdate;
        private DevExpress.XtraEditors.TextEdit txtePersonalIdUpdate;
        private DevExpress.XtraEditors.LabelControl lblcDepartmentUpdate;
        private DevExpress.XtraEditors.LabelControl lblcLastNameUpdate;
        private DevExpress.XtraEditors.LabelControl lblcFirstNameUpdate;
        private DevExpress.XtraEditors.LabelControl lblcPersonalIdUpdate;
    }
}