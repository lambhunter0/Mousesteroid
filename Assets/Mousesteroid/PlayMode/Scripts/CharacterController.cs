using PersonalProjects.GameFramework.Inputmanagement;
using PersonalProjects.Mouseteroid.Weapons;
using UnityEngine;

namespace PersonalProjects.Mouseteroid.Player
{
    public class CharacterController : MonoBehaviour
    {
        [Header("Data Templates")]
        [SerializeField] private CharacterDataTemplate characterDataTemplate;
        [SerializeField] private WeaponDataTemplate weaponDataTemplate;
        [Header("Other")]
        private InputManager inputManager;
        private IWeapon weapon;
        [SerializeField] private Transform weaponBarrel;

        void Start()
        {
            inputManager = new InputManager(new SampleShootBindings(), new RadialMouseInputHandler());
            inputManager.AddActionToBinding("shoot", Shoot);
            weapon = new BaseWeapon(weaponDataTemplate.WeaponData, weaponBarrel.gameObject);
        }

        void FixedUpdate()
        {
            CheckForInput();
        }

        private void CheckForInput()
        {
            inputManager.CheckForInput();
            Vector3 mouseInput = inputManager.GetMouseVector();
            Debug.Log(mouseInput);
            Quaternion lookRotation = Quaternion.Euler(mouseInput);
            transform.rotation = lookRotation;

            Vector2 input = Vector2.zero;
            input.x = inputManager.GetAxis("Horizontal");
            input.y = inputManager.GetAxis("Vertical");
            transform.Translate(input * Time.deltaTime * characterDataTemplate.CharacterData.MovementSpeed, Space.World);
        }

        private void Shoot()
        {
            weapon.Shoot();
        }
    }
}

