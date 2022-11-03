using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestScript
{
    [UnityTest]
    public IEnumerator TestScriptWithEnumeratorPasses()
    {
        yield return null;

        Assert.IsTrue(true);
    }
}
