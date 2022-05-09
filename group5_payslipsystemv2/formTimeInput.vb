Public Class formTimeInput
    Dim functionTime As New functionTime()
    Dim employeeTable As DataTable = functionTime.getEmployee()

    Private Sub formTimeInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        employeeComboBox.DataSource = employeeTable
        employeeComboBox.DisplayMember = "name"
    End Sub

    Private Sub employeeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles employeeComboBox.SelectedIndexChanged
        Console.WriteLine()
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click

        If employeeComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Input Employee", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim timeInHour As Decimal = DateTimePicker1.Value.Hour
            Dim timeOutHour As Decimal = DateTimePicker2.Value.Hour
            Dim timeInMinute As Decimal = DateTimePicker1.Value.Minute
            Dim timeOutMinute As Decimal = DateTimePicker2.Value.Minute

            If timeInHour < 7 Then
                timeInHour = 7
            End If

            Dim overtimeAnswer As Decimal = 0
            Dim answer As Decimal = timeOutHour - timeInHour

            If timeOutHour > 16 Then
                answer = 16 - timeInHour
                overtimeAnswer = timeOutHour - 16
            End If

            If answer > 5 Then
                answer -= 1
            End If

            Dim minuteAnswer As Decimal = 0
            If timeInMinute > timeOutMinute Then
                minuteAnswer = timeInMinute - timeOutMinute
            Else
                minuteAnswer = timeOutMinute - timeInMinute
            End If

            Dim employeeId As Decimal = employeeTable.Rows(employeeComboBox.SelectedIndex)("id")
            If functionTime.insertTime(employeeId, employeeComboBox.Text, DateTimePicker1.Value, DateTimePicker2.Value, answer, overtimeAnswer, minuteAnswer) Then
                MessageBox.Show("Time In/Out Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Sub solveTime()


    End Sub

End Class