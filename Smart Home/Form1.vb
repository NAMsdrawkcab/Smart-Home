Public Class Form1
    Private _intSizeOfArray As Integer = 12
    Private _strSavings(_intSizeOfArray)
    Private _decBill(_intSizeOfArray)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader
        Dim strSavingsAmount As String
        Dim intCount As Integer = 0
        Dim intFill As Integer

        lblMonth.Text = ""
        lblAverage.Text = ""
        lblMost.Text = ""
        'savings.txt was saved in my Personal Onedrive. Please change the file paths below to access savings.txt
        If IO.File.Exists("C:\Users\namho\OneDrive\Documents\savings.txt") = True Then
            objReader = IO.File.OpenText("C:\Users\namho\OneDrive\Documents\savings.txt")
            Do While objReader.Peek <> -1
                _strSavings(intCount) = objReader.ReadLine()
                strSavingsAmount = objReader.ReadLine()
                _decBill(intCount) = Convert.ToDecimal(strSavingsAmount)
                intCount += 1
            Loop
            objReader.Close()
            For intFill = 0 To (_strSavings.Length - 1)
                cboMonth.Items.Add(_strSavings(intFill))
            Next
        Else
            MsgBox("The file is not available. Restart the program when the file is available", , "Error")
            Close()
        End If
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        Dim intSelection As Integer

        intSelection = cboMonth.SelectedIndex
        lblMonth.Text = "The electric savings for " & _strSavings(intSelection) & " is $" & _decBill(intSelection).ToString()
        btnDisplay.Visible = True
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ComputeAverage()
        ComputeMax()
    End Sub
    Private Sub ComputeMax()
        Dim intMonths As Integer
        Dim intLargest As Integer = 0
        Dim intIndex As Integer = 0
        Dim strYearValue As String = ""

        For Each intMonths In _decBill
            intLargest = Math.Max(intLargest, intMonths)
            If (intMonths >= intLargest) Then
                strYearValue = _strSavings(intIndex)
            End If
            intIndex += 1
        Next
        lblMost.Text = strYearValue & " had the most significant monthly savings"
    End Sub
    Private Sub ComputeAverage()
        Dim intCount As Integer
        Dim intYears As Integer = 0
        Dim decTotalBill As Decimal = 0
        Dim decAverage As Decimal = 0D
        For Each intCount In _decBill
            decTotalBill += _decBill(intYears)
            intYears += 1
        Next
        decAverage = decTotalBill / Convert.ToDecimal(_decBill.Length())
        lblAverage.Text = "The average monthly savings is " & decAverage.ToString("C2")
    End Sub
End Class
