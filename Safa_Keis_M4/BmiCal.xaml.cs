namespace Safa_Keis_M4;

public partial class BmiCal : ContentPage
{
	public BmiCal()
	{
		InitializeComponent();
	}


    String Choice = "Male";

    private void TapMale_Tapped(object sender, TappedEventArgs e)
    {
        Choice = "Male";
        FrameMale.BorderColor = Color.FromArgb("#0a0e29");
        FrameFemale.BorderColor = Color.FromArgb("#fdfdfd");

    }

    private void TapFemale_Tapped(object sender, TappedEventArgs e)
    {
        Choice = "Female";
        FrameMale.BorderColor = Color.FromArgb("#fdfdfd");
        FrameFemale.BorderColor = Color.FromArgb("#0a0e29");

    }

    private void BtnCalculateBMI_Clicked(object sender, EventArgs e)
    {
        double height = double.Parse(LblHeight.Text);
        double weight = double.Parse(LblWeight.Text);
        double bmi = (weight*703)/(height*height);

        if (Choice.Equals("Male"))
        {
            if (bmi < 18.5)
            {
                DisplayAlert("Your calculated BMI result are: ",
                            "Gender: Male \n BMI: " + bmi.ToString("F1") +
                             "\nHealth Status: Underweight\n" +
                             "Recommendations:\n " +
                             "  -Increase intake with nutrient-rich foods (e.g., nuts, lean Protein, whole grains).\n" +
                             "  -Incoprporate strenght training to build muscle mass.\n" +
                             "  -Consult a nutritionist if needed",
                             " OK");
            }

            else if (18.5 <= bmi && bmi < 25) {
                DisplayAlert("Your calculated BMI result are: ",
                            "Gender: Male \n BMI: " + bmi.ToString("F1") +
                             "\nHealth Status: Normal Weight\n" +
                             "Recommendations:\n " +
                             "  -Maintain a balanced diet with proteins, healthy fats, and fiber.\n" +
                             "  -Stay physically active wioth at least 150 mintues of exercise per week.\n" +
                             "  -Keep regular check-ups to monitor overall health.",
                             " OK");
            }
            else if (25 <= bmi && bmi < 30)
            {
                DisplayAlert("Your calculated BMI result are: ",
                            "Gender: Male \n BMI: " + bmi.ToString("F1") +
                             "\nHealth Status: Overweight\n" +
                             "Recommendations:\n " +
                             "  -Reduce proccessed foods and focus on portion control.\n" +
                             "  -Engage in regular aerobic exercises (e.g., jogging, swimming) and strength training.\n" +
                             "  -Drink plenty of water and track your progress.",
                             " OK");

            }
            else
            {
                DisplayAlert("Your calculated BMI result are: ",
                            "Gender: Male \n BMI: " + bmi.ToString("F1") +
                             "\nHealth Status: Obese\n" +
                             "Recommendations:\n " +
                             "  -Consult a doctor personalized guidance.\n" +
                             "  -Start with low-impact exercise (e.g., walking, cycling).\n" +
                             "  -Follow a structured wweight-loss meal plan and consider behavioral therapy for lifestyle changes.\n" +
                             "  -Avoid sugary drinks and maintain a consistent sleep schedule.",
                             " OK");

            }


        }
        else
        {
            if (bmi < 18)
            {
                DisplayAlert("Your calculated BMI result are: ", 
                             "Gender: Female\n BMI: " + bmi.ToString("F1") + 
                             "\nHealth Status: Underweight\n" +
                             "Recommendations:\n " +
                             "  -Increase intake with nutrient-rich foods (e.g., nuts, lean Protein, whole grains).\n" +
                             "  -Incoprporate strenght training to build muscle mass.\n" +
                             "  -Consult a nutritionist if needed",
                             " OK");
            }
            else if (18 <= bmi && bmi < 24)
            {
                DisplayAlert("Your calculated BMI result are: ",
                            "Gender: Female \n BMI: " + bmi.ToString("F1") +
                             "\nHealth Status: Normal Weight\n" +
                             "Recommendations:\n " +
                             "  -Maintain a balanced diet with proteins, healthy fats, and fiber.\n" +
                             "  -Stay physically active wioth at least 150 mintues of exercise per week.\n" +
                             "  -Keep regular check-ups to monitor overall health.",
                             " OK");
            }
            else if (24 <= bmi && bmi < 29)
            {
                DisplayAlert("Your calculated BMI result are: ",
                            "Gender: Female \n BMI: " + bmi.ToString("F1") +
                             "\nHealth Status: Overweight\n" +
                             "Recommendations:\n " +
                             "  -Reduce proccessed foods and focus on portion control.\n" +
                             "  -Engage in regular aerobic exercises (e.g., jogging, swimming) and strength training.\n" +
                             "  -Drink plenty of water and track your progress.",
                             " OK");

            }
            else
            {
                DisplayAlert("Your calculated BMI result are: ",
                            "Gender: Female \n BMI: " + bmi.ToString("F1") +
                             "\nHealth Status: Obese\n" +
                             "Recommendations:\n " +
                             "  -Consult a doctor personalized guidance.\n" +
                             "  -Start with low-impact exercise (e.g., walking, cycling).\n" +
                             "  -Follow a structured wweight-loss meal plan and consider behavioral therapy for lifestyle changes.\n" +
                             "  -Avoid sugary drinks and maintain a consistent sleep schedule.",
                             " OK");

            }
        }
           

    }
}