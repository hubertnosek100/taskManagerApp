using System;
using Microsoft.AspNetCore.Mvc;
using TaskManagerApp.Controllers;
using Xunit;

namespace TaskManagerTest
{
    public class SingletonTest
    {
        [Fact]
        public void SingletonShouldHaveOneInstace()
        {
            Singleton instace = Singleton.Instance;
            Singleton instace2 = Singleton.Instance;
            Assert.Equal(instace, instace2);
        }
        
        [Fact]
        public void foo()
        {
            HomeController homeController = new HomeController();
            var result = homeController.VeryImportantMesasge();
           Assert.True(result.Contains("8"));
        }    
    }
}
