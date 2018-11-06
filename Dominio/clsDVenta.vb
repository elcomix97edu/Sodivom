Imports Entidades
Imports Persistencia
Public Class clsDVenta
    Dim unPV As New clsPVenta

    Public Function AltaVenta(fecha As Date, importe As Integer, empl As clsEEmpleado) As Boolean
        Return unPV.AltaVenta(fecha, importe, empl)
    End Function

    Public Function AltaVentaProducto(idventa As Integer, idprod As String, cantidad As Integer) As Boolean
        Return unPV.AltaVentaProducto(idventa, idprod, cantidad)
    End Function

    Public Function AltaVentaDeProducto(idventa As Integer, cicli As Integer) As Boolean
        Return unPV.AltaVentaDeProducto(idventa, cicli)
    End Function

    Public Function GetIdVenta(fecha As Date, ciEmpl As Integer) As Integer
        Return unPV.GetIdVenta(fecha, ciEmpl)
    End Function

    Public Function TraerVenta(id As String) As clsEVenta
        Return unPV.TraerVenta(id)
    End Function
    Public Function AltaReparto(idventa As Integer, descripcion As String) As Boolean
        Return unPV.AltaReparto(idventa, descripcion)
    End Function

    Public Function existeID(id As Integer) As Boolean
        Return unPV.existeID(id)
    End Function
End Class


