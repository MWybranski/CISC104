using System.Collections;
using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TrophyCollisionTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void trophyCountTest()
    {
        // Assert
        Assert.AreNotEqual(2, trophyCollisionCount());
    }

    private object trophyCollisionCount()
    {
        throw new NotImplementedException();
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TrophyCollisionTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
