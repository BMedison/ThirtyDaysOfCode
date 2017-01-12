using System;
using Xunit;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Test
    {
        [Fact]
        public void TestName()
        {
        //Given
        
        //When
        
        //Then
            Assert.Equal(2, 2 * 3);
        }
    }
}
