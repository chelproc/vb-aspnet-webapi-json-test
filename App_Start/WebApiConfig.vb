Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http

Public Module WebApiConfig
    Public Sub Register(ByVal config As HttpConfiguration)
        ' Web API の設定およびサービス
        config.Formatters.Remove(config.Formatters.XmlFormatter)
        config.Formatters.Add(config.Formatters.JsonFormatter)

        ' Web API ルート
        config.MapHttpAttributeRoutes()
    End Sub
End Module
