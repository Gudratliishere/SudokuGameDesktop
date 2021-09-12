namespace SudokuGame
{
    partial class LevelSelection
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
            this.btn_easy = new System.Windows.Forms.Button();
            this.btn_middle = new System.Windows.Forms.Button();
            this.btn_hard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_easy
            // 
            this.btn_easy.BackColor = System.Drawing.Color.Transparent;
            this.btn_easy.FlatAppearance.BorderSize = 0;
            this.btn_easy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_easy.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_easy.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_easy.Location = new System.Drawing.Point(311, 137);
            this.btn_easy.Name = "btn_easy";
            this.btn_easy.Size = new System.Drawing.Size(127, 41);
            this.btn_easy.TabIndex = 3;
            this.btn_easy.Text = "Easy";
            this.btn_easy.UseVisualStyleBackColor = false;
            this.btn_easy.Click += new System.EventHandler(this.btn_easy_Click);
            // 
            // btn_middle
            // 
            this.btn_middle.BackColor = System.Drawing.Color.Transparent;
            this.btn_middle.FlatAppearance.BorderSize = 0;
            this.btn_middle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_middle.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_middle.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_middle.Location = new System.Drawing.Point(311, 206);
            this.btn_middle.Name = "btn_middle";
            this.btn_middle.Size = new System.Drawing.Size(127, 41);
            this.btn_middle.TabIndex = 4;
            this.btn_middle.Text = "Middle";
            this.btn_middle.UseVisualStyleBackColor = false;
            this.btn_middle.Click += new System.EventHandler(this.btn_middle_Click);
            // 
            // btn_hard
            // 
            this.btn_hard.BackColor = System.Drawing.Color.Transparent;
            this.btn_hard.FlatAppearance.BorderSize = 0;
            this.btn_hard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hard.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hard.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_hard.Location = new System.Drawing.Point(311, 279);
            this.btn_hard.Name = "btn_hard";
            this.btn_hard.Size = new System.Drawing.Size(127, 41);
            this.btn_hard.TabIndex = 5;
            this.btn_hard.Text = "Hard";
            this.btn_hard.UseVisualStyleBackColor = false;
            this.btn_hard.Click += new System.EventHandler(this.btn_hard_Click);
            // 
            // LevelSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_hard);
            this.Controls.Add(this.btn_middle);
            this.Controls.Add(this.btn_easy);
            this.Name = "LevelSelection";
            this.Size = new System.Drawing.Size(781, 449);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_easy;
        private System.Windows.Forms.Button btn_middle;
        private System.Windows.Forms.Button btn_hard;
    }
}
