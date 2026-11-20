namespace MultiplosHastaCien;

partial class FormularioMultiplos
{
    private System.Windows.Forms.Label etiquetaTitulo = null!;
    private System.Windows.Forms.Label etiquetaIndicacion = null!;
    private System.Windows.Forms.Label etiquetaNumero = null!;
    private System.Windows.Forms.TextBox cuadroNumero = null!;
    private System.Windows.Forms.Button botonMostrar = null!;
    private System.Windows.Forms.Button botonLimpiar = null!;
    private System.Windows.Forms.Label etiquetaPrevios = null!;
    private System.Windows.Forms.RichTextBox cuadroResultados = null!;

    private void InitializeComponent()
    {
        etiquetaTitulo = new System.Windows.Forms.Label();
        etiquetaIndicacion = new System.Windows.Forms.Label();
        etiquetaNumero = new System.Windows.Forms.Label();
        cuadroNumero = new System.Windows.Forms.TextBox();
        botonMostrar = new System.Windows.Forms.Button();
        botonLimpiar = new System.Windows.Forms.Button();
        etiquetaPrevios = new System.Windows.Forms.Label();
        cuadroResultados = new System.Windows.Forms.RichTextBox();
        SuspendLayout();

        etiquetaTitulo.AutoSize = true;
        etiquetaTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        etiquetaTitulo.Location = new System.Drawing.Point(30, 22);
        etiquetaTitulo.Name = "etiquetaTitulo";
        etiquetaTitulo.Size = new System.Drawing.Size(273, 37);
        etiquetaTitulo.TabIndex = 0;
        etiquetaTitulo.Text = "Múltiplos hasta 100";

        etiquetaIndicacion.AutoSize = true;
        etiquetaIndicacion.Location = new System.Drawing.Point(33, 69);
        etiquetaIndicacion.Name = "etiquetaIndicacion";
        etiquetaIndicacion.Size = new System.Drawing.Size(424, 15);
        etiquetaIndicacion.TabIndex = 1;
        etiquetaIndicacion.Text = "Escribe cualquier número del 1 al 100 para ver sus múltiplos.";

        etiquetaNumero.AutoSize = true;
        etiquetaNumero.Location = new System.Drawing.Point(45, 119);
        etiquetaNumero.Name = "etiquetaNumero";
        etiquetaNumero.Size = new System.Drawing.Size(54, 15);
        etiquetaNumero.TabIndex = 2;
        etiquetaNumero.Text = "Número:";

        cuadroNumero.Location = new System.Drawing.Point(150, 115);
        cuadroNumero.Name = "cuadroNumero";
        cuadroNumero.Size = new System.Drawing.Size(230, 23);
        cuadroNumero.TabIndex = 0;

        botonMostrar.Location = new System.Drawing.Point(400, 111);
        botonMostrar.Name = "botonMostrar";
        botonMostrar.Size = new System.Drawing.Size(135, 32);
        botonMostrar.TabIndex = 1;
        botonMostrar.Text = "Mostrar múltiplos";
        botonMostrar.UseVisualStyleBackColor = true;
        botonMostrar.Click += MostrarMultiplos;

        botonLimpiar.Location = new System.Drawing.Point(400, 153);
        botonLimpiar.Name = "botonLimpiar";
        botonLimpiar.Size = new System.Drawing.Size(135, 32);
        botonLimpiar.TabIndex = 2;
        botonLimpiar.Text = "Limpiar";
        botonLimpiar.UseVisualStyleBackColor = true;
        botonLimpiar.Click += LimpiarTodo;

        etiquetaPrevios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        etiquetaPrevios.Location = new System.Drawing.Point(45, 166);
        etiquetaPrevios.Name = "etiquetaPrevios";
        etiquetaPrevios.Size = new System.Drawing.Size(335, 52);
        etiquetaPrevios.TabIndex = 3;
        etiquetaPrevios.Text = "Aquí aparecerán las consultas anteriores.";
        etiquetaPrevios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

        cuadroResultados.BackColor = System.Drawing.SystemColors.Window;
        cuadroResultados.Font = new System.Drawing.Font("Consolas", 10F);
        cuadroResultados.Location = new System.Drawing.Point(45, 245);
        cuadroResultados.Name = "cuadroResultados";
        cuadroResultados.ReadOnly = true;
        cuadroResultados.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
        cuadroResultados.Size = new System.Drawing.Size(490, 270);
        cuadroResultados.TabIndex = 4;
        cuadroResultados.Text = "";
        cuadroResultados.WordWrap = true;

        AcceptButton = botonMostrar;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(580, 560);
        Controls.Add(cuadroResultados);
        Controls.Add(etiquetaPrevios);
        Controls.Add(botonLimpiar);
        Controls.Add(botonMostrar);
        Controls.Add(cuadroNumero);
        Controls.Add(etiquetaNumero);
        Controls.Add(etiquetaIndicacion);
        Controls.Add(etiquetaTitulo);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormularioMultiplos";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Múltiplos hasta 100";
        ResumeLayout(false);
        PerformLayout();
    }
}
