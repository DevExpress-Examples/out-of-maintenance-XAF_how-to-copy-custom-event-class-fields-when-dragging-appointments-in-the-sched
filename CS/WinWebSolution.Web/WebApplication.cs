using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Web;

namespace WinWebSolution.Web {
    public partial class WinWebSolutionAspNetApplication : WebApplication {
        protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args) {
            args.ObjectSpaceProvider = new XPObjectSpaceProvider(args.ConnectionString, args.Connection, true);
        }
        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule module2;
        private WinWebSolution.Module.WinWebSolutionModule module3;
		private WinWebSolution.Module.Web.WinWebSolutionAspNetModule module4;
		private DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule module6;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private DevExpress.ExpressApp.Scheduler.Web.SchedulerAspNetModule schedulerAspNetModule1;
        private DevExpress.ExpressApp.Scheduler.SchedulerModuleBase schedulerModuleBase1;
        private DevExpress.ExpressApp.Validation.ValidationModule module5;

        public WinWebSolutionAspNetApplication() {
            InitializeComponent();
        }

        private void WinWebSolutionAspNetApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
#if EASYTEST
			e.Updater.Update();
			e.Handled = true;
#else
            e.Updater.Update();
            e.Handled = true;
#endif
        }

        private void InitializeComponent() {
			this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
			this.module2 = new DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule();
			this.module3 = new WinWebSolution.Module.WinWebSolutionModule();
			this.module4 = new WinWebSolution.Module.Web.WinWebSolutionAspNetModule();
			this.module5 = new DevExpress.ExpressApp.Validation.ValidationModule();
			this.module6 = new DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.schedulerAspNetModule1 = new DevExpress.ExpressApp.Scheduler.Web.SchedulerAspNetModule();
			this.schedulerModuleBase1 = new DevExpress.ExpressApp.Scheduler.SchedulerModuleBase();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// module5
			// 
			this.module5.AllowValidationDetailsAccess = true;
			this.module5.IgnoreWarningAndInformationRules = false;
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=WinWebSolution;Integrated Security=SSPI;Pooli" +
    "ng=false";
			this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
			// 
			// WinWebSolutionAspNetApplication
			// 
			this.ApplicationName = "WinWebSolution";
			this.Connection = this.sqlConnection1;
			this.Modules.Add(this.module1);
			this.Modules.Add(this.module2);
			this.Modules.Add(this.module6);
			this.Modules.Add(this.module3);
			this.Modules.Add(this.module4);
			this.Modules.Add(this.module5);
			this.Modules.Add(this.schedulerModuleBase1);
			this.Modules.Add(this.schedulerAspNetModule1);
			this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.WinWebSolutionAspNetApplication_DatabaseVersionMismatch);
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
