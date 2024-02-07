/*
Start with five students. Each student has five exam scores.

Each exam score is an integer value, 0-100, where 100 represents 100% correct.

A student's overall exam score is the average of their five exam scores.

Criteria for extra credit assignments:

Include extra credit assignment scores in the student's scores array.
Extra credit assignments are worth 10% of an exam score (when calculating the final numeric grade).
Add extra credit assignment scores to the student's total exam score before calculating the final numeric grade.
Your application needs to automatically assign letter grades based on the calculated final score for each student.

Your application needs to output/display each student’s name and formatted grade.

Your application needs to support adding other students and scores with minimal impact to the code.
*/

/*
Use arrays to store student names and assignment scores.

Use a foreach statement to iterate through the student names as an outer program loop.

Use an if statement within the outer loop to identify the current student name and access that student's assignment scores.

Use a foreach statement within the outer loop to iterate through the assignment scores array and sum the values.

Use an updated algorithm within the outer loop to calculate the average exam score for each student.

Use an if-elseif-else construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.

Integrate extra credit scores when calculating the student's final score and letter grade as follows:

Your code must detect extra credit assignments based on the number of elements in the student's scores array.
Your code must apply the 10% weighting factor to extra credit assignments before adding extra credit scores to the sum of exam scores.
*/

/* 
97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F
*/

int totalGrades = 5;
string[] students = ["Anna", "Bob", "Claudiu", "Denir", "Emma"];

int[] annaGrades = [89, 98, 88, 90, 87];
int[] bobGrades = [99, 88, 90, 98, 89];
int[] claudiuGrades = [90, 99, 80, 98, 88];
int[] denirGrades = [98, 97, 90, 99, 89];
int[] emmaGrades = [96, 88, 99, 90, 89];

int[] allGrades = [5];
Console.WriteLine("Name\t\tGrade");

foreach(string student in students)
{
    string studentName = student;
    
    if (student == "Anna")
    {
        allGrades = annaGrades;
    }
    else if (student == "Bob")
    {
        allGrades = bobGrades;
    }
    else if (student == "Claudiu")
    {
        allGrades = claudiuGrades;
    }
    else if (student == "Denir")
    {
        allGrades = denirGrades;
    }
    int sumGrades = 0;

    foreach (int score in allGrades)
    {
        sumGrades += score;
    }
    decimal average = (decimal) sumGrades / totalGrades;

    string grade = "";
    if (average >= 97)
    {
        grade = "A+";
    }
    else if (average >= 93)
    {
        grade = "A";
    }
    else if (average >= 90)
    {
        grade = "A-";
    }
    Console.WriteLine($"{studentName}\t\t{average}\t\t{grade}");
}


