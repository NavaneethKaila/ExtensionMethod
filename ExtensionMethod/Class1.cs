using System;

namespace ExtensionMethod
{
        public class Extension
        {
            public void Currency_Valid()
            {
                string currency = "123";
                Assert.Equal("$123", ExtensionMethodClass.ToCurrency(currency));
            }
            [InlineData("123abc")]
            [InlineData("abcd9010")]
            public void Currency_InValid(string currency)
            {
                string excep = "Entered String does not contain numbers";
                var exp = Assert.Throws<ArgumentException>(() => ExtMethodClass.ToCurrency(currency));
                Assert.Equal(excep, exp.Message);
            }
            public void Currency_EmptyString()
            {
                string currency = "";
                Assert.Equal("$", ExtMethodClass.ToCurrency(currency));
            }
    }
}