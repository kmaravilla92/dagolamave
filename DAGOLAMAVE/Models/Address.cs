using System;

namespace DAGOLAMAVE.Models
{
    public class Address
    {
        public string? City;
        public string? PostalCode;
        public string? Street;
        public string? Building;
        public int? FloorNumber;

        public override string ToString()
        {
            return $"{FloorNumber} {Building} {Street}, {City}, {PostalCode}";
        }
    }
}
