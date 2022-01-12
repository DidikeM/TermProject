
namespace Comp337.WebFormsUI.Forms.InstructorsForms
{
    partial class FrmInstructorCourseInfoAndAddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInstructorCourseInfoAndAddStudent));
            this.grpcAdd = new DevExpress.XtraEditors.GroupControl();
            this.sbtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.txteSemester = new DevExpress.XtraEditors.TextEdit();
            this.sbtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txteCourseCredit = new DevExpress.XtraEditors.TextEdit();
            this.txteCourseName = new DevExpress.XtraEditors.TextEdit();
            this.txteCourseCode = new DevExpress.XtraEditors.TextEdit();
            this.lblcSemester = new DevExpress.XtraEditors.LabelControl();
            this.lblcCourseCredit = new DevExpress.XtraEditors.LabelControl();
            this.lblcCourseName = new DevExpress.XtraEditors.LabelControl();
            this.lblcCourseCode = new DevExpress.XtraEditors.LabelControl();
            this.gcCourse = new DevExpress.XtraGrid.GridControl();
            this.gvCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCourseOfStudent = new DevExpress.XtraGrid.GridControl();
            this.gvCourseOfStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcStudentOfAdvisor = new DevExpress.XtraGrid.GridControl();
            this.gvStudentOfAdvisor = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grpcAdd)).BeginInit();
            this.grpcAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteSemester.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteCourseCredit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteCourseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteCourseCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCourseOfStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourseOfStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudentOfAdvisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentOfAdvisor)).BeginInit();
            this.SuspendLayout();
            // 
            // grpcAdd
            // 
            this.grpcAdd.Controls.Add(this.sbtnDelete);
            this.grpcAdd.Controls.Add(this.txteSemester);
            this.grpcAdd.Controls.Add(this.sbtnAdd);
            this.grpcAdd.Controls.Add(this.txteCourseCredit);
            this.grpcAdd.Controls.Add(this.txteCourseName);
            this.grpcAdd.Controls.Add(this.txteCourseCode);
            this.grpcAdd.Controls.Add(this.lblcSemester);
            this.grpcAdd.Controls.Add(this.lblcCourseCredit);
            this.grpcAdd.Controls.Add(this.lblcCourseName);
            this.grpcAdd.Controls.Add(this.lblcCourseCode);
            this.grpcAdd.Location = new System.Drawing.Point(426, 12);
            this.grpcAdd.Name = "grpcAdd";
            this.grpcAdd.Size = new System.Drawing.Size(408, 226);
            this.grpcAdd.TabIndex = 15;
            // 
            // sbtnDelete
            // 
            this.sbtnDelete.Enabled = false;
            this.sbtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnDelete.ImageOptions.Image")));
            this.sbtnDelete.Location = new System.Drawing.Point(309, 180);
            this.sbtnDelete.Name = "sbtnDelete";
            this.sbtnDelete.Size = new System.Drawing.Size(87, 35);
            this.sbtnDelete.TabIndex = 22;
            this.sbtnDelete.Text = "Delete";
            // 
            // txteSemester
            // 
            this.txteSemester.Enabled = false;
            this.txteSemester.Location = new System.Drawing.Point(216, 148);
            this.txteSemester.Name = "txteSemester";
            this.txteSemester.Size = new System.Drawing.Size(180, 20);
            this.txteSemester.TabIndex = 21;
            // 
            // sbtnAdd
            // 
            this.sbtnAdd.Enabled = false;
            this.sbtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnAdd.ImageOptions.Image")));
            this.sbtnAdd.Location = new System.Drawing.Point(216, 180);
            this.sbtnAdd.Name = "sbtnAdd";
            this.sbtnAdd.Size = new System.Drawing.Size(87, 35);
            this.sbtnAdd.TabIndex = 14;
            this.sbtnAdd.Text = "Add";
            // 
            // txteCourseCredit
            // 
            this.txteCourseCredit.Enabled = false;
            this.txteCourseCredit.Location = new System.Drawing.Point(216, 109);
            this.txteCourseCredit.Name = "txteCourseCredit";
            this.txteCourseCredit.Properties.Mask.EditMask = "f0";
            this.txteCourseCredit.Size = new System.Drawing.Size(180, 20);
            this.txteCourseCredit.TabIndex = 11;
            // 
            // txteCourseName
            // 
            this.txteCourseName.Enabled = false;
            this.txteCourseName.Location = new System.Drawing.Point(216, 73);
            this.txteCourseName.Name = "txteCourseName";
            this.txteCourseName.Size = new System.Drawing.Size(180, 20);
            this.txteCourseName.TabIndex = 10;
            // 
            // txteCourseCode
            // 
            this.txteCourseCode.Enabled = false;
            this.txteCourseCode.Location = new System.Drawing.Point(216, 37);
            this.txteCourseCode.Name = "txteCourseCode";
            this.txteCourseCode.Size = new System.Drawing.Size(180, 20);
            this.txteCourseCode.TabIndex = 9;
            // 
            // lblcSemester
            // 
            this.lblcSemester.Location = new System.Drawing.Point(144, 151);
            this.lblcSemester.Name = "lblcSemester";
            this.lblcSemester.Size = new System.Drawing.Size(57, 13);
            this.lblcSemester.TabIndex = 8;
            this.lblcSemester.Text = "Department";
            // 
            // lblcCourseCredit
            // 
            this.lblcCourseCredit.Location = new System.Drawing.Point(151, 112);
            this.lblcCourseCredit.Name = "lblcCourseCredit";
            this.lblcCourseCredit.Size = new System.Drawing.Size(50, 13);
            this.lblcCourseCredit.TabIndex = 7;
            this.lblcCourseCredit.Text = "Last Name";
            // 
            // lblcCourseName
            // 
            this.lblcCourseName.Location = new System.Drawing.Point(150, 76);
            this.lblcCourseName.Name = "lblcCourseName";
            this.lblcCourseName.Size = new System.Drawing.Size(51, 13);
            this.lblcCourseName.TabIndex = 6;
            this.lblcCourseName.Text = "First Name";
            // 
            // lblcCourseCode
            // 
            this.lblcCourseCode.Location = new System.Drawing.Point(147, 40);
            this.lblcCourseCode.Name = "lblcCourseCode";
            this.lblcCourseCode.Size = new System.Drawing.Size(54, 13);
            this.lblcCourseCode.TabIndex = 5;
            this.lblcCourseCode.Text = "Personal Id";
            // 
            // gcCourse
            // 
            this.gcCourse.Location = new System.Drawing.Point(426, 244);
            this.gcCourse.MainView = this.gvCourse;
            this.gcCourse.Name = "gcCourse";
            this.gcCourse.Size = new System.Drawing.Size(408, 226);
            this.gcCourse.TabIndex = 14;
            this.gcCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCourse});
            // 
            // gvCourse
            // 
            this.gvCourse.GridControl = this.gcCourse;
            this.gvCourse.Name = "gvCourse";
            this.gvCourse.OptionsBehavior.Editable = false;
            this.gvCourse.OptionsView.ShowGroupPanel = false;
            this.gvCourse.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCourse_RowClick);
            // 
            // gcCourseOfStudent
            // 
            this.gcCourseOfStudent.Location = new System.Drawing.Point(12, 244);
            this.gcCourseOfStudent.MainView = this.gvCourseOfStudent;
            this.gcCourseOfStudent.Name = "gcCourseOfStudent";
            this.gcCourseOfStudent.Size = new System.Drawing.Size(408, 226);
            this.gcCourseOfStudent.TabIndex = 13;
            this.gcCourseOfStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCourseOfStudent});
            // 
            // gvCourseOfStudent
            // 
            this.gvCourseOfStudent.GridControl = this.gcCourseOfStudent;
            this.gvCourseOfStudent.Name = "gvCourseOfStudent";
            this.gvCourseOfStudent.OptionsBehavior.Editable = false;
            this.gvCourseOfStudent.OptionsView.ShowGroupPanel = false;
            this.gvCourseOfStudent.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCourseOfStudent_RowClick);
            // 
            // gcStudentOfAdvisor
            // 
            this.gcStudentOfAdvisor.Location = new System.Drawing.Point(12, 12);
            this.gcStudentOfAdvisor.MainView = this.gvStudentOfAdvisor;
            this.gcStudentOfAdvisor.Name = "gcStudentOfAdvisor";
            this.gcStudentOfAdvisor.Size = new System.Drawing.Size(408, 226);
            this.gcStudentOfAdvisor.TabIndex = 12;
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
            // FrmInstructorCourseInfoAndAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 483);
            this.Controls.Add(this.grpcAdd);
            this.Controls.Add(this.gcCourse);
            this.Controls.Add(this.gcCourseOfStudent);
            this.Controls.Add(this.gcStudentOfAdvisor);
            this.Name = "FrmInstructorCourseInfoAndAddStudent";
            this.Text = "FrmInstructorCourseInfoAndAddStudent";
            this.Load += new System.EventHandler(this.FrmInstructorCourseInfoAndAddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpcAdd)).EndInit();
            this.grpcAdd.ResumeLayout(false);
            this.grpcAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteSemester.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteCourseCredit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteCourseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteCourseCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCourseOfStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourseOfStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudentOfAdvisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentOfAdvisor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpcAdd;
        private DevExpress.XtraEditors.SimpleButton sbtnDelete;
        private DevExpress.XtraEditors.TextEdit txteSemester;
        private DevExpress.XtraEditors.SimpleButton sbtnAdd;
        private DevExpress.XtraEditors.TextEdit txteCourseCredit;
        private DevExpress.XtraEditors.TextEdit txteCourseName;
        private DevExpress.XtraEditors.TextEdit txteCourseCode;
        private DevExpress.XtraEditors.LabelControl lblcSemester;
        private DevExpress.XtraEditors.LabelControl lblcCourseCredit;
        private DevExpress.XtraEditors.LabelControl lblcCourseName;
        private DevExpress.XtraEditors.LabelControl lblcCourseCode;
        private DevExpress.XtraGrid.GridControl gcCourse;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCourse;
        private DevExpress.XtraGrid.GridControl gcCourseOfStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCourseOfStudent;
        private DevExpress.XtraGrid.GridControl gcStudentOfAdvisor;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStudentOfAdvisor;
    }
}