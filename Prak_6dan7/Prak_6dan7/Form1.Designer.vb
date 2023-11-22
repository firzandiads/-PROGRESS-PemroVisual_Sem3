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
        Me.Btn_if = New System.Windows.Forms.Button
        Me.Btn_if_else = New System.Windows.Forms.Button
        Me.Btn_case = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Btn_if
        '
        Me.Btn_if.Location = New System.Drawing.Point(58, 63)
        Me.Btn_if.Name = "Btn_if"
        Me.Btn_if.Size = New System.Drawing.Size(158, 27)
        Me.Btn_if.TabIndex = 0
        Me.Btn_if.Text = "IF.. ENDIF"
        Me.Btn_if.UseVisualStyleBackColor = True
        '
        'Btn_if_else
        '
        Me.Btn_if_else.Location = New System.Drawing.Point(58, 108)
        Me.Btn_if_else.Name = "Btn_if_else"
        Me.Btn_if_else.Size = New System.Drawing.Size(158, 27)
        Me.Btn_if_else.TabIndex = 1
        Me.Btn_if_else.Text = "IF.. ELSE.. ENDIF"
        Me.Btn_if_else.UseVisualStyleBackColor = True
        '
        'Btn_case
        '
        Me.Btn_case.Location = New System.Drawing.Point(58, 152)
        Me.Btn_case.Name = "Btn_case"
        Me.Btn_case.Size = New System.Drawing.Size(158, 27)
        Me.Btn_case.TabIndex = 2
        Me.Btn_case.Text = "CASE.. ENDCASE"
        Me.Btn_case.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Btn_case)
        Me.Controls.Add(Me.Btn_if_else)
        Me.Controls.Add(Me.Btn_if)
        Me.Name = "Form1"
        Me.Text = "Pencabangan IF"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_if As System.Windows.Forms.Button
    Friend WithEvents Btn_if_else As System.Windows.Forms.Button
    Friend WithEvents Btn_case As System.Windows.Forms.Button

End Class
