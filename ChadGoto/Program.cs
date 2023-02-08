
void VirginLinq()
{
    int[] values = { 5, 10, 13, 20, 25, 39, 50 };

    // :3 i can't count :3
    Console.WriteLine(values.Sum());
}





void ChadGoTo()
{
    int[] values = { 5, 10, 13, 20, 25, 39, 50 };

    int sum = 0;
    int position = 0;

starthere: //i'll do all the job again and again counting to potatoes

    sum += values[position];
    if(position++ < values.Length-1)
    {
        goto starthere;
    }

    Console.WriteLine(sum);
}





VirginLinq();
ChadGoTo();