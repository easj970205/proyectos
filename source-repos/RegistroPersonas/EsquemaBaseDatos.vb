Imports MySqlConnector

' Este módulo contiene las instrucciones para dejar preparada la base de datos.
' Así, el formulario no depende de que las tablas se creen manualmente.
Public Module EsquemaBaseDatos
    Public Sub Preparar()
        ' Primero creamos la base de datos si todavía no existe.
        ' En esta primera conexión todavía no usamos el nombre de la base.
        Using conexion As New MySqlConnection(ConfiguracionBaseDatos.CrearCadena(False))
            ' Open inicia la comunicación con el servidor de MySQL.
            conexion.Open()

            ' IF NOT EXISTS evita un error si Escuela ya fue creada anteriormente.
            Dim sqlBase As String = $"CREATE DATABASE IF NOT EXISTS `{ConfiguracionBaseDatos.NombreBaseDatos}` CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;"
            Using comando As New MySqlCommand(sqlBase, conexion)
                ' ExecuteNonQuery sirve para ejecutar instrucciones que no devuelven filas.
                comando.ExecuteNonQuery()
            End Using
        End Using

        ' Después nos conectamos directamente a la base Escuela.
        Using conexion As New MySqlConnection(ConfiguracionBaseDatos.CrearCadena(True))
            conexion.Open()

            ' Cada elemento del arreglo contiene un CREATE TABLE diferente.
            For Each sentencia As String In SentenciasTablas
                Using comando As New MySqlCommand(sentencia, conexion)
                    ' Se crea la tabla solo si todavía no existe.
                    comando.ExecuteNonQuery()
                End Using
            Next

            ' Si la tabla Alumnos ya existía con el ejercicio del profesor,
            ' agregamos las columnas que necesita esta interfaz.
            AsegurarColumna(conexion, "Alumnos", "Apellido", "VARCHAR(100) NULL")
            AsegurarColumna(conexion, "Alumnos", "IdCarrera", "INT NULL")
        End Using
    End Sub

    Private Sub AsegurarColumna(conexion As MySqlConnection, tabla As String, columna As String, definicion As String)
        ' Revisamos la estructura actual para poder trabajar con una tabla
        ' Alumnos que quizá ya había creado el profesor.
        Const sqlExiste As String = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS " &
                                    "WHERE TABLE_SCHEMA = @base AND TABLE_NAME = @tabla AND COLUMN_NAME = @columna;"

        Using comandoExiste As New MySqlCommand(sqlExiste, conexion)
            ' Los parámetros indican los valores que queremos buscar en MySQL.
            ' También ayudan a evitar errores al escribir los datos directamente en SQL.
            comandoExiste.Parameters.AddWithValue("@base", ConfiguracionBaseDatos.NombreBaseDatos)
            comandoExiste.Parameters.AddWithValue("@tabla", tabla)
            comandoExiste.Parameters.AddWithValue("@columna", columna)

            ' ExecuteScalar devuelve el primer valor encontrado: en este caso, la cantidad de columnas.
            Dim existe As Integer = Convert.ToInt32(comandoExiste.ExecuteScalar())
            If existe = 0 Then
                ' Si la columna no existe, la agregamos para que el formulario pueda usarla.
                Dim sqlAgregar As String = $"ALTER TABLE `{tabla}` ADD COLUMN `{columna}` {definicion};"
                Using comandoAgregar As New MySqlCommand(sqlAgregar, conexion)
                    comandoAgregar.ExecuteNonQuery()
                End Using
            End If
        End Using
    End Sub

    ' Estas sentencias representan las tablas básicas del proyecto escolar.
    ' Los campos Id... son claves principales y se incrementan automáticamente.
    Private ReadOnly SentenciasTablas As String() = {
        "CREATE TABLE IF NOT EXISTS Carreras (IdCarrera INT AUTO_INCREMENT PRIMARY KEY, Nombre VARCHAR(100) NOT NULL UNIQUE) ENGINE=InnoDB;",
        "CREATE TABLE IF NOT EXISTS Profesores (IdProfesor INT AUTO_INCREMENT PRIMARY KEY, Nombre VARCHAR(100) NOT NULL, Apellido VARCHAR(100) NOT NULL) ENGINE=InnoDB;",
        "CREATE TABLE IF NOT EXISTS Alumnos (IdAlumno INT AUTO_INCREMENT PRIMARY KEY, Nombre VARCHAR(100) NOT NULL, Apellido VARCHAR(100) NULL, Edad INT NULL, Correo VARCHAR(150) NULL, IdCarrera INT NULL) ENGINE=InnoDB;",
        "CREATE TABLE IF NOT EXISTS Materias (IdMateria INT AUTO_INCREMENT PRIMARY KEY, Nombre VARCHAR(100) NOT NULL, IdProfesor INT NULL, IdCarrera INT NULL) ENGINE=InnoDB;"
    }
End Module
