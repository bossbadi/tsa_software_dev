<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_GPA
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
        Me.Grades = New System.Windows.Forms.ListBox()
        Me.GradeInput = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.Label_GPA = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_Grade = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WeightInput = New System.Windows.Forms.TextBox()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(489, 80)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GPA Calculator"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Grades
        '
        Me.Grades.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grades.FormattingEnabled = True
        Me.Grades.ItemHeight = 24
        Me.Grades.Location = New System.Drawing.Point(262, 114)
        Me.Grades.Name = "Grades"
        Me.Grades.Size = New System.Drawing.Size(239, 100)
        Me.Grades.TabIndex = 2
        '
        'GradeInput
        '
        Me.GradeInput.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeInput.Location = New System.Drawing.Point(137, 114)
        Me.GradeInput.MaxLength = 6
        Me.GradeInput.Name = "GradeInput"
        Me.GradeInput.Size = New System.Drawing.Size(105, 39)
        Me.GradeInput.TabIndex = 3
        Me.GradeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.Location = New System.Drawing.Point(12, 233)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(230, 48)
        Me.ButtonAdd.TabIndex = 4
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'Label_GPA
        '
        Me.Label_GPA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label_GPA.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_GPA.Location = New System.Drawing.Point(367, 287)
        Me.Label_GPA.Name = "Label_GPA"
        Me.Label_GPA.Size = New System.Drawing.Size(134, 47)
        Me.Label_GPA.TabIndex = 5
        Me.Label_GPA.Text = "0"
        Me.Label_GPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(262, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 47)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "GPA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(262, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 48)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Final"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_Grade
        '
        Me.Label_Grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label_Grade.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Grade.Location = New System.Drawing.Point(367, 233)
        Me.Label_Grade.Name = "Label_Grade"
        Me.Label_Grade.Size = New System.Drawing.Size(134, 48)
        Me.Label_Grade.TabIndex = 7
        Me.Label_Grade.Text = "0"
        Me.Label_Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 39)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Grade"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 39)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Weight"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WeightInput
        '
        Me.WeightInput.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightInput.Location = New System.Drawing.Point(137, 174)
        Me.WeightInput.MaxLength = 4
        Me.WeightInput.Name = "WeightInput"
        Me.WeightInput.Size = New System.Drawing.Size(105, 39)
        Me.WeightInput.TabIndex = 10
        Me.WeightInput.Text = "1"
        Me.WeightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemove.Location = New System.Drawing.Point(12, 287)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(230, 48)
        Me.ButtonRemove.TabIndex = 12
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'Form_GPA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 346)
        Me.Controls.Add(Me.ButtonRemove)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.WeightInput)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label_Grade)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label_GPA)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.GradeInput)
        Me.Controls.Add(Me.Grades)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_GPA"
        Me.Text = "GPA Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Grades As ListBox
    Friend WithEvents GradeInput As TextBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents Label_GPA As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_Grade As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents WeightInput As TextBox
    Friend WithEvents ButtonRemove As Button
End Class
