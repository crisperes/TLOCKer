using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace View
{
    public class Consistencia
    {
        #region Abrir Formulário

        public static void AbrirForm(Form formqueseraaberto, Form formprincipal, Control controle)
        {
            foreach (Form formfilho in formprincipal.MdiChildren)
            {
                if (formfilho.GetType() == formqueseraaberto.GetType())
                {
                    formfilho.Focus();
                    return;
                }
            }
            foreach (Control control in controle.Controls)
            {
                if (control.Name == "panel2")
                {
                    control.Controls.Clear();
                    formqueseraaberto.MdiParent = formprincipal;
                    formqueseraaberto.TopLevel = false;
                    formqueseraaberto.AutoScroll = false;
                    formqueseraaberto.FormBorderStyle = FormBorderStyle.None;
                    formqueseraaberto.WindowState = FormWindowState.Maximized;
                    control.Controls.Add(formqueseraaberto);
                    formqueseraaberto.Show();

                }
            }
        }


        #endregion

        #region Limpar Campos
        public static void Limpar(Control frmlimpar2)
        {
            foreach (Control controle in frmlimpar2.Controls)
            {
                if (controle is TextBox || controle is ComboBox || controle is MaskedTextBox)
                {
                    controle.Text = string.Empty;
                }
                if (controle is GroupBox)
                {
                    for (int i = 0; i < controle.Controls.Count; i++)
                    {
                        if (controle.Controls[i] is TextBox)
                        {
                            (controle.Controls[i] as TextBox).Text = "";
                        }
                        if (controle.Controls[i] is ComboBox)
                        {
                            (controle.Controls[i] as ComboBox).SelectedIndex = -1;
                        }
                        if (controle.Controls[i] is ComboBox)
                        {
                            (controle.Controls[i] as ComboBox).SelectedValue = -1;
                        }
                    }

                }

            }
        }

        #endregion

        #region Entrada
        public static void Entrada(object Entrada)
        {
            if (Entrada is Panel)
            {
                (Entrada as Panel).BackColor = Color.Teal;
            }
            
        }
        #endregion

        #region Saida
        public static void Saida(object Saida)
        {
            if (Saida is Panel)
            {
                (Saida as Panel).BackColor = Color.FromArgb(4, 91, 87);
            }

        }
        #endregion

        #region Validar Campos

        public static void ValidarCampos(Control controle)
        {
            if (controle is GroupBox)
            {
                if (controle is TextBox || controle is ComboBox || controle is MaskedTextBox)
                { 
                    if (string.IsNullOrWhiteSpace(controle.Text) && string.IsNullOrWhiteSpace(controle.Text))
                    {
                        MessageBox.Show("Preencha todos os campos.");
                    }
                }

            }
        }
        #endregion

    }
}