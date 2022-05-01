namespace IC20_KS_DeckShuffler
{
    partial class DeckShuffler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dealButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.cardsDealtListBox = new System.Windows.Forms.ListBox();
            this.card1PictureBox = new System.Windows.Forms.PictureBox();
            this.card2PictureBox = new System.Windows.Forms.PictureBox();
            this.card3PictureBox = new System.Windows.Forms.PictureBox();
            this.card4PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.card1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(176, 297);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(94, 58);
            this.dealButton.TabIndex = 0;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(425, 297);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(85, 58);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // cardsDealtListBox
            // 
            this.cardsDealtListBox.FormattingEnabled = true;
            this.cardsDealtListBox.Location = new System.Drawing.Point(176, 399);
            this.cardsDealtListBox.Name = "cardsDealtListBox";
            this.cardsDealtListBox.Size = new System.Drawing.Size(334, 121);
            this.cardsDealtListBox.TabIndex = 2;
            // 
            // card1PictureBox
            // 
            this.card1PictureBox.Location = new System.Drawing.Point(53, 59);
            this.card1PictureBox.Name = "card1PictureBox";
            this.card1PictureBox.Size = new System.Drawing.Size(112, 141);
            this.card1PictureBox.TabIndex = 3;
            this.card1PictureBox.TabStop = false;
            // 
            // card2PictureBox
            // 
            this.card2PictureBox.Location = new System.Drawing.Point(203, 59);
            this.card2PictureBox.Name = "card2PictureBox";
            this.card2PictureBox.Size = new System.Drawing.Size(112, 141);
            this.card2PictureBox.TabIndex = 4;
            this.card2PictureBox.TabStop = false;
            // 
            // card3PictureBox
            // 
            this.card3PictureBox.Location = new System.Drawing.Point(364, 59);
            this.card3PictureBox.Name = "card3PictureBox";
            this.card3PictureBox.Size = new System.Drawing.Size(112, 141);
            this.card3PictureBox.TabIndex = 5;
            this.card3PictureBox.TabStop = false;
            // 
            // card4PictureBox
            // 
            this.card4PictureBox.Location = new System.Drawing.Point(529, 59);
            this.card4PictureBox.Name = "card4PictureBox";
            this.card4PictureBox.Size = new System.Drawing.Size(112, 141);
            this.card4PictureBox.TabIndex = 6;
            this.card4PictureBox.TabStop = false;
            // 
            // DeckShuffler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 591);
            this.Controls.Add(this.card4PictureBox);
            this.Controls.Add(this.card3PictureBox);
            this.Controls.Add(this.card2PictureBox);
            this.Controls.Add(this.card1PictureBox);
            this.Controls.Add(this.cardsDealtListBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.dealButton);
            this.Name = "DeckShuffler";
            this.Text = "Deck Shuffler";
            this.Load += new System.EventHandler(this.DeckShuffler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.card1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListBox cardsDealtListBox;
        private System.Windows.Forms.PictureBox card1PictureBox;
        private System.Windows.Forms.PictureBox card2PictureBox;
        private System.Windows.Forms.PictureBox card3PictureBox;
        private System.Windows.Forms.PictureBox card4PictureBox;
    }
}

