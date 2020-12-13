using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


namespace Tests
{
    public class BulletLogicTests
    {
        [Test]
        public void Given_ArbitraryBulletLogicComponent_SpeedIsZero()
        {
            // Given
            var bullet = new GameObject();
            
            // When
            var bulletComponent = bullet.AddComponent<BulletLogic>();

            // Then
            Assert.AreEqual(bulletComponent.Speed, 0.0f);
        }

        [Test]
        public void Given_ArbitraryBulletLogicComponent_TTLIsZero()
        {
            // Given
            var bullet = new GameObject();

            // When
            var bulletComponent = bullet.AddComponent<BulletLogic>();

            // Then
            Assert.AreEqual(bulletComponent.TTL, 0.0f);
        }

        [UnityTest]
        public IEnumerator Given_ArbitraryBullet_WillMoveEveryFrame()
        {
            // Given
            var bullet = new GameObject();
            var bulletComponent = bullet.AddComponent<BulletLogic>();
            bulletComponent.Speed = 100;
            bulletComponent.TTL = 10;
            var originalPosition = bullet.transform.position;

            // When
            yield return new WaitForSeconds(1);

            // Then
            Assert.AreNotEqual(originalPosition, bullet.transform.position);
        }

        [UnityTest]
        public IEnumerator Given_ArbitraryBullet_DestroiesOnImpact()
        {
            // Given
            var bullet = new GameObject();
            var bulletComponent = bullet.AddComponent<BulletLogic>();

            // When
            bulletComponent.BroadcastMessage("OnTriggerEnter", new Collider());
            yield return new WaitForFixedUpdate();

            // Then
            Assert.IsTrue(bullet == null);
        }
    }
}
