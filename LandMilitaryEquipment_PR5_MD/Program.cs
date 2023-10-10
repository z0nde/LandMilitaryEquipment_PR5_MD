﻿/*
 Реализуйте с использованием ООП простейшую консольную базу данных
(без красивого интерфейса) в соответствии со своим вариантом. Функции:
добавление, изменение, удаление, сортировка, поиск, вывод на экран содержимого.
В ходе реализации используйте следующие принципы:
• DRY
• SOLID

База данных сухопутной военной техники. Поля: название, модель,
разработчик, предприятие, стоимость, тип
*/

namespace LandMilitaryEquipment_PR5_MD
{
    public class Program
    {
        public static void Main()
        {
            CentralController.MenuCentralController();
        }
    }
}