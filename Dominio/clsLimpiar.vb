Imports System.Windows.Forms
Public Class clsLimpiar

    Public Sub Limpiar(ByVal frm As Form)
        For Each unControl In frm.Controls
            If TypeOf unControl Is TextBox Then
                unControl.Text = ""
                unControl.BackColor = Drawing.Color.White

            End If

            If TypeOf unControl Is MaskedTextBox Then
                unControl.Text = ""
                unControl.BackColor = Drawing.Color.White
                unControl.Enabled = True
            End If

            If TypeOf unControl Is RadioButton Then
                unControl.Checked = False
            End If

            If TypeOf unControl Is ComboBox Then
                unControl.Text = ""
            End If

            If TypeOf unControl Is DateTimePicker Then
                unControl.Text = Date.Now
            End If

            If TypeOf unControl Is DataGridView Then
                unControl.Rows.Clear()
            End If
            unControl.Enabled = True
        Next

    End Sub

End Class
