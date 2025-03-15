using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Soft_Caisse.Views.FonctionsViews
{
    public class TextBoxKeyPressHandler
    {
        public static void HandleNumericOnlyKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(sender is TextBox textBox)) return;

            // Empêcher une virgule en première position ou après un "-"
            if ((e.KeyChar == ',' && textBox.SelectionStart == 0) ||
                (textBox.Text == "-" && e.KeyChar == ','))
            {
                e.Handled = true;
                return;
            }

            // Autoriser chiffres, Backspace, un seul point (","), et un signe moins au début
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)
                && (e.KeyChar != ',' || textBox.Text.Contains(",")) // Empêcher plusieurs virgules
                && (e.KeyChar != '-' || textBox.SelectionStart != 0)) // Empêcher "-" sauf en début
            {
                e.Handled = true;
            }
        }

        public static void PreventVirguleAtTheEndOfNumber_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox == null) return;

            // Empêcher une virgule à la fin
            if (textBox.Text.EndsWith(","))
            {
                textBox.Text = textBox.Text.TrimEnd(',');
            }

            // Empêcher un seul "-" (sans chiffres)
            if (textBox.Text == "-")
            {
                textBox.Text = "";
            }
        }

        public static void HandlePositiveNumericOnlyKeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox == null) return;

            // Empêcher la saisie d'une virgule au début
            if (e.KeyChar == ',' && textBox.SelectionStart == 0)
            {
                e.Handled = true;
                return;
            }

            // Autoriser uniquement les chiffres, la touche Backspace et une seule virgule
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)
                && (e.KeyChar != ',' || textBox.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        public static void HandleCodeBarresKeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox == null) return;

            // Vérifie si le caractère est une lettre ou un chiffre
            if ((!((e.KeyChar >= 'A' && e.KeyChar <= 'Z') ||
                   (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                   char.IsDigit(e.KeyChar)))
                  && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Empêche la saisie
            }
            if (char.IsLower(e.KeyChar))
            {
                // Convertit les minuscules en majuscules
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        public static void HandlePositiveIntegerKeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox == null) return;

            // Vérifie si le caractère entré est un chiffre (1-9) ou si c'est une touche de contrôle (comme Backspace)
            if (!char.IsControl(e.KeyChar) && (e.KeyChar < '1' || e.KeyChar > '9'))
            {
                e.Handled = true; // Bloque l'entrée
            }
        }
    }
}
