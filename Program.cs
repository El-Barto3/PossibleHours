int possibleCounter = 1000000;

string solution(int A, int B, int C, int D, int E, int F)
{
    int[] maxValue = new int[] {2,9,5,9,5,9};
    int[] digits = new int[] {A,B,C,D,E,F};
    int[] sorted = new int[digits.Length];
    int maxNumber, maxIndex=0;
    for(int i=digits.Length-1;i>=0;i--)
    {
        maxNumber = 0;
        maxIndex = -1;
        for(int j=0;j<digits.Length;j++)
        {
            if(digits[j]==10)
                continue;
            else
            {
                if(digits[j]>maxNumber && digits[j]<= maxValue[i])
                {
                    maxNumber = digits[j];
                    maxIndex = j;
                }
            }
        }
        if(maxIndex != -1)
            digits[maxIndex] = 10;
            
        sorted[i] = maxNumber;
    }
    string text = $"{A}{B}{C}{D}{E}{F} = ";
    text += $"{sorted[0]}{sorted[1]}:{sorted[2]}{sorted[3]}:{sorted[4]}{sorted[5]}";

    for(int i=0;i<sorted.Length;i++)
    {
        if(sorted[i]>maxValue[i] || sorted[0]==2 && sorted[1]>3 || digits[i] != 10)
        {
            text += " NOT POSSIBLE";
            possibleCounter--;
            break;
        }
    }

    Console.WriteLine(text);
    return text;

}

for(int a=9;a<10;a++)
    for(int b=0;b<10;b++)
        for(int c=0;c<10;c++)
            for(int d=0;d<10;d++)
                for(int e=0;e<10;e++)
                    for(int f=0;f<10;f++) 
                    {
                        solution(a,b,c,d,e,f);
                    }
                    Console.WriteLine("All possiblilities for hour(0-1000000): " + possibleCounter);
/*for(int hour = 0;hour<1000000;hour++)
{
    solution((hour%100000-hour%10000)/10000,(hour%100000-hour%10000)/10000,(hour%10000-hour%1000)/1000,(hour%1000-hour%100)/100,(hour%100-hour%10)/10,hour%10);
}*/
