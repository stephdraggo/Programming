using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Delegates
{
    public class Player : MonoBehaviour
    {
        #region Variables

        #endregion
        #region Properties

        #endregion
        #region Start
        void Start()
        {
            GameManager.instance.ListenForResourceGather(OnResourceGathered);
            GameManager.instance.ListenForResourceCount(OnResourcesCounted);
        }
        #endregion
        #region Update
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameManager.instance.CountResource();
            }
        }
        #endregion
        #region Functions
        private void OnResourceGathered(Resource _resource)
        {
            Debug.Log("Resource was worth: " + _resource.GoldValue);
        }
        private void OnResourcesCounted(int _count)
        {
            Debug.Log("There are " + _count.ToString() + " resources remaining.");
        }
        #endregion
    }
}