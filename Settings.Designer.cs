namespace X_O_Csharp_forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.playerOne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playerTwo = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player one\'s sign:";
            // 
            // playerOne
            // 
            this.playerOne.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOne.Location = new System.Drawing.Point(159, 30);
            this.playerOne.Name = "playerOne";
            this.playerOne.Size = new System.Drawing.Size(65, 29);
            this.playerOne.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player two\'s sign:";
            // 
            // playerTwo
            // 
            this.playerTwo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwo.Location = new System.Drawing.Point(159, 87);
            this.playerTwo.Name = "playerTwo";
            this.playerTwo.Size = new System.Drawing.Size(65, 29);
            this.playerTwo.TabIndex = 3;
            // 
            // enterButton
            // 
            this.enterButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Location = new System.Drawing.Point(237, 132);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(93, 31);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 175);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.playerTwo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerOne);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox playerTwo;
        private System.Windows.Forms.Button enterButton;
    }
}