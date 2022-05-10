
    Console.WriteLine("Введите координаты вектора А:");// честно говоря, я не совсем понял, зачем в этом ДЗ создавать классы и конструкторы
    int x1 = Getinput1("\nВведите значение |x1|: ");     //поэтому сделал по своему.
    int y1 = Getinput1("Введите значение |y1|: ");
    int z1 = Getinput1("Введите значение |z1|: ");


    Console.WriteLine("\nВведите координаты вектора B:");
    int x2 = Getinput1("\nВведите значение |x2|:");
    int y2 = Getinput1("Введите значение |y2|:");
    int z2 = Getinput1("Введите значение |z2|:");

   
    Console.WriteLine($"\nкоординаты вектора A: |x1= {x1}||y1= {y1}||z1= {z1}|");
    Console.WriteLine($"координаты второго B: |x2= {x2}||y2= {y2}||z2= {z2}|");
  
    
    Console.WriteLine("\nВектора A и B");
    var value = Math.Sqrt(x1 * x1 + y1 * y1 + z1 * z1);
    Console.WriteLine($"\nдлина вектора А = {value} ");
    var value1 = Math.Sqrt(x2 * x2 + y2 * y2 + z2 * z2);
    Console.WriteLine($"длина вектора B = {value1}");
    var value3 = x1 * x2 + y1 * y2 + z1 * z2;
    Console.WriteLine($"скалярное произведение векторов = {value3}");
    var value4 = (y1 * z2 - z1 * y2, z1 * x2 - x1 * z2, x1 * y2 - y1 * x2);
    Console.WriteLine($"векторное произведение = {value4}");
    var value5 = value3 / (value * value1);
    Console.WriteLine($"угол между векторами = {value5}");
    var value6 = (x1 + x2, y1 + y2, z1 + z2);
    Console.WriteLine($"сумма векторов A и B = {value6}");
    var value7 = (x1 - x2, y1 - y2, z1 - z2);
    Console.WriteLine($"разность векторов A и B = {value7}");
    


static int Getinput1(string str)
{

    Console.Write($"{str} ");
    int value = 0;
    string input = Console.ReadLine();
    bool converted = int.TryParse(input, out value);

    while (!converted)
    {
        Console.Write("введите корректное значение: ");
        input = Console.ReadLine();
        converted = int.TryParse(input, out value);
    }
    return value;
}


   
    




