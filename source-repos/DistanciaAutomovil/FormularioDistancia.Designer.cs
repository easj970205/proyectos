namespace DistanciaAutomovil;

partial class FormularioDistancia
{
    private System.Windows.Forms.Label etiquetaTitulo = null!;
    private System.Windows.Forms.Label etiquetaIndicacion = null!;
    private System.Windows.Forms.Label etiquetaTiempo = null!;
    private System.Windows.Forms.TextBox cuadroTiempo = null!;
    private System.Windows.Forms.Label etiquetaAceleracion = null!;
    private System.Windows.Forms.TextBox cuadroAceleracion = null!;
    private System.Windows.Forms.Button botonCalcular = null!;
    private System.Windows.Forms.Button botonLimpiar = null!;
    private System.Windows.Forms.Label etiquetaResultado = null!;

    private void InitializeComponent()
    {
        etiquetaTitulo = new System.Windows.Forms.Label();
        etiquetaIndicacion = new System.Windows.Forms.Label();
        etiquetaTiempo = new System.Windows.Forms.Label();
        cuadroTiempo = new System.Windows.Forms.TextBox();
        etiquetaAceleracion = new System.Windows.Forms.Label();
        cuadroAceleracion = new System.Windows.Forms.TextBox();
        botonCalcular = new System.Windows.Forms.Button();
        botonLimpiar = new System.Windows.Forms.Button();
        etiquetaResultado = new System.Windows.Forms.Label();
        SuspendLayout();

        etiquetaTitulo.AutoSize = true;
        etiquetaTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        etiquetaTitulo.Location = new System.Drawing.Point(30, 22);
        etiquetaTitulo.Name = "etiquetaTitulo";
        etiquetaTitulo.Size = new System.Drawing.Size(342, 37);
        etiquetaTitulo.TabIndex = 0;
        etiquetaTitulo.Text = "Distancia de un automóvil";

        etiquetaIndicacion.AutoSize = true;
        etiquetaIndicacion.Location = new System.Drawing.Point(33, 68);
        etiquetaIndicacion.Name = "etiquetaIndicacion";
        etiquetaIndicacion.Size = new System.Drawing.Size(410, 15);
        etiquetaIndicacion.TabIndex = 1;
        etiquetaIndicacion.Text = "Pon el tiempo y la aceleración del auto.";

        etiquetaTiempo.AutoSize = true;
        etiquetaTiempo.Location = new System.Drawing.Point(35, 120);
        etiquetaTiempo.Name = "etiquetaTiempo";
        etiquetaTiempo.Size = new System.Drawing.Size(116, 15);
        etiquetaTiempo.TabIndex = 2;
        etiquetaTiempo.Text = "Tiempo (segundos):";

        cuadroTiempo.Location = new System.Drawing.Point(190, 116);
        cuadroTiempo.Name = "cuadroTiempo";
        cuadroTiempo.Size = new System.Drawing.Size(270, 23);
        cuadroTiempo.TabIndex = 0;

        etiquetaAceleracion.AutoSize = true;
        etiquetaAceleracion.Location = new System.Drawing.Point(35, 169);
        etiquetaAceleracion.Name = "etiquetaAceleracion";
        etiquetaAceleracion.Size = new System.Drawing.Size(136, 15);
        etiquetaAceleracion.TabIndex = 3;
        etiquetaAceleracion.Text = "Aceleración (m/s²):";

        cuadroAceleracion.Location = new System.Drawing.Point(190, 165);
        cuadroAceleracion.Name = "cuadroAceleracion";
        cuadroAceleracion.Size = new System.Drawing.Size(270, 23);
        cuadroAceleracion.TabIndex = 1;

        botonCalcular.Location = new System.Drawing.Point(190, 214);
        botonCalcular.Name = "botonCalcular";
        botonCalcular.Size = new System.Drawing.Size(135, 38);
        botonCalcular.TabIndex = 2;
        botonCalcular.Text = "Calcular distancia";
        botonCalcular.UseVisualStyleBackColor = true;
        botonCalcular.Click += CalcularDistancia;

        botonLimpiar.Location = new System.Drawing.Point(325, 214);
        botonLimpiar.Name = "botonLimpiar";
        botonLimpiar.Size = new System.Drawing.Size(135, 38);
        botonLimpiar.TabIndex = 3;
        botonLimpiar.Text = "Limpiar";
        botonLimpiar.UseVisualStyleBackColor = true;
        botonLimpiar.Click += LimpiarCampos;

        etiquetaResultado.BackColor = System.Drawing.SystemColors.Info;
        etiquetaResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        etiquetaResultado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        etiquetaResultado.Location = new System.Drawing.Point(35, 282);
        etiquetaResultado.Name = "etiquetaResultado";
        etiquetaResultado.Size = new System.Drawing.Size(425, 48);
        etiquetaResultado.TabIndex = 4;
        etiquetaResultado.Text = "Aquí aparecerá el resultado.";
        etiquetaResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        AcceptButton = botonCalcular;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(495, 365);
        Controls.Add(etiquetaResultado);
        Controls.Add(botonLimpiar);
        Controls.Add(botonCalcular);
        Controls.Add(cuadroAceleracion);
        Controls.Add(etiquetaAceleracion);
        Controls.Add(cuadroTiempo);
        Controls.Add(etiquetaTiempo);
        Controls.Add(etiquetaIndicacion);
        Controls.Add(etiquetaTitulo);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormularioDistancia";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Distancia de un automóvil";
        ResumeLayout(false);
        PerformLayout();
    }
}
