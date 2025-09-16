namespace PrySp2AgorioNuevo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDistancia = new Label();
            lblCantDias = new Label();
            btnCancelar = new Button();
            btnCalcular = new Button();
            txtDistancia = new TextBox();
            nudCantDias = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudCantDias).BeginInit();
            SuspendLayout();
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Location = new Point(100, 71);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(70, 20);
            lblDistancia.TabIndex = 0;
            lblDistancia.Text = "Distancia";
            // 
            // lblCantDias
            // 
            lblCantDias.AutoSize = true;
            lblCantDias.Location = new Point(110, 182);
            lblCantDias.Name = "lblCantDias";
            lblCantDias.Size = new Size(121, 20);
            lblCantDias.TabIndex = 1;
            lblCantDias.Text = "Cantidad de días";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(197, 316);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Enabled = false;
            btnCalcular.Location = new Point(384, 316);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(337, 69);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(125, 27);
            txtDistancia.TabIndex = 4;
            txtDistancia.TextChanged += txtDistancia_TextChanged;
            // 
            // nudCantDias
            // 
            nudCantDias.Enabled = false;
            nudCantDias.Location = new Point(343, 177);
            nudCantDias.Name = "nudCantDias";
            nudCantDias.Size = new Size(150, 27);
            nudCantDias.TabIndex = 5;
            nudCantDias.ValueChanged += nudCantDias_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudCantDias);
            Controls.Add(txtDistancia);
            Controls.Add(btnCalcular);
            Controls.Add(btnCancelar);
            Controls.Add(lblCantDias);
            Controls.Add(lblDistancia);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudCantDias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDistancia;
        private Label lblCantDias;
        private Button btnCancelar;
        private Button btnCalcular;
        private TextBox txtDistancia;
        private NumericUpDown nudCantDias;
    }
}
