using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Habitacion
    {
        public int Numero { get; set; }
        public double Price { get; set; }
        public string Availability { get; set; }
        public string Cliente { get; set; }

        public Habitacion(int numero, double price, string availability, string cliente)
        {
            Numero = numero;
            Price = price;
            Availability = availability;
            Cliente = cliente;
        }
        public void CreateRomm(ref List<Habitacion> roomList )
        {
            Console.Clear();
            Console.WriteLine("Ingrese el Número de la habitación");
            int numRoom = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio de la habitación");
            double priceRoom = double.Parse(Console.ReadLine());
            string disponibilidad = "Disponible";
            string cliente = "";
            Habitacion newRoom = roomList.Find(p => p.Numero == numRoom);
            if (newRoom != null)
            {
                roomList.Add(new Habitacion(numRoom, priceRoom,disponibilidad,cliente));
                Console.WriteLine("Habitación creada correctamente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El número de habitación ya existe");
                Console.ReadKey();
            }

        }
        public void DeleteRoom(ref List<Habitacion> roomList)
        {
            Console.Clear();
            Console.WriteLine("\nIngrese el número de la habitación que quiere eliminar");
            int deleteRoom = int.Parse(Console.ReadLine());
            Habitacion delete = roomList.Find(p=>p.Numero == deleteRoom);
            if (delete != null) 
            {
                roomList.RemoveAt(deleteRoom);
                Console.WriteLine("La habitación se ha eliminado correctamente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No existe ese número de habitación");
                Console.ReadKey();
            }
        }
        public static void ShowRooms(ref List<Habitacion> roomList)

        {
            Console.Clear();   
            Console.WriteLine("Ingrese el número de la habitación que quiere ver la información");
            int numRoom = int.Parse(Console.ReadLine());
            Habitacion searchRoom = roomList.Find(p=>p.Numero == numRoom);
            if (searchRoom != null) 
            {
                Console.WriteLine("Habitación encontrada");
                Console.WriteLine($"Numero:{searchRoom.Numero}| Precio : {searchRoom.Price}| Disponibilidad: {searchRoom.Availability}| Cliente: {searchRoom.Cliente} ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Habitación no encontrada ingrese el número de una habitación existente");
                Console.ReadKey();
            }
        }
        public void ChangeAvaible(ref List<Habitacion>roomList)
        {

        }


    }
}
