/*Завдання 1:
 Розробити клас «Freezer», який описує морозильну камеру з дотриманням наступних вимог: 
 1. Реалізувати не менше п'яти закритих полів (різних типів), що представляють основні характеристики класу. 
 2. Створити не менше трьох методів управління класом і методи доступу до його закритих полів. 
 3. Створити метод, в який передаються аргументи за посиланням. 
 4. Створити не менше двох статичних полів (різних типів), 
 що представляють спільні характеристики об'єктів даного класу. 
 5. Створити статичний конструктор для ініціалізації статичних полів. 
 6. Обов'язковою вимогою є реалізація декількох перевантажених конструкторів, 
 аргументи яких визначаються студентом, виходячи із специфіки реалізованого класу 
 і так само реалізація конструктора за замовчуванням. По можливості застосувати делегування конструкторів. 
 7. Перевизначити алгоритм методу ToString(), який буде повертати інформацію про об’єкт у вигляді рядка. 
 8. Перенести описи всіх методів в інший файл, використовуючи partial class. 
 9. Створити масив (не менше 5 елементів) об'єктів створеного класу та показати інформацію по кожному*/


namespace _03._Intro_to_OOP
{
    public partial class Freezer
    {
        public string brand { get; set; }
        public string model { get; set; }
        private DateTime dateManufacture;
        private bool frostMode = true;
        private float temperature;
        public float _temperature
        {
            get { return temperature; }
            set
            {
                if (value >= -50 && value <= -10)
                {
                    temperature = value;
                }
                else
                {
                    temperature = 0;
                }
            }
        }

        private int volume;
        public int _volume
        {
            get { return volume; }
            set
            {
                if (value >= 5 && value <= 100)
                {
                    volume = value;
                }
                else
                {
                    volume = 0;
                }
            }
        }
        
        

        void FrostModeOff()
        {
            frostMode = false;
        }
        
        void FrostModeOn()
        {
            frostMode = true;
        }
        
        
        
        public Freezer(string brand, string model, int volume, float temperature)
        {
            this.brand = brand;
            this.model = model;
            this.volume = volume;
            this.temperature = temperature;
            this.temperature = temperature;
            dateManufacture = DateTime.Now;

            count++;
        }

        private static int count;
        
        static Freezer()
        {
            count = 0;
        }

        static int GetCount()
        {
            return count;
        }
        
        public override string ToString()
        {
            return $"Brand: {brand}, Model: {model}, Volume: {volume} L," + 
                   $" Temperature: {temperature} C, Date of manufacture: {dateManufacture.ToString("dd.MM.yyyy")}, Frost mode: {frostMode}";
        }
    }
    
    public partial class Freezer
    {
        DateTime GetDateManufacture()
        {
            return dateManufacture;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Freezer[] freezers = new Freezer[5];
            for (int i = 0; i < 5; i++)
            {
                freezers[i] = new Freezer("LG", "F16", 50, -18 + i);
                Console.WriteLine(freezers[i]);
            }
        }
    }
}
