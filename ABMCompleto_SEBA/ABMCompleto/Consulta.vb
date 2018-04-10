Imports System.Data.SqlClient

Public Class Consulta
    Dim cadena_conexion As String = "Data Source=maquis;Initial Catalog=_BD_PERSONAS_3K7;Persist Security Info=True;User ID=avisuales1;Password=avisuales1"
    Private Sub Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
        cargarCombo(cmbTipoDocumento, "tipos_documento", "n_tipo_documento", "id_tipo_documento")
        cargarCombo(cmbCarrera, "carreras", "n_carrera", "id_carrera")
    End Sub

    Private Sub cargar_grilla()
        Dim tabla As DataTable = consultaSql("SELECT * FROM Alumnos")
        Me.gdrAlumnos.DataSource = tabla

    End Sub

    Private Function consultaSql(ByVal sql As String) As DataTable
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(cadena_conexion)

        Dim consulta As String = sql

        cmd.Parameters.Clear()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta


        Dim tabla As New Data.DataTable

        cn.Open()
        cmd.Connection = cn
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        da.Fill(tabla)
        cn.Close()

        Return tabla
    End Function

    Private Sub cargarCombo(ByVal cmb As ComboBox, ByVal tablaString As String, ByVal descripcion As String, ByVal pk As String)
        Dim tabla As New DataTable
        tabla = consultaSql("SELECT * FROM " & tablaString)
        cmb.DataSource = tabla
        cmb.DisplayMember = descripcion
        cmb.ValueMember = pk
    End Sub

    Private Sub gdrAlumnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gdrAlumnos.CellClick
        For Each SelectedRow As DataGridViewRow In gdrAlumnos.SelectedRows
            Me.txtApellido.Text = SelectedRow.Cells("Apellido").Value.ToString
            Me.txtNombre.Text = SelectedRow.Cells("Nombre").Value.ToString
            Me.txtNumDocumento.Text = SelectedRow.Cells("NroDocumento").Value.ToString
            Me.txtCalle.Text = SelectedRow.Cells("Calle").Value.ToString
            Me.txtNroCalle.Text = SelectedRow.Cells("NroCalle").Value.ToString
            Me.txtCantidadHijos.Text = SelectedRow.Cells("CantidadHijos").Value.ToString
            Me.chkActividad.Checked = SelectedRow.Cells("Actividad").Value.ToString
            Me.chkCasado.Checked = SelectedRow.Cells("Casado").Value.ToString
            Me.chkHijos.Checked = SelectedRow.Cells("Hijos").Value.ToString

            Me.cmbTipoDocumento.SelectedIndex = SelectedRow.Cells("ID_Documento").Value.ToString
            Me.cmbCarrera.SelectedIndex = SelectedRow.Cells("IDCarrera").Value.ToString


            If SelectedRow.Cells("Sexo").Value.ToString = "m" Or SelectedRow.Cells("Sexo").Value.ToString = "M" Then
                Me.rdbMasculino.Checked = True
                Me.rdbFemenino.Checked = False
            Else
                Me.rdbMasculino.Checked = False
                Me.rdbFemenino.Checked = True
            End If

        Next
    End Sub

    Private Sub chkHijos_CheckedChanged(sender As Object, e As EventArgs) Handles chkHijos.CheckedChanged
        If Me.chkHijos.Checked = True Then
            Me.txtCantidadHijos.Enabled = True
        Else
            Me.txtCantidadHijos.Enabled = False
        End If
    End Sub
End Class