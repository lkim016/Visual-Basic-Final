' Name:         Alkapuro Water Delivery
' Purpose:      Allow users to order gallons of water for delivery
' Programmer:   Lori Kim on October 20, 2015

Option Explicit On
Option Strict On
Option Infer Off

Public Class Account

    ' Declares Private arrays
    Private strPayment(3) As String
    Private strBilling(4) As String

    ' Declares Private Payment variables
    Private strCardName As String
    Private strCardNum As String
    Private strCardExp As String
    Private strCardCvv As String

    ' Declares Private Billing variables
    Private strStreet As String
    Private strApt As String
    Private strCity As String
    Private strState As String
    Private strZip As String
    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Hide()
        SignUp.Show()
    End Sub

    Private Sub txtCardName_Click(sender As Object, e As EventArgs) Handles txtCardName.Click
        ' Empties the string in the txtName
        If txtCardName.Text = "card name" Then
            txtCardName.Text = ""
        End If
    End Sub

    Private Sub txtCardName_Leave(sender As Object, e As EventArgs) Handles txtCardName.Leave
        ' Re-enters the default text in the txtEmail
        If txtCardName.Text = "" Then
            txtCardName.Text = "card name"
        End If

        strCardName = txtCardName.Text
    End Sub

    Private Sub txtCardNum_Click(sender As Object, e As EventArgs) Handles txtCardNum.Click
        ' Empties the string in the txtName
        If txtCardNum.Text = "card number" Then
            txtCardNum.Text = ""
        End If
    End Sub

    Private Sub txtCardNum_Leave(sender As Object, e As EventArgs) Handles txtCardNum.Leave
        ' Re-enters the default text in the txtEmail
        If txtCardNum.Text = "" Then
            txtCardNum.Text = "card number"
        End If

        strCardNum = txtCardNum.Text
    End Sub

    Private Sub txtCardExp_Click(sender As Object, e As EventArgs) Handles txtCardExp.Click
        ' Empties the string in the txtName
        If txtCardExp.Text = "expiration date" Then
            txtCardExp.Text = ""
        End If
    End Sub

    Private Sub txtCardExp_Leave(sender As Object, e As EventArgs) Handles txtCardExp.Leave
        ' Re-enters the default text in the txtEmail
        If txtCardExp.Text = "" Then
            txtCardExp.Text = "expiration date"
        End If

        strCardExp = txtCardExp.Text
    End Sub

    Private Sub txtCardCvv_Click(sender As Object, e As EventArgs) Handles txtCardCvv.Click
        ' Empties the string in the txtName
        If txtCardCvv.Text = "cvv" Then
            txtCardCvv.Text = ""
        End If
    End Sub

    Private Sub txtCardCvv_Leave(sender As Object, e As EventArgs) Handles txtCardCvv.Leave
        ' Re-enters the default text in the txtEmail
        If txtCardCvv.Text = "" Then
            txtCardCvv.Text = "cvv"
        End If

        strCardCvv = txtCardCvv.Text
    End Sub

    Private Sub txtStreet_Click(sender As Object, e As EventArgs) Handles txtStreet.Click
        ' Empties the string in the txtName
        If txtStreet.Text = "street" Then
            txtStreet.Text = ""
        End If
    End Sub

    Private Sub txtStreet_Leave(sender As Object, e As EventArgs) Handles txtStreet.Leave
        ' Re-enters the default text in the txtEmail
        If txtStreet.Text = "" Then
            txtStreet.Text = "street"
        End If

        strStreet = txtStreet.Text
    End Sub

    Private Sub txtApt_Click(sender As Object, e As EventArgs) Handles txtApt.Click
        ' Empties the string in the txtName
        If txtApt.Text = "apt" Then
            txtApt.Text = ""
        End If
    End Sub

    Private Sub txtApt_Leave(sender As Object, e As EventArgs) Handles txtApt.Leave
        ' Re-enters the default text in the txtEmail
        If txtApt.Text = "" Then
            txtApt.Text = "apt"
        End If

        strApt = txtApt.Text
    End Sub

    Private Sub txtCity_Click(sender As Object, e As EventArgs) Handles txtCity.Click
        ' Empties the string in the txtName
        If txtCity.Text = "city" Then
            txtCity.Text = ""
        End If
    End Sub

    Private Sub txtCity_Leave(sender As Object, e As EventArgs) Handles txtCity.Leave
        ' Re-enters the default text in the txtEmail
        If txtCity.Text = "" Then
            txtCity.Text = "city"
        End If

        strCity = txtCity.Text
    End Sub

    Private Sub txtState_Click(sender As Object, e As EventArgs) Handles txtState.Click
        ' Empties the string in the txtName
        If txtState.Text = "state" Then
            txtState.Text = ""
        End If
    End Sub

    Private Sub txtState_Leave(sender As Object, e As EventArgs) Handles txtState.Leave
        ' Re-enters the default text in the txtEmail
        If txtState.Text = "" Then
            txtState.Text = "state"
        End If

        strState = txtState.Text
    End Sub

    Private Sub txtZip_Click(sender As Object, e As EventArgs) Handles txtZip.Click
        ' Empties the string in the txtName
        If txtZip.Text = "zip" Then
            txtZip.Text = ""
        End If
    End Sub

    Private Sub txtZip_Leave(sender As Object, e As EventArgs) Handles txtZip.Leave
        ' Re-enters the default text in the txtEmail
        If txtZip.Text = "" Then
            txtZip.Text = "zip"
        End If

        strZip = txtZip.Text
    End Sub

    Private Sub InputInfo(ByVal strTextDoc As String,
                          ByVal strSentence As String)
        Dim outFile As IO.StreamWriter
        Dim inFile As IO.StreamReader
        Dim strFile As String = "F:\My App\My App\bin\Debug\" & strTextDoc

        If IO.File.Exists(strTextDoc) Then
            inFile = IO.File.OpenText(strTextDoc)
            If inFile.Peek = -1 Then
                inFile.Close()
                outFile = IO.File.AppendText(strFile)
                outFile.Write(strSentence.Trim)
                outFile.Close()
            Else
                inFile.Close()
                outFile = IO.File.AppendText(strFile)
                outFile.Write(ControlChars.NewLine & strSentence.Trim)
                outFile.Close()
            End If
        Else
            outFile = IO.File.AppendText(strFile)
            outFile.Write(strSentence.Trim)
            outFile.Close()
        End If

    End Sub

    Private Sub lblDone_Click(sender As Object, e As EventArgs) Handles lblDone.Click
        Dim intArray As Integer = 0
        Dim strCombArray As String = ""
        Dim strTextDoc As String

        ' Input of the Contact Info into UserInfo.txt
        Do While intArray <= SignUp.strContact.Length - 1
            strCombArray += SignUp.strContact(intArray) & ","
            intArray += 1
        Loop

        strTextDoc = "UserInfo.txt"

        Call InputInfo(strTextDoc, strCombArray)

        ' Input of the Delivery Address Info into DeliveryInfo.txt
        intArray = 0
        strCombArray = ""

        Do While intArray <= SignUp.strDelivery.Length - 1
            strCombArray += SignUp.strDelivery(intArray) & ","
            intArray += 1
        Loop

        strTextDoc = "DeliveryInfo.txt"

        Call InputInfo(strTextDoc, strCombArray)

        If strCardName <> "" And strCardNum <> "" And strCardExp <> "" And strCardCvv <> "" And strStreet <> "" And strApt <> "" And strCity <> "" And strState <> "" And strZip <> "" Then
            strPayment(0) = strCardName
            strPayment(1) = strCardNum
            strPayment(2) = strCardExp
            strPayment(3) = strCardCvv

            strBilling(0) = strStreet
            strBilling(1) = strApt
            strBilling(2) = strCity
            strBilling(3) = strState
            strBilling(4) = strZip

        Else
            lblSorry.Text = "Sorry" ' Can take this out later
        End If

        ' Input of the Payment Info into PaymentInfo.txt
        intArray = 0
        strCombArray = ""

        Do While intArray <= strPayment.Length - 1
            strCombArray += strPayment(intArray) & ","
            intArray += 1
        Loop

        strTextDoc = "PaymentInfo.txt"

        Call InputInfo(strTextDoc, strCombArray)

        If chkDelivery.Checked Then
            intArray = 0
            Do While intArray <= strBilling.Length - 1
                If strBilling(intArray) <> "" Then
                    strBilling(intArray) = ""
                End If
                intArray += 1
            Loop
        Else
            ' Input of the Billing Address Info into BillingInfo.txt if chkDelivery is not checked
            intArray = 0
            strCombArray = ""

            Do While intArray <= strBilling.Length - 1
                strCombArray += strBilling(intArray) & ","
                intArray += 1
            Loop

            strTextDoc = "BillingInfo.txt"

            Call InputInfo(strTextDoc, strCombArray)
        End If
        
    End Sub

    Private Sub chkDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles chkDelivery.CheckedChanged
        Dim intArray As Integer = 0

        If strStreet <> "" And strApt <> "" And strCity <> "" And strState <> "" And strZip <> "" Then

            strBilling(0) = strStreet
            strBilling(1) = strApt
            strBilling(2) = strCity
            strBilling(3) = strState
            strBilling(4) = strZip

        End If

        Do While intArray <= strBilling.Length - 1
            If strBilling(intArray) <> "" Then
                Select Case intArray
                    Case 0
                        txtStreet.Text = "street"
                    Case 1
                        txtApt.Text = "apt"
                    Case 2
                        txtCity.Text = "city"
                    Case 3
                        txtState.Text = "state"
                    Case 4
                        txtZip.Text = "zip"
                End Select
            End If
            intArray += 1
        Loop
    End Sub
End Class