Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace WinWebSolution.Module
	'[DefaultClassOptions]
	Public Class CustomReferenceTypeField
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private _Name As String
		Public Property Name() As String
			Get
				Return _Name
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Name", _Name, value)
			End Set
		End Property
	End Class
	<DefaultClassOptions> _
	Public Class MyEvent
		Inherits DevExpress.Persistent.BaseImpl.Event
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private _CustomReferenceTypeField As CustomReferenceTypeField
		<RuleRequiredField(Nothing, DefaultContexts.Save)> _
		Public Property CustomReferenceTypeField() As CustomReferenceTypeField
			Get
				Return _CustomReferenceTypeField
			End Get
			Set(ByVal value As CustomReferenceTypeField)
				SetPropertyValue("CustomReferenceTypeField", _CustomReferenceTypeField, value)
			End Set
		End Property
		Private _CustomSimpleTypeField As String
		<RuleRequiredField(Nothing, DefaultContexts.Save)> _
		Public Property CustomSimpleTypeField() As String
			Get
				Return _CustomSimpleTypeField
			End Get
			Set(ByVal value As String)
				SetPropertyValue("CustomSimpleTypeField", _CustomSimpleTypeField, value)
			End Set
		End Property
	End Class
End Namespace