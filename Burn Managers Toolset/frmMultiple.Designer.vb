<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultiple
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
          Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMultiple))
          Me.Panel1 = New System.Windows.Forms.Panel()
          Me.txDistance = New System.Windows.Forms.TextBox()
          Me.Label2 = New System.Windows.Forms.Label()
          Me.txCatDay = New System.Windows.Forms.TextBox()
          Me.Label1 = New System.Windows.Forms.Label()
          Me.Panel2 = New System.Windows.Forms.Panel()
          Me.txResults = New System.Windows.Forms.TextBox()
          Me.Label5 = New System.Windows.Forms.Label()
          Me.Label4 = New System.Windows.Forms.Label()
          Me.Label3 = New System.Windows.Forms.Label()
          Me.txBlkLoad = New System.Windows.Forms.ComboBox()
          Me.txBlkType = New System.Windows.Forms.ComboBox()
          Me.txBlkSize = New System.Windows.Forms.TextBox()
          Me.dgv = New System.Windows.Forms.DataGridView()
          Me.bSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
          Me.bType = New System.Windows.Forms.DataGridViewTextBoxColumn()
          Me.bLoad = New System.Windows.Forms.DataGridViewTextBoxColumn()
          Me.bAvF = New System.Windows.Forms.DataGridViewTextBoxColumn()
          Me.bTTns = New System.Windows.Forms.DataGridViewTextBoxColumn()
          Me.Label6 = New System.Windows.Forms.Label()
          Me.txTotalSize = New System.Windows.Forms.Label()
          Me.txTotalTons = New System.Windows.Forms.Label()
          Me.Label9 = New System.Windows.Forms.Label()
          Me.btnCalc = New System.Windows.Forms.Button()
          Me.btnAddNew = New System.Windows.Forms.Button()
          Me.btnClear = New System.Windows.Forms.Button()
          Me.Panel1.SuspendLayout()
          Me.Panel2.SuspendLayout()
          CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
          Me.SuspendLayout()
          '
          'Panel1
          '
          Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
          Me.Panel1.Controls.Add(Me.txDistance)
          Me.Panel1.Controls.Add(Me.Label2)
          Me.Panel1.Controls.Add(Me.txCatDay)
          Me.Panel1.Controls.Add(Me.Label1)
          Me.Panel1.Location = New System.Drawing.Point(14, 16)
          Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
          Me.Panel1.Name = "Panel1"
          Me.Panel1.Size = New System.Drawing.Size(113, 104)
          Me.Panel1.TabIndex = 0
          '
          'txDistance
          '
          Me.txDistance.Location = New System.Drawing.Point(31, 74)
          Me.txDistance.Name = "txDistance"
          Me.txDistance.Size = New System.Drawing.Size(45, 22)
          Me.txDistance.TabIndex = 3
          '
          'Label2
          '
          Me.Label2.AutoSize = True
          Me.Label2.Location = New System.Drawing.Point(1, 54)
          Me.Label2.Name = "Label2"
          Me.Label2.Size = New System.Drawing.Size(105, 17)
          Me.Label2.TabIndex = 2
          Me.Label2.Text = "Target Distance:"
          '
          'txCatDay
          '
          Me.txCatDay.Location = New System.Drawing.Point(31, 24)
          Me.txCatDay.Name = "txCatDay"
          Me.txCatDay.Size = New System.Drawing.Size(45, 22)
          Me.txCatDay.TabIndex = 1
          '
          'Label1
          '
          Me.Label1.AutoSize = True
          Me.Label1.Location = New System.Drawing.Point(7, 4)
          Me.Label1.Name = "Label1"
          Me.Label1.Size = New System.Drawing.Size(93, 17)
          Me.Label1.TabIndex = 0
          Me.Label1.Text = "Category Day:"
          '
          'Panel2
          '
          Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
          Me.Panel2.Controls.Add(Me.txResults)
          Me.Panel2.Controls.Add(Me.Label5)
          Me.Panel2.Controls.Add(Me.Label4)
          Me.Panel2.Controls.Add(Me.Label3)
          Me.Panel2.Controls.Add(Me.txBlkLoad)
          Me.Panel2.Controls.Add(Me.txBlkType)
          Me.Panel2.Controls.Add(Me.txBlkSize)
          Me.Panel2.Location = New System.Drawing.Point(133, 16)
          Me.Panel2.Name = "Panel2"
          Me.Panel2.Size = New System.Drawing.Size(488, 104)
          Me.Panel2.TabIndex = 1
          '
          'txResults
          '
          Me.txResults.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(134, Byte), Integer))
          Me.txResults.BorderStyle = System.Windows.Forms.BorderStyle.None
          Me.txResults.Dock = System.Windows.Forms.DockStyle.Bottom
          Me.txResults.Location = New System.Drawing.Point(0, 85)
          Me.txResults.Name = "txResults"
          Me.txResults.Size = New System.Drawing.Size(484, 15)
          Me.txResults.TabIndex = 9
          '
          'Label5
          '
          Me.Label5.AutoSize = True
          Me.Label5.Location = New System.Drawing.Point(340, 15)
          Me.Label5.Name = "Label5"
          Me.Label5.Size = New System.Drawing.Size(121, 17)
          Me.Label5.TabIndex = 8
          Me.Label5.Text = "Block Fuel Loading:"
          '
          'Label4
          '
          Me.Label4.AutoSize = True
          Me.Label4.Location = New System.Drawing.Point(98, 15)
          Me.Label4.Name = "Label4"
          Me.Label4.Size = New System.Drawing.Size(100, 17)
          Me.Label4.TabIndex = 7
          Me.Label4.Text = "Block Fuel Type:"
          '
          'Label3
          '
          Me.Label3.AutoSize = True
          Me.Label3.Location = New System.Drawing.Point(0, 14)
          Me.Label3.Name = "Label3"
          Me.Label3.Size = New System.Drawing.Size(69, 17)
          Me.Label3.TabIndex = 6
          Me.Label3.Text = "Block Size:"
          '
          'txBlkLoad
          '
          Me.txBlkLoad.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          Me.txBlkLoad.FormattingEnabled = True
          Me.txBlkLoad.Items.AddRange(New Object() {"Low", "Moderate", "Heavy"})
          Me.txBlkLoad.Location = New System.Drawing.Point(340, 34)
          Me.txBlkLoad.Name = "txBlkLoad"
          Me.txBlkLoad.Size = New System.Drawing.Size(121, 28)
          Me.txBlkLoad.TabIndex = 5
          '
          'txBlkType
          '
          Me.txBlkType.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          Me.txBlkType.FormattingEnabled = True
          Me.txBlkType.Items.AddRange(New Object() {"Shortleaf Pine with Oak", "Shortleaf Pine Regeneration", "Loblolly Pine with Oak", "Loblolly Pine Regeneration", "Hardwood Leaf Litter", "Grass or Brush", "Dispersed Slash", "Piled Debris", "Shortleaf Loblolly with Grass", "Corn", "Cotton", "Rice", "Soybean", "Wheat"})
          Me.txBlkType.Location = New System.Drawing.Point(98, 34)
          Me.txBlkType.Name = "txBlkType"
          Me.txBlkType.Size = New System.Drawing.Size(236, 28)
          Me.txBlkType.TabIndex = 4
          '
          'txBlkSize
          '
          Me.txBlkSize.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          Me.txBlkSize.Location = New System.Drawing.Point(3, 34)
          Me.txBlkSize.Name = "txBlkSize"
          Me.txBlkSize.Size = New System.Drawing.Size(58, 26)
          Me.txBlkSize.TabIndex = 3
          '
          'dgv
          '
          Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
          Me.dgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(134, Byte), Integer))
          Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
          Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
          Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bSize, Me.bType, Me.bLoad, Me.bAvF, Me.bTTns})
          Me.dgv.Location = New System.Drawing.Point(133, 126)
          Me.dgv.Name = "dgv"
          Me.dgv.Size = New System.Drawing.Size(488, 150)
          Me.dgv.TabIndex = 9
          '
          'bSize
          '
          Me.bSize.HeaderText = "Size"
          Me.bSize.Name = "bSize"
          Me.bSize.Width = 56
          '
          'bType
          '
          Me.bType.HeaderText = "Type"
          Me.bType.Name = "bType"
          Me.bType.Width = 60
          '
          'bLoad
          '
          Me.bLoad.HeaderText = "Load"
          Me.bLoad.Name = "bLoad"
          Me.bLoad.Width = 63
          '
          'bAvF
          '
          Me.bAvF.HeaderText = "AvFuels"
          Me.bAvF.Name = "bAvF"
          Me.bAvF.Width = 79
          '
          'bTTns
          '
          Me.bTTns.HeaderText = "TotalTons"
          Me.bTTns.Name = "bTTns"
          Me.bTTns.Width = 87
          '
          'Label6
          '
          Me.Label6.AutoSize = True
          Me.Label6.Location = New System.Drawing.Point(130, 279)
          Me.Label6.Name = "Label6"
          Me.Label6.Size = New System.Drawing.Size(94, 17)
          Me.Label6.TabIndex = 10
          Me.Label6.Text = "Total Burn Size:"
          '
          'txTotalSize
          '
          Me.txTotalSize.AutoSize = True
          Me.txTotalSize.Location = New System.Drawing.Point(230, 279)
          Me.txTotalSize.Name = "txTotalSize"
          Me.txTotalSize.Size = New System.Drawing.Size(15, 17)
          Me.txTotalSize.TabIndex = 11
          Me.txTotalSize.Text = "0"
          '
          'txTotalTons
          '
          Me.txTotalTons.AutoSize = True
          Me.txTotalTons.Location = New System.Drawing.Point(534, 279)
          Me.txTotalTons.Name = "txTotalTons"
          Me.txTotalTons.Size = New System.Drawing.Size(15, 17)
          Me.txTotalTons.TabIndex = 13
          Me.txTotalTons.Text = "0"
          '
          'Label9
          '
          Me.Label9.AutoSize = True
          Me.Label9.Location = New System.Drawing.Point(460, 279)
          Me.Label9.Name = "Label9"
          Me.Label9.Size = New System.Drawing.Size(68, 17)
          Me.Label9.TabIndex = 12
          Me.Label9.Text = "Total Tons:"
          '
          'btnCalc
          '
          Me.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
          Me.btnCalc.Image = Global.Burn_Managers_Toolset.My.Resources.Resources.cal028
          Me.btnCalc.Location = New System.Drawing.Point(627, 117)
          Me.btnCalc.Name = "btnCalc"
          Me.btnCalc.Size = New System.Drawing.Size(68, 67)
          Me.btnCalc.TabIndex = 14
          Me.btnCalc.UseVisualStyleBackColor = True
          '
          'btnAddNew
          '
          Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
          Me.btnAddNew.Image = Global.Burn_Managers_Toolset.My.Resources.Resources.addbtn
          Me.btnAddNew.Location = New System.Drawing.Point(627, 22)
          Me.btnAddNew.Name = "btnAddNew"
          Me.btnAddNew.Size = New System.Drawing.Size(68, 89)
          Me.btnAddNew.TabIndex = 2
          Me.btnAddNew.UseVisualStyleBackColor = True
          '
          'btnClear
          '
          Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
          Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
          Me.btnClear.Location = New System.Drawing.Point(627, 190)
          Me.btnClear.Name = "btnClear"
          Me.btnClear.Size = New System.Drawing.Size(68, 46)
          Me.btnClear.TabIndex = 15
          Me.btnClear.Text = "Clear Fields"
          Me.btnClear.UseVisualStyleBackColor = False
          '
          'frmMultiple
          '
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
          Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(134, Byte), Integer))
          Me.ClientSize = New System.Drawing.Size(700, 317)
          Me.Controls.Add(Me.btnClear)
          Me.Controls.Add(Me.btnCalc)
          Me.Controls.Add(Me.txTotalTons)
          Me.Controls.Add(Me.Label9)
          Me.Controls.Add(Me.txTotalSize)
          Me.Controls.Add(Me.Label6)
          Me.Controls.Add(Me.dgv)
          Me.Controls.Add(Me.btnAddNew)
          Me.Controls.Add(Me.Panel2)
          Me.Controls.Add(Me.Panel1)
          Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
          Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
          Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
          Me.Name = "frmMultiple"
          Me.Text = "x"
          Me.Panel1.ResumeLayout(False)
          Me.Panel1.PerformLayout()
          Me.Panel2.ResumeLayout(False)
          Me.Panel2.PerformLayout()
          CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
     Friend WithEvents Panel1 As System.Windows.Forms.Panel
     Friend WithEvents txDistance As System.Windows.Forms.TextBox
     Friend WithEvents Label2 As System.Windows.Forms.Label
     Friend WithEvents txCatDay As System.Windows.Forms.TextBox
     Friend WithEvents Label1 As System.Windows.Forms.Label
     Friend WithEvents Panel2 As System.Windows.Forms.Panel
     Friend WithEvents Label5 As System.Windows.Forms.Label
     Friend WithEvents Label4 As System.Windows.Forms.Label
     Friend WithEvents Label3 As System.Windows.Forms.Label
     Friend WithEvents txBlkLoad As System.Windows.Forms.ComboBox
     Friend WithEvents txBlkType As System.Windows.Forms.ComboBox
     Friend WithEvents txBlkSize As System.Windows.Forms.TextBox
     Friend WithEvents btnAddNew As System.Windows.Forms.Button
     Friend WithEvents dgv As System.Windows.Forms.DataGridView
     Friend WithEvents bSize As System.Windows.Forms.DataGridViewTextBoxColumn
     Friend WithEvents bType As System.Windows.Forms.DataGridViewTextBoxColumn
     Friend WithEvents bLoad As System.Windows.Forms.DataGridViewTextBoxColumn
     Friend WithEvents bAvF As System.Windows.Forms.DataGridViewTextBoxColumn
     Friend WithEvents bTTns As System.Windows.Forms.DataGridViewTextBoxColumn
     Friend WithEvents Label6 As System.Windows.Forms.Label
     Friend WithEvents txTotalSize As System.Windows.Forms.Label
     Friend WithEvents txTotalTons As System.Windows.Forms.Label
     Friend WithEvents Label9 As System.Windows.Forms.Label
     Friend WithEvents btnCalc As System.Windows.Forms.Button
     Friend WithEvents txResults As System.Windows.Forms.TextBox
     Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
