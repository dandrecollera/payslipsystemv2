Imports MySql.Data.MySqlClient

Public Class formPayslip
    Public id As Decimal
    Public employeeName As String
    Public baseSalary As Double

    Public timeTable As New DataTable()
    Private Sub formPayslip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillTextBox()
    End Sub

    Private Function getDays(ByVal month As Decimal) As Decimal
        Dim year As Decimal = Date.Today.Year
        Dim days As Decimal = DateTime.DaysInMonth(year, month + 1)
        Return days
    End Function

    Private Sub monthsComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles monthsComboBox.SelectedIndexChanged
        If firstRadioButton.Checked = True Or secondRadioButton.Checked = True Then
            Dim days As Decimal = getDays(monthsComboBox.SelectedIndex)
            If firstRadioButton.Checked = True Then
                fillTable(1, Math.Ceiling(days / 2))
            Else
                fillTable(Math.Ceiling((days / 2) + 1), days)
            End If
        End If

        If monthsComboBox.SelectedIndex > -1 Then
            firstRadioButton.Enabled = True
            secondRadioButton.Enabled = True
        Else
            firstRadioButton.Enabled = False
            secondRadioButton.Enabled = False
        End If


    End Sub

    Private Sub firstRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles firstRadioButton.CheckedChanged
        checkRadioButton(firstRadioButton)
    End Sub

    Private Sub secondRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles secondRadioButton.CheckedChanged
        checkRadioButton(secondRadioButton)
    End Sub

    Private Sub checkRadioButton(ByVal control As RadioButton)
        Dim days As Decimal = getDays(monthsComboBox.SelectedIndex)

        If control.Checked = True Then
            If control Is firstRadioButton Then
                fillTable(1, Math.Ceiling(days / 2))

            Else
                fillTable(Math.Ceiling((days / 2) + 1), days)
            End If
        End If


    End Sub

    Private Sub fillTextBox()
        nameTextBox.Text = employeeName
        salaryTextBox.Text = Format(baseSalary, "₱##,###.00")
    End Sub

    Private Sub fillTable(ByVal firstDay As Decimal, ByVal lastDay As Decimal)
        Dim db As New dbConnector()
        Dim command As New MySqlCommand("SELECT * FROM `timeinout` WHERE `employee_id` = @id AND `date` BETWEEN @first AND @last", db.getConnection)
        command.Parameters.Add("@id", MySqlDbType.Int32).Value = id
        command.Parameters.AddWithValue("@first", Date.Today.Year.ToString() + "-" + (monthsComboBox.SelectedIndex + 1).ToString() + "-" + firstDay.ToString())
        command.Parameters.AddWithValue("@last", Date.Today.Year.ToString() + "-" + (monthsComboBox.SelectedIndex + 1).ToString() + "-" + lastDay.ToString())

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        timeTable = table
        calculateTotal()
    End Sub

    Private Sub calculateTotal()
        Dim regular As Decimal = 0
        Dim overtime As Decimal = 0
        Dim regMin As Decimal = 0
        Dim otMin As Decimal = 0
        Try
            For x As Byte = 0 To timeTable.Rows.Count - 1
                regular += timeTable.Rows(x)("Regular")
                overtime += timeTable.Rows(x)("Overtime")
                If timeTable.Rows(x)("Overtime") > 0 Then
                    otMin += timeTable.Rows(x)("Minute")
                Else
                    regMin += timeTable.Rows(x)("Minute")
                End If
            Next
        Catch ex As Exception
            'Pass
        End Try

        Dim bonus As Double
        If bonusTextBox.Text = "" Then
            bonusTextBox.Text = 0
            bonus = 0
        Else
            bonus = bonusTextBox.Text
        End If

        Dim hourlyRate As Double = (baseSalary / getDays(monthsComboBox.SelectedIndex)) / 8
        Dim overtimeRate As Double = hourlyRate * 1.25
        Dim minRate As Double = hourlyRate / 60
        Dim otRate As Double = minRate * 1.25

        Dim general As Double = (regular * hourlyRate) + (regMin * minRate)
        Dim otVal As Double = (overtime * overtimeRate) + (otMin * otRate)


        Dim sss As Double = general * 0.13
        If sss > 25000 Then
            sss = 25000
        End If

        Dim pagibig As Double = 0
        If general < 1500 Then
            pagibig = general * 0.01
        Else
            pagibig = general * 0.02
        End If

        Dim philhealth As Double = general * 0.0275
        If philhealth < 10000 Then
            philhealth = 0
        ElseIf philhealth > 40000 Then
            philhealth = 40000
        End If

        Dim tax As Double = 0
        If general <= 16666 Then
            tax = 0
        ElseIf general >= 16667 And general < 33332 Then
            tax = 1250
        ElseIf general >= 33333 And general < 83332 Then
            tax = 5416.67
        ElseIf general >= 83333 And general < 333332 Then
            tax = 20416.67
        ElseIf general >= 333333 Then
            tax = 100416.67
        End If

        Dim totalwodeduct As Double = general + otVal + bonus
        Dim finaltotal As Double = totalwodeduct - (sss + pagibig + philhealth + tax)
        fillBox(general, otVal, totalwodeduct, sss, pagibig, philhealth, tax, finaltotal)
    End Sub

    Private Sub fillBox(general, otVal, total, sss, pagibig, philhealth, tax, finaltotal)
        generalSalaryTextBox.Text = Format(general, "₱##,##0.00")
        overtimeTextBox.Text = Format(otVal, "₱##,##0.00")
        totalwoDeductionTextBox.Text = Format(total, "₱##,##0.00")
        sssTextBox.Text = Format(sss, "₱##,##0.00")
        pagibigTextBox.Text = Format(pagibig, "₱##,##0.00")
        philhealthTextBox.Text = Format(philhealth, "₱##,##0.00")
        taxTextBox.Text = Format(tax, "₱##,##0.00")
        finalTotalTextBox.Text = Format(finaltotal, "₱##,##0.00")
    End Sub

    Private Sub bonusTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bonusTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub generateButton_Click(sender As Object, e As EventArgs) Handles generateButton.Click
        If monthsComboBox.SelectedIndex >= 0 And firstRadioButton.Checked Or secondRadioButton.Checked Then
            Dim formPayslipGen As New formPayslipGen()
            Dim table As New DataTable
            Dim dtNames() As String = {"name", "month", "cutoff", "generalsalary", "overtime", "bonus", "totalwodeduct", "sss", "pagibig", "philhealth", "tax", "finaltotal", "year"}
            Dim i As Decimal
            For i = 0 To dtNames.Length - 1
                table.Columns.Add(dtNames(i), GetType(String))
            Next


            Dim name As String = nameTextBox.Text
            Dim month As String = monthsComboBox.Text
            Dim cutOff As String
            If firstRadioButton.Checked Then
                cutOff = "1st"
            Else
                cutOff = "2nd"
            End If
            Dim generalsalary As String = generalSalaryTextBox.Text
            Dim overtime As String = overtimeTextBox.Text
            Dim bonus As String = Format(Convert.ToInt32(bonusTextBox.Text), "₱##,##0.00")
            Console.WriteLine(bonus)
            Dim totalwodeduct As String = totalwoDeductionTextBox.Text
            Dim sss As String = sssTextBox.Text
            Dim pagibig As String = pagibigTextBox.Text
            Dim philhealth As String = philhealthTextBox.Text
            Dim tax As String = taxTextBox.Text
            Dim finaltotal As String = finalTotalTextBox.Text
            Dim year As String = Date.Today.Year


            table.Rows.Add(name, month, cutOff, generalsalary, overtime, bonus, totalwodeduct, sss, pagibig, philhealth, tax, finaltotal, year)
            formPayslipGen.paysliptable = table
            Me.Hide()
            formPayslipGen.ShowDialog()
            Me.Close()
        End If

    End Sub

    Private Sub bonusTextBox_TextChanged(sender As Object, e As EventArgs) Handles bonusTextBox.TextChanged
        If monthsComboBox.SelectedIndex >= 0 And firstRadioButton.Checked Or secondRadioButton.Checked Then
            calculateTotal()
        End If
    End Sub
End Class