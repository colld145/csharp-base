
/*Завдання 1:
   
   Описати клас з ім'ям Worker, що містить наступні поля:
   
   прізвище та ініціали працівника;
   вік працівника;
   ЗП працівника;
   дата прийняття на роботу.
   
   Написати програму, що виконує наступні дії:
   
   введення з клавіатури даних в масив, що складається з п'яти елементів типу Worker 
   (записи повинні бути впорядковані за алфавітом);
   якщо значення якогось параметру введено не в відповідному форматі - згенерувати відповідний exception.
   вивід на екран прізвища працівника, стаж роботи якого перевищує введене з клавіатури значення.
   
   Рекомендація: перевірку формата даних та генерацію винятку виконуйте в блоці set{} 
   для кожної властивості класа Worker. */


namespace _04._StructClass
{
    
    class Worker
    {
        private string fullName;
        private short age;
        private int salary;
        private DateTime inviteDate;

        public string FullName
        {
            get { return fullName; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Incorrect name.");
                    
                fullName = value;
            }
        }
        
        
        public short Age
        {
            get { return age; }
            set
            {
                if (value < 0) throw new Exception("Age can't be less than 0.");
                    
                age = value;
            }
        }
        
        public int Salary
        {
            get { return salary; }
            set
            {
                if (value < 0) throw new Exception("Salary can't be less than 0.");
                
                salary = value;
            }
        }

        public DateTime InviteDate
        {
            get { return inviteDate; }
            set
            {
                if (value > DateTime.Today) throw new Exception("Incorrect date.");

                inviteDate = DateTime.Today;
            }
        }
        
        
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[5];

            for (int i = 0; i < 5; i++)
            {
                workers[i] = new Worker();
                Console.WriteLine("Enter a name: ");
                try
                {
                    workers[i].FullName = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
                
                Console.WriteLine("Enter an age: ");
                try
                {
                    workers[i].Age = (short)int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
                
                Console.WriteLine("Enter a salary: ");
                try
                {
                    workers[i].Salary = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
                
                Console.WriteLine("Enter an invite date: ");
                try
                {
                    workers[i].InviteDate = DateTime.Today; // ...
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
            }
        }
    }
}