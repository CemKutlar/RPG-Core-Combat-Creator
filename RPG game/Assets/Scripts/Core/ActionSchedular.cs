using UnityEngine;

namespace RPG.Core
{
    public class ActionSchedular : MonoBehaviour
    {

        IAction currentAction;

        public void StartAction(IAction action)
        {
            if (currentAction == action) return;
            if (currentAction != null)
            {
                currentAction.Cancel();
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