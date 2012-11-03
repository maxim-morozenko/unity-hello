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
    _quads[0] = new nQuad();
    _quads[0].Texture = (Texture) Resources.Load("test.quad.1");

    /* create a couple of props from the quad */
    _props[0] = new nProp(_quads[0]);
    _props[0].Manifest = true;
  }

  void Update () {
  }
}

