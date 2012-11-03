using System;
using n.App;
using Hello.Model;

namespace Hello
{
  public class HelloStateFactory : nStateFactory
  {
    private static Session _instance;

    public n.nModel State {
      get {
        if (_instance == null) 
          _instance = new Session();
        return _instance;
      }
    }
  }
}

