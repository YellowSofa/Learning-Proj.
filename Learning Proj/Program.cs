//chalenge 1
//string Name = "Kylen";
//Console.WriteLine("Hello " + Name);


//challenge 3
//string name = Console.ReadLine();
//Console.WriteLine("hello " + name);


//challenge 4
//int X = 10;
//int Y = 20;
//Console.WriteLine(X + Y);



//challenge 5
//double X = 5;
//double Y = 2;
//Console.WriteLine(X / Y);



//challenge 6
//string C = Console.ReadLine();
//double cel = Convert.ToDouble(C);
//double F = (cel * 1.8) + 32;
//Console.WriteLine(C + " celsius in fahrenheit is " + F);


//challenge 7
//Console.WriteLine("enter age");
//string input = Console.ReadLine();
//int age = Convert.ToInt32(input);
//if(age > 18)
//{
//    Console.WriteLine("You are an adult");
//}
//{
//    Console.WriteLine("you are young");

//}


//challenge 8
//using Microsoft.Win32.SafeHandles;

//string num1 = Console.ReadLine();
//string num2 = Console.ReadLine();
//int out1 = Convert.ToInt32(num1);
//int out2 = Convert.ToInt32(num2);
//if((out1 > 0 && out2 < 0) || (out1 < 0 && out2 > 0))
//{
//    Console.WriteLine("NC one bro");
//}
//else
//{
//    Console.WriteLine("nah bruh");
//}


//challenge 9
//string num1 = Console.ReadLine();
//string num2 = Console.ReadLine();
//int alt1 = Convert.ToInt32(num1);
//int alt2 = Convert.ToInt32(num2);
//if ((alt1 >= -10 && alt1 <= 10)
//||
//(alt2 >= -10 && alt2 <= 10))
//    {
//    Console.WriteLine("NC 1 bro");
//}
//else
//{
//    Console.WriteLine("nah");
//}


//challenge 10/11


//for (int count = 1; count < 50; count = count + 2)
// {
//    Console.WriteLine(count);
//}


//challenge 12

//for (int count = -300; count < -29; count = count + 3)
//{
//    Console.WriteLine(count);
//}


//challenge 13

//int magicnum = 7;
//int ans = 93570347;
//while (ans != magicnum)
//{
//   string input = Console.ReadLine();
//    int inputconcersion = Convert.ToInt32(input);
//    ans = inputconcersion;

//}
//Console.WriteLine("NC 1 bro");


//chalenge 14

//string firstname = "Lebron";
//string surename = "James";
//while (firstname != "Santa" || surename != "Claus")
//{
//    Console.WriteLine("Who brings you presents for christmas");
//    string firstname1 = Console.ReadLine();
//    string surename2 = Console.ReadLine();
//    firstname = firstname1;
//    surename = surename2;

//}
//Console.WriteLine("IKR hes such a good guy");

// array challenge yeyeye
//int[] nums = {1,2,3,4,5,6,7,8,9,10};
//for(i = nums.Length - 1 ; i >= 0; i = i - 1)
//    Console.WriteLine(nums[i]);

//Console.ReadLine();

//int Total = 0;
//int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//for ( int i = 0 ; i < nums.Length; i++ )
//{
//    Total = Total + nums[i];

//}
//double average = Total / nums.Length;
//Console.WriteLine(average);

//string[] Names = new string[5];

//for(int count = 0; count < Names.Length; count++)
//{
//    string name = Console.ReadLine();
//    Names[count] = name;
//}
//for(int loop = 0; loop < Names.Length; loop++)
//{
//    Console.WriteLine(Names[loop]);
//}


using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

//int[] NUMBERS = new int[50];
//for (int count = 0; count < NUMBERS.Length; count++)
//{
//    int Rnum = new Random().Next(1,101);
//    NUMBERS[count] = Rnum;

//}
////smallet
//int smallest = NUMBERS[0];
//for (int count = 0; count < NUMBERS.Length; count++)
//{
//    if (NUMBERS[count] < smallest)
//    {
//        smallest = NUMBERS[count];
//    }
//}

////highest
//int Highest = NUMBERS[0];
//for(int count = 0; count < NUMBERS.Length; count++)
//{
//    if (NUMBERS[count] > Highest)
//    {
//        Highest = NUMBERS[count];
//    }
//}

////output
//Console.WriteLine("the highest number is " + Highest + " the smallest number is " + smallest);



//string[] NAMES = {"larry" , "garry" , "barry" , "harry" , "mary"};
//string input = Console.ReadLine();
//int count = 0;
//while(input != NAMES[count])
//{
//if (input != NAMES[count])
//    {
//        count++;
//    }
//if (count = 5)
//    {
//        input = "larry";
//    }
//}


//string[] NAMES = { "bob", "allan", "chad", "don", "ed" };
//string in1 = "";
//string in2 = "";
//int count = 0;
//int num = NAMES.Length;
//while (in1 != NAMES[count] && in2 != NAMES[count + 1] && count < NAMES.Length)
//{
//    in1 = Console.ReadLine();
//    in2 = Console.ReadLine();
//    if (in1 != NAMES[count] || in2 != NAMES[count + 1])
//    {
//        count = count + 1;
//    }
//    else if (in1 = NAMES[NAMES.Length])
//    {
//        Console.WriteLine("NO");
//    }
//    else
//    {
//        Console.WriteLine("NC1");
//    }
//}


//int[] nums = new int[100];
//for (int count = 0; count < nums.Length; count++)
//{
//    int Rnum = new Random().Next(1, 101);
//    nums[count] = Rnum;
//}
//for (int count = 0; count < nums.Length; count++)
//{
//    if (nums[count] > 30 && nums[count] < 60)
//    {
//        Console.WriteLine(nums[count]);
//    }
//}

//string[] places = { "America", "America", "Bolivia", "Chille", "Denmark", "Denmark" };
//string[] dups = new string[9999999];
//string input = places[0];
//for (int count = 0; count < places.Length; count++)
//{
//    for (int loop = count + 1; loop < places.Length; loop++)
//    {
//        if (places[count] == places[loop])
//            Console.WriteLine(places[count]);
//    }
//}

//challenge 11

//string[] NAMES = { "aron", "bob", "chris", "dan", "earl" };
//string delete = "aron";
//for (int count = 0; count < NAMES.Length; count++)
//{
//    if (NAMES[count] == delete)
//    {
//        NAMES[count] = NAMES[count + 1];
//    }
//}

//for (int count = 1; count < NAMES.Length; count++)
//{
//    if (count == NAMES.Length - 1)
//    {
//        Console.WriteLine(".");
//    }
//    else

//    {
//        NAMES[count] = NAMES[count + 1];
//    }


//}
//NAMES[NAMES.Length] = "";
//for (int loop = 2; loop < NAMES.Length; loop++)
//{
//    Console.WriteLine(NAMES[loop]);
//}

//challneg 12

for (double NUMBER = 100000; NUMBER <= 999999999999999999; NUMBER++)
{
    bool Isprime = true;
    for (int i = 2; i < NUMBER; i++)
    {
        if (NUMBER % i == 0)
        {
            Isprime = false;
        }
    }
    if (Isprime == true)
    {
        Console.Write(NUMBER + ",");
    }
}



