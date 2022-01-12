
namespace Comp337.WebFormsUI.Forms.CoordinatorForms
{
    partial class FrmCoordinatorAssignmentOfInstructorToCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCoordinatorAssignmentOfInstructorToCourse));
            this.gcInstructor = new DevExpress.XtraGrid.GridControl();
            this.gvInstructor = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.gcCourse = new DevExpress.XtraGrid.GridControl();
            this.gvCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CourseCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CourseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CourseCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SemesterId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcInstructorOfCourse = new DevExpress.XtraGrid.GridControl();
            this.gvInstructorOfCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcInstructor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInstructor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpcAdd)).BeginInit();
            this.grpcAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteEMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtePersonalId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInstructorOfCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInstructorOfCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // gcInstructor
            // 
            this.gcInstructor.Location = new System.Drawing.Point(426, 244);
            this.gcInstructor.MainView = this.gvInstructor;
            this.gcInstructor.Name = "gcInstructor";
            this.gcInstructor.Size = new System.Drawing.Size(408, 226);
            this.gcInstructor.TabIndex = 3;
            this.gcInstructor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInstructor});
            // 
            // gvInstructor
            // 
            this.gvInstructor.GridControl = this.gcInstructor;
            this.gvInstructor.Name = "gvInstructor";
            this.gvInstructor.OptionsBehavior.Editable = false;
            this.gvInstructor.OptionsView.ShowGroupPanel = false;
            this.gvInstructor.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvInstructor_RowClick);
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
            this.grpcAdd.Location = new System.Drawing.Point(426, 12);
            this.grpcAdd.Name = "grpcAdd";
            this.grpcAdd.Size = new System.Drawing.Size(408, 226);
            this.grpcAdd.TabIndex = 7;
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
            // gcCourse
            // 
            this.gcCourse.Location = new System.Drawing.Point(12, 12);
            this.gcCourse.MainView = this.gvCourse;
            this.gcCourse.Name = "gcCourse";
            this.gcCourse.Size = new System.Drawing.Size(408, 226);
            this.gcCourse.TabIndex = 8;
            this.gcCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCourse});
            // 
            // gvCourse
            // 
            this.gvCourse.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.CourseCode,
            this.CourseName,
            this.CourseCredit,
            this.SemesterId});
            this.gvCourse.GridControl = this.gcCourse;
            this.gvCourse.Name = "gvCourse";
            this.gvCourse.OptionsBehavior.Editable = false;
            this.gvCourse.OptionsView.ShowGroupPanel = false;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // CourseCode
            // 
            this.CourseCode.Caption = "Course Code";
            this.CourseCode.FieldName = "CourseCode";
            this.CourseCode.Name = "CourseCode";
            this.CourseCode.Visible = true;
            this.CourseCode.VisibleIndex = 0;
            // 
            // CourseName
            // 
            this.CourseName.Caption = "Course Name";
            this.CourseName.FieldName = "CourseName";
            this.CourseName.Name = "CourseName";
            this.CourseName.Visible = true;
            this.CourseName.VisibleIndex = 1;
            // 
            // CourseCredit
            // 
            this.CourseCredit.Caption = "Course Credit";
            this.CourseCredit.FieldName = "CourseCredit";
            this.CourseCredit.Name = "CourseCredit";
            this.CourseCredit.Visible = true;
            this.CourseCredit.VisibleIndex = 2;
            // 
            // SemesterId
            // 
            this.SemesterId.Caption = "Semester Id";
            this.SemesterId.FieldName = "SemesterId";
            this.SemesterId.Name = "SemesterId";
            this.SemesterId.Visible = true;
            this.SemesterId.VisibleIndex = 3;
            // 
            // gcInstructorOfCourse
            // 
            this.gcInstructorOfCourse.Location = new System.Drawing.Point(12, 244);
            this.gcInstructorOfCourse.MainView = this.gvInstructorOfCourse;
            this.gcInstructorOfCourse.Name = "gcInstructorOfCourse";
            this.gcInstructorOfCourse.Size = new System.Drawing.Size(408, 226);
            this.gcInstructorOfCourse.TabIndex = 9;
            this.gcInstructorOfCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInstructorOfCourse});
            // 
            // gvInstructorOfCourse
            // 
            this.gvInstructorOfCourse.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gvInstructorOfCourse.GridControl = this.gcInstructorOfCourse;
            this.gvInstructorOfCourse.Name = "gvInstructorOfCourse";
            this.gvInstructorOfCourse.OptionsBehavior.Editable = false;
            this.gvInstructorOfCourse.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Personal Id";
            this.gridColumn2.FieldName = "PersonalId";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "First Name";
            this.gridColumn3.FieldName = "FirstName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Last Name";
            this.gridColumn4.FieldName = "LastName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Department Id";
            this.gridColumn5.FieldName = "DepartmentId";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Phone Number";
            this.gridColumn6.FieldName = "PhoneNumber";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Extension Number";
            this.gridColumn7.FieldName = "ExtensionNumber";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "E-Mail";
            this.gridColumn8.FieldName = "Email";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            // 
            // FrmCoordinatorAssignmentOfInstructorToCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 500);
            this.Controls.Add(this.gcInstructorOfCourse);
            this.Controls.Add(this.gcCourse);
            this.Controls.Add(this.grpcAdd);
            this.Controls.Add(this.gcInstructor);
            this.Name = "FrmCoordinatorAssignmentOfInstructorToCourse";
            this.Text = "FrmCoordinatorAssignmentOfInstructorToCourse";
            this.Load += new System.EventHandler(this.FrmCoordinatorAssignmentOfInstructorToCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcInstructor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInstructor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpcAdd)).EndInit();
            this.grpcAdd.ResumeLayout(false);
            this.grpcAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteEMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtePersonalId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInstructorOfCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInstructorOfCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcInstructor;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInstructor;
        private DevExpress.XtraEditors.GroupControl grpcAdd;
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
        private DevExpress.XtraEditors.TextEdit txteDepartment;
        private DevExpress.XtraEditors.SimpleButton sbtnDelete;
        private DevExpress.XtraGrid.GridControl gcCourse;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCourse;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn CourseCode;
        private DevExpress.XtraGrid.Columns.GridColumn CourseName;
        private DevExpress.XtraGrid.Columns.GridColumn CourseCredit;
        private DevExpress.XtraGrid.Columns.GridColumn SemesterId;
        private DevExpress.XtraGrid.GridControl gcInstructorOfCourse;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInstructorOfCourse;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}