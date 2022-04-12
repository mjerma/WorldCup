using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class StartSettingsForm : Form
    {
        public StartSettingsForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string gender = pnlTeamGender.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked).Text;
            string language = pnlLanguage.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked).Text;

            UserSettings.Create();
            switch (language)
            {
                case "English":
                    UserSettings.Save(gender, "en");
                    break;
                case "Croatian":
                    UserSettings.Save(gender, "hr");
                    break;
            }
            Close();
            DialogResult = DialogResult.OK;
        }
    }
}

