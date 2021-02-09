namespace SpringFieldNuclear
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.reactor1 = new System.Windows.Forms.Label();
            this.reactor2 = new System.Windows.Forms.Label();
            this.reactor1StateLabel = new System.Windows.Forms.Label();
            this.reactor2StateLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.launchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Square721 BdEx BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(8, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(322, 22);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nuclear Reactor Control";
            this.titleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // reactor1
            // 
            this.reactor1.AutoSize = true;
            this.reactor1.Location = new System.Drawing.Point(57, 80);
            this.reactor1.Name = "reactor1";
            this.reactor1.Size = new System.Drawing.Size(54, 13);
            this.reactor1.TabIndex = 1;
            this.reactor1.Text = "Reactor 1";
            // 
            // reactor2
            // 
            this.reactor2.AutoSize = true;
            this.reactor2.Location = new System.Drawing.Point(241, 80);
            this.reactor2.Name = "reactor2";
            this.reactor2.Size = new System.Drawing.Size(54, 13);
            this.reactor2.TabIndex = 2;
            this.reactor2.Text = "Reactor 2";
            // 
            // reactor1StateLabel
            // 
            this.reactor1StateLabel.BackColor = System.Drawing.Color.Green;
            this.reactor1StateLabel.Location = new System.Drawing.Point(43, 127);
            this.reactor1StateLabel.Name = "reactor1StateLabel";
            this.reactor1StateLabel.Size = new System.Drawing.Size(79, 80);
            this.reactor1StateLabel.TabIndex = 3;
            // 
            // reactor2StateLabel
            // 
            this.reactor2StateLabel.BackColor = System.Drawing.Color.Green;
            this.reactor2StateLabel.Location = new System.Drawing.Point(229, 127);
            this.reactor2StateLabel.Name = "reactor2StateLabel";
            this.reactor2StateLabel.Size = new System.Drawing.Size(79, 80);
            this.reactor2StateLabel.TabIndex = 4;

            // 
            // OutputLabel
            // 
            this.OutputLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.OutputLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(90, 351);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(172, 23);
            this.OutputLabel.TabIndex = 5;
            this.OutputLabel.Text = "Reactors Stable";
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // launchButton
            // 
            this.launchButton.Font = new System.Drawing.Font("kroeger 05_66", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchButton.Location = new System.Drawing.Point(60, 277);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(235, 33);
            this.launchButton.TabIndex = 6;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(342, 400);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.reactor2StateLabel);
            this.Controls.Add(this.reactor1StateLabel);
            this.Controls.Add(this.reactor2);
            this.Controls.Add(this.reactor1);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Springfield Powerplant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label reactor1;
        private System.Windows.Forms.Label reactor2;
        private System.Windows.Forms.Label reactor1StateLabel;
        private System.Windows.Forms.Label reactor2StateLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button launchButton;
    }
}

