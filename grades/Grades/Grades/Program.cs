using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
       
        static void Main(string[] args)
        {

            float floatNum = 34f;
            int intNum = 345;

            WriteAsBytes(intNum);
            WriteAsBytes(floatNum);

            WriteNames("Ben", "John", "Thom");
            

            SynthesizeSpeech();

            Immutable();

            PassByValueAndRef();

            ClassesAndTypes();

            Arrays();

            WriteAsBytes(2213);

            exampleDelegate();

        }

        static void GiveBookAName(GradeBook book)
        {
            book.Name = "The Grade Book";
        }

        static void IncrementANumber(int number)
        {
            number += 1;

        }

        private static void SynthesizeSpeech()
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            Console.WriteLine("Speaking now");
            synth.Speak("Referencing an assembly for speech synthesis");
            Console.WriteLine("Completed introductory speech");
        }

        private static void WriteAsBytes(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            WriteByteArray(bytes);
        }

        //Overloaded method with float type
        private static void WriteAsBytes(float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            WriteByteArray(bytes);
        }

        private static void WriteByteArray(byte[] bytes)
        {
            WriteBreakingBar();
            foreach (byte b in bytes)
            {
                Console.WriteLine("0x{0:X} {2} {1} ", b, "One", "3ete");
            }
            WriteBreakingBar();
        }

        private static void WriteNames(params string[] names)
        {
            WriteBreakingBar();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            WriteBreakingBar();

        }
        private static void WriteBreakingBar()
        {
            Console.WriteLine("-----------");
        }

        private static void Arrays()
        {

            float[] grades;

            grades = new float[4];//have to pass in a size

            AddGrades(grades);

            foreach(float grade in grades)
            {
                Console.WriteLine("grade:" + grade);
            }


           


        }

        private static void AddGrades(float[] grades)
        {
            
            grades[0] = 91f;
            grades[1] = 89.1f;
            grades[2] = 75f;

        }

        private static void ClassesAndTypes()
        {
            GradeBook book = new GradeBook();
            //or default value     GradeBook book = new GradeBook(string name ="Default Book");
            book.AddGrade(92);
            book.AddGrade(34);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            WriteNames(book.Name);

            Console.WriteLine("Avg:" + stats.AverageGrade);
            Console.WriteLine("Lowest" + stats.LowestGrade);
            Console.WriteLine("Highest" + stats.HighestGrade);
        }

        private static void exampleDelegate()
        {
            Console.WriteLine("Starting Delegate example");
            GradeBook book = new GradeBook();
     
            book.AddGrade(92);
            book.AddGrade(34);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            //using delegate - this will later be triggered any time the name changes later.
          //  book.NameChanged = new NameChangedDelegate(OnNameChanged);

            //alternate method : multi cast delegate
            //multiple subscribers to execute when the event occurs
            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged2;

            //can unsubscribe from this event
           // book.NameChanged -= OnNameChanged2;

            book.Name = "changed name";

            WriteNames(book.Name);

            Console.WriteLine("Avg:" + stats.AverageGrade);
            Console.WriteLine("Lowest" + stats.LowestGrade);
            Console.WriteLine("Highest" + stats.HighestGrade);
        }

        private static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("name changing");
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("name changed from {0} to {1}",  args.OldValue, args.NewValue);
        }

        private static void Immutable()
        {

            string name = " BEN ";
            string trimmedName = name.Trim();
            Console.WriteLine(trimmedName);

            DateTime date = DateTime.Now; //or new DateTime(2014,1,1)
            date = date.AddDays(3);
            Console.WriteLine(date);

            string name1 = "Ben";
            string name2 = "ben";

            bool areEqual = name1.Equals(name2, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(areEqual);
        }

        private static void PassByValueAndRef()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(g1);
            Console.WriteLine(g2.Name);

            g1.Name = "Ben's Book";

            Console.WriteLine(g2.Name);

            int x1 = 4;

            IncrementANumber(x1);

            Console.WriteLine(x1);
        }
    }
}
