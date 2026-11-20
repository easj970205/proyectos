<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioPersonas
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Private etiquetaTitulo As System.Windows.Forms.Label
    Private etiquetaIndicacion As System.Windows.Forms.Label
    Private WithEvents botonConectar As System.Windows.Forms.Button
    Private etiquetaEstado As System.Windows.Forms.Label
    Private etiquetaId As System.Windows.Forms.Label
    Private cuadroId As System.Windows.Forms.TextBox
    Private etiquetaNombre As System.Windows.Forms.Label
    Private cuadroNombre As System.Windows.Forms.TextBox
    Private etiquetaApellido As System.Windows.Forms.Label
    Private cuadroApellido As System.Windows.Forms.TextBox
    Private etiquetaEdad As System.Windows.Forms.Label
    Private cuadroEdad As System.Windows.Forms.TextBox
    Private etiquetaCorreo As System.Windows.Forms.Label
    Private cuadroCorreo As System.Windows.Forms.TextBox
    Private WithEvents botonCrear As System.Windows.Forms.Button
    Private WithEvents botonLeer As System.Windows.Forms.Button
    Private WithEvents botonActualizar As System.Windows.Forms.Button
    Private WithEvents botonEliminar As System.Windows.Forms.Button
    Private etiquetaLista As System.Windows.Forms.Label
    Private tablaPersonas As System.Windows.Forms.DataGridView
    Private columnaId As System.Windows.Forms.DataGridViewTextBoxColumn
    Private columnaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Private columnaApellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Private columnaEdad As System.Windows.Forms.DataGridViewTextBoxColumn
    Private columnaCorreo As System.Windows.Forms.DataGridViewTextBoxColumn

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        etiquetaTitulo = New System.Windows.Forms.Label()
        etiquetaIndicacion = New System.Windows.Forms.Label()
        botonConectar = New System.Windows.Forms.Button()
        etiquetaEstado = New System.Windows.Forms.Label()
        etiquetaId = New System.Windows.Forms.Label()
        cuadroId = New System.Windows.Forms.TextBox()
        etiquetaNombre = New System.Windows.Forms.Label()
        cuadroNombre = New System.Windows.Forms.TextBox()
        etiquetaApellido = New System.Windows.Forms.Label()
        cuadroApellido = New System.Windows.Forms.TextBox()
        etiquetaEdad = New System.Windows.Forms.Label()
        cuadroEdad = New System.Windows.Forms.TextBox()
        etiquetaCorreo = New System.Windows.Forms.Label()
        cuadroCorreo = New System.Windows.Forms.TextBox()
        botonCrear = New System.Windows.Forms.Button()
        botonLeer = New System.Windows.Forms.Button()
        botonActualizar = New System.Windows.Forms.Button()
        botonEliminar = New System.Windows.Forms.Button()
        etiquetaLista = New System.Windows.Forms.Label()
        tablaPersonas = New System.Windows.Forms.DataGridView()
        columnaId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        columnaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        columnaApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        columnaEdad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        columnaCorreo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(tablaPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        etiquetaTitulo.AutoSize = True
        etiquetaTitulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        etiquetaTitulo.Location = New System.Drawing.Point(30, 22)
        etiquetaTitulo.Name = "etiquetaTitulo"
        etiquetaTitulo.Size = New System.Drawing.Size(254, 37)
        etiquetaTitulo.TabIndex = 0
        etiquetaTitulo.Text = "Registro de personas"

        etiquetaIndicacion.AutoSize = True
        etiquetaIndicacion.Location = New System.Drawing.Point(33, 69)
        etiquetaIndicacion.Name = "etiquetaIndicacion"
        etiquetaIndicacion.Size = New System.Drawing.Size(468, 15)
        etiquetaIndicacion.TabIndex = 1
        etiquetaIndicacion.Text = "Conecta MySQL y usa los botones para trabajar con la tabla de alumnos."

        botonConectar.Location = New System.Drawing.Point(535, 25)
        botonConectar.Name = "botonConectar"
        botonConectar.Size = New System.Drawing.Size(190, 38)
        botonConectar.TabIndex = 0
        botonConectar.Text = "Conectar / crear tablas"
        botonConectar.UseVisualStyleBackColor = True

        etiquetaEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        etiquetaEstado.ForeColor = System.Drawing.SystemColors.GrayText
        etiquetaEstado.Location = New System.Drawing.Point(33, 94)
        etiquetaEstado.Name = "etiquetaEstado"
        etiquetaEstado.Size = New System.Drawing.Size(692, 32)
        etiquetaEstado.TabIndex = 2
        etiquetaEstado.Text = "Estado: sin conexión. Pulsa Conectar / crear tablas."
        etiquetaEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

        etiquetaId.AutoSize = True
        etiquetaId.Location = New System.Drawing.Point(45, 161)
        etiquetaId.Name = "etiquetaId"
        etiquetaId.Size = New System.Drawing.Size(21, 15)
        etiquetaId.TabIndex = 3
        etiquetaId.Text = "ID:"

        cuadroId.BackColor = System.Drawing.SystemColors.Control
        cuadroId.Location = New System.Drawing.Point(105, 157)
        cuadroId.Name = "cuadroId"
        cuadroId.ReadOnly = True
        cuadroId.Size = New System.Drawing.Size(95, 23)
        cuadroId.TabIndex = 1

        etiquetaNombre.AutoSize = True
        etiquetaNombre.Location = New System.Drawing.Point(235, 161)
        etiquetaNombre.Name = "etiquetaNombre"
        etiquetaNombre.Size = New System.Drawing.Size(55, 15)
        etiquetaNombre.TabIndex = 4
        etiquetaNombre.Text = "Nombre:"

        cuadroNombre.Location = New System.Drawing.Point(295, 157)
        cuadroNombre.Name = "cuadroNombre"
        cuadroNombre.Size = New System.Drawing.Size(175, 23)
        cuadroNombre.TabIndex = 2

        etiquetaEdad.AutoSize = True
        etiquetaEdad.Location = New System.Drawing.Point(490, 161)
        etiquetaEdad.Name = "etiquetaEdad"
        etiquetaEdad.Size = New System.Drawing.Size(34, 15)
        etiquetaEdad.TabIndex = 5
        etiquetaEdad.Text = "Edad:"

        cuadroEdad.Location = New System.Drawing.Point(545, 157)
        cuadroEdad.MaxLength = 3
        cuadroEdad.Name = "cuadroEdad"
        cuadroEdad.Size = New System.Drawing.Size(70, 23)
        cuadroEdad.TabIndex = 3

        etiquetaApellido.AutoSize = True
        etiquetaApellido.Location = New System.Drawing.Point(45, 201)
        etiquetaApellido.Name = "etiquetaApellido"
        etiquetaApellido.Size = New System.Drawing.Size(57, 15)
        etiquetaApellido.TabIndex = 5
        etiquetaApellido.Text = "Apellido:"

        cuadroApellido.Location = New System.Drawing.Point(105, 197)
        cuadroApellido.Name = "cuadroApellido"
        cuadroApellido.Size = New System.Drawing.Size(365, 23)
        cuadroApellido.TabIndex = 4

        etiquetaCorreo.AutoSize = True
        etiquetaCorreo.Location = New System.Drawing.Point(490, 201)
        etiquetaCorreo.Name = "etiquetaCorreo"
        etiquetaCorreo.Size = New System.Drawing.Size(48, 15)
        etiquetaCorreo.TabIndex = 6
        etiquetaCorreo.Text = "Correo:"

        cuadroCorreo.Location = New System.Drawing.Point(545, 197)
        cuadroCorreo.MaxLength = 150
        cuadroCorreo.Name = "cuadroCorreo"
        cuadroCorreo.Size = New System.Drawing.Size(180, 23)
        cuadroCorreo.TabIndex = 5

        botonCrear.Location = New System.Drawing.Point(45, 245)
        botonCrear.Name = "botonCrear"
        botonCrear.Size = New System.Drawing.Size(105, 38)
        botonCrear.TabIndex = 6
        botonCrear.Text = "Crear"
        botonCrear.UseVisualStyleBackColor = True

        botonLeer.Location = New System.Drawing.Point(165, 245)
        botonLeer.Name = "botonLeer"
        botonLeer.Size = New System.Drawing.Size(105, 38)
        botonLeer.TabIndex = 7
        botonLeer.Text = "Leer"
        botonLeer.UseVisualStyleBackColor = True

        botonActualizar.Location = New System.Drawing.Point(285, 245)
        botonActualizar.Name = "botonActualizar"
        botonActualizar.Size = New System.Drawing.Size(105, 38)
        botonActualizar.TabIndex = 8
        botonActualizar.Text = "Actualizar"
        botonActualizar.UseVisualStyleBackColor = True

        botonEliminar.Location = New System.Drawing.Point(405, 245)
        botonEliminar.Name = "botonEliminar"
        botonEliminar.Size = New System.Drawing.Size(105, 38)
        botonEliminar.TabIndex = 9
        botonEliminar.Text = "Eliminar"
        botonEliminar.UseVisualStyleBackColor = True

        etiquetaLista.AutoSize = True
        etiquetaLista.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        etiquetaLista.Location = New System.Drawing.Point(45, 315)
        etiquetaLista.Name = "etiquetaLista"
        etiquetaLista.Size = New System.Drawing.Size(157, 19)
        etiquetaLista.TabIndex = 8
        etiquetaLista.Text = "Personas registradas"

        tablaPersonas.AllowUserToAddRows = False
        tablaPersonas.AllowUserToDeleteRows = False
        tablaPersonas.AllowUserToResizeRows = False
        tablaPersonas.AutoGenerateColumns = False
        tablaPersonas.BackgroundColor = System.Drawing.SystemColors.Window
        tablaPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tablaPersonas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {columnaId, columnaNombre, columnaApellido, columnaEdad, columnaCorreo})
        tablaPersonas.Location = New System.Drawing.Point(45, 345)
        tablaPersonas.MultiSelect = False
        tablaPersonas.Name = "tablaPersonas"
        tablaPersonas.ReadOnly = True
        tablaPersonas.RowHeadersVisible = False
        tablaPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        tablaPersonas.Size = New System.Drawing.Size(665, 190)
        tablaPersonas.TabIndex = 9

        columnaId.DataPropertyName = "id_alumno"
        columnaId.HeaderText = "ID"
        columnaId.Name = "columnaId"
        columnaId.ReadOnly = True
        columnaId.Width = 55

        columnaNombre.DataPropertyName = "nombre"
        columnaNombre.HeaderText = "Nombre"
        columnaNombre.Name = "columnaNombre"
        columnaNombre.ReadOnly = True
        columnaNombre.Width = 170

        columnaApellido.DataPropertyName = "apellido"
        columnaApellido.HeaderText = "Apellido"
        columnaApellido.Name = "columnaApellido"
        columnaApellido.ReadOnly = True
        columnaApellido.Width = 180

        columnaEdad.DataPropertyName = "edad"
        columnaEdad.HeaderText = "Edad"
        columnaEdad.Name = "columnaEdad"
        columnaEdad.ReadOnly = True
        columnaEdad.Width = 55

        columnaCorreo.DataPropertyName = "correo"
        columnaCorreo.HeaderText = "Correo"
        columnaCorreo.Name = "columnaCorreo"
        columnaCorreo.ReadOnly = True
        columnaCorreo.Width = 195

        AcceptButton = botonCrear
        AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(760, 575)
        Controls.Add(tablaPersonas)
        Controls.Add(etiquetaLista)
        Controls.Add(botonEliminar)
        Controls.Add(botonActualizar)
        Controls.Add(botonLeer)
        Controls.Add(botonCrear)
        Controls.Add(cuadroCorreo)
        Controls.Add(etiquetaCorreo)
        Controls.Add(cuadroApellido)
        Controls.Add(etiquetaApellido)
        Controls.Add(cuadroEdad)
        Controls.Add(etiquetaEdad)
        Controls.Add(cuadroNombre)
        Controls.Add(etiquetaNombre)
        Controls.Add(cuadroId)
        Controls.Add(etiquetaId)
        Controls.Add(etiquetaEstado)
        Controls.Add(botonConectar)
        Controls.Add(etiquetaIndicacion)
        Controls.Add(etiquetaTitulo)
        Font = New System.Drawing.Font("Segoe UI", 9.0!)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FormularioPersonas"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Registro de personas - MySQL"
        CType(tablaPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
End Class
