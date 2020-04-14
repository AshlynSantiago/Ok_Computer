﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OBM;
using OBM.Controllers;
using System.Diagnostics;
namespace OBMTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void ErrorPageControllerTest()
        {
            EventsController controller = new EventsController();
            try
            {
                ViewResult result = controller.Tournament(null) as ViewResult;
                Assert.AreEqual(new HttpException(404, "Page not Found").Message, result);
            }
            catch (Exception e)
            {
                Assert.AreEqual(new HttpException(404, "Page not Found").Message, e.Message);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            //te
            EventsController myController = new EventsController();

            var result = myController.Search("asdf");
            Debug.WriteLine(result);

            Assert.IsNotNull(result);
        }
    }
}
