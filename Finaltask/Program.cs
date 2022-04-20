//
string[] array = new string[10] {"hellow", "9", "gel", "send", "com", "son1", "23fin","coma", "-1","1111"};
string[] arraynew = new string[array.Length];
void ArrayResul(string[] array, string[] arraynew)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if(array[i].Length <= 3)
        {
        arraynew[count] = array[i];
        System.Console.Write($"{arraynew[count]};  ");
        count++;
        }
    }
}

ArrayResul(array, arraynew);



