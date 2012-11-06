using System;
using n;
using Hello.Views;
using n.Gfx;
using UnityEngine;
using n.UI;
using Hello.ViewModel;

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

    public nView TextTests () {
      return View(Id.Home.TextTests);
    }

    public nView SceneInfo() {
      var model = new SceneInfoViewModel();
      model.Camera = new nCamera(10.0f);
      model.Camera.Active = true;
      model.Camera.Background = Color.gray;

      model.BackButton = model.Button("Back", delegate {
        HelloApp.App.Get<HomeController>().Menu().Activate();
      });
      model.BackButton.Position = new Vector2(-5.0f, -4.0f);

      return View(model);
    }
  }
}

