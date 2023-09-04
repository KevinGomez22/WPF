Imports System.Data
Imports Newtonsoft.Json


Public Class Form1

    Dim tabla As New DataTable
    Dim Dr As DataRow
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim api = New DBApi

        Dim persona = New Persona()
        persona.Nombre = TextBox1.Text

        Dim url = "https://jsonplaceholder.typicode.com/users"

        Dim headers = New List(Of Parametro) From {
        New Parametro("Authorizacion", "bearer asdasdas"),
        New Parametro("Cookie", "asdasdasdas")
        }
        Dim parametros = New List(Of Parametro)
        Dim response = api.MGet(url, headers, parametros, persona)
        Dim result = JsonConvert.DeserializeObject(Of respuesta)(response)


        Dim tabla As New DataTable
        Dim Dr As DataRow

        tabla.Columns.Add(New DataColumn("ID", GetType(String)))
        tabla.Columns.Add(New DataColumn("Nombre", GetType(String)))

        Dr = tabla.NewRow()
        Dr("ID") = result.id.ToString
        Dr("Nombre") = result.nombre.ToString
        tabla.Rows.Add(Dr)

        DataGridView1.DataSource = tabla
    End Sub
End Class

Public Class Persona
    Public Property Nombre As String
End Class

Class respuesta
    Public Property nombre As String
    Public Property username As String
    Public Property id As Integer
End Class