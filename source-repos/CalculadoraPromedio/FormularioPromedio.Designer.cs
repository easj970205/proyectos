namespace CalculadoraPromedio;

partial class FormularioPromedio
{
    private System.Windows.Forms.Label lblTitulo = null!;
    private System.Windows.Forms.Label lblIndicacion = null!;
    private System.Windows.Forms.GroupBox grpMateria = null!;
    private System.Windows.Forms.Label lblMateria = null!;
    private System.Windows.Forms.TextBox txtMateria = null!;
    private System.Windows.Forms.GroupBox grpCalificaciones = null!;
    private System.Windows.Forms.Label lblCalificacion1 = null!;
    private System.Windows.Forms.Label lblCalificacion2 = null!;
    private System.Windows.Forms.Label lblCalificacion3 = null!;
    private System.Windows.Forms.Label lblCalificacion4 = null!;
    private System.Windows.Forms.TextBox txtCalificacion1 = null!;
    private System.Windows.Forms.TextBox txtCalificacion2 = null!;
    private System.Windows.Forms.TextBox txtCalificacion3 = null!;
    private System.Windows.Forms.TextBox txtCalificacion4 = null!;
    private System.Windows.Forms.Button btnCalcular = null!;
    private System.Windows.Forms.Button btnLimpiar = null!;
    private System.Windows.Forms.Label lblResultado = null!;

    private void InitializeComponent()
    {
        lblTitulo = new System.Windows.Forms.Label();
        lblIndicacion = new System.Windows.Forms.Label();
        grpMateria = new System.Windows.Forms.GroupBox();
        lblMateria = new System.Windows.Forms.Label();
        txtMateria = new System.Windows.Forms.TextBox();
        grpCalificaciones = new System.Windows.Forms.GroupBox();
        lblCalificacion1 = new System.Windows.Forms.Label();
        lblCalificacion2 = new System.Windows.Forms.Label();
        lblCalificacion3 = new System.Windows.Forms.Label();
        lblCalificacion4 = new System.Windows.Forms.Label();
        txtCalificacion1 = new System.Windows.Forms.TextBox();
        txtCalificacion2 = new System.Windows.Forms.TextBox();
        txtCalificacion3 = new System.Windows.Forms.TextBox();
        txtCalificacion4 = new System.Windows.Forms.TextBox();
        btnCalcular = new System.Windows.Forms.Button();
        btnLimpiar = new System.Windows.Forms.Button();
        lblResultado = new System.Windows.Forms.Label();
        grpMateria.SuspendLayout();
        grpCalificaciones.SuspendLayout();
        SuspendLayout();

        lblTitulo.AutoSize = true;
        lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        lblTitulo.Location = new System.Drawing.Point(30, 22);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new System.Drawing.Size(321, 37);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Calculadora de promedio";

        lblIndicacion.AutoSize = true;
        lblIndicacion.Location = new System.Drawing.Point(33, 66);
        lblIndicacion.Name = "lblIndicacion";
        lblIndicacion.Size = new System.Drawing.Size(326, 15);
        lblIndicacion.TabIndex = 1;
        lblIndicacion.Text = "Escribe la materia y hasta cuatro calificaciones de 0 a 100.";

        grpMateria.Controls.Add(lblMateria);
        grpMateria.Controls.Add(txtMateria);
        grpMateria.Location = new System.Drawing.Point(27, 100);
        grpMateria.Name = "grpMateria";
        grpMateria.Size = new System.Drawing.Size(550, 78);
        grpMateria.TabIndex = 0;
        grpMateria.TabStop = false;
        grpMateria.Text = "Materia";

        lblMateria.AutoSize = true;
        lblMateria.Location = new System.Drawing.Point(19, 33);
        lblMateria.Name = "lblMateria";
        lblMateria.Size = new System.Drawing.Size(48, 15);
        lblMateria.TabIndex = 0;
        lblMateria.Text = "Nombre:";

        txtMateria.Location = new System.Drawing.Point(91, 29);
        txtMateria.Name = "txtMateria";
        txtMateria.Size = new System.Drawing.Size(435, 23);
        txtMateria.TabIndex = 0;

        grpCalificaciones.Controls.Add(lblCalificacion1);
        grpCalificaciones.Controls.Add(lblCalificacion2);
        grpCalificaciones.Controls.Add(lblCalificacion3);
        grpCalificaciones.Controls.Add(lblCalificacion4);
        grpCalificaciones.Controls.Add(txtCalificacion1);
        grpCalificaciones.Controls.Add(txtCalificacion2);
        grpCalificaciones.Controls.Add(txtCalificacion3);
        grpCalificaciones.Controls.Add(txtCalificacion4);
        grpCalificaciones.Location = new System.Drawing.Point(27, 192);
        grpCalificaciones.Name = "grpCalificaciones";
        grpCalificaciones.Size = new System.Drawing.Size(550, 186);
        grpCalificaciones.TabIndex = 1;
        grpCalificaciones.TabStop = false;
        grpCalificaciones.Text = "Calificaciones (de 0 a 100)";

        lblCalificacion1.AutoSize = true;
        lblCalificacion1.Location = new System.Drawing.Point(20, 34);
        lblCalificacion1.Name = "lblCalificacion1";
        lblCalificacion1.Size = new System.Drawing.Size(83, 15);
        lblCalificacion1.TabIndex = 0;
        lblCalificacion1.Text = "Calificación 1:";

        lblCalificacion2.AutoSize = true;
        lblCalificacion2.Location = new System.Drawing.Point(20, 69);
        lblCalificacion2.Name = "lblCalificacion2";
        lblCalificacion2.Size = new System.Drawing.Size(83, 15);
        lblCalificacion2.TabIndex = 1;
        lblCalificacion2.Text = "Calificación 2:";

        lblCalificacion3.AutoSize = true;
        lblCalificacion3.Location = new System.Drawing.Point(20, 104);
        lblCalificacion3.Name = "lblCalificacion3";
        lblCalificacion3.Size = new System.Drawing.Size(83, 15);
        lblCalificacion3.TabIndex = 2;
        lblCalificacion3.Text = "Calificación 3:";

        lblCalificacion4.AutoSize = true;
        lblCalificacion4.Location = new System.Drawing.Point(20, 139);
        lblCalificacion4.Name = "lblCalificacion4";
        lblCalificacion4.Size = new System.Drawing.Size(83, 15);
        lblCalificacion4.TabIndex = 3;
        lblCalificacion4.Text = "Calificación 4:";

        txtCalificacion1.Location = new System.Drawing.Point(124, 30);
        txtCalificacion1.Name = "txtCalificacion1";
        txtCalificacion1.Size = new System.Drawing.Size(120, 23);
        txtCalificacion1.TabIndex = 1;

        txtCalificacion2.Location = new System.Drawing.Point(124, 65);
        txtCalificacion2.Name = "txtCalificacion2";
        txtCalificacion2.Size = new System.Drawing.Size(120, 23);
        txtCalificacion2.TabIndex = 2;

        txtCalificacion3.Location = new System.Drawing.Point(124, 100);
        txtCalificacion3.Name = "txtCalificacion3";
        txtCalificacion3.Size = new System.Drawing.Size(120, 23);
        txtCalificacion3.TabIndex = 3;

        txtCalificacion4.Location = new System.Drawing.Point(124, 135);
        txtCalificacion4.Name = "txtCalificacion4";
        txtCalificacion4.Size = new System.Drawing.Size(120, 23);
        txtCalificacion4.TabIndex = 4;

        btnCalcular.Location = new System.Drawing.Point(142, 402);
        btnCalcular.Name = "btnCalcular";
        btnCalcular.Size = new System.Drawing.Size(155, 38);
        btnCalcular.TabIndex = 5;
        btnCalcular.Text = "Calcular promedio";
        btnCalcular.UseVisualStyleBackColor = true;
        btnCalcular.Click += CalcularPromedio;

        btnLimpiar.Location = new System.Drawing.Point(316, 402);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new System.Drawing.Size(140, 38);
        btnLimpiar.TabIndex = 6;
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.UseVisualStyleBackColor = true;
        btnLimpiar.Click += LimpiarCampos;

        lblResultado.BackColor = System.Drawing.SystemColors.Window;
        lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        lblResultado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblResultado.Location = new System.Drawing.Point(27, 458);
        lblResultado.Name = "lblResultado";
        lblResultado.Size = new System.Drawing.Size(550, 64);
        lblResultado.TabIndex = 7;
        lblResultado.Text = "El promedio y la observación aparecerán aquí.";
        lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        AcceptButton = btnCalcular;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(604, 550);
        Controls.Add(lblResultado);
        Controls.Add(btnLimpiar);
        Controls.Add(btnCalcular);
        Controls.Add(grpCalificaciones);
        Controls.Add(grpMateria);
        Controls.Add(lblIndicacion);
        Controls.Add(lblTitulo);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormularioPromedio";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Calculadora de promedio";
        grpMateria.ResumeLayout(false);
        grpMateria.PerformLayout();
        grpCalificaciones.ResumeLayout(false);
        grpCalificaciones.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
