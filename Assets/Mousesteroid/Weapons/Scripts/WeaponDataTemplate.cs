using UnityEngine;

namespace PersonalProjects.Mouseteroid.Weapons
{
    [CreateAssetMenu(fileName = "New WeaponDataTemplate", menuName = "Data/WeaponTemplate")]
    public class WeaponDataTemplate : ScriptableObject
    {
        [SerializeField] private WeaponData weaponData;

        public WeaponData WeaponData { get { return weaponData; } }
    }
}
