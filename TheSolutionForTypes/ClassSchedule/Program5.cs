using System;

namespace classSchedule
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] sceduleAndProfesors = 
                // subject     ,  Professor ,
                { "English III", "Ms. Lapan",
            "Precalculus", "Mrs. Gideon",
            "Music Theory", "Mr. Davis",
            "Biotechnology", "Ms. Palmer",
            "Principles of Technology I", "Ms. Garcia",
            "Latin II", "Mrs. Barnett",
            "AP US History", "Ms. Johannessen",
            "Business Computer Infomation Systems", "Mr. James" };

            string thisWillBecomeATable = "";

            string verticalLine = "|";
            string hitEnter = "\n";
            int thisHoldsRowNumber = 1;
            int theLongestClassName = sceduleAndProfesors[14].Length;
            int theLongestProfName = sceduleAndProfesors[13].Length;

            //                                                      ↓ iterate by 2, cause writing 2 columns at a time
            for (int i = 0; i < sceduleAndProfesors.Length; i = i + 2)
            {
                //column width == .Length of 2 longest entries + 1 space for each
                //below calculate spaces
                int spacesTillFirstEntry = (theLongestClassName - sceduleAndProfesors[i].Length) + 1;
                int spacesAfterSecondEntry = (theLongestProfName - sceduleAndProfesors[i + 1].Length) + 1;

                string rowNumber = $"|{thisHoldsRowNumber}|";
                string firstSpace = new String(' ', spacesTillFirstEntry);
                string secondSpace = new String(' ', spacesAfterSecondEntry);

                thisHoldsRowNumber++;

                //add 1 line to table
                thisWillBecomeATable = thisWillBecomeATable
                    + rowNumber
                    + firstSpace
                    + sceduleAndProfesors[i] //class 
                    + verticalLine
                    + sceduleAndProfesors[i + 1]  //professor
                    + secondSpace
                    + verticalLine
                    + hitEnter;
            }
            Console.WriteLine(thisWillBecomeATable);
        }
    }
}
