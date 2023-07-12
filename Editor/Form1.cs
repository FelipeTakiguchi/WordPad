using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> fonts = new List<string>();
            List<string> sizes = new List<string> { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" };

            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fonts.Add(font.Name);
            }

            FamilyFont.ComboBox.ValueMember = "id";
            FamilyFont.ComboBox.DisplayMember = "Font";
            FamilyFont.ComboBox.DataSource = fonts;

            FontSize.ComboBox.ValueMember = "id";
            FontSize.ComboBox.DisplayMember = "Size";
            FontSize.ComboBox.DataSource = sizes;

            this.openFileDialog1.FileOk += delegate
            {
                var conteudo = new StreamReader(openFileDialog1.FileName);

                string line;
                richTextBox1.Text = "";

                while ((line = conteudo.ReadLine()) != null)
                    richTextBox1.Text += line + '\n';

                conteudo.Close();
            };
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.font = new System.Windows.Forms.ToolStripMenuItem();
            this.Arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Paste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FontSize = new System.Windows.Forms.ToolStripComboBox();
            this.FamilyFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Lines = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.font,
            this.Arquivo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1241, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // font
            // 
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(12, 20);
            // 
            // Arquivo
            // 
            this.Arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open,
            this.Save,
            this.Exit});
            this.Arquivo.Name = "Arquivo";
            this.Arquivo.Size = new System.Drawing.Size(61, 20);
            this.Arquivo.Text = "Arquivo";
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(103, 22);
            this.Open.Text = "Open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(103, 22);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(103, 22);
            this.Exit.Text = "Exit";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Paste,
            this.toolStripSeparator1,
            this.FontSize,
            this.FamilyFont,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1241, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Paste
            // 
            this.Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Paste.Image = ((System.Drawing.Image)(resources.GetObject("Paste.Image")));
            this.Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(23, 22);
            this.Paste.Text = "Paste";
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // FontSize
            // 
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(121, 25);
            this.FontSize.Text = "FontSize";
            this.FontSize.ToolTipText = "FontSize";
            this.FontSize.TextChanged += new System.EventHandler(this.UpdateFont);
            // 
            // FamilyFont
            // 
            this.FamilyFont.Name = "FamilyFont";
            this.FamilyFont.Size = new System.Drawing.Size(121, 25);
            this.FamilyFont.Text = "FontFamily";
            this.FamilyFont.TextChanged += new System.EventHandler(this.UpdateFont);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(202, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(825, 432);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.UpdateLines);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1185, 650);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Lines
            // 
            this.Lines.AutoSize = true;
            this.Lines.Location = new System.Drawing.Point(1194, 454);
            this.Lines.Name = "Lines";
            this.Lines.Size = new System.Drawing.Size(13, 13);
            this.Lines.TabIndex = 4;
            this.Lines.Text = "0";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1241, 469);
            this.Controls.Add(this.Lines);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Paste_Click(object sender, EventArgs e)
        {
            var saveLocation = richTextBox1.SelectionStart;

            if (richTextBox1.SelectionLength > 0)
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart, richTextBox1.SelectionLength).Insert(richTextBox1.SelectionStart, Clipboard.GetText());
            else
                richTextBox1.Text = richTextBox1.Text.Insert(richTextBox1.SelectionStart, Clipboard.GetText());

            richTextBox1.SelectionStart = saveLocation + Clipboard.GetText().Length;
            richTextBox1.Text = FamilyFont.SelectedIndex.ToString();
        }

        private void UpdateFont(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(FamilyFont.Text, Convert.ToInt16(FontSize.Text), FontStyle.Regular);
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Informe algo na caixa de texto");
                return;
            }

            saveFileDialog1.Title = "Salvar Arquivo Texto";
            saveFileDialog1.Filter = "Text File|.txt";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.FileName = "SemTitulo_" + DateTime.Now.ToString("ddMMyyyy_HHmmss");
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.InitialDirectory = @"c:\dados";
            saveFileDialog1.RestoreDirectory = true;

            DialogResult resultado = saveFileDialog1.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);

                StreamWriter writer = new StreamWriter(fs);
                writer.Write(richTextBox1.Text);
                writer.Close();
            }
            else
            {
                MessageBox.Show("Operação cancelada");
            }
        }   
        private void UpdateLines(object sender, EventArgs e)
        {
            var texto = richTextBox1.Text.Substring(0, richTextBox1.SelectionStart);
            Lines.Text = (texto.Split('\n').Length - 1).ToString();
        }
    }
}
