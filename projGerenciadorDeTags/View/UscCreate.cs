using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projGerenciadorDeTags.Controller;
using projGerenciadorDeTags.Model;

namespace projGerenciadorDeTags.View
{
    public partial class UscCreate : UserControl
    {
        public UscCreate()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtTitle.Text = string.Empty;
            txtContent.Text = string.Empty;
            cbxType.SelectedIndex = -1;
            cbxType.Text = "--Selecionar--";
        }

        private void OnButtonSaveClick(object sender, EventArgs e)
        {
            if (CheckConditions())
            {
                string type = cbxType.SelectedIndex == 0 ? "Branch" : "City"; 
                DatabaseController.Create
                (
                    new Tag(){Title = txtTitle.Text, Content = txtContent.Text},
                    type
                );
                MessageBox.Show("Tag cadastrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else MessageBox.Show("Confira as informações antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool CheckConditions()
        {
            return !(txtTitle.Text == string.Empty || txtContent.Text == string.Empty
                || cbxType.SelectedIndex == -1);
        }
    }
}
