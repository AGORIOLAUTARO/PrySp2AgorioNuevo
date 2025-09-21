namespace PrySp2AgorioNuevo
{
    partial class frmSp2Agorio
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
            lblDistancia.BackColor = Color.White;
            lblDistancia.Location = new Point(53, 69);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(70, 20);
            lblDistancia.TabIndex = 0;
            lblDistancia.Text = "Distancia";
            // 
            // lblCantDias
            // 
            lblCantDias.AutoSize = true;
            lblCantDias.BackColor = Color.White;
            lblCantDias.Location = new Point(53, 147);
            lblCantDias.Name = "lblCantDias";
            lblCantDias.Size = new Size(121, 20);
            lblCantDias.TabIndex = 1;
            lblCantDias.Text = "Cantidad de días";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(63, 239);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 29);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Enabled = false;
            btnCalcular.Location = new Point(197, 239);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 29);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(197, 69);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(125, 27);
            txtDistancia.TabIndex = 4;
            txtDistancia.TextChanged += txtDistancia_TextChanged;
            // 
            // nudCantDias
            // 
            nudCantDias.Enabled = false;
            nudCantDias.Location = new Point(197, 145);
            nudCantDias.Name = "nudCantDias";
            nudCantDias.Size = new Size(150, 27);
            nudCantDias.TabIndex = 5;
            nudCantDias.ValueChanged += nudCantDias_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(393, 344);
            Controls.Add(nudCantDias);
            Controls.Add(txtDistancia);
            Controls.Add(btnCalcular);
            Controls.Add(btnCancelar);
            Controls.Add(lblCantDias);
            Controls.Add(lblDistancia);
            Name = "Form1";
            Text = "frmSP2Agorio";
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
