using System;
using System.Collections;

namespace Student_Grades_Proj
{
    class Program
    {
        static void Main(string[] args)
       
        {
            var studentNameList = new ArrayList();
            var studentGradeList = new ArrayList();
            



            addToData(ref studentNameList, ref studentGradeList);
            



            ShowResults(studentNameList, studentGradeList);
            Console.Write("Enter 1 to change the results, or 2 to close the progrm: ");
            {
                update(ref studentNameList, ref studentGradeList);
            }


        }
        static string gradeRate(int grade)
        {

            if (grade >= 60)
            {
                return "Pass";

            }
            else 
            {
                return "Failed"; 
            }

        }
        static void addToData(ref ArrayList s_List, ref ArrayList g_List)
        {
            
            while(true)
            {

           
            
                Console.Write("Enter Student Name, or hit ENTER to view results: ");
                var studentName = Console.ReadLine();
                if (studentName == "") 
                {
                   
                    break; 
                }
                s_List.Add(studentName);
                Console.Write("Enter Student grade: ");
                g_List.Add(Int32.Parse(Console.ReadLine()));
            }
            
        }
        static void ShowResults(ArrayList s_List, ArrayList g_List)
        {        
            Console.WriteLine("\n#"+"\tName" + "\tGrade" + "\tResult");
            for (int i = 0; i < s_List.Count; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",i+1, s_List[i],g_List[i], gradeRate((int)g_List[i]));
                                                                                                             

            }
        }
        static void update(ref ArrayList s_List, ref ArrayList g_List)
        {
            Console.Write("\nEnter the # of the data entry you would like to update: ");
            var indexOfChange = int.Parse(Console.ReadLine());
            Console.Write("Enter 1 to change name or 2 to change the grade; ");
            var changedValue = Console.ReadLine();
            if (changedValue == "1")
            {
                Console.Write("Enter the new name: ");
                s_List[indexOfChange-1] = Console.ReadLine();
            }
            else
            {
                Console.Write("Enter the new grade: ");
                g_List[indexOfChange-1] = int.Parse(Console.ReadLine());


            }

            Console.WriteLine("\nPrinting new data table...\n");
            ShowResults(s_List, g_List);

          
        }

        Console.ReadKey();
        

}
    
    
}
