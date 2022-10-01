using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    public class Car
    {
        public int doors;
        public int enginePower;
        public string model;
        //public -публичный тип. Доступ публичный, если используется вне класса необходима ссылка на класс через точку "Car.doors"
        //private - закрытых тип. Доступ только внутри данного класса
        //protected - защищенный тип. Доступ открыт внутри данного класса и классов с родителем данным классом 
        //Internal - внутренний

        //Свойство
        public int doorsProp { get; set; }

        //Открытый конструктор
        public Car() { }

        protected Car(int Doors, int enginePower, string model)
        {
            Doors = doors;
            this.enginePower = enginePower;

            var carNew = new Car(this);
        }

        //Закрытый конструктор
        private Car(Car clone)
        {

        }

        public int DoorsCustom
        {
            get => _InternalVariable;
            set => _InternalVariable = value;
        }

        private int _InternalVariable;

        //virtual - влияет на скорость обработки метода (уменьшает эту скорость)
        public virtual int Getter()
        {
            return _InternalVariable;
        }

        public void Setter(int value)
        {
            _InternalVariable = value;
        }

        //Методы
        //Void не возвращает значения после завершения метода
        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        //Метод с Int возвращает значения (целочисленные)
        public int GetNumberTen()
        {
            var myInt = 10;
            return myInt;
        }

        //Метод с аргументами (аргумент указывает на тип переменной для возврата, число int приобразуется в строку string)
        public virtual string ConvertIntToString(int count) => count.ToString();
    }

    //Новый класс с родительским классом "Car"
    class BMW : Car
    {
        //Открытый конструктор
        public BMW(int Doors, int enginePower) : base(4, 150, "740")
        {
            var r = Doors;
        }

        public void Method4()
        {
            var r = ConvertIntToString(10);
            var r1 = doorsProp;
            doorsProp = r1;
        }

        //Перегрузка метода
        public override string ConvertIntToString(int count)
        {
            return base.ConvertIntToString(count) + "Text";
        }
    }

    struct CarStruct
    {
        int doors;
        int enginePower;
        string model;
    }
}