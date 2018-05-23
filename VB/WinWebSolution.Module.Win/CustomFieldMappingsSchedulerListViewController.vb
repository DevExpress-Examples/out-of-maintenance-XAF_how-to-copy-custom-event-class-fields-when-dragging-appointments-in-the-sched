Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler
Imports System.Collections.Generic

Namespace WinWebSolution.Module.Win
	Public Class CustomFieldMappingsSchedulerListViewController
		Inherits CustomFieldMappingsSchedulerListViewControllerBase
		Protected Overrides Sub AddCustomFieldMappings(ByVal mappings As List(Of MappingBase))
			Dim scheduler As SchedulerControl = CType(SchedulerListEditor.Scheduler, SchedulerControl)
			scheduler.Storage.Appointments.CustomFieldMappings.AddRange(mappings)
		End Sub
	End Class
End Namespace
