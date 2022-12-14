<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Perpustakaan
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
        Me.ListBoxKoleksi = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnPlus = New System.Windows.Forms.Button()
        Me.ButtonMin = New System.Windows.Forms.Button()
        Me.DataGridKoleksi = New System.Windows.Forms.DataGridView()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.BtnRMV = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBoxKoleksi
        '
        Me.ListBoxKoleksi.FormattingEnabled = True
        Me.ListBoxKoleksi.ItemHeight = 25
        Me.ListBoxKoleksi.Location = New System.Drawing.Point(41, 96)
        Me.ListBoxKoleksi.Name = "ListBoxKoleksi"
        Me.ListBoxKoleksi.Size = New System.Drawing.Size(311, 279)
        Me.ListBoxKoleksi.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1756, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksi})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(83, 29)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksi
        '
        Me.TambahKoleksi.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TambahKoleksi.Name = "TambahKoleksi"
        Me.TambahKoleksi.Size = New System.Drawing.Size(236, 34)
        Me.TambahKoleksi.Text = "Tambah Koleksi"
        '
        'BtnPlus
        '
        Me.BtnPlus.Location = New System.Drawing.Point(31, 56)
        Me.BtnPlus.Name = "BtnPlus"
        Me.BtnPlus.Size = New System.Drawing.Size(45, 34)
        Me.BtnPlus.TabIndex = 2
        Me.BtnPlus.Text = "+"
        Me.BtnPlus.UseVisualStyleBackColor = True
        '
        'ButtonMin
        '
        Me.ButtonMin.Location = New System.Drawing.Point(82, 56)
        Me.ButtonMin.Name = "ButtonMin"
        Me.ButtonMin.Size = New System.Drawing.Size(45, 34)
        Me.ButtonMin.TabIndex = 3
        Me.ButtonMin.Text = "-"
        Me.ButtonMin.UseVisualStyleBackColor = True
        '
        'DataGridKoleksi
        '
        Me.DataGridKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKoleksi.Location = New System.Drawing.Point(358, 96)
        Me.DataGridKoleksi.Name = "DataGridKoleksi"
        Me.DataGridKoleksi.RowHeadersWidth = 62
        Me.DataGridKoleksi.RowTemplate.Height = 33
        Me.DataGridKoleksi.Size = New System.Drawing.Size(1398, 785)
        Me.DataGridKoleksi.TabIndex = 4
        '
        'BtnSelect
        '
        Me.BtnSelect.Location = New System.Drawing.Point(1472, 916)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(112, 34)
        Me.BtnSelect.TabIndex = 5
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(1354, 916)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(112, 34)
        Me.BtnUpdate.TabIndex = 6
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(1590, 916)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(112, 34)
        Me.BtnRemove.TabIndex = 7
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnRMV
        '
        Me.BtnRMV.Location = New System.Drawing.Point(1635, 979)
        Me.BtnRMV.Name = "BtnRMV"
        Me.BtnRMV.Size = New System.Drawing.Size(112, 34)
        Me.BtnRMV.TabIndex = 8
        Me.BtnRMV.Text = "RMV"
        Me.BtnRMV.UseVisualStyleBackColor = True
        '
        'Form_Perpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1756, 1020)
        Me.Controls.Add(Me.BtnRMV)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.DataGridKoleksi)
        Me.Controls.Add(Me.ButtonMin)
        Me.Controls.Add(Me.BtnPlus)
        Me.Controls.Add(Me.ListBoxKoleksi)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form_Perpustakaan"
        Me.Text = "Form_Perpustakaan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxKoleksi As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKoleksi As ToolStripMenuItem
    Friend WithEvents BtnPlus As Button
    Friend WithEvents ButtonMin As Button
    Friend WithEvents DataGridKoleksi As DataGridView
    Friend WithEvents BtnSelect As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents BtnRMV As Button
End Class
