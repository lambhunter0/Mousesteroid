using System;
using UnityEngine;

namespace PersonalProjects.GameFramework.Inputmanagement.Interfaces
{
    public interface IMouseInputHandler
    {
        Vector2 GetRawPosition();
        Vector3 GetInput();
    }
}