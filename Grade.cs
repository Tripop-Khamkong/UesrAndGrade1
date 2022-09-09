public class Grade{
    public static string InputScore() {
        Console.Write("Input Score");

        return Console.ReadLine();
    }
    public static int ConvertStringToInt(string value) {
        if(int.TryParse(value, out int number)) {
           return number;
        }
        throw new Exception("Please input decimal data.");
    }
public static string ConvertScoreToGrade(int score) {
        if (score > 100) {
            throw new Exception("Please input data 0 - 100");}

        if (IsGradeA(score)){
            return "Grade A";
        }
        else if (IsGradeBPlus(score)){
            return "Grade B+";
        }
          else if (IsGradeB(score)){
            return "Grade B";
        }
          else if (IsGradeCPlus(score)){
            return "Grade C+";
        }
          else if (IsGradeC(score)){
            return "Grade C";
        }
         else if (IsGradeDPlus(score)){
            return "Grade D+";
        }
         else if (IsGradeD(score)){
            return "Grade D";
        }
        else return "Grade F" ;

        }
           public static bool IsGradeA(int score){

            return score <= 100 && score >=80;
           }
           public static bool IsGradeBPlus(int score){

            return score < 80 && score >=75;
           }
           public static bool IsGradeB(int score){

            return score < 75 && score >=70;
           }
           public static bool IsGradeCPlus(int score){

            return score < 70 && score >=65;
           }
           public static bool IsGradeC(int score){

            return score < 65 && score >=60;
           }
              public static bool IsGradeDPlus(int score){

            return score < 60 && score >=55;
           }
              public static bool IsGradeD(int score){
                 return score < 55 && score >=50;
           }
    static void PrintInputInformation(
    string InputScore,
    string grade) {
        Console.WriteLine();
        Console.WriteLine("***********************************");
        Console.WriteLine("Score is: {0}", InputScore);
        Console.WriteLine("Grade is:{0}", grade);
        Console.WriteLine("***********************************");
    }
    public static void Main(string[] args){
        string scoretext = InputScore();
        int scoreDecimal = ConvertStringToInt(scoretext);
        string grade = ConvertScoreToGrade(scoreDecimal);

        PrintInputInformation(scoretext, grade );
    }
}