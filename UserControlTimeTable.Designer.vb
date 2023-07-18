<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlTimeTable
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.cbGroup = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cbAddMoreRIC = New System.Windows.Forms.ComboBox()
        Me.btnAddRICToTable = New FontAwesome.Sharp.IconButton()
        Me.btnAddAgainRIC = New FontAwesome.Sharp.IconButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbRemovedRIC = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnRICRemove = New FontAwesome.Sharp.IconButton()
        Me.lbRIC = New System.Windows.Forms.ListBox()
        Me.pnlRIC = New System.Windows.Forms.Panel()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlCM = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ADDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbAddMoreCM = New System.Windows.Forms.ComboBox()
        Me.btnAddCMToTable = New FontAwesome.Sharp.IconButton()
        Me.btnAddAgainCM = New FontAwesome.Sharp.IconButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbRemovedCM = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCMRemove = New FontAwesome.Sharp.IconButton()
        Me.lbCM = New System.Windows.Forms.ListBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New FontAwesome.Sharp.IconButton()
        Me.btnPlaneAdd = New FontAwesome.Sharp.IconButton()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.cbShiftTime = New System.Windows.Forms.ComboBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lines = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.tbRoute = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblETAShow = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblSelectedFlight = New System.Windows.Forms.Label()
        Me.cbOPerater = New System.Windows.Forms.ComboBox()
        Me.btnUpdateData = New FontAwesome.Sharp.IconButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboxremarks = New System.Windows.Forms.ComboBox()
        Me.tbBayNo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnResizePnl = New FontAwesome.Sharp.IconButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbltoday = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btnPrint = New FontAwesome.Sharp.IconButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.pnlRIC.SuspendLayout()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCM.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(50, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "DAILY WORK SCHEDULE"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.pnlCM)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 752)
        Me.Panel1.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel7.Controls.Add(Me.cbGroup)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Location = New System.Drawing.Point(55, 240)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(255, 48)
        Me.Panel7.TabIndex = 7
        '
        'cbGroup
        '
        Me.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGroup.FormattingEnabled = True
        Me.cbGroup.Location = New System.Drawing.Point(106, 14)
        Me.cbGroup.Name = "cbGroup"
        Me.cbGroup.Size = New System.Drawing.Size(121, 23)
        Me.cbGroup.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 48)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "GROUP"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel6.Controls.Add(Me.cbAddMoreRIC)
        Me.Panel6.Controls.Add(Me.btnAddRICToTable)
        Me.Panel6.Controls.Add(Me.btnAddAgainRIC)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.lbRemovedRIC)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.btnRICRemove)
        Me.Panel6.Controls.Add(Me.lbRIC)
        Me.Panel6.Controls.Add(Me.pnlRIC)
        Me.Panel6.Location = New System.Drawing.Point(56, 515)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(255, 217)
        Me.Panel6.TabIndex = 7
        '
        'cbAddMoreRIC
        '
        Me.cbAddMoreRIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAddMoreRIC.FormattingEnabled = True
        Me.cbAddMoreRIC.Location = New System.Drawing.Point(14, 177)
        Me.cbAddMoreRIC.Name = "cbAddMoreRIC"
        Me.cbAddMoreRIC.Size = New System.Drawing.Size(87, 23)
        Me.cbAddMoreRIC.TabIndex = 16
        '
        'btnAddRICToTable
        '
        Me.btnAddRICToTable.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnAddRICToTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddRICToTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddRICToTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddRICToTable.FlatAppearance.BorderSize = 0
        Me.btnAddRICToTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnAddRICToTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddRICToTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRICToTable.IconChar = FontAwesome.Sharp.IconChar.UserLock
        Me.btnAddRICToTable.IconColor = System.Drawing.Color.White
        Me.btnAddRICToTable.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddRICToTable.IconSize = 25
        Me.btnAddRICToTable.Location = New System.Drawing.Point(127, 177)
        Me.btnAddRICToTable.Name = "btnAddRICToTable"
        Me.btnAddRICToTable.Size = New System.Drawing.Size(111, 29)
        Me.btnAddRICToTable.TabIndex = 21
        Me.btnAddRICToTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddRICToTable.UseVisualStyleBackColor = False
        '
        'btnAddAgainRIC
        '
        Me.btnAddAgainRIC.BackColor = System.Drawing.Color.White
        Me.btnAddAgainRIC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddAgainRIC.FlatAppearance.BorderSize = 0
        Me.btnAddAgainRIC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnAddAgainRIC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddAgainRIC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAgainRIC.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.btnAddAgainRIC.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnAddAgainRIC.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddAgainRIC.IconSize = 25
        Me.btnAddAgainRIC.Location = New System.Drawing.Point(106, 108)
        Me.btnAddAgainRIC.Name = "btnAddAgainRIC"
        Me.btnAddAgainRIC.Size = New System.Drawing.Size(40, 40)
        Me.btnAddAgainRIC.TabIndex = 20
        Me.btnAddAgainRIC.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(152, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 15)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "OUT"
        '
        'lbRemovedRIC
        '
        Me.lbRemovedRIC.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbRemovedRIC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbRemovedRIC.FormattingEnabled = True
        Me.lbRemovedRIC.ItemHeight = 15
        Me.lbRemovedRIC.Location = New System.Drawing.Point(151, 45)
        Me.lbRemovedRIC.Name = "lbRemovedRIC"
        Me.lbRemovedRIC.Size = New System.Drawing.Size(87, 124)
        Me.lbRemovedRIC.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(14, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 15)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "IN"
        '
        'btnRICRemove
        '
        Me.btnRICRemove.BackColor = System.Drawing.Color.White
        Me.btnRICRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRICRemove.FlatAppearance.BorderSize = 0
        Me.btnRICRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnRICRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRICRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRICRemove.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        Me.btnRICRemove.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnRICRemove.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRICRemove.IconSize = 25
        Me.btnRICRemove.Location = New System.Drawing.Point(106, 62)
        Me.btnRICRemove.Name = "btnRICRemove"
        Me.btnRICRemove.Size = New System.Drawing.Size(40, 40)
        Me.btnRICRemove.TabIndex = 16
        Me.btnRICRemove.UseVisualStyleBackColor = False
        '
        'lbRIC
        '
        Me.lbRIC.AllowDrop = True
        Me.lbRIC.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbRIC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbRIC.FormattingEnabled = True
        Me.lbRIC.ItemHeight = 15
        Me.lbRIC.Location = New System.Drawing.Point(14, 45)
        Me.lbRIC.Name = "lbRIC"
        Me.lbRIC.Size = New System.Drawing.Size(87, 124)
        Me.lbRIC.TabIndex = 15
        '
        'pnlRIC
        '
        Me.pnlRIC.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.pnlRIC.Controls.Add(Me.IconPictureBox3)
        Me.pnlRIC.Controls.Add(Me.Label9)
        Me.pnlRIC.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRIC.Location = New System.Drawing.Point(0, 0)
        Me.pnlRIC.Name = "pnlRIC"
        Me.pnlRIC.Size = New System.Drawing.Size(255, 23)
        Me.pnlRIC.TabIndex = 2
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.IconPictureBox3.IconColor = System.Drawing.Color.White
        Me.IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox3.IconSize = 21
        Me.IconPictureBox3.Location = New System.Drawing.Point(229, 3)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(21, 26)
        Me.IconPictureBox3.TabIndex = 9
        Me.IconPictureBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(6, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "RIC"
        '
        'pnlCM
        '
        Me.pnlCM.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlCM.ContextMenuStrip = Me.ContextMenuStrip2
        Me.pnlCM.Controls.Add(Me.cbAddMoreCM)
        Me.pnlCM.Controls.Add(Me.btnAddCMToTable)
        Me.pnlCM.Controls.Add(Me.btnAddAgainCM)
        Me.pnlCM.Controls.Add(Me.Label11)
        Me.pnlCM.Controls.Add(Me.lbRemovedCM)
        Me.pnlCM.Controls.Add(Me.Label10)
        Me.pnlCM.Controls.Add(Me.btnCMRemove)
        Me.pnlCM.Controls.Add(Me.lbCM)
        Me.pnlCM.Controls.Add(Me.Panel8)
        Me.pnlCM.Location = New System.Drawing.Point(55, 293)
        Me.pnlCM.Name = "pnlCM"
        Me.pnlCM.Size = New System.Drawing.Size(255, 217)
        Me.pnlCM.TabIndex = 6
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(99, 26)
        '
        'ADDToolStripMenuItem
        '
        Me.ADDToolStripMenuItem.Name = "ADDToolStripMenuItem"
        Me.ADDToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.ADDToolStripMenuItem.Text = "ADD"
        '
        'cbAddMoreCM
        '
        Me.cbAddMoreCM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAddMoreCM.FormattingEnabled = True
        Me.cbAddMoreCM.Location = New System.Drawing.Point(15, 177)
        Me.cbAddMoreCM.Name = "cbAddMoreCM"
        Me.cbAddMoreCM.Size = New System.Drawing.Size(87, 23)
        Me.cbAddMoreCM.TabIndex = 15
        '
        'btnAddCMToTable
        '
        Me.btnAddCMToTable.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnAddCMToTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddCMToTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCMToTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddCMToTable.FlatAppearance.BorderSize = 0
        Me.btnAddCMToTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnAddCMToTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddCMToTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCMToTable.IconChar = FontAwesome.Sharp.IconChar.UserLock
        Me.btnAddCMToTable.IconColor = System.Drawing.Color.White
        Me.btnAddCMToTable.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddCMToTable.IconSize = 25
        Me.btnAddCMToTable.Location = New System.Drawing.Point(128, 177)
        Me.btnAddCMToTable.Name = "btnAddCMToTable"
        Me.btnAddCMToTable.Size = New System.Drawing.Size(111, 29)
        Me.btnAddCMToTable.TabIndex = 14
        Me.btnAddCMToTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddCMToTable.UseVisualStyleBackColor = False
        '
        'btnAddAgainCM
        '
        Me.btnAddAgainCM.BackColor = System.Drawing.Color.White
        Me.btnAddAgainCM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddAgainCM.FlatAppearance.BorderSize = 0
        Me.btnAddAgainCM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnAddAgainCM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAddAgainCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAgainCM.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.btnAddAgainCM.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnAddAgainCM.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddAgainCM.IconSize = 25
        Me.btnAddAgainCM.Location = New System.Drawing.Point(106, 108)
        Me.btnAddAgainCM.Name = "btnAddAgainCM"
        Me.btnAddAgainCM.Size = New System.Drawing.Size(40, 40)
        Me.btnAddAgainCM.TabIndex = 9
        Me.btnAddAgainCM.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(152, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 15)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "OUT"
        '
        'lbRemovedCM
        '
        Me.lbRemovedCM.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbRemovedCM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbRemovedCM.FormattingEnabled = True
        Me.lbRemovedCM.ItemHeight = 15
        Me.lbRemovedCM.Location = New System.Drawing.Point(152, 45)
        Me.lbRemovedCM.Name = "lbRemovedCM"
        Me.lbRemovedCM.Size = New System.Drawing.Size(87, 124)
        Me.lbRemovedCM.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(15, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 15)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "IN"
        '
        'btnCMRemove
        '
        Me.btnCMRemove.BackColor = System.Drawing.Color.White
        Me.btnCMRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCMRemove.FlatAppearance.BorderSize = 0
        Me.btnCMRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnCMRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCMRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCMRemove.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        Me.btnCMRemove.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnCMRemove.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCMRemove.IconSize = 25
        Me.btnCMRemove.Location = New System.Drawing.Point(106, 62)
        Me.btnCMRemove.Name = "btnCMRemove"
        Me.btnCMRemove.Size = New System.Drawing.Size(40, 40)
        Me.btnCMRemove.TabIndex = 3
        Me.btnCMRemove.UseVisualStyleBackColor = False
        '
        'lbCM
        '
        Me.lbCM.AllowDrop = True
        Me.lbCM.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbCM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbCM.FormattingEnabled = True
        Me.lbCM.ItemHeight = 15
        Me.lbCM.Location = New System.Drawing.Point(15, 45)
        Me.lbCM.Name = "lbCM"
        Me.lbCM.Size = New System.Drawing.Size(87, 124)
        Me.lbCM.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Panel8.Controls.Add(Me.IconPictureBox2)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(255, 23)
        Me.Panel8.TabIndex = 1
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.IconPictureBox2.IconColor = System.Drawing.Color.White
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 21
        Me.IconPictureBox2.Location = New System.Drawing.Point(230, 3)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(21, 26)
        Me.IconPictureBox2.TabIndex = 9
        Me.IconPictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(5, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "CREWMAN"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.btnRefresh)
        Me.Panel3.Controls.Add(Me.btnPlaneAdd)
        Me.Panel3.Controls.Add(Me.lblShift)
        Me.Panel3.Controls.Add(Me.lblDay)
        Me.Panel3.Controls.Add(Me.cbShiftTime)
        Me.Panel3.Controls.Add(Me.dtpDate)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(55, 47)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(255, 187)
        Me.Panel3.TabIndex = 5
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Retweet
        Me.btnRefresh.IconColor = System.Drawing.Color.White
        Me.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRefresh.IconSize = 20
        Me.btnRefresh.Location = New System.Drawing.Point(201, 144)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(29, 29)
        Me.btnRefresh.TabIndex = 14
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnPlaneAdd
        '
        Me.btnPlaneAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnPlaneAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPlaneAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlaneAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPlaneAdd.FlatAppearance.BorderSize = 0
        Me.btnPlaneAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnPlaneAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPlaneAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlaneAdd.IconChar = FontAwesome.Sharp.IconChar.PlaneLock
        Me.btnPlaneAdd.IconColor = System.Drawing.Color.White
        Me.btnPlaneAdd.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPlaneAdd.IconSize = 25
        Me.btnPlaneAdd.Location = New System.Drawing.Point(90, 144)
        Me.btnPlaneAdd.Name = "btnPlaneAdd"
        Me.btnPlaneAdd.Size = New System.Drawing.Size(107, 29)
        Me.btnPlaneAdd.TabIndex = 13
        Me.btnPlaneAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPlaneAdd.UseVisualStyleBackColor = False
        '
        'lblShift
        '
        Me.lblShift.BackColor = System.Drawing.Color.White
        Me.lblShift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblShift.Location = New System.Drawing.Point(90, 114)
        Me.lblShift.Name = "lblShift"
        Me.lblShift.Size = New System.Drawing.Size(140, 23)
        Me.lblShift.TabIndex = 12
        '
        'lblDay
        '
        Me.lblDay.BackColor = System.Drawing.SystemColors.Window
        Me.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDay.Location = New System.Drawing.Point(90, 87)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(140, 21)
        Me.lblDay.TabIndex = 11
        '
        'cbShiftTime
        '
        Me.cbShiftTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbShiftTime.FormattingEnabled = True
        Me.cbShiftTime.Location = New System.Drawing.Point(90, 58)
        Me.cbShiftTime.Name = "cbShiftTime"
        Me.cbShiftTime.Size = New System.Drawing.Size(140, 23)
        Me.cbShiftTime.TabIndex = 10
        '
        'dtpDate
        '
        Me.dtpDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(91, 28)
        Me.dtpDate.MaxDate = New Date(2123, 3, 17, 0, 0, 0, 0)
        Me.dtpDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(139, 23)
        Me.dtpDate.TabIndex = 9
        Me.dtpDate.Value = New Date(2023, 3, 17, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(12, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "SHIFT "
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Panel4.Controls.Add(Me.IconPictureBox1)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(255, 23)
        Me.Panel4.TabIndex = 0
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 21
        Me.IconPictureBox1.Location = New System.Drawing.Point(230, 1)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(21, 26)
        Me.IconPictureBox1.TabIndex = 9
        Me.IconPictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(5, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "SHIFT TIME"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "SHIFT TIME"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "DAY"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "DATE"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Panel11)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(320, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(713, 752)
        Me.Panel2.TabIndex = 6
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel11.Controls.Add(Me.Panel9)
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(0, 56)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(713, 696)
        Me.Panel11.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel9.Controls.Add(Me.dgvMain)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.ForeColor = System.Drawing.Color.Black
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel9.Size = New System.Drawing.Size(463, 696)
        Me.Panel9.TabIndex = 2
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.noo, Me.fli, Me.Column10, Me.Column4, Me.lines, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column3, Me.Column5})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMain.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(5, 5)
        Me.dgvMain.Name = "dgvMain"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMain.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMain.RowHeadersWidth = 4
        Me.dgvMain.RowTemplate.Height = 25
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(453, 686)
        Me.dgvMain.TabIndex = 0
        '
        'Column2
        '
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column2.Width = 20
        '
        'Column1
        '
        Me.Column1.HeaderText = "BAY NO"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'noo
        '
        Me.noo.HeaderText = "NO"
        Me.noo.Name = "noo"
        Me.noo.ReadOnly = True
        Me.noo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.noo.Width = 40
        '
        'fli
        '
        Me.fli.HeaderText = "FLIGHT"
        Me.fli.Name = "fli"
        Me.fli.ReadOnly = True
        Me.fli.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column10
        '
        Me.Column10.HeaderText = "ROUTE"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column10.Width = 70
        '
        'Column4
        '
        Me.Column4.HeaderText = "E.T.A"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'lines
        '
        Me.lines.HeaderText = "AIRLINE"
        Me.lines.Name = "lines"
        Me.lines.ReadOnly = True
        Me.lines.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column6
        '
        Me.Column6.HeaderText = "RIC"
        Me.Column6.Name = "Column6"
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.Width = 70
        '
        'Column7
        '
        Me.Column7.HeaderText = "OPERATOR"
        Me.Column7.Name = "Column7"
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.Width = 70
        '
        'Column8
        '
        Me.Column8.HeaderText = "CREWMAN"
        Me.Column8.Name = "Column8"
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column8.Width = 70
        '
        'Column9
        '
        Me.Column9.HeaderText = "REMARKS"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column9.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cancel"
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.Width = 50
        '
        'Column5
        '
        Me.Column5.HeaderText = "DATE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel12.Controls.Add(Me.tbRoute)
        Me.Panel12.Controls.Add(Me.Label18)
        Me.Panel12.Controls.Add(Me.lblETAShow)
        Me.Panel12.Controls.Add(Me.Label16)
        Me.Panel12.Controls.Add(Me.Label17)
        Me.Panel12.Controls.Add(Me.lblSelectedFlight)
        Me.Panel12.Controls.Add(Me.cbOPerater)
        Me.Panel12.Controls.Add(Me.btnUpdateData)
        Me.Panel12.Controls.Add(Me.Label19)
        Me.Panel12.Controls.Add(Me.cboxremarks)
        Me.Panel12.Controls.Add(Me.tbBayNo)
        Me.Panel12.Controls.Add(Me.Label15)
        Me.Panel12.Controls.Add(Me.Label14)
        Me.Panel12.Controls.Add(Me.btnResizePnl)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel12.ForeColor = System.Drawing.Color.Black
        Me.Panel12.Location = New System.Drawing.Point(463, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel12.Size = New System.Drawing.Size(250, 696)
        Me.Panel12.TabIndex = 2
        '
        'tbRoute
        '
        Me.tbRoute.Location = New System.Drawing.Point(43, 196)
        Me.tbRoute.Name = "tbRoute"
        Me.tbRoute.Size = New System.Drawing.Size(165, 23)
        Me.tbRoute.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label18.Location = New System.Drawing.Point(41, 173)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 15)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "ROUTE"
        '
        'lblETAShow
        '
        Me.lblETAShow.AutoSize = True
        Me.lblETAShow.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblETAShow.Location = New System.Drawing.Point(120, 85)
        Me.lblETAShow.Name = "lblETAShow"
        Me.lblETAShow.Size = New System.Drawing.Size(33, 15)
        Me.lblETAShow.TabIndex = 35
        Me.lblETAShow.Text = "E.T.A"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(92, 85)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 15)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "AT :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label17.Location = New System.Drawing.Point(40, 62)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 15)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "FLIGHT"
        '
        'lblSelectedFlight
        '
        Me.lblSelectedFlight.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSelectedFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSelectedFlight.Location = New System.Drawing.Point(94, 58)
        Me.lblSelectedFlight.Name = "lblSelectedFlight"
        Me.lblSelectedFlight.Size = New System.Drawing.Size(113, 23)
        Me.lblSelectedFlight.TabIndex = 30
        Me.lblSelectedFlight.Text = "Selected Flight"
        Me.lblSelectedFlight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbOPerater
        '
        Me.cbOPerater.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOPerater.FormattingEnabled = True
        Me.cbOPerater.Location = New System.Drawing.Point(42, 258)
        Me.cbOPerater.Name = "cbOPerater"
        Me.cbOPerater.Size = New System.Drawing.Size(166, 23)
        Me.cbOPerater.TabIndex = 29
        '
        'btnUpdateData
        '
        Me.btnUpdateData.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnUpdateData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUpdateData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdateData.FlatAppearance.BorderSize = 0
        Me.btnUpdateData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnUpdateData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateData.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        Me.btnUpdateData.IconColor = System.Drawing.Color.White
        Me.btnUpdateData.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUpdateData.IconSize = 25
        Me.btnUpdateData.Location = New System.Drawing.Point(43, 361)
        Me.btnUpdateData.Name = "btnUpdateData"
        Me.btnUpdateData.Size = New System.Drawing.Size(166, 29)
        Me.btnUpdateData.TabIndex = 14
        Me.btnUpdateData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdateData.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label19.Location = New System.Drawing.Point(40, 296)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 15)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "REMARKS"
        '
        'cboxremarks
        '
        Me.cboxremarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxremarks.FormattingEnabled = True
        Me.cboxremarks.Location = New System.Drawing.Point(43, 319)
        Me.cboxremarks.Name = "cboxremarks"
        Me.cboxremarks.Size = New System.Drawing.Size(166, 23)
        Me.cboxremarks.TabIndex = 11
        '
        'tbBayNo
        '
        Me.tbBayNo.Location = New System.Drawing.Point(43, 135)
        Me.tbBayNo.Name = "tbBayNo"
        Me.tbBayNo.Size = New System.Drawing.Size(165, 23)
        Me.tbBayNo.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(40, 235)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 15)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "OPERATOR"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(41, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 15)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "BAY NO"
        '
        'btnResizePnl
        '
        Me.btnResizePnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnResizePnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnResizePnl.FlatAppearance.BorderSize = 0
        Me.btnResizePnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResizePnl.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnResizePnl.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnResizePnl.IconChar = FontAwesome.Sharp.IconChar.AngleRight
        Me.btnResizePnl.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnResizePnl.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnResizePnl.IconSize = 20
        Me.btnResizePnl.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnResizePnl.Location = New System.Drawing.Point(3, 3)
        Me.btnResizePnl.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResizePnl.MaximumSize = New System.Drawing.Size(244, 40)
        Me.btnResizePnl.Name = "btnResizePnl"
        Me.btnResizePnl.Size = New System.Drawing.Size(244, 40)
        Me.btnResizePnl.TabIndex = 0
        Me.btnResizePnl.Text = "     UPDATE TABLE ROWS"
        Me.btnResizePnl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResizePnl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnResizePnl.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel5.Controls.Add(Me.lbltoday)
        Me.Panel5.Controls.Add(Me.lblTime)
        Me.Panel5.Controls.Add(Me.Panel10)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.ForeColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel5.Size = New System.Drawing.Size(713, 56)
        Me.Panel5.TabIndex = 0
        '
        'lbltoday
        '
        Me.lbltoday.AutoSize = True
        Me.lbltoday.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbltoday.ForeColor = System.Drawing.Color.Black
        Me.lbltoday.Location = New System.Drawing.Point(24, 10)
        Me.lbltoday.Name = "lbltoday"
        Me.lbltoday.Size = New System.Drawing.Size(73, 15)
        Me.lbltoday.TabIndex = 6
        Me.lbltoday.Text = "22/03/2023"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTime.ForeColor = System.Drawing.Color.Black
        Me.lblTime.Location = New System.Drawing.Point(24, 31)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(35, 15)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "TIME"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.btnPrint)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(503, 10)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(200, 36)
        Me.Panel10.TabIndex = 4
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnPrint.IconColor = System.Drawing.Color.White
        Me.btnPrint.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPrint.IconSize = 25
        Me.btnPrint.Location = New System.Drawing.Point(61, 1)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(138, 34)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'UserControlTimeTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserControlTimeTable"
        Me.Size = New System.Drawing.Size(1033, 752)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.pnlRIC.ResumeLayout(False)
        Me.pnlRIC.PerformLayout()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCM.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cbShiftTime As ComboBox
    Friend WithEvents lblDay As Label
    Friend WithEvents lblShift As Label
    Friend WithEvents btnPlaneAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlCM As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cbGroup As ComboBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents pnlRIC As Panel
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lbCM As ListBox
    Friend WithEvents btnCMRemove As FontAwesome.Sharp.IconButton
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAddAgainCM As FontAwesome.Sharp.IconButton
    Friend WithEvents Label11 As Label
    Friend WithEvents lbRemovedCM As ListBox
    Friend WithEvents btnAddCMToTable As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddRICToTable As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddAgainRIC As FontAwesome.Sharp.IconButton
    Friend WithEvents Label12 As Label
    Friend WithEvents lbRemovedRIC As ListBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnRICRemove As FontAwesome.Sharp.IconButton
    Friend WithEvents lbRIC As ListBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnPrint As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTime As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents dgvMain As DataGridView
    Friend WithEvents Panel12 As Panel
    Friend WithEvents btnResizePnl As FontAwesome.Sharp.IconButton
    Friend WithEvents Label14 As Label
    Friend WithEvents tbBayNo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cboxremarks As ComboBox
    Friend WithEvents btnUpdateData As FontAwesome.Sharp.IconButton
    Friend WithEvents cbOPerater As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents lblSelectedFlight As Label
    Friend WithEvents lblETAShow As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lbltoday As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents tbRoute As TextBox
    Friend WithEvents btnRefresh As FontAwesome.Sharp.IconButton
    Friend WithEvents cbAddMoreCM As ComboBox
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents ADDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbAddMoreRIC As ComboBox
    Friend WithEvents Column2 As DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents noo As DataGridViewTextBoxColumn
    Friend WithEvents fli As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents lines As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewComboBoxColumn
    Friend WithEvents Column7 As DataGridViewComboBoxColumn
    Friend WithEvents Column8 As DataGridViewComboBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewCheckBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
