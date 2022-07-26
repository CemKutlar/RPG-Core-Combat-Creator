using UnityEngine;

namespace RPG.Combat
{
    public class Health : MonoBehaviour
    {
        [SerializeField] float healthPoints = 100f;
        Animator animator;
        bool isAlive = true;

        private void Awake()
        {
            animator = GetComponent<Animator>();    
        }

        private void Update()
        {
            TriggerDeathAnimation();
        }
        public void TakeDamge(float damageAmount)
        {
            healthPoints = Mathf.Max(healthPoints - damageAmount, 0);
            Debug.Log(healthPoints);
        }

        private void TriggerDeathAnimation()
        {
            if(healthPoints == 0 && isAlive)
            {
                animator.SetTrigger("die");
                isAlive = false;
            }
        }

        public bool IsAlive()
        {
            return isAlive;
        }
    }
}
