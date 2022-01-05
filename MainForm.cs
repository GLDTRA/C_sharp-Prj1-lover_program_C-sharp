/*
 * Criado por SharpDevelop.
 * Usuário: Gustavo
 * Data: 27/07/2019
 * Hora: 19:35
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace My_Heart
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();		
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
		void ToolTip1Popup(object sender, PopupEventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			Form2 lovemine = new Form2 ();
			lovemine.Show ();
			this.Hide();
		}
	}
}
