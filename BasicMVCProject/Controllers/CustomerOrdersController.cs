using BasicMVCProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace BasicMVCProject.Controllers
{
    public class CustomerOrdersController : Controller
    {


        //Index metodunda:

        //Örnek bir Customer nesnesi ve birkaç Order nesnesi oluşturun.

        //Bu nesneleri kullanarak bir CustomerOrderViewModel nesnesi oluşturun.

        //CustomerOrderViewModel nesnesini view'a iletin.





        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 0,
                FirstName = "Sabahattin",
                LastName = "Ali",
                Email = "sabahattin@ali.com"
            };

            var order = new List<Order>
            {
                new Order() {Id=0,Price=10,ProductName="Book",Quantity=5 },
                new Order() {Id=1,Price=20,ProductName="Pencil",Quantity=8 },
                new Order() {Id=2,Price=30,ProductName="Paper",Quantity=100 }

            };


            var viewModel = new CustomerOrderViewModel //viewModel nesnesi oluşturuldu
            {
                Customer = customer,
                Orders = order
            };
            return View(viewModel);
        }
    }
}
