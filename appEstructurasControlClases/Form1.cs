using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appEstructurasControlClases
{
  public partial class Form1 : Form   // El : significa HEREDA
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void btnAbrirForm2_Click(object sender, EventArgs e)
    {
      Form2 formulario;
      formulario = new Form2();
      formulario.Show();
    }

    private void btnContar_Click(object sender, EventArgs e)
    {
      int hastaQueNumero = 0;
      if (int.TryParse(txtHastaQueNumero.Text, out hastaQueNumero))
      {
        Alumno a;
        a = new Alumno();
        a.Contar(hastaQueNumero);
      }
      else
      {
        MessageBox.Show("Error", "fasdasdas",MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      

      foreach (Control item in this.Controls )
      {
        if (item.GetType().Name == "TextBox" && item.Name!= "txtHastaQueNumero")
        {
          ((TextBox)item).Clear();
        }
       
      }

    }

    private void btnSumar_Click(object sender, EventArgs e)
    {
      Alumno x;
      Alumno y;

      x = new Alumno();
      y = new Alumno();

      x.Contar(2);
      y.Contar(4);

      int n1 = int.Parse(txtN1.Text);
      int n2 = int.Parse(txtN2.Text);

      int r=Matematicas.Sumar(n1, n2);
      
      MessageBox.Show("Suma=" + r);
    }
  }
}
