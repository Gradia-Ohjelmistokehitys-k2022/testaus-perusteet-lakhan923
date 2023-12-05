using Bank;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            //Arrange
            double initialBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;

            BankAccount account = new BankAccount(initialBalance);

            //Act
            account.Debit(debitAmount);

            //Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly.");
        }

        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            //Arrange
            double initialBalance = 11.99;
            double debitAmount = 100.00;
            BankAccount account = new BankAccount(initialBalance);

            //Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }

        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            double initialBalance = 11.99;
            double debitAmount = 20.0;
            BankAccount account = new BankAccount(initialBalance);

            // Act
            try
            {
                account.Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void Debit_WithNegativeAmount_ShouldThrowException()
        {
            //Arrange
            double initialBalance = 11.99;
            BankAccount account = new BankAccount(initialBalance);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Credit(-100), "Credit with a negative amount should throw an ArgumentOutOfRangeException.");
        }

        [TestMethod]
        public void Credit_WithPositiveAmount_ShouldIncreaseBalance()
        {
            //Arrange
            double initialBalance = 11.99;
            BankAccount account = new BankAccount(initialBalance);

            // Act
            account.Credit(110);

            // Assert
            double expectedBalance = initialBalance + 110;
            double actualBalance = account.Balance;
            Assert.AreEqual(expectedBalance, actualBalance, "The balance should be increased by the credited amount.");
        }

        [TestMethod]
        public void Credit_WithNegativeAmount_ShouldThrowException()
        {
            // Arrange
            double initialBalance = 11.99;
            BankAccount account = new BankAccount(initialBalance);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Credit(-50), "Credit with a negative amount should throw an ArgumentOutOfRangeException.");
        }

        [TestMethod]
        public void AddAccount_ShouldIncreaseAccountCount()
        {
            // Arrange
            BankCustomer customer = new BankCustomer("Laiba khan");

            // Act
            customer.AddAccount(500);

            // Assert
            Assert.AreEqual(1, customer.Accounts.Count, "The account count should be increased after adding an account.");
        }

        [TestMethod]
        public void RemoveAccount_ShouldDecreaseAccountCount()
        {
            // Arrange
            BankCustomer customer = new BankCustomer("Laiba khan");
            BankAccount account = new BankAccount(600);

            // Act
            customer.RemoveAccount(account);

            // Assert
            Assert.AreEqual(0, customer.Accounts.Count, "The account count should be decreased after deleting an account.");
        }

        [TestMethod]
        public void GetTotalBalance_ShouldReturnSumOfAccountBalances()
        {
            // Arrange
            BankCustomer customer = new BankCustomer("Laiba khan");
            customer.AddAccount(1000);
            customer.AddAccount(2000);

            // Act
            double totalBalance = customer.GetTotalBalance();

            // Assert
            Assert.AreEqual(3000, totalBalance, "The total balance should be the sum of individual account balances.");
        }
    }
}


