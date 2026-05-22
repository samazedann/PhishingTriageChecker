using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhishingTriageChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMicrosoft_Click(object sender, EventArgs e)
        {
            txtSender.Text = "support@logins-updates.com";

            txtSubject.Text =
            "URGENT: Account suspended";

            txtBody.Text =
            "Verify your account immediately";

            txtURL.Text =
            "micros0ft-login.support";
        }

        private void btnBEC_Click(object sender, EventArgs e)
        {
            txtSender.Text = "finance-update@secure-pay.com";

            txtSubject.Text = "Urgent Wire Transfer Request";

            txtBody.Text =
            "Please transfer funds immediately.";

            txtURL.Text =
            "secure-pay.xyz";
        }

        private void btnHR_Click(object sender, EventArgs e)
        {
            txtSender.Text =
"hr-team@company-update.com";

            txtSubject.Text =
            "Updated employee policy";

            txtBody.Text =
            "Click to review policy";

            txtURL.Text =
            "policy-secure.xyz";
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            lstFlags.Items.Clear();

            string senderEmail = txtSender.Text.ToLower();

            string subject = txtSubject.Text.ToLower();

            string body = txtBody.Text.ToLower();

            string url = txtURL.Text.ToLower();

            int risk = 0;


            // Sender check
            if (
                senderEmail.Contains("login") ||
                senderEmail.Contains("verify")
                )
            {
                lstFlags.Items.Add("Suspicious sender domain");

                risk++;
            }


            // Urgency check
            if (
                subject.Contains("urgent") ||
                body.Contains("immediately") ||
                body.Contains("24 hours")
                )
            {
                lstFlags.Items.Add("Urgency detected");

                risk++;
            }


            // Credential check
            if (
                body.Contains("password") ||
                body.Contains("verify account") ||
                body.Contains("login")
                )
            {
                lstFlags.Items.Add("Credential request");

                risk++;
            }


            // URL check
            if (
                url.Contains(".xyz") ||
                url.Contains("micros0ft")
                )
            {
                lstFlags.Items.Add("Suspicious URL");

                risk++;
            }



            // Final Risk Result

            if (risk == 0)
            {
                lblRisk.Text = "Risk Level: LOW";

                lblRisk.ForeColor = Color.Green;

                lblUnsafe.Text =
                "No major phishing indicators found.";
            }

            else if (risk <= 2)
            {
                lblRisk.Text = "Risk Level: MEDIUM";

                lblRisk.ForeColor = Color.Orange;

                lblUnsafe.Text =
                "Some suspicious indicators were found. Verify the message before taking action.";
            }

            else
            {
                lblRisk.Text = "Risk Level: HIGH";

                lblRisk.ForeColor = Color.Red;

                lblUnsafe.Text =
                "This message attempts to pressure users into revealing credentials and may be phishing.";
            }
        }
    }
}
