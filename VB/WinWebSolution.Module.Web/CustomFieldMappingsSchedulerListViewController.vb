Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler
Imports System.Collections.Generic
Imports DevExpress.Web.ASPxScheduler

Namespace WinWebSolution.Module.Web
	Public Class CustomFieldMappingsSchedulerListViewController
		Inherits CustomFieldMappingsSchedulerListViewControllerBase
		Protected Overrides Sub AddCustomFieldMappings(ByVal mappings As List(Of MappingBase))
			Dim scheduler As ASPxScheduler = CType(SchedulerListEditor.Scheduler, ASPxScheduler)
			scheduler.Storage.Appointments.CustomFieldMappings.AddRange(mappings)
		End Sub
	End Class
End Namespace
