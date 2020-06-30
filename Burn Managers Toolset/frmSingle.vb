Public Class frmSingle
     Dim sid As Integer = My.Settings.CurrentSession
     Private Sub frmSingle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
          Me.Text = "Current Session: " & sid

     End Sub

     Private Sub btnCalc_Click(sender As System.Object, e As System.EventArgs) Handles btnCalc.Click
          'CALC


          txAvFuels.Text = GetTonsAvailable(txFtype.SelectedItem, txFload.SelectedItem)
          txTotalTons.Text = Val(txBurnSize.Text) * Val(txAvFuels.Text)
          txAllowed.Text = smpCalc(txCatDay.Text, txDistance.Text)



     End Sub

     Private Sub pbClear_Click(sender As System.Object, e As System.EventArgs) Handles pbClear.Click
          'CLEAR


     End Sub
End Class