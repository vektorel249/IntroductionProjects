using BenchmarkDotNet.Attributes;
using System.Text;

namespace Vektorel.StringBenchmarks
{
    [SimpleJob]
    [MemoryDiagnoser(true)]
    public class StringComparisons
    {
        [Benchmark]
        public void ConcatWithPlus()
        {
            var name = "Mustafa";
            var name2 = "Kemal";
            var surname = "Atatürk";
            var suffix = "19 Mayıs 1919'da Samsun'a gitti";

            var sentence = name + " " + name2 + " " + surname + " " + suffix;
        }

        [Benchmark]
        public void ConcatWithConcat()
        {
            var name = "Mustafa";
            var name2 = "Kemal";
            var surname = "Atatürk";
            var suffix = "19 Mayıs 1919'da Samsun'a gitti";

            var sentence = string.Concat(name, " ", name2, " ", surname, " ", suffix);
        }

        [Benchmark]
        public void ConcatWithFormat()
        {
            var name = "Mustafa";
            var name2 = "Kemal";
            var surname = "Atatürk";
            var suffix = "19 Mayıs 1919'da Samsun'a gitti";

            var sentence = string.Format("{0} {1} {2} {3}", name, name2, surname, suffix);
        }

        [Benchmark]
        public void ConcatWithInterpolation()
        {
            var name = "Mustafa";
            var name2 = "Kemal";
            var surname = "Atatürk";
            var suffix = "19 Mayıs 1919'da Samsun'a gitti";

            var sentence = $"{name} {name2} {surname} {suffix}";
        }

        [Benchmark]
        public void ConcatWithBuilder()
        {
            var name = "Mustafa";
            var name2 = "Kemal";
            var surname = "Atatürk";
            var suffix = "19 Mayıs 1919'da Samsun'a gitti";

            var builder = new StringBuilder();
            builder.Append(name);
            builder.Append(" ");
            builder.Append(name2);
            builder.Append(" ");
            builder.Append(surname);
            builder.Append(" ");
            builder.Append(suffix);

            var sentence = builder.ToString();
        }
    }

    [MemoryDiagnoser(true)]
    public class StringBuilderVSPlus
    {
        [Benchmark]
        public void ConcatWithPlus()
        {
            var text = string.Empty;
            for (int i = 0; i < 1000; i++)
            {
                text += "Vektörel Bilişim" + i;
            }
        }

        [Benchmark]
        public void ConcatWithBuilder()
        {
            var builder = new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                builder.Append("Vektörel Bilişim");
                builder.Append(i);
            }
        }
    }
}
