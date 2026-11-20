Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports MySqlConnector

Namespace RegistroEscuela
    ' Este es el formulario principal que el usuario ve al abrir el programa.
    Public Class MainForm
        Inherits Form

        ' Estos controles se declaran aquí para poder usarlos desde varios métodos.
        ' ReadOnly significa que la referencia no cambia, aunque el contenido sí pueda cambiar.
        Private ReadOnly txtId As New TextBox()
        Private ReadOnly txtNombre As New TextBox()
        Private ReadOnly nudAlumnos As New NumericUpDown()
        Private ReadOnly grid As New DataGridView()
        Private ReadOnly status As New Label()

        Public Sub New()
            ' Configuración básica de la ventana.
            Text = "RegistroEscuela - Carreras"
            StartPosition = FormStartPosition.CenterScreen
            MinimumSize = New Size(760, 500)
            Size = New Size(900, 600)
            ' Construimos la interfaz desde código, sin usar el diseñador visual.
            BuildInterface()
            ' Al abrir, el cursor queda listo en el campo donde se escribe la carrera.
            ActiveControl = txtNombre
            ' Mensaje inicial para orientar al usuario.
            SetStatus("Listo. Inicia MySQL y pulsa Conectar / crear tabla.")
        End Sub

        Private Sub BuildInterface()
            ' Colores y fuente general de la ventana.
            BackColor = Color.FromArgb(244, 246, 248)
            Font = New Font("Segoe UI", 10.0F)

            ' Título y texto de apoyo del formulario.
            Dim title As New Label With {.Text = "Registro de carreras", .Font = New Font("Segoe UI", 20.0F, FontStyle.Bold), .ForeColor = Color.FromArgb(31, 78, 121), .AutoSize = True, .Location = New Point(24, 18)}
            Controls.Add(title)
            Dim subtitle As New Label With {.Text = "Administra las carreras y la cantidad de alumnos inscritos.", .ForeColor = Color.FromArgb(90, 100, 110), .AutoSize = True, .Location = New Point(27, 54)}
            Controls.Add(subtitle)

            ' Panel para probar la conexión y preparar la base de datos.
            Dim connectionPanel As New Panel With {.Location = New Point(24, 82), .Size = New Size(830, 54), .BackColor = Color.FromArgb(226, 236, 247), .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right}
            Dim connectButton As New Button With {.Text = "Conectar / preparar", .Location = New Point(12, 10), .Size = New Size(180, 34)}
            StyleButton(connectButton, Color.FromArgb(31, 78, 121), Color.White)
            ' Cuando se presiona el botón, se ejecuta el método ConnectDatabase.
            AddHandler connectButton.Click, AddressOf ConnectDatabase
            connectionPanel.Controls.Add(connectButton)
            status.Text = "MySQL no verificado"
            status.AutoSize = True
            status.ForeColor = Color.FromArgb(70, 80, 90)
            status.Location = New Point(210, 18)
            connectionPanel.Controls.Add(status)
            Controls.Add(connectionPanel)

            ' Panel blanco que contiene los datos que se van a capturar.
            Dim formPanel As New Panel With {.Location = New Point(24, 154), .Size = New Size(830, 126), .BackColor = Color.White, .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right}
            Dim formCaption As New Label With {.Text = "Datos de la carrera", .Font = New Font("Segoe UI", 11.0F, FontStyle.Bold), .ForeColor = Color.FromArgb(45, 55, 65), .AutoSize = True, .Location = New Point(18, 12)}
            formPanel.Controls.Add(formCaption)
            AddField(formPanel, "ID carrera", txtId, 18, 40, 135)
            ' El ID lo genera MySQL automáticamente; el usuario no debe editarlo.
            ' Se habilita visualmente solo como campo informativo para mostrar una selección.
            txtId.ReadOnly = True
            txtId.Enabled = False
            AddField(formPanel, "Carrera", txtNombre, 185, 40, 310)
            AddField(formPanel, "Número de alumnos", nudAlumnos, 515, 40, 190)
            ' TabIndex define el orden en que se recorren los controles con la tecla Tab.
            txtNombre.TabIndex = 0
            nudAlumnos.TabIndex = 1
            txtId.TabIndex = 2
            nudAlumnos.Minimum = 0
            nudAlumnos.Maximum = 1000000
            Controls.Add(formPanel)

            ' Panel de botones para las operaciones del CRUD.
            Dim actionsCaption As New Label With {.Text = "Acciones", .Font = New Font("Segoe UI", 10.0F, FontStyle.Bold), .ForeColor = Color.FromArgb(45, 55, 65), .AutoSize = True, .Location = New Point(24, 300)}
            Controls.Add(actionsCaption)
            Dim buttons As New FlowLayoutPanel With {.Location = New Point(24, 326), .Size = New Size(830, 42), .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right, .FlowDirection = FlowDirection.LeftToRight, .WrapContents = False}
            ' Cada botón llama al método que realiza una operación específica en la base.
            Dim createButton = AddButton(buttons, "Crear carrera", AddressOf CreateRecord)
            StyleButton(createButton, Color.FromArgb(40, 130, 80), Color.White)
            Dim readButton = AddButton(buttons, "Cargar seleccionada", AddressOf ReadSelected)
            StyleButton(readButton, Color.FromArgb(31, 78, 121), Color.White)
            Dim updateButton = AddButton(buttons, "Actualizar", AddressOf UpdateRecord)
            StyleButton(updateButton, Color.FromArgb(218, 139, 18), Color.White)
            Dim deleteButton = AddButton(buttons, "Eliminar", AddressOf DeleteRecord)
            StyleButton(deleteButton, Color.FromArgb(180, 55, 55), Color.White)
            Dim clearButton = AddButton(buttons, "Limpiar", AddressOf ClearFields)
            StyleButton(clearButton, Color.White, Color.FromArgb(70, 80, 90))
            Controls.Add(buttons)

            ' La cuadrícula muestra los registros guardados en MySQL.
            Dim gridCaption As New Label With {.Text = "Carreras registradas", .Font = New Font("Segoe UI", 10.0F, FontStyle.Bold), .ForeColor = Color.FromArgb(45, 55, 65), .AutoSize = True, .Location = New Point(24, 382)}
            Controls.Add(gridCaption)
            grid.Location = New Point(24, 408)
            grid.Size = New Size(830, 190)
            grid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            grid.AllowUserToAddRows = False
            grid.ReadOnly = True
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            grid.MultiSelect = False
            ' Estas propiedades hacen que la tabla sea de consulta y tenga un estilo más claro.
            grid.BackgroundColor = Color.White
            grid.BorderStyle = BorderStyle.FixedSingle
            grid.GridColor = Color.FromArgb(220, 225, 230)
            grid.RowHeadersVisible = False
            grid.EnableHeadersVisualStyles = False
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 78, 121)
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            grid.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            grid.ColumnHeadersHeight = 34
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(205, 225, 244)
            grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 40, 50)
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(246, 248, 250)
            AddHandler grid.CellDoubleClick, AddressOf Grid_CellDoubleClick
            Controls.Add(grid)
        End Sub

        ' Agrega una etiqueta y su control de entrada en una posición determinada.
        Private Shared Sub AddField(panel As Panel, caption As String, control As Control, x As Integer, y As Integer, width As Integer)
            Dim label As New Label With {.Text = caption, .AutoSize = True, .Location = New Point(x, y)}
            panel.Controls.Add(label)
            control.Location = New Point(x, y + 22)
            control.Size = New Size(width, 28)
            panel.Controls.Add(control)
        End Sub

        ' Crea un botón, le asigna el evento Click y lo agrega al panel de acciones.
        Private Shared Function AddButton(panel As FlowLayoutPanel, caption As String, handler As EventHandler) As Button
            Dim button As New Button With {.Text = caption, .AutoSize = False, .Width = 145, .Height = 34, .Margin = New Padding(0, 0, 10, 0)}
            AddHandler button.Click, handler
            panel.Controls.Add(button)
            Return button
        End Function

        ' Aplica colores y formato común a los botones para que la interfaz sea consistente.
        Private Shared Sub StyleButton(button As Button, backColor As Color, foreColor As Color)
            button.BackColor = backColor
            button.ForeColor = foreColor
            button.FlatStyle = FlatStyle.Flat
            button.FlatAppearance.BorderSize = If(backColor = Color.White, 1, 0)
            button.FlatAppearance.BorderColor = Color.FromArgb(190, 198, 206)
            button.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        End Sub

        ' Prepara la base de datos y carga los registros existentes.
        Private Sub ConnectDatabase(sender As Object, e As EventArgs)
            Try
                Database.EnsureTable()
                LoadData()
                SetStatus("Conexión correcta y tabla Carreras preparada.")
            Catch ex As Exception
                ShowError(ex)
            End Try
        End Sub

        ' Consulta todas las carreras y las muestra en el DataGridView.
        Private Sub LoadData()
            Try
                Using connection = Database.OpenConnection()
                    Using command As New MySqlCommand("SELECT IdCarrera, Nombre, NumeroAlumnos FROM Carreras ORDER BY Nombre;", connection)
                        Using adapter As New MySqlDataAdapter(command)
                            Dim table As New DataTable()
                            ' Fill copia el resultado de MySQL a una tabla que entiende el control visual.
                            adapter.Fill(table)
                            grid.DataSource = table
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                SetStatus("No se pudo cargar la información. Verifica MySQL y pulsa Conectar.")
            End Try
        End Sub

        ' CREATE del CRUD: inserta una carrera nueva.
        Private Sub CreateRecord(sender As Object, e As EventArgs)
            ' Validamos que el usuario no intente guardar un nombre vacío.
            If String.IsNullOrWhiteSpace(txtNombre.Text) Then
                MessageBox.Show("Escribe el nombre de la carrera.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Try
                ' Using cierra la conexión y el comando automáticamente al terminar.
                Using connection = Database.OpenConnection()
                    ' Los parámetros evitan concatenar directamente el texto del usuario en SQL.
                    Using command As New MySqlCommand("INSERT INTO Carreras (Nombre, NumeroAlumnos) VALUES (@nombre, @alumnos);", connection)
                        command.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim())
                        command.Parameters.AddWithValue("@alumnos", CInt(nudAlumnos.Value))
                        command.ExecuteNonQuery()
                        ' MySQL devuelve el ID AUTO_INCREMENT que acaba de generar.
                        txtId.Text = command.LastInsertedId.ToString()
                    End Using
                End Using
                LoadData()
                ' Conservamos los datos visibles para que el usuario pueda ver el registro creado.
                SetStatus($"Carrera creada correctamente. ID asignado: {txtId.Text}.")
            Catch ex As Exception
                ShowError(ex)
            End Try
        End Sub

        ' READ del CRUD: carga en los controles la fila seleccionada.
        Private Sub ReadSelected(sender As Object, e As EventArgs)
            If grid.CurrentRow Is Nothing Then Return
            txtId.Text = grid.CurrentRow.Cells("IdCarrera").Value.ToString()
            txtNombre.Text = grid.CurrentRow.Cells("Nombre").Value.ToString()
            nudAlumnos.Value = Convert.ToDecimal(grid.CurrentRow.Cells("NumeroAlumnos").Value)
            SetStatus("Registro cargado para consulta o edición.")
        End Sub

        ' También permitimos cargar un registro haciendo doble clic sobre una fila.
        Private Sub Grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
            If e.RowIndex >= 0 Then ReadSelected(sender, EventArgs.Empty)
        End Sub

        ' UPDATE del CRUD: modifica el nombre o el número de alumnos de una carrera.
        Private Sub UpdateRecord(sender As Object, e As EventArgs)
            Dim id As Integer
            If Not Integer.TryParse(txtId.Text, id) Then
                MessageBox.Show("Selecciona primero una carrera.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Try
                Using connection = Database.OpenConnection()
                    Using command As New MySqlCommand("UPDATE Carreras SET Nombre=@nombre, NumeroAlumnos=@alumnos WHERE IdCarrera=@id;", connection)
                        command.Parameters.AddWithValue("@id", id)
                        command.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim())
                        command.Parameters.AddWithValue("@alumnos", CInt(nudAlumnos.Value))
                        command.ExecuteNonQuery()
                    End Using
                End Using
                LoadData()
                SetStatus("Carrera actualizada correctamente.")
            Catch ex As Exception
                ShowError(ex)
            End Try
        End Sub

        ' DELETE del CRUD: elimina la carrera seleccionada después de pedir confirmación.
        Private Sub DeleteRecord(sender As Object, e As EventArgs)
            Dim id As Integer
            If Not Integer.TryParse(txtId.Text, id) Then
                MessageBox.Show("Selecciona primero una carrera.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If MessageBox.Show("¿Eliminar la carrera seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            Try
                Using connection = Database.OpenConnection()
                    Using command As New MySqlCommand("DELETE FROM Carreras WHERE IdCarrera=@id;", connection)
                        command.Parameters.AddWithValue("@id", id)
                        command.ExecuteNonQuery()
                    End Using
                End Using
                LoadData()
                ClearFields(Nothing, EventArgs.Empty)
                SetStatus("Carrera eliminada correctamente.")
            Catch ex As Exception
                ShowError(ex)
            End Try
        End Sub

        ' Limpia los campos para poder capturar una carrera nueva.
        Private Sub ClearFields(sender As Object, e As EventArgs)
            txtId.Clear()
            txtNombre.Clear()
            nudAlumnos.Value = 0
            grid.ClearSelection()
        End Sub

        ' Cambia el texto de estado que aparece en el panel de conexión.
        Private Sub SetStatus(message As String)
            status.Text = message
        End Sub

        ' Muestra los errores en pantalla para que el usuario sepa qué ocurrió.
        Private Sub ShowError(ex As Exception)
            ' Mostramos una descripción corta también en la barra de estado.
            SetStatus("Error: " & ex.Message)
            MessageBox.Show(ex.Message, "RegistroEscuela", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub
    End Class
End Namespace
'Rev. Luis Alberto Luna Hernandez'
'Calif: 100'
