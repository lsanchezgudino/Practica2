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
	/// Description of Cronometro.
	/// </summary>
	public class Cronometro
	{
		public Cronometro()
		{
		}
		public void iniciar(){
			int h,m,s;
			Console.Clear();
			for(h=0;h<24;h++){
				for(m=0;m<60;m++){
					for(s=0;s<60;s++){
						Console.WriteLine(h.ToString("00") + ":" + m.ToString("00") + ":" + s.ToString("00"));
                                    System.Threading.Thread.Sleep(1000);
                                    Console.Clear();

					}
				}
			}
		}
	}
}
