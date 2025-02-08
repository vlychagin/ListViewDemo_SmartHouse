using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse.Models;

// Класс, описывающий электроприбор по заданию
// Название, мощность, цена, включен/выключен, индекс условного изображения
// электроприбора в ImageList.
public class Appliance(int id, string name, int power, int price, bool state, int imageIndex)
{
    // идентификатор
    public int Id { get; set; } = id;

    // Название
    public string Name { get; set; } = name;

    // мощность (Вт)
    public int Power { get; set; } = power;

    // цена (руб.)
    public int Price { get; set; } = price;

    // включен/выключен
    public bool State { get; set; } = state;

    // индекс условного изображения в ImageList.
    public int ImageIndex { get; set; } = imageIndex;

    // конструктор
    public Appliance():this(0, "", 0, 0, false, -1) {}


} // class Appliance
