using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessdienerListe
{
    class NewMessdienerDialog
    {
        public ArrayList ShowDialog()
        {
            ArrayList messdiener = new ArrayList();

            Form prompt = new Form();
            prompt.Width = 520;
            prompt.Height = 400;
            prompt.Text = "Neuen Messdiener anlegen";

            Label textLabel1 = new Label() { Left = 50, Top = 20, Text = "Vorname" };
            TextBox inputBox1 = new TextBox() { Left = 50, Top = 50, Width = 200 };
            Label textLabel2 = new Label() { Left = 280, Top = 20, Text = "Nachname"};
            TextBox inputBox2 = new TextBox() { Left = 280, Top = 50, Width = 200 };
            Label textLabel3 = new Label() { Left = 50, Top = 80,Text = "An den angehakten Tagen kann der Messdiener:" ,Width = 500};
            Label textLabelMo = new Label() { Left = 50, Top = 110,Text = "Mo", Width = 50};
            Label textLabelDi = new Label() { Left = 100, Top = 110,Text = "Di", Width = 50 };
            Label textLabelMi = new Label() { Left = 150, Top = 110,Text = "Mi", Width = 50 };
            Label textLabelDo = new Label() { Left = 200, Top = 110,Text = "Do", Width = 50 };
            Label textLabelFr = new Label() { Left = 250, Top = 110,Text = "Fr", Width = 50 };
            Label textLabelSa = new Label() { Left = 300, Top = 110,Text = "Sa", Width = 50 };
            Label textLabelSo = new Label() { Left = 350, Top = 110,Text = "So", Width = 50 };
            CheckBox checkBoxMo = new CheckBox() { Left = 50, Top = 140, Width = 50};
            CheckBox checkBoxDi = new CheckBox() { Left = 100, Top = 140, Width = 50};
            CheckBox checkBoxMi = new CheckBox() { Left = 150, Top = 140, Width = 50};
            CheckBox checkBoxDo = new CheckBox() { Left = 200, Top = 140, Width = 50};
            CheckBox checkBoxFr = new CheckBox() { Left = 250, Top = 140, Width = 50};
            CheckBox checkBoxSa = new CheckBox() { Left = 300, Top = 140, Width = 50};
            CheckBox checkBoxSo = new CheckBox() { Left = 350, Top = 140, Width = 50};
            Label textLabel4 = new Label() { Left = 50, Top = 180, Width = 200, Text = "Bemerkungen:" };
            TextBox textBoxBem = new TextBox() {Left = 50, Top = 210, Width = 220 ,Multiline = true, ScrollBars = ScrollBars.Vertical, Height = 100};

            
            Button confirmation = new Button() { Text = "Speichern", Left = 350, Width = 100, Top = 210 };
            confirmation.Click += (sender, e) => { prompt.Close(); };



            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel1);

            prompt.Controls.Add(inputBox1);
            prompt.Controls.Add(textLabel2);
            prompt.Controls.Add(inputBox2);
            prompt.Controls.Add(textLabel3);
            prompt.Controls.Add(textLabelMo);
            prompt.Controls.Add(textLabelDi);
            prompt.Controls.Add(textLabelMi);
            prompt.Controls.Add(textLabelDo);
            prompt.Controls.Add(textLabelFr);
            prompt.Controls.Add(textLabelSa);
            prompt.Controls.Add(textLabelSo);
            prompt.Controls.Add(checkBoxMo);
            prompt.Controls.Add(checkBoxDi);
            prompt.Controls.Add(checkBoxMi);
            prompt.Controls.Add(checkBoxDo);
            prompt.Controls.Add(checkBoxFr);
            prompt.Controls.Add(checkBoxSa);
            prompt.Controls.Add(checkBoxSo);
            prompt.Controls.Add(textLabel4);
            prompt.Controls.Add(textBoxBem);


            prompt.ShowDialog();
           
            messdiener.Add(inputBox1.Text);
            messdiener.Add(inputBox2.Text);
            messdiener.Add(checkBoxMo.Checked);
            messdiener.Add(checkBoxDi.Checked);
            messdiener.Add(checkBoxMi.Checked);
            messdiener.Add(checkBoxDo.Checked);
            messdiener.Add(checkBoxFr.Checked);
            messdiener.Add(checkBoxSa.Checked);
            messdiener.Add(checkBoxSo.Checked);
            messdiener.Add(textBoxBem.Text);
            

            return messdiener;
        }
    }

    
}
