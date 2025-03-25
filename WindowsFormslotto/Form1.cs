using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Auteur : Cyril Vandervelde
// Auteur : Cyril Vandervelde
namespace WindowsFormslotto
{
    public partial class Form1 : Form
    {
        List<Label> selectedLabels = new List<Label>();
        int maxSelectedLabels = 7; // Changé de 4 à 7
        List<int> chiffresGagnants = new List<int>();

        int test = 0;


        public Form1()
        {
            InitializeComponent();
            InitiData();
            DisplayNumbersInPanel();

        }

        private void InitiData()
        {
            label1.Hide();
            l_chiffreChoisis.Hide();
            l_chiffreGagnants.Hide();
            l_listeDesChiffresGagnant.Hide();
            label1.Text = "";
            l_chiffreChoisis.Text = "";
            l_chiffreGagnants.Text = "";
            l_listeDesChiffresGagnant.Text = "";
        }

        private void DisplayNumbersInPanel()
        {
            int lignes = 9;
            int colonnes = 5;
            int initial = 1;
            int labellargeur = 40;
            int labelhauteur = 20;
            int espace = 1;

            for (int i = 0; i < lignes; i++)
            {
                for (int j = 0; j < colonnes; j++)
                {
                    Label label = new Label();
                    label.Text = initial.ToString();
                    label.BorderStyle = BorderStyle.FixedSingle;
                    label.Width = labellargeur;
                    label.Height = labelhauteur;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Location = new Point(j * (labellargeur + espace), i * (labelhauteur + espace));
                    label.Click += Label_Click; // Un seul gestionnaire d'événement
                    panel1.Controls.Add(label);
                    initial++;

                    if (initial > 42) break;
                }
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label; // Conversion sécurisée
            if (clickedLabel != null)              // Vérification
            {
                if (selectedLabels.Count < maxSelectedLabels)
                {
                    clickedLabel.BackColor = Color.Green;       // Action sur le Label
                    selectedLabels.Add(clickedLabel);

                    if (selectedLabels.Count == maxSelectedLabels)
                    {
                        //MessageBox.Show($"Vous avez sélectionné {maxSelectedLabels} labels.");

                        label1.Text = "Chiffres Choisiss";
                        label1.Show();

                        foreach (var item in selectedLabels)
                        {
                            l_chiffreChoisis.Text +=  item.Text + " - ";
                        }

                        l_chiffreChoisis.Show();

                        foreach (Control control in panel1.Controls)
                        {
                            if (control is Label label && !selectedLabels.Contains(label))
                            {
                                label.Enabled = false;
                            }
                        }

                        SelectionnerLesChiffresGagnants();
                        ComparerLesChiffres();
                    }
                }
            }
        }

        private void SelectionnerLesChiffresGagnants()
        {
            //1 Choisir un chiffre entre 1 et 42
            //2 le mettre dans la liste

            Random random = new Random();

            int chiffreChoisi;

            for (int i = 0; i < maxSelectedLabels; i++)
            {
                chiffreChoisi = random.Next(1, 43);
                chiffresGagnants.Add(chiffreChoisi);
            }

            l_chiffreGagnants.Text = "Chiffre Gagnants: ";
            l_chiffreGagnants.Show();

            foreach (var item in chiffresGagnants)
            {
                l_listeDesChiffresGagnant.Text += item.ToString() + " - ";
            }

            l_listeDesChiffresGagnant.Show();
        }

        private void ComparerLesChiffres()
        {
            int chiffreQuiCorrespond = 0;

            for (int i = 0; i < maxSelectedLabels; i++)
            {
                if(selectedLabels[i].Text == chiffresGagnants[i].ToString())
                {
                    chiffreQuiCorrespond++;
                }
            }            

            if(chiffreQuiCorrespond == maxSelectedLabels)
            {
                MessageBox.Show("Super vous avez gagné le jackpot !!!");
            }
            else
            {
                MessageBox.Show("Dommage, vous avez perdu :( ");
            }
        }

    }
}

