using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayerLogicTests
    {
        public void Given_ArbitraryPlayerLogicComponent_SpeedIsZero()
        {
            // Given
            var player = new GameObject();

            // When
            var playerComponent = player.AddComponent<PlayerLogic>();

            // Then
            Assert.AreEqual(playerComponent.PlayerHealth, 0.0f);
        }
    }
}
