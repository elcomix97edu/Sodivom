Public Class clsValidar

    Public Function Valido(obj As String) As Boolean
        If obj = "" Then
            Return False
        Else Return True
        End If
    End Function

    Public Function VerificarCI(ci As Integer) As Boolean
        Dim num(6) As Integer
        For i = 0 To 6
            num(i) = Integer.Parse(ci.ToString.ToCharArray()(i))
        Next
        Dim ver As Integer
        ver = num(0) * 8
        ver += num(1) * 1
        ver += num(2) * 2
        ver += num(3) * 3
        ver += num(4) * 4
        ver += num(5) * 7
        ver += num(6) * 6
        ver = ver Mod 10

        If ver = Integer.Parse(ci.ToString.ToCharArray()(7)) Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
