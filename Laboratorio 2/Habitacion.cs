using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Laboratorio_2
{

    public class Habitacion
    {

        public int Numero { get; set; }
        public double Price { get; set; }
        public string Availability { get; set; }
        public string Cliente { get; set; }
        public string Type { get; set; }

        public Habitacion(int numero, double price, string availability, string cliente, string type)
        {
            Numero = numero;
            Price = price;
            Availability = availability;
            Cliente = cliente;
            Type = type;
        }
        public static void  CreateRomm(ref List<Habitacion> roomList)

        {
            Console.Clear();
            string available = "Disponible";
            string notAvailable = "No Disponible";
            Console.WriteLine("Ingrese el tipo de habitación a crear");
            Console.WriteLine("\n1.Habitación simple");
            Console.WriteLine("\n2.Habitación Doble");
            Console.WriteLine("\n3.Habitación Suite");
            Console.WriteLine("\n4.Habitación Deluxe");
            int addRoom = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de habitación");
            int numRoom = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio por noche ");
            double priceRoom = double.Parse(Console.ReadLine());
            string availability = available;
            string cliente = "";
           
            switch (addRoom) 
            {
                case 1:
                    string type = "Habitación Simple";
                    Console.WriteLine("Ingrese cantidad de camas");
                    int numBeds = int.Parse(Console.ReadLine());
                    Habitacion adRoom = roomList.Find(p => p.Numero == addRoom);
                    if (numRoom != null)
                    {
                        Habitacion newRoom = new Habitacion(numRoom, priceRoom,availability,cliente,type);
                        roomList.Add(newRoom);
                        Console.WriteLine("Habitación simple agregada correctamete");
                        Console.ReadKey();
                    }
                    else
                    {

                        Console.WriteLine("El Número de habitación que ingreso ya existe");
                        Console.ReadKey();
                    }
                    break;
                    case 2:
                    string typeTwo = "Habitación Doble";
                    Console.WriteLine("¿Tiene vista al mar? s/n");
                    bool vistaMar = Console.ReadLine().ToLower()== "s";
                    Habitacion doubleRoom = roomList.Find(p => p.Numero == addRoom);
                    if (addRoom != null)
                    {
                        Habitacion newRoom = new Habitacion(numRoom, priceRoom, availability, cliente, typeTwo);
                        roomList.Add(newRoom);
                        Console.WriteLine("Habitación simple agregada correctamete");
                        Console.ReadKey();
                    }
                    else
                    {

                        Console.WriteLine("El Número de habitación que ingreso ya existe");
                        Console.ReadKey();
                    }

                    break;
                    case 3:
                    string typeThree = "Suite Room";
                    Console.WriteLine("Ingrese el número de valores que tiene la Suite");
                    int switRooms = int.Parse(Console.ReadLine());
                    Console.WriteLine("¿Tiene Jacuzzi? s/n");
                    bool jacuzzi = Console.ReadLine().ToLower() =="s";
                    Habitacion suiteRoom = roomList.Find(p => p.Numero == addRoom);
                    if (addRoom != null)
                    {
                        Habitacion newRoom = new Habitacion(numRoom, priceRoom, availability, cliente, typeThree);
                        roomList.Add(newRoom);
                        Console.WriteLine("Habitación simple agregada correctamete");
                        Console.ReadKey();
                    }
                    else
                    {

                        Console.WriteLine("El Número de habitación que ingreso ya existe");
                        Console.ReadKey();
                    }


                    break;
                    case 4:
                    string typeFour = "Deluxe Room";
                    Console.WriteLine("Ingresee Servicios extra de la habitación");
                    string extra = Console.ReadLine();
                    Habitacion deluxeRoom = roomList.Find(p => p.Numero == addRoom);
                    if (addRoom != null)
                    {
                        Habitacion newRoom = new Habitacion(numRoom, priceRoom, availability, cliente, typeFour);
                        roomList.Add(newRoom);
                        Console.WriteLine("Habitación simple agregada correctamete");
                        Console.ReadKey();
                    }
                    else
                    {

                        Console.WriteLine("El Número de habitación que ingreso ya existe");
                        Console.ReadKey();
                    }
                    break;
                    default:
                    Console.WriteLine("Ingrese una opción valida");
                    break;
            }
        }
        public static void DeleteRoom(ref List<Habitacion> roomList)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el número de la habitación que quiere eliminar");
            int deleteRoom = int.Parse(Console.ReadLine());
            Habitacion deletRoom = roomList.Find(p => p.Numero == deleteRoom);
            if (deletRoom != null)
            {
            roomList.Remove(deletRoom);
                Console.WriteLine("La habitación se ha eliminado");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se encontró el número de habitación que ingreso");
                Console.ReadKey();
            }
        }
        public static void ShowInfoRoom(ref List<Habitacion> roomList)
        {
            Console.Clear();
           foreach (Habitacion room in roomList)
            {
                Console.WriteLine($"Número {room.Numero}| Precio:{room.Price}| Disponibilidad:{room.Availability}| Cliente: {room.Cliente}| Tipo: {room.Type}| ");
                Console.ReadKey(); 
            }
        }
        public static void AsingRoom(ref List<Habitacion> roomList, ref string notAvailable, ref string available)
        {
            Console.Clear();
           Console.WriteLine("Ingrese el número de la habitación que desea asignar");
            int asingRoom = int.Parse(Console.ReadLine());  
            Habitacion room = roomList.Find(p=>p.Numero == asingRoom);
            if (room != null&& room.Cliente == available) 
            {
                Console.WriteLine("Ingrese el Nombre del Cliente");
                string cliente = Console.ReadLine();
                room.Cliente = cliente;
                room.Availability = notAvailable;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se ha encontrado el número de habitación");
                Console.ReadKey();
            }
        }
    }

}
