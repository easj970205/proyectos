Imports MySqlConnector

' Aquí se concentran los datos de conexión para no repetirlos en todo el programa.
Public Module ConfiguracionBaseDatos
    ' Cambia estos datos si tu instalación de MySQL usa otros valores.
    Public Const Servidor As String = "localhost"
    Public Const Puerto As UInteger = 3306
    Public Const Usuario As String = "root"
    Public Const Contrasena As String = ""
    Public Const NombreBaseDatos As String = "Escuela"

    Public Function CrearCadena(incluirBase As Boolean) As String
        ' MySqlConnector arma la cadena con los datos de la conexión.
        ' incluirBase indica si también agregamos el nombre de la base de datos.
        ' Estos valores corresponden al MySQL instalado en la computadora.
        Dim constructor As New MySqlConnectionStringBuilder With {
            .Server = Servidor,
            .Port = Puerto,
            .UserID = Usuario,
            .Password = Contrasena,
            .ConnectionTimeout = 5
        }

        If incluirBase Then
            ' Para crear la base no se incluye este dato; después sí se selecciona Escuela.
            constructor.Database = NombreBaseDatos
        End If

        ' ConnectionString devuelve todo en el formato que entiende MySqlConnection.
        Return constructor.ConnectionString
    End Function
End Module
