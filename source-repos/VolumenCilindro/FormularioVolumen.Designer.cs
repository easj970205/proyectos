namespace VolumenCilindro;

partial class FormularioVolumen
{
    private System.Windows.Forms.Label etiquetaRadio = null!;
    private System.Windows.Forms.TextBox cuadroRadio = null!;
    private System.Windows.Forms.Label etiquetaAltura = null!;
    private System.Windows.Forms.TextBox cuadroAltura = null!;
    private System.Windows.Forms.Button botonCalcular = null!;

    private void InitializeComponent()
    {
        etiquetaRadio = new System.Windows.Forms.Label();
        cuadroRadio = new System.Windows.Forms.TextBox();
        etiquetaAltura = new System.Windows.Forms.Label();
        cuadroAltura = new System.Windows.Forms.TextBox();
        botonCalcular = new System.Windows.Forms.Button();
        SuspendLayout();

        etiquetaRadio.AutoSize = true;
        etiquetaRadio.Location = new System.Drawing.Point(38, 43);
        etiquetaRadio.Name = "etiquetaRadio";
        etiquetaRadio.Size = new System.Drawing.Size(63, 15);
        etiquetaRadio.TabIndex = 0;
        etiquetaRadio.Text = "Radio (m):";

        cuadroRadio.Location = new System.Drawing.Point(155, 39);
        cuadroRadio.Name = "cuadroRadio";
        cuadroRadio.Size = new System.Drawing.Size(285, 23);
        cuadroRadio.TabIndex = 0;

        etiquetaAltura.AutoSize = true;
        etiquetaAltura.Location = new System.Drawing.Point(38, 91);
        etiquetaAltura.Name = "etiquetaAltura";
        etiquetaAltura.Size = new System.Drawing.Size(67, 15);
        etiquetaAltura.TabIndex = 1;
        etiquetaAltura.Text = "Altura (m):";

        cuadroAltura.Location = new System.Drawing.Point(155, 87);
        cuadroAltura.Name = "cuadroAltura";
        cuadroAltura.Size = new System.Drawing.Size(285, 23);
        cuadroAltura.TabIndex = 1;

        botonCalcular.Location = new System.Drawing.Point(155, 143);
        botonCalcular.Name = "botonCalcular";
        botonCalcular.Size = new System.Drawing.Size(285, 38);
        botonCalcular.TabIndex = 2;
        botonCalcular.Text = "Calcular volumen";
        botonCalcular.UseVisualStyleBackColor = true;
        botonCalcular.Click += CalcularVolumen;

        AcceptButton = botonCalcular;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(490, 220);
        Controls.Add(botonCalcular);
        Controls.Add(cuadroAltura);
        Controls.Add(etiquetaAltura);
        Controls.Add(cuadroRadio);
        Controls.Add(etiquetaRadio);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormularioVolumen";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Volumen de un cilindro";
        ResumeLayout(false);
        PerformLayout();
    }
}
