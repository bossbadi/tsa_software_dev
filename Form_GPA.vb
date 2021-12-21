Public Class Form_GPA
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        If IsNumeric(GradeInput.Text) And IsNumeric(WeightInput.Text) Then
            If (
                GradeInput.Text >= 0 And GradeInput.Text <= 200 And
                WeightInput.Text >= 1 And WeightInput.Text < 2
            ) Then
                Dim grade As Double = GradeInput.Text
                Dim weight As Double = WeightInput.Text
                grade = Format(grade * weight, "0.000")

                Grades.Items.Add(grade)

                UpdateGPA()
            End If
        End If
    End Sub

    Sub UpdateGPA()
        ' sum up all the numbers in Grades.Items
        Dim sum As Double = 0
        For Each item As Double In Grades.Items
            sum += item
        Next

        ' divide the sum by the number of items in Grades.Items
        Dim avg As Double = sum / Grades.Items.Count

        ' format to 2 decimal places
        Label_Grade.Text = Format(avg, "0.00")
        Label_GPA.Text = Format(avg / 20 - 1, "0.00")

        ' color both labels based on label_grade
        If avg >= 90 Then
            Label_Grade.ForeColor = Color.Green
            Label_GPA.ForeColor = Color.Green
        ElseIf avg >= 80 Then
            Label_Grade.ForeColor = Color.DarkOrange
            Label_GPA.ForeColor = Color.DarkOrange
        Else
            Label_Grade.ForeColor = Color.Red
            Label_GPA.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        If Grades.SelectedIndex >= 0 Then
            Dim num As Integer
            num = Grades.SelectedIndex
            Grades.Items.RemoveAt(num)

            UpdateGPA()
        End If
    End Sub
End Class
