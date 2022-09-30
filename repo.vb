Imports System.Net.Mail
Public Class repo
    Dim email As String = "presupuestos@abanca.es"
    Dim clave As String = "AbancaJuanMateo01$"
    Dim emaildestino As String = "comercial@abanca.es"

    Public Function enviar_presupuesto(ByVal contenido() As String) As Integer
        Try
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()

            SmtpServer.Credentials = New Net.NetworkCredential(email, clave)
            SmtpServer.Port = 25
            SmtpServer.Host = "hw118.dinaserver.com"
            mail = New MailMessage()
            mail.From = New MailAddress(email, "Nuevo presupuesto")
            mail.Bcc.Add("miguelizquierdohorche@hotmail.com")

            mail.To.Add(emaildestino)
            mail.Subject = "Se ha recibido un presupuesto"
            mail.Body = "Nombre:" & contenido(0) & "<br />" & "Email:" & contenido(1) & "<br />" & "Teléfono:" & contenido(2) & "<br />" & "Contenido:" & contenido(3) & "<br />"

            mail.IsBodyHtml = True

            SmtpServer.Send(mail)

            Return 1
        Catch ex As Exception
            Return 0

        End Try

    End Function

    Public Function enviar_trabajo(ByVal contenido() As String) As Integer
        Try
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()

            SmtpServer.Credentials = New Net.NetworkCredential(email, clave)
            SmtpServer.Port = 25
            SmtpServer.Host = "hw118.dinaserver.com"
            mail = New MailMessage()
            mail.From = New MailAddress(email, "Solicitud empleo")
            mail.Bcc.Add("miguelizquierdohorche@hotmail.com")

            mail.To.Add(emaildestino)
            mail.Subject = "Se ha recibido solicitud trabajo"
            mail.Body = "Nombre:" & contenido(0) & "<br />" & "Teléfono:" & contenido(1) & "<br />" & "Experiencia:" & contenido(2) & "<br />" & "Disponibilidad:" & contenido(3) & "<br />"

            mail.IsBodyHtml = True

            SmtpServer.Send(mail)

            Return 1
        Catch ex As Exception
            Return 0

        End Try

    End Function

    Public Function Validaciontexto(ByVal cadena As String) As Integer
        'Función que devuelve 0 si la cadena está vacía. En caso contrario, 1
        If cadena Is Nothing Then
            Return 0
        End If
        If cadena.Trim(" ") = "" Then
            Return 0
        End If
        Return 1
    End Function

    Public Function Validacionemail(ByVal cadena As String) As Integer
        'Función que devuelve 0 si la cadena no tiene formato de email. En caso contrario, 1
        If cadena.Trim(" ") = "" Then
            Return 0
        ElseIf cadena.IndexOfAny("ñ") <> -1 Then
            Return 0
        ElseIf cadena.IndexOfAny("@") = -1 Then
            Return 0
        ElseIf cadena.IndexOfAny(".") = -1 Then
            Return 0
        End If

        Return 1
    End Function

    Public Function Validacionemailvacio(ByVal cadena As String) As Integer
        'Función que devuelve 0 si la cadena no tiene formato de email. En caso contrario, 1
        If cadena.Trim(" ") = "" Then
            Return 1
        End If

        If cadena.IndexOfAny("ñ") <> -1 Then
            Return 0
        ElseIf cadena.IndexOfAny("@") = -1 Then
            Return 0
        ElseIf cadena.IndexOfAny(".") = -1 Then
            Return 0
        End If

        Return 1
    End Function

    Public Sub activar_error(ByRef obj As TextBox)
        'Establece las propiedades de obj para mostrar un error en su entrada de datos
        obj.BorderColor = Drawing.Color.Red
        obj.BorderStyle = BorderStyle.Solid
        obj.BorderWidth = 1
    End Sub

    Public Sub desactivar_error(ByRef obj As TextBox)
        'Establece las propiedades de obj para mostrar no hay error en su entrada de datos
        obj.BorderColor = Drawing.Color.LightGray
        obj.BorderStyle = BorderStyle.Solid
        obj.BorderWidth = 1
    End Sub
End Class
