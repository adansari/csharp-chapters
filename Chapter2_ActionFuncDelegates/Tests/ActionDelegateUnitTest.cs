namespace Tests
{
    public class ActionDelegateUnitTest
    {
        [Fact]
        public void When_PrintAWord_Is_Called_With_String_Then_It_Should_Print_That_String_In_Console()
        {
            using (StringWriter sw = new StringWriter())
            {
                // arrange
                Console.aut
                Console.SetOut(sw);
                string expected = string.Format("test{0}", Environment.NewLine);

                //act
                ActionDelegate.Program.PrintAWord("test");
                string actual = sw.ToString();

                //assert
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void When_Main_Is_Called_Then_It_Should_Print_Fruits_Name_In_Console()
        {
            using (StringWriter sw = new StringWriter())
            {
                // arrange
                Console.SetOut(sw);
                string expected = string.Format("apple{0}banana{0}apple{0}banana{0}apple{0}banana{0}", Environment.NewLine);

                //act
                ActionDelegate.Program.Main(new string[0]);
                string actual = sw.ToString();

                //assert
                Assert.Equal(expected, actual);
            }
        }
    }
}