namespace org.cameek.Keepa
{
    partial class KeepaForm
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
            this.keepaTimer = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTimeout = new System.Windows.Forms.Label();
            this.numericTimeout = new System.Windows.Forms.NumericUpDown();
            this.labelCursorY = new System.Windows.Forms.Label();
            this.labelInactiveFor = new System.Windows.Forms.Label();
            this.labelCursorX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // keepaTimer
            // 
            this.keepaTimer.Enabled = true;
            this.keepaTimer.Tick += new System.EventHandler(this.keepaTimer_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(238, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(52, 13);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "labelTime";
            // 
            // labelTimeout
            // 
            this.labelTimeout.AutoSize = true;
            this.labelTimeout.Location = new System.Drawing.Point(12, 9);
            this.labelTimeout.Name = "labelTimeout";
            this.labelTimeout.Size = new System.Drawing.Size(113, 13);
            this.labelTimeout.TabIndex = 1;
            this.labelTimeout.Text = "Keep active after (ms):";
            // 
            // numericTimeout
            // 
            this.numericTimeout.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericTimeout.Location = new System.Drawing.Point(15, 25);
            this.numericTimeout.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericTimeout.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericTimeout.Name = "numericTimeout";
            this.numericTimeout.Size = new System.Drawing.Size(120, 20);
            this.numericTimeout.TabIndex = 2;
            this.numericTimeout.Value = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            // 
            // labelCursorY
            // 
            this.labelCursorY.AutoSize = true;
            this.labelCursorY.Location = new System.Drawing.Point(238, 27);
            this.labelCursorY.Name = "labelCursorY";
            this.labelCursorY.Size = new System.Drawing.Size(66, 13);
            this.labelCursorY.TabIndex = 3;
            this.labelCursorY.Text = "labelCursorY";
            // 
            // labelInactiveFor
            // 
            this.labelInactiveFor.AutoSize = true;
            this.labelInactiveFor.Location = new System.Drawing.Point(12, 57);
            this.labelInactiveFor.Name = "labelInactiveFor";
            this.labelInactiveFor.Size = new System.Drawing.Size(82, 13);
            this.labelInactiveFor.TabIndex = 4;
            this.labelInactiveFor.Text = "labelInactiveFor";
            // 
            // labelCursorX
            // 
            this.labelCursorX.AutoSize = true;
            this.labelCursorX.Location = new System.Drawing.Point(191, 27);
            this.labelCursorX.Name = "labelCursorX";
            this.labelCursorX.Size = new System.Drawing.Size(66, 13);
            this.labelCursorX.TabIndex = 5;
            this.labelCursorX.Text = "labelCursorX";
            // 
            // KeepaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.Controls.Add(this.labelCursorX);
            this.Controls.Add(this.labelInactiveFor);
            this.Controls.Add(this.labelCursorY);
            this.Controls.Add(this.numericTimeout);
            this.Controls.Add(this.labelTimeout);
            this.Controls.Add(this.labelTime);
            this.Name = "KeepaForm";
            this.Text = "Keepa (Keep Active)";
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer keepaTimer;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTimeout;
        private System.Windows.Forms.NumericUpDown numericTimeout;
        private System.Windows.Forms.Label labelCursorY;
        private System.Windows.Forms.Label labelInactiveFor;
        private System.Windows.Forms.Label labelCursorX;
    }
}

