﻿Imports System
Imports System.Linq
Imports System.Web.Mvc

Namespace DXWebApplication1.Controllers
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View()
		End Function
		Public Function GridViewPartial() As ActionResult
			Return GridViewPartialCore()
		End Function
		Public Function GridViewPartialCustom(ByVal layoutToApply As String) As ActionResult
			ViewData("Layout") = layoutToApply
			Return GridViewPartialCore()
		End Function
		Public Function GridViewPartialCore() As ActionResult
			Return PartialView("GridViewPartial", GetModel())
		End Function
		Private Function GetModel() As Object
			Return Enumerable.Range(1, 100).Select(Function(i) New MyModel With {.ID = i, .Text = "Text - " & i})
		End Function
	End Class
	Public Class MyModel
		Public Property ID() As Integer
		Public Property Text() As String
	End Class
End Namespace