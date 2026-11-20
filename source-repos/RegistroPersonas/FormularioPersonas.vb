Imports MySqlConnector

' Esta clase representa la ventana principal del registro de personas.
Public Class FormularioPersonas
    ' El repositorio contiene las consultas SQL de la tabla Alumnos.
    Private ReadOnly repositorio As New RepositorioAlumnos()
    ' Esta variable nos dice si la aplicación ya pudo conectarse.
    Private conectado As Boolean

    Public Sub New()
        ' Cargamos la ventana; la conexión se hace con el botón de arriba.
        InitializeComponent()
        ' Al inicio no permitimos el CRUD porque todavía no hay conexión.
        HabilitarBotones(False)
        ' El ID lo genera MySQL, por eso el usuario no lo escribe.
        cuadroId.Text = "(automático)"
    End Sub

    Private Sub ConectarBaseDatos(sender As Object, e As EventArgs) Handles botonConectar.Click
        Try
            ' Crea la base y las tablas si es la primera vez que se ejecuta.
            EsquemaBaseDatos.Preparar()
            ' Si no ocurrió una excepción, la conexión y las tablas están listas.
            conectado = True
            HabilitarBotones(True)
            ' Al conectarnos también mostramos los registros que ya existen.
            CargarPersonas()
            etiquetaEstado.Text = "Estado: conectado a MySQL y tablas listas."
            etiquetaEstado.ForeColor = System.Drawing.Color.DarkGreen
        Catch errorMySql As MySqlException
            ' Este bloque muestra los errores que vienen directamente de MySQL.
            conectado = False
            HabilitarBotones(False)
            etiquetaEstado.Text = "Estado: no se pudo conectar."
            etiquetaEstado.ForeColor = System.Drawing.Color.DarkRed
            MostrarError("MySQL respondió con un error:" & Environment.NewLine & errorMySql.Message)
        Catch errorGeneral As Exception
            ' Aquí entran otros errores que no son específicos de MySQL.
            conectado = False
            HabilitarBotones(False)
            etiquetaEstado.Text = "Estado: ocurrió un error."
            etiquetaEstado.ForeColor = System.Drawing.Color.DarkRed
            MostrarError("Ocurrió un error al preparar la base de datos:" & Environment.NewLine & errorGeneral.Message)
        End Try
    End Sub

    Private Sub CrearPersona(sender As Object, e As EventArgs) Handles botonCrear.Click
        ' Primero validamos la conexión y que los campos tengan información.
        If Not PuedeUsarLaBase() OrElse Not DatosCorrectos() Then
            Return
        End If

        Try
            ' Trim quita espacios al principio y al final antes de guardar.
            ' Convertimos la edad a número porque la columna Edad es de tipo INT.
            Dim edad As Integer = Convert.ToInt32(cuadroEdad.Text.Trim())
            ' El repositorio recibe todos los datos que se escribieron en el formulario.
            repositorio.Insertar(cuadroNombre.Text.Trim(), cuadroApellido.Text.Trim(), edad, cuadroCorreo.Text.Trim())
            ' Actualizamos la tabla para que se vea el nuevo registro.
            CargarPersonas()
            LimpiarCampos()
        Catch errorMySql As MySqlException
            MostrarError("No se pudo crear la persona:" & Environment.NewLine & errorMySql.Message)
        End Try
    End Sub

    Private Sub LeerPersona(sender As Object, e As EventArgs) Handles botonLeer.Click
        If Not PuedeUsarLaBase() Then
            Return
        End If

        ' Tomamos la fila que el usuario seleccionó en el DataGridView.
        Dim fila As DataGridViewRow = FilaSeleccionada()
        If fila Is Nothing Then
            MostrarAviso("Selecciona una persona de la tabla para leer sus datos.")
            Return
        End If

        ' Leer carga la fila seleccionada en los campos del formulario.
        cuadroId.Text = Convert.ToString(fila.Cells("columnaId").Value)
        cuadroNombre.Text = Convert.ToString(fila.Cells("columnaNombre").Value)
        cuadroApellido.Text = Convert.ToString(fila.Cells("columnaApellido").Value)
        ' Los dos campos nuevos también se cargan desde la fila seleccionada.
        cuadroEdad.Text = Convert.ToString(fila.Cells("columnaEdad").Value)
        cuadroCorreo.Text = Convert.ToString(fila.Cells("columnaCorreo").Value)
    End Sub

    Private Sub ActualizarPersona(sender As Object, e As EventArgs) Handles botonActualizar.Click
        ' Para actualizar necesitamos una conexión y datos nuevos válidos.
        If Not PuedeUsarLaBase() OrElse Not DatosCorrectos() Then
            Return
        End If

        Dim id As Integer
        ' TryParse convierte el texto del ID a número sin cerrar el programa si está mal escrito.
        If Not Integer.TryParse(cuadroId.Text, id) Then
            MostrarAviso("Primero selecciona una persona y presiona Leer.")
            Return
        End If

        Try
            ' El ID permanece igual; se actualizan los datos escritos en los campos.
            ' La edad se convierte otra vez a entero antes de enviarla a MySQL.
            Dim edad As Integer = Convert.ToInt32(cuadroEdad.Text.Trim())
            repositorio.Actualizar(id, cuadroNombre.Text.Trim(), cuadroApellido.Text.Trim(), edad, cuadroCorreo.Text.Trim())
            CargarPersonas()
            LimpiarCampos()
        Catch errorMySql As MySqlException
            MostrarError("No se pudo actualizar la persona:" & Environment.NewLine & errorMySql.Message)
        End Try
    End Sub

    Private Sub EliminarPersona(sender As Object, e As EventArgs) Handles botonEliminar.Click
        If Not PuedeUsarLaBase() Then
            Return
        End If

        ' Para eliminar usamos la fila seleccionada, porque de ahí obtenemos su ID.
        Dim fila As DataGridViewRow = FilaSeleccionada()
        If fila Is Nothing Then
            MostrarAviso("Selecciona una persona de la tabla para eliminarla.")
            Return
        End If

        Dim id As Integer
        If Not Integer.TryParse(Convert.ToString(fila.Cells("columnaId").Value), id) Then
            MostrarAviso("No se pudo leer el ID de la persona.")
            Return
        End If

        Dim nombre As String = Convert.ToString(fila.Cells("columnaNombre").Value)
        Dim apellido As String = Convert.ToString(fila.Cells("columnaApellido").Value)
        ' Pedimos confirmación para no borrar un registro por accidente.
        Dim respuesta As DialogResult = MessageBox.Show(
            Me,
            $"¿Quieres eliminar a {nombre} {apellido}?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If respuesta <> DialogResult.Yes Then
            Return
        End If

        Try
            repositorio.Eliminar(id)
            CargarPersonas()
            LimpiarCampos()
        Catch errorMySql As MySqlException
            MostrarError("No se pudo eliminar la persona:" & Environment.NewLine & errorMySql.Message)
        End Try
    End Sub

    Private Sub CargarPersonas()
        ' Si todavía no hay conexión, no intentamos consultar la base.
        If Not conectado Then
            Return
        End If

        Try
            ' DataSource enlaza la lista que devuelve el repositorio con la tabla visual.
            tablaPersonas.DataSource = repositorio.ObtenerTodos()
            ' Quitamos la selección para que el usuario elija una fila conscientemente.
            tablaPersonas.ClearSelection()
        Catch errorMySql As MySqlException
            MostrarError("No se pudo leer la tabla de alumnos:" & Environment.NewLine & errorMySql.Message)
        End Try
    End Sub

    Private Function FilaSeleccionada() As DataGridViewRow
        ' CurrentRow es la fila que está marcada en el control.
        ' La fila nueva vacía no cuenta como una persona registrada.
        If tablaPersonas.CurrentRow Is Nothing OrElse tablaPersonas.CurrentRow.IsNewRow Then
            Return Nothing
        End If

        Return tablaPersonas.CurrentRow
    End Function

    Private Function DatosCorrectos() As Boolean
        ' No dejamos guardar una persona sin nombre.
        If String.IsNullOrWhiteSpace(cuadroNombre.Text) Then
            MostrarAviso("Escribe el nombre de la persona.")
            cuadroNombre.Focus()
            Return False
        End If

        ' Tampoco dejamos guardar una persona sin apellido.
        If String.IsNullOrWhiteSpace(cuadroApellido.Text) Then
            MostrarAviso("Escribe el apellido de la persona.")
            cuadroApellido.Focus()
            Return False
        End If

        ' La edad se guarda como número entero y debe ser mayor que cero.
        Dim edad As Integer
        If Not Integer.TryParse(cuadroEdad.Text.Trim(), edad) OrElse edad <= 0 Then
            MostrarAviso("Escribe una edad válida.")
            cuadroEdad.Focus()
            Return False
        End If

        ' Para este ejercicio basta con comprobar que el correo no quede vacío.
        If String.IsNullOrWhiteSpace(cuadroCorreo.Text) Then
            MostrarAviso("Escribe el correo de la persona.")
            cuadroCorreo.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function PuedeUsarLaBase() As Boolean
        ' Esta función se usa antes de cada operación para revisar el estado de la conexión.
        If conectado Then
            Return True
        End If

        MostrarAviso("Primero presiona Conectar / crear tablas.")
        Return False
    End Function

    Private Sub HabilitarBotones(habilitar As Boolean)
        ' Los cuatro botones dependen de que MySQL esté disponible.
        botonCrear.Enabled = habilitar
        botonLeer.Enabled = habilitar
        botonActualizar.Enabled = habilitar
        botonEliminar.Enabled = habilitar
    End Sub

    Private Sub MostrarAviso(mensaje As String)
        ' Método pequeño para mostrar mensajes de validación al usuario.
        MessageBox.Show(Me, mensaje, "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub MostrarError(mensaje As String)
        ' Método reutilizable para mostrar errores de conexión o de consultas.
        MessageBox.Show(Me, mensaje, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub LimpiarCampos()
        ' Después de guardar, editar o eliminar dejamos el formulario listo para otra operación.
        cuadroId.Text = "(automático)"
        cuadroNombre.Clear()
        cuadroApellido.Clear()
        cuadroEdad.Clear()
        cuadroCorreo.Clear()
        tablaPersonas.ClearSelection()
        cuadroNombre.Focus()
    End Sub
End Class
