Imports Microsoft.VisualBasic
Imports System
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
		Protected Overrides Overloads Sub OnViewChanging(ByVal view As View)
			MyBase.OnViewChanging(view)
			Dim lv As ListView = TryCast(view, ListView)
			If lv IsNot Nothing Then
				Active(SchedulerListEditorActiveKey) = GetSchedulerListEditor(lv) IsNot Nothing
			End If
		End Sub
		Private Shared Function GetSchedulerListEditor(ByVal lv As ListView) As SchedulerListEditorBase
			Return TryCast(lv.Editor, SchedulerListEditorBase)
		End Function
		Public ReadOnly Property SchedulerListEditor() As SchedulerListEditorBase
			Get
				Return GetSchedulerListEditor(View)
			End Get
		End Property
		Protected Overrides Overloads Sub OnViewControlsCreated()
			MyBase.OnViewControlsCreated()
			AddCustomFieldMappings(GetCustomFieldMappings())
		End Sub
		Protected Overridable Function GetCustomFieldMappings() As List(Of MappingBase)
			Dim mappings As New List(Of MappingBase)()
			mappings.Add(New AppointmentCustomFieldMapping("CustomReferenceTypeField", "CustomReferenceTypeField!"))
			mappings.Add(New AppointmentCustomFieldMapping("CustomSimpleTypeField", "CustomSimpleTypeField"))
			Return mappings
		End Function
		Protected MustOverride Sub AddCustomFieldMappings(ByVal mappings As List(Of MappingBase))
	End Class
End Namespace