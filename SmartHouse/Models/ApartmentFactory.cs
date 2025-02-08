using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse.Models;
public class ApartmentFactory
{
    public static readonly string[] AddressSeeds = [
        "Донецк, пр. Мира, 5, 11",
        "Донецк, пр. Ильича, 8, 19",
        "Донецк, пр. Шевченко, 22, 112",
        "Макеевка, ул.Ленина, 7, 8",
        "Горловка, ул. Артема, 67, 71",
    ];
    
    // n - количество приборов в коллекции приборов квартиры
    public static Apartment Create(int n) {
        var address = AddressSeeds[Random.Shared.Next(0, AddressSeeds.Count())];
        List<Appliance> appliances = [];
        for (int i = 0; i < n; i++) {
            appliances.Add(ApplianceFactory.Create(1000 + i + 1)); 
        } // for i

        return new Apartment(address, appliances);
    } // Create
} // class ApartmentFactory
