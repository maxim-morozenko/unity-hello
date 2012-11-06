using System;
using UnityEngine;
using n.Gfx;
using Hello;
using Hello.Controllers;
using n.UI;
using Hello.ViewModel;

public class Menu : MonoBehaviour
{
  void Start () {
    var controller = HelloApp.App.Get<HomeController>();
    var model = controller.SceneInfo().Model.As<SceneInfoViewModel>();

    var b = model.Button("Launch: PropsTest", delegate {
      controller.PropTests().Activate();
    });
    b.Position = new Vector2(0.0f, 1.0f);
    b.Manifest();

    b = model.Button("Launch: TextTest", delegate {
      controller.TextTests().Activate();
    });
    b.Position = new Vector2(0.0f, 0.5f);
    b.Manifest();
  }
}

