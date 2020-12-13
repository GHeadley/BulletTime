using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class GunLogicTests
    {
        [Test]
        public void Given_ArbitraryGunLogicComponent_AimWindupDurationIs0()
        {
            // Given
            var gameObject = new GameObject();

            // When
            var gunComponent = gameObject.AddComponent<GunLogic>();

            // Then
            Assert.AreEqual(gunComponent.AimWindupDuration, 0.0f);
        }

        [UnityTest]
        public IEnumerator Given_ArbitraryAimWindupDuration_WillDestroyAfterDuration()
        {
            // Given
            var gun = new GameObject();
            var arbitraryObject = new GameObject();
            var gunLogicComponenet = gun.AddComponent<GunLogic>();
            var ArbitraryAimWindupDuration = 0.5f;

            gunLogicComponenet.Player = arbitraryObject;
            gunLogicComponenet.BulletPrefab = arbitraryObject;
            gunLogicComponenet.BulletSpawn = arbitraryObject;
            gunLogicComponenet.AimWindupDuration = ArbitraryAimWindupDuration;

            // When
            yield return new WaitForSeconds(ArbitraryAimWindupDuration);

            // Then
            Assert.IsTrue(gun == null);
        }
    }
}
