using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UserGroupRole.Controllers
{
  [Authorize(Roles=("b8fb2729-2c7e-4876-9acf-9de51c127e20"))]
  public class ProductsController : Controller
  {
    SampleData data;

    public ProductsController(SampleData data)
    {
      this.data = data;
    }

    public ActionResult Index()
    {
      return View(data.Products);
    }
  }
}