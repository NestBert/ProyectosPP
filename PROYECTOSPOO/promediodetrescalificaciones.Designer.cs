
namespace ProyectosPP.PROYECTOSPOO
{
    partial class promediodetrescalificaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcalificacion1 = new System.Windows.Forms.TextBox();
            this.txtcalificacion2 = new System.Windows.Forms.TextBox();
            this.txtcalificacion3 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calificación 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Calificación 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calificación 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Promedio";
            // 
            // txtcalificacion1
            // 
            this.txtcalificacion1.Location = new System.Drawing.Point(372, 64);
            this.txtcalificacion1.Name = "txtcalificacion1";
            this.txtcalificacion1.Size = new System.Drawing.Size(100, 26);
            this.txtcalificacion1.TabIndex = 4;
            this.txtcalificacion1.TextChanged += new System.EventHandler(this.txtcalificacion1_TextChanged);
            this.txtcalificacion1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcalificacion1_KeyPress);
            // 
            // txtcalificacion2
            // 
            this.txtcalificacion2.Location = new System.Drawing.Point(372, 107);
            this.txtcalificacion2.Name = "txtcalificacion2";
            this.txtcalificacion2.Size = new System.Drawing.Size(100, 26);
            this.txtcalificacion2.TabIndex = 5;
            // 
            // txtcalificacion3
            // 
            this.txtcalificacion3.Location = new System.Drawing.Point(372, 154);
            this.txtcalificacion3.Name = "txtcalificacion3";
            this.txtcalificacion3.Size = new System.Drawing.Size(100, 26);
            this.txtcalificacion3.TabIndex = 6;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(372, 217);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(100, 26);
            this.txtresultado.TabIndex = 7;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(372, 266);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(100, 38);
            this.btncalcular.TabIndex = 8;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // promediodetrescalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtcalificacion3);
            this.Controls.Add(this.txtcalificacion2);
            this.Controls.Add(this.txtcalificacion1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "promediodetrescalificaciones";
            this.Text = "promediodetrescalificaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcalificacion1;
        private System.Windows.Forms.TextBox txtcalificacion2;
        private System.Windows.Forms.TextBox txtcalificacion3;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btncalcular;
    }
}