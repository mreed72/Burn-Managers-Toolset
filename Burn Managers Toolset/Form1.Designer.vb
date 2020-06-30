<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
          Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
          Me.Panel1 = New System.Windows.Forms.Panel()
          Me.Label2 = New System.Windows.Forms.Label()
          Me.btnMultipleFuels = New System.Windows.Forms.Button()
          Me.Label1 = New System.Windows.Forms.Label()
          Me.btnSingleFuels = New System.Windows.Forms.Button()
          Me.PictureBox1 = New System.Windows.Forms.PictureBox()
          Me.Button1 = New System.Windows.Forms.Button()
          Me.Panel1.SuspendLayout()
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
          Me.SuspendLayout()
          '
          'Panel1
          '
          Me.Panel1.BackColor = System.Drawing.SystemColors.Control
          Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
          Me.Panel1.Controls.Add(Me.Label2)
          Me.Panel1.Controls.Add(Me.btnMultipleFuels)
          Me.Panel1.Controls.Add(Me.Label1)
          Me.Panel1.Controls.Add(Me.btnSingleFuels)
          Me.Panel1.Location = New System.Drawing.Point(12, 12)
          Me.Panel1.Name = "Panel1"
          Me.Panel1.Size = New System.Drawing.Size(308, 132)
          Me.Panel1.TabIndex = 1
          '
          'Label2
          '
          Me.Label2.AutoSize = True
          Me.Label2.Location = New System.Drawing.Point(35, 39)
          Me.Label2.Name = "Label2"
          Me.Label2.Size = New System.Drawing.Size(201, 13)
          Me.Label2.TabIndex = 5
          Me.Label2.Text = "Multiple Fuels Calculator for Smoke Mgmt"
          '
          'btnMultipleFuels
          '
          Me.btnMultipleFuels.FlatStyle = System.Windows.Forms.FlatStyle.Popup
          Me.btnMultipleFuels.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          Me.btnMultipleFuels.Image = Global.Burn_Managers_Toolset.My.Resources.Resources.fire_big_icon
          Me.btnMultipleFuels.Location = New System.Drawing.Point(3, 34)
          Me.btnMultipleFuels.Name = "btnMultipleFuels"
          Me.btnMultipleFuels.Size = New System.Drawing.Size(26, 25)
          Me.btnMultipleFuels.TabIndex = 4
          Me.btnMultipleFuels.TextAlign = System.Drawing.ContentAlignment.TopCenter
          Me.btnMultipleFuels.UseVisualStyleBackColor = True
          '
          'Label1
          '
          Me.Label1.AutoSize = True
          Me.Label1.Location = New System.Drawing.Point(35, 8)
          Me.Label1.Name = "Label1"
          Me.Label1.Size = New System.Drawing.Size(194, 13)
          Me.Label1.TabIndex = 3
          Me.Label1.Text = "Single Fuels Calculator for Smoke Mgmt"
          '
          'btnSingleFuels
          '
          Me.btnSingleFuels.FlatStyle = System.Windows.Forms.FlatStyle.Popup
          Me.btnSingleFuels.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          Me.btnSingleFuels.Image = Global.Burn_Managers_Toolset.My.Resources.Resources.fire_icon__2_
          Me.btnSingleFuels.Location = New System.Drawing.Point(3, 3)
          Me.btnSingleFuels.Name = "btnSingleFuels"
          Me.btnSingleFuels.Size = New System.Drawing.Size(26, 25)
          Me.btnSingleFuels.TabIndex = 2
          Me.btnSingleFuels.TextAlign = System.Drawing.ContentAlignment.TopCenter
          Me.btnSingleFuels.UseVisualStyleBackColor = True
          '
          'PictureBox1
          '
          Me.PictureBox1.Image = Global.Burn_Managers_Toolset.My.Resources.Resources.FC010y
          Me.PictureBox1.Location = New System.Drawing.Point(326, 12)
          Me.PictureBox1.Name = "PictureBox1"
          Me.PictureBox1.Size = New System.Drawing.Size(375, 132)
          Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
          Me.PictureBox1.TabIndex = 0
          Me.PictureBox1.TabStop = False
          '
          'Button1
          '
          Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
          Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
          Me.Button1.Location = New System.Drawing.Point(610, 17)
          Me.Button1.Name = "Button1"
          Me.Button1.Size = New System.Drawing.Size(80, 23)
          Me.Button1.TabIndex = 2
          Me.Button1.Text = "Exit Session"
          Me.Button1.UseVisualStyleBackColor = False
          '
          'Form1
          '
          Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(134, Byte), Integer))
          Me.ClientSize = New System.Drawing.Size(712, 156)
          Me.ControlBox = False
          Me.Controls.Add(Me.Button1)
          Me.Controls.Add(Me.Panel1)
          Me.Controls.Add(Me.PictureBox1)
          Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
          Me.Name = "Form1"
          Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
          Me.Text = "Form1"
          Me.Panel1.ResumeLayout(False)
          Me.Panel1.PerformLayout()
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
     Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
     Friend WithEvents Panel1 As System.Windows.Forms.Panel
     Friend WithEvents btnSingleFuels As System.Windows.Forms.Button
     Friend WithEvents Label2 As System.Windows.Forms.Label
     Friend WithEvents btnMultipleFuels As System.Windows.Forms.Button
     Friend WithEvents Label1 As System.Windows.Forms.Label
     Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
