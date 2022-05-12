﻿Public Class formLeaveAdd
    Dim functionAudit As New functionAudit()
    Dim functionLeave As New functionLeave()
    Dim employeeTable As DataTable = functionLeave.getEmployee()

    Private Sub formLeaveAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        employeeComboBox.DataSource = employeeTable
        employeeComboBox.DisplayMember = "name"
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        If employeeComboBox.SelectedIndex = -1 Or detailRichTextBox.Text = "" Then
            MessageBox.Show("Input all fields.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim employeeId As Decimal = employeeTable.Rows(employeeComboBox.SelectedIndex)("id")
            If functionLeave.insertLeave(employeeId, employeeComboBox.Text, detailRichTextBox.Text, DateTimePicker1.Value) Then
                Dim audit As String = "Added a new employee's leave for: " + employeeComboBox.Text
                functionAudit.insertAudit(audit)
                MessageBox.Show("Employee's Absent Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub
End Class