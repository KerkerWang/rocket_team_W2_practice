namespace W2_practice;

class Program
{
    static void Main(string[] args)
    {

        //page5
        //讀入兩個數x和y，選出大的那一個
        //double x, y;
        //Console.WriteLine("請輸入數字x");
        //x = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("請輸入數字y");
        //y = Convert.ToDouble(Console.ReadLine());
        //if (x == y)
        //{
        //    Console.WriteLine("兩數相等");
        //}
        //else if (x > y)
        //{
        //    Console.WriteLine($"數字x:{x}大於數字y:{y}");
        //}
        //else
        //{
        //    Console.WriteLine($"數字x:{x}小於數字y:{y}");
        //}
        //Console.ReadKey();


        //page7
        //讀入x和y，如果x>y，則回傳x-y，否則回傳y-x
        //double x, y;
        //Console.WriteLine("請輸入數字x");
        //x = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("請輸入數字y");
        //y = Convert.ToDouble(Console.ReadLine());
        //if (x == y)
        //{
        //    Console.WriteLine("兩數相等");
        //}
        //else if (x > y)
        //{
        //    Console.WriteLine($"x-y={x - y}");
        //}
        //else
        //{
        //    Console.WriteLine($"y-x={y - x}");
        //}
        //Console.ReadKey();


        //page9
        //讀入x和y，如果x>y，則回傳x-y，否則回傳y-x
        //double x, y;
        //Console.WriteLine("請輸入數字x");
        //x = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("請輸入數字y");
        //y = Convert.ToDouble(Console.ReadLine());
        //if (x == y)
        //{
        //    Console.WriteLine("兩數相等");
        //}
        //else if (x > y)
        //{
        //    Console.WriteLine($"x-y={x - y}");
        //}
        //else
        //{
        //    Console.WriteLine($"y-x={y - x}");
        //}
        //Console.ReadKey();


        //page11
        //輸入一個學生的分數，輸出該成績級別，分數級別如下：
        //90分以上 -> A
        //80~89分 -> B
        //70~79分 -> C
        //60~69分 -> D
        //60分以下 -> F
        //double x;
        //Console.WriteLine("請輸入學生分數");
        //x = Convert.ToDouble(Console.ReadLine());
        //if (x >= 90)
        //{
        //    Console.WriteLine($"grade=\"A\"'");
        //}
        //else if (x >= 80)
        //{
        //    Console.WriteLine($"grade=\"B\"");
        //}
        //else if (x >= 70)
        //{
        //    Console.WriteLine($"grade=\"C\"");
        //}
        //else if (x >= 60)
        //{
        //    Console.WriteLine($"grade=\"D\"");
        //}
        //else
        //{
        //    Console.WriteLine($"grade=\"F\"");
        //}
        //Console.ReadKey();


        //page12
        //double x;
        //使用switch改寫
        //double x;
        //Console.WriteLine("請輸入學生分數");
        //x = Convert.ToDouble(Console.ReadLine());
        //x = Math.Floor(x / 10);
        //switch (x)
        //{
        //    case 9:
        //        Console.WriteLine("grade=\"A\"");
        //        break;
        //    case 8:
        //        Console.WriteLine("grade=\"B\"");
        //        break;
        //    case 7:
        //        Console.WriteLine("grade=\"C\"");
        //        break;
        //    case 6:
        //        Console.WriteLine("grade=\"D\"");
        //        break;
        //    default:
        //        Console.WriteLine("grade=\"F\"");
        //        break;
        //}
        //Console.ReadKey();


        //page15
        //某商店在大特價，根據購買的商品總金額決定打折的折扣，總金額越高折扣越多，折扣表如下：
        //未滿1000 -> 無折扣
        //1000~4999 -> 9折
        //5000~9999 -> 8折
        //高於10000 -> 7折
        //小數點四捨五入，印出折扣後的金額。
        //double x, y;
        //Console.WriteLine("請輸入商品總金額");
        //x = Convert.ToDouble(Console.ReadLine());
        //if (x < 1000)
        //{
        //    y = 1;
        //}
        //else if (x <= 4999)
        //{
        //    y = 0.9;
        //}
        //else if (x <= 9999)
        //{
        //    y = 0.8;
        //}
        //else
        //{
        //    y = 0.7;
        //}
        //double z = Math.Round(x * y);
        //Console.WriteLine($"商品總金額為{x}，折扣後的金額為{z}");
        //Console.ReadKey();


        //page18
        //習題2-1：輸入x和y，如果x>y，則列印x，否則列印y
        //輸入x,y -> 印出x,y -> 比大小 -> 誰大印出誰
        //double x, y;
        //Console.WriteLine("請輸入數字x");
        //x = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("請輸入數字y");
        //y = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine($"數字x為{x},數字y為{y}");
        //if (x > y)
        //{
        //    Console.WriteLine($"數字x:{x}比數字y:{y}大");
        //}
        //else if (y > x)
        //{
        //    Console.WriteLine($"數字y:{y}比數字x:{x}大");
        //}
        //else
        //{
        //    Console.WriteLine("兩數相等");
        //}
        //Console.ReadKey();


        //page20
        //習題2-2：輸入x和y，如果x和y都是正數，令z=1，如兩者均為負數，令z=-1，否則令z=0
        //double x, y, z;
        //Console.WriteLine("請輸入數字x");
        //x = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("請輸入數字y");
        //y = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine($"數字x為{x},數字y為{y}");
        //if (x > 0 && y > 0)
        //{
        //    z = 1;
        //    Console.WriteLine($"兩者均為正數，z={z}");
        //}
        //else if (x < 0 && y < 0)
        //{
        //    z = -1;
        //    Console.WriteLine($"兩者均為負數，z={z}");
        //}
        //else
        //{
        //    z = 0;
        //    Console.WriteLine($"兩者一為正數，一為負數，z={z}");
        //}
        //Console.ReadKey();


        //page22
        //習題2-3：輸入x、y、u、v，如果(x+y)>(u+v)，則令z=x-y，否則令z=u-v
        //double x, y, z, u, v;
        //Console.WriteLine("請輸入數字x");
        //x = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("請輸入數字y");
        //y = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("請輸入數字u");
        //u = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("請輸入數字v");
        //v = Convert.ToDouble(Console.ReadLine());
        //if ((x + y) > (u + v))
        //{
        //    z = x - y;
        //    Console.WriteLine($"(x+y)>(u+v)，z=x-y={z}");
        //}
        //else
        //{
        //    z = u - v;
        //    Console.WriteLine($"(x+y)<=(u+v)，z=u-v={z}");
        //}
        //Console.ReadKey();



        //page25
        //習題2-4：輸入x、y、u、v，如果(x+y)/(u-v)>=2，則令z=x-y，否則令z=u-v
        //double x, y, z, u, v;
        //Console.WriteLine("請輸入數字x");
        //x = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("請輸入數字y");
        //y = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("請輸入數字u");
        //u = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("請輸入數字v");
        //v = Convert.ToDouble(Console.ReadLine());
        //if ((x + y) / (u + v) >= 2)
        //{
        //    z = x - y;
        //    Console.WriteLine($"(x+y)/(u+v)>=2，z=x-y={z}");
        //}
        //else
        //{
        //    z = u - v;
        //    Console.WriteLine($"(x+y)/(u+v)<2，z=u-v={z}");
        //}
        //Console.ReadKey();



        //page27
        //習題2-5：輸入x和y，如果x>=y，令z=x^2，否則令z=y^2
        //double x, y, z;
        //Console.WriteLine("請輸入數字x");
        //x = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("請輸入數字y");
        //y = Convert.ToDouble(Console.ReadLine());
        //if (x >= y)
        //{
        //    z = Math.Pow(x, 2);
        //    Console.WriteLine($"x>=y，z=x^2={z}");
        //}
        //else
        //{
        //    z = Math.Pow(y, 2);
        //    Console.WriteLine($"x<y，z=y^2={z}");
        //}
        //Console.ReadKey();


        //page29
        //習題2-6
        //double income, rate, difference, tax;
        //Console.WriteLine("請輸入數字income");
        //income = Convert.ToDouble(Console.ReadLine());
        //if (income > 4090000)
        //{
        //    rate = .4;
        //    difference = 721100;
        //}
        //else if (income > 2180000)
        //{
        //    rate = .3;
        //    difference = 312100;
        //}
        //else if (income > 1090000)
        //{
        //    rate = .21;
        //    difference = 115900;
        //}
        //else if (income > 410000)
        //{
        //    rate = .13;
        //    difference = 28700;
        //}
        //else
        //{
        //    rate = .06;
        //    difference = 0;
        //}
        //tax = income * rate - difference;
        //Console.WriteLine($"Income is {income}.");
        //Console.WriteLine($"Rate is {rate}.");
        //Console.WriteLine($"Difference is {difference}.");
        //Console.WriteLine($"So your tax = income * rate - difference = {tax}");
        //Console.ReadKey();


        //page31
        //習題2-7
        //double x, y;
        //Console.WriteLine("請輸入數字x");
        //x = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("請輸入數字y");
        //y = Convert.ToDouble(Console.ReadLine());
        //if (x > 0)
        //{
        //    if (y > 0)
        //    {
        //        Console.WriteLine("1st quadrant\n");
        //    }
        //    else if (y == 0)
        //    {
        //        Console.WriteLine("X-axis\n");
        //    }
        //    else
        //    {
        //        Console.WriteLine("4th quadrant\n");
        //    }
        //}
        //else if (x == 0)
        //{
        //    if (y == 0)
        //    {
        //        Console.WriteLine("Origin\n");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Y-axis\n");
        //    }
        //}
        //else
        //{
        //    if (y > 0)
        //    {
        //        Console.WriteLine("2nd quadrant\n");
        //    }
        //    else if (y == 0)
        //    {
        //        Console.WriteLine("X-axis\n");
        //    }
        //    else
        //    {
        //        Console.WriteLine("3rd quadrant\n");
        //    }
        //}


        //page33
        //補充習題1
        //int number, score;
        //Console.WriteLine("請輸入答對題數");
        //number = Convert.ToInt32(Console.ReadLine());
        //if (number <= 10)
        //{
        //    score = number * 6;
        //}
        //else if (number <= 20)
        //{
        //    score = (number - 10) * 2 + 60;
        //}
        //else if (number <= 40)
        //{
        //    score = (number - 20) * 1 + 80;
        //}
        //else
        //{
        //    score = 100;
        //}
        //Console.WriteLine($"答對題數為{number}題，分數為{score}");
        //Console.ReadKey();


        //page35
        //補充習題2-1
        //輸入身高體重，輸出BMI並顯示這樣的BMI是正常還是過輕、過重
        //double x, y, bmi;
        //Console.WriteLine("請輸入身高(m)");
        //x = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("請輸入體重(kg)");
        //y = Convert.ToDouble(Console.ReadLine());
        //bmi = y / x / x;
        //if (bmi < 18.5)
        //{
        //    Console.WriteLine($"bmi為{bmi},體重過輕");
        //}
        //else if (bmi < 24)
        //{
        //    Console.WriteLine($"bmi為{bmi},體重正常");
        //}
        //else
        //{
        //    Console.WriteLine($"bmi為{bmi},體重過重");
        //}
        //Console.ReadKey();


        //page36
        //補充習題2-2
        //隨意輸入三個數，請由大到小 依序印出
        //double x, y, z;
        //Console.WriteLine("請輸入數字x");
        //x = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("請輸入數字y");
        //y = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("請輸入數字z");
        //z = Convert.ToDouble(Console.ReadLine());
        //if (x > y)
        //{
        //    if (y > z)
        //    {
        //        Console.WriteLine($"順序大小為：x > y > z");
        //    }
        //    else
        //    {
        //        if (x > z)
        //        {
        //            Console.WriteLine($"順序大小為：x > z > y");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"順序大小為：z > x > y");
        //        }
        //    }
        //}
        //else
        //{
        //    if (y > z)
        //    {
        //        if (x > z)
        //        {
        //            Console.WriteLine($"順序大小為：y > x > z");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"順序大小為：y > z > x");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine($"順序大小為：z > y > x");
        //    }
        //}
        //Console.ReadKey();


        //page37
        //補充習題2-3
        //企業發放的獎金根據利潤提成。利潤低於或等於10萬元時，獎金可提10 %；
        //利潤高于10萬元，低於20萬元時，低於10萬元的部分按10 % 提成，高於10萬元的部分，可提成7.5 %；
        //20萬到40萬之間時，高於20萬元的部分，可提成5 %；
        //40萬到60萬之間時高於40萬元的部分，可提成3 %；
        //60萬到100萬之間時，高於60萬元的部分，可提成1.5 %；
        //高於100萬元時，超過100萬元的部分按1 % 提成，從鍵盤輸入當月利潤I，求應發放獎金總數？
        //double I, P;
        //Console.WriteLine("請輸入利潤I");
        //I = Convert.ToDouble(Console.ReadLine());
        //if (I <= 100000)
        //{
        //    P = I * .1;
        //}
        //else if (I <= 200000)
        //{
        //    P = 10000 + (I - 100000) * .075;
        //}
        //else if (I <= 400000)
        //{
        //    P = 10000 + 7500 + (I - 200000) * .05;
        //}
        //else if (I <= 600000)
        //{
        //    P = 10000 + 7500 + 10000 + (I - 400000) * .03;
        //}
        //else if (I <= 1000000)
        //{
        //    P = 10000 + 7500 + 10000 + 6000 + (I - 600000) * .015;
        //}
        //else
        //{
        //    P = 10000 + 7500 + 10000 + 6000 + 6000 + (I - 1000000) * .01;
        //}
        //Console.WriteLine($"獎金為{P}");
        //Console.ReadKey();

        //aa


    }
}

