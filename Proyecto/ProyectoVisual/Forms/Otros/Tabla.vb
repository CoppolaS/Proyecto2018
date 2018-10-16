Public Class Tabla
    Public Shared ID As Integer

    Private Sub Tabla_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowHeadersVisible = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua
        DataGridView1.MultiSelect = False
    End Sub

    Public Event ClickCelda(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim Fila As Integer = DataGridView1.CurrentRow.Index
        Try
            Dim ID1 As Integer = DataGridView1.Rows(Fila).Cells(0).Value
            ID = ID1
        Catch
        End Try
        RaiseEvent ClickCelda(Me, New System.Windows.Forms.DataGridViewCellEventArgs(0, 0))
    End Sub

End Class
