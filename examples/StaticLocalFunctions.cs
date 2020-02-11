namespace DotNetLightningTalks
{
    class StaticLocalFunctions
    {
        float ComputeTax(float price, float rate) 
        {
            return GetTaxAmount(price, rate) + price;

            static float GetTaxAmount(float price, float rate) => (rate * price);
        }
    }
}