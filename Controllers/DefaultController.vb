Imports System.Web.Http
Imports System.ComponentModel.DataAnnotations

Namespace Controllers
    <RoutePrefix("api/todos")>
    Public Class DefaultController
        Inherits ApiController

        <HttpPost>
        <Route("add")>
        Public Function AddTodos(ByVal RequestBody As AddTodosInput)
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            Return New With {
                .status = "success",
                .count = RequestBody.Todos.Length
            }
        End Function

        Public Class AddTodosInput
            <Required>
            <MinLength(1)>
            Property Todos As AddTodosInputTodo()
        End Class

        Public Class AddTodosInputTodo
            <Required>
            Property Title As String
            <Required>
            <RegularExpression("\S+ \S+")>
            Property Asignee As String
        End Class
    End Class
End Namespace
