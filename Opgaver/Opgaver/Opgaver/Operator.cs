namespace Opgaver
{
    class Operator
    {
        public int Plus(int num1, int num2)
        {
            return num1 += num2;
        }
        public int Minus(int num1, int num2)
        {
            return num1 -= num2;
        }
        public int Gange(int num1, int num2)
        {
            return num1 *= num2;
        }
        public int Divider(int num1, int num2)
        {
            return num1 /= num2;
        }
    }
}
