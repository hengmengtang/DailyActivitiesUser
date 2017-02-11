Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Public Module RouteConfig
    Public Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

        routes.MapRoute(
            name:="Activities",
            url:="UserAccounts/Activities",
            defaults:=New With {.controller = "Activities", .action = "Index"}
        )

        routes.MapRoute(
            name:="ActivityCategories",
            url:="UserAccounts/ActivityCategories",
            defaults:=New With {.controller = "ActivityCategories", .action = "Index"}
        )

        routes.MapRoute(
           name:="ActivityDetails",
           url:="UserAccounts/ActivityDetails",
           defaults:=New With {.controller = "ActivityDetails", .action = "Index"}
       )

        routes.MapRoute(
           name:="ActivitySubCategories",
           url:="UserAccounts/ActivitySubCategories",
           defaults:=New With {.controller = "ActivitySubCategories", .action = "Index"}
       )

        routes.MapRoute(
            name:="Default",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "UserAccounts", .action = "Login", .id = UrlParameter.Optional}
        )
    End Sub
End Module