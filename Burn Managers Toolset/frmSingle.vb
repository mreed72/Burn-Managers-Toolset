Public Class frmSingle
     Dim sid As Integer = My.Settings.CurrentSession
     Private Sub frmSingle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
          Me.Text = "Current Session: " & sid

     End Sub

     Private Sub btnCalc_Click(sender As System.Object, e As System.EventArgs) Handles btnCalc.Click
          'CALC
          Try
               If txBurnSize.Text = String.Empty Then
                    txBurnSize.BackColor = Color.Yellow
                    txBurnSize.Focus()
                    Exit Sub
               Else
                    txBurnSize.BackColor = Color.White
               End If

               If txDistance.Text = String.Empty Then
                    txDistance.BackColor = Color.Yellow
                    txDistance.Focus()
                    Exit Sub
               Else
                    txDistance.BackColor = Color.White
               End If

               If txCatDay.Text = String.Empty Then
                    txCatDay.BackColor = Color.Yellow
                    txCatDay.Focus()
                    Exit Sub
               Else
                    txCatDay.BackColor = Color.White
               End If

               If txCatDay.Text >= 6 Then
                    txCatDay.BackColor = Color.Yellow
                    txCatDay.Focus()
                    Exit Sub
               Else
                    txCatDay.BackColor = Color.White
               End If

               If txFtype.SelectedIndex = -1 Then
                    txFtype.BackColor = Color.Yellow
                    Exit Sub
               Else
                    txFtype.BackColor = Color.White
               End If

               If txFload.SelectedIndex = -1 Then
                    txFload.BackColor = Color.Yellow
                    Exit Sub
               Else
                    txFload.BackColor = Color.White
               End If
          Catch ex As Exception
               ErrorLog("1X2HI1G", ex.Message)
          End Try

          Try
               Dim sNEW As Integer = 0

               txAvFuels.Text = GetTonsAvailable(txFtype.SelectedItem, txFload.SelectedItem)
               txTotalTons.Text = Val(txBurnSize.Text) * Val(txAvFuels.Text)
               txAllowed.Text = smpCalc(txCatDay.Text, txDistance.Text)
               sNEW = Val(txAllowed.Text) / Val(txAvFuels.Text) - 3

               If Val(txTotalTons.Text) >= Val(txAllowed.Text) Then
                    txResults.Text = "This burn will EXCEED the guidelines."
                    txResults.BackColor = Color.LightPink
                    txRec.Text = "Recommend a new burn size of: " & sNEW & " acres."
               Else
                    txResults.Text = "This burn will not exceed the guidelines."
                    txResults.BackColor = Color.White
                    txRec.Text = "na"
               End If
          Catch ex As Exception
               ErrorLog("1XACX2B", ex.Message)
          End Try

          LogThis(txBurnSize.Text, txCatDay.Text, txDistance.Text, txAvFuels.Text, txAllowed.Text, txTotalTons.Text, txFtype.SelectedItem, txFload.SelectedItem, txResults.Text, txRec.Text)

     End Sub

     Private Sub pbClear_Click(sender As System.Object, e As System.EventArgs) Handles pbClear.Click
          'CLEAR
          Try
               txBurnSize.Clear()
               txCatDay.Clear()
               txDistance.Clear()
               txFtype.SelectedIndex = -1
               txFload.SelectedIndex = -1
               txRec.Text = "na"
               txResults.Clear()
               txAllowed.Text = "0"
               txAvFuels.Text = "0.0"
               txTotalTons.Text = "0"
          Catch ex As Exception
               ErrorLog("1X902VO", ex.Message)
          End Try

     End Sub


     Private Function LogThis(bs As Integer, cd As Integer, td As Integer, avf As Double, allw As Integer, ttns As Integer, ftp As String, fld As String, res As String, rec As String)

          Try
               Dim Final As String
               Final = "Burn Size: " & bs & vbNewLine & "Catedgory Day: " & cd & vbNewLine & "Target Distance: " & td & vbNewLine & _
                    "Available Fuels: " & avf & vbNewLine & "Allowed Tons: " & allw & vbNewLine & "Total Tons: " & ttns & vbNewLine & _
                    "Fuel Type: " & ftp & vbNewLine & "Fuel Loading: " & fld & vbNewLine & "Results: " & res & vbNewLine & "Recommendations: " & rec

               Log(Final, "Single Fuels Calculation")
          Catch ex As Exception
               ErrorLog("1XJCFFS", ex.Message)
          End Try


     End Function



End Class