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


    // Возвращает копию коллекции, упорядоченную по возрастанию поля,
    // заданного лямбда-выражением
    public List<Appliance> OrderBy(Func<Appliance, object> lambda) => 
        Appliances
        .OrderBy(lambda)
        .ToList();


    // Возвращает копию коллекции, упорядоченную по убыванию поля,
    // заданного лямбда-выражением
    public List<Appliance> OrderByDescending(Func<Appliance, object> lambda) =>
        Appliances
        .OrderByDescending(lambda)
        .ToList();


    // Отбор приборов с минимальной стоимостью
    public List<Appliance> WhereMinPrice() {
        int minPrice = Appliances.Min(a => a.Price);
        return 
            Appliances
            .Where(a => a.Price == minPrice)
            .ToList();
    } // WhereMinPrice
} // class Apartment
