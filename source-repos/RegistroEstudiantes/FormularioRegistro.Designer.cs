namespace RegistroEstudiantes;

partial class FormularioRegistro
{
    private System.Windows.Forms.Label etiquetaTitulo = null!;
    private System.Windows.Forms.Label etiquetaIndicacion = null!;
    private System.Windows.Forms.GroupBox grupoDatos = null!;
    private System.Windows.Forms.Label etiquetaNombre = null!;
    private System.Windows.Forms.TextBox cuadroNombre = null!;
    private System.Windows.Forms.Label etiquetaNota1 = null!;
    private System.Windows.Forms.TextBox cuadroNota1 = null!;
    private System.Windows.Forms.Label etiquetaNota2 = null!;
    private System.Windows.Forms.TextBox cuadroNota2 = null!;
    private System.Windows.Forms.Label etiquetaNota3 = null!;
    private System.Windows.Forms.TextBox cuadroNota3 = null!;
    private System.Windows.Forms.Label etiquetaNota4 = null!;
    private System.Windows.Forms.TextBox cuadroNota4 = null!;
    private System.Windows.Forms.Button botonAgregar = null!;
    private System.Windows.Forms.Button botonLimpiar = null!;
    private System.Windows.Forms.GroupBox grupoAlumnos = null!;
    private System.Windows.Forms.ListBox listaAlumnos = null!;
    private System.Windows.Forms.Label etiquetaCantidad = null!;

    private void InitializeComponent()
    {
        etiquetaTitulo = new System.Windows.Forms.Label();
        etiquetaIndicacion = new System.Windows.Forms.Label();
        grupoDatos = new System.Windows.Forms.GroupBox();
        etiquetaNombre = new System.Windows.Forms.Label();
        cuadroNombre = new System.Windows.Forms.TextBox();
        etiquetaNota1 = new System.Windows.Forms.Label();
        cuadroNota1 = new System.Windows.Forms.TextBox();
        etiquetaNota2 = new System.Windows.Forms.Label();
        cuadroNota2 = new System.Windows.Forms.TextBox();
        etiquetaNota3 = new System.Windows.Forms.Label();
        cuadroNota3 = new System.Windows.Forms.TextBox();
        etiquetaNota4 = new System.Windows.Forms.Label();
        cuadroNota4 = new System.Windows.Forms.TextBox();
        botonAgregar = new System.Windows.Forms.Button();
        botonLimpiar = new System.Windows.Forms.Button();
        grupoAlumnos = new System.Windows.Forms.GroupBox();
        listaAlumnos = new System.Windows.Forms.ListBox();
        etiquetaCantidad = new System.Windows.Forms.Label();
        grupoDatos.SuspendLayout();
        grupoAlumnos.SuspendLayout();
        SuspendLayout();

        etiquetaTitulo.AutoSize = true;
        etiquetaTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        etiquetaTitulo.Location = new System.Drawing.Point(30, 22);
        etiquetaTitulo.Name = "etiquetaTitulo";
        etiquetaTitulo.Size = new System.Drawing.Size(258, 37);
        etiquetaTitulo.TabIndex = 0;
        etiquetaTitulo.Text = "Registro de alumnos";

        etiquetaIndicacion.AutoSize = true;
        etiquetaIndicacion.Location = new System.Drawing.Point(33, 68);
        etiquetaIndicacion.Name = "etiquetaIndicacion";
        etiquetaIndicacion.Size = new System.Drawing.Size(402, 15);
        etiquetaIndicacion.TabIndex = 1;
        etiquetaIndicacion.Text = "Escribe el nombre y sus notas. Puedes agregar varios alumnos.";

        grupoDatos.Controls.Add(etiquetaNombre);
        grupoDatos.Controls.Add(cuadroNombre);
        grupoDatos.Controls.Add(etiquetaNota1);
        grupoDatos.Controls.Add(cuadroNota1);
        grupoDatos.Controls.Add(etiquetaNota2);
        grupoDatos.Controls.Add(cuadroNota2);
        grupoDatos.Controls.Add(etiquetaNota3);
        grupoDatos.Controls.Add(cuadroNota3);
        grupoDatos.Controls.Add(etiquetaNota4);
        grupoDatos.Controls.Add(cuadroNota4);
        grupoDatos.Controls.Add(botonAgregar);
        grupoDatos.Controls.Add(botonLimpiar);
        grupoDatos.Location = new System.Drawing.Point(28, 100);
        grupoDatos.Name = "grupoDatos";
        grupoDatos.Size = new System.Drawing.Size(530, 286);
        grupoDatos.TabIndex = 0;
        grupoDatos.TabStop = false;
        grupoDatos.Text = "Datos del alumno";

        etiquetaNombre.AutoSize = true;
        etiquetaNombre.Location = new System.Drawing.Point(18, 34);
        etiquetaNombre.Name = "etiquetaNombre";
        etiquetaNombre.Size = new System.Drawing.Size(116, 15);
        etiquetaNombre.TabIndex = 0;
        etiquetaNombre.Text = "Nombre del alumno:";

        cuadroNombre.Location = new System.Drawing.Point(151, 30);
        cuadroNombre.Name = "cuadroNombre";
        cuadroNombre.Size = new System.Drawing.Size(350, 23);
        cuadroNombre.TabIndex = 0;

        etiquetaNota1.AutoSize = true;
        etiquetaNota1.Location = new System.Drawing.Point(18, 72);
        etiquetaNota1.Name = "etiquetaNota1";
        etiquetaNota1.Size = new System.Drawing.Size(46, 15);
        etiquetaNota1.TabIndex = 1;
        etiquetaNota1.Text = "Nota 1:";

        cuadroNota1.Location = new System.Drawing.Point(151, 68);
        cuadroNota1.Name = "cuadroNota1";
        cuadroNota1.Size = new System.Drawing.Size(100, 23);
        cuadroNota1.TabIndex = 1;

        etiquetaNota2.AutoSize = true;
        etiquetaNota2.Location = new System.Drawing.Point(18, 108);
        etiquetaNota2.Name = "etiquetaNota2";
        etiquetaNota2.Size = new System.Drawing.Size(46, 15);
        etiquetaNota2.TabIndex = 2;
        etiquetaNota2.Text = "Nota 2:";

        cuadroNota2.Location = new System.Drawing.Point(151, 104);
        cuadroNota2.Name = "cuadroNota2";
        cuadroNota2.Size = new System.Drawing.Size(100, 23);
        cuadroNota2.TabIndex = 2;

        etiquetaNota3.AutoSize = true;
        etiquetaNota3.Location = new System.Drawing.Point(18, 144);
        etiquetaNota3.Name = "etiquetaNota3";
        etiquetaNota3.Size = new System.Drawing.Size(46, 15);
        etiquetaNota3.TabIndex = 3;
        etiquetaNota3.Text = "Nota 3:";

        cuadroNota3.Location = new System.Drawing.Point(151, 140);
        cuadroNota3.Name = "cuadroNota3";
        cuadroNota3.Size = new System.Drawing.Size(100, 23);
        cuadroNota3.TabIndex = 3;

        etiquetaNota4.AutoSize = true;
        etiquetaNota4.Location = new System.Drawing.Point(18, 180);
        etiquetaNota4.Name = "etiquetaNota4";
        etiquetaNota4.Size = new System.Drawing.Size(46, 15);
        etiquetaNota4.TabIndex = 4;
        etiquetaNota4.Text = "Nota 4:";

        cuadroNota4.Location = new System.Drawing.Point(151, 176);
        cuadroNota4.Name = "cuadroNota4";
        cuadroNota4.Size = new System.Drawing.Size(100, 23);
        cuadroNota4.TabIndex = 4;

        botonAgregar.Location = new System.Drawing.Point(286, 111);
        botonAgregar.Name = "botonAgregar";
        botonAgregar.Size = new System.Drawing.Size(215, 38);
        botonAgregar.TabIndex = 5;
        botonAgregar.Text = "Agregar alumno";
        botonAgregar.UseVisualStyleBackColor = true;
        botonAgregar.Click += AgregarAlumno;

        botonLimpiar.Location = new System.Drawing.Point(286, 163);
        botonLimpiar.Name = "botonLimpiar";
        botonLimpiar.Size = new System.Drawing.Size(215, 38);
        botonLimpiar.TabIndex = 6;
        botonLimpiar.Text = "Limpiar campos";
        botonLimpiar.UseVisualStyleBackColor = true;
        botonLimpiar.Click += LimpiarCampos;

        grupoAlumnos.Controls.Add(listaAlumnos);
        grupoAlumnos.Controls.Add(etiquetaCantidad);
        grupoAlumnos.Location = new System.Drawing.Point(28, 405);
        grupoAlumnos.Name = "grupoAlumnos";
        grupoAlumnos.Size = new System.Drawing.Size(530, 184);
        grupoAlumnos.TabIndex = 1;
        grupoAlumnos.TabStop = false;
        grupoAlumnos.Text = "Alumnos guardados";

        listaAlumnos.FormattingEnabled = true;
        listaAlumnos.HorizontalScrollbar = true;
        listaAlumnos.ItemHeight = 15;
        listaAlumnos.Location = new System.Drawing.Point(18, 28);
        listaAlumnos.Name = "listaAlumnos";
        listaAlumnos.Size = new System.Drawing.Size(483, 109);
        listaAlumnos.TabIndex = 0;

        etiquetaCantidad.AutoSize = true;
        etiquetaCantidad.Location = new System.Drawing.Point(18, 151);
        etiquetaCantidad.Name = "etiquetaCantidad";
        etiquetaCantidad.Size = new System.Drawing.Size(119, 15);
        etiquetaCantidad.TabIndex = 1;
        etiquetaCantidad.Text = "Alumnos registrados: 0";

        AcceptButton = botonAgregar;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(590, 620);
        Controls.Add(grupoAlumnos);
        Controls.Add(grupoDatos);
        Controls.Add(etiquetaIndicacion);
        Controls.Add(etiquetaTitulo);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormularioRegistro";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Registro de alumnos";
        grupoDatos.ResumeLayout(false);
        grupoDatos.PerformLayout();
        grupoAlumnos.ResumeLayout(false);
        grupoAlumnos.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
