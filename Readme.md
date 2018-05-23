# How to copy custom Event class fields when dragging appointments in the Scheduler Control


<p>If you extended the default DevExpress.Persistent.BaseImpl.Event class or implemented your own class, supporting the DevExpress.Persistent.Base.IEvent interface, then you may face the situation when custom fields added to your class won't be copied when copying appointments in the scheduler control. To make it possible, you should manually map your custom data fields to appropriate appointment fields. The <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument5228">How to: Create a Custom Field for an Appointment</a> help topic provides more information on how to do this.<br />
In this example, we have a descendant of the Event class that has two properties with the <a href="http://documentation.devexpress.com/#Xaf/clsDevExpressPersistentValidationRuleRequiredFieldAttributetopic">RuleRequiredFieldAttribute</a>. After adding custom field mappings to the controllers, if we drag and drop an existing appointment in the scheduler control with the Control key pressed, we won't receive a validation exception because custom fields will be correctly copied.<br />
However, adding custom field mappings won't help if we have collection properties, for example, an associated details collection. In this situation, you should handle copying of appointments yourself. The scheduler control provides corresponding API for this. For example, check the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraSchedulerSchedulerControl_AllowAppointmentCopytopic">SchedulerControl.AllowAppointmentCopy Event</a> help topic for more information.</p><p><strong>See Also:</strong><br />
<a href="http://documentation.devexpress.com/#Xaf/CustomDocument2812">Scheduler Module Overview</a><br />
<a href="https://www.devexpress.com/Support/Center/p/E1255">How to create fully custom Role, User, Event, Resource classes for use with the Security and Scheduler modules</a><br />
<a href="https://www.devexpress.com/Support/Center/p/S33729">Scheduler - Provide a way to copy a collection of custom fields when an appointment is being copied</a></p>

<br/>


