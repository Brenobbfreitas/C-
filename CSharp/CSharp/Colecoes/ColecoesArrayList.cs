using System;
using System.Collections;
using System.Text;

namespace CSharp.Colecoes
{ 
 class ColecoesArrayList
{
	public static void Executar()
	{
			var araylist = new ArrayList {
				"palavra",
				3,
				true
            };

			araylist.Add(3.12);

			foreach (var item in araylist){
				Console.WriteLine("{0} => {1}", item, item.GetType());
			}
		}
	}
}