using System;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace WinWebSolution.Module {
    //[DefaultClassOptions]
    public class CustomReferenceTypeField : BaseObject {
        public CustomReferenceTypeField(Session session) : base(session) { }
        private string _Name;
        public string Name {
            get { return _Name; }
            set { SetPropertyValue("Name", ref _Name, value); }
        }
    }
    [DefaultClassOptions]
    public class MyEvent : DevExpress.Persistent.BaseImpl.Event {
        public MyEvent(Session session) : base(session) { }
        private CustomReferenceTypeField _CustomReferenceTypeField;
        [RuleRequiredField(null, DefaultContexts.Save)]
        public CustomReferenceTypeField CustomReferenceTypeField {
            get { return _CustomReferenceTypeField; }
            set { SetPropertyValue("CustomReferenceTypeField", ref _CustomReferenceTypeField, value); }
        }
        private string _CustomSimpleTypeField;
        [RuleRequiredField(null, DefaultContexts.Save)]
        public string CustomSimpleTypeField {
            get { return _CustomSimpleTypeField; }
            set { SetPropertyValue("CustomSimpleTypeField", ref _CustomSimpleTypeField, value); }
        }
    }
}