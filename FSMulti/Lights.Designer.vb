<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Switches
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
        Me.gbLights = New System.Windows.Forms.GroupBox()
        Me.gbEngines = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'gbLights
        '
        Me.gbLights.BackColor = System.Drawing.Color.Black
        Me.gbLights.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbLights.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.gbLights.Location = New System.Drawing.Point(63, 59)
        Me.gbLights.Name = "gbLights"
        Me.gbLights.Size = New System.Drawing.Size(407, 112)
        Me.gbLights.TabIndex = 0
        Me.gbLights.TabStop = False
        Me.gbLights.Text = "Lights"
        Me.gbLights.UseCompatibleTextRendering = True
        '
        'gbEngines
        '
        Me.gbEngines.BackColor = System.Drawing.Color.Black
        Me.gbEngines.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.gbEngines.Location = New System.Drawing.Point(575, 59)
        Me.gbEngines.Name = "gbEngines"
        Me.gbEngines.Size = New System.Drawing.Size(363, 118)
        Me.gbEngines.TabIndex = 1
        Me.gbEngines.TabStop = False
        Me.gbEngines.Text = "Engines"
        '
        'GroupBox1
        '
        Me.GroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Location = New System.Drawing.Point(63, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 167)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Avionics"
        '
        'GroupBox2
        '
        Me.GroupBox2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Location = New System.Drawing.Point(575, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(363, 158)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Power"
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.Maroon
        Me.btnExit.Location = New System.Drawing.Point(1076, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(22, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Switches
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1110, 413)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbEngines)
        Me.Controls.Add(Me.gbLights)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Switches"
        Me.Text = "Switches"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbLights As GroupBox
    Friend WithEvents gbEngines As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnExit As Button
End Class
