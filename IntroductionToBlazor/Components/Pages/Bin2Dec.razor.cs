using Microsoft.AspNetCore.Components;

namespace IntroductionToBlazor.Components.Pages
{
    public partial class Bin2Dec
    {
        int dec = 0;
        string bin = "";
        private void OnBinInput(ChangeEventArgs e)
        {
            string input = e.Value?.ToString() ?? "";
            if (string.IsNullOrEmpty(input) || input.All(c => c == '0' || c == '1'))
            {
                bin = input;
                Cunvert();
            }
        }
        void Cunvert()
        {
            if (bin.Length < 10)
            {
                dec = bin
                .Select((c, index) => new { Digit = c, Position = bin.Length - index - 1 })
                .Where(x => x.Digit == '1')
                .Sum(x => (int)Math.Pow(2, x.Position));
            }
        }
    }
}
