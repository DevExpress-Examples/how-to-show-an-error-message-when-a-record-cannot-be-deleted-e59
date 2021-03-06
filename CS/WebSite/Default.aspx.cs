using System;
using DevExpress.Web;
using DevExpress.Web.Data;

public partial class Error_Message_When_Row_Cannot_Be_Deleted : System.Web.UI.Page {
    protected void ASPxGridView1_RowDeleting(object sender, ASPxDataDeletingEventArgs e) {
        throw new MyException("Cannot delete this record");
    }

    protected void ASPxGridView1_CustomErrorText(object sender, ASPxGridViewCustomErrorTextEventArgs e) {
        if (e.Exception is MyException)
            e.ErrorText = e.Exception.Message;
    }
}