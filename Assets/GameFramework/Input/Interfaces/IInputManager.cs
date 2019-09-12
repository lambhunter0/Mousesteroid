using System;
using UnityEngine;

namespace PersonalProjects.GameFramework.Inputmanagement.Interfaces
{
    public interface IInputManager
    {
        void AddActionToBinding(string binding, Action action);
        float GetAxis(string axisName);
        bool GetButton(string button);
        Vector3 GetMouseVector();
    }
}