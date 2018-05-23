Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo

Namespace WinWebSolution.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal session As Session, ByVal currentDBVersion As Version)
			MyBase.New(session, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			Dim obj As New MyEvent(Session)
			obj.Subject = "Test Subject"
			obj.StartOn = DateTime.Now
			obj.AllDay = True
			Dim obj2 As New CustomReferenceTypeField(Session)
			obj2.Name = "CustomReferenceTypeField"
			obj2.Save()
			obj.CustomReferenceTypeField = obj2
			obj.CustomSimpleTypeField = "CustomSimpleTypeField"
			obj.Save()
		End Sub
	End Class
End Namespace
