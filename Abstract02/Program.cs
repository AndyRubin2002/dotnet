using System;

internal class Program
{
    private static void Main(string[] args)
    {
        FactoryReport fr = new FactoryReport();
        Report report = fr.GenerateFactory();
        report.GenerateReport();

    }
    public abstract class Report{
            protected abstract void parse();
            protected abstract void Validate();
            protected abstract void save();

        public virtual void GenerateReport()
        {
            parse();
            Validate();
            save();
        }

                    
    }

    public abstract class SpecialReport : Report
    {
        protected abstract void Re_Validate();

        public override void GenerateReport()
        {
            parse();
            Validate();
            Re_Validate();
            save();
        }

    }
    public class Pdf : Report
    {
        protected override void parse()
        {
            Console.WriteLine("Pdf parse");
        }

        protected override void save()
        {
            Console.WriteLine("Pdf Save");
        }

        protected override void Validate()
        {
            Console.WriteLine("Pdf Validate");
        }
    }
    public class Docx : Report
    {
        protected override void parse()
        {
            Console.WriteLine("Docx parse");
        }

        protected override void save()
        {
            Console.WriteLine("Docx Save");
        }

        protected override void Validate()
        {
            Console.WriteLine("Docx Validate");
        }
    }
    public class JSon : SpecialReport
    {
        protected override void parse()
        {
            Console.WriteLine("JSon parse");
        }

        protected override void Re_Validate()
        {
            Console.WriteLine("JSon Re-validate");
        }

        protected override void save()
        {
            Console.WriteLine("Json Save");
        }

        protected override void Validate()
        {
            Console.WriteLine("Json Validate");
        }

    }
    public class FactoryReport
    {
        public Report GenerateFactory()
        {
            Console.WriteLine("Enter the choice ");
            Console.WriteLine("1.Pdf 2.Docx .3.Json");
            
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                  return new Pdf();
                    break;
                case 2:
                    return new Docx();
                    break;
                case 3:
                    return new JSon();
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    return null;
                    break;

            }
        }
    }

}