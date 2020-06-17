namespace Intro_CSharp
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Mas = new System.Windows.Forms.Button();
            this.Menos = new System.Windows.Forms.Button();
            this.Multi = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Classroom = new System.Windows.Forms.LinkLabel();
            this.IMG1 = new System.Windows.Forms.LinkLabel();
            this.IMG2 = new System.Windows.Forms.LinkLabel();
            this.IMG3 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(650, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mas
            // 
            this.Mas.BackColor = System.Drawing.Color.Goldenrod;
            this.Mas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mas.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mas.ForeColor = System.Drawing.Color.White;
            this.Mas.Location = new System.Drawing.Point(92, 298);
            this.Mas.Name = "Mas";
            this.Mas.Size = new System.Drawing.Size(114, 48);
            this.Mas.TabIndex = 1;
            this.Mas.Text = "Suma";
            this.Mas.UseVisualStyleBackColor = false;
            this.Mas.Click += new System.EventHandler(this.Mas_Click);
            // 
            // Menos
            // 
            this.Menos.BackColor = System.Drawing.Color.Goldenrod;
            this.Menos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menos.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menos.ForeColor = System.Drawing.Color.White;
            this.Menos.Location = new System.Drawing.Point(212, 298);
            this.Menos.Name = "Menos";
            this.Menos.Size = new System.Drawing.Size(114, 48);
            this.Menos.TabIndex = 2;
            this.Menos.Text = "Resta";
            this.Menos.UseVisualStyleBackColor = false;
            this.Menos.Click += new System.EventHandler(this.Menos_Click);
            // 
            // Multi
            // 
            this.Multi.BackColor = System.Drawing.Color.Goldenrod;
            this.Multi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Multi.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multi.ForeColor = System.Drawing.Color.White;
            this.Multi.Location = new System.Drawing.Point(332, 298);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(197, 48);
            this.Multi.TabIndex = 3;
            this.Multi.Text = "Multiplicación";
            this.Multi.UseVisualStyleBackColor = false;
            this.Multi.Click += new System.EventHandler(this.Multi_Click);
            // 
            // Div
            // 
            this.Div.BackColor = System.Drawing.Color.Goldenrod;
            this.Div.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Div.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Div.ForeColor = System.Drawing.Color.White;
            this.Div.Location = new System.Drawing.Point(535, 298);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(144, 48);
            this.Div.TabIndex = 4;
            this.Div.Text = "División";
            this.Div.UseVisualStyleBackColor = false;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Num1
            // 
            this.Num1.BackColor = System.Drawing.Color.Goldenrod;
            this.Num1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.ForeColor = System.Drawing.Color.White;
            this.Num1.Location = new System.Drawing.Point(247, 216);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(100, 37);
            this.Num1.TabIndex = 5;
            // 
            // Num2
            // 
            this.Num2.BackColor = System.Drawing.Color.Goldenrod;
            this.Num2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.ForeColor = System.Drawing.Color.White;
            this.Num2.Location = new System.Drawing.Point(453, 218);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(100, 37);
            this.Num2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "1° Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "2° Número";
            // 
            // Classroom
            // 
            this.Classroom.AutoSize = true;
            this.Classroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Classroom.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Classroom.Location = new System.Drawing.Point(325, 81);
            this.Classroom.Name = "Classroom";
            this.Classroom.Size = new System.Drawing.Size(158, 42);
            this.Classroom.TabIndex = 10;
            this.Classroom.TabStop = true;
            this.Classroom.Text = "Classroom";
            this.Classroom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Classroom_LinkClicked);
            // 
            // IMG1
            // 
            this.IMG1.AutoSize = true;
            this.IMG1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IMG1.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.IMG1.Location = new System.Drawing.Point(12, 349);
            this.IMG1.Name = "IMG1";
            this.IMG1.Size = new System.Drawing.Size(202, 42);
            this.IMG1.TabIndex = 11;
            this.IMG1.TabStop = true;
            this.IMG1.Text = "IMG Codigo 1";
            this.IMG1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IMG1_LinkClicked);
            // 
            // IMG2
            // 
            this.IMG2.AutoSize = true;
            this.IMG2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IMG2.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.IMG2.Location = new System.Drawing.Point(12, 391);
            this.IMG2.Name = "IMG2";
            this.IMG2.Size = new System.Drawing.Size(206, 42);
            this.IMG2.TabIndex = 12;
            this.IMG2.TabStop = true;
            this.IMG2.Text = "IMG Codigo 2";
            this.IMG2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IMG2_LinkClicked);
            // 
            // IMG3
            // 
            this.IMG3.AutoSize = true;
            this.IMG3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IMG3.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.IMG3.Location = new System.Drawing.Point(12, 433);
            this.IMG3.Name = "IMG3";
            this.IMG3.Size = new System.Drawing.Size(190, 42);
            this.IMG3.TabIndex = 13;
            this.IMG3.TabStop = true;
            this.IMG3.Text = "Form Design";
            this.IMG3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IMG3_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 479);
            this.Controls.Add(this.IMG3);
            this.Controls.Add(this.IMG2);
            this.Controls.Add(this.IMG1);
            this.Controls.Add(this.Classroom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Multi);
            this.Controls.Add(this.Menos);
            this.Controls.Add(this.Mas);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Operacionales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Mas;
        private System.Windows.Forms.Button Menos;
        private System.Windows.Forms.Button Multi;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel Classroom;
        private System.Windows.Forms.LinkLabel IMG1;
        private System.Windows.Forms.LinkLabel IMG2;
        private System.Windows.Forms.LinkLabel IMG3;
    }
}

