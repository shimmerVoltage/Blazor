namespace IntroductionToBlazor.Components.Pages
{
    public partial class Factorial
    {
        int n = 0;
        long fact = 1;
        void Calculate()
        {
            fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
        }
    }
}
