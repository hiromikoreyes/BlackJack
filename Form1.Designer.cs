
namespace BlackJack
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
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDeal = new System.Windows.Forms.Button();
            this.lblDealerCards = new System.Windows.Forms.Label();
            this.lblPlayerCards = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerValue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHit.Enabled = false;
            this.btnHit.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHit.Location = new System.Drawing.Point(43, 364);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(124, 60);
            this.btnHit.TabIndex = 0;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStand.Enabled = false;
            this.btnStand.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStand.Location = new System.Drawing.Point(173, 364);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(124, 60);
            this.btnStand.TabIndex = 1;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = false;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(43, 335);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(360, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "New Game";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeal.Enabled = false;
            this.btnDeal.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeal.Location = new System.Drawing.Point(303, 364);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(100, 60);
            this.btnDeal.TabIndex = 4;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = false;
            this.btnDeal.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDealerCards
            // 
            this.lblDealerCards.AutoSize = true;
            this.lblDealerCards.Font = new System.Drawing.Font("Ink Free", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDealerCards.ForeColor = System.Drawing.Color.Transparent;
            this.lblDealerCards.Location = new System.Drawing.Point(39, 29);
            this.lblDealerCards.Name = "lblDealerCards";
            this.lblDealerCards.Size = new System.Drawing.Size(170, 26);
            this.lblDealerCards.TabIndex = 5;
            this.lblDealerCards.Text = "DEALER CARDS";
            // 
            // lblPlayerCards
            // 
            this.lblPlayerCards.AutoSize = true;
            this.lblPlayerCards.Font = new System.Drawing.Font("Ink Free", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPlayerCards.ForeColor = System.Drawing.Color.Transparent;
            this.lblPlayerCards.Location = new System.Drawing.Point(39, 167);
            this.lblPlayerCards.Name = "lblPlayerCards";
            this.lblPlayerCards.Size = new System.Drawing.Size(166, 26);
            this.lblPlayerCards.TabIndex = 6;
            this.lblPlayerCards.Text = "PLAYER CARDS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(458, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 52);
            this.label1.TabIndex = 7;
            this.label1.Text = "BLACKJACK    \r\n                Miko Reyes (2022)\r\n";
            // 
            // lblPlayerValue
            // 
            this.lblPlayerValue.AutoSize = true;
            this.lblPlayerValue.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerValue.ForeColor = System.Drawing.Color.Transparent;
            this.lblPlayerValue.Location = new System.Drawing.Point(43, 294);
            this.lblPlayerValue.Name = "lblPlayerValue";
            this.lblPlayerValue.Size = new System.Drawing.Size(127, 23);
            this.lblPlayerValue.TabIndex = 9;
            this.lblPlayerValue.Text = "Player Value: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlackJack.Properties.Resources.boredape1;
            this.pictureBox1.Location = new System.Drawing.Point(472, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPlayerValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayerCards);
            this.Controls.Add(this.lblDealerCards);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Name = "Form1";
            this.Text = "Black Jack!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Label lblDealerCards;
        private System.Windows.Forms.Label lblPlayerCards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerValue;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

