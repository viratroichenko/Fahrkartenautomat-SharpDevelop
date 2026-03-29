/*
 * Created by SharpDevelop.
 * User: vira.troichenko
 * Date: 10.03.2026
 * Time: 08:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using System;

namespace Fahrkarten
{
	class Program
	{
		public static void Main(string[] args)
		{
			char zone;
			char kOderE;
			double preis = 0.0;
			int anzahlFahrkarten = 0;
			double gesamtpreis = 0.0;
			char weiterefahrkarte; 
			char wiederstarten; 
			
			Console.WriteLine("Kauf von Fahrkarten"); 
			Console.WriteLine(); 
			
			do
			{
				anzahlFahrkarten = 0;
				gesamtpreis = 0.0;
				
				do
				{
					// Zone eingeben
					do
					{
						Console.Write("Zone (1, 2, 3 oder 4): "); 
						zone = Convert.ToChar(Console.ReadLine());
						
						if (zone < '1' || zone > '4') 
						{
							Console.WriteLine("Fehler: Die Zone existiert nicht. Bitte neu eingeben."); 
						}
						
					} while (zone < '1' || zone > '4');

					// Kind oder Erwachsener
					do 
					{  
						Console.Write("<K>ind oder <E>rwachsener: ");
						kOderE = Convert.ToChar(Console.ReadLine());
						
						if(kOderE != 'E' && kOderE != 'e' && kOderE != 'K' && kOderE != 'k') 
						{
							Console.WriteLine("Fehler: Falsche Eingabe. Bitte neu eingeben."); 
						}
						
					} while(kOderE != 'E' && kOderE != 'e' && kOderE != 'K' && kOderE != 'k');
					
					// Preis berechnen
					if (kOderE == 'K' || kOderE == 'k') 
					{
						switch(zone) 
						{
							case '1': preis = 1.80; break;
							case '2': preis = 2.60; break;
							case '3': preis = 3.60; break;
							case '4': preis = 5.80; break;
						}
					}
					else 
					{
						switch(zone) 
						{
							case '1': preis = 3.00; break;
							case '2': preis = 4.40; break;
							case '3': preis = 6.10; break;
							case '4': preis = 9.70; break;
						}
					}
					
					anzahlFahrkarten++;
					gesamtpreis += preis;
					
					Console.WriteLine("Zwischensumme für {0} Fahrkarten: {1:F2} Euro", anzahlFahrkarten, gesamtpreis); 
					
					Console.Write("Weitere Fahrkarte kaufen (j/n)? "); 
					weiterefahrkarte = Convert.ToChar(Console.ReadLine());
							
				} while(weiterefahrkarte == 'j' || weiterefahrkarte == 'J');
				
				Console.WriteLine();
				Console.WriteLine("Gesamtpreis: {0:F2} Euro", gesamtpreis);
				Console.WriteLine("Die Fahrkarten werden gedruckt.");
				Console.WriteLine();
			
				Console.Write("Programm neu starten (j/n)? "); 
				wiederstarten = Convert.ToChar(Console.ReadLine());
			
			} while (wiederstarten == 'j' || wiederstarten == 'J');
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}