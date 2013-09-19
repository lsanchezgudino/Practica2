/*
 * Created by SharpDevelop.
 * User: Aula1
 * Date: 17/09/2013
 * Time: 06:16 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica2
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Reloj
	{
		public Reloj()
		{
		}
		
		public void iniciar(){
			for(;;){
				Console.Clear();
			Console.WriteLine (DateTime.Now.ToLongTimeString() );
			System.Threading.Thread.Sleep(1000);
			}
			
		}
	}
}
                                                                                     