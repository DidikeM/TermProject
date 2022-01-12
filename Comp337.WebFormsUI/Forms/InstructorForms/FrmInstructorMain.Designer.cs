
namespace Comp337.WebFormsUI.Forms.InstructorsForms
{
    partial class FrmInstructorMain
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnHomePage = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddCoursetoStudents = new DevExpress.XtraBars.BarButtonItem();
            this.btnCourseInformation = new DevExpress.XtraBars.BarButtonItem();
            this.btnUserInformation = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnHomePage,
            this.btnAddCoursetoStudents,
            this.btnCourseInformation,
            this.btnUserInformation,
            this.barButtonItem5,
            this.barButtonItem6});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages;
            this.ribbon.ShowSearchItem = true;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(847, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // btnHomePage
            // 
            this.btnHomePage.Caption = "HomePage";
            this.btnHomePage.Id = 1;
            this.btnHomePage.ImageOptions.Image = global::Comp337.WebFormsUI.Properties.Resources.home_16x162;
            this.btnHomePage.ImageOptions.LargeImage = global::Comp337.WebFormsUI.Properties.Resources.home_32x322;
            this.btnHomePage.Name = "btnHomePage";
            // 
            // btnAddCoursetoStudents
            // 
            this.btnAddCoursetoStudents.Caption = "Add Course to Students";
            this.btnAddCoursetoStudents.Id = 2;
            this.btnAddCoursetoStudents.ImageOptions.Image = global::Comp337.WebFormsUI.Properties.Resources.about_16x16;
            this.btnAddCoursetoStudents.ImageOptions.LargeImage = global::Comp337.WebFormsUI.Properties.Resources.about_32x32;
            this.btnAddCoursetoStudents.Name = "btnAddCoursetoStudents";
            this.btnAddCoursetoStudents.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddStudents_ItemClick);
            // 
            // btnCourseInformation
            // 
            this.btnCourseInformation.Caption = "Course Information";
            this.btnCourseInformation.Id = 3;
            this.btnCourseInformation.ImageOptions.Image = global::Comp337.WebFormsUI.Properties.Resources.apply_16x16;
            this.btnCourseInformation.ImageOptions.LargeImage = global::Comp337.WebFormsUI.Properties.Resources.apply_32x32;
            this.btnCourseInformation.Name = "btnCourseInformation";
            // 
            // btnUserInformation
            // 
            this.btnUserInformation.Caption = "User Information";
            this.btnUserInformation.Id = 4;
            this.btnUserInformation.ImageOptions.Image = global::Comp337.WebFormsUI.Properties.Resources.edit_16x16;
            this.btnUserInformation.ImageOptions.LargeImage = global::Comp337.WebFormsUI.Properties.Resources.edit_32x32;
            this.btnUserInformation.Name = "btnUserInformation";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHomePage);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAddCoursetoStudents);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCourseInformation);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUserInformation);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 624);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(847, 24);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmInstructorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 648);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FrmInstructorMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "FrmInstructorMain";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnHomePage;
        private DevExpress.XtraBars.BarButtonItem btnAddCoursetoStudents;
        private DevExpress.XtraBars.BarButtonItem btnCourseInformation;
        private DevExpress.XtraBars.BarButtonItem btnUserInformation;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}