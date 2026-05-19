int officialExams = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Overall\tOverall\t\tLetter Grade\tExtra Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    //Number of exams that counts on the credit grades
    int creditExams = studentScores.Length - officialExams;

    // Declared variables initialized in 0
    decimal sumExamScores = 0;
    decimal overall = 0;
    int gradedExams = 0;
    decimal examOverall = 0;
    decimal creditOverall = 0;
    int sumOficialExams = 0;
    decimal sumCreditExams = 0;
    decimal extraScore = 0;

    /* 
    the inner foreach loop sums assignment scores
    extra credit assignments are worth 10% of an exam score
    */
    foreach (int score in studentScores)
    {
        gradedExams += 1;

        //Maded a variable to save the scores of the exams and the credits
        if (gradedExams <= officialExams)
        {
            sumExamScores += score;
            sumOficialExams += score;
        }

        else
        {
            sumExamScores += (decimal)score / 10;
            sumCreditExams += score;
        }
    }

    overall = (decimal)(sumExamScores) / officialExams;
    examOverall = (decimal)sumOficialExams / officialExams;
    creditOverall = sumCreditExams / creditExams;
    extraScore = overall - examOverall;


    if (overall >= 97)
        currentStudentLetterGrade = "A+";

    else if (overall >= 93)
        currentStudentLetterGrade = "A";

    else if (overall >= 90)
        currentStudentLetterGrade = "A-";

    else if (overall >= 87)
        currentStudentLetterGrade = "B+";

    else if (overall >= 83)
        currentStudentLetterGrade = "B";

    else if (overall >= 80)
        currentStudentLetterGrade = "B-";

    else if (overall >= 77)
        currentStudentLetterGrade = "C+";

    else if (overall >= 73)
        currentStudentLetterGrade = "C";

    else if (overall >= 70)
        currentStudentLetterGrade = "C-";

    else if (overall >= 67)
        currentStudentLetterGrade = "D+";

    else if (overall >= 63)
        currentStudentLetterGrade = "D";

    else if (overall >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";
    
    Console.WriteLine($"{currentStudent}\t\t{examOverall}\t\t{overall}\t\t{currentStudentLetterGrade}\t\t{creditOverall} ({extraScore} pts)");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
