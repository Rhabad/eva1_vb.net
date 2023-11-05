Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Form1

    'la cadena para la conexion
    Private cadenaConexion As String = "Server=localhost;Database=eva1_vb;User Id=root;Password=1234;"

    'aca mostramos los registros de la tabla
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim query As String = "select * from cliente;"
        Try
            Using connection As New MySqlConnection(cadenaConexion)
                Using cmd As New MySqlCommand(query, connection)
                    connection.Open()

                    Dim lector As MySqlDataReader = cmd.ExecuteReader()

                    Dim resultado As New StringBuilder

                    While lector.Read()
                        resultado.AppendLine("Rut: " & lector("rut").ToString)
                        resultado.AppendLine("Nombre: " & lector("nombre").ToString)
                        resultado.AppendLine("Apellido: " & lector("apellido").ToString)
                        resultado.AppendLine("Edad: " & lector("edad").ToString)
                        resultado.AppendLine("Genero: " & lector("genero").ToString)
                        resultado.AppendLine("Correo: " & lector("correo").ToString)
                        resultado.AppendLine("Direccion: " & lector("direccion").ToString)

                        resultado.AppendLine()
                    End While

                    tbox.Text = resultado.ToString
                End Using
            End Using
        Catch ex As Exception
            MsgBox("no se pudo conectar" & ex.Message)
        End Try
    End Sub

    'agregamos nuevos registros.
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim rut As String = txtRut.Text
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim edad As Integer = CInt(numEdad.Value)
        Dim genero As String = Combo1.Text
        Dim correo As String = txtCorreo.Text
        Dim direccion As String = txtDireccion.Text

        Try
            Dim query As String = "INSERT INTO cliente (rut, nombre, apellido, edad, genero, correo, direccion) 
                                    VALUES(@rut, @nombre, @apellido, @edad, @genero, @correo, @direccion);"

            Using conectar As New MySqlConnection(cadenaConexion)
                Using cmd As New MySqlCommand(query, conectar)
                    cmd.Parameters.AddWithValue("@rut", rut)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@apellido", apellido)
                    cmd.Parameters.AddWithValue("@edad", edad)
                    cmd.Parameters.AddWithValue("@genero", genero)
                    cmd.Parameters.AddWithValue("@correo", correo)
                    cmd.Parameters.AddWithValue("@direccion", direccion)

                    conectar.Open()
                    cmd.ExecuteNonQuery()

                    txtRut.Text = ""
                    txtNombre.Text = ""
                    txtApellido.Text = ""
                    txtCorreo.Text = ""
                    txtDireccion.Text = ""
                    numEdad.Value = numEdad.Minimum
                    Combo1.SelectedIndex = 2


                    MessageBox.Show("Agregado con exito.")
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error de conexion")
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combo1.SelectedIndex = 2

    End Sub
End Class
