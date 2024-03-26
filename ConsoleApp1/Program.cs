

//11111111111111111111111111111111111111111111

//int num = 15;
//int C = 17;
//if (C >= 15)
//{
//    Console.WriteLine("hava istidir");
//}
//else
//{
//    Console.WriteLine("hava soyuqdur");
//}
//-------22222222222222222222222222222222222 tersine yazdiqim----------

//int day = 29;

//switch (day)
//{
//    case 31:
//        Console.WriteLine("yanvar");
//        Console.WriteLine("mart");
//        Console.WriteLine("aprel");
//        Console.WriteLine("iyun");

//        Console.WriteLine("decabr");
//        Console.WriteLine("noyabr");
//        break;
//    case 29:
//        Console.WriteLine("fevral");
//        break;
//    case 30:
//        Console.WriteLine("may");
//        Console.WriteLine("iyul");
//        Console.WriteLine("avqust");
//        Console.WriteLine("sentyabr");
//        Console.WriteLine("oktyabr");
//        break;
//} 
//------------22222222222222222222-----------------
//string mounth = "yanvar";
//switch (mounth)
//{
//    case "yanvar":
//        Console.WriteLine(31); 
//        break;
//    case "fefral":
//        Console.WriteLine(29);
//        break;
//    case "mart":
//        Console.WriteLine(31);
//        break;
//    case "aprel":
//        Console.WriteLine(31);
//        break;
//    case "may":
//        Console.WriteLine(30);
//        break;
//    case "iyun":
//        Console.WriteLine(31);
//        break;
//    case "iyul":
//        Console.WriteLine(30);
//        break;
//    case "avqus":
//        Console.WriteLine(31);
//        break;
//    case "sentyabr":
//        Console.WriteLine(30);
//        break;
//    case "oktyabr":
//        Console.WriteLine(30);
//        break;
//    case "noyabr":
//        Console.WriteLine(30);
//        break;
//    case "dekabr":
//        Console.WriteLine(31);
//        break;
//}
//---------33333333333333333333333------------
//int num = 4;
//for(int i = 1; i < num; i++)
//{
//        i = i + 1;
//    if(num > 0)
//    {
//        i++;
//        Console.WriteLine(i*(i+1));    
//    }

//}


//---------------44444444444444444-------------

//int num = 15;
//for(int i = 2; i < num;i++)
//{

//    if (num % i == 0)
//    {
//        Console.WriteLine("murekkeb");
//    break;
//    }

//}

//----------555555555555555555----------

//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,11};
//int sum = 0;
//for (int i = 0;i< arr.Length; i++)
//{

//    if (arr[i] % 2 !=0 )
//    {
//        sum += arr[i];

//    }

//}
//    Console.WriteLine(sum);
//-------666666666666666666-----------------

//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 9, 8 };
//int i = 0;
//int max = arr[i];
//for( i = 0; i < arr.Length; i++)
//{
//    if (arr[i] > max)
//    {
//        max= arr[i];
//    }
//}
//Console.WriteLine(max);
//--------7777777777777777777777---------------


//int num = 887;
//bool result = false;
//for(int i = 0; i < num; i++)
//{
//   for(int j=i;j)
//}

//----------888888888--------------

//int num = 18;
//bool ard = true;
//int count = -1;
//for (int i = 1; ard; i *= 2)
//{
//    count++;
//    if (i == num)
//    {
//        Console.WriteLine(count);
//        ard = false;
//    }
//    else if (num < i)
//    {
//        if (num - i / 2 < i - num)
//        {
//            Console.WriteLine(count - 1);
//            ard = false;
//        }
//        else
//        {
//            Console.WriteLine(count);
//            ard = false;
//        }
//    }
//}


// mellim bunu basa dusmedim



//--------999999999999---------------
//int num = 69825;
//int a = num % 10;
//int b = num / 10;
//bool result = false;
//for (int i = 0; i < num; i++)
//{
//    for (int j = 0; j < a; j++)
//    {

//    if (b / 10 != 0)
//    {                  
//        a = b % 10;
//        b = b / 10;
//        result = true;

//    }
//    }


//}
//if (result)
//{
//    if (b > a) { Console.WriteLine(b); }
//    else { Console.WriteLine(a);    }
//}

//------10-10-10-10-10-10----------------------


//int[] arr = { 6, 7, 1, 2, 3, 4, 5 };
//int i = 0;
//int arrmin = arr[i];
//for (i = 0; i < arr.Length; i++)
//{
//    if (arrmin > arr[i])
//    {
//        arrmin = arr[i];

//    }
//}
//    Console.WriteLine(arrmin);


//-----------11--11--11--11--11---------------


//int[] arr = { 1, 2, 33, 3, 44, 55, 5 };
//int count = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] / 10 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

//------------12---12--12---12--12----------------

//int num = 55;
//int a = num % 10;
//int b = num / 10;
//if (a >b)
//{
//    Console.WriteLine("teklikler boyukdur");
//}
//else if(a == b)
//{
//    Console.WriteLine("beraberdirler");
//}
//else { Console.WriteLine("onluqlar boyukdur"); }

//------------13--13--13---13--13-------------------

//int[] arr = { 2, 1, 5, 6, 7, 10, 4, 8 };
//int max = 0;
//int min = 0;
//for (int i = 1;i < arr.Length; i++)
//{
//    if (arr[max] < arr[i])
//    {
//        max = i;
//    }
//    if (arr[min] > arr[i])
//    {
//        min = i;
//    }
//}

//arr[max] += arr[min];
//arr[max] = arr[max] - arr[min];

//int save = arr[max];
//arr[max] = arr[min];
//arr[min] = save;

//for (int i = 0;i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//---------------14---14---14----14---14-----------
//int num = 2452334;
//int count = 1;
//for (int i = 10;i< num;)
//{
//    if (num / i != 0)
//    {
//        i = i * 10;
//    }
//        count++;
//}
//    Console.WriteLine(count);

//-----------------15--15--15-15--15--15------------------------------


//int num = 4444;
//int num2 = 4444 + 70000;
//num2 = num2 * 10 + 8;
//Console.WriteLine(num2);

//string num = "3333";
//Console.WriteLine(7 + num + 8);


//---------------16--16--16--16--16--------------------------------

//int num = 57;
//num = num * 10 * 10 + num;
//Console.WriteLine(num);

//-------------17--17---17--17--17---------------------------------------

//double num = 57;
//num = 57 * 10 + 7;
//double faiz = num * 7 / 100;

//Console.WriteLine(faiz);



//--------------18--18---18---18--18--18-----------------------

//int num = 13;
//if (num % 2 == 0)
//{
//    Console.WriteLine("eded cutdur");
//}
//else
//{
//    Console.WriteLine("eded tekdir");
//}


//-------------19---19---19--19--19---19--------------------------

//int num = 42;
//if (num % 21 != 0)
//{
//    Console.WriteLine("bolunmur");
//}
//else
//{
//    Console.WriteLine("tam bolunur");
//}


//---------------20----20---20---20--20--------------------

//int num = 12;
//int num2 = 13;
//if (num > num2)
//{
//    Console.WriteLine(num + " diger ededden boyukdur");
//}else if (num == num2)
//{
//    Console.WriteLine("beraberdirler");
//}
//else
//{
//    Console.WriteLine(num2 + " diger ededden boyukdur");
//}

//------------21---21---21--21--21--21--21----------------------

//string[] arr = { "salam", "AB106", "saqol" };
//bool result = false;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == "AB106")
//    {
//        result = true;
//    }

//}
//if (result)
//{
//        Console.WriteLine("var");

//}
//else
//{
//    Console.WriteLine("yoxdur");
//}


//--------------22--22---22---22---22---22------------------


//int M = 100;
//int count = 0;
//for(int i = 1; i < M; i++)
//{
//    if(i % 15 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);


//----------------elave 2 denenin 1 cisi-----------------------------


//int[] arr1 = { 4, 5, 9, 11, 15 };
//int[] arr2 = { 1, 5, 3, 15 };
//for (int i = 0; i < arr1.Length; i++)
//{
//    for (int j = 0; j < arr2.Length; j++)
//    {
//        if (arr1[i] == arr2[j])
//        {

//            Console.WriteLine(arr1[i]);

//        }
//    }
//}

int[] arr = { 5, 2, 3 };
for (int i = 0; i < arr.Length - 1; i++)
{
    for (int j = 0; j < arr.Length - i - 1; j++)
    {
        if (arr[j] > arr[j + 1])
        {
            int temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
        }
    }
}    
for (int i = 0;i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}