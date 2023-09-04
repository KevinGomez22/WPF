
Public Class Conexiones
    Dim Conexion As String = "CATBLACK01\LOCALDB#3B4E5F36 (CATBLACK01\gioke)"
    Public cnn As String = Conexion
    Public User As String
    Public Departamento As String
    Public Fecha As Date = Format(Now.Date, "dd-MMM-yy")
    Public Admin As String
    Public NivelAutorizado As Integer

End Class
