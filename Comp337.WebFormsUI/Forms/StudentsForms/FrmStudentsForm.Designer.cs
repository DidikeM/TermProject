
namespace Comp337.WebFormsUI.Forms.StudentsForms
{
    partial class FrmStudentsForm
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
            this.btnRegisteredCourses = new DevExpress.XtraBars.BarButtonItem();
            this.btnRegisteredStudents = new DevExpress.XtraBars.BarButtonItem();
            this.btnUserInformation = new DevExpress.XtraBars.BarButtonItem();
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
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnHomePage,
            this.btnRegisteredCourses,
            this.btnRegisteredStudents,
            this.btnUserInformation});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(904, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnHomePage
            // 
            this.btnHomePage.Caption = "Home Page";
            this.btnHomePage.Id = 1;
            this.btnHomePage.ImageOptions.Image = global::Comp337.WebFormsUI.Properties.Resources.home_16x163;
            this.btnHomePage.ImageOptions.LargeImage = global::Comp337.WebFormsUI.Properties.Resources.home_32x323;
            this.btnHomePage.Name = "btnHomePage";
            // 
            // btnRegisteredCourses
            // 
            this.btnRegisteredCourses.Caption = "Registered Courses";
            this.btnRegisteredCourses.Id = 2;
            this.btnRegisteredCourses.ImageOptions.Image = global::Comp337.WebFormsUI.Properties.Resources.apply_16x161;
            this.btnRegisteredCourses.ImageOptions.LargeImage = global::Comp337.WebFormsUI.Properties.Resources.apply_32x321;
            this.btnRegisteredCourses.Name = "btnRegisteredCourses";
            // 
            // btnRegisteredStudents
            // 
            this.btnRegisteredStudents.Caption = "Registered Students";
            this.btnRegisteredStudents.Id = 3;
            this.btnRegisteredStudents.ImageOptions.Image = global::Comp337.WebFormsUI.Properties.Resources.apply_16x162;
            this.btnRegisteredStudents.ImageOptions.LargeImage = global::Comp337.WebFormsUI.Properties.Resources.apply_32x322;
            this.btnRegisteredStudents.Name = "btnRegisteredStudents";
            // 
            // btnUserInformation
            // 
            this.btnUserInformation.Caption = "User Information";
            this.btnUserInformation.Id = 4;
            this.btnUserInformation.ImageOptions.Image = global::Comp337.WebFormsUI.Properties.Resources.about_16x161;
            this.btnUserInformation.ImageOptions.LargeImage = global::Comp337.WebFormsUI.Properties.Resources.about_32x321;
            this.btnUserInformation.Name = "btnUserInformation";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRegisteredCourses);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRegisteredStudents);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUserInformation);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 429);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(904, 24);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 453);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FrmStudentsForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "FrmStudentsForm";
            this.Load += new System.EventHandler(this.FrmStudentsForm_Load);
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
        private DevExpress.XtraBars.BarButtonItem btnRegisteredCourses;
        private DevExpress.XtraBars.BarButtonItem btnRegisteredStudents;
        private DevExpress.XtraBars.BarButtonItem btnUserInformation;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}