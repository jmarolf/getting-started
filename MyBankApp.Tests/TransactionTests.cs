using System;

using Xunit;

namespace MyBankApp.Tests
{
    public class TransactionTests
    {
        [Fact]
        [Trait("Category", "Withdraw")]
        public void InvalidWithdrawTest1()
        {
            var invalidAccount = new BankAccount("invalid", 1);

            // Test that the withdrawal cannot be greater than the account balance
            Assert.Throws<InvalidOperationException>(
                    () => invalidAccount.MakeWithdrawal(1000, DateTime.Now, "Attempt to overdraw"));
        }

        [Fact]
        [Trait("Category", "Withdraw")]
        public void InvalidWithdrawTest2()
        {
            var invalidAccount = new BankAccount("invalid", 10);

            // Test that the withdrawal cannot be greater than the account balance
            // This test will fail because withdrawing $1 is not greater than the account balance.
            // Change 1 to 100 to cause the expected exception and the test to pass.
            Assert.Throws<InvalidOperationException>(
                    () => invalidAccount.MakeWithdrawal(1, DateTime.Now, "Attempt to overdraw"));
        }

        [Fact]
        [Trait("Category", "Deposit")]
        public void InvalidDepositTest1()
        {
            var invalidAccount = new BankAccount("invalid", 1);

            // Test that you can not deposit negative money
            Assert.Throws<ArgumentOutOfRangeException>(
                    () => invalidAccount.MakeDeposit(-1, DateTime.Now, "Attempt to deposit negative money"));
        }

        [Fact]
        [Trait("Category","Deposit")]
        public void InvalidDepositTest2()
        {
            var invalidAccount = new BankAccount("invalid", 1);

            // Test that you can not deposit negative money
            // This test fails because the given inputs did not cause the exception we were expecting.
            // Edit the line below to "-1" to cause the expected exception and make the test pass.
            Assert.Throws<ArgumentOutOfRangeException>(
                    () => invalidAccount.MakeDeposit(1, DateTime.Now, "Attempt to deposit negative money"));
        }
    }
}
