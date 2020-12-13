using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


namespace Tests
{
    public class BulletLogicTests
    {
        public GameObject bulletPrefab;
    
        [UnityTest]
        public IEnumerator Given_ArbitraryBullet_WillMoveEveryFrame()
        {
            // Given
            var bullet = new GameObject();
            var bulletComponent = bullet.AddComponent<BulletLogic>();
            bulletComponent.Speed = 1000;
            bulletComponent.TTL = 10;
            var originalPosition = bullet.transform.position;

            // When
            yield return new WaitForFixedUpdate();

            // Then
            Assert.AreNotEqual(originalPosition, bullet.transform.position);
        }
    }
}
