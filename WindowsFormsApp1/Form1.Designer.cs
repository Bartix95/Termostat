namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TEMP = new System.Windows.Forms.Label();
            this.wyzejbtn = new System.Windows.Forms.Button();
            this.nizejbtn = new System.Windows.Forms.Button();
            this.TempAk = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zmienbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "AKTUALNA TEMPERATURA WYNOSI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TEMP
            // 
            this.TEMP.AutoSize = true;
            this.TEMP.Location = new System.Drawing.Point(152, 36);
            this.TEMP.Name = "TEMP";
            this.TEMP.Size = new System.Drawing.Size(21, 16);
            this.TEMP.TabIndex = 1;
            this.TEMP.Text = "22";
            // 
            // wyzejbtn
            // 
            this.wyzejbtn.Location = new System.Drawing.Point(248, 72);
            this.wyzejbtn.Name = "wyzejbtn";
            this.wyzejbtn.Size = new System.Drawing.Size(33, 23);
            this.wyzejbtn.TabIndex = 2;
            this.wyzejbtn.Text = "/\\";
            this.wyzejbtn.UseVisualStyleBackColor = true;
            this.wyzejbtn.Click += new System.EventHandler(this.wyzejbtn_Click);
            // 
            // nizejbtn
            // 
            this.nizejbtn.Location = new System.Drawing.Point(248, 117);
            this.nizejbtn.Name = "nizejbtn";
            this.nizejbtn.Size = new System.Drawing.Size(33, 23);
            this.nizejbtn.TabIndex = 3;
            this.nizejbtn.Text = "\\/";
            this.nizejbtn.UseVisualStyleBackColor = true;
            this.nizejbtn.Click += new System.EventHandler(this.nizejbtn_Click);
            // 
            // TempAk
            // 
            this.TempAk.AutoSize = true;
            this.TempAk.Location = new System.Drawing.Point(152, 117);
            this.TempAk.Name = "TempAk";
            this.TempAk.Size = new System.Drawing.Size(21, 16);
            this.TempAk.TabIndex = 4;
            this.TempAk.Text = "22";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ustaw temperaturę";
            // 
            // zmienbtn
            // 
            this.zmienbtn.Location = new System.Drawing.Point(68, 168);
            this.zmienbtn.Name = "zmienbtn";
            this.zmienbtn.Size = new System.Drawing.Size(193, 23);
            this.zmienbtn.TabIndex = 6;
            this.zmienbtn.Text = "Aktywuj termostat";
            this.zmienbtn.UseVisualStyleBackColor = true;
            this.zmienbtn.Click += new System.EventHandler(this.zmienbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 231);
            this.Controls.Add(this.zmienbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TempAk);
            this.Controls.Add(this.nizejbtn);
            this.Controls.Add(this.wyzejbtn);
            this.Controls.Add(this.TEMP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TEMP;
        private System.Windows.Forms.Button wyzejbtn;
        private System.Windows.Forms.Button nizejbtn;
        private System.Windows.Forms.Label TempAk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button zmienbtn;
    }
}

