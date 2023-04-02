namespace Tests
{
    public class FuncDelegateUnitTest
    {
        [Fact]
        public void When_Square_Is_Called_With_Int_Then_It_Should_Return_Its_Square()
        {
            // arrange
            var input = 5;
            var expected = 25;

            // act
            var actual = FuncDelegate.Program.Square(input);

            // assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void When_Main_Is_Called_Then_It_Should_Print_Squares_Of_2_4_8()
        {
            using (StringWriter sw = new StringWriter())
            {
                // arrange
                Console.SetOut(sw);
                string expected = string.Format("4{0}16{0}64{0}", Environment.NewLine);

                //act
                FuncDelegate.Program.Main(new string[0]);
                string actual = sw.ToString();

                //assert
                Assert.Equal(expected, actual);
            }
        }
    }
}