using projGerenciadorDeTags.Model;
using projGerenciadorDeTags.View;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace projGerenciadorDeTags
{
    public partial class FrmMain : Form
    {
        Content Type = Content.Build;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void OnLabelOver(object sender, EventArgs e)
        {
            Label? lbl = sender as Label;
            lbl.ForeColor = Color.SaddleBrown;
            lbl.Font = new Font(Label.DefaultFont, FontStyle.Bold);
        }

        private void OnLabelLeave(object sender, EventArgs e)
        {
            Label? lbl = sender as Label;
            lbl.ForeColor = Color.Black;
            lbl.Font = new Font(Label.DefaultFont, FontStyle.Regular);
        }

        private void OnLblBuildClick(object sender, EventArgs e)
        {
            if (Type != Content.Build)
            {
                uscBuilder1.Clear();

                uscCreate1.Visible = false;
                uscEdit1.Visible = false;
                uscBuilder1.Visible = true;
                Type = Content.Build;
            }
        }

        private void OnLblCreateClick(object sender, EventArgs e)
        {
            if (Type != Content.Create)
            {
                uscCreate1.Clear();

                uscEdit1.Visible = false;
                uscBuilder1.Visible = false;
                uscCreate1.Visible = true;
                Type = Content.Create;
            }
        }

        private void OnLblEditClick(object sender, EventArgs e)
        {
            if (Type != Content.Edit)
            {
                uscEdit1.Clear();

                uscEdit1.Visible = true;
                uscBuilder1.Visible = false;
                uscCreate1.Visible = false;
                Type = Content.Edit;
            }
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblLink.LinkVisited = true;
            string url = "https://github.com/enrisco";

            try
            {
                Process.Start(url);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}