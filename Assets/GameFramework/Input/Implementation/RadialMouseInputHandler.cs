using PersonalProjects.GameFramework.Inputmanagement.Interfaces;
using UnityEngine;

namespace PersonalProjects.GameFramework.Inputmanagement
{
    public class RadialMouseInputHandler : IMouseInputHandler
    {
        public Vector3 GetInput()
        {
            Vector3 mousePos = Input.mousePosition;
            Vector3 relativeMousePos = new Vector2(mousePos.x - (Screen.width / 2), mousePos.y - (Screen.height / 2));
            float angle = Mathf.Atan2(relativeMousePos.y, relativeMousePos.x) * Mathf.Rad2Deg - 90;
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            return rotation.eulerAngles;
        }

        public Vector2 GetRawPosition()
        {
            return Input.mousePosition;
        }
    }
}

