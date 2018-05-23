using System;
using DevExpress.XtraScheduler;
using System.Collections.Generic;
using DevExpress.Web.ASPxScheduler;

namespace WinWebSolution.Module.Web {
    public class CustomFieldMappingsSchedulerListViewController : CustomFieldMappingsSchedulerListViewControllerBase {
        protected override void AddCustomFieldMappings(List<MappingBase> mappings) {
            ASPxScheduler scheduler = (ASPxScheduler)SchedulerListEditor.Scheduler;
            scheduler.Storage.Appointments.CustomFieldMappings.AddRange(mappings);
        }
    }
}
