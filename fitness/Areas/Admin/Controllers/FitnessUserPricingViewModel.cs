namespace fitness.Areas.Admin.Controllers
{
    internal class FitnessUserPricingViewModel
    {
        private string baslangicFiyat;
        private string profosyonelFiyat;
        private string premiumFiyat;

        public FitnessUserPricingViewModel(string baslangicFiyat, string profosyonelFiyat, string premiumFiyat)
        {
            this.baslangicFiyat = baslangicFiyat;
            this.profosyonelFiyat = profosyonelFiyat;
            this.premiumFiyat = premiumFiyat;
        }
    }
}