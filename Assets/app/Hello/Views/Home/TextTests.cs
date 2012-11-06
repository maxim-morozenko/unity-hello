using System;
using UnityEngine;
using n.Gfx;
using n;
using Hello;
using Hello.ViewModel;
using Hello.Controllers;

public class TextTests : MonoBehaviour
{
  private GUIText _t;
  private GameObject _tt;

  void Start ()
  {

    var controller = HelloApp.App.Get<HomeController>();
    var model = controller.SceneInfo().Model.As<SceneInfoViewModel>();
    model.BackButton.Manifest();

    var light_font = (Font) Resources.Load ("Fonts/Roboto-Regular");
    var bold_font = (Font) Resources.Load ("Fonts/Roboto-BoldCondensed");

    var instance = new nText(new Vector2(1.0f, 1.0f));
    instance.Font = bold_font;
    instance.FontSize = 0.2f;
    instance.Color = Color.white;
    instance.Text = "Hello nText, yeah!\nhithere\ndfsdfasfdasfasdf\ndasfasdfasdf";

    var prop = new nProp(instance);
    prop.Visible = true;
    prop.Scale = new Vector2(1.0f, 1.0f);
    prop.Position = new Vector2(-6.0f, 2.0f);
    prop.Depth = 0;
    prop.Listen(_cam, delegate {
      nLog.Debug ("Text click");
    });

    instance = new nText(new Vector2(1.0f, 1.0f));
    instance.Font = light_font;
    instance.FontSize = 1.0f;
    instance.Color = Color.blue;
    instance.Text = "this is a blue test";
    
    prop = new nProp(instance);
    prop.Visible = true;
    prop.Scale = new Vector2(1.0f, 1.0f);
    prop.Position = new Vector2(-6.0f, 1.0f);
    prop.Depth = 0;
    prop.Listen(_cam, delegate {
      nLog.Debug ("Text click");
    });

    instance = new nText(new Vector2(1.0f, 1.0f));
    instance.Font = bold_font;
    instance.FontSize = 2.0f;
    instance.Color = Color.magenta;
    instance.Text = "This is a pink test which is all scaled";
    
    prop = new nProp(instance);
    prop.Visible = true;
    prop.Scale = new Vector2(0.5f, 1.0f);
    prop.Position = new Vector2(-6.0f, -1.0f);
    prop.Depth = 1;
    prop.Listen(_cam, delegate {
      nLog.Debug ("Text click");
    });

    instance = new nText(new Vector2(1.0f, 1.0f));
    instance.Font = bold_font;
    instance.FontSize = 0.5f;
    instance.Color = Color.green;
    instance.Text = "This is another random test we've rotated!";
    
    prop = new nProp(instance);
    prop.Visible = true;
    prop.Scale = new Vector2(0.8f, 1.0f);
    prop.Position = new Vector2(3.0f, 3.0f);
    prop.Rotation = -90.0f;
    prop.Depth = 0;
    prop.Listen(_cam, delegate {
      nLog.Debug ("Text click");
    });
  }

  void Update () {
  }
}

