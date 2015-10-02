<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Me.ButtonGantiWarna = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonGantiWarna
        '
        Me.ButtonGantiWarna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonGantiWarna.Location = New System.Drawing.Point(82, 90)
        Me.ButtonGantiWarna.Name = "ButtonGantiWarna"
        Me.ButtonGantiWarna.Size = New System.Drawing.Size(108, 42)
        Me.ButtonGantiWarna.TabIndex = 0
        Me.ButtonGantiWarna.Text = "Ganti Warna"
        Me.ButtonGantiWarna.UseVisualStyleBackColor = True
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ButtonGantiWarna)
        Me.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Name = "Form"
        Me.Text = "Form Ganti Warna"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonGantiWarna As System.Windows.Forms.Button

End Class
