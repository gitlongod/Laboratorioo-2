
using Laboratorio_2;

bool generalContinue = true;
List<Habitacion> roomList = new List<Habitacion>();


do
{
	try
	{
			
	}
	catch (Exception)
	{

		throw;
	}
} while (true);
static int Menu()
{
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
static void ShowMenu()
{
	switch (Menu())
	{
		case 1:
			break;
		case 2:
			break;
			case 3:
			break;	
			case 4:
            Console.WriteLine();
            break;
			case 5:
			break;
	}
}
