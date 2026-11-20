namespace ConversorDistancias;

partial class FormularioConversor
{
    private System.Windows.Forms.Label lblTitulo = null!;
    private System.Windows.Forms.Label lblIndicacion = null!;
    private System.Windows.Forms.GroupBox grpMetros = null!;
    private System.Windows.Forms.Label lblMetros = null!;
    private System.Windows.Forms.TextBox txtMetros = null!;
    private System.Windows.Forms.Button btnConvertirMetros = null!;
    private System.Windows.Forms.Label lblResultadoKilometros = null!;
    private System.Windows.Forms.GroupBox grpKilometros = null!;
    private System.Windows.Forms.Label lblKilometros = null!;
    private System.Windows.Forms.TextBox txtKilometros = null!;
    private System.Windows.Forms.Button btnConvertirKilometros = null!;
    private System.Windows.Forms.Label lblResultadoMillas = null!;
    private System.Windows.Forms.Button btnLimpiar = null!;

    private void InitializeComponent()
    {
        lblTitulo = new System.Windows.Forms.Label();
        lblIndicacion = new System.Windows.Forms.Label();
        grpMetros = new System.Windows.Forms.GroupBox();
        lblMetros = new System.Windows.Forms.Label();
        txtMetros = new System.Windows.Forms.TextBox();
        btnConvertirMetros = new System.Windows.Forms.Button();
        lblResultadoKilometros = new System.Windows.Forms.Label();
        grpKilometros = new System.Windows.Forms.GroupBox();
        lblKilometros = new System.Windows.Forms.Label();
        txtKilometros = new System.Windows.Forms.TextBox();
        btnConvertirKilometros = new System.Windows.Forms.Button();
        lblResultadoMillas = new System.Windows.Forms.Label();
        btnLimpiar = new System.Windows.Forms.Button();
        grpMetros.SuspendLayout();
        grpKilometros.SuspendLayout();
        SuspendLayout();

        lblTitulo.AutoSize = true;
        lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        lblTitulo.Location = new System.Drawing.Point(30, 22);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new System.Drawing.Size(292, 37);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Conversor de distancias";

        lblIndicacion.AutoSize = true;
        lblIndicacion.Location = new System.Drawing.Point(34, 66);
        lblIndicacion.Name = "lblIndicacion";
        lblIndicacion.Size = new System.Drawing.Size(404, 15);
        lblIndicacion.TabIndex = 1;
        lblIndicacion.Text = "Elige una conversión. Puedes usar coma o punto para los decimales.";

        grpMetros.Controls.Add(lblMetros);
        grpMetros.Controls.Add(txtMetros);
        grpMetros.Controls.Add(btnConvertirMetros);
        grpMetros.Controls.Add(lblResultadoKilometros);
        grpMetros.Location = new System.Drawing.Point(30, 105);
        grpMetros.Name = "grpMetros";
        grpMetros.Size = new System.Drawing.Size(585, 145);
        grpMetros.TabIndex = 0;
        grpMetros.TabStop = false;
        grpMetros.Text = "Metros a kilómetros";

        lblMetros.AutoSize = true;
        lblMetros.Location = new System.Drawing.Point(21, 36);
        lblMetros.Name = "lblMetros";
        lblMetros.Size = new System.Drawing.Size(87, 15);
        lblMetros.TabIndex = 0;
        lblMetros.Text = "Cantidad en m:";

        txtMetros.Location = new System.Drawing.Point(123, 32);
        txtMetros.Name = "txtMetros";
        txtMetros.Size = new System.Drawing.Size(170, 23);
        txtMetros.TabIndex = 0;

        btnConvertirMetros.Location = new System.Drawing.Point(318, 29);
        btnConvertirMetros.Name = "btnConvertirMetros";
        btnConvertirMetros.Size = new System.Drawing.Size(165, 30);
        btnConvertirMetros.TabIndex = 1;
        btnConvertirMetros.Text = "Convertir a kilómetros";
        btnConvertirMetros.UseVisualStyleBackColor = true;
        btnConvertirMetros.Click += ConvertirMetrosAKilometros;

        lblResultadoKilometros.BackColor = System.Drawing.SystemColors.Info;
        lblResultadoKilometros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        lblResultadoKilometros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblResultadoKilometros.Location = new System.Drawing.Point(123, 78);
        lblResultadoKilometros.Name = "lblResultadoKilometros";
        lblResultadoKilometros.Size = new System.Drawing.Size(360, 35);
        lblResultadoKilometros.TabIndex = 2;
        lblResultadoKilometros.Text = "Resultado: -- km";
        lblResultadoKilometros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        grpKilometros.Controls.Add(lblKilometros);
        grpKilometros.Controls.Add(txtKilometros);
        grpKilometros.Controls.Add(btnConvertirKilometros);
        grpKilometros.Controls.Add(lblResultadoMillas);
        grpKilometros.Location = new System.Drawing.Point(30, 275);
        grpKilometros.Name = "grpKilometros";
        grpKilometros.Size = new System.Drawing.Size(585, 145);
        grpKilometros.TabIndex = 1;
        grpKilometros.TabStop = false;
        grpKilometros.Text = "Kilómetros a millas";

        lblKilometros.AutoSize = true;
        lblKilometros.Location = new System.Drawing.Point(21, 36);
        lblKilometros.Name = "lblKilometros";
        lblKilometros.Size = new System.Drawing.Size(100, 15);
        lblKilometros.TabIndex = 0;
        lblKilometros.Text = "Cantidad en km:";

        txtKilometros.Location = new System.Drawing.Point(123, 32);
        txtKilometros.Name = "txtKilometros";
        txtKilometros.Size = new System.Drawing.Size(170, 23);
        txtKilometros.TabIndex = 2;

        btnConvertirKilometros.Location = new System.Drawing.Point(318, 29);
        btnConvertirKilometros.Name = "btnConvertirKilometros";
        btnConvertirKilometros.Size = new System.Drawing.Size(165, 30);
        btnConvertirKilometros.TabIndex = 3;
        btnConvertirKilometros.Text = "Convertir a millas";
        btnConvertirKilometros.UseVisualStyleBackColor = true;
        btnConvertirKilometros.Click += ConvertirKilometrosAMillas;

        lblResultadoMillas.BackColor = System.Drawing.SystemColors.Info;
        lblResultadoMillas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        lblResultadoMillas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblResultadoMillas.Location = new System.Drawing.Point(123, 78);
        lblResultadoMillas.Name = "lblResultadoMillas";
        lblResultadoMillas.Size = new System.Drawing.Size(360, 35);
        lblResultadoMillas.TabIndex = 2;
        lblResultadoMillas.Text = "Resultado: -- mi";
        lblResultadoMillas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        btnLimpiar.Location = new System.Drawing.Point(245, 444);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new System.Drawing.Size(155, 38);
        btnLimpiar.TabIndex = 4;
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.UseVisualStyleBackColor = true;
        btnLimpiar.Click += LimpiarCampos;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(650, 510);
        Controls.Add(btnLimpiar);
        Controls.Add(grpKilometros);
        Controls.Add(grpMetros);
        Controls.Add(lblIndicacion);
        Controls.Add(lblTitulo);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormularioConversor";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Conversor de distancias";
        grpMetros.ResumeLayout(false);
        grpMetros.PerformLayout();
        grpKilometros.ResumeLayout(false);
        grpKilometros.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}

