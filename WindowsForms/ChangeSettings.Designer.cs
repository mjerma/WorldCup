
namespace WindowsForms
{
    partial class ChangeSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeSettings));
            this.pnlLanguage = new System.Windows.Forms.Panel();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbCroatian = new System.Windows.Forms.RadioButton();
            this.pnlTeamGender = new System.Windows.Forms.Panel();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.pnlLanguage.SuspendLayout();
            this.pnlTeamGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLanguage
            // 
            this.pnlLanguage.BackColor = System.Drawing.Color.Transparent;
            this.pnlLanguage.Controls.Add(this.rbEnglish);
            this.pnlLanguage.Controls.Add(this.rbCroatian);
            resources.ApplyResources(this.pnlLanguage, "pnlLanguage");
            this.pnlLanguage.Name = "pnlLanguage";
            // 
            // rbEnglish
            // 
            resources.ApplyResources(this.rbEnglish, "rbEnglish");
            this.rbEnglish.Checked = true;
            this.rbEnglish.ForeColor = System.Drawing.Color.White;
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.TabStop = true;
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // rbCroatian
            // 
            resources.ApplyResources(this.rbCroatian, "rbCroatian");
            this.rbCroatian.ForeColor = System.Drawing.Color.White;
            this.rbCroatian.Name = "rbCroatian";
            this.rbCroatian.UseVisualStyleBackColor = true;
            // 
            // pnlTeamGender
            // 
            this.pnlTeamGender.BackColor = System.Drawing.Color.Transparent;
            this.pnlTeamGender.Controls.Add(this.rbFemale);
            this.pnlTeamGender.Controls.Add(this.rbMale);
            resources.ApplyResources(this.pnlTeamGender, "pnlTeamGender");
            this.pnlTeamGender.Name = "pnlTeamGender";
            // 
            // rbFemale
            // 
            resources.ApplyResources(this.rbFemale, "rbFemale");
            this.rbFemale.ForeColor = System.Drawing.Color.White;
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            resources.ApplyResources(this.rbMale, "rbMale");
            this.rbMale.Checked = true;
            this.rbMale.ForeColor = System.Drawing.Color.White;
            this.rbMale.Name = "rbMale";
            this.rbMale.TabStop = true;
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // lblGender
            // 
            resources.ApplyResources(this.lblGender, "lblGender");
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Name = "lblGender";
            // 
            // lblSettings
            // 
            resources.ApplyResources(this.lblSettings, "lblSettings");
            this.lblSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblSettings.ForeColor = System.Drawing.Color.White;
            this.lblSettings.Name = "lblSettings";
            // 
            // ChangeSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsForms.Properties.Resources.SettingsBG;
            this.Controls.Add(this.pnlLanguage);
            this.Controls.Add(this.pnlTeamGender);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblSettings);
            this.Name = "ChangeSettings";
            this.pnlLanguage.ResumeLayout(false);
            this.pnlLanguage.PerformLayout();
            this.pnlTeamGender.ResumeLayout(false);
            this.pnlTeamGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLanguage;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.RadioButton rbCroatian;
        private System.Windows.Forms.Panel pnlTeamGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblSettings;
    }
}