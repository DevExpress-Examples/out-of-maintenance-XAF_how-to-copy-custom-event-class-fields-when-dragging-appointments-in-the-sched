Imports System
Imports DevExpress.XtraScheduler
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.Scheduler.Win

Namespace WinWebSolution.Module.Win
    Public Class CustomFieldMappingsSchedulerListViewController
        Inherits CustomFieldMappingsSchedulerListViewControllerBase

        Protected Overrides Sub AddCustomFieldMappings(ByVal mappings As List(Of MappingBase))
            Dim scheduler As SchedulerControl = CType(SchedulerListEditor, SchedulerListEditor).SchedulerControl
            scheduler.Storage.Appointments.CustomFieldMappings.AddRange(mappings)
        End Sub
    End Class
End Namespace
