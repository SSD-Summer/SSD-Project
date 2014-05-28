namespace Mustashe_ic
{
    partial class gamePlayForm
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
            this.label_timer_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Score_title = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.panel_tilePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label_timer_title
            // 
            this.label_timer_title.AutoSize = true;
            this.label_timer_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer_title.Location = new System.Drawing.Point(621, 86);
            this.label_timer_title.Name = "label_timer_title";
            this.label_timer_title.Size = new System.Drawing.Size(159, 37);
            this.label_timer_title.TabIndex = 0;
            this.label_timer_title.Text = "Time Left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lives";
            // 
            // label_Score_title
            // 
            this.label_Score_title.AutoSize = true;
            this.label_Score_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Score_title.Location = new System.Drawing.Point(1144, 22);
            this.label_Score_title.Name = "label_Score_title";
            this.label_Score_title.Size = new System.Drawing.Size(100, 37);
            this.label_Score_title.TabIndex = 2;
            this.label_Score_title.Text = "Score";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.Location = new System.Drawing.Point(1284, 22);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(36, 37);
            this.label_score.TabIndex = 3;
            this.label_score.Text = "0";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.Location = new System.Drawing.Point(628, 22);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(103, 37);
            this.label_time.TabIndex = 4;
            this.label_time.Text = "00:30";
            // 
            // panel_tilePanel
            // 
            this.panel_tilePanel.Location = new System.Drawing.Point(12, 136);
            this.panel_tilePanel.Name = "panel_tilePanel";
            this.panel_tilePanel.Size = new System.Drawing.Size(1444, 969);
            this.panel_tilePanel.TabIndex = 5;
            // 
            // gamePlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 1117);
            this.Controls.Add(this.panel_tilePanel);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_Score_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_timer_title);
            this.Name = "gamePlayForm";
            this.Text = "gamePlayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_timer_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Score_title;
        public System.Windows.Forms.Label label_score;
        public System.Windows.Forms.Label label_time;
        public System.Windows.Forms.Panel panel_tilePanel;
    }
}