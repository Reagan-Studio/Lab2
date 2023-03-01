using Lab2;


//-------------------------------------------------(инд2)-----------------------------------------------------------------------


////ЗАДАНИЕ НОМЕР 2
//Console.WriteLine("Введите кол-во фигур: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Tor[] tor_lib = new Tor[n];
//for (int i = 0; i < n; i++)
//{
//    tor_lib[i] = new Tor();
//    tor_lib[i].Input();
//}


//string name_long = "";
//int index = 0;
//for (int i = 0; i < n; i++)
//{
//    if (name_long.Length < tor_lib[i].Name.Length)
//    {
//        name_long = tor_lib[i].Name;
//        index = i;
//    }
//}
//Console.WriteLine("\nВсе данные фигуры с самой длинной надписью");
//tor_lib[index].Print();


//Console.WriteLine($"\nВсе данные новой фигуры, которая получена из последней фигуры в массиве путем увеличения ее линейных размеров в 2 раза");
//Tor add_tor = new Tor();
//add_tor.Name = "New tor";
//add_tor.CoefCopy(tor_lib[n - 1], 2);
//add_tor.Print();


//double all_area = 0;
//foreach (Tor t in tor_lib)
//{
//    all_area += t.Area();
//}
//Console.WriteLine($"\nПлощади поверхности всех фигур в массиве = {all_area}");


//double min_area = tor_lib[0].Area();
//int min_index = 0;
//for (int i = 0; i < n; i++)
//{
//    if (min_area > tor_lib[i].Area())
//    {
//        min_area = tor_lib[i].Area();
//        min_index = i;
//    }
//}
//tor_lib[min_index].MIN_rename();
//Console.WriteLine("\nCообщение о фигуре, с наименьшей площадью");
//tor_lib[min_index].Print();


//int counter = 0;
//for (int i = 0; i < n; i++)
//{
//    if (tor_lib[i].Area() > 15)
//    {
//        counter++;
//    }
//}
//Console.WriteLine($"\nKоличество фигур с площадью больше 15 = {counter}");


//Console.WriteLine("\nOбъемы всех фигур в массиве:");
//foreach (Tor t in tor_lib)
//{
//    Console.WriteLine($"Объем фигуры {t.Name} = {t.Volume()}");
//}


//double result = 0;
//for (int i = 0; i < n; i++)
//{
//    result += tor_lib[i].Volume();
//}
//Console.WriteLine($"\nCуммa всех объемов = {result}");






////ЗАДАНИЕ НОМЕР 1

//Tor tor1 = new Tor();
//tor1.Input();
//Tor tor2 = new Tor("Tor2", 8.0, 2.0);

//Console.WriteLine($"\nПлощадь поверхности фигуры {tor1.Name} = {tor1.Area()}");
//Console.WriteLine($"Площадь поверхности фигуры {tor2.Name} = {tor2.Area()}");

//Console.WriteLine($"\nОбъем фигуры {tor1.Name} = {tor1.Volume()}");
//Console.WriteLine($"Объем фигуры {tor2.Name} = {tor2.Volume()}");

//Console.WriteLine($"\nИмя фигуры с наибольшим объемом: {(tor1.Volume() > tor2.Volume() ? tor1.Name : tor2.Name)}");

//Console.WriteLine($"\nПлощадь {(Math.Abs(100 - tor1.Area()) > Math.Abs(100 - tor2.Area()) ? tor2.Name : tor1.Name)} ближе к 100");









//----------------------------------------------------(лаба2)-------------------------------------------------------------------


//Console.WriteLine("Введите кол-во людей для базы данных: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Person[] people = new Person[n];
//for (int i = 0; i < n; i++)
//{
//    people[i] = new Person();
//    people[i].Input();
//}
//foreach (Person person in people)
//{
//    Console.WriteLine(person.ToString());
//}
