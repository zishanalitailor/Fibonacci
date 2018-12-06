﻿using System.Web.Mvc;
using NUnit.Framework;
using Web.Controllers;
using Web.Models;

namespace Web.Tests
{
    [TestFixture]
    public class FibonacciControllerTests
    {
        [Test]
        public void ItShouldAccceptParameterAndAddToViewModel()
        {
            var result = GetViewResultFromController();
            var viewModel = result.Model as FibonacciViewModel;

            Assert.That(viewModel.NumberRequested, Is.EqualTo(10));
        }

        private static ViewResult GetViewResultFromController()
        {
            var controller = new FibonacciController();

            var result = controller.Index() as ViewResult;
            return result;
        }

        [Test]
        public void ItShouldReturnFibonacciViewModel()
        {
            var result = GetViewResultFromController();

            Assert.That(result.Model, Is.TypeOf<FibonacciViewModel>());
        }
    }
}