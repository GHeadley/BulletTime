using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.Input;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class GestureLogicTests
    {
        [UnityTest]
        public IEnumerator Given_ArbitraryGestureLogic_DestroiesOnGestureStarted()
        {
            // Given
            var arbitraryGameObject = new GameObject();
            var gestureLogicCompontnt = arbitraryGameObject.AddComponent<GestureLogic>();

            // When
            gestureLogicCompontnt.BroadcastMessage("OnGestureStarted", new GameObject());
            yield return new WaitForFixedUpdate();

            // Then
            Assert.IsTrue(arbitraryGameObject == null);
        }

        [UnityTest]
        public IEnumerator Given_ArbitraryGestureLogic_DestroiesOnGestureUpdated()
        {
            // Given
            var arbitraryGameObject = new GameObject();
            var gestureLogicCompontnt = arbitraryGameObject.AddComponent<GestureLogic>();

            // When
            gestureLogicCompontnt.BroadcastMessage("OnGestureUpdated", new GameObject());
            yield return new WaitForFixedUpdate();

            // Then
            Assert.IsTrue(arbitraryGameObject == null);
        }

        [UnityTest]
        public IEnumerator Given_ArbitraryGestureLogic_DestroiesOnGestureCompleted()
        {
            // Given
            var arbitraryGameObject = new GameObject();
            var gestureLogicCompontnt = arbitraryGameObject.AddComponent<GestureLogic>();

            // When
            gestureLogicCompontnt.BroadcastMessage("OnGestureCompleted", new GameObject());
            yield return new WaitForFixedUpdate();

            // Then
            Assert.IsTrue(arbitraryGameObject == null);
        }

        [UnityTest]
        public IEnumerator Given_ArbitraryGestureLogic_DestroiesOnGestureCanceled()
        {
            // Given
            var arbitraryGameObject = new GameObject();
            var gestureLogicCompontnt = arbitraryGameObject.AddComponent<GestureLogic>();

            // When
            gestureLogicCompontnt.BroadcastMessage("OnGestureCanceled", new GameObject());
            yield return new WaitForFixedUpdate();

            // Then
            Assert.IsTrue(arbitraryGameObject == null);
        }
    }
}
