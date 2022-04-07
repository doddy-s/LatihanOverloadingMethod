public class Numbers
{
    public int findMinimum(int num1, int num2)
    {
        if(num1 < num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }

    public int findMinimum(int num1, int num2, int num3)
    {
        if(num1 <= num2 && num1 <= num3){
            return num1;
        }
        else if(num2 <= num3)
        {
            return num2;
        }
        else
        {
            return num3;
        }
    }

    public int findMaximum(int num1, int num2)
    {
        if(num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }

    public int findMaximum(int num1, int num2, int num3)
    {
        if(num1 >= num2 && num1 >= num3){
            return num1;
        }
        else if(num2 >= num3)
        {
            return num2;
        }
        else
        {
            return num3;
        }
    }
}