<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_RandomProblem
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
        Me.Button_Next = New System.Windows.Forms.Button()
        Me.Button_Back = New System.Windows.Forms.Button()
        Me.Label_Card = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_Next
        '
        Me.Button_Next.BackColor = System.Drawing.Color.PowderBlue
        Me.Button_Next.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Next.Location = New System.Drawing.Point(669, 178)
        Me.Button_Next.Name = "Button_Next"
        Me.Button_Next.Size = New System.Drawing.Size(112, 101)
        Me.Button_Next.TabIndex = 0
        Me.Button_Next.Text = "Next"
        Me.Button_Next.UseVisualStyleBackColor = False
        '
        'Button_Back
        '
        Me.Button_Back.BackColor = System.Drawing.Color.PowderBlue
        Me.Button_Back.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Back.Location = New System.Drawing.Point(19, 178)
        Me.Button_Back.Name = "Button_Back"
        Me.Button_Back.Size = New System.Drawing.Size(112, 101)
        Me.Button_Back.TabIndex = 1
        Me.Button_Back.Text = "Back"
        Me.Button_Back.UseVisualStyleBackColor = False
        '
        'Label_Card
        '
        Me.Label_Card.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label_Card.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Card.Location = New System.Drawing.Point(156, 111)
        Me.Label_Card.Name = "Label_Card"
        Me.Label_Card.Size = New System.Drawing.Size(489, 237)
        Me.Label_Card.TabIndex = 2
        Me.Label_Card.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(156, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(489, 80)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Random Problem"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form_RandomProblem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(800, 365)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_Card)
        Me.Controls.Add(Me.Button_Back)
        Me.Controls.Add(Me.Button_Next)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_RandomProblem"
        Me.Text = "Random Problem"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Next As Button
    Friend WithEvents Button_Back As Button
    Friend WithEvents Label_Card As Label
    Friend WithEvents Label1 As Label
End Class
