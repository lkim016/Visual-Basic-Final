' Name:         Alkapuro Water Delivery
' Purpose:      Allow users to order gallons of water for delivery
' Programmer:   Lori Kim on October 20, 2015

Option Explicit On
Option Strict On
Option Infer Off

Public Class Login

    ' Declares class level variables for the Email and Pass input by user
    Private strEmail As String
    Private strPass As String

    Private Sub lblX_Click(sender As Object, e As EventArgs) Handles lblX.Click

        ' Closes the whole application
        Me.Close()
        Main.Close()
    End Sub

    Private Sub txtUser_Click(sender As Object, e As EventArgs) Handles txtEmail.Click

        ' Empties the string in the txtEmail
        If txtEmail.Text = "email" Then
            txtEmail.Text = ""
        End If

    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave

        ' Re-enters the default text in the txtEmail
        If txtEmail.Text = "" Then
            txtEmail.Text = "email"
        End If
    End Sub

    Private Sub txtPass_Click(sender As Object, e As EventArgs) Handles txtPass.Click

        ' Empties the string in the txtPass
        If txtPass.Text = "password" Then
            txtPass.Text = ""
        End If

    End Sub

    Private Sub txtPass_Leave(sender As Object, e As EventArgs) Handles txtPass.Leave

        '  Re-enters the default text in the txtPass
        If txtPass.Text = "" Then
            txtPass.Text = "password"
        End If

    End Sub

    Private Sub lblSignup_Click(sender As Object, e As EventArgs) Handles lblSignup.Click

        ' Brings up the SignUp Page
        SignUp.Show()
        Me.Hide()

        ' Puts the txtEmail and txtPass to their default text
        If txtEmail.Text <> "email" Then
            txtEmail.Text = "email"
        End If

        If txtPass.Text <> "password" Then
            txtPass.Text = "password"
        End If

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged


        ' Only allows letters and numbers to be entered into the txtEmail
        Dim charactersAllowed As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890@."
        Dim theText As String = txtEmail.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = txtEmail.SelectionStart
        Dim Change As Integer
        If txtEmail.Text <> "email" Then
            For x As Integer = 0 To txtEmail.Text.Length - 1
                Letter = txtEmail.Text.Substring(x, 1)
                If charactersAllowed.Contains(Letter) = False Then
                    theText = theText.Replace(Letter, String.Empty)
                    Change = 1
                End If
            Next x

            txtEmail.Text = theText
            txtEmail.Select(SelectionIndex - Change, 0)
        End If
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

        ' Only allows letters and numbers to be entered into the txtPass
        Dim charactersAllowed As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890"
        Dim theText As String = txtPass.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = txtPass.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To txtPass.Text.Length - 1
            Letter = txtPass.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
                ' Make it so that every character input by user goes into the strPass and changes the txtPass to "*"
            End If
        Next x

            txtPass.Text = theText
            txtPass.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub lblDone_Click(sender As Object, e As EventArgs) Handles lblDone.Click
        Dim inFile As IO.StreamReader
        Dim strLine As String
        Dim strUserInfo(3) As String
        Dim intArray As Integer = 0
        Dim intIndex As Integer
        Dim intHighSub As Integer = strUserInfo.GetUpperBound(0)

        ' Inputs the Email and Pass input by user into the class level variables
        strEmail = txtEmail.Text
        strPass = txtPass.Text

        ' Open up the text doc to put each line into an array
        If IO.File.Exists("UserInfo.txt") Then
            inFile = IO.File.OpenText("UserInfo.txt")
            Do Until inFile.Peek = -1
                strLine = inFile.ReadLine
                intIndex = strLine.IndexOf(",")
                If strLine.Substring(0, intIndex).Trim = strEmail Then

                    Do While intArray < strUserInfo.Length - 1

                        intIndex = strLine.IndexOf(",")
                        strUserInfo(intArray) = strLine.Substring(0, intIndex).Trim
                        strLine = strLine.Remove(0, intIndex + 1)
                        intArray += 1

                    Loop
                End If
            Loop
            inFile.Close()

        Else
            MessageBox.Show("Can't find the file",
                            "Missing User Info File",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If

        ' Checks if the Email and Pass input by user match the stored Email and Pass
        If strEmail = strUserInfo(0) And strPass = strUserInfo(1) Then
            ' Need to adjust this and make the form hide and show the frmDelivery
            ' Me.Hide()
            lblWarn.Text = "Correct" ' Can take this out later
        Else
            lblWarn.Text = "email and password" &
            ControlChars.NewLine & " do not match"

        End If

        ' Clears the text input by user from Email and Pass
        txtEmail.Text = ""
        txtPass.Text = ""

    End Sub


End Class