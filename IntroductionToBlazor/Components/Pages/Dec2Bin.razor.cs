using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IntroductionToBlazor.Components.Pages
{
    public partial class Dec2Bin
    {
        int dec;
        string bin = "";
        void Cunvert()
        {
            bin = Convert.ToString(dec, 2);
        }
    }
}
