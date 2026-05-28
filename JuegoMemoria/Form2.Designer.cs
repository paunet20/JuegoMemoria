namespace JuegoMemoria
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelNivel;
        private System.Windows.Forms.Label labelPuntos;
        private System.Windows.Forms.Label labelParejas;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Panel panelJuego;
        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Timer reloj;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelTitulo = new Label();
            labelNivel = new Label();
            labelPuntos = new Label();
            labelParejas = new Label();
            labelTiempo = new Label();
            panelJuego = new Panel();
            botonNuevo = new Button();
            botonVolver = new Button();
            reloj = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitulo.Location = new Point(23, 20);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(251, 47);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Buscar parejas";
            // 
            // labelNivel
            // 
            labelNivel.Font = new Font("Segoe UI", 11F);
            labelNivel.Location = new Point(297, 27);
            labelNivel.Name = "labelNivel";
            labelNivel.Size = new Size(103, 33);
            labelNivel.TabIndex = 1;
            labelNivel.Text = "Nivel: 1";
            // 
            // labelPuntos
            // 
            labelPuntos.Font = new Font("Segoe UI", 11F);
            labelPuntos.Location = new Point(423, 27);
            labelPuntos.Name = "labelPuntos";
            labelPuntos.Size = new Size(137, 33);
            labelPuntos.TabIndex = 2;
            labelPuntos.Text = "Puntos: 0";
            // 
            // labelParejas
            // 
            labelParejas.Font = new Font("Segoe UI", 11F);
            labelParejas.Location = new Point(577, 27);
            labelParejas.Name = "labelParejas";
            labelParejas.Size = new Size(149, 33);
            labelParejas.TabIndex = 3;
            labelParejas.Text = "Parejas: 0/4";
            // 
            // labelTiempo
            // 
            labelTiempo.Font = new Font("Segoe UI", 11F);
            labelTiempo.Location = new Point(743, 27);
            labelTiempo.Name = "labelTiempo";
            labelTiempo.Size = new Size(149, 33);
            labelTiempo.TabIndex = 4;
            labelTiempo.Text = "Tiempo: 30";
            // 
            // panelJuego
            // 
            panelJuego.BorderStyle = BorderStyle.FixedSingle;
            panelJuego.Location = new Point(29, 93);
            panelJuego.Margin = new Padding(3, 4, 3, 4);
            panelJuego.Name = "panelJuego";
            panelJuego.Size = new Size(868, 559);
            panelJuego.TabIndex = 5;
            // 
            // botonNuevo
            // 
            botonNuevo.Font = new Font("Segoe UI", 10F);
            botonNuevo.Location = new Point(251, 680);
            botonNuevo.Margin = new Padding(3, 4, 3, 4);
            botonNuevo.Name = "botonNuevo";
            botonNuevo.Size = new Size(149, 51);
            botonNuevo.TabIndex = 6;
            botonNuevo.Text = "Nuevo";
            botonNuevo.UseVisualStyleBackColor = true;
            botonNuevo.Click += botonNuevo_Click;
            // 
            // botonVolver
            // 
            botonVolver.Font = new Font("Segoe UI", 10F);
            botonVolver.Location = new Point(434, 680);
            botonVolver.Margin = new Padding(3, 4, 3, 4);
            botonVolver.Name = "botonVolver";
            botonVolver.Size = new Size(171, 51);
            botonVolver.TabIndex = 7;
            botonVolver.Text = "Volver al menú";
            botonVolver.UseVisualStyleBackColor = true;
            botonVolver.Click += botonVolver_Click;
            // 
            // reloj
            // 
            reloj.Interval = 1000;
            reloj.Tick += reloj_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 760);
            Controls.Add(labelTitulo);
            Controls.Add(labelNivel);
            Controls.Add(labelPuntos);
            Controls.Add(labelParejas);
            Controls.Add(labelTiempo);
            Controls.Add(panelJuego);
            Controls.Add(botonNuevo);
            Controls.Add(botonVolver);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Juego";
            Load += Form2_Load;
            ResumeLayout(false);
        }
    }
}