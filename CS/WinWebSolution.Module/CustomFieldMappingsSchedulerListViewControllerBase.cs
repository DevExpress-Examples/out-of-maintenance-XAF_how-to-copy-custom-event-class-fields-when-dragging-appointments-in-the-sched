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
		protected override void OnActivated() {
			base.OnActivated();
			Active[SchedulerListEditorActiveKey] = SchedulerListEditor != null;
		}
        public SchedulerListEditorBase SchedulerListEditor {
			get { return View.Editor as SchedulerListEditorBase; }
        }
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            AddCustomFieldMappings(GetCustomFieldMappings());
        }
        protected virtual List<MappingBase> GetCustomFieldMappings() {
            List<MappingBase> mappings = new List<MappingBase>();
            mappings.Add(new AppointmentCustomFieldMapping("ReferenceField", "CustomReferenceTypeField"));
            mappings.Add(new AppointmentCustomFieldMapping("SimpleField", "CustomSimpleTypeField"));
            return mappings;
        }
        protected abstract void AddCustomFieldMappings(List<MappingBase> mappings);
    }
}