/*
 * Criado por SharpDevelop.
 * Usuário: Gustavo
 * Data: 28/07/2019
 * Hora: 20:40
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace My_Heart
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "Greice")
			{
				if (textBox2.Text == "")
				{
					MessageBox.Show("Digite sua senha meu amor :/");
					textBox2.Clear();
					textBox2.Focus();
				}
				else 
					if (textBox2.Text == "27011998")
				{
					string box_title = "I miss you <3";
					MessageBox.Show("Welcome my love! why you so linger? :3",box_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
					MainForm heart = new MainForm();
					heart.Show();
					this.Hide();
				}
			}
			else 
			{
				if (textBox1.Text == "") 
				{
					MessageBox.Show("Digite algo para a identificação!");
					textBox1.Clear();
					textBox2.Clear();
					textBox1.Focus();
				}
				else 
				{  
					string box_title = "Dados inválidos!";
					MessageBox.Show("Você quer entrar no meu coração sem permissão?",box_title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
		
		}
	}
}
