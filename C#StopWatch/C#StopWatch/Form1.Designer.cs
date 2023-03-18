namespace C_StopWatch
{
    partial class Stop_Watch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stop_Watch));
            this.timerLabel = new System.Windows.Forms.Label();
            this.startStopButton = new System.Windows.Forms.Button();
            this.lapTimesListBox = new System.Windows.Forms.ListBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.lapButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerLabel
            // 
            resources.ApplyResources(this.timerLabel, "timerLabel");
            this.timerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.timerLabel.Name = "timerLabel";
            // 
            // startStopButton
            // 
            resources.ApplyResources(this.startStopButton, "startStopButton");
            this.startStopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.startStopButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.startStopButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.UseVisualStyleBackColor = false;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // lapTimesListBox
            // 
            resources.ApplyResources(this.lapTimesListBox, "lapTimesListBox");
            this.lapTimesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lapTimesListBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lapTimesListBox.FormattingEnabled = true;
            this.lapTimesListBox.Name = "lapTimesListBox";
            // 
            // resetButton
            // 
            resources.ApplyResources(this.resetButton, "resetButton");
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.resetButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.resetButton.Name = "resetButton";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // lapButton
            // 
            resources.ApplyResources(this.lapButton, "lapButton");
            this.lapButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lapButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lapButton.Name = "lapButton";
            this.lapButton.UseVisualStyleBackColor = false;
            this.lapButton.Click += new System.EventHandler(this.lapButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Stop_Watch
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.Controls.Add(this.lapButton);
            this.Controls.Add(this.lapTimesListBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.timerLabel);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MaximizeBox = false;
            this.Name = "Stop_Watch";
            this.Opacity = 0.95D;
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.ListBox lapTimesListBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button lapButton;
        private System.Windows.Forms.Timer timer1;
    }
}

