using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class ChangeSettings : Form
    {
        public ChangeSettings()
        {
            InitializeComponent();
            Load();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Load()
        {
            string[] settings = UserSettings.Load();
            if (settings[0] == "Male")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            if (settings[1] == "en")
            {
                rbEnglish.Checked = true;
            }
            else
            {
                rbCroatian.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string gender = pnlTeamGender.Controls.OfType<RadioButton>()
                          .FirstOrDefault(n => n.Checked).Name;
                string language = pnlLanguage.Controls.OfType<RadioButton>()
                               .FirstOrDefault(n => n.Checked).Name;

                if (gender == "rbMale")
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }

                switch (language)
                {
                    case "rbEnglish":
                        UserSettings.Save(gender, "en");
                        break;
                    case "rbCroatian":
                        UserSettings.Save(gender, "hr");
                        break;
                }
                Close();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
