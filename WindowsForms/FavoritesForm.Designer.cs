
namespace WindowsForms
{
    partial class FavoritesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoritesForm));
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flpAllPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.flpFavPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRankingList = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbTeams
            // 
            resources.ApplyResources(this.cbTeams, "cbTeams");
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.SelectedIndexChanged += new System.EventHandler(this.cbTeams_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // flpAllPlayers
            // 
            this.flpAllPlayers.AllowDrop = true;
            resources.ApplyResources(this.flpAllPlayers, "flpAllPlayers");
            this.flpAllPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAllPlayers.Name = "flpAllPlayers";
            this.flpAllPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpPlayers_DragDrop);
            this.flpAllPlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpPlayers_DragEnter);
            // 
            // flpFavPlayers
            // 
            this.flpFavPlayers.AllowDrop = true;
            resources.ApplyResources(this.flpFavPlayers, "flpFavPlayers");
            this.flpFavPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFavPlayers.Name = "flpFavPlayers";
            this.flpFavPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpPlayers_DragDrop);
            this.flpFavPlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpPlayers_DragEnter);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // btnRankingList
            // 
            resources.ApplyResources(this.btnRankingList, "btnRankingList");
            this.btnRankingList.Name = "btnRankingList";
            this.btnRankingList.UseVisualStyleBackColor = true;
            this.btnRankingList.Click += new System.EventHandler(this.btnRankingList_Click);
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // FavoritesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsForms.Properties.Resources.FavoritesBG;
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnRankingList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flpFavPlayers);
            this.Controls.Add(this.flpAllPlayers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTeams);
            this.Name = "FavoritesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FavoritesForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTeams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpAllPlayers;
        private System.Windows.Forms.FlowLayoutPanel flpFavPlayers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRankingList;
        private System.Windows.Forms.Button btnSettings;
    }
}