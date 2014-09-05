using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phoenix_Project.Controllers;
using System.Web.Mvc;
using Phoenix_Project.Controllers.API;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Results;

namespace Phoenix_Project.Tests
{
    [TestClass]
    public class UnitTest1
    {
        
       
        [TestMethod]
        public void HomeControllerTest()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void GetOrdersTest(){
            OrderApiController controller = new OrderApiController();

             var result = controller.GetOrders();

            
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void HomeControllerContactTest()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Contact() as ViewResult;

            Assert.IsNotNull(result);

        }

         [TestMethod]
        public void HomeControllerAboutTest()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.About() as ViewResult;

            Assert.IsNotNull(result);

        }

         [TestMethod]
         public void HomeControllerGalleryTest()
         {
             HomeController controller = new HomeController();

             ViewResult result = controller.Gallery() as ViewResult;

             Assert.IsNotNull(result);

         }

         [TestMethod]
         public void HomeControllerOrderTest()
         {
             HomeController controller = new HomeController();

             ViewResult result = controller.Order() as ViewResult;

             Assert.IsNotNull(result);

         }
         [TestMethod]
         public void HomeControllerCateringTest()
         {
             HomeController controller = new HomeController();

             ViewResult result = controller.Catering() as ViewResult;

             Assert.IsNotNull(result);

         }
         [TestMethod]
        public void LoginControllerTest()
        {
            LoginController controller = new LoginController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);

        }
         
         [TestMethod]
         public void OrderControllerTest()
         {
             OrderController controller = new OrderController();

             ViewResult result = controller.Index() as ViewResult;

             Assert.IsNotNull(result);

         }

         [TestMethod]
         public void RegisterControllerTest()
         {
             RegisterController controller = new RegisterController();

             ViewResult result = controller.Index() as ViewResult;

             Assert.IsNotNull(result);

         }

         [TestMethod]
         public void UserApiControllerGetUsersTest()
         {
             UserController controller = new UserController();

             var result = controller.GetUsers();

             Assert.IsNotNull(result);

         }

       
        
    

    }
}
