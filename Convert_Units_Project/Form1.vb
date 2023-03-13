Public Class Form1
    'Declaring variables 
    Dim decMeter As Decimal = 0.0254D
    Dim decInch As Decimal = 39.3701D
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'this button exits the program
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'this button will clear the results so you can enter a new value.
        'Just resetting the text to nothing and hiding the label again.
        lblResults.Text = ""
        lblResults.Visible = False
        'Resetting the value input to blank and the radio button default to inches to meters
        txtValueToConvert.Text = ""
        rdoInchtoMeter.Checked = True

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'Declaring needed variables below. I had to do a check for numeric as well as creating
        'a variable for the result set.  I also set the values for the conversion calculations.
        Dim checkNum = IsNumeric(txtValueToConvert.Text)
        Dim conversionResult As Decimal
        'Dim myNumtoconvert As Decimal
        Dim decMeter As Decimal = 0.0254D
        Dim decInch As Decimal = 39.3701D
        Dim unitOfMeasure As String
        Dim unitOfMeasure2 As String

        Dim myNumtoconvert = Convert.ToDecimal(txtValueToConvert.Text) 'Error happens here,but if I remove this, it doesnt calculate my values correctly

        'First if statement to check for errors in the entry process

        If String.IsNullOrEmpty(txtValueToConvert.Text) Then
            MsgBox("Please enter a value in order to proceed.")
            lblResults.Visible = False
        ElseIf checkNum = False Then
            MsgBox("Please only enter a valid number for your group.")
            lblResults.Visible = False
        ElseIf txtValueToConvert.Text < 1 Then
            MsgBox("Please enter a positive value only.")
            lblResults.Visible = False
        ElseIf rdoInchtoMeter.Checked = True Then
            conversionResult = Convert.ToDecimal(txtValueToConvert.Text) * decMeter
            unitOfMeasure = "inches "
            unitOfMeasure2 = " meters"
            'lblResults.Text = myNumtoconvert.ToString() + " inches is " + conversionResult.ToString() + " meters."
        ElseIf rdoMeterToInch.Checked = True Then
            conversionResult = Convert.ToInt32(txtValueToConvert.Text) * decInch
            unitOfMeasure = "meters"
            unitOfMeasure2 = " inches"
            'lblResults.Text = myNumtoconvert.ToString() + " meters is " + conversionResult.ToString() + " inches." 
        End If
        'Make label visible and show results of calculations
        lblResults.Text = myNumtoconvert.ToString() + " " + unitOfMeasure + " is " + conversionResult.ToString() + unitOfMeasure2
        lblResults.Visible = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblResults.Visible = False
        rdoInchtoMeter.Checked = True
    End Sub
End Class
