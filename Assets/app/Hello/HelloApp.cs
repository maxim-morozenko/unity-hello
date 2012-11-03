using System;
using n.App;
using n.Platform;

namespace Hello
{
  public class HelloApp : nApp
  {
    protected override void setup (n.nResolver resolver)
    {
      nUnityBindings.Bind(resolver);
      resolver.Bind<nStateFactory, HelloStateFactory>();
    }
  }
}

