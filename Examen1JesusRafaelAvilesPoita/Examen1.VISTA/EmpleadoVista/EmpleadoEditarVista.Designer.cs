namespace Examen1.VISTA.EmpleadoVista
{
    partial class EmpleadoEditarVista
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(393, 12);
            button3.Name = "button3";
            button3.Size = new Size(95, 23);
            button3.TabIndex = 19;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(278, 217);
            button2.Name = "button2";
            button2.Size = new Size(88, 23);
            button2.TabIndex = 18;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(23, 217);
            button1.Name = "button1";
            button1.Size = new Size(88, 23);
            button1.TabIndex = 17;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(106, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 23);
            textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(106, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 23);
            textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(19, 158);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(255, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 100);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 12;
            label3.Text = "SALARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 58);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 11;
            label2.Text = "PUESTO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 15);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 10;
            label1.Text = "PERSONA ID";
            // 
            // EmpleadoEditarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 311);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmpleadoEditarVista";
            Text = "EmpleadoEditarVista";
            Load += EmpleadoEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}