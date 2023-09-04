Imports System.Net
Imports RestSharp
Public Class DBApi
    Public Function MGet(url As String, headers As List(Of Parametro), parametros As List(Of Parametro), json As Object) As String
        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        Dim client = New RestClient(New Uri(url))

        Dim request = New RestRequest()
        request.Method = Method.Post

        For Each item As Parametro In headers
            request.AddHeader(item.Clave, item.Valor)
        Next

        For Each parametro As Parametro In parametros
            request.AddParameter(parametro.Clave, parametro.Valor)
        Next

        If (parametros.Count = 0) Then
            request.AddJsonBody(json)
        End If

        Dim response = client.Execute(request).Content.ToString
        Return response
    End Function
End Class

Public Class DBApi2
    Public Function MGet(url As String, headers As List(Of Parametro), parametros As List(Of Parametro), json As Object) As String
        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        Dim client = New RestClient(New Uri(url))

        Dim request = New RestRequest()
        request.Method = Method.Post

        For Each item As Parametro In headers
            request.AddHeader(item.Clave, item.Valor)
        Next

        For Each parametro As Parametro In parametros
            request.AddParameter(parametro.Clave, parametro.Valor)
        Next

        If (parametros.Count = 0) Then
            request.AddJsonBody(json)
        End If

        Dim response = client.Execute(request).Content.ToString
        Return response
    End Function
End Class
