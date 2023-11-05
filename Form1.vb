Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Form1

    Private cadenaConexion As String = "Server=localhost;Database=eva1_vb;User Id=root;Password=1234;"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

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
End Class
