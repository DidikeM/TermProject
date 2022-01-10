
namespace Comp337.WebFormsUI.Forms
{
    partial class BaseForm
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.tabloBaseForm = new DevExpress.XtraLayout.LayoutControl();
            this.txtCourseCredit = new DevExpress.XtraEditors.TextEdit();
            this.txtCourseName = new DevExpress.XtraEditors.TextEdit();
            this.grcCourse = new DevExpress.XtraGrid.GridControl();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comp337DataSet = new Comp337.WebFormsUI.Comp337DataSet();
            this.grwCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCourseId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourseCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSectionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleteFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSectionId = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtCourseNamel = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtCourseCreditl = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtSectionIdl = new DevExpress.XtraLayout.LayoutControlItem();
            this.coursesTableAdapter = new Comp337.WebFormsUI.Comp337DataSetTableAdapters.CoursesTableAdapter();
            this.comp337DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comp337DataSet1 = new Comp337.WebFormsUI.Comp337DataSet1();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionsTableAdapter = new Comp337.WebFormsUI.Comp337DataSet1TableAdapters.SectionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloBaseForm)).BeginInit();
            this.tabloBaseForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCourseCredit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCourseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp337DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grwCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSectionId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCourseNamel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCourseCreditl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSectionIdl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp337DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp337DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(990, 158);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Save";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = global::Comp337.WebFormsUI.Properties.Resources.save_16x16;
            this.barButtonItem1.ImageOptions.LargeImage = global::Comp337.WebFormsUI.Properties.Resources.save_32x32;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Delete";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = global::Comp337.WebFormsUI.Properties.Resources.deletelist_16x16;
            this.barButtonItem2.ImageOptions.LargeImage = global::Comp337.WebFormsUI.Properties.Resources.deletelist_32x32;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "New Record";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.Image = global::Comp337.WebFormsUI.Properties.Resources.addfile_16x16;
            this.barButtonItem3.ImageOptions.LargeImage = global::Comp337.WebFormsUI.Properties.Resources.addfile_32x32;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Menu";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 541);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(990, 24);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // tabloBaseForm
            // 
            this.tabloBaseForm.Controls.Add(this.txtCourseCredit);
            this.tabloBaseForm.Controls.Add(this.txtCourseName);
            this.tabloBaseForm.Controls.Add(this.grcCourse);
            this.tabloBaseForm.Controls.Add(this.txtSectionId);
            this.tabloBaseForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabloBaseForm.Location = new System.Drawing.Point(0, 158);
            this.tabloBaseForm.Name = "tabloBaseForm";
            this.tabloBaseForm.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(356, 181, 650, 392);
            this.tabloBaseForm.Root = this.Root;
            this.tabloBaseForm.Size = new System.Drawing.Size(990, 383);
            this.tabloBaseForm.TabIndex = 2;
            this.tabloBaseForm.Text = "layoutControl1";
            // 
            // txtCourseCredit
            // 
            this.txtCourseCredit.Location = new System.Drawing.Point(708, 36);
            this.txtCourseCredit.MenuManager = this.ribbonControl1;
            this.txtCourseCredit.Name = "txtCourseCredit";
            this.txtCourseCredit.Size = new System.Drawing.Size(270, 20);
            this.txtCourseCredit.StyleController = this.tabloBaseForm;
            this.txtCourseCredit.TabIndex = 6;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(708, 12);
            this.txtCourseName.MenuManager = this.ribbonControl1;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(270, 20);
            this.txtCourseName.StyleController = this.tabloBaseForm;
            this.txtCourseName.TabIndex = 5;
            // 
            // grcCourse
            // 
            this.grcCourse.DataSource = this.coursesBindingSource;
            this.grcCourse.Location = new System.Drawing.Point(12, 12);
            this.grcCourse.MainView = this.grwCourse;
            this.grcCourse.MenuManager = this.ribbonControl1;
            this.grcCourse.Name = "grcCourse";
            this.grcCourse.Size = new System.Drawing.Size(616, 359);
            this.grcCourse.TabIndex = 4;
            this.grcCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grwCourse});
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.comp337DataSet;
            // 
            // comp337DataSet
            // 
            this.comp337DataSet.DataSetName = "Comp337DataSet";
            this.comp337DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grwCourse
            // 
            this.grwCourse.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCourseId,
            this.colCourseName,
            this.colCourseCredit,
            this.colSectionId,
            this.colDeleteFlag});
            this.grwCourse.GridControl = this.grcCourse;
            this.grwCourse.Name = "grwCourse";
            // 
            // colCourseId
            // 
            this.colCourseId.FieldName = "CourseId";
            this.colCourseId.Name = "colCourseId";
            // 
            // colCourseName
            // 
            this.colCourseName.FieldName = "Course Name";
            this.colCourseName.Name = "colCourseName";
            this.colCourseName.Visible = true;
            this.colCourseName.VisibleIndex = 0;
            // 
            // colCourseCredit
            // 
            this.colCourseCredit.FieldName = "Course Credit";
            this.colCourseCredit.Name = "colCourseCredit";
            this.colCourseCredit.Visible = true;
            this.colCourseCredit.VisibleIndex = 1;
            // 
            // colSectionId
            // 
            this.colSectionId.FieldName = "Section Name";
            this.colSectionId.Name = "colSectionId";
            this.colSectionId.Visible = true;
            this.colSectionId.VisibleIndex = 2;
            // 
            // colDeleteFlag
            // 
            this.colDeleteFlag.FieldName = "DeleteFlag";
            this.colDeleteFlag.Name = "colDeleteFlag";
            // 
            // txtSectionId
            // 
            this.txtSectionId.Location = new System.Drawing.Point(708, 60);
            this.txtSectionId.MenuManager = this.ribbonControl1;
            this.txtSectionId.Name = "txtSectionId";
            this.txtSectionId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSectionId.Properties.DataSource = this.sectionsBindingSource;
            this.txtSectionId.Properties.DisplayMember = "SectionName";
            this.txtSectionId.Properties.NullText = "";
            this.txtSectionId.Properties.ValueMember = "SectionId";
            this.txtSectionId.Size = new System.Drawing.Size(270, 20);
            this.txtSectionId.StyleController = this.tabloBaseForm;
            this.txtSectionId.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.txtCourseNamel,
            this.txtCourseCreditl,
            this.txtSectionIdl});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(990, 383);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grcCourse;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(620, 363);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // txtCourseNamel
            // 
            this.txtCourseNamel.Control = this.txtCourseName;
            this.txtCourseNamel.Location = new System.Drawing.Point(620, 0);
            this.txtCourseNamel.Name = "txtCourseNamel";
            this.txtCourseNamel.Size = new System.Drawing.Size(350, 24);
            this.txtCourseNamel.Text = "Course Name :";
            this.txtCourseNamel.TextSize = new System.Drawing.Size(73, 13);
            // 
            // txtCourseCreditl
            // 
            this.txtCourseCreditl.Control = this.txtCourseCredit;
            this.txtCourseCreditl.Location = new System.Drawing.Point(620, 24);
            this.txtCourseCreditl.Name = "txtCourseCreditl";
            this.txtCourseCreditl.Size = new System.Drawing.Size(350, 24);
            this.txtCourseCreditl.Text = "Course Credit :";
            this.txtCourseCreditl.TextSize = new System.Drawing.Size(73, 13);
            // 
            // txtSectionIdl
            // 
            this.txtSectionIdl.Control = this.txtSectionId;
            this.txtSectionIdl.Location = new System.Drawing.Point(620, 48);
            this.txtSectionIdl.Name = "txtSectionIdl";
            this.txtSectionIdl.Size = new System.Drawing.Size(350, 315);
            this.txtSectionIdl.Text = "Section Name";
            this.txtSectionIdl.TextSize = new System.Drawing.Size(73, 13);
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // comp337DataSetBindingSource
            // 
            this.comp337DataSetBindingSource.DataSource = this.comp337DataSet;
            this.comp337DataSetBindingSource.Position = 0;
            // 
            // comp337DataSet1
            // 
            this.comp337DataSet1.DataSetName = "Comp337DataSet1";
            this.comp337DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sectionsBindingSource
            // 
            this.sectionsBindingSource.DataMember = "Sections";
            this.sectionsBindingSource.DataSource = this.comp337DataSet1;
            // 
            // sectionsTableAdapter
            // 
            this.sectionsTableAdapter.ClearBeforeFill = true;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 565);
            this.Controls.Add(this.tabloBaseForm);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "BaseForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Load += new System.EventHandler(this.BaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloBaseForm)).EndInit();
            this.tabloBaseForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCourseCredit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCourseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp337DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grwCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSectionId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCourseNamel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCourseCreditl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSectionIdl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp337DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp337DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraLayout.LayoutControl tabloBaseForm;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtCourseCredit;
        private DevExpress.XtraEditors.TextEdit txtCourseName;
        private DevExpress.XtraGrid.GridControl grcCourse;
        private DevExpress.XtraGrid.Views.Grid.GridView grwCourse;
        private DevExpress.XtraEditors.LookUpEdit txtSectionId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem txtCourseNamel;
        private DevExpress.XtraLayout.LayoutControlItem txtCourseCreditl;
        private DevExpress.XtraLayout.LayoutControlItem txtSectionIdl;
        private Comp337DataSet comp337DataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private Comp337DataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCourseId;
        private DevExpress.XtraGrid.Columns.GridColumn colCourseName;
        private DevExpress.XtraGrid.Columns.GridColumn colCourseCredit;
        private DevExpress.XtraGrid.Columns.GridColumn colSectionId;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleteFlag;
        private System.Windows.Forms.BindingSource comp337DataSetBindingSource;
        private Comp337DataSet1 comp337DataSet1;
        private System.Windows.Forms.BindingSource sectionsBindingSource;
        private Comp337DataSet1TableAdapters.SectionsTableAdapter sectionsTableAdapter;
    }
}