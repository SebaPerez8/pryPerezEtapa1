namespace pryPerezEtapa1
{
    partial class frmFirma
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
            picDibujo = new PictureBox();
            btnGrabar = new Button();
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)picDibujo).BeginInit();
            SuspendLayout();
            // 
            // picDibujo
            // 
            picDibujo.BackColor = SystemColors.ButtonHighlight;
            picDibujo.Location = new Point(23, 12);
            picDibujo.Name = "picDibujo";
            picDibujo.Size = new Size(579, 274);
            picDibujo.TabIndex = 0;
            picDibujo.TabStop = false;
            picDibujo.Paint += PicDibujo_Paint;
            picDibujo.MouseDown += PicDibujo_MouseDown;
            picDibujo.MouseMove += PicDibujo_MouseMove;
            picDibujo.MouseUp += PicDibujo_MouseUp;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(23, 292);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(105, 23);
            btnGrabar.TabIndex = 1;
            btnGrabar.Text = "Grabar firma";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(486, 295);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(105, 23);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // frmFirma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 330);
            Controls.Add(btnBorrar);
            Controls.Add(btnGrabar);
            Controls.Add(picDibujo);
            Name = "frmFirma";
            Text = "Etapa 1 - DIBUJAR";
            MouseDown += PicDibujo_MouseDown;
            MouseMove += PicDibujo_MouseMove;
            MouseUp += PicDibujo_MouseUp;
            ((System.ComponentModel.ISupportInitialize)picDibujo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picDibujo;
        private Button btnGrabar;
        private Button btnBorrar;
    }
}
