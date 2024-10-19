namespace Blackjack
{
    partial class frmJogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJogo));
            lblPontosDealer = new Label();
            lblPontosJogador = new Label();
            pbCartaDealer1 = new PictureBox();
            pbCartaJogador1 = new PictureBox();
            pbCartaDealer2 = new PictureBox();
            pbCartaJogador2 = new PictureBox();
            pbCartaJogador3 = new PictureBox();
            pbCartaJogador4 = new PictureBox();
            pbCartaJogador5 = new PictureBox();
            btnReiniciar = new Button();
            btnParar = new Button();
            btnPedirCarta = new Button();
            ((System.ComponentModel.ISupportInitialize)pbCartaDealer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCartaJogador1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCartaDealer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCartaJogador2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCartaJogador3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCartaJogador4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCartaJogador5).BeginInit();
            SuspendLayout();
            // 
            // lblPontosDealer
            // 
            lblPontosDealer.AutoSize = true;
            lblPontosDealer.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblPontosDealer.ForeColor = SystemColors.ControlLightLight;
            lblPontosDealer.Location = new Point(43, 25);
            lblPontosDealer.Name = "lblPontosDealer";
            lblPontosDealer.Size = new Size(116, 23);
            lblPontosDealer.TabIndex = 0;
            lblPontosDealer.Text = "Pontos Dealer";
            // 
            // lblPontosJogador
            // 
            lblPontosJogador.AutoSize = true;
            lblPontosJogador.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblPontosJogador.ForeColor = SystemColors.ControlLightLight;
            lblPontosJogador.Location = new Point(43, 541);
            lblPontosJogador.Name = "lblPontosJogador";
            lblPontosJogador.Size = new Size(129, 23);
            lblPontosJogador.TabIndex = 1;
            lblPontosJogador.Text = "Pontos Jogador";
            // 
            // pbCartaDealer1
            // 
            pbCartaDealer1.Location = new Point(43, 61);
            pbCartaDealer1.Name = "pbCartaDealer1";
            pbCartaDealer1.Size = new Size(141, 213);
            pbCartaDealer1.SizeMode = PictureBoxSizeMode.Zoom;
            pbCartaDealer1.TabIndex = 2;
            pbCartaDealer1.TabStop = false;
            // 
            // pbCartaJogador1
            // 
            pbCartaJogador1.Location = new Point(43, 297);
            pbCartaJogador1.Name = "pbCartaJogador1";
            pbCartaJogador1.Size = new Size(141, 213);
            pbCartaJogador1.SizeMode = PictureBoxSizeMode.Zoom;
            pbCartaJogador1.TabIndex = 3;
            pbCartaJogador1.TabStop = false;
            // 
            // pbCartaDealer2
            // 
            pbCartaDealer2.Location = new Point(80, 61);
            pbCartaDealer2.Name = "pbCartaDealer2";
            pbCartaDealer2.Size = new Size(141, 213);
            pbCartaDealer2.SizeMode = PictureBoxSizeMode.Zoom;
            pbCartaDealer2.TabIndex = 4;
            pbCartaDealer2.TabStop = false;
            // 
            // pbCartaJogador2
            // 
            pbCartaJogador2.Location = new Point(80, 297);
            pbCartaJogador2.Name = "pbCartaJogador2";
            pbCartaJogador2.Size = new Size(141, 213);
            pbCartaJogador2.SizeMode = PictureBoxSizeMode.Zoom;
            pbCartaJogador2.TabIndex = 5;
            pbCartaJogador2.TabStop = false;
            // 
            // pbCartaJogador3
            // 
            pbCartaJogador3.Location = new Point(118, 297);
            pbCartaJogador3.Name = "pbCartaJogador3";
            pbCartaJogador3.Size = new Size(141, 213);
            pbCartaJogador3.SizeMode = PictureBoxSizeMode.Zoom;
            pbCartaJogador3.TabIndex = 6;
            pbCartaJogador3.TabStop = false;
            // 
            // pbCartaJogador4
            // 
            pbCartaJogador4.Location = new Point(157, 297);
            pbCartaJogador4.Name = "pbCartaJogador4";
            pbCartaJogador4.Size = new Size(141, 213);
            pbCartaJogador4.SizeMode = PictureBoxSizeMode.Zoom;
            pbCartaJogador4.TabIndex = 7;
            pbCartaJogador4.TabStop = false;
            // 
            // pbCartaJogador5
            // 
            pbCartaJogador5.Location = new Point(195, 297);
            pbCartaJogador5.Name = "pbCartaJogador5";
            pbCartaJogador5.Size = new Size(141, 213);
            pbCartaJogador5.SizeMode = PictureBoxSizeMode.Zoom;
            pbCartaJogador5.TabIndex = 8;
            pbCartaJogador5.TabStop = false;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Font = new Font("Segoe UI", 10.2F);
            btnReiniciar.Location = new Point(498, 25);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(117, 37);
            btnReiniciar.TabIndex = 9;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btnParar
            // 
            btnParar.Font = new Font("Segoe UI", 10.2F);
            btnParar.Location = new Point(498, 223);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(117, 37);
            btnParar.TabIndex = 10;
            btnParar.Text = "Parar";
            btnParar.UseVisualStyleBackColor = true;
            btnParar.Click += btnParar_Click;
            // 
            // btnPedirCarta
            // 
            btnPedirCarta.Font = new Font("Segoe UI", 10.2F);
            btnPedirCarta.Location = new Point(498, 273);
            btnPedirCarta.Name = "btnPedirCarta";
            btnPedirCarta.Size = new Size(117, 37);
            btnPedirCarta.TabIndex = 11;
            btnPedirCarta.Text = "Pedir Carta";
            btnPedirCarta.UseVisualStyleBackColor = true;
            btnPedirCarta.Click += btnPedirCarta_Click;
            // 
            // frmJogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(650, 584);
            Controls.Add(btnPedirCarta);
            Controls.Add(btnParar);
            Controls.Add(btnReiniciar);
            Controls.Add(pbCartaJogador5);
            Controls.Add(pbCartaJogador4);
            Controls.Add(pbCartaJogador3);
            Controls.Add(pbCartaJogador2);
            Controls.Add(pbCartaDealer2);
            Controls.Add(pbCartaJogador1);
            Controls.Add(pbCartaDealer1);
            Controls.Add(lblPontosJogador);
            Controls.Add(lblPontosDealer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmJogo";
            Text = "Blackjack";
            ((System.ComponentModel.ISupportInitialize)pbCartaDealer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCartaJogador1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCartaDealer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCartaJogador2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCartaJogador3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCartaJogador4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCartaJogador5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPontosDealer;
        private Label lblPontosJogador;
        private PictureBox pbCartaDealer1;
        private PictureBox pbCartaJogador1;
        private PictureBox pbCartaDealer2;
        private PictureBox pbCartaJogador2;
        private PictureBox pbCartaJogador3;
        private PictureBox pbCartaJogador4;
        private PictureBox pbCartaJogador5;
        private Button btnReiniciar;
        private Button btnParar;
        private Button btnPedirCarta;
    }
}
