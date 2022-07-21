using Bank;
using System;
using NUnit.Framework;

namespace BankNunitTests
{
    public class BankAccountTests
    {

        [Test]
        public void Adding_Funds_Should_Update_Balance()
        {
            //ARRANGE
            var account = new BankAccount(1000);

            //ACT
            account.Add(500);

            //ASSERT
            Assert.AreEqual(1500, account.Balance);
        }

        [Test]
        public void Withdrawing_Funds_Should_Update_Balance()
        {
            //ARRANGE
            var account = new BankAccount(1000);

            //ACT
            account.Withdraw(500);

            //ASSERT
            Assert.AreEqual(500, account.Balance);
        }

        /*
        [Test]
        public void Transferring_Funds_Should_Update_Both_Balances()
        {
            //ARRANGE
            var account = new BankAccount(1000);
            var otherAccount = new BankAccount(1000);


            //ACT
            account.TransferFundsTo(otherAccount, 500);

            //ASSERT
            Assert.AreEqual(500, account.Balance);
            Assert.AreEqual(1500, otherAccount.Balance);
        }

        [Test]
        public void Adding_Negative_Funds_Should_Throw()
        {
            //ARRANGE
            var account = new BankAccount(1000);

            //ACT + ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Add(-500));
        }
        */
    }
}