Public Class clsECliente
    Inherits clsEPersona

    Public Sub New(ced As Integer, nom As String, ape As String, dir As String, tel As String, mail As String)
        ci = ced
        nombre = nom
        apellido = ape
        direccion = dir
        telefono = tel
        email = mail

    End Sub


End Class
