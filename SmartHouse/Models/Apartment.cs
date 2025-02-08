using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse.Models;

// описание квартиры по заданию:
// адрес квартиры, коллекция электроприборов
public class Apartment(string address, List<Appliance> appliances)
{
    // адрес квартиры
    public string Address { get; set; } = address;

    // коллекция электроприборов
    public List<Appliance> Appliances { get; set; } = appliances;

    public Apartment():this("", []) {}
} // class Apartment
