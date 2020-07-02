Public Class frmMultiple
     Dim sid As Integer = My.Settings.CurrentSession
     Dim exID As String

     Private Sub frmMultiple_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
          Me.Text = "Current Session: " & sid

     End Sub

     Function AddUp()

          Dim xgal, xamt As Integer

          For Each row As DataGridViewRow In dgv.Rows
               If IsDBNull(row.Cells(0).Value) Then On Error Resume Next
               If IsDBNull(row.Cells(4).Value) Then On Error Resume Next
               xgal += row.Cells(0).Value
               xamt += row.Cells(4).Value
          Next

          txTotalSize.Text = xgal
          txTotalTons.Text = xamt
  
     End Function


     Private Sub btnAddNew_Click(sender As System.Object, e As System.EventArgs) Handles btnAddNew.Click
          Try
               Dim av As Double
               Dim tt As Integer
               av = GetTonsAvailable(txBlkType.SelectedItem, txBlkLoad.SelectedItem)
               tt = Val(txBlkSize.Text) * Val(av)

               dgv.Rows.Add(txBlkSize.Text, txBlkType.SelectedItem, txBlkLoad.SelectedItem, av, tt)

               AddUp()
               txBlkSize.Clear()
               txBlkType.SelectedIndex = -1
               txBlkLoad.SelectedIndex = -1
               txBlkSize.Focus()
          Catch ex As Exception
               ErrorLog("1XM3Y9Q", ex.Message)
          End Try

     End Sub

     Private Sub btnCalc_Click(sender As System.Object, e As System.EventArgs) Handles btnCalc.Click


          Try
               If txCatDay.Text = String.Empty Or txCatDay.Text >= 6 Then
                    txCatDay.BackColor = Color.Yellow
                    txCatDay.Focus()
                    Exit Sub
               Else
                    txCatDay.BackColor = Color.White
               End If

               If txDistance.Text = String.Empty Then
                    txDistance.BackColor = Color.Yellow
                    txDistance.Focus()
                    Exit Sub
               Else
                    txDistance.BackColor = Color.White
               End If

               Dim cfin As Integer = smpCalc(txCatDay.Text, txDistance.Text)
               If Val(txTotalTons.Text) > Val(cfin) Then
                    txResults.Text = "This burn will exceed the guidelines."
                    txResults.BackColor = Color.LightPink
                    Me.BackColor = Color.LightPink
               Else
                    txResults.Text = "This burn will not exceed the guidelines."
                    txResults.BackColor = Color.LightGreen
                    Me.BackColor = Color.FromArgb(255, 218, 134)
               End If
               exID = "Multi_" & sid & "_" & grs(5)
               DGtoCSV()
               LogThis(exID, cfin)
          Catch ex As Exception
               ErrorLog("1XFRUDN", ex.Message)
          End Try
     End Sub

     Private Function LogThis(d As String, allwd As Integer)
          Try
               Dim bs, cd, td, ttns As Integer
               Dim res As String
               bs = txTotalSize.Text
               cd = txCatDay.Text
               td = txDistance.Text
               ttns = txTotalTons.Text
               res = txResults.Text


               Dim Final As String
               Final = d & vbNewLine & "Burn Size: " & bs & vbNewLine & "Catedgory Day: " & cd & vbNewLine & "Target Distance: " & td & vbNewLine & _
                    "Allowed Tons: " & allwd & vbNewLine & "Total Tons: " & ttns & vbNewLine & "Results: " & res

               Log(Final, "Multiple Fuels Calculation")
          Catch ex As Exception
               ErrorLog("1X8MN1S", ex.Message)
          End Try


     End Function

     Function grs(ByRef length As Integer) As String
          Randomize()
          Dim ac As String
          ac = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
          Dim i As Integer
          For i = 1 To length
               grs = grs & Mid(ac, Int(Rnd() * Len(ac) + 1), 1)
          Next
     End Function

     Function DGtoCSV()
          Try
               Dim StrExport As String = ""
               For Each C As DataGridViewColumn In dgv.Columns
                    StrExport &= """" & C.HeaderText & ""","
               Next
               StrExport = StrExport.Substring(0, StrExport.Length - 1)
               StrExport &= Environment.NewLine

               For Each R As DataGridViewRow In dgv.Rows
                    For Each C As DataGridViewCell In R.Cells
                         If Not C.Value Is Nothing Then
                              StrExport &= """" & C.Value.ToString & ""","
                         Else
                              StrExport &= """" & "" & ""","
                         End If
                    Next
                    StrExport = StrExport.Substring(0, StrExport.Length - 1)
                    StrExport &= Environment.NewLine
               Next

               Dim tw As IO.TextWriter = New IO.StreamWriter("C:\PB Toolset\Sessions\" & My.Settings.CurrentSession & "\" & exID & ".csv")
               tw.Write(StrExport)
               tw.Close()
          Catch ex As Exception
               ErrorLog("1XV2E82", ex.Message)
          End Try
     End Function




     Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
          Try
               txBlkSize.Clear()
               txBlkType.SelectedIndex = -1
               txBlkLoad.SelectedIndex = -1
               txCatDay.Clear()
               txDistance.Clear()
               txResults.Clear()
               txResults.BackColor = Color.FromArgb(255, 218, 134)
               dgv.Rows.Clear()
               txTotalSize.Text = "0"
               txTotalTons.Text = "0"
               Me.BackColor = Color.FromArgb(255, 218, 134)
          Catch ex As Exception
               ErrorLog("1XVQ6CA", ex.Message)
          End Try




     End Sub


End Class