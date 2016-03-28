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
            this.numOnlineL = new System.Windows.Forms.Label();
            this.numOfUsers = new System.Windows.Forms.Label();
            this.numOfFollowers = new System.Windows.Forms.Label();
            this.numberOfFollowers = new System.Windows.Forms.Label();
            this.totalViews = new System.Windows.Forms.Label();
            this.numberOfViews = new System.Windows.Forms.Label();
            this.favButton = new System.Windows.Forms.Button();
            this.activeStreams = new System.Windows.Forms.ListBox();
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
            this.streamLink.Location = new System.Drawing.Point(239, 588);
            this.streamLink.Name = "streamLink";
            this.streamLink.Size = new System.Drawing.Size(75, 23);
            this.streamLink.TabIndex = 4;
            this.streamLink.Text = "Stream Link";
            this.streamLink.UseVisualStyleBackColor = true;
            this.streamLink.Click += new System.EventHandler(this.streamLink_Click);
            // 
            // numOnlineL
            // 
            this.numOnlineL.AutoSize = true;
            this.numOnlineL.Location = new System.Drawing.Point(224, 38);
            this.numOnlineL.Name = "numOnlineL";
            this.numOnlineL.Size = new System.Drawing.Size(96, 13);
            this.numOnlineL.TabIndex = 5;
            this.numOnlineL.Text = "Number of Viewers";
            // 
            // numOfUsers
            // 
            this.numOfUsers.AutoSize = true;
            this.numOfUsers.Location = new System.Drawing.Point(224, 57);
            this.numOfUsers.Name = "numOfUsers";
            this.numOfUsers.Size = new System.Drawing.Size(13, 13);
            this.numOfUsers.TabIndex = 6;
            this.numOfUsers.Text = "0";
            // 
            // numOfFollowers
            // 
            this.numOfFollowers.AutoSize = true;
            this.numOfFollowers.Location = new System.Drawing.Point(224, 93);
            this.numOfFollowers.Name = "numOfFollowers";
            this.numOfFollowers.Size = new System.Drawing.Size(103, 13);
            this.numOfFollowers.TabIndex = 7;
            this.numOfFollowers.Text = "Number of Followers";
            // 
            // numberOfFollowers
            // 
            this.numberOfFollowers.AutoSize = true;
            this.numberOfFollowers.Location = new System.Drawing.Point(224, 106);
            this.numberOfFollowers.Name = "numberOfFollowers";
            this.numberOfFollowers.Size = new System.Drawing.Size(13, 13);
            this.numberOfFollowers.TabIndex = 8;
            this.numberOfFollowers.Text = "0";
            // 
            // totalViews
            // 
            this.totalViews.AutoSize = true;
            this.totalViews.Location = new System.Drawing.Point(224, 141);
            this.totalViews.Name = "totalViews";
            this.totalViews.Size = new System.Drawing.Size(62, 13);
            this.totalViews.TabIndex = 9;
            this.totalViews.Text = "Total Views";
            // 
            // numberOfViews
            // 
            this.numberOfViews.AutoSize = true;
            this.numberOfViews.Location = new System.Drawing.Point(224, 154);
            this.numberOfViews.Name = "numberOfViews";
            this.numberOfViews.Size = new System.Drawing.Size(13, 13);
            this.numberOfViews.TabIndex = 10;
            this.numberOfViews.Text = "0";
            // 
            // favButton
            // 
            this.favButton.Location = new System.Drawing.Point(50, 588);
            this.favButton.Name = "favButton";
            this.favButton.Size = new System.Drawing.Size(75, 23);
            this.favButton.TabIndex = 11;
            this.favButton.Text = "Favorite";
            this.favButton.UseVisualStyleBackColor = true;
            // 
            // activeStreams
            // 
            this.activeStreams.FormattingEnabled = true;
            this.activeStreams.Location = new System.Drawing.Point(15, 38);
            this.activeStreams.Name = "activeStreams";
            this.activeStreams.Size = new System.Drawing.Size(168, 524);
            this.activeStreams.TabIndex = 12;
            // 
            // twitchDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 623);
            this.Controls.Add(this.activeStreams);
            this.Controls.Add(this.favButton);
            this.Controls.Add(this.numberOfViews);
            this.Controls.Add(this.totalViews);
            this.Controls.Add(this.numberOfFollowers);
            this.Controls.Add(this.numOfFollowers);
            this.Controls.Add(this.numOfUsers);
            this.Controls.Add(this.numOnlineL);
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
        private System.Windows.Forms.Label numOnlineL;
        private System.Windows.Forms.Label numOfUsers;
        private System.Windows.Forms.Label numOfFollowers;
        private System.Windows.Forms.Label numberOfFollowers;
        private System.Windows.Forms.Label totalViews;
        private System.Windows.Forms.Label numberOfViews;
        private System.Windows.Forms.Button favButton;
        private System.Windows.Forms.ListBox activeStreams;
    }
}

