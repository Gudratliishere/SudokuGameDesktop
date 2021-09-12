namespace SudokuGame
{
    partial class Game
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.pnl_time = new System.Windows.Forms.Panel();
            this.flp_sudokuTemplate = new System.Windows.Forms.FlowLayoutPanel();
            this.timer_gameTime = new System.Windows.Forms.Timer(this.components);
            this.lbl_numberOfMistakes = new System.Windows.Forms.Label();
            this.btn_tip = new System.Windows.Forms.Button();
            this.lbl_numberOfTips = new System.Windows.Forms.Label();
            this.pnl_time.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_play.BackgroundImage")));
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Location = new System.Drawing.Point(660, 165);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(42, 40);
            this.btn_play.TabIndex = 1;
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            this.btn_play.MouseEnter += new System.EventHandler(this.btn_play_MouseEnter);
            // 
            // btn_stop
            // 
            this.btn_stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_stop.BackgroundImage")));
            this.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_stop.FlatAppearance.BorderSize = 0;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_stop.Location = new System.Drawing.Point(636, 367);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(91, 35);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "Exit";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.White;
            this.lbl_time.Location = new System.Drawing.Point(24, 13);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(92, 25);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "00:00:00";
            // 
            // pnl_time
            // 
            this.pnl_time.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_time.BackgroundImage")));
            this.pnl_time.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_time.Controls.Add(this.lbl_time);
            this.pnl_time.Location = new System.Drawing.Point(611, 223);
            this.pnl_time.Name = "pnl_time";
            this.pnl_time.Size = new System.Drawing.Size(140, 51);
            this.pnl_time.TabIndex = 2;
            // 
            // flp_sudokuTemplate
            // 
            this.flp_sudokuTemplate.BackColor = System.Drawing.Color.White;
            this.flp_sudokuTemplate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flp_sudokuTemplate.BackgroundImage")));
            this.flp_sudokuTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flp_sudokuTemplate.Location = new System.Drawing.Point(188, 23);
            this.flp_sudokuTemplate.Name = "flp_sudokuTemplate";
            this.flp_sudokuTemplate.Size = new System.Drawing.Size(405, 405);
            this.flp_sudokuTemplate.TabIndex = 6;
            // 
            // timer_gameTime
            // 
            this.timer_gameTime.Interval = 1000;
            this.timer_gameTime.Tick += new System.EventHandler(this.timer_gameTime_Tick);
            // 
            // lbl_numberOfMistakes
            // 
            this.lbl_numberOfMistakes.AutoSize = true;
            this.lbl_numberOfMistakes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numberOfMistakes.ForeColor = System.Drawing.Color.White;
            this.lbl_numberOfMistakes.Location = new System.Drawing.Point(30, 367);
            this.lbl_numberOfMistakes.Name = "lbl_numberOfMistakes";
            this.lbl_numberOfMistakes.Size = new System.Drawing.Size(88, 19);
            this.lbl_numberOfMistakes.TabIndex = 7;
            this.lbl_numberOfMistakes.Text = "Mistakes: 0";
            // 
            // btn_tip
            // 
            this.btn_tip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tip.BackgroundImage")));
            this.btn_tip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tip.FlatAppearance.BorderSize = 0;
            this.btn_tip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tip.Location = new System.Drawing.Point(34, 74);
            this.btn_tip.Name = "btn_tip";
            this.btn_tip.Size = new System.Drawing.Size(42, 40);
            this.btn_tip.TabIndex = 8;
            this.btn_tip.UseVisualStyleBackColor = true;
            this.btn_tip.Click += new System.EventHandler(this.btn_tip_Click);
            // 
            // lbl_numberOfTips
            // 
            this.lbl_numberOfTips.AutoSize = true;
            this.lbl_numberOfTips.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numberOfTips.ForeColor = System.Drawing.Color.White;
            this.lbl_numberOfTips.Location = new System.Drawing.Point(30, 334);
            this.lbl_numberOfTips.Name = "lbl_numberOfTips";
            this.lbl_numberOfTips.Size = new System.Drawing.Size(59, 19);
            this.lbl_numberOfTips.TabIndex = 9;
            this.lbl_numberOfTips.Text = "Tips: 0";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbl_numberOfTips);
            this.Controls.Add(this.btn_tip);
            this.Controls.Add(this.lbl_numberOfMistakes);
            this.Controls.Add(this.flp_sudokuTemplate);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.pnl_time);
            this.Controls.Add(this.btn_play);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(781, 449);
            this.pnl_time.ResumeLayout(false);
            this.pnl_time.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Panel pnl_time;
        private System.Windows.Forms.FlowLayoutPanel flp_sudokuTemplate;
        private System.Windows.Forms.Timer timer_gameTime;
        private System.Windows.Forms.Label lbl_numberOfMistakes;
        private System.Windows.Forms.Button btn_tip;
        private System.Windows.Forms.Label lbl_numberOfTips;
    }
}
