using System;
using UnityEngine;
using n.Gfx;

public class PropTests : MonoBehaviour
{
  private nCamera _cam;
  private nQuad[] _quads = new nQuad[1];
  private nProp[] _props = new nProp[10];

  void Start () {

    /* create 10 unit high camera */
    _cam = new nCamera(10.0);
    _cam.Background = Color.blue;
    _cam.Active = true;

    /* load a quad */
    _quads[0] = new nQuad(new Vector2(1.0f, 1.0f));
    _quads[0].Texture = (Texture) Resources.Load("test.quad.1");

    /* create a couple of props from the quad */
    _props[0] = new nProp(_quads[0]);
    _props[0].Visible = true;
    _props[0].Position = new Vector2(0, 0);

    _props[1] = new nProp(_quads[0]);
    _props[1].Visible = true;
    _props[1].Position = new Vector2(2, 0);
    _props[1].Scale = new Vector2(0.5f, 0.5f);

    _props[2] = new nProp(_quads[0]);
    _props[2].Visible = true;
    _props[2].Position = new Vector2(0, 2);
    _props[2].Rotation = 45.0f;

    _props[3] = new nProp(_quads[0]);
    _props[3].Visible = true;
    _props[3].Position = new Vector2(2, 2);
    _props[3].Depth = 0;

    _props[4] = new nProp(_quads[0]);
    _props[4].Visible = true;
    _props[4].Position = new Vector2(2.5f, 2.5f);
    _props[4].Depth = 1;
  }

  void Update () {
  }
}

