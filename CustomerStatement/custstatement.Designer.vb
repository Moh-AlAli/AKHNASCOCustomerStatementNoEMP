<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class custstatement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(custstatement))
        Me.Rbwcw = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Rbwocw = New System.Windows.Forms.RadioButton()
        Me.CMD_OK = New System.Windows.Forms.Button()
        Me.CMD_Exit = New System.Windows.Forms.Button()
        Me.Gbpar = New System.Windows.Forms.GroupBox()
        Me.btfind = New System.Windows.Forms.Button()
        Me.Txttocus = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bffind = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfrmcus = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Rbsource = New System.Windows.Forms.RadioButton()
        Me.Rbfunc = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3.SuspendLayout()
        Me.Gbpar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Rbwcw
        '
        Me.Rbwcw.AutoSize = True
        Me.Rbwcw.Location = New System.Drawing.Point(9, 28)
        Me.Rbwcw.Name = "Rbwcw"
        Me.Rbwcw.Size = New System.Drawing.Size(72, 17)
        Me.Rbwcw.TabIndex = 0
        Me.Rbwcw.TabStop = True
        Me.Rbwcw.Text = "With CW"
        Me.Rbwcw.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Rbwocw)
        Me.GroupBox3.Controls.Add(Me.Rbwcw)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox3.Location = New System.Drawing.Point(5, 248)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(279, 62)
        Me.GroupBox3.TabIndex = 58
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CW"
        '
        'Rbwocw
        '
        Me.Rbwocw.AutoSize = True
        Me.Rbwocw.Location = New System.Drawing.Point(178, 29)
        Me.Rbwocw.Name = "Rbwocw"
        Me.Rbwocw.Size = New System.Drawing.Size(91, 17)
        Me.Rbwocw.TabIndex = 1
        Me.Rbwocw.TabStop = True
        Me.Rbwocw.Text = "Without CW"
        Me.Rbwocw.UseVisualStyleBackColor = True
        '
        'CMD_OK
        '
        Me.CMD_OK.BackColor = System.Drawing.SystemColors.Control
        Me.CMD_OK.Cursor = System.Windows.Forms.Cursors.Default
        Me.CMD_OK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CMD_OK.Location = New System.Drawing.Point(15, 330)
        Me.CMD_OK.Name = "CMD_OK"
        Me.CMD_OK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CMD_OK.Size = New System.Drawing.Size(81, 25)
        Me.CMD_OK.TabIndex = 56
        Me.CMD_OK.Text = "OK"
        Me.CMD_OK.UseVisualStyleBackColor = False
        '
        'CMD_Exit
        '
        Me.CMD_Exit.BackColor = System.Drawing.SystemColors.Control
        Me.CMD_Exit.Cursor = System.Windows.Forms.Cursors.Default
        Me.CMD_Exit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CMD_Exit.Location = New System.Drawing.Point(193, 329)
        Me.CMD_Exit.Name = "CMD_Exit"
        Me.CMD_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CMD_Exit.Size = New System.Drawing.Size(81, 25)
        Me.CMD_Exit.TabIndex = 57
        Me.CMD_Exit.Text = "Exit"
        Me.CMD_Exit.UseVisualStyleBackColor = False
        '
        'Gbpar
        '
        Me.Gbpar.Controls.Add(Me.btfind)
        Me.Gbpar.Controls.Add(Me.Txttocus)
        Me.Gbpar.Controls.Add(Me.Label2)
        Me.Gbpar.Controls.Add(Me.bffind)
        Me.Gbpar.Controls.Add(Me.Label1)
        Me.Gbpar.Controls.Add(Me.txtfrmcus)
        Me.Gbpar.Font = New System.Drawing.Font("Tahoma", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Gbpar.Location = New System.Drawing.Point(3, 0)
        Me.Gbpar.Name = "Gbpar"
        Me.Gbpar.Size = New System.Drawing.Size(280, 83)
        Me.Gbpar.TabIndex = 51
        Me.Gbpar.TabStop = False
        Me.Gbpar.Text = "Customer"
        '
        'btfind
        '
        Me.btfind.BackColor = System.Drawing.SystemColors.Control
        Me.btfind.Cursor = System.Windows.Forms.Cursors.Default
        Me.btfind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btfind.Image = CType(resources.GetObject("btfind.Image"), System.Drawing.Image)
        Me.btfind.Location = New System.Drawing.Point(247, 55)
        Me.btfind.Name = "btfind"
        Me.btfind.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btfind.Size = New System.Drawing.Size(17, 20)
        Me.btfind.TabIndex = 26
        Me.btfind.TabStop = False
        Me.btfind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btfind.UseVisualStyleBackColor = False
        '
        'Txttocus
        '
        Me.Txttocus.Location = New System.Drawing.Point(64, 56)
        Me.Txttocus.Name = "Txttocus"
        Me.Txttocus.Size = New System.Drawing.Size(188, 20)
        Me.Txttocus.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Unicode MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 15)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "To"
        '
        'bffind
        '
        Me.bffind.BackColor = System.Drawing.SystemColors.Control
        Me.bffind.Cursor = System.Windows.Forms.Cursors.Default
        Me.bffind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bffind.Image = CType(resources.GetObject("bffind.Image"), System.Drawing.Image)
        Me.bffind.Location = New System.Drawing.Point(248, 28)
        Me.bffind.Name = "bffind"
        Me.bffind.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bffind.Size = New System.Drawing.Size(17, 20)
        Me.bffind.TabIndex = 23
        Me.bffind.TabStop = False
        Me.bffind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bffind.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From"
        '
        'txtfrmcus
        '
        Me.txtfrmcus.Location = New System.Drawing.Point(64, 29)
        Me.txtfrmcus.Name = "txtfrmcus"
        Me.txtfrmcus.Size = New System.Drawing.Size(188, 20)
        Me.txtfrmcus.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 15)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "To"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 83)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(64, 57)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 62
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(63, 28)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Unicode MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(6, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "From"
        '
        'Rbsource
        '
        Me.Rbsource.AutoSize = True
        Me.Rbsource.Location = New System.Drawing.Point(178, 29)
        Me.Rbsource.Name = "Rbsource"
        Me.Rbsource.Size = New System.Drawing.Size(64, 17)
        Me.Rbsource.TabIndex = 1
        Me.Rbsource.TabStop = True
        Me.Rbsource.Text = "Source"
        Me.Rbsource.UseVisualStyleBackColor = True
        '
        'Rbfunc
        '
        Me.Rbfunc.AutoSize = True
        Me.Rbfunc.Location = New System.Drawing.Point(9, 28)
        Me.Rbfunc.Name = "Rbfunc"
        Me.Rbfunc.Size = New System.Drawing.Size(83, 17)
        Me.Rbfunc.TabIndex = 0
        Me.Rbfunc.TabStop = True
        Me.Rbfunc.Text = "Functional"
        Me.Rbfunc.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Rbsource)
        Me.GroupBox2.Controls.Add(Me.Rbfunc)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox2.Location = New System.Drawing.Point(5, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(279, 62)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Currency"
        '
        'custstatement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 360)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CMD_OK)
        Me.Controls.Add(Me.CMD_Exit)
        Me.Controls.Add(Me.Gbpar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "custstatement"
        Me.Text = "Customer Statement"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Gbpar.ResumeLayout(False)
        Me.Gbpar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Rbwcw As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Rbwocw As System.Windows.Forms.RadioButton
    Public WithEvents CMD_OK As System.Windows.Forms.Button
    Public WithEvents CMD_Exit As System.Windows.Forms.Button
    Friend WithEvents Gbpar As System.Windows.Forms.GroupBox
    Public WithEvents btfind As System.Windows.Forms.Button
    Friend WithEvents Txttocus As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents bffind As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfrmcus As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Rbsource As System.Windows.Forms.RadioButton
    Friend WithEvents Rbfunc As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker

End Class
