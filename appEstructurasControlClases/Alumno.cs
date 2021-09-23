using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appEstructurasControlClases
{
  class Alumno
  {
    //Variables
    private int numero;
    //Propiedades
    public int Numero
    {
      get
      {
        return numero;
      }
      set
      {
        numero = value;
      }
    }




    //Constructores
    public Alumno()
    {
      numero = 0;
    }

    //Metodos .. Funcion SubRutina SubPrograma
    //4 tipos de métodos
    public void X()
    {
    
    }
    public void X2(int parametro)
    {

    }
    public Alumno X3()
    {
      Alumno x = new Alumno();
      return x ;
    }
    public string X4(int parametro1, Alumno parametro2)
    {
      return "hola";
    }
    public void Contar(int hastaQueNumero)
    {
      //
      for (int i = 1; i <= hastaQueNumero; i++)
      {
        MessageBox.Show("Contando " + i);
      }
    }
  }
}
