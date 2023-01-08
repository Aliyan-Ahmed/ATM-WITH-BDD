using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ATM.Steps
{
    [Binding]
    public class AmountWithdrawalSteps
    {
        ATM atm = new ATM();
        Param parame = new Param();

        [Given(@"Amount in Account")]
        public void GivenAmountInAccount()
        {
            parame.amount = 50000;
        }
        
        [Given(@"Enter the choice")]
        public void GivenEnterTheChoice()
        {
            parame.choice = 2;
        }
        
        [Given(@"Withdraw the amount")]
        public void GivenWithdrawTheAmount()
        {
            parame.withdraw = 10000;
        }
        
        [When(@"Validate the Pin")]
        public void WhenValidateThePin()
        {
            parame.pin = 123;
        }
        
        [Then(@"Your current amount")]
        public void ThenYourCurrentAmount()
        {
            Assert.AreEqual(atm.BankTransaction(parame), "Your current amount now is 40000");
        }
    }
}
