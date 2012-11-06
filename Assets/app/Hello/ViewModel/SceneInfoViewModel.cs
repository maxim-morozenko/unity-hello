using System;
using n;
using n.Gfx;
using n.UI;
using UnityEngine;

namespace Hello.ViewModel
{
  public class SceneInfoViewModel : nModel
  {
    public nCamera Camera;

    public nButton BackButton;

    public nButton Button(string text, nPropClick onClick) {
      var b = new nButton() {
        Camera = Camera,
        Color = Color.black,
        Font = "Fonts/Roboto-Regular",
        Texture = "menu.button.1",
        FontSize = 0.2f,
        Position = new Vector2(-5.0f, 3.0f),
        Size = new Vector2(2.8f, 0.4f),
        Text = text,
        Action = onClick
      };
      return b;
    }
  }
}

