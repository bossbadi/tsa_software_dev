<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Navigation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_GPA = New System.Windows.Forms.Button()
        Me.Button_BaseConverter = New System.Windows.Forms.Button()
        Me.Button_RandomProblem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 47.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(597, 80)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to CalcHub"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_GPA
        '
        Me.Button_GPA.BackColor = System.Drawing.Color.Aquamarine
        Me.Button_GPA.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_GPA.Location = New System.Drawing.Point(59, 182)
        Me.Button_GPA.Name = "Button_GPA"
        Me.Button_GPA.Size = New System.Drawing.Size(186, 122)
        Me.Button_GPA.TabIndex = 1
        Me.Button_GPA.Text = "GPA Calculator"
        Me.Button_GPA.UseVisualStyleBackColor = False
        '
        'Button_BaseConverter
        '
        Me.Button_BaseConverter.BackColor = System.Drawing.Color.Aquamarine
        Me.Button_BaseConverter.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_BaseConverter.Location = New System.Drawing.Point(293, 182)
        Me.Button_BaseConverter.Name = "Button_BaseConverter"
        Me.Button_BaseConverter.Size = New System.Drawing.Size(186, 122)
        Me.Button_BaseConverter.TabIndex = 2
        Me.Button_BaseConverter.Text = "Base Converter"
        Me.Button_BaseConverter.UseVisualStyleBackColor = False
        '
        'Button_RandomProblem
        '
        Me.Button_RandomProblem.BackColor = System.Drawing.Color.Aquamarine
        Me.Button_RandomProblem.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_RandomProblem.Location = New System.Drawing.Point(538, 182)
        Me.Button_RandomProblem.Name = "Button_RandomProblem"
        Me.Button_RandomProblem.Size = New System.Drawing.Size(186, 122)
        Me.Button_RandomProblem.TabIndex = 3
        Me.Button_RandomProblem.Text = "Random Problem"
        Me.Button_RandomProblem.UseVisualStyleBackColor = False
        '
        'Navigation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_RandomProblem)
        Me.Controls.Add(Me.Button_BaseConverter)
        Me.Controls.Add(Me.Button_GPA)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Navigation"
        Me.Text = "CalcHub"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button_GPA As Button
    Friend WithEvents Button_BaseConverter As Button
    Friend WithEvents Button_RandomProblem As Button
End Class
