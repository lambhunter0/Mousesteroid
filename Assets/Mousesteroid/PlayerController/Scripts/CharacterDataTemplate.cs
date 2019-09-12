using UnityEngine;

namespace PersonalProjects.Mouseteroid.Player
{
    [CreateAssetMenu(fileName = "New CharacterDataTemplate", menuName = "Data/CharacterTemplate")]
    public class CharacterDataTemplate : ScriptableObject
    {
        [SerializeField] private CharacterData characterData;

        public CharacterData CharacterData { get { return characterData; } }
    }
}
