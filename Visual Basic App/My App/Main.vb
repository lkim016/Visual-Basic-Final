' Name:         Alkapuro Water Delivery
' Purpose:      Allow users to order gallons of water for delivery
' Programmer:   Lori Kim on October 20, 2015

Option Explicit On
Option Strict On
Option Infer Off

Public Class Main

    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub lblX_Click(sender As Object, e As EventArgs) Handles lblX.Click
        Me.Close()
    End Sub
End Class