namespace DescuentoCompra;

partial class FormularioDescuento
{
    private System.Windows.Forms.Label etiquetaTitulo = null!;
    private System.Windows.Forms.Label etiquetaIndicacion = null!;
    private System.Windows.Forms.Label etiquetaUnidades = null!;
    private System.Windows.Forms.TextBox cuadroUnidades = null!;
    private System.Windows.Forms.Label etiquetaPrecioBase = null!;
    private System.Windows.Forms.Button botonCalcular = null!;
    private System.Windows.Forms.Button botonLimpiar = null!;
    private System.Windows.Forms.Label etiquetaRango = null!;
    private System.Windows.Forms.Label etiquetaDescuento = null!;
    private System.Windows.Forms.Label etiquetaPrecio = null!;
    private System.Windows.Forms.Label etiquetaTotal = null!;

    private void InitializeComponent()
    {
        etiquetaTitulo = new System.Windows.Forms.Label();
        etiquetaIndicacion = new System.Windows.Forms.Label();
        etiquetaUnidades = new System.Windows.Forms.Label();
        cuadroUnidades = new System.Windows.Forms.TextBox();
        etiquetaPrecioBase = new System.Windows.Forms.Label();
        botonCalcular = new System.Windows.Forms.Button();
        botonLimpiar = new System.Windows.Forms.Button();
        etiquetaRango = new System.Windows.Forms.Label();
        etiquetaDescuento = new System.Windows.Forms.Label();
        etiquetaPrecio = new System.Windows.Forms.Label();
        etiquetaTotal = new System.Windows.Forms.Label();
        SuspendLayout();

        etiquetaTitulo.AutoSize = true;
        etiquetaTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        etiquetaTitulo.Location = new System.Drawing.Point(30, 22);
        etiquetaTitulo.Name = "etiquetaTitulo";
        etiquetaTitulo.Size = new System.Drawing.Size(286, 37);
        etiquetaTitulo.TabIndex = 0;
        etiquetaTitulo.Text = "Descuento de compra";

        etiquetaIndicacion.AutoSize = true;
        etiquetaIndicacion.Location = new System.Drawing.Point(33, 69);
        etiquetaIndicacion.Name = "etiquetaIndicacion";
        etiquetaIndicacion.Size = new System.Drawing.Size(304, 15);
        etiquetaIndicacion.TabIndex = 1;
        etiquetaIndicacion.Text = "Escribe cuántas unidades quieres comprar.";

        etiquetaUnidades.AutoSize = true;
        etiquetaUnidades.Location = new System.Drawing.Point(45, 119);
        etiquetaUnidades.Name = "etiquetaUnidades";
        etiquetaUnidades.Size = new System.Drawing.Size(116, 15);
        etiquetaUnidades.TabIndex = 2;
        etiquetaUnidades.Text = "Número de unidades:";

        cuadroUnidades.Location = new System.Drawing.Point(190, 115);
        cuadroUnidades.Name = "cuadroUnidades";
        cuadroUnidades.Size = new System.Drawing.Size(250, 23);
        cuadroUnidades.TabIndex = 0;

        etiquetaPrecioBase.AutoSize = true;
        etiquetaPrecioBase.ForeColor = System.Drawing.SystemColors.GrayText;
        etiquetaPrecioBase.Location = new System.Drawing.Point(45, 151);
        etiquetaPrecioBase.Name = "etiquetaPrecioBase";
        etiquetaPrecioBase.Size = new System.Drawing.Size(224, 15);
        etiquetaPrecioBase.TabIndex = 3;
        etiquetaPrecioBase.Text = "Precio base por unidad: $100.00 MXN";

        botonCalcular.Location = new System.Drawing.Point(190, 184);
        botonCalcular.Name = "botonCalcular";
        botonCalcular.Size = new System.Drawing.Size(125, 38);
        botonCalcular.TabIndex = 1;
        botonCalcular.Text = "Calcular total";
        botonCalcular.UseVisualStyleBackColor = true;
        botonCalcular.Click += CalcularCompra;

        botonLimpiar.Location = new System.Drawing.Point(325, 184);
        botonLimpiar.Name = "botonLimpiar";
        botonLimpiar.Size = new System.Drawing.Size(115, 38);
        botonLimpiar.TabIndex = 2;
        botonLimpiar.Text = "Limpiar";
        botonLimpiar.UseVisualStyleBackColor = true;
        botonLimpiar.Click += LimpiarCampos;

        etiquetaRango.AutoSize = true;
        etiquetaRango.Location = new System.Drawing.Point(45, 255);
        etiquetaRango.Name = "etiquetaRango";
        etiquetaRango.Size = new System.Drawing.Size(120, 15);
        etiquetaRango.TabIndex = 4;
        etiquetaRango.Text = "Rango aplicado: -";

        etiquetaDescuento.AutoSize = true;
        etiquetaDescuento.Location = new System.Drawing.Point(45, 282);
        etiquetaDescuento.Name = "etiquetaDescuento";
        etiquetaDescuento.Size = new System.Drawing.Size(91, 15);
        etiquetaDescuento.TabIndex = 5;
        etiquetaDescuento.Text = "Descuento: -";

        etiquetaPrecio.AutoSize = true;
        etiquetaPrecio.Location = new System.Drawing.Point(45, 309);
        etiquetaPrecio.Name = "etiquetaPrecio";
        etiquetaPrecio.Size = new System.Drawing.Size(128, 15);
        etiquetaPrecio.TabIndex = 6;
        etiquetaPrecio.Text = "Precio por unidad: -";

        etiquetaTotal.BackColor = System.Drawing.SystemColors.Info;
        etiquetaTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        etiquetaTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        etiquetaTotal.Location = new System.Drawing.Point(45, 350);
        etiquetaTotal.Name = "etiquetaTotal";
        etiquetaTotal.Size = new System.Drawing.Size(395, 52);
        etiquetaTotal.TabIndex = 7;
        etiquetaTotal.Text = "Aquí aparecerá el total.";
        etiquetaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        AcceptButton = botonCalcular;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(490, 435);
        Controls.Add(etiquetaTotal);
        Controls.Add(etiquetaPrecio);
        Controls.Add(etiquetaDescuento);
        Controls.Add(etiquetaRango);
        Controls.Add(botonLimpiar);
        Controls.Add(botonCalcular);
        Controls.Add(etiquetaPrecioBase);
        Controls.Add(cuadroUnidades);
        Controls.Add(etiquetaUnidades);
        Controls.Add(etiquetaIndicacion);
        Controls.Add(etiquetaTitulo);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormularioDescuento";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Descuento de compra";
        ResumeLayout(false);
        PerformLayout();
    }
}
