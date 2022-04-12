
namespace WindowsForms
{
    partial class StartSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartSettingsForm));
            this.lblSettings = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlTeamGender = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.pnlLanguage = new System.Windows.Forms.Panel();
            this.pnlTeamGender.SuspendLayout();
            this.pnlLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSettings
            // 
            resources.ApplyResources(this.lblSettings, "lblSettings");
            this.lblSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblSettings.ForeColor = System.Drawing.Color.White;
            this.lblSettings.Name = "lblSettings";
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            resources.ApplyResources(this.lblGender, "lblGender");
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Name = "lblGender";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlTeamGender
            // 
            resources.ApplyResources(this.pnlTeamGender, "pnlTeamGender");
            this.pnlTeamGender.BackColor = System.Drawing.Color.Transparent;
            this.pnlTeamGender.Controls.Add(this.radioButton2);
            this.pnlTeamGender.Controls.Add(this.radioButton1);
            this.pnlTeamGender.Name = "pnlTeamGender";
            // 
            // radioButton3
            // 
            resources.ApplyResources(this.radioButton3, "radioButton3");
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            resources.ApplyResources(this.radioButton4, "radioButton4");
            this.radioButton4.Checked = true;
            this.radioButton4.ForeColor = System.Drawing.Color.White;
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // pnlLanguage
            // 
            resources.ApplyResources(this.pnlLanguage, "pnlLanguage");
            this.pnlLanguage.BackColor = System.Drawing.Color.Transparent;
            this.pnlLanguage.Controls.Add(this.radioButton4);
            this.pnlLanguage.Controls.Add(this.radioButton3);
            this.pnlLanguage.Name = "pnlLanguage";
            // 
            // StartSettingsForm
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
            this.Name = "StartSettingsForm";
            this.pnlTeamGender.ResumeLayout(false);
            this.pnlTeamGender.PerformLayout();
            this.pnlLanguage.ResumeLayout(false);
            this.pnlLanguage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlTeamGender;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel pnlLanguage;
    }
}