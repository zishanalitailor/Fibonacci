using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Web.Models;
using System.Web.Mvc;
using Web.Controllers;
using System.Collections.Generic;

namespace Web.MSTest
{
    [TestClass]
    public class Fiboncci
    {
        [TestMethod]
        public void ItShouldAccceptParameterAndAddToViewModel()
        {
            var result = GetViewResultFromController();
            var viewModel = result.Model as FibonacciViewModel;

            Assert.AreEqual(viewModel.NumberRequested, 10);
        }

        private static ViewResult GetViewResultFromController()
        {
            var controller = new FibonacciController();
            var result = controller.Index() as ViewResult;
            return result;
        }

        [TestMethod]
        public void ItShouldReturnFibonacciViewModel()
        {
            var result = GetViewResultFromController();
            var viewModel = result.Model as FibonacciViewModel;
            List<int> number = viewModel.Results as List<int>;
            Assert.AreEqual(number[5], 5);
        }
    }
}
