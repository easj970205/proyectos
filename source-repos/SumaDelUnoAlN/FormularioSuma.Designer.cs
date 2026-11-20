namespace SumaDelUnoAlN;

partial class FormularioSuma
{
    private System.Windows.Forms.Label etiquetaTitulo = null!;
    private System.Windows.Forms.Label etiquetaIndicacion = null!;
    private System.Windows.Forms.Label etiquetaNumero = null!;
    private System.Windows.Forms.TextBox cuadroNumero = null!;
    private System.Windows.Forms.Button botonSumar = null!;
    private System.Windows.Forms.Button botonLimpiar = null!;
    private System.Windows.Forms.Label etiquetaTotal = null!;
    private System.Windows.Forms.Label etiquetaEntradas = null!;
    private System.Windows.Forms.ListBox listaNumeros = null!;

    private void InitializeComponent()
    {
        etiquetaTitulo = new System.Windows.Forms.Label();
        etiquetaIndicacion = new System.Windows.Forms.Label();
        etiquetaNumero = new System.Windows.Forms.Label();
        cuadroNumero = new System.Windows.Forms.TextBox();
        botonSumar = new System.Windows.Forms.Button();
        botonLimpiar = new System.Windows.Forms.Button();
        etiquetaTotal = new System.Windows.Forms.Label();
        etiquetaEntradas = new System.Windows.Forms.Label();
        listaNumeros = new System.Windows.Forms.ListBox();
        SuspendLayout();

        etiquetaTitulo.AutoSize = true;
        etiquetaTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        etiquetaTitulo.Location = new System.Drawing.Point(30, 22);
        etiquetaTitulo.Name = "etiquetaTitulo";
        etiquetaTitulo.Size = new System.Drawing.Size(218, 37);
        etiquetaTitulo.TabIndex = 0;
        etiquetaTitulo.Text = "Suma acumulada";

        etiquetaIndicacion.AutoSize = true;
        etiquetaIndicacion.Location = new System.Drawing.Point(33, 69);
        etiquetaIndicacion.Name = "etiquetaIndicacion";
        etiquetaIndicacion.Size = new System.Drawing.Size(383, 15);
        etiquetaIndicacion.TabIndex = 1;
        etiquetaIndicacion.Text = "Escribe una cantidad y pulsa Sumar. Puedes repetirlo.";

        etiquetaNumero.AutoSize = true;
        etiquetaNumero.Location = new System.Drawing.Point(45, 119);
        etiquetaNumero.Name = "etiquetaNumero";
        etiquetaNumero.Size = new System.Drawing.Size(59, 15);
        etiquetaNumero.TabIndex = 2;
        etiquetaNumero.Text = "Cantidad:";

        cuadroNumero.Location = new System.Drawing.Point(190, 115);
        cuadroNumero.Name = "cuadroNumero";
        cuadroNumero.Size = new System.Drawing.Size(270, 23);
        cuadroNumero.TabIndex = 0;

        botonSumar.Location = new System.Drawing.Point(190, 165);
        botonSumar.Name = "botonSumar";
        botonSumar.Size = new System.Drawing.Size(145, 38);
        botonSumar.TabIndex = 1;
        botonSumar.Text = "Sumar";
        botonSumar.UseVisualStyleBackColor = true;
        botonSumar.Click += SumarCantidad;

        botonLimpiar.Location = new System.Drawing.Point(350, 165);
        botonLimpiar.Name = "botonLimpiar";
        botonLimpiar.Size = new System.Drawing.Size(110, 38);
        botonLimpiar.TabIndex = 2;
        botonLimpiar.Text = "Limpiar";
        botonLimpiar.UseVisualStyleBackColor = true;
        botonLimpiar.Click += LimpiarTodo;

        etiquetaTotal.BackColor = System.Drawing.SystemColors.Info;
        etiquetaTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        etiquetaTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        etiquetaTotal.Location = new System.Drawing.Point(45, 235);
        etiquetaTotal.Name = "etiquetaTotal";
        etiquetaTotal.Size = new System.Drawing.Size(415, 48);
        etiquetaTotal.TabIndex = 3;
        etiquetaTotal.Text = "Total acumulado: 0";
        etiquetaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        etiquetaEntradas.AutoSize = true;
        etiquetaEntradas.Location = new System.Drawing.Point(45, 310);
        etiquetaEntradas.Name = "etiquetaEntradas";
        etiquetaEntradas.Size = new System.Drawing.Size(195, 15);
        etiquetaEntradas.TabIndex = 4;
        etiquetaEntradas.Text = "Números que se han ido sumando:";

        listaNumeros.FormattingEnabled = true;
        listaNumeros.ItemHeight = 15;
        listaNumeros.Location = new System.Drawing.Point(45, 334);
        listaNumeros.Name = "listaNumeros";
        listaNumeros.Size = new System.Drawing.Size(415, 79);
        listaNumeros.TabIndex = 5;

        AcceptButton = botonSumar;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(510, 445);
        Controls.Add(listaNumeros);
        Controls.Add(etiquetaEntradas);
        Controls.Add(etiquetaTotal);
        Controls.Add(botonLimpiar);
        Controls.Add(botonSumar);
        Controls.Add(cuadroNumero);
        Controls.Add(etiquetaNumero);
        Controls.Add(etiquetaIndicacion);
        Controls.Add(etiquetaTitulo);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormularioSuma";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Suma acumulada";
        ResumeLayout(false);
        PerformLayout();
    }
}
