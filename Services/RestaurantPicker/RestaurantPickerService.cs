namespace MiniChallengeEightToTen___Endpoints.Services.RestaurantPicker;
public class RestaurantPickerService : IRestaurantPickerService
{
    public string Category(string num) {
        int numParsed = 0;
        bool isTrue = int.TryParse(num, out numParsed);

        Random random = new Random();
        int ranNum = random.Next(1,9);

        string[] mexRest = {"Sazón", "Topolobampo", "Restaurant Sanchez", "Pujol", "Cosme", "Ella Canta", "Hoja Santa", "Quintonil", "Meso Maya", "Carnitas Uruapan"};
        string[] asRest = {"Le Du","Sézanne", "Nusara", "Den", "Gaggan Anand", "Odette","Florilège", "La Cime", "Sorn", "Narisawa"};
        string[] eastRest = {"Noah's Ark", "Skewers Kabob House", "Aziza", "Saffy's", "Ala", "Albi", "Maydān", "Galit", "Kismet", "Bavel"};

        if(isTrue) {
            if(num == "1") {
                return mexRest[ranNum];
            } else if(num == "2") {
                return asRest[ranNum];
            } else if(num == "3") {
                return eastRest[ranNum];
            }
        }
        return "Pick a number, 1 for Mexican Restaurants, 2 for Asian Restaurants, 3 for Middle Eastern Restaurants";
    }
}