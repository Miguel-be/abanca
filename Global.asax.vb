Imports System.Web.SessionState
Imports System.Web.Routing

Public Class Global_asax
    Inherits System.Web.HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al iniciar la aplicación
        RegisterRoutes(RouteTable.Routes)
    End Sub

    Private Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.MapPageRoute("aviso", "aviso-legal", "~/aviso-legal.aspx")
        routes.MapPageRoute("contacto", "trabajo-limpieza", "~/contacto.aspx")
        routes.MapPageRoute("empresa", "empresa-limpiezas-madrid", "~/empresa-limpiezas-madrid.aspx")
        routes.MapPageRoute("clinicas", "limpieza-clinicas", "~/limpieza-clinicas.aspx")
        routes.MapPageRoute("colegios", "limpieza-colegios", "~/limpieza-colegios.aspx")
        routes.MapPageRoute("comunidades", "limpieza-comunidades", "~/limpieza-comunidades.aspx")
        routes.MapPageRoute("oficinas", "limpieza-oficinas", "~/limpieza-oficinas.aspx")
        routes.MapPageRoute("mantenimiento", "mantenimiento-de-comunidades", "~/mantenimiento-de-comunidades.aspx")
        routes.MapPageRoute("jardines", "mantenimiento-de-jardines", "~/mantenimiento-de-jardines.aspx")
        routes.MapPageRoute("piscinas", "mantenimiento-de-piscinas", "~/mantenimiento-de-piscinas.aspx")
        routes.MapPageRoute("cookies", "politica-cookies", "~/politica-cookies.aspx")
        routes.MapPageRoute("privacidad", "politica-privacidad", "~/politica-privacidad.aspx")
        routes.MapPageRoute("presupuesto", "presupuesto-limpieza", "~/presupuesto-limpieza.aspx")
        routes.MapPageRoute("rsc", "responsabilidad-social-corporativa", "~/responsabilidad-social-corporativa.aspx")
        routes.MapPageRoute("conserjeria", "servicios-de-conserjeria", "~/servicios-de-conserjeria.aspx")
        routes.MapPageRoute("gracias", "gracias", "~/servicios-de-conserjeria.aspx")
        routes.MapPageRoute("error", "error", "~/error.aspx")

    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al iniciar la sesión
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al comienzo de cada solicitud
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al intentar autenticar el uso
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando se produce un error
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando finaliza la sesión
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando finaliza la aplicación
    End Sub

End Class