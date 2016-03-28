namespace Twitch_Desktop
{
    partial class twitchDesktop
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
            this.lblStreams = new System.Windows.Forms.Label();
            this.streamLink = new System.Windows.Forms.Button();
            this.favButton = new System.Windows.Forms.Button();
            this.activeStreams = new System.Windows.Forms.ListBox();
            this.removeFavorite = new System.Windows.Forms.Button();
            this.favorites = new System.Windows.Forms.ListBox();
            this.favoriteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStreams
            // 
            this.lblStreams.AutoSize = true;
            this.lblStreams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreams.Location = new System.Drawing.Point(11, 11);
            this.lblStreams.Name = "lblStreams";
            this.lblStreams.Size = new System.Drawing.Size(172, 20);
            this.lblStreams.TabIndex = 0;
            this.lblStreams.Text = "Current Streams/Users";
            // 
            // streamLink
            // 
            this.streamLink.Location = new System.Drawing.Point(51, 588);
            this.streamLink.Name = "streamLink";
            this.streamLink.Size = new System.Drawing.Size(75, 23);
            this.streamLink.TabIndex = 4;
            this.streamLink.Text = "View Stream";
            this.streamLink.UseVisualStyleBackColor = true;
            this.streamLink.Click += new System.EventHandler(this.streamLink_Click);
            // 
            // favButton
            // 
            this.favButton.Location = new System.Drawing.Point(204, 316);
            this.favButton.Name = "favButton";
            this.favButton.Size = new System.Drawing.Size(133, 23);
            this.favButton.TabIndex = 11;
            this.favButton.Text = "Favorite";
            this.favButton.UseVisualStyleBackColor = true;
            this.favButton.Click += new System.EventHandler(this.favButton_Click);
            // 
            // activeStreams
            // 
            this.activeStreams.FormattingEnabled = true;
            this.activeStreams.Location = new System.Drawing.Point(15, 38);
            this.activeStreams.Name = "activeStreams";
            this.activeStreams.Size = new System.Drawing.Size(168, 524);
            this.activeStreams.TabIndex = 12;
            // 
            // removeFavorite
            // 
            this.removeFavorite.Location = new System.Drawing.Point(204, 362);
            this.removeFavorite.Name = "removeFavorite";
            this.removeFavorite.Size = new System.Drawing.Size(133, 23);
            this.removeFavorite.TabIndex = 13;
            this.removeFavorite.Text = "Remove Favorite";
            this.removeFavorite.UseVisualStyleBackColor = true;
            this.removeFavorite.Click += new System.EventHandler(this.removeFavorite_Click);
            // 
            // favorites
            // 
            this.favorites.FormattingEnabled = true;
            this.favorites.Location = new System.Drawing.Point(204, 38);
            this.favorites.Name = "favorites";
            this.favorites.Size = new System.Drawing.Size(133, 264);
            this.favorites.TabIndex = 14;
            // 
            // favoriteLabel
            // 
            this.favoriteLabel.AutoSize = true;
            this.favoriteLabel.Location = new System.Drawing.Point(204, 19);
            this.favoriteLabel.Name = "favoriteLabel";
            this.favoriteLabel.Size = new System.Drawing.Size(50, 13);
            this.favoriteLabel.TabIndex = 15;
            this.favoriteLabel.Text = "Favorites";
            // 
            // twitchDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 623);
            this.Controls.Add(this.favoriteLabel);
            this.Controls.Add(this.favorites);
            this.Controls.Add(this.removeFavorite);
            this.Controls.Add(this.activeStreams);
            this.Controls.Add(this.favButton);
            this.Controls.Add(this.streamLink);
            this.Controls.Add(this.lblStreams);
            this.Name = "twitchDesktop";
            this.Text = "Twitch Dekstop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStreams;
        private System.Windows.Forms.Button streamLink;
        private System.Windows.Forms.Button favButton;
        private System.Windows.Forms.ListBox activeStreams;
        private System.Windows.Forms.Button removeFavorite;
        private System.Windows.Forms.ListBox favorites;
        private System.Windows.Forms.Label favoriteLabel;
    }
}

