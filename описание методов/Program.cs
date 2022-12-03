//Первая группа методов(Ничего не принимает и ничего не возвращает)
//void Method1()
//{
//  Console.WriteLine("Автор...");  // Если мы хотим подписать программу в конце
//} 

// Как вызвать метод

//Method1();

// Вторая группа методов(Могут принимать какие-то аргументы,но ничего не возвращают)
//void Method2(string msg, int count)
//{
//int i = 0;
//while(i<count)
//{
// Console.WriteLine(msg);
//   i++;
//  }
//}
//Method2("Текст сообщения",4);
//Method2(msg:"Текст сообщения",count:4);
//Method2(count:4,msg:"Текстсообщения");



// Третья группа методов(Ничего не принимает,но что-то может возвращать)

//int Method3()
//{
//return DateTime.Now.Year;
//}
//int year = Method3();
//Console.WriteLine(year);


//Четвертая группа методов(Что-то принимают и что-то возвращают)


//string Method4(int count,string text)
//{
// string result = String.Empty;
//int i = 0;
//while(i<count)
// {
// result = result + text;
// i++;
//}
//return result;
//}
//string result = Method4(10, "asdf");
//Console.WriteLine(result);



//Пример с циклом for

//string Method4(int count, string text)
//{
  //  string result = String.Empty;

    //for (int i = 0; i < count; i++)
    //{
      //  result = result + text;
   // }
    //return result;
//}
//string result = Method4(10, "zzzz");
//Console.WriteLine(result);

//Пример с цикло в цикле.

for(int i = 2;i<=10;i++)
{
    for(int j = 1;j<=10;j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}