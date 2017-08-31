using System;
using System.IO;
using Xunit;

namespace BDSA2017.Assignment01.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_given_leap_and_year_prints()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new String[] { "leap", "1600" });
            var output = writer.GetStringBuilder().ToString();

            Assert.Equal("True" + Environment.NewLine, output);
        }

        [Fact]
        public void Main_given_power_and_two_numbers_returns()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new String[] { "100", "powerof", "10" });
            var output = writer.GetStringBuilder().ToString();

            Assert.Equal("True" + Environment.NewLine, output);
        }

        [Fact]
        public void Main_given_arguments_of_wrong_length()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(null);
            var output = writer.GetStringBuilder().ToString();

            Assert.Equal("Please give valid arguments" + Environment.NewLine, output);
        }

        [Fact]
        public void Main_given_leap_but_not_number()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new String[] {"leap", "hej" });
            var output = writer.GetStringBuilder().ToString();

            Assert.Equal("Please write a valid year number" + Environment.NewLine, output);
        }

        [Fact]
        public void Main_given_not_leap_and_length_2()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new String[] { "leaps","100"});
            var output = writer.GetStringBuilder().ToString();

            Assert.Equal("Please start your call with leap, followed by a year" + Environment.NewLine, output);
        }

        [Fact]
        public void Main_given_powerof_but_not_numbers()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new String[] { "le", "powerof", "100" });
            var output = writer.GetStringBuilder().ToString();

            Assert.Equal("Please give numbers as the first and third argument" + Environment.NewLine, output);
        }

        [Fact]
        public void Main_given_numbers_but_not_powerof()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new String[] { "100","powerofs", "100" });
            var output = writer.GetStringBuilder().ToString();

            Assert.Equal("Please write powerof as the second argument" + Environment.NewLine, output);
        }
    }
}
