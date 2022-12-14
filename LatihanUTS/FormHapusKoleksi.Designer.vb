<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHapusKoleksi
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
        Me.Lbl_Nama_Koleksi = New System.Windows.Forms.Label()
        Me.Lbl_ID_Koleksi = New System.Windows.Forms.Label()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Nama_Koleksi
        '
        Me.Lbl_Nama_Koleksi.AutoSize = True
        Me.Lbl_Nama_Koleksi.Location = New System.Drawing.Point(99, 46)
        Me.Lbl_Nama_Koleksi.Name = "Lbl_Nama_Koleksi"
        Me.Lbl_Nama_Koleksi.Size = New System.Drawing.Size(119, 25)
        Me.Lbl_Nama_Koleksi.TabIndex = 0
        Me.Lbl_Nama_Koleksi.Text = "Nama Koleksi"
        '
        'Lbl_ID_Koleksi
        '
        Me.Lbl_ID_Koleksi.AutoSize = True
        Me.Lbl_ID_Koleksi.Location = New System.Drawing.Point(116, 145)
        Me.Lbl_ID_Koleksi.Name = "Lbl_ID_Koleksi"
        Me.Lbl_ID_Koleksi.Size = New System.Drawing.Size(90, 25)
        Me.Lbl_ID_Koleksi.TabIndex = 1
        Me.Lbl_ID_Koleksi.Text = "ID Koleksi"
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(70, 237)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(112, 34)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'FormHapusKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.Lbl_ID_Koleksi)
        Me.Controls.Add(Me.Lbl_Nama_Koleksi)
        Me.Name = "FormHapusKoleksi"
        Me.Text = "FormHapusKoleksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Nama_Koleksi As Label
    Friend WithEvents Lbl_ID_Koleksi As Label
    Friend WithEvents BtnDelete As Button
End Class
