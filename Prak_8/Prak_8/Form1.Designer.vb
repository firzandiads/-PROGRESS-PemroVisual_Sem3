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
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbTgl = New System.Windows.Forms.ComboBox
        Me.CmbBln = New System.Windows.Forms.ComboBox
        Me.CmbThn = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tgl/Bln/Thn"
        '
        'CmbTgl
        '
        Me.CmbTgl.FormattingEnabled = True
        Me.CmbTgl.Location = New System.Drawing.Point(109, 54)
        Me.CmbTgl.Name = "CmbTgl"
        Me.CmbTgl.Size = New System.Drawing.Size(68, 21)
        Me.CmbTgl.TabIndex = 1
        '
        'CmbBln
        '
        Me.CmbBln.FormattingEnabled = True
        Me.CmbBln.Location = New System.Drawing.Point(183, 54)
        Me.CmbBln.Name = "CmbBln"
        Me.CmbBln.Size = New System.Drawing.Size(68, 21)
        Me.CmbBln.TabIndex = 2
        '
        'CmbThn
        '
        Me.CmbThn.FormattingEnabled = True
        Me.CmbThn.Location = New System.Drawing.Point(257, 54)
        Me.CmbThn.Name = "CmbThn"
        Me.CmbThn.Size = New System.Drawing.Size(68, 21)
        Me.CmbThn.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 132)
        Me.Controls.Add(Me.CmbThn)
        Me.Controls.Add(Me.CmbBln)
        Me.Controls.Add(Me.CmbTgl)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Perulangan FOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbTgl As System.Windows.Forms.ComboBox
    Friend WithEvents CmbBln As System.Windows.Forms.ComboBox
    Friend WithEvents CmbThn As System.Windows.Forms.ComboBox

End Class
