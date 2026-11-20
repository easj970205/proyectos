Imports MySqlConnector

Namespace RegistroEscuela
    ' Este módulo concentra las funciones que usan la conexión con MySQL.
    Friend Module Database
        ' Esta conexión se usa para entrar al servidor sin seleccionar una base de datos.
        ' Es necesaria porque la base Escuela podría no existir todavía.
        Private Const ServerConnectionString As String =
            "Server=localhost;Port=3306;User ID=root;Password=;Connection Timeout=5;"

        ' Esta conexión ya apunta a la base de datos que usa el proyecto.
        Private Const ConnectionString As String =
            "Server=localhost;Port=3306;User ID=root;Password=;Database=Escuela;Connection Timeout=5;"

        ' Abre y devuelve una conexión lista para trabajar con la base Escuela.
        Friend Function OpenConnection() As MySqlConnection
            Dim connection As New MySqlConnection(ConnectionString)
            connection.Open()
            Return connection
        End Function

        ' Crea la base de datos y la tabla Carreras si todavía no existen.
        Friend Sub EnsureTable()
            ' Primero nos conectamos solamente al servidor.
            Using connection As New MySqlConnection(ServerConnectionString)
                connection.Open()
                ' IF NOT EXISTS evita un error si la base ya fue creada anteriormente.
                Using command As New MySqlCommand(
                    "CREATE DATABASE IF NOT EXISTS Escuela CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;", connection)
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Ya con la base creada, abrimos una conexión seleccionando Escuela.
            Using connection = OpenConnection()
                ' La tabla almacena el nombre de la carrera y su número de alumnos.
                Using command As New MySqlCommand(
                    "CREATE TABLE IF NOT EXISTS Carreras (" &
                    "IdCarrera INT AUTO_INCREMENT PRIMARY KEY, " &
                    "Nombre VARCHAR(100) NOT NULL UNIQUE, " &
                    "NumeroAlumnos INT NOT NULL DEFAULT 0" &
                    ") ENGINE=InnoDB;", connection)
                    command.ExecuteNonQuery()
                End Using

                ' Si la tabla ya existía desde una versión anterior, revisamos si tiene la columna nueva.
                ' Así actualizamos la estructura sin borrar las carreras que ya estaban guardadas.
                Using checkColumn As New MySqlCommand(
                    "SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS " &
                    "WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'Carreras' AND COLUMN_NAME = 'NumeroAlumnos';", connection)
                    If Convert.ToInt32(checkColumn.ExecuteScalar()) = 0 Then
                        Using alterTable As New MySqlCommand(
                            "ALTER TABLE Carreras ADD COLUMN NumeroAlumnos INT NOT NULL DEFAULT 0;", connection)
                            alterTable.ExecuteNonQuery()
                        End Using
                    End If
                End Using
            End Using
        End Sub
    End Module
End Namespace
