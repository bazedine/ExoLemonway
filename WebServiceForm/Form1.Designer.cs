namespace WebServiceForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnshowservice = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.Label();
            this.ResultFab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textxmltojson = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bxresult = new System.Windows.Forms.Label();
            this.btnshowxmltojson = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnshowservice
            // 
            this.btnshowservice.Location = new System.Drawing.Point(76, 52);
            this.btnshowservice.Name = "btnshowservice";
            this.btnshowservice.Size = new System.Drawing.Size(176, 23);
            this.btnshowservice.TabIndex = 1;
            this.btnshowservice.Text = "Valider";
            this.btnshowservice.UseVisualStyleBackColor = true;
            this.btnshowservice.Click += new System.EventHandler(this.btnshowservice_Click);
            // 
            // txtNum
            // 
            this.txtNum.AutoSize = true;
            this.txtNum.Location = new System.Drawing.Point(121, 20);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(71, 13);
            this.txtNum.TabIndex = 2;
            this.txtNum.Text = "Fibonacci(10)";
            // 
            // ResultFab
            // 
            this.ResultFab.AutoSize = true;
            this.ResultFab.Location = new System.Drawing.Point(156, 142);
            this.ResultFab.Name = "ResultFab";
            this.ResultFab.Size = new System.Drawing.Size(0, 13);
            this.ResultFab.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "XML";
            // 
            // textxmltojson
            // 
            this.textxmltojson.Location = new System.Drawing.Point(65, 162);
            this.textxmltojson.Name = "textxmltojson";
            this.textxmltojson.Size = new System.Drawing.Size(318, 20);
            this.textxmltojson.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.btnshowservice);
            this.groupBox1.Location = new System.Drawing.Point(40, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 93);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fibonacci";
            // 
            // bxresult
            // 
            this.bxresult.AutoSize = true;
            this.bxresult.Location = new System.Drawing.Point(116, 218);
            this.bxresult.Name = "bxresult";
            this.bxresult.Size = new System.Drawing.Size(0, 13);
            this.bxresult.TabIndex = 10;
            // 
            // btnshowxmltojson
            // 
            this.btnshowxmltojson.Location = new System.Drawing.Point(64, 191);
            this.btnshowxmltojson.Name = "btnshowxmltojson";
            this.btnshowxmltojson.Size = new System.Drawing.Size(318, 23);
            this.btnshowxmltojson.TabIndex = 11;
            this.btnshowxmltojson.Text = "Valider";
            this.btnshowxmltojson.UseVisualStyleBackColor = true;
            this.btnshowxmltojson.Click += new System.EventHandler(this.btnshowxmltojson_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(25, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 108);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "XmlToJson";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 271);
            this.Controls.Add(this.btnshowxmltojson);
            this.Controls.Add(this.bxresult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textxmltojson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultFab);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Fibonacci / XmlToJson";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnshowservice;
        private System.Windows.Forms.Label txtNum;
        private System.Windows.Forms.Label ResultFab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textxmltojson;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label bxresult;
        private System.Windows.Forms.Button btnshowxmltojson;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

