using projGerenciadorDeTags.Controller;
using projGerenciadorDeTags.Model;
using System.Text.Json;

namespace projGerenciadorDeTags.View
{
    public partial class UscBuilder : UserControl
    {
        public UscBuilder()
        {
            InitializeComponent();
            Clear();
        }

        private void OnBuildClick(object sender, EventArgs e)
        {
            if (CheckValues())
                txtResult.Text = DatabaseController.LoadTag(cbxBranch.Text, cbxCity.Text);
            else MessageBox.Show("Selecione o ramo e a cidade da empresa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool CheckValues()
        {
            return cbxBranch.SelectedIndex != -1 && cbxCity.SelectedIndex != -1;
        }

        public void Clear()
        {
            cbxBranch.Items.Clear();
            cbxCity.Items.Clear();
            cbxBranch.Text = "--Selecionar--";
            cbxCity.Text = "--Selecionar--";
            cbxBranch.Items.AddRange(DatabaseController.LoadTagsTitle("Branch"));
            cbxCity.Items.AddRange(DatabaseController.LoadTagsTitle("City"));
        }

    }
}
