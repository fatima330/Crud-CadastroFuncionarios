namespace Crud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            tsbNovo = new ToolStripButton();
            tsbCancelar = new ToolStripButton();
            tsbSalvar = new ToolStripButton();
            tsbAlterar = new ToolStripButton();
            tsbExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            tstIdBuscar = new ToolStripTextBox();
            tsbBuscar = new ToolStripButton();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtBairro = new TextBox();
            label5 = new Label();
            txtCidade = new TextBox();
            label6 = new Label();
            txtUF = new TextBox();
            label8 = new Label();
            mskTelefone = new MaskedTextBox();
            mskCEP = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Transparent;
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNovo, tsbCancelar, tsbSalvar, tsbAlterar, tsbExcluir, toolStripSeparator1, toolStripLabel1, tstIdBuscar, tsbBuscar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(671, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovo
            // 
            tsbNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNovo.Image = (Image)resources.GetObject("tsbNovo.Image");
            tsbNovo.ImageTransparentColor = Color.Magenta;
            tsbNovo.Name = "tsbNovo";
            tsbNovo.Size = new Size(23, 22);
            tsbNovo.Text = "Novo";
            // 
            // tsbCancelar
            // 
            tsbCancelar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbCancelar.Image = (Image)resources.GetObject("tsbCancelar.Image");
            tsbCancelar.ImageTransparentColor = Color.Magenta;
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Size = new Size(23, 22);
            tsbCancelar.Text = "Cancelar";
            // 
            // tsbSalvar
            // 
            tsbSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSalvar.Image = (Image)resources.GetObject("tsbSalvar.Image");
            tsbSalvar.ImageTransparentColor = Color.Magenta;
            tsbSalvar.Name = "tsbSalvar";
            tsbSalvar.Size = new Size(23, 22);
            tsbSalvar.Text = "Salvar";
            tsbSalvar.Click += tsbSalvar_Click;
            // 
            // tsbAlterar
            // 
            tsbAlterar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAlterar.Image = (Image)resources.GetObject("tsbAlterar.Image");
            tsbAlterar.ImageTransparentColor = Color.Magenta;
            tsbAlterar.Name = "tsbAlterar";
            tsbAlterar.Size = new Size(23, 22);
            tsbAlterar.Text = "Alterar";
            tsbAlterar.Click += tsbAlterar_Click;
            // 
            // tsbExcluir
            // 
            tsbExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbExcluir.Image = (Image)resources.GetObject("tsbExcluir.Image");
            tsbExcluir.ImageTransparentColor = Color.Magenta;
            tsbExcluir.Name = "tsbExcluir";
            tsbExcluir.Size = new Size(23, 22);
            tsbExcluir.Text = "Excluir";
            tsbExcluir.Click += tsbExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(76, 22);
            toolStripLabel1.Text = "Buscar por Id";
            // 
            // tstIdBuscar
            // 
            tstIdBuscar.Name = "tstIdBuscar";
            tstIdBuscar.Size = new Size(100, 25);
            // 
            // tsbBuscar
            // 
            tsbBuscar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbBuscar.Image = (Image)resources.GetObject("tsbBuscar.Image");
            tsbBuscar.ImageTransparentColor = Color.Magenta;
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(23, 22);
            tsbBuscar.Text = "Buscar";
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 52);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(10, 67);
            txtId.Name = "txtId";
            txtId.Size = new Size(47, 23);
            txtId.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 52);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(65, 67);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(404, 23);
            txtNome.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 117);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 5;
            label3.Text = "CEP";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 117);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(121, 135);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(209, 23);
            txtBairro.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(357, 117);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 9;
            label5.Text = "Cidade";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(346, 135);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(100, 23);
            txtCidade.TabIndex = 10;
            txtCidade.TextChanged += txtCidade_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(468, 117);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 11;
            label6.Text = "UF";
            label6.Click += label6_Click;
            // 
            // txtUF
            // 
            txtUF.Location = new Point(468, 135);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(47, 23);
            txtUF.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 186);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 15;
            label8.Text = "Telefone";
            // 
            // mskTelefone
            // 
            mskTelefone.Location = new Point(63, 186);
            mskTelefone.Mask = "(99) 00000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(142, 23);
            mskTelefone.TabIndex = 16;
            // 
            // mskCEP
            // 
            mskCEP.Location = new Point(0, 135);
            mskCEP.Mask = "00000-000";
            mskCEP.Name = "mskCEP";
            mskCEP.Size = new Size(100, 23);
            mskCEP.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(530, 197);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 134);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(671, 332);
            Controls.Add(pictureBox1);
            Controls.Add(mskCEP);
            Controls.Add(mskTelefone);
            Controls.Add(label8);
            Controls.Add(txtUF);
            Controls.Add(label6);
            Controls.Add(txtCidade);
            Controls.Add(label5);
            Controls.Add(txtBairro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNovo;
        private ToolStripButton tsbCancelar;
        private ToolStripButton tsbSalvar;
        private ToolStripButton tsbAlterar;
        private ToolStripButton tsbExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox tstIdBuscar;
        private ToolStripButton tsbBuscar;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private Label label4;
        private TextBox txtBairro;
        private Label label5;
        private TextBox txtCidade;
        private Label label6;
        private TextBox txtUF;
        private Label label8;
        private MaskedTextBox mskTelefone;
        private MaskedTextBox mskCEP;
        private PictureBox pictureBox1;
    }
}
