Imports System.Windows.Forms

Public Class PropiedadesTablas

    Public Function PropiedadesTabla1() As DataGridView
        Dim dgv As New DataGridView
        dgv.ReadOnly = True
        dgv.AllowUserToAddRows = False
        dgv.RowHeadersVisible = False
        dgv.AllowUserToResizeRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Return dgv
    End Function

End Class
