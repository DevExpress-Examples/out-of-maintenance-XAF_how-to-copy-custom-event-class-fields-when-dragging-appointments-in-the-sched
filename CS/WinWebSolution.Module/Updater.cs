using System;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;

namespace WinWebSolution.Module {
    public class Updater : ModuleUpdater {
        public Updater(Session session, Version currentDBVersion) : base(session, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            MyEvent obj = new MyEvent(Session);
            obj.Subject = "Test Subject";
            obj.StartOn = DateTime.Now;
            obj.AllDay = true;
            CustomReferenceTypeField obj2 = new CustomReferenceTypeField(Session);
            obj2.Name = "CustomReferenceTypeField";
            obj2.Save();
            obj.CustomReferenceTypeField = obj2;
            obj.CustomSimpleTypeField = "CustomSimpleTypeField";
            obj.Save();
        }
    }
}
