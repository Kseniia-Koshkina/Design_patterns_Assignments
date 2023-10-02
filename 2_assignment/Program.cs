namespace _2_assignment
{        
    // TODO#1: Convert to use Singleton pattern
    public class Printer
    {
        private static Printer? instance = null;
        
        private Printer() 
        {}

        public static Printer getInstance() 
        {
            if (instance == null) 
            {
                instance = new Printer();   

            }
            return instance;
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
            // Output: print out the string message 
        }
    }

    // Class template for Exam classes
    public interface Exam
    {
        void Conduct();
        void Evaluate();
        void PublishResults();
    }
    // TODO#2: Convert to use Abstract Factory pattern
    // Create an Exam interface and an Abstract Factory to manage the creation of different exam types.


    public abstract class ExamFactory // abstract factory
    {
        public abstract Exam CreateExam();
    }

    public class MathExamFactory : ExamFactory // Math factory
    {
        public override Exam CreateExam()
        {
            return new MathExam();
        }
    }
    public class ScienceExamFactory : ExamFactory // Science exam factory
    {
        public override Exam CreateExam()
        {
            return new ScienceExam();
        }
    }
    public class ProgrammingExamFactory : ExamFactory // Programming exam factory
    {
        public override Exam CreateExam()
        {
            return new ProgrammingExam();
        }
    }

    public class MathExam : Exam
    {
        public void Conduct()
        {
            // Output: "Conducting Math Exam", should use Printer class to print the message

            Printer.getInstance().Print("Conducting Math Exam");
        }

        public void Evaluate()
        {
            // Output: "Evaluating Math Exam", should use Printer class to print the message
            Printer.getInstance().Print("Evaluating Math Exam");

        }

        public void PublishResults()
        {
            // Output: "Publishing Math Exam Results", should use Printer class to print the message
            Printer.getInstance().Print("Publishing Math Exam Results");
        }
    }

    // TODO#5: Add new ScienceExam class
    public class ScienceExam : Exam
    {
        public void Conduct()
        {
            // Output: "Conducting Math Exam", should use Printer class to print the message
            Printer.getInstance().Print("Conducting Science Exam");
        }

        public void Evaluate()
        {
            // Output: "Evaluating Science Exam", should use Printer class to print the message
            Printer.getInstance().Print("Evaluating Science Exam");
        }

        public void PublishResults()
        {
            // Output: "Publishing Science Exam Results", should use Printer class to print the message
            Printer.getInstance().Print("Publishing Science Exam Results");
        }
    }

    // TODO#6: Add another ProgrammingExam class
    public class ProgrammingExam : Exam
    {
        public void Conduct()
        {
            // Output: "Conducting Programming Exam", should use Printer class to print the message
            Printer.getInstance().Print("Conducting Programming Exam");
        }

        public void Evaluate()
        {
            // Output: "Evaluating Programming Exam", should use Printer class to print the message
            Printer.getInstance().Print("Evaluating Programming Exam");
        }

        public void PublishResults()
        {
            // Output: "Publishing Programming Exam Results", should use Printer class to print the message
            Printer.getInstance().Print("Publishing Programming Exam Results");
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // TODO#7: Initialize Printer that uses Singleton pattern
            var my_printer = Printer.getInstance();

            // TODO#8: Test that the created Printer works, by calling the Print method
            my_printer.Print("Some test text.");
            // TODO#9: Ensure that only one Printer instance is used throughout the application.
            //         Try to create new Printer object and compare the two objects to check,
            //         that the new printer object is the same instance
            var my_printer2 = Printer.getInstance();
            if (Object.ReferenceEquals(my_printer, my_printer2)) 
            {
                Console.WriteLine("Yes, they are the same object");
            }
            // TODO#10: Use Abstract Factory to create different types of exams.

            var math_exam = new MathExamFactory().CreateExam();
            var science_exam = new ScienceExamFactory().CreateExam();
            var programming_exam = new ProgrammingExamFactory().CreateExam();
            math_exam.Conduct();
            science_exam.Evaluate();
            programming_exam.PublishResults();
        }
    }

  }

