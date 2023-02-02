'Name: Jacket Haven
'Purpose: Calculate cost and total ordered with textboxes and apply discounts via checkbox
'Programmer: Owen Smith


Option Explicit On
Option Strict On
Option Infer Off



Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intAmountDue As Double
        Dim intAmountOrdered As Double
        Dim intAmountSaved As Double
        Dim dblBlack As Double
        Dim dblRed As Double
        Dim dblNavy As Double
        Double.TryParse(txtBlack.Text, dblBlack)
        Double.TryParse(txtRed.Text, dblRed)
        Double.TryParse(txtNavy.Text, dblNavy)
        intAmountOrdered = dblBlack + dblNavy + dblRed
        intAmountDue = (dblBlack * 45.99) + (dblNavy * 39.99) + (dblRed * 39.99)

        If chkCreditCard.Checked = True Then
            intAmountSaved = intAmountDue * 0.1
            intAmountDue -= intAmountSaved
        ElseIf intAmountOrdered > 1 = True Then
            intAmountSaved = intAmountDue * 0.05
            intAmountDue -= intAmountSaved
        End If
        lblPrice.Text = intAmountDue.ToString("C2")
        lblOrdered.Text = intAmountOrdered.ToString("")
        lblSaved.Text = intAmountSaved.ToString("C2")
    End Sub

    Private Sub chkCreditCard_CheckedChanged(sender As Object, e As EventArgs) Handles chkCreditCard.CheckedChanged
        lblOrdered.ResetText()
        lblPrice.ResetText()
        lblSaved.ResetText()
    End Sub

    Private Sub txtBlack_TextChanged(sender As Object, e As EventArgs) Handles txtBlack.TextChanged
        lblOrdered.ResetText()
        lblPrice.ResetText()
        lblSaved.ResetText()
    End Sub

    Private Sub txtNavy_TextChanged(sender As Object, e As EventArgs) Handles txtNavy.TextChanged
        lblOrdered.ResetText()
        lblPrice.ResetText()
        lblSaved.ResetText()
    End Sub

    Private Sub txtRed_TextChanged(sender As Object, e As EventArgs) Handles txtRed.TextChanged
        lblOrdered.ResetText()
        lblPrice.ResetText()
        lblSaved.ResetText()
    End Sub

    Private Sub txtBlack_Enter(sender As Object, e As EventArgs) Handles txtBlack.Enter
        txtBlack.SelectAll()
    End Sub

    Private Sub txtNavy_Enter(sender As Object, e As EventArgs) Handles txtNavy.Enter
        txtNavy.SelectAll()
    End Sub

    Private Sub txtRed_Enter(sender As Object, e As EventArgs) Handles txtRed.Enter
        txtRed.SelectAll()
    End Sub

    Private Sub txtBlack_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBlack.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNavy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNavy.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRed.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class

