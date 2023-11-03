using UnityEngine;

namespace Assets.Core.Task_5.Scripts
{
    public class Player : MonoBehaviour
    {
        public BaseStats Stats;

        private void Start()
        {
            Debug.Log($"Intelligence = {Stats.Intelligence}, Strength = {Stats.Strength}, Agility = {Stats.Agility}");
        }
    }
}