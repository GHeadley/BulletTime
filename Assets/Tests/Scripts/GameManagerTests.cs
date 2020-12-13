using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class GameManagerTests
    {
        [Test]
        public void Given_ArbitraryGameManager_minIntervalIsZero()
        {
            // Given
            var gameObject = new GameObject();

            // When
            var managerComponent = gameObject.AddComponent<GameManager>();

            // Then
            Assert.AreEqual(managerComponent.minInterval, 0.0f);
        }

        [Test]
        public void Given_ArbitraryGameManager_maxIntervalIsZero()
        {
            // Given
            var gameObject = new GameObject();

            // When
            var managerComponent = gameObject.AddComponent<GameManager>();

            // Then
            Assert.AreEqual(managerComponent.maxInterval, 0.0f);
        }

        [Test]
        public void Given_ArbitraryGameManager_spawnDistanceFromPlayerIsZero()
        {
            // Given
            var gameObject = new GameObject();

            // When
            var managerComponent = gameObject.AddComponent<GameManager>();

            // Then
            Assert.AreEqual(managerComponent.spawnDistanceFromPlayer, 0.0f);
        }

        [Test]
        public void Given_ArbitraryGameManager_GetRandomSpawnVectorIsValid()
        {
            // Given
            var gameObject = new GameObject();
            var managerComponent = gameObject.AddComponent<GameManager>();

            // When
            Vector3 result = managerComponent.GetRandomSpawnVector();

            // Then
            Assert.IsNotNull(result);
        }
    }
}
