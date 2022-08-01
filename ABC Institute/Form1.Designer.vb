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
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtStID = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.rdioMale = New System.Windows.Forms.RadioButton()
        Me.rdioFemale = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkOL = New System.Windows.Forms.CheckBox()
        Me.chkAL = New System.Windows.Forms.CheckBox()
        Me.chkNVQ = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDob = New System.Windows.Forms.DateTimePicker()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdReset
        '
        Me.cmdReset.BackColor = System.Drawing.Color.Silver
        Me.cmdReset.FlatAppearance.BorderSize = 0
        Me.cmdReset.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReset.Location = New System.Drawing.Point(341, 414)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 23)
        Me.cmdReset.TabIndex = 15
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.Silver
        Me.cmdSave.FlatAppearance.BorderSize = 0
        Me.cmdSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Location = New System.Drawing.Point(85, 414)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 12
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'txtStID
        '
        Me.txtStID.Location = New System.Drawing.Point(151, 113)
        Me.txtStID.Name = "txtStID"
        Me.txtStID.Size = New System.Drawing.Size(265, 20)
        Me.txtStID.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(151, 76)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(265, 20)
        Me.txtSearch.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(31, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(31, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Student ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(31, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gold
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "   SLGTI Student Record   "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(31, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(31, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Address"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(151, 153)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(265, 20)
        Me.txtName.TabIndex = 3
        '
        'txtAdress
        '
        Me.txtAdress.Location = New System.Drawing.Point(151, 192)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(265, 20)
        Me.txtAdress.TabIndex = 4
        '
        'rdioMale
        '
        Me.rdioMale.AutoSize = True
        Me.rdioMale.ForeColor = System.Drawing.Color.White
        Me.rdioMale.Location = New System.Drawing.Point(151, 236)
        Me.rdioMale.Name = "rdioMale"
        Me.rdioMale.Size = New System.Drawing.Size(48, 17)
        Me.rdioMale.TabIndex = 5
        Me.rdioMale.TabStop = True
        Me.rdioMale.Text = "Male"
        Me.rdioMale.UseVisualStyleBackColor = True
        '
        'rdioFemale
        '
        Me.rdioFemale.AutoSize = True
        Me.rdioFemale.ForeColor = System.Drawing.Color.White
        Me.rdioFemale.Location = New System.Drawing.Point(228, 236)
        Me.rdioFemale.Name = "rdioFemale"
        Me.rdioFemale.Size = New System.Drawing.Size(59, 17)
        Me.rdioFemale.TabIndex = 6
        Me.rdioFemale.TabStop = True
        Me.rdioFemale.Text = "Female"
        Me.rdioFemale.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(31, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Qualification"
        '
        'chkOL
        '
        Me.chkOL.AutoSize = True
        Me.chkOL.ForeColor = System.Drawing.Color.White
        Me.chkOL.Location = New System.Drawing.Point(151, 272)
        Me.chkOL.Name = "chkOL"
        Me.chkOL.Size = New System.Drawing.Size(45, 17)
        Me.chkOL.TabIndex = 7
        Me.chkOL.Text = "O/L"
        Me.chkOL.UseVisualStyleBackColor = True
        '
        'chkAL
        '
        Me.chkAL.AutoSize = True
        Me.chkAL.ForeColor = System.Drawing.Color.White
        Me.chkAL.Location = New System.Drawing.Point(228, 272)
        Me.chkAL.Name = "chkAL"
        Me.chkAL.Size = New System.Drawing.Size(44, 17)
        Me.chkAL.TabIndex = 8
        Me.chkAL.Text = "A/L"
        Me.chkAL.UseVisualStyleBackColor = True
        '
        'chkNVQ
        '
        Me.chkNVQ.AutoSize = True
        Me.chkNVQ.ForeColor = System.Drawing.Color.White
        Me.chkNVQ.Location = New System.Drawing.Point(309, 272)
        Me.chkNVQ.Name = "chkNVQ"
        Me.chkNVQ.Size = New System.Drawing.Size(61, 17)
        Me.chkNVQ.TabIndex = 9
        Me.chkNVQ.Text = "NVQ- 4"
        Me.chkNVQ.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(31, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Course"
        '
        'cmbCourse
        '
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Items.AddRange(New Object() {"ICT", "Graphic", "Networking"})
        Me.cmbCourse.Location = New System.Drawing.Point(151, 310)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(265, 21)
        Me.cmbCourse.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(31, 358)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 19)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "DOB"
        '
        'txtDob
        '
        Me.txtDob.Location = New System.Drawing.Point(151, 357)
        Me.txtDob.Name = "txtDob"
        Me.txtDob.Size = New System.Drawing.Size(265, 20)
        Me.txtDob.TabIndex = 11
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.Color.Silver
        Me.cmdUpdate.FlatAppearance.BorderSize = 0
        Me.cmdUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUpdate.Location = New System.Drawing.Point(170, 414)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(75, 23)
        Me.cmdUpdate.TabIndex = 13
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.Silver
        Me.cmdDelete.FlatAppearance.BorderSize = 0
        Me.cmdDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Location = New System.Drawing.Point(256, 414)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 14
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(449, 483)
        Me.Controls.Add(Me.txtDob)
        Me.Controls.Add(Me.cmbCourse)
        Me.Controls.Add(Me.chkNVQ)
        Me.Controls.Add(Me.chkAL)
        Me.Controls.Add(Me.chkOL)
        Me.Controls.Add(Me.rdioFemale)
        Me.Controls.Add(Me.rdioMale)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtAdress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtStID)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SLGTI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtStID As System.Windows.Forms.TextBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAdress As System.Windows.Forms.TextBox
    Friend WithEvents rdioMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdioFemale As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkOL As System.Windows.Forms.CheckBox
    Friend WithEvents chkAL As System.Windows.Forms.CheckBox
    Friend WithEvents chkNVQ As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDob As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button

End Class
