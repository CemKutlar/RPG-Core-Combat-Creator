using UnityEngine;

namespace RPG.Core
{
    public class ActionSchedular : MonoBehaviour
    {

        MonoBehaviour currentAction;

        public void StartAction(MonoBehaviour action)
        {
            if (currentAction == action) return;
            if (currentAction != null)
            {
                Debug.Log("Cancelling" + currentAction);
            }
            currentAction = action;

            //    if (action == GetComponent<Mover>())
            //    {
            //        Debug.Log("Start moving");
            //    }
            //    if (action = GetComponent<Fighter>())
            //    {
            //        Debug.Log("StartFighting");
            //    }
        }
    }

}