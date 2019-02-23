' Name:         Alkapuro Water Delivery
' Purpose:      Allow users to order gallons of water for delivery
' Programmer:   Lori Kim on October 20, 2015

Option Explicit On
Option Strict On
Option Infer Off

Public Class SignUp

    ' Declares Friend variables
    Friend strContact(3) As String
    Friend strDelivery(4) As String

    ' Declares Private Contact variables
    Private strEmail As String
    Private strPass As String
    Private strName As String
    Private strPhone As String

    ' Declares Private Delivery variables
    Private strStreet As String
    Private strApt As String
    Private strCity As String
    Private strState As String
    Private strZip As String

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        ' Going back to Login form
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub txtName_Click(sender As Object, e As EventArgs) Handles txtName.Click

        ' Empties the string in the txtName
        If txtName.Text = "full name" Then
            txtName.Text = ""
        End If

    End Sub

    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave

        Dim intIndex As Integer
        Dim strFirst As String
        Dim strLast As String

        ' Re-enters the default text in the txtEmail
        If txtName.Text = "" Then
            txtName.Text = "full name"
        End If

        ' Separates the first from the last name and checks if it's a full name
        strName = txtName.Text

        intIndex = strName.IndexOf(" ")
        If intIndex > 0 Then
            strFirst = strName.Substring(0, intIndex)
            strLast = strName.Substring(intIndex + 1)
            strName = strFirst & "," & strLast
        Else
            lblNameWarn.Text = "please enter a full name"
            strName = ""
        End If
    End Sub
    Private Sub txtEmail_Click(sender As Object, e As EventArgs) Handles txtEmail.Click

        ' Empties the string in the txtEmail
        If txtEmail.Text = "email" Then
            txtEmail.Text = ""
        End If

    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave

        Dim inFile As IO.StreamReader
        Dim strLine As String
        Dim intIndex As Integer

        ' Re-enters the default text in the txtEmail
        If txtEmail.Text = "" Then
            txtEmail.Text = "email"
        End If

        ' Checks to see if the email already exists

        If IO.File.Exists("UserInfo.txt") Then
            inFile = IO.File.OpenText("UserInfo.txt")
            If inFile.Peek = -1 Then
                strEmail = txtEmail.Text
                lblEmailWarn.Text = "true"
                inFile.Close()
            Else
                Do Until inFile.Peek = -1
                    strLine = inFile.ReadLine
                    intIndex = strLine.IndexOf(",")
                    If txtEmail.Text = strLine.Substring(0, intIndex).Trim Then
                        strEmail = ""
                        lblEmailWarn.Text = "invalid email"
                    Else
                        strEmail = txtEmail.Text
                        lblEmailWarn.Text = strEmail
                    End If
                Loop
                inFile.Close()
            End If
        Else
            MessageBox.Show("Can't find the file",
                            "Missing User Info File",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub txtPass_Click(sender As Object, e As EventArgs) Handles txtPass.Click

        ' Empties the string in the txtPass
        If txtPass.Text = "password" Then
            txtPass.Text = ""
        End If
    End Sub

    Private Sub txtPass_Leave(sender As Object, e As EventArgs) Handles txtPass.Leave

        ' Re-enters the default text in the txtPass
        If txtPass.Text = "" Then
            txtPass.Text = "password"
        End If
    End Sub

    Private Sub txtConfirm_Click(sender As Object, e As EventArgs) Handles txtConfirm.Click

        ' Empties the string in the txtConfirm
        If txtConfirm.Text = "password confirmation" Then
            txtConfirm.Text = ""
        End If

    End Sub

    Private Sub txtConfirm_Leave(sender As Object, e As EventArgs) Handles txtConfirm.Leave

        ' Re-enters the default text in the txtConfirm
        If txtConfirm.Text = "" Then
            txtConfirm.Text = "password confirmation"
        End If

        ' Confirms that the password confirmation entered matches the password above
        If txtConfirm.Text = txtPass.Text Then
            strPass = txtConfirm.Text
            lblPassWarn.Text = strPass ' Can take this out later
        Else
            strPass = ""
            lblPassWarn.Text = "password does not match"
        End If
    End Sub

    Private Sub txtPhone_Click(sender As Object, e As EventArgs) Handles txtPhone.Click

        ' Empties the string in the txtConfirm
        If txtPhone.Text = "phone number" Then
            txtPhone.Text = ""
        End If
    End Sub

    Private Sub txtPhone_Leave(sender As Object, e As EventArgs) Handles txtPhone.Leave

        ' Re-enters the default text in the txtConfirm
        If txtPhone.Text = "" Then
            txtPhone.Text = "phone number"
        End If

        ' Checks to see if there are 8 digits in txtPhone and puts it into the strPhone variable
        strPhone = txtPhone.Text
    End Sub

    Private Sub txtStreet_Click(sender As Object, e As EventArgs) Handles txtStreet.Click
        ' Empties the string in the txtConfirm
        If txtStreet.Text = "street" Then
            txtStreet.Text = ""
        End If
    End Sub

    Private Sub txtStreet_Leave(sender As Object, e As EventArgs) Handles txtStreet.Leave
        ' Re-enters the default text in the txtPass
        If txtStreet.Text = "" Then
            txtStreet.Text = "street"
        End If

        strStreet = txtStreet.Text
    End Sub

    Private Sub txtApt_Click(sender As Object, e As EventArgs) Handles txtApt.Click
        ' Empties the string in the txtConfirm
        If txtApt.Text = "apt" Then
            txtApt.Text = ""
        End If
    End Sub

    Private Sub txtApt_Leave(sender As Object, e As EventArgs) Handles txtApt.Leave
        ' Re-enters the default text in the txtPass
        If txtApt.Text = "" Then
            txtApt.Text = "apt"
        End If

        strApt = txtApt.Text
    End Sub

    Private Sub txtCity_Click(sender As Object, e As EventArgs) Handles txtCity.Click
        ' Empties the string in the txtConfirm
        If txtCity.Text = "city" Then
            txtCity.Text = ""
        End If
    End Sub

    Private Sub txtCity_Leave(sender As Object, e As EventArgs) Handles txtCity.Leave
        ' Re-enters the default text in the txtPass
        If txtCity.Text = "" Then
            txtCity.Text = "city"
        End If

        strCity = txtCity.Text
    End Sub

    Private Sub txtState_Click(sender As Object, e As EventArgs) Handles txtState.Click
        ' Empties the string in the txtConfirm
        If txtState.Text = "state" Then
            txtState.Text = ""
        End If
    End Sub

    Private Sub txtState_Leave(sender As Object, e As EventArgs) Handles txtState.Leave
        ' Re-enters the default text in the txtPass
        If txtState.Text = "" Then
            txtState.Text = "state"
        End If

        strState = txtState.Text
    End Sub

    Private Sub txtZip_Click(sender As Object, e As EventArgs) Handles txtZip.Click
        ' Empties the string in the txtConfirm
        If txtZip.Text = "zip" Then
            txtZip.Text = ""
        End If
    End Sub

    Private Sub txtZip_Leave(sender As Object, e As EventArgs) Handles txtZip.Leave
        ' Re-enters the default text in the txtPass
        If txtZip.Text = "" Then
            txtZip.Text = "zip"
        End If

        strZip = txtZip.Text
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

        Dim charactersAllowed As String = " ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"

        ' Only allows letters and numbers to be entered into the txtName
        Dim theText As String = txtName.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = txtName.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To txtName.Text.Length - 1
            Letter = txtName.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next x

        txtName.Text = theText
        txtName.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

        ' Have to check what other characters emails allow
        Dim charactersAllowed As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*.?"

        ' Only allows letters and numbers to be entered into the txtEmail
        Dim theText As String = txtEmail.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = txtEmail.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To txtEmail.Text.Length - 1
            Letter = txtEmail.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next x

        txtEmail.Text = theText
        txtEmail.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub lblDone_Click(sender As Object, e As EventArgs) Handles lblDone.Click

        ' value of strEmail -> Check the strEmail Leave Event
        ' value of strPass -> Check the strPass Leave Event
        ' value of strName -> Check the strName Leave Event
        ' value of strPhone -> Check the strPhone Leave Event

        ' Inputs all of the information input by user into the UserInfo.txt
        If strEmail <> "" And strPass <> "" And strName <> "" And strPhone <> "" And strStreet <> "" And strApt <> "" And strCity <> "" And strState <> "" And strZip <> "" Then
            strContact(0) = strEmail
            strContact(1) = strPass
            strContact(2) = strName
            strContact(3) = strPhone

            strDelivery(0) = strStreet
            strDelivery(1) = strApt
            strDelivery(2) = strCity
            strDelivery(3) = strState
            strDelivery(4) = strZip

            Me.Hide()
            Account.Show()
        Else
            lblSorry.Text = "please fill out all of" & ControlChars.NewLine & "the information" ' Can take this out later""
        End If

    End Sub

End Class