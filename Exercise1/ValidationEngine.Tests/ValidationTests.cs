﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationEngine.Exceptions;

namespace ValidationEngine.Tests
{
    [TestFixture]
    public class ValidationTests
    {
        [Test]
        public void TrueForValidAddress()
        {
            var sut = new Validator();

            var result = sut.ValidateEmailAdress("nisse@email.com");

            Assert.IsTrue(result);
        }
        [Test]
        public void FalseForInvalidAddress()
        {
            var sut = new Validator();

            Assert.Throws<InvalidEmailException>(() =>
            {
                var result = sut.ValidateEmailAdress("Det här är ingen email.");
                var result2 = sut.ValidateEmailAdress("felemail.com");

            });
        }
        [Test]
        public void FalseForInvalidEmailClassCheck()
        {
            var sut = new Validator();

            Assert.Throws<InvalidEmailException>(() =>
            {
                var result = sut.ValidateWithMailClass("Det här är ingen email.");
                var result2 = sut.ValidateWithMailClass("felemail.com");

            });
        }
    }
}