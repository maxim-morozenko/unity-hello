using System;
using n;
using Hello.Views;

namespace Hello.Controllers
{
  public class HomeController : nController
  {
    public nView Menu() {
      return View(Id.Home.Menu);
    }

    public nView PropTests () {
      return View(Id.Home.PropTests);
    }
  }
}

