using System;
using UnityEngine;
using n.Gfx;
using n;

public class TextTests : MonoBehaviour
{
  private nCamera _cam;
  private GUIText _t;
  private GameObject _tt;

  void Start ()
  {

    /* create 10 unit high camera */
    _cam = new nCamera (10.0);
    _cam.Background = Color.black;
    _cam.Active = true;

    var tex = (Texture) Resources.Load("test.quad.1");
    //var font = (Font) Resources.Load ("Fonts/Roboto-Regular");
    var font = (Font) Resources.Load ("Fonts/Roboto-BoldCondensed");

    var back = new nProp(tex, new Vector2(1.0f, 1.0f));
    back.Visible = true;
    back.Position = new Vector2(0, 0);
    back.Depth = 1;
    back.Listen(_cam, delegate {
      nLog.Debug ("Back click");
   });

    var instance = new nText(new Vector2(1.0f, 1.0f));
    instance.Font = font;
    instance.FontSize = 0.25f;
    instance.Color = Color.blue;
    instance.Text = "Hello nText, yeah!\nhithere\ndfsdfasfdasfasdf\ndasfasdfasdf";

    var prop = new nProp(instance);
    prop.Visible = true;
    prop.Scale = new Vector2(1.0f, 1.0f);
    prop.Position = new Vector2(-0.5f, 0.5f);
    prop.Depth = 0;
    prop.Listen(_cam, delegate {
      nLog.Debug ("Text click");
    });

    /* Create object and add to scene */
    /*_tt = (GameObject)new GameObject (
      "HelloWorld",
      typeof(TextMesh),
      typeof(MeshRenderer)
    );

    var tm = _tt.GetComponent<TextMesh>();
    var mr = _tt.GetComponent<MeshRenderer>();
    Debug.Log ("MR: " + mr);
    Debug.Log ("TM: " + tm);
    Debug.Log ("F: " + font);
    Debug.Log ("FM: " + font.material);

    tm.font = font;
    mr.material = font.material;

    tm.fontSize = 50;
    tm.text = "Hello 3D Mesh";
    //mr.transform.position = new Vector3(0.0f, 1.0f, 1.0f);
    //mr.transform.localScale = new Vector3(0.1f, 0.1f, 1.0f);
    //mr.transform.Rotate(new Vector3(0f, 0f, 1.0f), 45.0f);
    _tt.transform.position = new Vector3(0.0f, 1.0f, 1.0f);
    _tt.transform.localScale = new Vector3(0.1f, 0.1f, 1.0f);
    _tt.transform.Rotate(new Vector3(0f, 0f, 1.0f), 45.0f);*/
  }

  void Update () {
  }
}

