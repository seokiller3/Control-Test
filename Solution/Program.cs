Console.Clear();

string[] arrayoriginal = new string[7] {"Hope", "1234", "777", "Bright future", "Yes", "Lucky", "Matilda"};
string[] arrayfinal = new string[arrayoriginal.Length];

void ArrayFinalSolution(string[] arrayoriginal, string[] arrayfinal)
{
    int count = 0;
    for (int i = 0; i < arrayoriginal.Length; i++)
    {
        if (arrayoriginal.Length <=3)
        {
            arrayfinal[count] = arrayoriginal[i];
            count++;
        }
    }
}