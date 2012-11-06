using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using n.Test;
using n.Test.Writers;
using Tests.n.App;

namespace Balls {
  public class Hello : nTestRunner {
    protected override void Setup(nTestSuite tests) {
      tests.type = typeof(MyTests);
      tests.type = typeof(MyTests2);
      tests.type = typeof(nDbRecordTests);
    }
    
    public static void RunTests() {
      new Hello().Run(typeof(nSimpleTestWriter));
    }
  }
}
