Public Class Form1

     Dim sLocation As String = "C:\PB Toolset\Sessions\"
     Dim sTSID As Integer

     Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
          Dim xv As String = My.Application.Info.Version.ToString
          sTSID = grs(6)
          Me.Text = "Toolset Session: " & sTSID
          CreateSession()
          My.Settings.CurrentSession = sTSID
          My.Settings.Save()


     End Sub

     Function CreateSession()
          Dim cs As Boolean
          cs = My.Computer.FileSystem.DirectoryExists(sLocation & sTSID)
          If cs = False Then
               My.Computer.FileSystem.CreateDirectory(sLocation & sTSID)
          End If
     End Function



     Private Sub btnSingleFuels_Click(sender As System.Object, e As System.EventArgs) Handles btnSingleFuels.Click
          'Single Fuels Button
          frmSingle.Show()

     End Sub

     Private Sub btnMultipleFuels_Click(sender As System.Object, e As System.EventArgs) Handles btnMultipleFuels.Click
          'Multiple Fuels Button
          frmMultiple.Show()

     End Sub

     Function grs(ByRef length As Integer) As String
          Randomize()
          Dim ac As String
          ac = "123456789"
          Dim i As Integer
          For i = 1 To length
               grs = grs & Mid(ac, Int(Rnd() * Len(ac) + 1), 1)
          Next
     End Function


     Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
          If MessageBox.Show("This will end your current session, do you want to continue?", "Session Ending!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
               Application.Exit()
          Else
               Exit Sub
          End If
     End Sub
End Class
