using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Text.Json;
using System.IO;
using Newtonsoft.Json;

namespace MessdienerListe
{
    public partial class Form1 : Form
    {
        #region Variablen
        List<Messdiener> messdieners;
      
        string fileName;

        #endregion

        #region konstructor
        #endregion

        #region attribute
     
        #endregion

        public Form1()
        {
            InitializeComponent();
        }


        #region methoden
        #endregion


        #region eventHandler
        private void loadList_Click(object sender, EventArgs e)
        {
            messdieners = new List<Messdiener>();
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string jsonString;
                fileName = openFileDialog1.FileName;
                jsonString = File.ReadAllText(fileName);
                //messdieners = JsonSerializer.Deserialize<List<Messdiener>>(jsonString);
                messdieners = JsonConvert.DeserializeObject<List<Messdiener>>(jsonString);
            }
        }

        private void newMessdiener_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                NewMessdienerDialog newDialog = new NewMessdienerDialog();
                int nextIndex = 0;
                ArrayList result = new ArrayList();

                if(messdieners != null) 
                {
                    foreach (Messdiener m in messdieners)
                    {
                        if (nextIndex < m.Id)
                        {
                            nextIndex = m.Id;
                        }
                    }
                    nextIndex++;
                }
                else
                {
                    messdieners = new List<Messdiener>();
                    nextIndex = 0;

                }
                
                result = newDialog.ShowDialog();
                //Messdiener messdiener = new Messdiener(nextIndex,result[0].ToString(), (string)result[1], (bool)result[2], (bool)result[3], (bool)result[4], (bool)result[5], (bool)result[6], (bool)result[7], (bool)result[8], (string)result[9]);
                Messdiener messdiener = new Messdiener();
                messdiener.id = nextIndex;
                messdiener.vorname = (string)result[0];
                messdiener.nachname = (string)result[1];
                messdiener.mo = (bool)result[2];
                messdiener.di = (bool)result[3];
                messdiener.mi = (bool)result[4];
                messdiener.don = (bool)result[5];
                messdiener.fr = (bool)result[6];
                messdiener.sa = (bool)result[7];
                messdiener.so = (bool)result[8];
                messdiener.bemerkung = (string)result[9];
                messdieners.Add(messdiener);
            }
            else
            {
                string message = "Wählen Sie erste eine Liste aus!";
                string caption = "Fehler!!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    
                }
            }
        }


        private void saveAs_Click(object sender, EventArgs e)
        {
             string path;
            string json = "";

            //json = JsonSerializer.Serialize<List<Messdiener>>(messdieners);

            json = JsonConvert.SerializeObject(messdieners);
           

            saveFileDialog1.ShowDialog();
            path = saveFileDialog1.FileName;

            if(saveFileDialog1.FileName != "")
            {
                File.WriteAllText(@path, json);
            }
        }
        #endregion

        
    }
}
