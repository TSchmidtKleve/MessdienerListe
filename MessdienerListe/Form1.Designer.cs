
namespace MessdienerListe
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.newMessdiener = new System.Windows.Forms.Button();
            this.loadList = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveAs = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.newMessdiener);
            this.flowLayoutPanel1.Controls.Add(this.loadList);
            this.flowLayoutPanel1.Controls.Add(this.saveAs);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 39);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // newMessdiener
            // 
            this.newMessdiener.AutoSize = true;
            this.newMessdiener.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newMessdiener.Location = new System.Drawing.Point(3, 3);
            this.newMessdiener.Name = "newMessdiener";
            this.newMessdiener.Size = new System.Drawing.Size(147, 23);
            this.newMessdiener.TabIndex = 0;
            this.newMessdiener.Text = "Neuen Messdiener anlegen";
            this.newMessdiener.UseVisualStyleBackColor = true;
            this.newMessdiener.Click += new System.EventHandler(this.newMessdiener_Click);
            // 
            // loadList
            // 
            this.loadList.Location = new System.Drawing.Point(156, 3);
            this.loadList.Name = "loadList";
            this.loadList.Size = new System.Drawing.Size(75, 23);
            this.loadList.TabIndex = 1;
            this.loadList.Text = "Liste laden";
            this.loadList.UseVisualStyleBackColor = true;
            this.loadList.Click += new System.EventHandler(this.loadList_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveAs
            // 
            this.saveAs.AutoSize = true;
            this.saveAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveAs.Location = new System.Drawing.Point(237, 3);
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(92, 23);
            this.saveAs.TabIndex = 2;
            this.saveAs.Text = "Speichern unter";
            this.saveAs.UseVisualStyleBackColor = true;
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "MessdienerListe";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button newMessdiener;
        private System.Windows.Forms.Button loadList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button saveAs;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

