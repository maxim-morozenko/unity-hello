using UnityEngine;
using System.Collections;

using Hello;
using Hello.Controllers;

/** Bootstrap */
public class Main : MonoBehaviour {
	void Start () {
    HelloApp.App.Get<HomeController>().PropTests().Activate();
	}
  void Update () {}
}
