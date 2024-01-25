using System;
using TratExceUm.Entities;

public class Process
{
 /*
  *Solução 2 (ruim): método retornando string.
  * A semântica da operação é prejudicada
  *     Retornar string não tem nada a ver com atualização de reserva
  *     E se a operação tivesse que retornar um string?
  * Ainda não é possível tratar exceções em construtores
  * A lógica fica estruturada em condicionais aninhadas 
 */

    public static void Main()
    {
        Console.Write("Room number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Check-in date (dd/MM/yyyy): ");
        DateTime checkIn = DateTime.Parse(Console.ReadLine());
        Console.Write("Check-out date (dd/MM/yyyy): ");
        DateTime checkOut = DateTime.Parse(Console.ReadLine());

        if (checkOut <= checkIn)
        {
            Console.WriteLine("Error in reservation: Check-out date must be after check-in");
        }
        else
        {
            Reservation reservation = new Reservation(number, checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);

            Console.WriteLine();
            Console.WriteLine("Enter data to update the reservation: ");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            string error = reservation.UpdateDates(checkIn, checkOut);

            if(error != null)
            {
                Console.WriteLine("Error in reservation: " + error);
            }
            else
            {
                Console.WriteLine("Reservation:" + reservation);
            }
        }
    }
}