
namespace Comp337.WebFormsUI.Forms.CoordinatorForms
{
    partial class FrmCoordinatorAssignmentOfAdvisorToStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCoordinatorAssignmentOfAdvisorToStudent));
            this.grpcAdd = new DevExpress.XtraEditors.GroupControl();
            this.sbtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.txteDepartment = new DevExpress.XtraEditors.TextEdit();
            this.txteEMail = new DevExpress.XtraEditors.TextEdit();
            this.lblcEMail = new DevExpress.XtraEditors.LabelControl();
            this.sbtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txteLastName = new DevExpress.XtraEditors.TextEdit();
            this.txteFirstName = new DevExpress.XtraEditors.TextEdit();
            this.txtePersonalId = new DevExpress.XtraEditors.TextEdit();
            this.lblcDepartment = new DevExpress.XtraEditors.LabelControl();
            this.lblcLastName = new DevExpress.XtraEditors.LabelControl();
            this.lblcFirsName = new DevExpress.XtraEditors.LabelControl();
            this.lblcPersonalId = new DevExpress.XtraEditors.LabelControl();
            this.gcStudent = new DevExpress.XtraGrid.GridControl();
            this.gvStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcStudentOfAdvisor = new DevExpress.XtraGrid.GridControl();
            this.gvStudentOfAdvisor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcAdvisor = new DevExpress.XtraGrid.GridControl();
            this.gvAdvisor = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grpcAdd)).BeginInit();
            this.grpcAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteEMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtePersonalId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudentOfAdvisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentOfAdvisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAdvisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdvisor)).BeginInit();
            this.SuspendLayout();
            // 
            // grpcAdd
            // 
            this.grpcAdd.Controls.Add(this.sbtnDelete);
            this.grpcAdd.Controls.Add(this.txteDepartment);
            this.grpcAdd.Controls.Add(this.txteEMail);
            this.grpcAdd.Controls.Add(this.lblcEMail);
            this.grpcAdd.Controls.Add(this.sbtnAdd);
            this.grpcAdd.Controls.Add(this.txteLastName);
            this.grpcAdd.Controls.Add(this.txteFirstName);
            this.grpcAdd.Controls.Add(this.txtePersonalId);
            this.grpcAdd.Controls.Add(this.lblcDepartment);
            this.grpcAdd.Controls.Add(this.lblcLastName);
            this.grpcAdd.Controls.Add(this.lblcFirsName);
            this.grpcAdd.Controls.Add(this.lblcPersonalId);
            this.grpcAdd.Location = new System.Drawing.Point(425, 12);
            this.grpcAdd.Name = "grpcAdd";
            this.grpcAdd.Size = new System.Drawing.Size(408, 226);
            this.grpcAdd.TabIndex = 11;
            // 
            // sbtnDelete
            // 
            this.sbtnDelete.Enabled = false;
            this.sbtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnDelete.ImageOptions.Image")));
            this.sbtnDelete.Location = new System.Drawing.Point(309, 174);
            this.sbtnDelete.Name = "sbtnDelete";
            this.sbtnDelete.Size = new System.Drawing.Size(87, 35);
            this.sbtnDelete.TabIndex = 22;
            this.sbtnDelete.Text = "Delete";
            this.sbtnDelete.Click += new System.EventHandler(this.sbtnDelete_Click);
            // 
            // txteDepartment
            // 
            this.txteDepartment.Enabled = false;
            this.txteDepartment.Location = new System.Drawing.Point(216, 115);
            this.txteDepartment.Name = "txteDepartment";
            this.txteDepartment.Size = new System.Drawing.Size(180, 20);
            this.txteDepartment.TabIndex = 21;
            // 
            // txteEMail
            // 
            this.txteEMail.Enabled = false;
            this.txteEMail.Location = new System.Drawing.Point(216, 141);
            this.txteEMail.Name = "txteEMail";
            this.txteEMail.Size = new System.Drawing.Size(180, 20);
            this.txteEMail.TabIndex = 20;
            // 
            // lblcEMail
            // 
            this.lblcEMail.Location = new System.Drawing.Point(173, 144);
            this.lblcEMail.Name = "lblcEMail";
            this.lblcEMail.Size = new System.Drawing.Size(28, 13);
            this.lblcEMail.TabIndex = 19;
            this.lblcEMail.Text = "E-Mail";
            // 
            // sbtnAdd
            // 
            this.sbtnAdd.Enabled = false;
            this.sbtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnAdd.ImageOptions.Image")));
            this.sbtnAdd.Location = new System.Drawing.Point(216, 174);
            this.sbtnAdd.Name = "sbtnAdd";
            this.sbtnAdd.Size = new System.Drawing.Size(87, 35);
            this.sbtnAdd.TabIndex = 14;
            this.sbtnAdd.Text = "Add";
            this.sbtnAdd.Click += new System.EventHandler(this.sbtnAdd_Click);
            // 
            // txteLastName
            // 
            this.txteLastName.Enabled = false;
            this.txteLastName.Location = new System.Drawing.Point(216, 89);
            this.txteLastName.Name = "txteLastName";
            this.txteLastName.Properties.Mask.EditMask = "f0";
            this.txteLastName.Size = new System.Drawing.Size(180, 20);
            this.txteLastName.TabIndex = 11;
            // 
            // txteFirstName
            // 
            this.txteFirstName.Enabled = false;
            this.txteFirstName.Location = new System.Drawing.Point(216, 63);
            this.txteFirstName.Name = "txteFirstName";
            this.txteFirstName.Size = new System.Drawing.Size(180, 20);
            this.txteFirstName.TabIndex = 10;
            // 
            // txtePersonalId
            // 
            this.txtePersonalId.Enabled = false;
            this.txtePersonalId.Location = new System.Drawing.Point(216, 37);
            this.txtePersonalId.Name = "txtePersonalId";
            this.txtePersonalId.Size = new System.Drawing.Size(180, 20);
            this.txtePersonalId.TabIndex = 9;
            // 
            // lblcDepartment
            // 
            this.lblcDepartment.Location = new System.Drawing.Point(144, 118);
            this.lblcDepartment.Name = "lblcDepartment";
            this.lblcDepartment.Size = new System.Drawing.Size(57, 13);
            this.lblcDepartment.TabIndex = 8;
            this.lblcDepartment.Text = "Department";
            // 
            // lblcLastName
            // 
            this.lblcLastName.Location = new System.Drawing.Point(151, 92);
            this.lblcLastName.Name = "lblcLastName";
            this.lblcLastName.Size = new System.Drawing.Size(50, 13);
            this.lblcLastName.TabIndex = 7;
            this.lblcLastName.Text = "Last Name";
            // 
            // lblcFirsName
            // 
            this.lblcFirsName.Location = new System.Drawing.Point(150, 66);
            this.lblcFirsName.Name = "lblcFirsName";
            this.lblcFirsName.Size = new System.Drawing.Size(51, 13);
            this.lblcFirsName.TabIndex = 6;
            this.lblcFirsName.Text = "First Name";
            // 
            // lblcPersonalId
            // 
            this.lblcPersonalId.Location = new System.Drawing.Point(147, 40);
            this.lblcPersonalId.Name = "lblcPersonalId";
            this.lblcPersonalId.Size = new System.Drawing.Size(54, 13);
            this.lblcPersonalId.TabIndex = 5;
            this.lblcPersonalId.Text = "Personal Id";
            // 
            // gcStudent
            // 
            this.gcStudent.Location = new System.Drawing.Point(425, 244);
            this.gcStudent.MainView = this.gvStudent;
            this.gcStudent.Name = "gcStudent";
            this.gcStudent.Size = new System.Drawing.Size(408, 226);
            this.gcStudent.TabIndex = 10;
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
            // gcStudentOfAdvisor
            // 
            this.gcStudentOfAdvisor.Location = new System.Drawing.Point(11, 244);
            this.gcStudentOfAdvisor.MainView = this.gvStudentOfAdvisor;
            this.gcStudentOfAdvisor.Name = "gcStudentOfAdvisor";
            this.gcStudentOfAdvisor.Size = new System.Drawing.Size(408, 226);
            this.gcStudentOfAdvisor.TabIndex = 9;
            this.gcStudentOfAdvisor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStudentOfAdvisor});
            // 
            // gvStudentOfAdvisor
            // 
            this.gvStudentOfAdvisor.GridControl = this.gcStudentOfAdvisor;
            this.gvStudentOfAdvisor.Name = "gvStudentOfAdvisor";
            this.gvStudentOfAdvisor.OptionsBehavior.Editable = false;
            this.gvStudentOfAdvisor.OptionsView.ShowGroupPanel = false;
            this.gvStudentOfAdvisor.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvStudentOfAdvisor_RowClick);
            // 
            // gcAdvisor
            // 
            this.gcAdvisor.Location = new System.Drawing.Point(11, 12);
            this.gcAdvisor.MainView = this.gvAdvisor;
            this.gcAdvisor.Name = "gcAdvisor";
            this.gcAdvisor.Size = new System.Drawing.Size(408, 226);
            this.gcAdvisor.TabIndex = 8;
            this.gcAdvisor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAdvisor});
            // 
            // gvAdvisor
            // 
            this.gvAdvisor.GridControl = this.gcAdvisor;
            this.gvAdvisor.Name = "gvAdvisor";
            this.gvAdvisor.OptionsBehavior.Editable = false;
            this.gvAdvisor.OptionsView.ShowGroupPanel = false;
            this.gvAdvisor.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvAdvisor_RowClick);
            // 
            // FrmCoordinatorAssignmentOfAdvisorToStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 492);
            this.Controls.Add(this.grpcAdd);
            this.Controls.Add(this.gcStudent);
            this.Controls.Add(this.gcStudentOfAdvisor);
            this.Controls.Add(this.gcAdvisor);
            this.Name = "FrmCoordinatorAssignmentOfAdvisorToStudent";
            this.Text = "FrmcoordinatorAssignmentOfAdvisorToStudent";
            this.Load += new System.EventHandler(this.FrmCoordinatorAssignmentOfAdvisorToStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpcAdd)).EndInit();
            this.grpcAdd.ResumeLayout(false);
            this.grpcAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteEMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtePersonalId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudentOfAdvisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentOfAdvisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAdvisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdvisor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpcAdd;
        private DevExpress.XtraEditors.SimpleButton sbtnDelete;
        private DevExpress.XtraEditors.TextEdit txteDepartment;
        private DevExpress.XtraEditors.TextEdit txteEMail;
        private DevExpress.XtraEditors.LabelControl lblcEMail;
        private DevExpress.XtraEditors.SimpleButton sbtnAdd;
        private DevExpress.XtraEditors.TextEdit txteLastName;
        private DevExpress.XtraEditors.TextEdit txteFirstName;
        private DevExpress.XtraEditors.TextEdit txtePersonalId;
        private DevExpress.XtraEditors.LabelControl lblcDepartment;
        private DevExpress.XtraEditors.LabelControl lblcLastName;
        private DevExpress.XtraEditors.LabelControl lblcFirsName;
        private DevExpress.XtraEditors.LabelControl lblcPersonalId;
        private DevExpress.XtraGrid.GridControl gcStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStudent;
        private DevExpress.XtraGrid.GridControl gcStudentOfAdvisor;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStudentOfAdvisor;
        private DevExpress.XtraGrid.GridControl gcAdvisor;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAdvisor;
    }
}