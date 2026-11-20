namespace NumeroPositivoNegativo;

partial class FormularioSigno
{
    private System.Windows.Forms.Label etiquetaTitulo = null!;
    private System.Windows.Forms.Label etiquetaIndicacion = null!;
    private System.Windows.Forms.Label etiquetaNumero = null!;
    private System.Windows.Forms.TextBox cuadroNumero = null!;
    private System.Windows.Forms.Button botonRevisar = null!;
    private System.Windows.Forms.Button botonLimpiar = null!;
    private System.Windows.Forms.Label etiquetaResultado = null!;

    private void InitializeComponent()
    {
        etiquetaTitulo = new System.Windows.Forms.Label();
        etiquetaIndicacion = new System.Windows.Forms.Label();
        etiquetaNumero = new System.Windows.Forms.Label();
        cuadroNumero = new System.Windows.Forms.TextBox();
        botonRevisar = new System.Windows.Forms.Button();
        botonLimpiar = new System.Windows.Forms.Button();
        etiquetaResultado = new System.Windows.Forms.Label();
        SuspendLayout();

        etiquetaTitulo.AutoSize = true;
        etiquetaTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        etiquetaTitulo.Location = new System.Drawing.Point(30, 22);
        etiquetaTitulo.Name = "etiquetaTitulo";
        etiquetaTitulo.Size = new System.Drawing.Size(350, 37);
        etiquetaTitulo.TabIndex = 0;
        etiquetaTitulo.Text = "Número positivo o negativo";

        etiquetaIndicacion.AutoSize = true;
        etiquetaIndicacion.Location = new System.Drawing.Point(33, 68);
        etiquetaIndicacion.Name = "etiquetaIndicacion";
        etiquetaIndicacion.Size = new System.Drawing.Size(360, 15);
        etiquetaIndicacion.TabIndex = 1;
        etiquetaIndicacion.Text = "Si es mayor que 0, es positivo; si no, se considera negativo.";

        etiquetaNumero.AutoSize = true;
        etiquetaNumero.Location = new System.Drawing.Point(35, 121);
        etiquetaNumero.Name = "etiquetaNumero";
        etiquetaNumero.Size = new System.Drawing.Size(108, 15);
        etiquetaNumero.TabIndex = 2;
        etiquetaNumero.Text = "Escribe un número:";

        cuadroNumero.Location = new System.Drawing.Point(180, 117);
        cuadroNumero.Name = "cuadroNumero";
        cuadroNumero.Size = new System.Drawing.Size(280, 23);
        cuadroNumero.TabIndex = 0;

        botonRevisar.Location = new System.Drawing.Point(180, 166);
        botonRevisar.Name = "botonRevisar";
        botonRevisar.Size = new System.Drawing.Size(135, 38);
        botonRevisar.TabIndex = 1;
        botonRevisar.Text = "Revisar número";
        botonRevisar.UseVisualStyleBackColor = true;
        botonRevisar.Click += RevisarNumero;

        botonLimpiar.Location = new System.Drawing.Point(325, 166);
        botonLimpiar.Name = "botonLimpiar";
        botonLimpiar.Size = new System.Drawing.Size(135, 38);
        botonLimpiar.TabIndex = 2;
        botonLimpiar.Text = "Limpiar";
        botonLimpiar.UseVisualStyleBackColor = true;
        botonLimpiar.Click += LimpiarCampos;

        etiquetaResultado.BackColor = System.Drawing.SystemColors.Info;
        etiquetaResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        etiquetaResultado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        etiquetaResultado.Location = new System.Drawing.Point(35, 238);
        etiquetaResultado.Name = "etiquetaResultado";
        etiquetaResultado.Size = new System.Drawing.Size(425, 46);
        etiquetaResultado.TabIndex = 3;
        etiquetaResultado.Text = "Aquí aparecerá el resultado.";
        etiquetaResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        AcceptButton = botonRevisar;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(495, 325);
        Controls.Add(etiquetaResultado);
        Controls.Add(botonLimpiar);
        Controls.Add(botonRevisar);
        Controls.Add(cuadroNumero);
        Controls.Add(etiquetaNumero);
        Controls.Add(etiquetaIndicacion);
        Controls.Add(etiquetaTitulo);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormularioSigno";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Número positivo o negativo";
        ResumeLayout(false);
        PerformLayout();
    }
}
