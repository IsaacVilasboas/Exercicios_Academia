namespace Winform_Amigo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxEmail = new TextBox();
            textBoxNome = new TextBox();
            buttonCadastrar = new Button();
            listViewAmigos = new ListView();
            nome = new ColumnHeader();
            email = new ColumnHeader();
            label4 = new Label();
            buttonGerarAmigo = new Button();
            buttonLimpar = new Button();
            listViewSecretos = new ListView();
            listaAmigo = new ColumnHeader();
            listaAmigo2 = new ColumnHeader();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 70);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Email :";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(60, 67);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(193, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(61, 40);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(193, 23);
            textBoxNome.TabIndex = 1;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(260, 53);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(91, 23);
            buttonCadastrar.TabIndex = 4;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += button2_Click;
            // 
            // listViewAmigos
            // 
            listViewAmigos.Columns.AddRange(new ColumnHeader[] { nome, email });
            listViewAmigos.Location = new Point(17, 128);
            listViewAmigos.Name = "listViewAmigos";
            listViewAmigos.Size = new Size(369, 262);
            listViewAmigos.TabIndex = 5;
            listViewAmigos.UseCompatibleStateImageBehavior = false;
            listViewAmigos.View = View.Details;
            // 
            // nome
            // 
            nome.Text = "Nome";
            nome.Width = 180;
            // 
            // email
            // 
            email.Text = "Email";
            email.Width = 200;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(535, 110);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 6;
            label4.Text = "Lista Amigo Secreto";
            // 
            // buttonGerarAmigo
            // 
            buttonGerarAmigo.Location = new Point(546, 53);
            buttonGerarAmigo.Name = "buttonGerarAmigo";
            buttonGerarAmigo.Size = new Size(91, 23);
            buttonGerarAmigo.TabIndex = 7;
            buttonGerarAmigo.Text = "Gerar";
            buttonGerarAmigo.UseVisualStyleBackColor = true;
            buttonGerarAmigo.Click += button1_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(364, 396);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(98, 32);
            buttonLimpar.TabIndex = 8;
            buttonLimpar.Text = "Limpar Tabela";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // listViewSecretos
            // 
            listViewSecretos.Columns.AddRange(new ColumnHeader[] { listaAmigo, listaAmigo2 });
            listViewSecretos.Location = new Point(430, 128);
            listViewSecretos.Name = "listViewSecretos";
            listViewSecretos.Size = new Size(323, 262);
            listViewSecretos.TabIndex = 9;
            listViewSecretos.UseCompatibleStateImageBehavior = false;
            listViewSecretos.View = View.Details;
            // 
            // listaAmigo
            // 
            listaAmigo.Text = "Email";
            listaAmigo.Width = 160;
            // 
            // listaAmigo2
            // 
            listaAmigo2.Text = "Email";
            listaAmigo2.Width = 200;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources._43b58PICIf2hZta4meU6G_PIC2018;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(listViewSecretos);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonGerarAmigo);
            Controls.Add(listViewAmigos);
            Controls.Add(buttonCadastrar);
            Controls.Add(textBoxEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxNome);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxEmail;
        private TextBox textBoxNome;
        private Button buttonCadastrar;
        private ListView listViewAmigos;
        private ColumnHeader nome;
        private ColumnHeader email;
        private Label label4;
        private Button buttonGerarAmigo;
        private Button buttonLimpar;
        private ListView listViewSecretos;
        private ColumnHeader listaAmigo;
        private ColumnHeader listaAmigo2;
        private PictureBox pictureBox1;
    }
}