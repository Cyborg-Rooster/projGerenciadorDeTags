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
    public partial class UscEdit : UserControl
    {
        public UscEdit()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtContent.Text = string.Empty;
            txtTitle.Text = string.Empty;
            cbxType.SelectedIndex = -1;
            cbxTagToEdit.Items.Clear();
            cbxTagToEdit.Enabled = false;
            cbxType.Text = "--Selecionar--";
            cbxTagToEdit.Text = "--Selecionar--";
        }

        private void OnButtonSaveClick(object sender, EventArgs e)
        {
            if (CheckValues())
            {
                var response = MessageBox.Show("Você tem certeza que quer alterar a tag?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(response == DialogResult.Yes) 
                {
                    string type = cbxType.SelectedIndex == 0 ? "Branch" : "City";
                    Tag tag = DatabaseController.LoadTagAsTag(cbxTagToEdit.Text, type);
                    if(txtTitle.Text != string.Empty) tag.Title = txtTitle.Text;
                    if(txtContent.Text != string.Empty) tag.Content = txtContent.Text;

                    DatabaseController.Edit(tag, cbxTagToEdit.Text, type);
                    MessageBox.Show("Tag editada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            else MessageBox.Show("Verifique os valores antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnCbxTypeSelectedChanged(object sender, EventArgs e)
        {
            if(!cbxTagToEdit.Enabled) cbxTagToEdit.Enabled = true;

            string type = cbxType.SelectedIndex == 0 ? "Branch" : "City";

            cbxTagToEdit.Items.Clear();
            cbxTagToEdit.Items.AddRange(DatabaseController.LoadTagsTitle(type));
        }

        private bool CheckValues()
        {
            return !(txtTitle.Text == string.Empty && txtContent.Text == string.Empty ||
                cbxTagToEdit.SelectedIndex == -1);
        }

        private void OnButtonDeleteClick(object sender, EventArgs e)
        {
            if (cbxTagToEdit.SelectedIndex >= 0)
            {
                var response = MessageBox.Show("Você tem certeza que quer excluir a tag? Isso não poderá ser disfeito.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response == DialogResult.Yes)
                {
                    string type = cbxType.SelectedIndex == 0 ? "Branch" : "City";
                    DatabaseController.Remove(cbxTagToEdit.Text, type);
                    MessageBox.Show("Tag excluída.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    Clear();
                }
            }else MessageBox.Show("Escolha uma tag para ser excluída.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
