Imports System.Data
Imports MySqlConnector

Public Class RepositorioAlumnos
    Public Function ObtenerTodos() As DataTable
        Dim tabla As New DataTable()

        Using conexion As New MySqlConnection(ConfiguracionBaseDatos.CrearCadena(True))
            conexion.Open()

            ' La consulta trae las cinco columnas que se muestran en la tabla del formulario.
            Const sql As String = "SELECT IdAlumno AS id_alumno, Nombre AS nombre, Apellido AS apellido, Edad AS edad, Correo AS correo FROM Alumnos ORDER BY IdAlumno;"
            Using comando As New MySqlCommand(sql, conexion)
                Using lector As MySqlDataReader = comando.ExecuteReader()
                    tabla.Load(lector)
                End Using
            End Using
        End Using

        Return tabla
    End Function

    Public Sub Insertar(nombre As String, apellido As String, edad As Integer, correo As String)
        ' Los valores se mandan como parámetros para que MySQL los guarde correctamente.
        Const sql As String = "INSERT INTO Alumnos (Nombre, Apellido, Edad, Correo) VALUES (@nombre, @apellido, @edad, @correo);"

        Using conexion As New MySqlConnection(ConfiguracionBaseDatos.CrearCadena(True))
            conexion.Open()
            Using comando As New MySqlCommand(sql, conexion)
                comando.Parameters.AddWithValue("@nombre", nombre)
                comando.Parameters.AddWithValue("@apellido", apellido)
                comando.Parameters.AddWithValue("@edad", edad)
                comando.Parameters.AddWithValue("@correo", correo)
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Actualizar(id As Integer, nombre As String, apellido As String, edad As Integer, correo As String)
        ' El ID se usa para encontrar el registro; los demás datos sí pueden cambiar.
        Const sql As String = "UPDATE Alumnos SET Nombre = @nombre, Apellido = @apellido, Edad = @edad, Correo = @correo WHERE IdAlumno = @id;"

        Using conexion As New MySqlConnection(ConfiguracionBaseDatos.CrearCadena(True))
            conexion.Open()
            Using comando As New MySqlCommand(sql, conexion)
                comando.Parameters.AddWithValue("@id", id)
                comando.Parameters.AddWithValue("@nombre", nombre)
                comando.Parameters.AddWithValue("@apellido", apellido)
                comando.Parameters.AddWithValue("@edad", edad)
                comando.Parameters.AddWithValue("@correo", correo)
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Eliminar(id As Integer)
        Const sql As String = "DELETE FROM Alumnos WHERE IdAlumno = @id;"

        Using conexion As New MySqlConnection(ConfiguracionBaseDatos.CrearCadena(True))
            conexion.Open()
            Using comando As New MySqlCommand(sql, conexion)
                comando.Parameters.AddWithValue("@id", id)
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
