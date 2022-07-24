using RPG.Combat;
using UnityEngine;
using UnityEngine.AI;

namespace RPG.Movement
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] Transform target;

        NavMeshAgent navMeshAgent;

        private void Awake()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();

        }

        // Update is called once per frame
        void Update()
        {

            UpdateAnimator();
        }

        public void Stop()
        {
            navMeshAgent.isStopped = true;
        }


        public void StartMoveAction(Vector3 destination)
        {
            GetComponent<Fighter>().CancelAttack();
            MoveTo(destination);
        }
        public void MoveTo(Vector3 destination)
        {
            navMeshAgent.destination = destination;
            navMeshAgent.isStopped = false;
        }

        private void UpdateAnimator()
        {
            Vector3 velocity = navMeshAgent.velocity;
            Vector3 localVelocity = transform.InverseTransformDirection(velocity);
            float speed = localVelocity.z;
            GetComponent<Animator>().SetFloat("forwardSpeed", speed);
        }
    }
}