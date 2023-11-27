namespace Tic_Tac_Toe_Game
{
    partial class Form1
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
            System.Windows.Forms.Button btn_reset;
            System.Windows.Forms.Button btn_close;
            this.pb12 = new System.Windows.Forms.PictureBox();
            this.pb13 = new System.Windows.Forms.PictureBox();
            this.pb11 = new System.Windows.Forms.PictureBox();
            this.pb22 = new System.Windows.Forms.PictureBox();
            this.pb23 = new System.Windows.Forms.PictureBox();
            this.pb21 = new System.Windows.Forms.PictureBox();
            this.pb31 = new System.Windows.Forms.PictureBox();
            this.pb32 = new System.Windows.Forms.PictureBox();
            this.pb33 = new System.Windows.Forms.PictureBox();
            this.winner = new System.Windows.Forms.Label();
            this.mainLable = new System.Windows.Forms.Label();
            this.labe_turn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            btn_reset = new System.Windows.Forms.Button();
            btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb33)).BeginInit();
            this.SuspendLayout();
            // 
            // pb12
            // 
            this.pb12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb12.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb12.Location = new System.Drawing.Point(195, 59);
            this.pb12.Name = "pb12";
            this.pb12.Size = new System.Drawing.Size(96, 96);
            this.pb12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb12.TabIndex = 0;
            this.pb12.TabStop = false;
            this.pb12.Tag = "?";
            this.pb12.Click += new System.EventHandler(this.pb12_Click);
            // 
            // pb13
            // 
            this.pb13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb13.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb13.Location = new System.Drawing.Point(324, 59);
            this.pb13.Name = "pb13";
            this.pb13.Size = new System.Drawing.Size(96, 96);
            this.pb13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb13.TabIndex = 1;
            this.pb13.TabStop = false;
            this.pb13.Tag = "?";
            this.pb13.Click += new System.EventHandler(this.pb13_Click);
            // 
            // pb11
            // 
            this.pb11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb11.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb11.Location = new System.Drawing.Point(66, 59);
            this.pb11.Name = "pb11";
            this.pb11.Size = new System.Drawing.Size(96, 96);
            this.pb11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb11.TabIndex = 2;
            this.pb11.TabStop = false;
            this.pb11.Tag = "?";
            this.pb11.Click += new System.EventHandler(this.pb11_Click);
            // 
            // pb22
            // 
            this.pb22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb22.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb22.Location = new System.Drawing.Point(195, 188);
            this.pb22.Name = "pb22";
            this.pb22.Size = new System.Drawing.Size(96, 96);
            this.pb22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb22.TabIndex = 3;
            this.pb22.TabStop = false;
            this.pb22.Tag = "?";
            this.pb22.Click += new System.EventHandler(this.pb22_Click);
            // 
            // pb23
            // 
            this.pb23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb23.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb23.Location = new System.Drawing.Point(324, 188);
            this.pb23.Name = "pb23";
            this.pb23.Size = new System.Drawing.Size(96, 96);
            this.pb23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb23.TabIndex = 4;
            this.pb23.TabStop = false;
            this.pb23.Tag = "?";
            this.pb23.Click += new System.EventHandler(this.pb23_Click);
            // 
            // pb21
            // 
            this.pb21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb21.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb21.Location = new System.Drawing.Point(66, 188);
            this.pb21.Name = "pb21";
            this.pb21.Size = new System.Drawing.Size(96, 96);
            this.pb21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb21.TabIndex = 5;
            this.pb21.TabStop = false;
            this.pb21.Tag = "?";
            this.pb21.Click += new System.EventHandler(this.pb21_Click);
            // 
            // pb31
            // 
            this.pb31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb31.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb31.Location = new System.Drawing.Point(66, 317);
            this.pb31.Name = "pb31";
            this.pb31.Size = new System.Drawing.Size(96, 96);
            this.pb31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb31.TabIndex = 6;
            this.pb31.TabStop = false;
            this.pb31.Tag = "?";
            this.pb31.Click += new System.EventHandler(this.pb31_Click);
            // 
            // pb32
            // 
            this.pb32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb32.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb32.Location = new System.Drawing.Point(195, 317);
            this.pb32.Name = "pb32";
            this.pb32.Size = new System.Drawing.Size(96, 96);
            this.pb32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb32.TabIndex = 7;
            this.pb32.TabStop = false;
            this.pb32.Tag = "?";
            this.pb32.Click += new System.EventHandler(this.pb32_Click);
            // 
            // pb33
            // 
            this.pb33.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb33.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb33.Location = new System.Drawing.Point(324, 317);
            this.pb33.Name = "pb33";
            this.pb33.Size = new System.Drawing.Size(96, 96);
            this.pb33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb33.TabIndex = 8;
            this.pb33.TabStop = false;
            this.pb33.Tag = "?";
            this.pb33.Click += new System.EventHandler(this.pb33_Click);
            // 
            // btn_reset
            // 
            btn_reset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_reset.Font = new System.Drawing.Font("Tahoma", 13.2F);
            btn_reset.ForeColor = System.Drawing.Color.DeepSkyBlue;
            btn_reset.Location = new System.Drawing.Point(501, 303);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new System.Drawing.Size(319, 49);
            btn_reset.TabIndex = 11;
            btn_reset.Text = "Reset Game";
            btn_reset.UseVisualStyleBackColor = false;
            btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // winner
            // 
            this.winner.AutoSize = true;
            this.winner.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winner.ForeColor = System.Drawing.Color.Red;
            this.winner.Location = new System.Drawing.Point(623, 229);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(0, 34);
            this.winner.TabIndex = 13;
            this.winner.Click += new System.EventHandler(this.winner_Click);
            // 
            // mainLable
            // 
            this.mainLable.AutoSize = true;
            this.mainLable.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.mainLable.Location = new System.Drawing.Point(513, 229);
            this.mainLable.Name = "mainLable";
            this.mainLable.Size = new System.Drawing.Size(113, 34);
            this.mainLable.TabIndex = 12;
            this.mainLable.Text = "Winner:";
            // 
            // labe_turn
            // 
            this.labe_turn.AutoSize = true;
            this.labe_turn.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe_turn.ForeColor = System.Drawing.Color.Red;
            this.labe_turn.Location = new System.Drawing.Point(599, 188);
            this.labe_turn.Name = "labe_turn";
            this.labe_turn.Size = new System.Drawing.Size(105, 34);
            this.labe_turn.TabIndex = 15;
            this.labe_turn.Text = "player1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(513, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 34);
            this.label2.TabIndex = 14;
            this.label2.Text = "Turn: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(542, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "TIC TAC TOE";
            // 
            // btn_close
            // 
            btn_close.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_close.Font = new System.Drawing.Font("Tahoma", 13.2F);
            btn_close.ForeColor = System.Drawing.Color.DeepSkyBlue;
            btn_close.Location = new System.Drawing.Point(501, 364);
            btn_close.Name = "btn_close";
            btn_close.Size = new System.Drawing.Size(319, 49);
            btn_close.TabIndex = 18;
            btn_close.Text = "Close The Game";
            btn_close.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(884, 442);
            this.Controls.Add(btn_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labe_turn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.winner);
            this.Controls.Add(this.mainLable);
            this.Controls.Add(btn_reset);
            this.Controls.Add(this.pb33);
            this.Controls.Add(this.pb32);
            this.Controls.Add(this.pb31);
            this.Controls.Add(this.pb21);
            this.Controls.Add(this.pb23);
            this.Controls.Add(this.pb22);
            this.Controls.Add(this.pb11);
            this.Controls.Add(this.pb13);
            this.Controls.Add(this.pb12);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb33)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb12;
        private System.Windows.Forms.PictureBox pb13;
        private System.Windows.Forms.PictureBox pb11;
        private System.Windows.Forms.PictureBox pb22;
        private System.Windows.Forms.PictureBox pb23;
        private System.Windows.Forms.PictureBox pb21;
        private System.Windows.Forms.PictureBox pb31;
        private System.Windows.Forms.PictureBox pb32;
        private System.Windows.Forms.PictureBox pb33;
        private System.Windows.Forms.Label winner;
        private System.Windows.Forms.Label mainLable;
        private System.Windows.Forms.Label labe_turn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

