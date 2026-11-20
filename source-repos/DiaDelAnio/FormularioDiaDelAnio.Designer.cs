namespace DiaDelAnio;

partial class FormularioDiaDelAnio
{
    private System.Windows.Forms.Label etiquetaTitulo = null!;
    private System.Windows.Forms.Label etiquetaIndicacion = null!;
    private System.Windows.Forms.Label etiquetaDia = null!;
    private System.Windows.Forms.Label etiquetaMes = null!;
    private System.Windows.Forms.TextBox cuadroDia = null!;
    private System.Windows.Forms.TextBox cuadroMes = null!;
    private System.Windows.Forms.Button botonCalcular = null!;
    private System.Windows.Forms.Button botonLimpiar = null!;
    private System.Windows.Forms.Label etiquetaNota = null!;
    private System.Windows.Forms.Label etiquetaResultado = null!;

    private void InitializeComponent()
    {
        etiquetaTitulo = new System.Windows.Forms.Label();
        etiquetaIndicacion = new System.Windows.Forms.Label();
        etiquetaDia = new System.Windows.Forms.Label();
        etiquetaMes = new System.Windows.Forms.Label();
        cuadroDia = new System.Windows.Forms.TextBox();
        cuadroMes = new System.Windows.Forms.TextBox();
        botonCalcular = new System.Windows.Forms.Button();
        botonLimpiar = new System.Windows.Forms.Button();
        etiquetaNota = new System.Windows.Forms.Label();
        etiquetaResultado = new System.Windows.Forms.Label();
        SuspendLayout();

        etiquetaTitulo.AutoSize = true;
        etiquetaTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        etiquetaTitulo.Location = new System.Drawing.Point(30, 22);
        etiquetaTitulo.Name = "etiquetaTitulo";
        etiquetaTitulo.Size = new System.Drawing.Size(191, 37);
        etiquetaTitulo.TabIndex = 0;
        etiquetaTitulo.Text = "Día y mes";

        etiquetaIndicacion.AutoSize = true;
        etiquetaIndicacion.Location = new System.Drawing.Point(33, 69);
        etiquetaIndicacion.Name = "etiquetaIndicacion";
        etiquetaIndicacion.Size = new System.Drawing.Size(370, 15);
        etiquetaIndicacion.TabIndex = 1;
        etiquetaIndicacion.Text = "Escribe el día y el mes para ver la fecha completa.";

        etiquetaDia.AutoSize = true;
        etiquetaDia.Location = new System.Drawing.Point(45, 125);
        etiquetaDia.Name = "etiquetaDia";
        etiquetaDia.Size = new System.Drawing.Size(31, 15);
        etiquetaDia.TabIndex = 2;
        etiquetaDia.Text = "Día:";

        cuadroDia.Location = new System.Drawing.Point(105, 121);
        cuadroDia.Name = "cuadroDia";
        cuadroDia.Size = new System.Drawing.Size(115, 23);
        cuadroDia.TabIndex = 0;

        etiquetaMes.AutoSize = true;
        etiquetaMes.Location = new System.Drawing.Point(270, 125);
        etiquetaMes.Name = "etiquetaMes";
        etiquetaMes.Size = new System.Drawing.Size(34, 15);
        etiquetaMes.TabIndex = 3;
        etiquetaMes.Text = "Mes:";

        cuadroMes.Location = new System.Drawing.Point(325, 121);
        cuadroMes.Name = "cuadroMes";
        cuadroMes.Size = new System.Drawing.Size(115, 23);
        cuadroMes.TabIndex = 1;

        botonCalcular.Location = new System.Drawing.Point(105, 174);
        botonCalcular.Name = "botonCalcular";
        botonCalcular.Size = new System.Drawing.Size(150, 38);
        botonCalcular.TabIndex = 2;
        botonCalcular.Text = "Mostrar fecha";
        botonCalcular.UseVisualStyleBackColor = true;
        botonCalcular.Click += CalcularFecha;

        botonLimpiar.Location = new System.Drawing.Point(270, 174);
        botonLimpiar.Name = "botonLimpiar";
        botonLimpiar.Size = new System.Drawing.Size(170, 38);
        botonLimpiar.TabIndex = 3;
        botonLimpiar.Text = "Limpiar";
        botonLimpiar.UseVisualStyleBackColor = true;
        botonLimpiar.Click += LimpiarCampos;

        etiquetaNota.AutoSize = true;
        etiquetaNota.ForeColor = System.Drawing.SystemColors.GrayText;
        etiquetaNota.Location = new System.Drawing.Point(45, 237);
        etiquetaNota.Name = "etiquetaNota";
        etiquetaNota.Size = new System.Drawing.Size(350, 15);
        etiquetaNota.TabIndex = 4;
        etiquetaNota.Text = "Se usa el año actual para obtener el día de la semana.";

        etiquetaResultado.BackColor = System.Drawing.SystemColors.Info;
        etiquetaResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        etiquetaResultado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        etiquetaResultado.Location = new System.Drawing.Point(45, 275);
        etiquetaResultado.Name = "etiquetaResultado";
        etiquetaResultado.Size = new System.Drawing.Size(395, 52);
        etiquetaResultado.TabIndex = 5;
        etiquetaResultado.Text = "Aquí aparecerá la fecha.";
        etiquetaResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        AcceptButton = botonCalcular;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(490, 360);
        Controls.Add(etiquetaResultado);
        Controls.Add(etiquetaNota);
        Controls.Add(botonLimpiar);
        Controls.Add(botonCalcular);
        Controls.Add(cuadroMes);
        Controls.Add(cuadroDia);
        Controls.Add(etiquetaMes);
        Controls.Add(etiquetaDia);
        Controls.Add(etiquetaIndicacion);
        Controls.Add(etiquetaTitulo);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormularioDiaDelAnio";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Día y mes";
        ResumeLayout(false);
        PerformLayout();
    }
}
´'Revisando Luis alberto Luna Hernandez'