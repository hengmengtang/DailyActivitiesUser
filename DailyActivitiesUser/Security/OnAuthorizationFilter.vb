Public Class OnAuthorizationFilter
    Inherits AuthorizeAttribute
    Implements IAuthorizationFilter

    Public Overrides Sub OnAuthorization(filterContext As AuthorizationContext)
        If HttpContext.Current.Session("username") IsNot Nothing Then
            filterContext.Result = New HttpUnauthorizedResult
        End If
    End Sub

End Class
