namespace Hello
{
    partial class HelloApp
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
            this.ButtonShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonShow
            // 
            this.ButtonShow.Location = new System.Drawing.Point(386, 198);
            this.ButtonShow.Name = "ButtonShow";
            this.ButtonShow.Size = new System.Drawing.Size(75, 23);
            this.ButtonShow.TabIndex = 0;
            this.ButtonShow.Text = "Show";
            this.ButtonShow.UseVisualStyleBackColor = true;
            this.ButtonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // HelloApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonShow);
            this.Name = "HelloApp";
            this.Text = "Hello";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonShow;
    }
}

