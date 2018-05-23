Imports DevExpress.ExpressApp
Imports DevExpress.XtraScheduler
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.Scheduler

Namespace WinWebSolution.Module
    Public MustInherit Class CustomFieldMappingsSchedulerListViewControllerBase
        Inherits ViewController(Of ListView)

        Public Const SchedulerListEditorActiveKey As String = "SchedulerListEditor is used for the ListView"
        Public Sub New()
            TargetObjectType = GetType(MyEvent)
        End Sub
        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            Active(SchedulerListEditorActiveKey) = SchedulerListEditor IsNot Nothing
        End Sub
        Public ReadOnly Property SchedulerListEditor() As SchedulerListEditorBase
            Get
                Return TryCast(View.Editor, SchedulerListEditorBase)
            End Get
        End Property
        Protected Overrides Sub OnViewControlsCreated()
            MyBase.OnViewControlsCreated()
            AddCustomFieldMappings(GetCustomFieldMappings())
        End Sub
        Protected Overridable Function GetCustomFieldMappings() As List(Of MappingBase)
            Dim mappings As New List(Of MappingBase)()
            mappings.Add(New AppointmentCustomFieldMapping("ReferenceField", "CustomReferenceTypeField"))
            mappings.Add(New AppointmentCustomFieldMapping("SimpleField", "CustomSimpleTypeField"))
            Return mappings
        End Function
        Protected MustOverride Sub AddCustomFieldMappings(ByVal mappings As List(Of MappingBase))
    End Class
End Namespace