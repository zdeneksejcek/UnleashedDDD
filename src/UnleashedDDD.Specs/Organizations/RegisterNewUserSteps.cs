using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using UnleashedDDD.Organizations.Application;
using UnleashedDDD.Organizations.Application.Commands;
using UnleashedDDD.Tests.Stubs;

namespace UnleashedDDD.Specs.Organizations
{
    [Binding]
    public class RegisterNewUserSteps
    {
        private UserRepositoryStub _userRepository;
        private RegisterNewUserService _service;
        private NewUserCommand _command;


        [Given(@"I have RegisterNewUserservice initialized")]
        public void GivenIHaveRegisterUserServiceInitialized()
        {
            _userRepository = new UserRepositoryStub();

            _service = new RegisterNewUserService(
                _userRepository,
                new UserByEmailQueryRetrieverStub()
            );
        }

        [When(@"I use following data")]
        public void WhenIUseFollowingData(Table table)
        {
            var firstName = table.Rows[0]["value"];
            var lastName = table.Rows[1]["value"];
            var email = table.Rows[2]["value"];

            _command = new NewUserCommand(email, firstName, lastName);
        }

        [When(@"register")]
        public void WhenRegister()
        {
            _service.Register(_command);
        }

        [Then(@"I should have new account")]
        public void ThenIShouldHaveNewAccount()
        {
            var newUser = _userRepository.SavedUser;

            Assert.IsNotNull(newUser);
            Assert.AreNotEqual(Guid.Empty, newUser.Id.Id);
            Assert.AreEqual(_command.Email, newUser.Email.EmailAddress);
        }
    }
}
