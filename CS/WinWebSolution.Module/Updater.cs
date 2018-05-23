using System;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;

namespace WinWebSolution.Module {
    public class Updater : ModuleUpdater {
        public Updater(ObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            MyEvent obj = ObjectSpace.CreateObject<MyEvent>();
            obj.Subject = "Test Subject";
            obj.StartOn = DateTime.Now;
            obj.AllDay = true;
            CustomReferenceTypeField obj2 = ObjectSpace.CreateObject<CustomReferenceTypeField>();
            obj2.Name = "CustomReferenceTypeField";
            obj2.Save();
            obj.CustomReferenceTypeField = obj2;
            obj.CustomSimpleTypeField = "CustomSimpleTypeField";
            obj.Save();
        }
    }
}
