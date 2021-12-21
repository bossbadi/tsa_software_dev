<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_BaseConverter
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BaseInput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumberInput = New System.Windows.Forms.TextBox()
        Me.ButtonConvert = New System.Windows.Forms.Button()
        Me.Label_Converted = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BaseOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(489, 80)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Base Converter"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 39)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Input base"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BaseInput
        '
        Me.BaseInput.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BaseInput.Location = New System.Drawing.Point(207, 174)
        Me.BaseInput.Name = "BaseInput"
        Me.BaseInput.Size = New System.Drawing.Size(294, 39)
        Me.BaseInput.TabIndex = 16
        Me.BaseInput.Text = "16"
        Me.BaseInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 39)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Input"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumberInput
        '
        Me.NumberInput.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberInput.Location = New System.Drawing.Point(207, 114)
        Me.NumberInput.Name = "NumberInput"
        Me.NumberInput.Size = New System.Drawing.Size(294, 39)
        Me.NumberInput.TabIndex = 14
        Me.NumberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonConvert
        '
        Me.ButtonConvert.BackColor = System.Drawing.Color.Snow
        Me.ButtonConvert.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConvert.Location = New System.Drawing.Point(12, 289)
        Me.ButtonConvert.Name = "ButtonConvert"
        Me.ButtonConvert.Size = New System.Drawing.Size(189, 56)
        Me.ButtonConvert.TabIndex = 18
        Me.ButtonConvert.Text = "Convert"
        Me.ButtonConvert.UseVisualStyleBackColor = False
        '
        'Label_Converted
        '
        Me.Label_Converted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label_Converted.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Converted.Location = New System.Drawing.Point(207, 290)
        Me.Label_Converted.Name = "Label_Converted"
        Me.Label_Converted.Size = New System.Drawing.Size(294, 55)
        Me.Label_Converted.TabIndex = 19
        Me.Label_Converted.Text = "0"
        Me.Label_Converted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 39)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Output base"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BaseOutput
        '
        Me.BaseOutput.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BaseOutput.Location = New System.Drawing.Point(207, 233)
        Me.BaseOutput.Name = "BaseOutput"
        Me.BaseOutput.Size = New System.Drawing.Size(294, 39)
        Me.BaseOutput.TabIndex = 20
        Me.BaseOutput.Text = "10"
        Me.BaseOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form_BaseConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(514, 361)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BaseOutput)
        Me.Controls.Add(Me.Label_Converted)
        Me.Controls.Add(Me.ButtonConvert)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BaseInput)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumberInput)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_BaseConverter"
        Me.Text = "Base Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BaseInput As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NumberInput As TextBox
    Friend WithEvents ButtonConvert As Button
    Friend WithEvents Label_Converted As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BaseOutput As TextBox
End Class
