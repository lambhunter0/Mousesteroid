using System.Collections;
using UnityEngine;

namespace PersonalProjects.Mouseteroid.Prototype
{
    public class Projectile : MonoBehaviour
    {
        private float lifeTime;
        private Vector3 direction;
        private float velocity;
        private bool isAlive;

        public void Init(Vector3 direction, float velocity = 10.0f, float lifeTime = 1.0f)
        {
            this.lifeTime = lifeTime;
            this.velocity = velocity;
            this.direction = direction;
        }

        private void Update()
        {
            if (isAlive)
            {
                transform.position += direction * Time.deltaTime * velocity;
            }
        }

        public void Shoot()
        {
            StartCoroutine(DeathTimer(lifeTime));
            isAlive = true;
        }

        private IEnumerator DeathTimer(float timer)
        {
            yield return new WaitForSeconds(timer);
            Destroy(gameObject);
        }
    }
}
