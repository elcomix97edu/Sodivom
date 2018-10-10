Imports MySql.Data.MySqlClient
Public Class clsPersistencia
        Private con As MySqlConnection
        Private Function conectar() As MySqlConnection
            If Not con Is Nothing Then con.Close()
            Dim miConexion As String
        'miConexion = "server=127.0.0.1; uid=root ; password=; database=database;"
        miConexion = "server=localhost; uid=root ; password= ; database=sodivom  ; SslMode=none;"
        Try
                con = New MySqlConnection(miConexion)
                con.Open()
            Catch ex As MySqlException
            'MsgBox("Error al conectarse con el servidor " & ex.Message)
        End Try
            Return con
        End Function

        Private Sub desconectar()
            con.Close()
        End Sub
        Public Function ejecutarSQL(ByVal consultaSQL As String) As Boolean
            Dim correctou As Boolean = True
            Dim comando As New MySqlCommand()
            comando.CommandText = consultaSQL
            comando.CommandType = CommandType.Text
            comando.Connection = conectar()
            Try
                comando.ExecuteNonQuery()
            Catch ex As MySqlException
            MsgBox("Error al ejecutar las sentencias sql" & ex.Message)
            correctou = False
            End Try
            desconectar()
            Return correctou
        End Function

    Public Function ejecutarYdevolver(ByVal sql As String) As MySqlDataReader
        Dim comando As New MySqlCommand
        Dim resultados As MySqlDataReader
        comando.CommandText = sql
        comando.CommandType = CommandType.Text
        comando.Connection = conectar()
        Try
            resultados = comando.ExecuteReader()
        Catch ex As MySqlException

        End Try
        Return resultados
        desconectar()
    End Function


End Class

