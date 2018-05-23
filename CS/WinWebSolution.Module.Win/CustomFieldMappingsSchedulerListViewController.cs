using System;
using DevExpress.XtraScheduler;
using System.Collections.Generic;

namespace WinWebSolution.Module.Win {
    public class CustomFieldMappingsSchedulerListViewController : CustomFieldMappingsSchedulerListViewControllerBase {
        protected override void AddCustomFieldMappings(List<MappingBase> mappings) {
            SchedulerControl scheduler = (SchedulerControl)SchedulerListEditor.Scheduler;
            scheduler.Storage.Appointments.CustomFieldMappings.AddRange(mappings);
        }
    }
}
