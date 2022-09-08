Console.Write("Введите ряд трех значных чисел, разделенных запятой : ");
int count = 0;
string number = Console.ReadLine();

string[] array = new string [number.Length];
int index = 0;
foreach (var item in number)
{
if(item != ' ')
{
array [index] += item.ToString();

}else
{
index++;
}
}
Console.Write("[ ");

for (int i = 0; i <= index-1; i++)
{
Console.Write(array[i] + " ");
}


Console.Write(array[index] + " ]");
for (int i = 0; i < number.Length; i++)
if ( number [i] != ','&& number[i] % 2 == 0 )

count ++;


Console.WriteLine($"всего {number.Length} чисел, {count} из них чётные");
