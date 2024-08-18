using System;

// initialize assignment number to calculate average for each student later
int examAssignments = 5;

// initialize necessary arrays
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
int[] studentScores = new int[10];

// initialize letter grade as empty since it occurs later with if else if and else structure
string currentStudentLetterGrade = "";

// decide output organization
Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\tExtra Credit\n");

// loop to understand current student to proceed
foreach (string name in studentNames)
{
    string currentStudent = name;

    // branch to assign studentScores array
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else
        continue;

    // realize common operation for different student
    decimal sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;
    int gradedAssignments = 0;
    decimal examScores = 0;
    decimal extraCreditScores = 0;
    int countExtraCredit = 0;
    foreach (decimal score in studentScores)
    {
        gradedAssignments += 1;
        if (gradedAssignments <= examAssignments)
        {
            sumAssignmentScores += score;
            examScores += score;
        }
        else
        {
            countExtraCredit += 1;
            sumAssignmentScores += score / 10;
            extraCreditScores += score;
        }
    }
    decimal examScoresAverage = (decimal) examScores / examAssignments;
    currentStudentGrade = (decimal) sumAssignmentScores / examAssignments;
    decimal extraCreditScoresAverage = (decimal) extraCreditScores / countExtraCredit;
    decimal addition = (decimal) extraCreditScores / 10 / examAssignments;

    // branch to decide letter grade
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    // back again to realize common operation for different student
    Console.WriteLine(
        $"{currentStudent}\t\t{examScoresAverage}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t" +
        $"{extraCreditScoresAverage} ({addition} pts)"
    );
}

// final output organization to communicate with user as well
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();