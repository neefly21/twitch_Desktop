namespace Twitch_Desktop
{
    partial class viewStream
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
            this.streamViewer = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // streamViewer
            // 
            this.streamViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streamViewer.Location = new System.Drawing.Point(0, 0);
            this.streamViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.streamViewer.Name = "streamViewer";
            this.streamViewer.Size = new System.Drawing.Size(1264, 681);
            this.streamViewer.TabIndex = 0;
            // 
            // viewStream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.streamViewer);
            this.Name = "viewStream";
            this.Text = "Stream Viewer";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser streamViewer;
    }
}