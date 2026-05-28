namespace JuegoMemoria
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelAyuda;
        private System.Windows.Forms.Button botonCerrar;

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
            this.labelAyuda = new System.Windows.Forms.Label();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.labelAyuda.AutoSize = false;
            this.labelAyuda.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelAyuda.Location = new System.Drawing.Point(25, 25);
            this.labelAyuda.Name = "labelAyuda";
            this.labelAyuda.Size = new System.Drawing.Size(360, 170);
            this.labelAyuda.Text = "Instrucciones:\n\n1. Haz clic sobre dos cartas.\n2. Si las cartas son iguales, quedan descubiertas.\n3. Si son diferentes, se vuelven a tapar.\n4. Ganas cuando encuentres todas las parejas antes de que acabe el tiempo.";

            this.botonCerrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.botonCerrar.Location = new System.Drawing.Point(140, 215);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(120, 35);
            this.botonCerrar.Text = "Cerrar";
            this.botonCerrar.UseVisualStyleBackColor = true;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 280);
            this.Controls.Add(this.labelAyuda);
            this.Controls.Add(this.botonCerrar);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ayuda";
            this.ResumeLayout(false);
        }
    }
}