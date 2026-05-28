namespace JuegoMemoria
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button botonNivel1;
        private System.Windows.Forms.Button botonNivel2;
        private System.Windows.Forms.Button botonNivel3;
        private System.Windows.Forms.Button botonAyuda;
        private System.Windows.Forms.Button botonSalir;

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
            this.titulo = new System.Windows.Forms.Label();
            this.botonNivel1 = new System.Windows.Forms.Button();
            this.botonNivel2 = new System.Windows.Forms.Button();
            this.botonNivel3 = new System.Windows.Forms.Button();
            this.botonAyuda = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.titulo.AutoSize = false;
            this.titulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.titulo.Location = new System.Drawing.Point(70, 35);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(360, 60);
            this.titulo.Text = "Juego Encontrados";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.botonNivel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.botonNivel1.Location = new System.Drawing.Point(145, 120);
            this.botonNivel1.Name = "botonNivel1";
            this.botonNivel1.Size = new System.Drawing.Size(210, 42);
            this.botonNivel1.Text = "Nivel 1 - 2 x 4 - 30 seg";
            this.botonNivel1.UseVisualStyleBackColor = true;
            this.botonNivel1.Click += new System.EventHandler(this.botonNivel1_Click);

            this.botonNivel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.botonNivel2.Location = new System.Drawing.Point(145, 175);
            this.botonNivel2.Name = "botonNivel2";
            this.botonNivel2.Size = new System.Drawing.Size(210, 42);
            this.botonNivel2.Text = "Nivel 2 - 3 x 6 - 60 seg";
            this.botonNivel2.UseVisualStyleBackColor = true;
            this.botonNivel2.Click += new System.EventHandler(this.botonNivel2_Click);

            this.botonNivel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.botonNivel3.Location = new System.Drawing.Point(145, 230);
            this.botonNivel3.Name = "botonNivel3";
            this.botonNivel3.Size = new System.Drawing.Size(210, 42);
            this.botonNivel3.Text = "Nivel 3 - 4 x 8 - 120 seg";
            this.botonNivel3.UseVisualStyleBackColor = true;
            this.botonNivel3.Click += new System.EventHandler(this.botonNivel3_Click);

            this.botonAyuda.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.botonAyuda.Location = new System.Drawing.Point(145, 295);
            this.botonAyuda.Name = "botonAyuda";
            this.botonAyuda.Size = new System.Drawing.Size(210, 42);
            this.botonAyuda.Text = "Ayuda";
            this.botonAyuda.UseVisualStyleBackColor = true;
            this.botonAyuda.Click += new System.EventHandler(this.botonAyuda_Click);

            this.botonSalir.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.botonSalir.Location = new System.Drawing.Point(145, 350);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(210, 42);
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 440);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.botonNivel1);
            this.Controls.Add(this.botonNivel2);
            this.Controls.Add(this.botonNivel3);
            this.Controls.Add(this.botonAyuda);
            this.Controls.Add(this.botonSalir);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
        }
    }
}
