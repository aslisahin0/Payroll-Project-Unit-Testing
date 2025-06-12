using PayrollProject;
namespace TestMyPayrollClass
{
    public class PayrollTest : IDisposable
    {
        Payroll testCase;
        public PayrollTest() 
        {
            testCase = new Payroll();  
            testCase.Hours = 20;
            testCase.Hourly = 10;

        
        }    
        public void Dispose()
        {
          //close down test
          //close the database
        }

        [Fact]
        public void TestGrossPAyIsCorrect()
        {
            //Arrange
            Decimal expected = 200;

            //Act
            Decimal actual = testCase.GrossPay;
            
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestLocalTaxesIsCorrect()
        {
            //arrange
            Decimal taxRate = (Decimal) 0.035;
            Decimal expected = 200* (Decimal)0.035;//7

            //Act

            Decimal actual = testCase.LocalTaxes(taxRate);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}