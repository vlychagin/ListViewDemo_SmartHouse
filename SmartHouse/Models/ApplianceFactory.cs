using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse.Models;
public static class ApplianceFactory
{
    public static (int ImageIndex, string Name)[] ApplianceSeeds = [
        (0, "очиститель воздуха"),
        (1, "кондиционер"),
        (2, "бойлер"),
        (3, "люстра"),
        (4, "панель управления"),
        (5, "настольная лампа"),
        (6, "посудомоечная машина"),
        (7, "торшер"),
        (8, "морозильная камера"),
        (9, "холодильник"),
        (10, "микроволновка"),
        (11, "радио"),
        (12, "телевизор"),
        (13, "пылесос"),
        (14, "стиральная машина"),
    ];

    public static Appliance Create(int id) {
        var (imageIndex, name) = ApplianceSeeds[Random.Shared.Next(0, ApplianceSeeds.Length)];
        int power = Random.Shared.Next(1, 500) * 10;
        int price = Random.Shared.Next(1, 500) * 100;
        bool state = Random.Shared.Next(1, 10) >= 5; 

        return new Appliance(id, name, power, price, state, imageIndex);
    } // Create
} // class ApplianceFactory
