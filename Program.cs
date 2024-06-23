namespace hw_19._06_Despose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Завдання 1:
            //Створіть клас «Фільм», який має зберігати таку інформацію:
            // назва фільму;
            // назва кіностудії;
            // жанр;
            // тривалість;
            // рік.
            //Реалізуйте у класі методи та властивості, необхідні для
            //функціонування класу.
            //Додайте до класу деструктор. Напишіть код для тестування
            //функціональності класу.
            //Напишіть код для деструктора.
            Console.WriteLine("Завдання 1");
            {
                Movie movie1 = new Movie("MTitle", "SName", "Genre", 125.5, 1555);
                Console.WriteLine(movie1);
                movie1.Dispose();
            }


            //        Завдання 2:
            //Створіть клас «Вистава», який має зберігати таку інформацію:
            // назва спектаклю;
            // назва театру;
            // жанр;
            // тривалість;
            // список акторів.
            //Реалізуйте у класі методи та властивості, необхідні для
            //функціонування класу.
            //            Клас має реалізовувати інтерфейс IDisposable.Напишіть код для
            //тестування функціональності класу.
            //Напишіть код для виклику методу Dispose.
            Console.WriteLine("\nЗавдання 2");
            using (Perfomance perfom1 = new Perfomance("PName", "TJearer", "GenreT", 111, "Joe", "Jey", "Jim"))
            {
                Console.WriteLine(perfom1);
            }

            List<string> newList = new List<string> { "Jessy", "John", "Jack" };  //для создания обьекта через лист
            using (Perfomance perfom2 = new Perfomance("newN", "dwadwa", "genreadw", 1155, newList))
            {
                Console.WriteLine(perfom2);
            }

            Perfomance perfom3 = new Perfomance("PName", "TJearer", "GenreT", 111, "Joe", "Jey", "Jim") ;
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }
    }
}
