using KTPM;

namespace BankTest
{
    public class BankTest
    {

        [Theory]
        [InlineData(100)]
        [InlineData(101)]
        [InlineData(4999)]
        [InlineData(5000)]
        public void ValidMoney(int money)
        {
            Assert.Equal("So tien da duoc chuyen", Bank.transfer(money));
        }

        [Theory]
        [InlineData(99)]
        [InlineData(10001)]
        public void InvalidMoney(int money)
        {
            Assert.Equal("So tien khong hop le", Bank.transfer(money));
        }

        [Theory]
        [InlineData(5001)]
        [InlineData(9999)]
        [InlineData(10000)]
        public void AuthMoney(int money)
        {
            Assert.Equal("So tien can duoc phe duyet", Bank.transfer(money));
        }
    }
}