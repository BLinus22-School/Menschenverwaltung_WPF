using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menschenverwaltung
{
    public class Menschen : BindableBase
    {
        private List<Mensch> menschenListe = new List<Mensch>();

        public List<Mensch> MenschenListe
        {
            get { return this.menschenListe; }
            set
            {
                SetProperty(ref this.menschenListe, value, nameof(this.MenschenListe));
            }
        }

        private Mensch selectedMensch;

        public Mensch SelectedMensch
        {
            get { return this.selectedMensch; }
            set
            {
                SetProperty(ref this.selectedMensch, value, nameof(this.SelectedMensch));
            }
        }

        public Menschen()
        {

        }




        /*
        
                private void listbxMenschen_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mensch = listbxMenschen.SelectedItem;

            if (mensch != null)
            {
                if (mensch is Kind)
                {
                    var kind = (Kind)mensch;

                    refreshSelectedValues(kind);
                }
                else
                {
                    var erwachsener = (Erwachsener)mensch;

                    refreshSelectedValues(erwachsener);
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Menschen aus.");
            }
        }

        private void btnGeburtstag_Click(object sender, EventArgs e)
        {
            Mensch mensch = (Mensch)listbxMenschen.SelectedItem;
            if (mensch != null)
            {
                mensch.Geburtstag();

                refreshSelectedValues(mensch);
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Menschen aus.");
            }
        }

        private void btnHeiraten_Click(object sender, EventArgs e)
        {
            Mensch mensch = (Mensch)listbxMenschen.SelectedItem;

            if (mensch != null && txtbxNeuerNachname.Text != "")
            {
                if (mensch is Kind)
                {
                    Kind kind = (Kind)mensch;

                    if (kind.Alter < 16)
                    {
                        MessageBox.Show("Kind ist zu jung, um zu Heiraten.");
                        return;
                    }
                    if (kind.Einwilligung == false)
                    {
                        MessageBox.Show("Einwilligung der Eltern muss erst erteilt werden.");
                        return;
                    }
                }

                var result = mensch.Heiraten(txtbxNeuerNachname.Text);
                if (result == false)
                {
                    MessageBox.Show($"{mensch.Vorname} {mensch.Nachname} ist schon verheiratet!");
                }
                else
                {
                    txtbxNeuerNachname.Clear();

                    refreshSelectedValues(mensch);
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Menschen aus oder geben Sie einen neuen Nachnamen an.");
            }
        }

        private void refreshSelectedValues(Mensch mensch)
        {
            txtbxAlter.Text = mensch.Alter.ToString();
            txtbxVorname.Text = mensch.Vorname;
            txtbxNachname.Text = mensch.Nachname;
            txtbxFamilienstand.Text = mensch.Familienstand;
        }

        private void refreshSelectedValues(Erwachsener erwachsener)
        {
            txtbxAlter.Text = erwachsener.Alter.ToString();
            txtbxVorname.Text = erwachsener.Vorname;
            txtbxNachname.Text = erwachsener.Nachname;
            txtbxFamilienstand.Text = erwachsener.Familienstand;

            checkbxAgreement.Checked = false;
            checkbxAgreement.Enabled = false;
        }

        private void refreshSelectedValues(Kind kind)
        {
            txtbxAlter.Text = kind.Alter.ToString();
            txtbxVorname.Text = kind.Vorname;
            txtbxNachname.Text = kind.Nachname;
            txtbxFamilienstand.Text = kind.Familienstand;

            checkbxAgreement.Enabled = true;
            checkbxAgreement.Checked = kind.Einwilligung;
        }

        private void checkbxAgreement_CheckedChanged(object sender, EventArgs e)
        {
            var mensch = listbxMenschen.SelectedItem;

            if (mensch is Kind)
            {
                var kind = (Kind)mensch;

                kind.Einwilligung = checkbxAgreement.Checked;
            }
        }

         */


    }
}
