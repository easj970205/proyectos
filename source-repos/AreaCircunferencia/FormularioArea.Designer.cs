namespace AreaCircunferencia;

partial class FormularioArea
{
    private System.Windows.Forms.Label etiquetaTitulo = null!;
    private System.Windows.Forms.Label etiquetaIndicacion = null!;
    private System.Windows.Forms.Label etiquetaRadio = null!;
    private System.Windows.Forms.TextBox cuadroRadio = null!;
    private System.Windows.Forms.Button botonCalcular = null!;
    private System.Windows.Forms.Button botonLimpiar = null!;
    private System.Windows.Forms.Label etiquetaResultado = null!;

    private void InitializeComponent()
    {
        etiquetaTitulo = new System.Windows.Forms.Label();
        etiquetaIndicacion = new System.Windows.Forms.Label();
        etiquetaRadio = new System.Windows.Forms.Label();
        cuadroRadio = new System.Windows.Forms.TextBox();
        botonCalcular = new System.Windows.Forms.Button();
        botonLimpiar = new System.Windows.Forms.Button();
        etiquetaResultado = new System.Windows.Forms.Label();
        SuspendLayout();

        etiquetaTitulo.AutoSize = true;
        etiquetaTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        etiquetaTitulo.Location = new System.Drawing.Point(30, 22);
        etiquetaTitulo.Name = "etiquetaTitulo";
        etiquetaTitulo.Size = new System.Drawing.Size(310, 37);
        etiquetaTitulo.TabIndex = 0;
        etiquetaTitulo.Text = "Área de la circunferencia";

        etiquetaIndicacion.AutoSize = true;
        etiquetaIndicacion.Location = new System.Drawing.Point(33, 68);
        etiquetaIndicacion.Name = "etiquetaIndicacion";
        etiquetaIndicacion.Size = new System.Drawing.Size(365, 15);
        etiquetaIndicacion.TabIndex = 1;
        etiquetaIndicacion.Text = "Escribe el radio en metros y pulsa Calcular área.";

        etiquetaRadio.AutoSize = true;
        etiquetaRadio.Location = new System.Drawing.Point(35, 119);
        etiquetaRadio.Name = "etiquetaRadio";
        etiquetaRadio.Size = new System.Drawing.Size(205, 15);
        etiquetaRadio.TabIndex = 2;
        etiquetaRadio.Text = "Radio de la circunferencia (m):";

        cuadroRadio.Location = new System.Drawing.Point(190, 115);
        cuadroRadio.Name = "cuadroRadio";
        cuadroRadio.Size = new System.Drawing.Size(270, 23);
        cuadroRadio.TabIndex = 0;

        botonCalcular.Location = new System.Drawing.Point(190, 164);
        botonCalcular.Name = "botonCalcular";
        botonCalcular.Size = new System.Drawing.Size(130, 38);
        botonCalcular.TabIndex = 1;
        botonCalcular.Text = "Calcular área";
        botonCalcular.UseVisualStyleBackColor = true;
        botonCalcular.Click += CalcularArea;

        botonLimpiar.Location = new System.Drawing.Point(330, 164);
        botonLimpiar.Name = "botonLimpiar";
        botonLimpiar.Size = new System.Drawing.Size(130, 38);
        botonLimpiar.TabIndex = 2;
        botonLimpiar.Text = "Limpiar";
        botonLimpiar.UseVisualStyleBackColor = true;
        botonLimpiar.Click += LimpiarCampos;

        etiquetaResultado.BackColor = System.Drawing.SystemColors.Info;
        etiquetaResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        etiquetaResultado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        etiquetaResultado.Location = new System.Drawing.Point(35, 232);
        etiquetaResultado.Name = "etiquetaResultado";
        etiquetaResultado.Size = new System.Drawing.Size(425, 48);
        etiquetaResultado.TabIndex = 3;
        etiquetaResultado.Text = "Aquí aparecerá el resultado.";
        etiquetaResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        AcceptButton = botonCalcular;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(495, 320);
        Controls.Add(etiquetaResultado);
        Controls.Add(botonLimpiar);
        Controls.Add(botonCalcular);
        Controls.Add(cuadroRadio);
        Controls.Add(etiquetaRadio);
        Controls.Add(etiquetaIndicacion);
        Controls.Add(etiquetaTitulo);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormularioArea";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Área de la circunferencia";
        ResumeLayout(false);
        PerformLayout();
    }
}
