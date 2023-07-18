<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlCREW
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSelectedID = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDeleteCM = New FontAwesome.Sharp.IconButton()
        Me.btnUpdateCM = New FontAwesome.Sharp.IconButton()
        Me.btnSaveCM = New FontAwesome.Sharp.IconButton()
        Me.cbPosition = New System.Windows.Forms.ComboBox()
        Me.cbGroup = New System.Windows.Forms.ComboBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvCrew = New System.Windows.Forms.DataGridView()
        Me.AID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvCrew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.lblSelectedID)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnDeleteCM)
        Me.Panel1.Controls.Add(Me.btnUpdateCM)
        Me.Panel1.Controls.Add(Me.btnSaveCM)
        Me.Panel1.Controls.Add(Me.cbPosition)
        Me.Panel1.Controls.Add(Me.cbGroup)
        Me.Panel1.Controls.Add(Me.tbName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(478, 632)
        Me.Panel1.TabIndex = 0
        '
        'lblSelectedID
        '
        Me.lblSelectedID.AutoSize = True
        Me.lblSelectedID.BackColor = System.Drawing.Color.Transparent
        Me.lblSelectedID.ForeColor = System.Drawing.Color.IndianRed
        Me.lblSelectedID.Location = New System.Drawing.Point(385, 449)
        Me.lblSelectedID.Name = "lblSelectedID"
        Me.lblSelectedID.Size = New System.Drawing.Size(0, 15)
        Me.lblSelectedID.TabIndex = 24
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox1.Image = Global.CPCAviationDutyAssignManagement.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(387, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'btnDeleteCM
        '
        Me.btnDeleteCM.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnDeleteCM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteCM.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDeleteCM.FlatAppearance.BorderSize = 0
        Me.btnDeleteCM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnDeleteCM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeleteCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteCM.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDeleteCM.ForeColor = System.Drawing.Color.White
        Me.btnDeleteCM.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btnDeleteCM.IconColor = System.Drawing.Color.White
        Me.btnDeleteCM.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnDeleteCM.IconSize = 20
        Me.btnDeleteCM.Location = New System.Drawing.Point(289, 345)
        Me.btnDeleteCM.Name = "btnDeleteCM"
        Me.btnDeleteCM.Size = New System.Drawing.Size(150, 35)
        Me.btnDeleteCM.TabIndex = 22
        Me.btnDeleteCM.Text = "DELETE"
        Me.btnDeleteCM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteCM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteCM.UseVisualStyleBackColor = False
        '
        'btnUpdateCM
        '
        Me.btnUpdateCM.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnUpdateCM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateCM.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUpdateCM.FlatAppearance.BorderSize = 0
        Me.btnUpdateCM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnUpdateCM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnUpdateCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateCM.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdateCM.ForeColor = System.Drawing.Color.White
        Me.btnUpdateCM.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        Me.btnUpdateCM.IconColor = System.Drawing.Color.White
        Me.btnUpdateCM.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnUpdateCM.IconSize = 20
        Me.btnUpdateCM.Location = New System.Drawing.Point(289, 301)
        Me.btnUpdateCM.Name = "btnUpdateCM"
        Me.btnUpdateCM.Size = New System.Drawing.Size(150, 35)
        Me.btnUpdateCM.TabIndex = 21
        Me.btnUpdateCM.Text = "UPDATE"
        Me.btnUpdateCM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdateCM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdateCM.UseVisualStyleBackColor = False
        '
        'btnSaveCM
        '
        Me.btnSaveCM.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnSaveCM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveCM.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSaveCM.FlatAppearance.BorderSize = 0
        Me.btnSaveCM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnSaveCM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnSaveCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveCM.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSaveCM.ForeColor = System.Drawing.Color.White
        Me.btnSaveCM.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.btnSaveCM.IconColor = System.Drawing.Color.White
        Me.btnSaveCM.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnSaveCM.IconSize = 20
        Me.btnSaveCM.Location = New System.Drawing.Point(289, 257)
        Me.btnSaveCM.Name = "btnSaveCM"
        Me.btnSaveCM.Size = New System.Drawing.Size(150, 35)
        Me.btnSaveCM.TabIndex = 20
        Me.btnSaveCM.Text = "SAVE"
        Me.btnSaveCM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveCM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveCM.UseVisualStyleBackColor = False
        '
        'cbPosition
        '
        Me.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPosition.FormattingEnabled = True
        Me.cbPosition.Location = New System.Drawing.Point(235, 179)
        Me.cbPosition.Name = "cbPosition"
        Me.cbPosition.Size = New System.Drawing.Size(204, 23)
        Me.cbPosition.TabIndex = 9
        '
        'cbGroup
        '
        Me.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGroup.FormattingEnabled = True
        Me.cbGroup.Location = New System.Drawing.Point(235, 131)
        Me.cbGroup.Name = "cbGroup"
        Me.cbGroup.Size = New System.Drawing.Size(204, 23)
        Me.cbGroup.TabIndex = 8
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(235, 83)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(204, 23)
        Me.tbName.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(99, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "POSITION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "GROUP"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(99, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(68, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CREWMEN DETAILS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.dgvCrew)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(478, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(578, 632)
        Me.Panel2.TabIndex = 1
        '
        'dgvCrew
        '
        Me.dgvCrew.AllowUserToAddRows = False
        Me.dgvCrew.AllowUserToDeleteRows = False
        Me.dgvCrew.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvCrew.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCrew.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCrew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCrew.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AID, Me.AName, Me.AGroup, Me.APosition})
        Me.dgvCrew.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCrew.Location = New System.Drawing.Point(10, 10)
        Me.dgvCrew.Name = "dgvCrew"
        Me.dgvCrew.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCrew.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCrew.RowHeadersWidth = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvCrew.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCrew.RowTemplate.Height = 25
        Me.dgvCrew.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCrew.Size = New System.Drawing.Size(558, 612)
        Me.dgvCrew.TabIndex = 0
        '
        'AID
        '
        Me.AID.HeaderText = "ID"
        Me.AID.Name = "AID"
        Me.AID.ReadOnly = True
        Me.AID.Width = 180
        '
        'AName
        '
        Me.AName.HeaderText = "NAME"
        Me.AName.Name = "AName"
        Me.AName.ReadOnly = True
        Me.AName.Width = 200
        '
        'AGroup
        '
        Me.AGroup.HeaderText = "GROUP"
        Me.AGroup.Name = "AGroup"
        Me.AGroup.ReadOnly = True
        Me.AGroup.Width = 200
        '
        'APosition
        '
        Me.APosition.HeaderText = "POSITION"
        Me.APosition.Name = "APosition"
        Me.APosition.ReadOnly = True
        Me.APosition.Width = 200
        '
        'UserControlCREW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserControlCREW"
        Me.Size = New System.Drawing.Size(1056, 632)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvCrew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents cbPosition As ComboBox
    Friend WithEvents cbGroup As ComboBox
    Friend WithEvents btnDeleteCM As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUpdateCM As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveCM As FontAwesome.Sharp.IconButton
    Friend WithEvents dgvCrew As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblSelectedID As Label
    Friend WithEvents AID As DataGridViewTextBoxColumn
    Friend WithEvents AName As DataGridViewTextBoxColumn
    Friend WithEvents AGroup As DataGridViewTextBoxColumn
    Friend WithEvents APosition As DataGridViewTextBoxColumn
End Class
