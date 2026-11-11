<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gauges
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtALT = New System.Windows.Forms.TextBox()
        Me.txtIAS = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGALT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHEAD = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFuel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBARO = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtFuelMax = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPlanLat = New System.Windows.Forms.TextBox()
        Me.txtPlaneLon = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(151, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ALT"
        '
        'txtALT
        '
        Me.txtALT.BackColor = System.Drawing.Color.Black
        Me.txtALT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtALT.ForeColor = System.Drawing.Color.Gold
        Me.txtALT.Location = New System.Drawing.Point(129, 51)
        Me.txtALT.Name = "txtALT"
        Me.txtALT.Size = New System.Drawing.Size(75, 20)
        Me.txtALT.TabIndex = 1
        Me.txtALT.Text = "0"
        Me.txtALT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIAS
        '
        Me.txtIAS.BackColor = System.Drawing.Color.Black
        Me.txtIAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIAS.ForeColor = System.Drawing.Color.Gold
        Me.txtIAS.Location = New System.Drawing.Point(221, 51)
        Me.txtIAS.Name = "txtIAS"
        Me.txtIAS.Size = New System.Drawing.Size(75, 20)
        Me.txtIAS.TabIndex = 3
        Me.txtIAS.Text = "0"
        Me.txtIAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(245, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "IAS"
        '
        'txtGALT
        '
        Me.txtGALT.BackColor = System.Drawing.Color.Black
        Me.txtGALT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGALT.ForeColor = System.Drawing.Color.Gold
        Me.txtGALT.Location = New System.Drawing.Point(315, 51)
        Me.txtGALT.Name = "txtGALT"
        Me.txtGALT.Size = New System.Drawing.Size(75, 20)
        Me.txtGALT.TabIndex = 5
        Me.txtGALT.Text = "0"
        Me.txtGALT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(333, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "GALT"
        '
        'txtHEAD
        '
        Me.txtHEAD.BackColor = System.Drawing.Color.Black
        Me.txtHEAD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHEAD.ForeColor = System.Drawing.Color.Gold
        Me.txtHEAD.Location = New System.Drawing.Point(396, 51)
        Me.txtHEAD.Name = "txtHEAD"
        Me.txtHEAD.Size = New System.Drawing.Size(75, 20)
        Me.txtHEAD.TabIndex = 7
        Me.txtHEAD.Text = "0"
        Me.txtHEAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(413, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "HEAD"
        '
        'txtFuel
        '
        Me.txtFuel.BackColor = System.Drawing.Color.Black
        Me.txtFuel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFuel.ForeColor = System.Drawing.Color.Gold
        Me.txtFuel.Location = New System.Drawing.Point(477, 51)
        Me.txtFuel.Name = "txtFuel"
        Me.txtFuel.Size = New System.Drawing.Size(75, 20)
        Me.txtFuel.TabIndex = 9
        Me.txtFuel.Text = "0"
        Me.txtFuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(495, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "FUEL"
        '
        'txtBARO
        '
        Me.txtBARO.BackColor = System.Drawing.Color.Black
        Me.txtBARO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBARO.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtBARO.Location = New System.Drawing.Point(639, 51)
        Me.txtBARO.Name = "txtBARO"
        Me.txtBARO.Size = New System.Drawing.Size(75, 20)
        Me.txtBARO.TabIndex = 11
        Me.txtBARO.Text = "0"
        Me.txtBARO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(656, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "BARO"
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.Maroon
        Me.btnExit.Location = New System.Drawing.Point(911, 10)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(22, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtFuelMax
        '
        Me.txtFuelMax.BackColor = System.Drawing.Color.Black
        Me.txtFuelMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFuelMax.ForeColor = System.Drawing.Color.Gold
        Me.txtFuelMax.Location = New System.Drawing.Point(558, 51)
        Me.txtFuelMax.Name = "txtFuelMax"
        Me.txtFuelMax.Size = New System.Drawing.Size(75, 20)
        Me.txtFuelMax.TabIndex = 13
        Me.txtFuelMax.Text = "0"
        Me.txtFuelMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(561, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "FUEL MAX"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(154, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "LAT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(286, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "LON"
        '
        'txtPlanLat
        '
        Me.txtPlanLat.BackColor = System.Drawing.Color.Black
        Me.txtPlanLat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlanLat.ForeColor = System.Drawing.Color.Gold
        Me.txtPlanLat.Location = New System.Drawing.Point(154, 135)
        Me.txtPlanLat.Name = "txtPlanLat"
        Me.txtPlanLat.Size = New System.Drawing.Size(75, 20)
        Me.txtPlanLat.TabIndex = 17
        Me.txtPlanLat.Text = "0"
        Me.txtPlanLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPlaneLon
        '
        Me.txtPlaneLon.BackColor = System.Drawing.Color.Black
        Me.txtPlaneLon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlaneLon.ForeColor = System.Drawing.Color.Gold
        Me.txtPlaneLon.Location = New System.Drawing.Point(289, 135)
        Me.txtPlaneLon.Name = "txtPlaneLon"
        Me.txtPlaneLon.Size = New System.Drawing.Size(75, 20)
        Me.txtPlaneLon.TabIndex = 18
        Me.txtPlaneLon.Text = "0"
        Me.txtPlaneLon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Gauges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(945, 167)
        Me.Controls.Add(Me.txtPlaneLon)
        Me.Controls.Add(Me.txtPlanLat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtFuelMax)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtBARO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFuel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtHEAD)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtGALT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIAS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtALT)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Gold
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Name = "Gauges"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Switches"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtALT As TextBox
    Friend WithEvents txtIAS As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGALT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHEAD As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFuel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBARO As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnExit As Button
    Friend WithEvents txtFuelMax As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPlanLat As TextBox
    Friend WithEvents txtPlaneLon As TextBox
End Class
