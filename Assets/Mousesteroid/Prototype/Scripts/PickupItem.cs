using System;
using UnityEngine;

namespace PersonalProjects.Mouseteroid.Prototype
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class PickupItem : MonoBehaviour
    {
        private Action<GameObject> onPickedUp;

        public void Init(Action<GameObject> onPickedUp)
        {
            this.onPickedUp = onPickedUp;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other != null)
            {
                Debug.Log("COLLISION ENTER");
                if (onPickedUp != null)
                {
                    onPickedUp.Invoke(other.gameObject);
                }
            }
        }
    }
}
