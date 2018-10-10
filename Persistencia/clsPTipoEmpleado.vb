Imports Entidades
Imports MySql.Data.MySqlClient

Public Class clsPTipoEmpleado
    Inherits clsPersistencia

    Public Function AltaTipoEmpleado(tipo As String) As Boolean
        Dim consulta As String
        consulta = "INSERT INTO tipoempleado (tipoempleado) VALUES ('" & tipo & "' )"

        Return ejecutarSQL(consulta)
    End Function

    Public Function existe(tipo As String) As Boolean
        Dim consultaSQL As String
        consultaSQL = "SELECT * FROM tipoempleado WHERE tipoempleado='" & tipo & "'"
        Dim datos = ejecutarYdevolver(consultaSQL)
        If datos.HasRows Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function listarTipoEmpleado() As List(Of clsETipoEmpleado)
        Dim consulta As String
        consulta = "SELECT * FROM tipoempleado"



        Dim datos As MySqlDataReader
        datos = ejecutarYdevolver(consulta)

        Dim listatipoempleado As New List(Of clsETipoEmpleado)
        Dim lista2 As New List(Of clsETipoEmpleado)
        Dim untipo As New clsETipoEmpleado
        While datos.Read
            'untipo.id = CInt(datos.Item("id").ToString)
            'untipo.tipoEmpleado = datos.Item("tipoempleado").ToString
            listatipoempleado.Add(crearTipoEmpleado(datos))
        End While

        'untipo.id = 1
        'untipo.tipoEmpleado = "Administrador"
        'listatipoempleado.Add(untipo)
        'lista2.Add(untipo)

        'untipo.id = 2
        'untipo.tipoEmpleado = "Cajero"
        'listatipoempleado.Add(untipo)
        'lista2.Add(untipo)



        Return listatipoempleado
    End Function

    Public Function eliminarTipoEmpleado(tipo As String) As Boolean
        Dim consulta As String
        consulta = "DELETE FROM tipoempleado WHERE tipoempleado = '" & tipo & "';"
        Return ejecutarSQL(consulta)
    End Function

    Public Function crearTipoEmpleado(ByVal datos As MySqlDataReader) As clsETipoEmpleado
        Dim unTE As New clsETipoEmpleado
        unTE.id = CInt(datos.Item("id").ToString)
        unTE.tipoEmpleado = datos.Item("tipoempleado").ToString
        Return unTE
    End Function

End Class
