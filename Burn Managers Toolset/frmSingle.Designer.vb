<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSingle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
          Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSingle))
          Me.Panel1 = New System.Windows.Forms.Panel()
          Me.Label1 = New System.Windows.Forms.Label()
          Me.txBurnSize = New System.Windows.Forms.TextBox()
          Me.txCatDay = New System.Windows.Forms.TextBox()
          Me.Label2 = New System.Windows.Forms.Label()
          Me.txDistance = New System.Windows.Forms.TextBox()
          Me.Label3 = New System.Windows.Forms.Label()
          Me.Label4 = New System.Windows.Forms.Label()
          Me.txFtype = New System.Windows.Forms.ComboBox()
          Me.txFload = New System.Windows.Forms.ComboBox()
          Me.Label5 = New System.Windows.Forms.Label()
          Me.Panel2 = New System.Windows.Forms.Panel()
          Me.Label6 = New System.Windows.Forms.Label()
          Me.Label7 = New System.Windows.Forms.Label()
          Me.txAllowed = New System.Windows.Forms.Label()
          Me.txAvFuels = New System.Windows.Forms.Label()
          Me.txTotalTons = New System.Windows.Forms.Label()
          Me.Label11 = New System.Windows.Forms.Label()
          Me.txResults = New System.Windows.Forms.TextBox()
          Me.Label8 = New System.Windows.Forms.Label()
          Me.txRec = New System.Windows.Forms.Label()
          Me.pbClear = New System.Windows.Forms.PictureBox()
          Me.btnCalc = New System.Windows.Forms.Button()
          Me.PictureBox1 = New System.Windows.Forms.PictureBox()
          Me.Panel1.SuspendLayout()
          Me.Panel2.SuspendLayout()
          CType(Me.pbClear, System.ComponentModel.ISupportInitialize).BeginInit()
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
          Me.SuspendLayout()
          '
          'Panel1
          '
          Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
          Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
          Me.Panel1.Controls.Add(Me.txFload)
          Me.Panel1.Controls.Add(Me.Label5)
          Me.Panel1.Controls.Add(Me.txFtype)
          Me.Panel1.Controls.Add(Me.Label4)
          Me.Panel1.Controls.Add(Me.txDistance)
          Me.Panel1.Controls.Add(Me.Label3)
          Me.Panel1.Controls.Add(Me.txCatDay)
          Me.Panel1.Controls.Add(Me.Label2)
          Me.Panel1.Controls.Add(Me.txBurnSize)
          Me.Panel1.Controls.Add(Me.Label1)
          Me.Panel1.Location = New System.Drawing.Point(12, 12)
          Me.Panel1.Name = "Panel1"
          Me.Panel1.Size = New System.Drawing.Size(349, 90)
          Me.Panel1.TabIndex = 1
          '
          'Label1
          '
          Me.Label1.AutoSize = True
          Me.Label1.Location = New System.Drawing.Point(0, 0)
          Me.Label1.Name = "Label1"
          Me.Label1.Size = New System.Drawing.Size(55, 13)
          Me.Label1.TabIndex = 0
          Me.Label1.Text = "Burn Size:"
          '
          'txBurnSize
          '
          Me.txBurnSize.Location = New System.Drawing.Point(3, 16)
          Me.txBurnSize.Name = "txBurnSize"
          Me.txBurnSize.Size = New System.Drawing.Size(54, 20)
          Me.txBurnSize.TabIndex = 1
          '
          'txCatDay
          '
          Me.txCatDay.Location = New System.Drawing.Point(137, 16)
          Me.txCatDay.Name = "txCatDay"
          Me.txCatDay.Size = New System.Drawing.Size(36, 20)
          Me.txCatDay.TabIndex = 3
          '
          'Label2
          '
          Me.Label2.AutoSize = True
          Me.Label2.Location = New System.Drawing.Point(121, 0)
          Me.Label2.Name = "Label2"
          Me.Label2.Size = New System.Drawing.Size(74, 13)
          Me.Label2.TabIndex = 2
          Me.Label2.Text = "Category Day:"
          '
          'txDistance
          '
          Me.txDistance.Location = New System.Drawing.Point(249, 16)
          Me.txDistance.Name = "txDistance"
          Me.txDistance.Size = New System.Drawing.Size(37, 20)
          Me.txDistance.TabIndex = 5
          '
          'Label3
          '
          Me.Label3.AutoSize = True
          Me.Label3.Location = New System.Drawing.Point(236, 0)
          Me.Label3.Name = "Label3"
          Me.Label3.Size = New System.Drawing.Size(86, 13)
          Me.Label3.TabIndex = 4
          Me.Label3.Text = "Target Distance:"
          '
          'Label4
          '
          Me.Label4.AutoSize = True
          Me.Label4.Location = New System.Drawing.Point(0, 39)
          Me.Label4.Name = "Label4"
          Me.Label4.Size = New System.Drawing.Size(57, 13)
          Me.Label4.TabIndex = 6
          Me.Label4.Text = "Fuel Type:"
          '
          'txFtype
          '
          Me.txFtype.FormattingEnabled = True
          Me.txFtype.Items.AddRange(New Object() {"Shortleaf Pine with Oak", "Shortleaf Pine Regeneration", "Loblolly Pine with Oak", "Loblolly Pine Regeneration", "Hardwood Leaf Litter", "Grass or Brush", "Dispersed Slash", "Piled Debris", "Shortleaf Loblolly with Grass", "Corn", "Cotton", "Rice", "Soybean", "Wheat"})
          Me.txFtype.Location = New System.Drawing.Point(3, 55)
          Me.txFtype.Name = "txFtype"
          Me.txFtype.Size = New System.Drawing.Size(209, 21)
          Me.txFtype.TabIndex = 7
          '
          'txFload
          '
          Me.txFload.FormattingEnabled = True
          Me.txFload.Items.AddRange(New Object() {"Low", "Moderate", "Heavy"})
          Me.txFload.Location = New System.Drawing.Point(218, 55)
          Me.txFload.Name = "txFload"
          Me.txFload.Size = New System.Drawing.Size(121, 21)
          Me.txFload.TabIndex = 9
          '
          'Label5
          '
          Me.Label5.AutoSize = True
          Me.Label5.Location = New System.Drawing.Point(215, 39)
          Me.Label5.Name = "Label5"
          Me.Label5.Size = New System.Drawing.Size(71, 13)
          Me.Label5.TabIndex = 8
          Me.Label5.Text = "Fuel Loading:"
          '
          'Panel2
          '
          Me.Panel2.Controls.Add(Me.txTotalTons)
          Me.Panel2.Controls.Add(Me.Label11)
          Me.Panel2.Controls.Add(Me.txAllowed)
          Me.Panel2.Controls.Add(Me.txAvFuels)
          Me.Panel2.Controls.Add(Me.Label7)
          Me.Panel2.Controls.Add(Me.Label6)
          Me.Panel2.Location = New System.Drawing.Point(367, 12)
          Me.Panel2.Name = "Panel2"
          Me.Panel2.Size = New System.Drawing.Size(200, 90)
          Me.Panel2.TabIndex = 2
          '
          'Label6
          '
          Me.Label6.AutoSize = True
          Me.Label6.Location = New System.Drawing.Point(23, 10)
          Me.Label6.Name = "Label6"
          Me.Label6.Size = New System.Drawing.Size(81, 13)
          Me.Label6.TabIndex = 0
          Me.Label6.Text = "Available Fuels:"
          '
          'Label7
          '
          Me.Label7.AutoSize = True
          Me.Label7.Location = New System.Drawing.Point(30, 37)
          Me.Label7.Name = "Label7"
          Me.Label7.Size = New System.Drawing.Size(74, 13)
          Me.Label7.TabIndex = 1
          Me.Label7.Text = "Allowed Tons:"
          '
          'txAllowed
          '
          Me.txAllowed.AutoSize = True
          Me.txAllowed.Location = New System.Drawing.Point(110, 37)
          Me.txAllowed.Name = "txAllowed"
          Me.txAllowed.Size = New System.Drawing.Size(13, 13)
          Me.txAllowed.TabIndex = 3
          Me.txAllowed.Text = "0"
          '
          'txAvFuels
          '
          Me.txAvFuels.AutoSize = True
          Me.txAvFuels.Location = New System.Drawing.Point(110, 10)
          Me.txAvFuels.Name = "txAvFuels"
          Me.txAvFuels.Size = New System.Drawing.Size(22, 13)
          Me.txAvFuels.TabIndex = 2
          Me.txAvFuels.Text = "0.0"
          '
          'txTotalTons
          '
          Me.txTotalTons.AutoSize = True
          Me.txTotalTons.Location = New System.Drawing.Point(110, 64)
          Me.txTotalTons.Name = "txTotalTons"
          Me.txTotalTons.Size = New System.Drawing.Size(13, 13)
          Me.txTotalTons.TabIndex = 5
          Me.txTotalTons.Text = "0"
          '
          'Label11
          '
          Me.Label11.AutoSize = True
          Me.Label11.Location = New System.Drawing.Point(43, 64)
          Me.Label11.Name = "Label11"
          Me.Label11.Size = New System.Drawing.Size(61, 13)
          Me.Label11.TabIndex = 4
          Me.Label11.Text = "Total Tons:"
          '
          'txResults
          '
          Me.txResults.BackColor = System.Drawing.SystemColors.Info
          Me.txResults.BorderStyle = System.Windows.Forms.BorderStyle.None
          Me.txResults.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          Me.txResults.Location = New System.Drawing.Point(12, 108)
          Me.txResults.Name = "txResults"
          Me.txResults.Size = New System.Drawing.Size(555, 15)
          Me.txResults.TabIndex = 3
          Me.txResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
          '
          'Label8
          '
          Me.Label8.AutoSize = True
          Me.Label8.Location = New System.Drawing.Point(9, 140)
          Me.Label8.Name = "Label8"
          Me.Label8.Size = New System.Drawing.Size(98, 13)
          Me.Label8.TabIndex = 4
          Me.Label8.Text = "Recommendations:"
          '
          'txRec
          '
          Me.txRec.AutoSize = True
          Me.txRec.Location = New System.Drawing.Point(113, 140)
          Me.txRec.Name = "txRec"
          Me.txRec.Size = New System.Drawing.Size(19, 13)
          Me.txRec.TabIndex = 5
          Me.txRec.Text = "na"
          '
          'pbClear
          '
          Me.pbClear.Image = Global.Burn_Managers_Toolset.My.Resources.Resources.ClrFields
          Me.pbClear.Location = New System.Drawing.Point(455, 127)
          Me.pbClear.Name = "pbClear"
          Me.pbClear.Size = New System.Drawing.Size(74, 50)
          Me.pbClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
          Me.pbClear.TabIndex = 7
          Me.pbClear.TabStop = False
          '
          'btnCalc
          '
          Me.btnCalc.Image = Global.Burn_Managers_Toolset.My.Resources.Resources.cal027
          Me.btnCalc.Location = New System.Drawing.Point(535, 127)
          Me.btnCalc.Name = "btnCalc"
          Me.btnCalc.Size = New System.Drawing.Size(32, 38)
          Me.btnCalc.TabIndex = 6
          Me.btnCalc.UseVisualStyleBackColor = True
          '
          'PictureBox1
          '
          Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
          Me.PictureBox1.Image = Global.Burn_Managers_Toolset.My.Resources.Resources._0000001
          Me.PictureBox1.Location = New System.Drawing.Point(0, 185)
          Me.PictureBox1.Name = "PictureBox1"
          Me.PictureBox1.Size = New System.Drawing.Size(588, 185)
          Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
          Me.PictureBox1.TabIndex = 0
          Me.PictureBox1.TabStop = False
          '
          'frmSingle
          '
          Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(134, Byte), Integer))
          Me.ClientSize = New System.Drawing.Size(588, 370)
          Me.Controls.Add(Me.pbClear)
          Me.Controls.Add(Me.btnCalc)
          Me.Controls.Add(Me.txRec)
          Me.Controls.Add(Me.Label8)
          Me.Controls.Add(Me.txResults)
          Me.Controls.Add(Me.Panel2)
          Me.Controls.Add(Me.Panel1)
          Me.Controls.Add(Me.PictureBox1)
          Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
          Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
          Me.Name = "frmSingle"
          Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
          Me.Text = "x"
          Me.Panel1.ResumeLayout(False)
          Me.Panel1.PerformLayout()
          Me.Panel2.ResumeLayout(False)
          Me.Panel2.PerformLayout()
          CType(Me.pbClear, System.ComponentModel.ISupportInitialize).EndInit()
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
     Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
     Friend WithEvents Panel1 As System.Windows.Forms.Panel
     Friend WithEvents txFload As System.Windows.Forms.ComboBox
     Friend WithEvents Label5 As System.Windows.Forms.Label
     Friend WithEvents txFtype As System.Windows.Forms.ComboBox
     Friend WithEvents Label4 As System.Windows.Forms.Label
     Friend WithEvents txDistance As System.Windows.Forms.TextBox
     Friend WithEvents Label3 As System.Windows.Forms.Label
     Friend WithEvents txCatDay As System.Windows.Forms.TextBox
     Friend WithEvents Label2 As System.Windows.Forms.Label
     Friend WithEvents txBurnSize As System.Windows.Forms.TextBox
     Friend WithEvents Label1 As System.Windows.Forms.Label
     Friend WithEvents Panel2 As System.Windows.Forms.Panel
     Friend WithEvents txTotalTons As System.Windows.Forms.Label
     Friend WithEvents Label11 As System.Windows.Forms.Label
     Friend WithEvents txAllowed As System.Windows.Forms.Label
     Friend WithEvents txAvFuels As System.Windows.Forms.Label
     Friend WithEvents Label7 As System.Windows.Forms.Label
     Friend WithEvents Label6 As System.Windows.Forms.Label
     Friend WithEvents txResults As System.Windows.Forms.TextBox
     Friend WithEvents Label8 As System.Windows.Forms.Label
     Friend WithEvents txRec As System.Windows.Forms.Label
     Friend WithEvents btnCalc As System.Windows.Forms.Button
     Friend WithEvents pbClear As System.Windows.Forms.PictureBox
End Class
