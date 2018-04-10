Imports System.Data.SqlClient

Public Class AltaAlumno
    Dim cadena_conexion As String = "Data Source=maquis;Initial Catalog=_BD_PERSONAS_3K7;Persist Security Info=True;User ID=avisuales1;Password=avisuales1"
    Private Sub AltaAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cmbTipoDocumento, "tipos_documento", "n_tipo_documento", "id_tipo_documento")
        cargarCombo(cmbCarrera, "carreras", "n_carrera", "id_carrera")
    End Sub

    Private Sub cargarCombo(ByVal cmb As ComboBox, ByVal tablaString As String, ByVal descripcion As String, ByVal pk As String)
        Dim tabla As New DataTable
        tabla = consultaSql("SELECT * FROM " & tablaString)
        cmb.DataSource = tabla
        cmb.DisplayMember = descripcion
        cmb.ValueMember = pk
    End Sub

    Private Function consultaSql(ByVal sql As String) As DataTable
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(cadena_conexion)

        Dim consulta As String = sql

        cmd.Parameters.Clear()
        ''cmd.Parameters.AddWithValue("@NombreUsu", _Usuario.NombreDelUsuario)
        ''cmd.Parameters.AddWithValue("@Pass", _Usuario.PasswordDelUsuario)
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

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub limpiar()
        Dim obj As New Object
        Dim objetos = Me.Controls
        For Each obj In objetos
            Select Case TypeName(obj)
                Case "TextBox"
                    Dim objActual As TextBox = obj
                    objActual.Text = ""
                Case "CheckBox"
                    Dim objActual As CheckBox = obj
                    objActual.Checked = False
                Case "ComboBox"
                    Dim objActual As ComboBox = obj
                    objActual.SelectedIndex = 0
                Case "RadioButton"
                    Dim objActual As RadioButton = obj
                    objActual.Checked = False
            End Select
        Next
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Dim flag_vacios As Boolean = verificar_Vacios()
        If flag_vacios = False Then
            MsgBox("Ingrese todos los campos")
            Exit Sub
        End If
        crear_Reg_alumno()
        MsgBox("Alumno cargado con exito")
        limpiar()

    End Sub

    Private Sub crear_Reg_alumno()
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(cadena_conexion)
        Dim consulta As String = "INSERT INTO Alumnos (Apellido, Nombres, id_tipo_documento, nro_documento, sexo, calle, nro_calle, actividad, casado, hijos, cantidad_hijos, id_carrera) 
        VALUES (@_Apellido, @_Nombre, @_id_tipo_documento, @_nro_documento, @_sexo, @_calle, @_nro_calle, @_actividad, @_casado, @_hijos, @_cantidad_hijos, @_id_carrera);  "
        cmd.Parameters.Clear()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta

        cmd.Parameters.AddWithValue("@_Apellido", Me.txtApellido.Text)
        cmd.Parameters.AddWithValue("@_Nombre", Me.txtNombre.Text)
        cmd.Parameters.AddWithValue("@_nro_documento", Me.txtNumDocumento.Text)
        cmd.Parameters.AddWithValue("@_calle", Me.txtCalle.Text)
        cmd.Parameters.AddWithValue("@_nro_calle", Me.txtNroCalle.Text)
        cmd.Parameters.AddWithValue("@_cantidad_hijos", Me.txtCantHijos.Text)
        cmd.Parameters.AddWithValue("@_id_tipo_documento", Me.cmbTipoDocumento.SelectedValue) ''ComboBox
        cmd.Parameters.AddWithValue("@_id_carrera", Me.cmbCarrera.SelectedValue) ''ComboBox
        If Me.rdbMasculino.Checked = True Then
            cmd.Parameters.AddWithValue("@_sexo", "m") ''RaddioButon
        Else
            cmd.Parameters.AddWithValue("@_sexo", "f") ''RaddioButon
        End If
        If Me.chkActividad.Checked = True Then
            cmd.Parameters.AddWithValue("@_actividad", 1) ''CheckBox
        Else
            cmd.Parameters.AddWithValue("@_actividad", 0) ''CheckBox
        End If
        If Me.chkCasado.Checked = True Then
            cmd.Parameters.AddWithValue("@_casado", 1) ''CheckBox
        Else
            cmd.Parameters.AddWithValue("@_casado", 0) ''CheckBox
        End If
        If Me.chkHijos.Checked = True Then
            cmd.Parameters.AddWithValue("@_hijos", 1) ''CheckBox
        Else
            cmd.Parameters.AddWithValue("@_hijos", 0) ''CheckBox
        End If

        cn.Open()
        cmd.Connection = cn
        cmd.ExecuteNonQuery()
        cn.Close()

    End Sub



    Private Function verificar_Vacios() As Boolean
        Dim flag_Resultado As Boolean = True
        Dim obj As New Object
        Dim objetos = Me.Controls
        For Each obj In objetos
            Select Case TypeName(obj)
                Case "TextBox"
                    Dim objActual As TextBox = obj
                    If objActual.Text = "" Then
                        If objActual.Name = "txtCantHijos" Then
                            If Me.chkHijos.Checked = True Then
                                flag_Resultado = False
                            End If
                        Else
                            flag_Resultado = False
                        End If
                    End If
                Case "ComboBox"
                    Dim objActual As ComboBox = obj
                    If objActual.SelectedIndex = -1 Then
                        flag_Resultado = False
                    End If
            End Select
        Next
        Return flag_Resultado
    End Function



    Private Sub chkHijos_CheckedChanged(sender As Object, e As EventArgs) Handles chkHijos.CheckedChanged
        If Me.chkHijos.Checked = True Then
            Me.txtCantHijos.Enabled = True
        Else
            Me.txtCantHijos.Enabled = False
        End If
    End Sub
End Class