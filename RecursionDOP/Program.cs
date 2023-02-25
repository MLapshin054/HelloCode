// Собрать строку с числами от a до b, a<=b

// string NumbersFor(int a, int b)
// {
//   string result = string.Empty;
//   for (int i = a; i <= b; i++)
//   {
//     result += $"{i} ";
//   }
//   return result;
// }

// string NumbersRec(int a, int b)
// {
//   if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
//   else return string.Empty;
// }

// System.Console.WriteLine(NumbersFor(1, 10));
// System.Console.WriteLine(NumbersRec(1, 10));


// тот же метод, но от большего к меньшему (используя декримент)

// string NumbersFor(int a, int b)
// {
//   string result = string.Empty;
//   for (int i = a; i >= b; i--)
//   {
//     result += $"{i} ";
//   }
//   return result;
// }

// string NumbersRec(int a, int b)
// {
//   if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
//   else return string.Empty;
// }

// System.Console.WriteLine(NumbersFor(10, 1));
// System.Console.WriteLine(NumbersRec(1, 10));


// Сумма чисел от 1 до N при помощи итеративного метода и метода рекурсии.

// int SumFor(int n)
// {
//   int result = 0;
//   for (int i = 1; i <= n; i++) result += i;
//   return result;
// }

// int SumRec(int n)
// {
//   if (n == 0) return 0;
//   else return n + SumRec(n - 1);
// }

// System.Console.WriteLine(SumFor(10));
// System.Console.WriteLine(SumRec(10));


// Факториал числа

// int FactorialFor(int n)
// {
//   int result = 1;
//   for (int i = 1; i <= n; i++) result *= i;
//   return result;
// }

// int FactorialRec(int n)
// {
//   if (n == 1) return 1;
//   else return n * FactorialRec(n - 1);
// }

// System.Console.WriteLine(FactorialFor(10));
// System.Console.WriteLine(FactorialRec(10));


// Вычисление числа а в степени n

// int Prompt(string message)
// {
//   System.Console.Write(message);
//   int res = Convert.ToInt32(Console.ReadLine());
//   return res;
// }

// int PowerFor(int a, int n)
// {
//   int result = 1;
//   for (int i = 1; i <= n; i++) result = result * a;
//   return result;
// }

// int PowerRec(int a, int n)
// {
//   return n == 0 ? 1 : PowerRec(a, n - 1) * a;
//   // if (n == 0) return 1;
//   // else return PowerRec(a, n - 1) * a;
// }

// int PowerRecMath(int a, int n)
// {
//   if (n == 0) return 1;
//   else if (n%2==0) return PowerRecMath(a*a, n/2);
//   else return PowerRecMath(a, n-1)*a;
// }

// System.Console.WriteLine(PowerFor(Prompt("Input A "), Prompt("Input N ")));
// System.Console.WriteLine(PowerRec(Prompt("A: "), Prompt("N: ")));
// System.Console.WriteLine(PowerRecMath(Prompt("Input A "), Prompt("Input N ")));


// Перебор слов
// В некотором машинном алфавите имеются четыре буквы "а", "и", "с" и "в". Покажите все слова,
// состоящие из Т букв, которые можно построить их букв этого алфавита.

// char[] s = { 'а', 'и', 'с', 'в' };
// int count = s.Length;
// int n=1;
// for (int i = 0; i < count; i++)
// {
//   for (int j = 0; j < count; j++)
//   {
//     System.Console.WriteLine($"{n++,-5}{s[i]}{s[j]}");
//   }  
// }

int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
  if (length == word.Length)
  {
    System.Console.WriteLine($"{n++,-4} {new String(word)}"); return;
  }
  for (int i = 0; i < alphabet.Length; i++)
  {
    word[length] = alphabet[i];
    FindWords(alphabet, word, length + 1);
  }
}
FindWords("апож", new char[4]);