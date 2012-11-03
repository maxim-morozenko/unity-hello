using System;
using n.App;
using n.Platform;
using n;

namespace Hello
{
  public class HelloApp : nApp
  {
    private static HelloApp _instance = null;

    private nContext _ctx = new nUnityContext();

    public static HelloApp App {
      get {
        if (_instance == null)
          _instance = new HelloApp();
        return _instance;
      }
    }

    /** Bind everything; unity bindings + state, etc. */
    protected override void setup (n.nResolver resolver)
    {
      nUnityBinding.Bind(resolver);
      resolver.Bind<nStateFactory, HelloStateFactory>();
    }

    /** Unity doesn't need contexts; shortcut helper */
    public T Get<T>() where T : nController {
      return Get<T>(_ctx);
    }
  }
}

