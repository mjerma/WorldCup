
namespace WindowsForms.UserControls
{
    partial class PlayerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerControl));
            this.lblCaptain = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCaptainPlaceholder = new System.Windows.Forms.Label();
            this.lblPositionPlaceholder = new System.Windows.Forms.Label();
            this.lblNumberPlaceholder = new System.Windows.Forms.Label();
            this.lblNamePlaceholder = new System.Windows.Forms.Label();
            this.cmsPlayer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAddToFavorites = new System.Windows.Forms.ToolStripMenuItem();
            this.miRemoveFromFavorites = new System.Windows.Forms.ToolStripMenuItem();
            this.miChangePicture = new System.Windows.Forms.ToolStripMenuItem();
            this.pbStar = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.cmsPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaptain
            // 
            resources.ApplyResources(this.lblCaptain, "lblCaptain");
            this.lblCaptain.Name = "lblCaptain";
            // 
            // lblPosition
            // 
            resources.ApplyResources(this.lblPosition, "lblPosition");
            this.lblPosition.Name = "lblPosition";
            // 
            // lblNumber
            // 
            resources.ApplyResources(this.lblNumber, "lblNumber");
            this.lblNumber.Name = "lblNumber";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // lblCaptainPlaceholder
            // 
            resources.ApplyResources(this.lblCaptainPlaceholder, "lblCaptainPlaceholder");
            this.lblCaptainPlaceholder.Name = "lblCaptainPlaceholder";
            // 
            // lblPositionPlaceholder
            // 
            resources.ApplyResources(this.lblPositionPlaceholder, "lblPositionPlaceholder");
            this.lblPositionPlaceholder.Name = "lblPositionPlaceholder";
            // 
            // lblNumberPlaceholder
            // 
            resources.ApplyResources(this.lblNumberPlaceholder, "lblNumberPlaceholder");
            this.lblNumberPlaceholder.Name = "lblNumberPlaceholder";
            // 
            // lblNamePlaceholder
            // 
            resources.ApplyResources(this.lblNamePlaceholder, "lblNamePlaceholder");
            this.lblNamePlaceholder.Name = "lblNamePlaceholder";
            // 
            // cmsPlayer
            // 
            resources.ApplyResources(this.cmsPlayer, "cmsPlayer");
            this.cmsPlayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddToFavorites,
            this.miRemoveFromFavorites,
            this.miChangePicture});
            this.cmsPlayer.Name = "cmsPlayer";
            // 
            // miAddToFavorites
            // 
            resources.ApplyResources(this.miAddToFavorites, "miAddToFavorites");
            this.miAddToFavorites.Name = "miAddToFavorites";
            this.miAddToFavorites.Click += new System.EventHandler(this.miAddToFavorites_Click);
            // 
            // miRemoveFromFavorites
            // 
            resources.ApplyResources(this.miRemoveFromFavorites, "miRemoveFromFavorites");
            this.miRemoveFromFavorites.Name = "miRemoveFromFavorites";
            this.miRemoveFromFavorites.Click += new System.EventHandler(this.miRemoveFromFavorites_Click);
            // 
            // miChangePicture
            // 
            resources.ApplyResources(this.miChangePicture, "miChangePicture");
            this.miChangePicture.Name = "miChangePicture";
            this.miChangePicture.Click += new System.EventHandler(this.miChangePicture_Click);
            // 
            // pbStar
            // 
            resources.ApplyResources(this.pbStar, "pbStar");
            this.pbStar.Image = global::WindowsForms.Properties.Resources.star;
            this.pbStar.Name = "pbStar";
            this.pbStar.TabStop = false;
            // 
            // pbPlayer
            // 
            resources.ApplyResources(this.pbPlayer, "pbPlayer");
            this.pbPlayer.Image = global::WindowsForms.Properties.Resources.playerDefault;
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.TabStop = false;
            // 
            // PlayerControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.cmsPlayer;
            this.Controls.Add(this.pbStar);
            this.Controls.Add(this.lblCaptainPlaceholder);
            this.Controls.Add(this.lblPositionPlaceholder);
            this.Controls.Add(this.lblNumberPlaceholder);
            this.Controls.Add(this.lblNamePlaceholder);
            this.Controls.Add(this.lblCaptain);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbPlayer);
            this.Name = "PlayerControl";
            this.cmsPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Label lblCaptain;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCaptainPlaceholder;
        private System.Windows.Forms.Label lblPositionPlaceholder;
        private System.Windows.Forms.Label lblNumberPlaceholder;
        private System.Windows.Forms.Label lblNamePlaceholder;
        private System.Windows.Forms.PictureBox pbStar;
        private System.Windows.Forms.ContextMenuStrip cmsPlayer;
        private System.Windows.Forms.ToolStripMenuItem miAddToFavorites;
        private System.Windows.Forms.ToolStripMenuItem miRemoveFromFavorites;
        private System.Windows.Forms.ToolStripMenuItem miChangePicture;
    }
}
