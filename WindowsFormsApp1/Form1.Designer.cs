namespace WindowsFormsApp1
{
    partial class btnguardar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNOMBRE = new System.Windows.Forms.TextBox();
            this.textTELEFONO = new System.Windows.Forms.TextBox();
            this.textFNCIMIENTO = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE CONTACTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TELEFONO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FECHA DE NACIMIENTO";
            // 
            // textNOMBRE
            // 
            this.textNOMBRE.Location = new System.Drawing.Point(174, 136);
            this.textNOMBRE.Name = "textNOMBRE";
            this.textNOMBRE.Size = new System.Drawing.Size(237, 20);
            this.textNOMBRE.TabIndex = 4;
            // 
            // textTELEFONO
            // 
            this.textTELEFONO.Location = new System.Drawing.Point(174, 189);
            this.textTELEFONO.Name = "textTELEFONO";
            this.textTELEFONO.Size = new System.Drawing.Size(237, 20);
            this.textTELEFONO.TabIndex = 5;
            // 
            // textFNCIMIENTO
            // 
            this.textFNCIMIENTO.Location = new System.Drawing.Point(174, 230);
            this.textFNCIMIENTO.Name = "textFNCIMIENTO";
            this.textFNCIMIENTO.Size = new System.Drawing.Size(237, 20);
            this.textFNCIMIENTO.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnguardar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textFNCIMIENTO);
            this.Controls.Add(this.textTELEFONO);
            this.Controls.Add(this.textNOMBRE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "btnguardar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNOMBRE;
        private System.Windows.Forms.TextBox textTELEFONO;
        private System.Windows.Forms.TextBox textFNCIMIENTO;
        private System.Windows.Forms.Button button1;
    }
}

