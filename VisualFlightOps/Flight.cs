/*!
 * Visual Flight Operations Management System
 * Copyright (c) 2026 Louie Bloomberg.
 * SPDX-License-Identifier: MIT
 */
namespace VisualFlightOps;
public class Flight
{
    public int Number { get; set; }
    public string DepCode { get; set; }
    public string ArrCode { get; set; }
    public int CrewId { get; set; }
    public string Status { get; set; }

    public Flight(int number, string depCode, string arrCode, int crewId, string status)
    {
        Number = number;
        DepCode = depCode;
        ArrCode = arrCode;
        CrewId = crewId;
        Status = status;
    }

    public void DisplayFlightInformation()
    {
        Console.WriteLine("Flight Information for FL{0}", Number);
        Console.WriteLine("Departure Airport: {0}", DepCode);
        Console.WriteLine("Arrival Airport: {0}", ArrCode);
        Console.WriteLine("Crew ID: {0}", CrewId);
        Console.WriteLine("Status: {0}", Status);
    }

    public void UpdateFlightInformation()
    {
        Console.WriteLine("Updating Flight Information for FL{0}", Number);
        Console.WriteLine("To leave any flight information alone, leave update field blank.");
        Console.WriteLine("Please enter the new Departure Code");
        string? newDepCode = Console.ReadLine();
        Console.WriteLine("Please enter the new Arrival Code:");
        string? newArrCode = Console.ReadLine();
        Console.WriteLine("Please enter the new Crew ID:");
        string? newCrewIdInput = Console.ReadLine();
        int newCrewId = 0;
        if (!string.IsNullOrWhiteSpace(newCrewIdInput) && !int.TryParse(newCrewIdInput, out newCrewId))
        {
            Console.WriteLine("Invalid crew ID. Flight information was not changed.");
            return;
        }
        UpdateDepartureCode(newDepCode);
        UpdateArrivalCode(newArrCode);
        UpdateCrewId(newCrewId);
    }

    public void UpdateFlightStatus()
    {
        Console.WriteLine("Updating Flight Status for FL{0}", Number);
        Console.WriteLine("The available Flight Status States are as follows: 'Scheduled', 'On Time'," +
                          " 'In Air', 'Arrived', 'Delayed', 'Canceled'.");
        Console.WriteLine("To leave the current flight status as is, please leave this field blank.");
        Console.WriteLine("Please enter the new Flight Status. :");
        string? newStatus = Console.ReadLine();
        UpdateStatus(newStatus);
    }

    private void UpdateDepartureCode(string? newDepCode)
    {
        if (!string.IsNullOrWhiteSpace(newDepCode))
        {
            DepCode = newDepCode;
        }
    }

    private void UpdateArrivalCode(string? newArrCode)
    {
        if (!string.IsNullOrWhiteSpace(newArrCode))
        {
            ArrCode = newArrCode;
        }
    }

    private void UpdateCrewId(int newCrewId)
    {
        if (newCrewId != 0)
        {
            CrewId = newCrewId;
        }
    }

    private void UpdateStatus(string? newStatus)
    {
        if (!string.IsNullOrWhiteSpace(newStatus))
        {
            if (newStatus == "Scheduled" || newStatus == "On Time" || newStatus == "In Air" || newStatus == "Arrived" || newStatus == "Delayed" || newStatus == "Canceled" || newStatus == "Cancelled")
            {
                Status = newStatus == "Cancelled" ? "Canceled" : newStatus;
            }
            else
            {
                Console.WriteLine("Invalid flight status. Please enter a valid flight status.");
            }
        }
    }

}
