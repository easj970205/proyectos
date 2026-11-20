namespace IntercambiarValores;

partial class FormularioIntercambio
{
    private System.Windows.Forms.Label etiquetaTitulo = null!;
    private System.Windows.Forms.Label etiquetaIndicacion = null!;
    private System.Windows.Forms.Label etiquetaValorUno = null!;
    private System.Windows.Forms.TextBox cuadroValorUno = null!;
    private System.Windows.Forms.Label etiquetaValorDos = null!;
    private System.Windows.Forms.TextBox cuadroValorDos = null!;
    private System.Windows.Forms.Button botonIntercambiar = null!;
    private System.Windows.Forms.Button botonLimpiar = null!;
    private System.Windows.Forms.Label etiquetaResultado = null!;

    private void InitializeComponent()
    {
        etiquetaTitulo = new System.Windows.Forms.Label();
        etiquetaIndicacion = new System.Windows.Forms.Label();
        etiquetaValorUno = new System.Windows.Forms.Label();
        cuadroValorUno = new System.Windows.Forms.TextBox();
        etiquetaValorDos = new System.Windows.Forms.Label();
        cuadroValorDos = new System.Windows.Forms.TextBox();
        botonIntercambiar = new System.Windows.Forms.Button();
        botonLimpiar = new System.Windows.Forms.Button();
        etiquetaResultado = new System.Windows.Forms.Label();
        SuspendLayout();

        etiquetaTitulo.AutoSize = true;
        etiquetaTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        etiquetaTitulo.Location = new System.Drawing.Point(30, 22);
        etiquetaTitulo.Name = "etiquetaTitulo";
        etiquetaTitulo.Size = new System.Drawing.Size(270, 37);
        etiquetaTitulo.TabIndex = 0;
        etiquetaTitulo.Text = "Intercambiar valores";

        etiquetaIndicacion.AutoSize = true;
        etiquetaIndicacion.Location = new System.Drawing.Point(33, 68);
        etiquetaIndicacion.Name = "etiquetaIndicacion";
        etiquetaIndicacion.Size = new System.Drawing.Size(320, 15);
        etiquetaIndicacion.TabIndex = 1;
        etiquetaIndicacion.Text = "Escribe dos números enteros y pulsa Intercambiar.";

        etiquetaValorUno.AutoSize = true;
        etiquetaValorUno.Location = new System.Drawing.Point(35, 119);
        etiquetaValorUno.Name = "etiquetaValorUno";
        etiquetaValorUno.Size = new System.Drawing.Size(52, 15);
        etiquetaValorUno.TabIndex = 2;
        etiquetaValorUno.Text = "Valor 1:";

        cuadroValorUno.Location = new System.Drawing.Point(150, 115);
        cuadroValorUno.Name = "cuadroValorUno";
        cuadroValorUno.Size = new System.Drawing.Size(310, 23);
        cuadroValorUno.TabIndex = 0;

        etiquetaValorDos.AutoSize = true;
        etiquetaValorDos.Location = new System.Drawing.Point(35, 168);
        etiquetaValorDos.Name = "etiquetaValorDos";
        etiquetaValorDos.Size = new System.Drawing.Size(52, 15);
        etiquetaValorDos.TabIndex = 3;
        etiquetaValorDos.Text = "Valor 2:";

        cuadroValorDos.Location = new System.Drawing.Point(150, 164);
        cuadroValorDos.Name = "cuadroValorDos";
        cuadroValorDos.Size = new System.Drawing.Size(310, 23);
        cuadroValorDos.TabIndex = 1;

        botonIntercambiar.Location = new System.Drawing.Point(150, 213);
        botonIntercambiar.Name = "botonIntercambiar";
        botonIntercambiar.Size = new System.Drawing.Size(150, 38);
        botonIntercambiar.TabIndex = 2;
        botonIntercambiar.Text = "Intercambiar";
        botonIntercambiar.UseVisualStyleBackColor = true;
        botonIntercambiar.Click += IntercambiarValores;

        botonLimpiar.Location = new System.Drawing.Point(310, 213);
        botonLimpiar.Name = "botonLimpiar";
        botonLimpiar.Size = new System.Drawing.Size(150, 38);
        botonLimpiar.TabIndex = 3;
        botonLimpiar.Text = "Limpiar";
        botonLimpiar.UseVisualStyleBackColor = true;
        botonLimpiar.Click += LimpiarCampos;

        etiquetaResultado.BackColor = System.Drawing.SystemColors.Info;
        etiquetaResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        etiquetaResultado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        etiquetaResultado.Location = new System.Drawing.Point(35, 280);
        etiquetaResultado.Name = "etiquetaResultado";
        etiquetaResultado.Size = new System.Drawing.Size(425, 48);
        etiquetaResultado.TabIndex = 4;
        etiquetaResultado.Text = "Aquí aparecerá el resultado.";
        etiquetaResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        AcceptButton = botonIntercambiar;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(495, 365);
        Controls.Add(etiquetaResultado);
        Controls.Add(botonLimpiar);
        Controls.Add(botonIntercambiar);
        Controls.Add(cuadroValorDos);
        Controls.Add(etiquetaValorDos);
        Controls.Add(cuadroValorUno);
        Controls.Add(etiquetaValorUno);
        Controls.Add(etiquetaIndicacion);
        Controls.Add(etiquetaTitulo);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormularioIntercambio";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Intercambiar valores";
        ResumeLayout(false);
        PerformLayout();
    }
}
