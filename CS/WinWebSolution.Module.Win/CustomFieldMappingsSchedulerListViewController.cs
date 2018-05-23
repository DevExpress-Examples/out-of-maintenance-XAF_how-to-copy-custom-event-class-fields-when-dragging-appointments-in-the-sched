using System;
using DevExpress.XtraScheduler;
using System.Collections.Generic;
using DevExpress.ExpressApp.Scheduler.Win;

namespace WinWebSolution.Module.Win {
    public class CustomFieldMappingsSchedulerListViewController : CustomFieldMappingsSchedulerListViewControllerBase {
        protected override void AddCustomFieldMappings(List<MappingBase> mappings) {
            SchedulerControl scheduler = ((SchedulerListEditor)SchedulerListEditor).SchedulerControl;
            scheduler.Storage.Appointments.CustomFieldMappings.AddRange(mappings);
        }
    }
}
