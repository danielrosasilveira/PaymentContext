﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Tests.Commands
{
    class CreateBoletoSubscriptionCommandTests
    {
        [TestMethod]
        public void ShoulReturnErrorWhenNameIsInvalid()
        {
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "";
            command.Validate();
            Assert.AreEqual(false, command.Valid);
        }
    }
}