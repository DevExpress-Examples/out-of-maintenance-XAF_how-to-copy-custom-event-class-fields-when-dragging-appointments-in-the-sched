using System;
using DevExpress.ExpressApp;
using DevExpress.XtraScheduler;
using System.Collections.Generic;
using DevExpress.ExpressApp.Scheduler;

namespace WinWebSolution.Module {
    public abstract class CustomFieldMappingsSchedulerListViewControllerBase : ViewController<ListView> {
        public const string SchedulerListEditorActiveKey = "SchedulerListEditor is used for the ListView";
        public CustomFieldMappingsSchedulerListViewControllerBase() {
            TargetObjectType = typeof(MyEvent);
        }
        protected override void OnViewChanging(View view) {
            base.OnViewChanging(view);
            ListView lv = view as ListView;
            if (lv != null)
                Active[SchedulerListEditorActiveKey] = GetSchedulerListEditor(lv) != null;
        }
        private static SchedulerListEditorBase GetSchedulerListEditor(ListView lv) {
            return lv.Editor as SchedulerListEditorBase;
        }
        public SchedulerListEditorBase SchedulerListEditor {
            get { return GetSchedulerListEditor(View); }
        }
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            AddCustomFieldMappings(GetCustomFieldMappings());
        }
        protected virtual List<MappingBase> GetCustomFieldMappings() {
            List<MappingBase> mappings = new List<MappingBase>();
            mappings.Add(new AppointmentCustomFieldMapping("CustomReferenceTypeField", "CustomReferenceTypeField!"));
            mappings.Add(new AppointmentCustomFieldMapping("CustomSimpleTypeField", "CustomSimpleTypeField"));
            return mappings;
        }
        protected abstract void AddCustomFieldMappings(List<MappingBase> mappings);
    }
}