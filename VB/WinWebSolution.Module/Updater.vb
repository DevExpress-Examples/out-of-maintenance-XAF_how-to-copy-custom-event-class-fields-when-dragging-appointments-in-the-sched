Imports System

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl

Namespace WinWebSolution.Module
    Public Class Updater
        Inherits ModuleUpdater

        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub
        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            Dim obj As MyEvent = ObjectSpace.CreateObject(Of MyEvent)()
            obj.Subject = "Test Subject"
            obj.StartOn = Date.Now
            obj.AllDay = True
            Dim obj2 As CustomReferenceTypeField = ObjectSpace.CreateObject(Of CustomReferenceTypeField)()
            obj2.Name = "CustomReferenceTypeField"
            obj2.Save()
            obj.CustomReferenceTypeField = obj2
            obj.CustomSimpleTypeField = "CustomSimpleTypeField"
            obj.Save()
        End Sub
    End Class
End Namespace
