﻿Imports instat.Translations
Public Class ucrButtonsSubdialogue
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.ParentForm.Close()
    End Sub
    Public Event ClickReturn(sender As Object, e As EventArgs)
    Private Sub cmdReturn_Click(sender As Object, e As EventArgs) Handles cmdReturn.Click
        RaiseEvent ClickReturn(sender, e)
        Me.ParentForm.Close()
    End Sub

    Private Sub ucrButtonsSubdialogue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        translateEach(Controls)
    End Sub
End Class
