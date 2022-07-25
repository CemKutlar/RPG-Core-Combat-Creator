using UnityEngine;

namespace RPG.Combat
{
    public class Health : MonoBehaviour
    {
        [SerializeField] float health = 100f;

        public void TakeDamge(float damageAmount)
        {
            health = Mathf.Max(health - damageAmount, 0);
            Debug.Log(health);
        }
    }
}
