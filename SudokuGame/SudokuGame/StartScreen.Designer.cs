namespace SudokuGame
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.pnl_timeTemplate = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.pnl_timeTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_start.Location = new System.Drawing.Point(331, 168);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(127, 41);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            this.btn_start.MouseEnter += new System.EventHandler(this.btn_start_MouseEnter);
            this.btn_start.MouseLeave += new System.EventHandler(this.btn_start_MouseLeave);
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.Color.Transparent;
            this.btn_quit.FlatAppearance.BorderSize = 0;
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_quit.Location = new System.Drawing.Point(331, 228);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(127, 41);
            this.btn_quit.TabIndex = 3;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            this.btn_quit.MouseEnter += new System.EventHandler(this.btn_quit_MouseEnter);
            this.btn_quit.MouseLeave += new System.EventHandler(this.btn_quit_MouseLeave);
            // 
            // pnl_timeTemplate
            // 
            this.pnl_timeTemplate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_timeTemplate.BackgroundImage")));
            this.pnl_timeTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_timeTemplate.Controls.Add(this.lbl_time);
            this.pnl_timeTemplate.Location = new System.Drawing.Point(310, 96);
            this.pnl_timeTemplate.Name = "pnl_timeTemplate";
            this.pnl_timeTemplate.Size = new System.Drawing.Size(165, 44);
            this.pnl_timeTemplate.TabIndex = 4;
            this.pnl_timeTemplate.Visible = false;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_time.Location = new System.Drawing.Point(41, 9);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(92, 25);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "00:00:00";
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnl_timeTemplate);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_start);
            this.Name = "StartScreen";
            this.Size = new System.Drawing.Size(781, 449);
            this.pnl_timeTemplate.ResumeLayout(false);
            this.pnl_timeTemplate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Panel pnl_timeTemplate;
        private System.Windows.Forms.Label lbl_time;
    }
}
