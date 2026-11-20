namespace PesosADolares;

partial class FormularioConversion
{
    private System.Windows.Forms.Label etiquetaTitulo = null!;
    private System.Windows.Forms.Label etiquetaIndicacion = null!;
    private System.Windows.Forms.Label etiquetaPesos = null!;
    private System.Windows.Forms.TextBox cuadroPesos = null!;
    private System.Windows.Forms.Label etiquetaPrecio = null!;
    private System.Windows.Forms.Label etiquetaDolares = null!;
    private System.Windows.Forms.TextBox cuadroDolares = null!;
    private System.Windows.Forms.Button botonConvertir = null!;
    private System.Windows.Forms.Button botonLimpiar = null!;

    private void InitializeComponent()
    {
        etiquetaTitulo = new System.Windows.Forms.Label();
        etiquetaIndicacion = new System.Windows.Forms.Label();
        etiquetaPesos = new System.Windows.Forms.Label();
        cuadroPesos = new System.Windows.Forms.TextBox();
        etiquetaPrecio = new System.Windows.Forms.Label();
        etiquetaDolares = new System.Windows.Forms.Label();
        cuadroDolares = new System.Windows.Forms.TextBox();
        botonConvertir = new System.Windows.Forms.Button();
        botonLimpiar = new System.Windows.Forms.Button();
        SuspendLayout();

        etiquetaTitulo.AutoSize = true;
        etiquetaTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        etiquetaTitulo.Location = new System.Drawing.Point(32, 22);
        etiquetaTitulo.Name = "etiquetaTitulo";
        etiquetaTitulo.Size = new System.Drawing.Size(281, 37);
        etiquetaTitulo.TabIndex = 0;
        etiquetaTitulo.Text = "Pesos mexicanos a dólares";

        etiquetaIndicacion.AutoSize = true;
        etiquetaIndicacion.Location = new System.Drawing.Point(35, 68);
        etiquetaIndicacion.Name = "etiquetaIndicacion";
        etiquetaIndicacion.Size = new System.Drawing.Size(390, 15);
        etiquetaIndicacion.TabIndex = 1;
        etiquetaIndicacion.Text = "Escribe los pesos y pulsa Convertir. Puedes usar coma o punto decimal.";

        etiquetaPesos.AutoSize = true;
        etiquetaPesos.Location = new System.Drawing.Point(38, 120);
        etiquetaPesos.Name = "etiquetaPesos";
        etiquetaPesos.Size = new System.Drawing.Size(105, 15);
        etiquetaPesos.TabIndex = 2;
        etiquetaPesos.Text = "Pesos mexicanos:";

        cuadroPesos.Location = new System.Drawing.Point(190, 116);
        cuadroPesos.Name = "cuadroPesos";
        cuadroPesos.Size = new System.Drawing.Size(285, 23);
        cuadroPesos.TabIndex = 0;

        etiquetaPrecio.AutoSize = true;
        etiquetaPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
        etiquetaPrecio.ForeColor = System.Drawing.SystemColors.HotTrack;
        etiquetaPrecio.Location = new System.Drawing.Point(38, 166);
        etiquetaPrecio.Name = "etiquetaPrecio";
        etiquetaPrecio.Size = new System.Drawing.Size(270, 15);
        etiquetaPrecio.TabIndex = 3;
        etiquetaPrecio.Text = "Precio de conversión:";

        etiquetaDolares.AutoSize = true;
        etiquetaDolares.Location = new System.Drawing.Point(38, 215);
        etiquetaDolares.Name = "etiquetaDolares";
        etiquetaDolares.Size = new System.Drawing.Size(92, 15);
        etiquetaDolares.TabIndex = 4;
        etiquetaDolares.Text = "Resultado USD:";

        cuadroDolares.BackColor = System.Drawing.SystemColors.Window;
        cuadroDolares.Location = new System.Drawing.Point(190, 211);
        cuadroDolares.Name = "cuadroDolares";
        cuadroDolares.ReadOnly = true;
        cuadroDolares.Size = new System.Drawing.Size(285, 23);
        cuadroDolares.TabIndex = 1;
        cuadroDolares.TabStop = false;

        botonConvertir.Location = new System.Drawing.Point(190, 260);
        botonConvertir.Name = "botonConvertir";
        botonConvertir.Size = new System.Drawing.Size(135, 38);
        botonConvertir.TabIndex = 2;
        botonConvertir.Text = "Convertir";
        botonConvertir.UseVisualStyleBackColor = true;
        botonConvertir.Click += ConvertirPesosADolares;

        botonLimpiar.Location = new System.Drawing.Point(340, 260);
        botonLimpiar.Name = "botonLimpiar";
        botonLimpiar.Size = new System.Drawing.Size(135, 38);
        botonLimpiar.TabIndex = 3;
        botonLimpiar.Text = "Limpiar";
        botonLimpiar.UseVisualStyleBackColor = true;
        botonLimpiar.Click += LimpiarCampos;

        AcceptButton = botonConvertir;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(520, 345);
        Controls.Add(botonLimpiar);
        Controls.Add(botonConvertir);
        Controls.Add(cuadroDolares);
        Controls.Add(etiquetaDolares);
        Controls.Add(etiquetaPrecio);
        Controls.Add(cuadroPesos);
        Controls.Add(etiquetaPesos);
        Controls.Add(etiquetaIndicacion);
        Controls.Add(etiquetaTitulo);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormularioConversion";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Conversión de pesos mexicanos a dólares";
        ResumeLayout(false);
        PerformLayout();
    }
}
