
using PersonalProjects.GameFramework.Coroutines;
using System.Collections;
using UnityEngine;

namespace PersonalProjects.Mouseteroid.Weapons
{
    public class BaseWeapon : IWeapon
    {
        private WeaponData weaponData;
        private int currentAmmo;
        private bool isReloading = false;
        private float lastFire = 0;
        private Transform actorLocation;

        public BaseWeapon(WeaponData weaponData, GameObject actor)
        {
            this.weaponData = weaponData;
            this.currentAmmo = weaponData.MaxAmmo;
            actorLocation = actor.transform;
        }

        public bool Shoot()
        {
            if (lastFire + weaponData.MinimumFireInterval > Time.time)
            {
                Debug.Log("*CLICK* FUCK");
                return false;
            }
            if (isReloading)
            {
                Debug.Log("RELOADING BOI");
                return false;
            }
            if (currentAmmo > 0)
            {
                currentAmmo--;
                lastFire = Time.time;
                SpawnProjectile();
                Debug.Log("bang "+ currentAmmo + "/"+weaponData.MaxAmmo);
                return true;
            }
            if (currentAmmo <= 0 && weaponData.DoesAutoReload)
            {
                Debug.Log("RELOADINGGG");
                Reload();
                return false;
            }
            else
            {
                Debug.Log("nothing");
                return false;
            }
        }

        public void Reload()
        {
            isReloading = true;
            CoroutineHelper.RunCoroutine(ReloadTimer);
        }

        private IEnumerator ReloadTimer()
        {
            float timer = 0;
            while (timer <= weaponData.ReloadTime)
            {
                timer += Time.deltaTime;
                yield return null;
            }
            Debug.Log("reload complete");
            currentAmmo = weaponData.MaxAmmo;
            isReloading = false;
        }

        private void SpawnProjectile()
        {
            GameObject spawnedProjectile = GameObject.Instantiate(weaponData.ProjectilePrefab, actorLocation.position,actorLocation.rotation);
            spawnedProjectile.name = "Projectile";
            Rigidbody2D rb = spawnedProjectile.GetComponent<Rigidbody2D>();
            rb.velocity = rb.transform.up.normalized * weaponData.ProjectileSpeed;
            GameObject.Destroy(spawnedProjectile, 5.0f);
        }
    }
}
