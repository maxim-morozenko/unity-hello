using UnityEngine;
using System.Collections;

using Hello;
using Hello.Controllers;

public class Main : MonoBehaviour {
	void Start () {
    HelloApp.App.Get<HomeController>().Menu().Activate();
	}
}
