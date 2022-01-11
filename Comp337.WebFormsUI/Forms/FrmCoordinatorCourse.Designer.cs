
namespace Comp337.WebFormsUI.Forms
{
    partial class FrmCoordinatorCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCoordinatorCourse));
            this.gvCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCourse = new DevExpress.XtraGrid.GridControl();
            this.grpcAdd = new DevExpress.XtraEditors.GroupControl();
            this.sbtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.lueSemesterAdd = new DevExpress.XtraEditors.LookUpEdit();
            this.txteCourseCreditAdd = new DevExpress.XtraEditors.TextEdit();
            this.txteCourseNameAdd = new DevExpress.XtraEditors.TextEdit();
            this.txteCourseCodeAdd = new DevExpress.XtraEditors.TextEdit();
            this.lblcSemesterAdd = new DevExpress.XtraEditors.LabelControl();
            this.lblcCourseCreditAdd = new DevExpress.XtraEditors.LabelControl();
            this.lblcCourseNameAdd = new DevExpress.XtraEditors.LabelControl();
            this.lblcCourseCodeAdd = new DevExpress.XtraEditors.LabelControl();
            this.grpcUpdate = new DevExpress.XtraEditors.GroupControl();
            this.sbtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.lueSemesterUpdate = new DevExpress.XtraEditors.LookUpEdit();
            this.txteCourseCreditUpdate = new DevExpress.XtraEditors.TextEdit();
            this.txteCourseNameUpdate = new DevExpress.XtraEditors.TextEdit();
            this.txteCourseCodeUpdate = new DevExpress.XtraEditors.TextEdit();
            this.lblcSemesterUpdate = new DevExpress.XtraEditors.LabelControl();
            this.lblcCourseCreditUpdate = new DevExpress.XtraEditors.LabelControl();
            this.lblcCourseNameUpdate = new DevExpress.XtraEditors.LabelControl();
            this.lblcCourseCodeUpdate = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpcAdd)).BeginInit();
            this.grpcAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueSemesterAdd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteCourseCreditAdd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteCourseNameAdd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteCourseCodeAdd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpcUpdate)).BeginInit();
            this.grpcUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueSemesterUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteCourseCreditUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteCourseNameUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteCourseCodeUpdate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gvCourse
            // 
            this.gvCourse.GridControl = this.gcCourse;
            this.gvCourse.Name = "gvCourse";
            this.gvCourse.OptionsBehavior.Editable = false;
            this.gvCourse.OptionsView.ShowGroupPanel = false;
            this.gvCourse.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCourse_RowClick);
            // 
            // gcCourse
            // 
            this.gcCourse.Location = new System.Drawing.Point(12, 12);
            this.gcCourse.MainView = this.gvCourse;
            this.gcCourse.Name = "gcCourse";
            this.gcCourse.Size = new System.Drawing.Size(820, 210);
            this.gcCourse.TabIndex = 0;
            this.gcCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCourse});
            // 
            // grpcAdd
            // 
            this.grpcAdd.Controls.Add(this.sbtnAdd);
            this.grpcAdd.Controls.Add(this.lueSemesterAdd);
            this.grpcAdd.Controls.Add(this.txteCourseCreditAdd);
            this.grpcAdd.Controls.Add(this.txteCourseNameAdd);
            this.grpcAdd.Controls.Add(this.txteCourseCodeAdd);
            this.grpcAdd.Controls.Add(this.lblcSemesterAdd);
            this.grpcAdd.Controls.Add(this.lblcCourseCreditAdd);
            this.grpcAdd.Controls.Add(this.lblcCourseNameAdd);
            this.grpcAdd.Controls.Add(this.lblcCourseCodeAdd);
            this.grpcAdd.Location = new System.Drawing.Point(12, 228);
            this.grpcAdd.Name = "grpcAdd";
            this.grpcAdd.Size = new System.Drawing.Size(400, 200);
            this.grpcAdd.TabIndex = 5;
            this.grpcAdd.Text = "Add";
            // 
            // sbtnAdd
            // 
            this.sbtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnAdd.ImageOptions.Image")));
            this.sbtnAdd.Location = new System.Drawing.Point(136, 151);
            this.sbtnAdd.Name = "sbtnAdd";
            this.sbtnAdd.Size = new System.Drawing.Size(180, 35);
            this.sbtnAdd.TabIndex = 14;
            this.sbtnAdd.Text = "Add";
            this.sbtnAdd.Click += new System.EventHandler(this.sbtnAdd_Click);
            // 
            // lueSemesterAdd
            // 
            this.lueSemesterAdd.Location = new System.Drawing.Point(136, 125);
            this.lueSemesterAdd.Name = "lueSemesterAdd";
            this.lueSemesterAdd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSemesterAdd.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Semesters", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueSemesterAdd.Properties.DropDownRows = 2;
            this.lueSemesterAdd.Size = new System.Drawing.Size(180, 20);
            this.lueSemesterAdd.TabIndex = 13;
            // 
            // txteCourseCreditAdd
            // 
            this.txteCourseCreditAdd.Location = new System.Drawing.Point(136, 95);
            this.txteCourseCreditAdd.Name = "txteCourseCreditAdd";
            this.txteCourseCreditAdd.Properties.Mask.EditMask = "f0";
            this.txteCourseCreditAdd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txteCourseCreditAdd.Size = new System.Drawing.Size(180, 20);
            this.txteCourseCreditAdd.TabIndex = 11;
            // 
            // txteCourseNameAdd
            // 
            this.txteCourseNameAdd.Location = new System.Drawing.Point(136, 65);
            this.txteCourseNameAdd.Name = "txteCourseNameAdd";
            this.txteCourseNameAdd.Size = new System.Drawing.Size(180, 20);
            this.txteCourseNameAdd.TabIndex = 10;
            // 
            // txteCourseCodeAdd
            // 
            this.txteCourseCodeAdd.Location = new System.Drawing.Point(136, 37);
            this.txteCourseCodeAdd.Name = "txteCourseCodeAdd";
            this.txteCourseCodeAdd.Size = new System.Drawing.Size(180, 20);
            this.txteCourseCodeAdd.TabIndex = 9;
            // 
            // lblcSemesterAdd
            // 
            this.lblcSemesterAdd.Location = new System.Drawing.Point(31, 128);
            this.lblcSemesterAdd.Name = "lblcSemesterAdd";
            this.lblcSemesterAdd.Size = new System.Drawing.Size(76, 13);
            this.lblcSemesterAdd.TabIndex = 8;
            this.lblcSemesterAdd.Text = "Curse Semester";
            // 
            // lblcCourseCreditAdd
            // 
            this.lblcCourseCreditAdd.Location = new System.Drawing.Point(41, 98);
            this.lblcCourseCreditAdd.Name = "lblcCourseCreditAdd";
            this.lblcCourseCreditAdd.Size = new System.Drawing.Size(66, 13);
            this.lblcCourseCreditAdd.TabIndex = 7;
            this.lblcCourseCreditAdd.Text = "Course Credit";
            // 
            // lblcCourseNameAdd
            // 
            this.lblcCourseNameAdd.Location = new System.Drawing.Point(43, 68);
            this.lblcCourseNameAdd.Name = "lblcCourseNameAdd";
            this.lblcCourseNameAdd.Size = new System.Drawing.Size(64, 13);
            this.lblcCourseNameAdd.TabIndex = 6;
            this.lblcCourseNameAdd.Text = "Course Name";
            // 
            // lblcCourseCodeAdd
            // 
            this.lblcCourseCodeAdd.Location = new System.Drawing.Point(45, 40);
            this.lblcCourseCodeAdd.Name = "lblcCourseCodeAdd";
            this.lblcCourseCodeAdd.Size = new System.Drawing.Size(62, 13);
            this.lblcCourseCodeAdd.TabIndex = 5;
            this.lblcCourseCodeAdd.Text = "Course Code";
            // 
            // grpcUpdate
            // 
            this.grpcUpdate.Controls.Add(this.sbtnDelete);
            this.grpcUpdate.Controls.Add(this.sbtnUpdate);
            this.grpcUpdate.Controls.Add(this.lueSemesterUpdate);
            this.grpcUpdate.Controls.Add(this.txteCourseCreditUpdate);
            this.grpcUpdate.Controls.Add(this.txteCourseNameUpdate);
            this.grpcUpdate.Controls.Add(this.txteCourseCodeUpdate);
            this.grpcUpdate.Controls.Add(this.lblcSemesterUpdate);
            this.grpcUpdate.Controls.Add(this.lblcCourseCreditUpdate);
            this.grpcUpdate.Controls.Add(this.lblcCourseNameUpdate);
            this.grpcUpdate.Controls.Add(this.lblcCourseCodeUpdate);
            this.grpcUpdate.Location = new System.Drawing.Point(432, 228);
            this.grpcUpdate.Name = "grpcUpdate";
            this.grpcUpdate.Size = new System.Drawing.Size(400, 200);
            this.grpcUpdate.TabIndex = 15;
            this.grpcUpdate.Text = "Update and Remove";
            // 
            // sbtnDelete
            // 
            this.sbtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnDelete.ImageOptions.Image")));
            this.sbtnDelete.Location = new System.Drawing.Point(231, 151);
            this.sbtnDelete.Name = "sbtnDelete";
            this.sbtnDelete.Size = new System.Drawing.Size(85, 35);
            this.sbtnDelete.TabIndex = 15;
            this.sbtnDelete.Text = "Delete";
            this.sbtnDelete.Click += new System.EventHandler(this.sbtnDelete_Click);
            // 
            // sbtnUpdate
            // 
            this.sbtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnUpdate.ImageOptions.Image")));
            this.sbtnUpdate.Location = new System.Drawing.Point(136, 151);
            this.sbtnUpdate.Name = "sbtnUpdate";
            this.sbtnUpdate.Size = new System.Drawing.Size(85, 35);
            this.sbtnUpdate.TabIndex = 14;
            this.sbtnUpdate.Text = "Update";
            this.sbtnUpdate.Click += new System.EventHandler(this.sbtnUpdate_Click);
            // 
            // lueSemesterUpdate
            // 
            this.lueSemesterUpdate.Location = new System.Drawing.Point(136, 125);
            this.lueSemesterUpdate.Name = "lueSemesterUpdate";
            this.lueSemesterUpdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSemesterUpdate.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Semesters", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueSemesterUpdate.Properties.DropDownRows = 2;
            this.lueSemesterUpdate.Size = new System.Drawing.Size(180, 20);
            this.lueSemesterUpdate.TabIndex = 13;
            // 
            // txteCourseCreditUpdate
            // 
            this.txteCourseCreditUpdate.Location = new System.Drawing.Point(136, 95);
            this.txteCourseCreditUpdate.Name = "txteCourseCreditUpdate";
            this.txteCourseCreditUpdate.Properties.Mask.EditMask = "f0";
            this.txteCourseCreditUpdate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txteCourseCreditUpdate.Size = new System.Drawing.Size(180, 20);
            this.txteCourseCreditUpdate.TabIndex = 11;
            // 
            // txteCourseNameUpdate
            // 
            this.txteCourseNameUpdate.Location = new System.Drawing.Point(136, 65);
            this.txteCourseNameUpdate.Name = "txteCourseNameUpdate";
            this.txteCourseNameUpdate.Size = new System.Drawing.Size(180, 20);
            this.txteCourseNameUpdate.TabIndex = 10;
            // 
            // txteCourseCodeUpdate
            // 
            this.txteCourseCodeUpdate.Location = new System.Drawing.Point(136, 37);
            this.txteCourseCodeUpdate.Name = "txteCourseCodeUpdate";
            this.txteCourseCodeUpdate.Size = new System.Drawing.Size(180, 20);
            this.txteCourseCodeUpdate.TabIndex = 9;
            // 
            // lblcSemesterUpdate
            // 
            this.lblcSemesterUpdate.Location = new System.Drawing.Point(31, 128);
            this.lblcSemesterUpdate.Name = "lblcSemesterUpdate";
            this.lblcSemesterUpdate.Size = new System.Drawing.Size(76, 13);
            this.lblcSemesterUpdate.TabIndex = 8;
            this.lblcSemesterUpdate.Text = "Curse Semester";
            // 
            // lblcCourseCreditUpdate
            // 
            this.lblcCourseCreditUpdate.Location = new System.Drawing.Point(41, 98);
            this.lblcCourseCreditUpdate.Name = "lblcCourseCreditUpdate";
            this.lblcCourseCreditUpdate.Size = new System.Drawing.Size(66, 13);
            this.lblcCourseCreditUpdate.TabIndex = 7;
            this.lblcCourseCreditUpdate.Text = "Course Credit";
            // 
            // lblcCourseNameUpdate
            // 
            this.lblcCourseNameUpdate.Location = new System.Drawing.Point(43, 68);
            this.lblcCourseNameUpdate.Name = "lblcCourseNameUpdate";
            this.lblcCourseNameUpdate.Size = new System.Drawing.Size(64, 13);
            this.lblcCourseNameUpdate.TabIndex = 6;
            this.lblcCourseNameUpdate.Text = "Course Name";
            // 
            // lblcCourseCodeUpdate
            // 
            this.lblcCourseCodeUpdate.Location = new System.Drawing.Point(45, 40);
            this.lblcCourseCodeUpdate.Name = "lblcCourseCodeUpdate";
            this.lblcCourseCodeUpdate.Size = new System.Drawing.Size(62, 13);
            this.lblcCourseCodeUpdate.TabIndex = 5;
            this.lblcCourseCodeUpdate.Text = "Course Code";
            // 
            // FrmCoordinatorCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 447);
            this.Controls.Add(this.grpcUpdate);
            this.Controls.Add(this.grpcAdd);
            this.Controls.Add(this.gcCourse);
            this.Name = "FrmCoordinatorCourse";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.FrmCoordinatorCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpcAdd)).EndInit();
            this.grpcAdd.ResumeLayout(false);
            this.grpcAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueSemesterAdd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteCourseCreditAdd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteCourseNameAdd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteCourseCodeAdd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpcUpdate)).EndInit();
            this.grpcUpdate.ResumeLayout(false);
            this.grpcUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueSemesterUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteCourseCreditUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteCourseNameUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteCourseCodeUpdate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCourse;
        private DevExpress.XtraEditors.GroupControl grpcAdd;
        private DevExpress.XtraEditors.TextEdit txteCourseCreditAdd;
        private DevExpress.XtraEditors.TextEdit txteCourseNameAdd;
        private DevExpress.XtraEditors.TextEdit txteCourseCodeAdd;
        private DevExpress.XtraEditors.LabelControl lblcSemesterAdd;
        private DevExpress.XtraEditors.LabelControl lblcCourseCreditAdd;
        private DevExpress.XtraEditors.LabelControl lblcCourseNameAdd;
        private DevExpress.XtraEditors.LabelControl lblcCourseCodeAdd;
        private DevExpress.XtraEditors.LookUpEdit lueSemesterAdd;
        private DevExpress.XtraEditors.SimpleButton sbtnAdd;
        private DevExpress.XtraEditors.GroupControl grpcUpdate;
        private DevExpress.XtraEditors.SimpleButton sbtnUpdate;
        private DevExpress.XtraEditors.LookUpEdit lueSemesterUpdate;
        private DevExpress.XtraEditors.TextEdit txteCourseCreditUpdate;
        private DevExpress.XtraEditors.TextEdit txteCourseNameUpdate;
        private DevExpress.XtraEditors.TextEdit txteCourseCodeUpdate;
        private DevExpress.XtraEditors.LabelControl lblcSemesterUpdate;
        private DevExpress.XtraEditors.LabelControl lblcCourseCreditUpdate;
        private DevExpress.XtraEditors.LabelControl lblcCourseNameUpdate;
        private DevExpress.XtraEditors.LabelControl lblcCourseCodeUpdate;
        private DevExpress.XtraEditors.SimpleButton sbtnDelete;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCourse;
    }
}