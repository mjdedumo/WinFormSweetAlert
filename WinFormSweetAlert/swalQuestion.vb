Public Class swalQuestion

    Public Sub New(ByVal message As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblSubQuestion.Text = message
        DialogResult = vbNo
    End Sub

    Private Sub GunaNo_Click(sender As Object, e As EventArgs) Handles GunaNo.Click
        DialogResult = vbNo
        Me.Dispose()
    End Sub

    Private Sub GunaYes_Click(sender As Object, e As EventArgs) Handles GunaYes.Click
        DialogResult = vbYes
        Me.Dispose()
    End Sub
End Class