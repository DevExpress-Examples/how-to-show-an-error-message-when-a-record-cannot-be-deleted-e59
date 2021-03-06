Imports System
Imports DevExpress.Web
Imports DevExpress.Web.Data

Partial Public Class Error_Message_When_Row_Cannot_Be_Deleted
    Inherits System.Web.UI.Page

    Protected Sub ASPxGridView1_RowDeleting(ByVal sender As Object, ByVal e As ASPxDataDeletingEventArgs)
        Throw New MyException("Cannot delete this record")
    End Sub

    Protected Sub ASPxGridView1_CustomErrorText(ByVal sender As Object, ByVal e As ASPxGridViewCustomErrorTextEventArgs)
        If TypeOf e.Exception Is MyException Then
            e.ErrorText = e.Exception.Message
        End If
    End Sub
End Class