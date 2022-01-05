/*
 * Criado por SharpDevelop.
 * Usuário: Gustavo
 * Data: 28/07/2019
 * Hora: 23:34
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace My_Heart
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
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
			if (radioButton1.Checked)
			{
				string intro_mes = "Um erro? ou um acerto?"; 
				MessageBox.Show("Ainda temos muito pouco tempo de relacionamento, mas saiba que não importando o tempo ou distância, minha afetividade não irá se alterar... I love u baka <3",intro_mes, MessageBoxButtons.OK, MessageBoxIcon.Information );
			}
			else 
				if (radioButton2.Checked)
			{
				
				string intro_mes = "Amor mole!"; 
				MessageBox.Show("Nosso amor já virou algo constante... todos os dias penso em ti e nunca vou te esquecer... minha dark princess :3 ",intro_mes, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else 
				if (radioButton3.Checked)
			{
				
				string intro_mes = "Eita! Eh muito amor pra caber dentro desse coração! ;3"; 
				MessageBox.Show("Meu amor por você é igual a quantia de gotas que o mar contém, ou, se for menos complexo, consegue contar a quantidade de estrelas que há o céu?... já sabe? Eu tbm te amo meu amor e infinitamente <3",intro_mes, MessageBoxButtons.OK, MessageBoxIcon.Information );
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			MainForm heart = new MainForm();
			heart.Show();
			this.Hide(); 
		}    
	}
}
