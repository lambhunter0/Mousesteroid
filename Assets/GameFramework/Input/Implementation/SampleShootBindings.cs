using UnityEngine;

namespace PersonalProjects.GameFramework.Inputmanagement
{
    public class SampleShootBindings : InputBindings
    {
        protected override void SetupBindings()
        {
            base.SetupBindings();
            keyBindings.Add("shoot", KeyCode.Mouse0);
        }
    }
}
