using System;
using UnityEngine;

namespace PersonalProjects.Mouseteroid.Weapons
{
    [Serializable]
    public class WeaponData
    {
        [Header("General")]
        [SerializeField] private float minimumFireInterval;
        [SerializeField] private int maxAmmo;
        [Header("Reload")]
        [SerializeField] private float reloadTime;
        [SerializeField] private bool doesAutoReload;
        [Header("Projectile")]
        [SerializeField] private float baseDamage;
        [SerializeField] private float projectileSpeed;
        [SerializeField] GameObject projectilePrefab;
        
        public int MaxAmmo { get { return maxAmmo; } }
        public float MinimumFireInterval { get { return minimumFireInterval; } }
        public float ReloadTime { get { return reloadTime; } }
        public bool DoesAutoReload { get { return doesAutoReload; } }
        public float BaseDamage { get { return baseDamage; } }
        public float ProjectileSpeed { get { return projectileSpeed; } }
        public GameObject ProjectilePrefab { get { return projectilePrefab; } }
    }
}