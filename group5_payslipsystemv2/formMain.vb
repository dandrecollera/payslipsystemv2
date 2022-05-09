Imports MySql.Data.MySqlClient
Public Class formMain
    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'Payslipdbv2DataSet.timeinout' table. You can move, or remove it, as needed.
        tableLoad()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Hide()
        Dim formEmployee As New formEmployee()
        formEmployee.ShowDialog()
        Me.Close()
    End Sub

    Private Sub buttonTimeInOut_Click(sender As Object, e As EventArgs) Handles buttonTimeInOut.Click
        Dim formTimeInput As New formTimeInput()
        If formTimeInput.ShowDialog = DialogResult.OK Then
            tableLoad()
        End If
    End Sub

    Private Sub tableLoad()
        Dim db As New dbConnector()
        Dim command As New MySqlCommand("SELECT * FROM `timeinout` ORDER BY `timeinout`.`date` ASC", db.getConnection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.Hide()
        Dim formReports As New formReports()
        formReports.ShowDialog()
        Me.Close()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Me.Hide()
        Dim formLogin As New formLogin()
        formLogin.ShowDialog()
        Me.Close()
    End Sub
End Class