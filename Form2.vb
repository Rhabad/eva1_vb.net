Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Form2
    Private cadenaConexion As String = "Server=localhost;Database=eva1_vb;User Id=root;Password=1234;"

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim rut As String = txtRutCliente.Text
        Dim telefono As Integer = CInt(txtTelefono.Text)

        Try
            Dim query As String = "INSERT INTO telefonosCliente (telefono, rutCliente) 
                                    VALUES(@telefono, @rutCliente);"

            Using conectar As New MySqlConnection(cadenaConexion)
                Using cmd As New MySqlCommand(query, conectar)
                    cmd.Parameters.AddWithValue("@telefono", telefono)
                    cmd.Parameters.AddWithValue("@rutCliente", rut)

                    conectar.Open()
                    cmd.ExecuteNonQuery()


                    MessageBox.Show("Telefono agregado")
                End Using
            End Using


        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnMostrarTelefonos_Click(sender As Object, e As EventArgs) Handles btnMostrarTelefonos.Click
        Dim query As String = "select * from telefonosCliente;"

        Try
            Using conectar As New MySqlConnection(cadenaConexion)
                Using cmd As New MySqlCommand(query, conectar)
                    conectar.Open()

                    Dim lector As MySqlDataReader = cmd.ExecuteReader()
                    Dim resultado As New StringBuilder

                    While lector.Read()
                        resultado.AppendLine("ID: " & lector("idTelefono").ToString)
                        resultado.AppendLine("Telefono: " & lector("telefono").ToString)
                        resultado.AppendLine("Rut Cliente: " & lector("rutCliente").ToString)

                        resultado.AppendLine()
                    End While

                    tboxTelefonos.Text = resultado.ToString
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message)
        End Try
    End Sub
End Class