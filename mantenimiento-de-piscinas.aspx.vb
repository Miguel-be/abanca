Public Class mantenimiento_de_piscinas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnenviar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnenviar.Click
        'comprobar que se han metido bien los datos del formulario
        Dim v As New repo
        Dim contenido(3) As String

        recoger_contenido(contenido)
        If noerrores_formulario() Then
            If v.enviar_presupuesto(contenido) = 1 Then
                Dim cs As ClientScriptManager = Page.ClientScript
                Dim csname2 As String = "ButtonClickScript"
                Dim cstype As Type = Me.GetType()
                Dim cadena As String

                cadena = "<script language=javascript> alert ('Hemos recibido su petición. Muchas gracias por contactarnos'); window.location.href= 'https://www.abanca.es' </script>"
                cs.RegisterClientScriptBlock(cstype, csname2, cadena, False)
            End If

        End If

    End Sub

    Private Function noerrores_formulario() As Boolean
        'Se comprueba la validación del formulario
        Dim d As New repo

        If d.Validaciontexto(txtname.Text) = 0 Then
            d.activar_error(txtname)
            lblerror.Visible = True
            lblerror.Text = "Por favor, introduce tu nombre"
            Return False
        Else
            d.desactivar_error(txtname)
        End If

        If d.Validacionemailvacio(txtemail.Text) = 0 Then
            d.activar_error(txtemail)
            lblerror.Visible = True
            lblerror.Text = "Por favor, introduce tu email correctamente"
            Return False
        Else
            d.desactivar_error(txtemail)
        End If

        If d.Validaciontexto(txttelefono.Text) = 0 Then
            d.activar_error(txttelefono)
            lblerror.Visible = True
            lblerror.Text = "Por favor, introduce tu teléfono"
            Return False
        Else
            d.desactivar_error(txttelefono)
        End If

        If Not lopd.Checked Then
            lblerror.Visible = True
            lblerror.Text = "Por favor, lee y acepta la política de privacidad"
            Return False
        End If
        Return True
    End Function

    Private Sub recoger_contenido(ByVal contenido() As String)
        contenido(0) = txtname.Text
        contenido(1) = txtemail.Text
        contenido(2) = txttelefono.Text
        contenido(3) = txtcontenido.Text
    End Sub

End Class