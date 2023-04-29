using System.Text;

namespace MyProject.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // arrange 

            StringBuilder sb = new StringBuilder();



            // act

            sb.Append("test")
                .Append("test2");

            string result = sb.ToString();

            // assert


            Assert.Equal("testtest2", result);

             

        }
    }
}