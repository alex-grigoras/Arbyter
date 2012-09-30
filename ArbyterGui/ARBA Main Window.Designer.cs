namespace Arbyter
{
    partial class MainWindow
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
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.CopyButton = new System.Windows.Forms.Button();
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.Destination = new System.Windows.Forms.Label();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.BrowseSourceButton = new System.Windows.Forms.Button();
            this.BrowseDestinationButton = new System.Windows.Forms.Button();
            this.CleanButton = new System.Windows.Forms.Button();
            this.StartAutoCopy = new System.Windows.Forms.Button();
            this.StopAutoCopy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CopyInterval = new System.Windows.Forms.NumericUpDown();
            this.Logging = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ToTray = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CopyInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(56, 125);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 23);
            this.CopyButton.TabIndex = 0;
            this.CopyButton.Text = "Copy Now!";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Location = new System.Drawing.Point(98, 18);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.Size = new System.Drawing.Size(249, 20);
            this.SourceTextBox.TabIndex = 1;
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceLabel.Location = new System.Drawing.Point(3, 18);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(64, 20);
            this.SourceLabel.TabIndex = 2;
            this.SourceLabel.Text = "Source:";
            // 
            // Destination
            // 
            this.Destination.AutoSize = true;
            this.Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Destination.Location = new System.Drawing.Point(3, 44);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(94, 20);
            this.Destination.TabIndex = 3;
            this.Destination.Text = "Destination:";
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Location = new System.Drawing.Point(98, 46);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(249, 20);
            this.DestinationTextBox.TabIndex = 4;
            // 
            // BrowseSourceButton
            // 
            this.BrowseSourceButton.Location = new System.Drawing.Point(353, 15);
            this.BrowseSourceButton.Name = "BrowseSourceButton";
            this.BrowseSourceButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseSourceButton.TabIndex = 5;
            this.BrowseSourceButton.Text = "Browse";
            this.BrowseSourceButton.UseVisualStyleBackColor = true;
            this.BrowseSourceButton.Click += new System.EventHandler(this.BrowseSourceButton_Click);
            // 
            // BrowseDestinationButton
            // 
            this.BrowseDestinationButton.Location = new System.Drawing.Point(353, 46);
            this.BrowseDestinationButton.Name = "BrowseDestinationButton";
            this.BrowseDestinationButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseDestinationButton.TabIndex = 6;
            this.BrowseDestinationButton.Text = "Browse";
            this.BrowseDestinationButton.UseVisualStyleBackColor = true;
            this.BrowseDestinationButton.Click += new System.EventHandler(this.BrowseDestinationButton_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(304, 125);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(75, 23);
            this.CleanButton.TabIndex = 7;
            this.CleanButton.Text = "Clean";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // StartAutoCopy
            // 
            this.StartAutoCopy.Location = new System.Drawing.Point(150, 125);
            this.StartAutoCopy.Name = "StartAutoCopy";
            this.StartAutoCopy.Size = new System.Drawing.Size(134, 23);
            this.StartAutoCopy.TabIndex = 8;
            this.StartAutoCopy.Text = "Start auto copy";
            this.StartAutoCopy.UseVisualStyleBackColor = true;
            this.StartAutoCopy.Click += new System.EventHandler(this.StartAutoCopy_Click);
            // 
            // StopAutoCopy
            // 
            this.StopAutoCopy.Enabled = false;
            this.StopAutoCopy.Location = new System.Drawing.Point(150, 154);
            this.StopAutoCopy.Name = "StopAutoCopy";
            this.StopAutoCopy.Size = new System.Drawing.Size(134, 23);
            this.StopAutoCopy.TabIndex = 9;
            this.StopAutoCopy.Text = "Stop auto copy";
            this.StopAutoCopy.UseVisualStyleBackColor = true;
            this.StopAutoCopy.Click += new System.EventHandler(this.StopAutoCopy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Auto copy every";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "minutes*";
            // 
            // CopyInterval
            // 
            this.CopyInterval.Location = new System.Drawing.Point(211, 86);
            this.CopyInterval.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.CopyInterval.Name = "CopyInterval";
            this.CopyInterval.Size = new System.Drawing.Size(36, 20);
            this.CopyInterval.TabIndex = 13;
            this.CopyInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CopyInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Logging
            // 
            this.Logging.AutoSize = true;
            this.Logging.Location = new System.Drawing.Point(173, 185);
            this.Logging.Name = "Logging";
            this.Logging.Size = new System.Drawing.Size(64, 17);
            this.Logging.TabIndex = 14;
            this.Logging.Text = "Logging";
            this.Logging.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "*Restart auto copy to take effect";
            // 
            // ToTray
            // 
            this.ToTray.Text = "Arbyter";
            this.ToTray.Visible = true;
            this.ToTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ToTray_MouseDoubleClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 241);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Logging);
            this.Controls.Add(this.CopyInterval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopAutoCopy);
            this.Controls.Add(this.StartAutoCopy);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.BrowseDestinationButton);
            this.Controls.Add(this.BrowseSourceButton);
            this.Controls.Add(this.DestinationTextBox);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.SourceTextBox);
            this.Controls.Add(this.CopyButton);
            this.Name = "MainWindow";
            this.Text = "Arbyter";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += this.MainWindow_Resize;
            this.FormClosing += this.MainWindow_FormClosing;
            ((System.ComponentModel.ISupportInitialize)(this.CopyInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Label Destination;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.Button BrowseSourceButton;
        private System.Windows.Forms.Button BrowseDestinationButton;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Button StartAutoCopy;
        private System.Windows.Forms.Button StopAutoCopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown CopyInterval;
        private System.Windows.Forms.CheckBox Logging;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon ToTray;


    }
}

