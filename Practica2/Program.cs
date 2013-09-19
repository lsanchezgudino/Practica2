/*
 * Created by SharpDevelop.
 * User: Aula1
 * Date: 17/09/2013
 * Time: 06:15 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int opc;
		Console.WriteLine("Menu \n 1.Reloj \n 2.Cronometro");
		opc= int.Parse(Console.ReadLine ());
		switch (opc) {
				case 1: Reloj r=new Reloj ();
				        r.iniciar();
				         break;
				
				         case 2: Cronometro c=new Cronometro();
				         c.iniciar ();
				         break;
				    }
		
			
		}
	}
}