using System;
using System.Drawing;

namespace assignment6_yevhenii
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

        private int ComputerRandomSelect()
        {
            return new Random().Next(1, 4);
        }

        private void ShowComputerDecision(int players_select, int computer_select)
        {
            this.picture_pc.Image = Image.FromFile(paths[computer_select - 1]);
            if (players_select == computer_select)
            {
                this.label_status.Text = "Draw";
            } else if 
                (
                    (players_select == 1 && computer_select == 2)
                    || (players_select == 2 && computer_select == 3)
                    || (players_select == 3 && computer_select == 1)
                )
            {
                this.label_status.Text = "Win";
                this.label_score_player.Text = (int.Parse(this.label_score_player.Text) + 1).ToString();
            } else
            {
                this.label_status.Text = "Lose";
                this.label_score_pc.Text = (int.Parse(this.label_score_pc.Text) + 1).ToString();
            }
        }
        
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picture_stone = new System.Windows.Forms.PictureBox();
            this.picture_paper = new System.Windows.Forms.PictureBox();
            this.picture_scissors = new System.Windows.Forms.PictureBox();
            this.button_play = new System.Windows.Forms.Button();
            this.button_finish = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.picture_pc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_score_player = new System.Windows.Forms.Label();
            this.label_score_pc = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_stone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pc)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_stone
            // 
            this.picture_stone.Image = global::assignment6_yevhenii.Properties.Resources.stones;
            this.picture_stone.Location = new System.Drawing.Point(36, 300);
            this.picture_stone.Name = "picture_stone";
            this.picture_stone.Size = new System.Drawing.Size(200, 200);
            this.picture_stone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_stone.TabIndex = 0;
            this.picture_stone.TabStop = false;
            this.picture_stone.Click += new System.EventHandler(this.picture_stone_Click);
            // 
            // picture_paper
            // 
            this.picture_paper.Image = global::assignment6_yevhenii.Properties.Resources.paper;
            this.picture_paper.Location = new System.Drawing.Point(500, 300);
            this.picture_paper.Name = "picture_paper";
            this.picture_paper.Size = new System.Drawing.Size(200, 200);
            this.picture_paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_paper.TabIndex = 1;
            this.picture_paper.TabStop = false;
            this.picture_paper.Click += new System.EventHandler(this.picture_paper_Click);
            // 
            // picture_scissors
            // 
            this.picture_scissors.Image = global::assignment6_yevhenii.Properties.Resources.scissors;
            this.picture_scissors.Location = new System.Drawing.Point(267, 300);
            this.picture_scissors.Name = "picture_scissors";
            this.picture_scissors.Size = new System.Drawing.Size(200, 200);
            this.picture_scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_scissors.TabIndex = 2;
            this.picture_scissors.TabStop = false;
            this.picture_scissors.Click += new System.EventHandler(this.picture_scissors_Click);
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(754, 324);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(120, 35);
            this.button_play.TabIndex = 3;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_finish
            // 
            this.button_finish.Location = new System.Drawing.Point(754, 386);
            this.button_finish.Name = "button_finish";
            this.button_finish.Size = new System.Drawing.Size(120, 35);
            this.button_finish.TabIndex = 4;
            this.button_finish.Text = "Finish";
            this.button_finish.UseVisualStyleBackColor = true;
            this.button_finish.Click += new System.EventHandler(this.button_finish_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(754, 447);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(120, 35);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // picture_pc
            // 
            this.picture_pc.Location = new System.Drawing.Point(267, 23);
            this.picture_pc.Name = "picture_pc";
            this.picture_pc.Size = new System.Drawing.Size(200, 200);
            this.picture_pc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_pc.TabIndex = 6;
            this.picture_pc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Computer: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(31, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Player: ";
            // 
            // label_score_player
            // 
            this.label_score_player.AutoSize = true;
            this.label_score_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_score_player.Location = new System.Drawing.Point(156, 73);
            this.label_score_player.Name = "label_score_player";
            this.label_score_player.Size = new System.Drawing.Size(26, 29);
            this.label_score_player.TabIndex = 9;
            this.label_score_player.Text = "0";
            // 
            // label_score_pc
            // 
            this.label_score_pc.AutoSize = true;
            this.label_score_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_score_pc.Location = new System.Drawing.Point(156, 35);
            this.label_score_pc.Name = "label_score_pc";
            this.label_score_pc.Size = new System.Drawing.Size(26, 29);
            this.label_score_pc.TabIndex = 10;
            this.label_score_pc.Text = "0";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_status.Location = new System.Drawing.Point(326, 244);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(85, 29);
            this.label_status.TabIndex = 11;
            this.label_status.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 534);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_score_pc);
            this.Controls.Add(this.label_score_player);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture_pc);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_finish);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.picture_scissors);
            this.Controls.Add(this.picture_paper);
            this.Controls.Add(this.picture_stone);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture_stone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_stone;
        private System.Windows.Forms.PictureBox picture_paper;
        private System.Windows.Forms.PictureBox picture_scissors;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_finish;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.PictureBox picture_pc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_score_player;
        private System.Windows.Forms.Label label_score_pc;
        private System.Windows.Forms.Label label_status;
        private string[] paths = { 
            "../../resources/stones.png",
            "../../resources/scissors.png",
            "../../resources/paper.png"
        };
    }
}

