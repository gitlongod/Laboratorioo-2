
using Laboratorio_2;
using System.Collections.Generic;
using System.Globalization;

string available = "Disponible";
string notAvailable = "No Disponible";
bool generalContinue = true;

	
List<Habitacion> roomList = new List<Habitacion>();


do
{
	try
	{
			ShowMenu(ref roomList,ref available,ref notAvailable);
	}
	catch (Exception ex)
	{
        Console.WriteLine(ex.Message);

    }
} while (true);
static int Menu()
{
	Console.Clear();
    Console.WriteLine("\nBIENVENIDO A HOTEL HAMMINGTON");
    Console.WriteLine("\n Ingrese una opción");
    Console.WriteLine("1. Agregar");
    Console.WriteLine("2. Eliminar habitaciones");
    Console.WriteLine("3. Mostrar Habitaciones");
    Console.WriteLine("4. Asignar habitaciones");
    Console.WriteLine("5. Liberar Habitaciones");
    
    int option = Convert.ToInt32(Console.ReadLine());
	return option;
	
}
static void ShowMenu(ref List<Habitacion> roomList,ref string available, ref string notAvailable)
{
	switch (Menu())
	{
		case 1:
			Habitacion.CreateRomm(ref roomList);
			
            break;
		case 2:
			Habitacion.DeleteRoom(ref roomList);
			
			break;
			case 3:
				Habitacion.ShowInfoRoom(ref roomList);
			break;	
			case 4:
		Habitacion.AsingRoom(ref roomList,ref notAvailable);
            break;
			case 5:
			break;
	}
}
