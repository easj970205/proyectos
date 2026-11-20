namespace ParImpar;

partial class FormularioParImpar
{
    private System.Windows.Forms.Label etiquetaTitulo = null!;
    private System.Windows.Forms.Label etiquetaIndicacion = null!;
    private System.Windows.Forms.Label etiquetaNumero = null!;
    private System.Windows.Forms.TextBox cuadroNumero = null!;
    private System.Windows.Forms.Button botonVerificar = null!;
    private System.Windows.Forms.Button botonLimpiar = null!;
    private System.Windows.Forms.Label etiquetaResultado = null!;

    private void InitializeComponent()
    {
        etiquetaTitulo = new System.Windows.Forms.Label();
        etiquetaIndicacion = new System.Windows.Forms.Label();
        etiquetaNumero = new System.Windows.Forms.Label();
        cuadroNumero = new System.Windows.Forms.TextBox();
        botonVerificar = new System.Windows.Forms.Button();
        botonLimpiar = new System.Windows.Forms.Button();
        etiquetaResultado = new System.Windows.Forms.Label();
        SuspendLayout();

        etiquetaTitulo.AutoSize = true;
        etiquetaTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        etiquetaTitulo.Location = new System.Drawing.Point(30, 22);
        etiquetaTitulo.Name = "etiquetaTitulo";
        etiquetaTitulo.Size = new System.Drawing.Size(224, 37);
        etiquetaTitulo.TabIndex = 0;
        etiquetaTitulo.Text = "Número par o impar";

        etiquetaIndicacion.AutoSize = true;
        etiquetaIndicacion.Location = new System.Drawing.Point(33, 68);
        etiquetaIndicacion.Name = "etiquetaIndicacion";
        etiquetaIndicacion.Size = new System.Drawing.Size(313, 15);
        etiquetaIndicacion.TabIndex = 1;
        etiquetaIndicacion.Text = "Escribe un número entero y pulsa Verificar número.";

        etiquetaNumero.AutoSize = true;
        etiquetaNumero.Location = new System.Drawing.Point(35, 119);
        etiquetaNumero.Name = "etiquetaNumero";
        etiquetaNumero.Size = new System.Drawing.Size(126, 15);
        etiquetaNumero.TabIndex = 2;
        etiquetaNumero.Text = "Número entero:";

        cuadroNumero.Location = new System.Drawing.Point(190, 115);
        cuadroNumero.Name = "cuadroNumero";
        cuadroNumero.Size = new System.Drawing.Size(270, 23);
        cuadroNumero.TabIndex = 0;

        botonVerificar.Location = new System.Drawing.Point(190, 164);
        botonVerificar.Name = "botonVerificar";
        botonVerificar.Size = new System.Drawing.Size(130, 38);
        botonVerificar.TabIndex = 1;
        botonVerificar.Text = "Verificar número";
        botonVerificar.UseVisualStyleBackColor = true;
        botonVerificar.Click += VerificarNumero;

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

        AcceptButton = botonVerificar;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(495, 320);
        Controls.Add(etiquetaResultado);
        Controls.Add(botonLimpiar);
        Controls.Add(botonVerificar);
        Controls.Add(cuadroNumero);
        Controls.Add(etiquetaNumero);
        Controls.Add(etiquetaIndicacion);
        Controls.Add(etiquetaTitulo);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormularioParImpar";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Número par o impar";
        ResumeLayout(false);
        PerformLayout();
    }
}
