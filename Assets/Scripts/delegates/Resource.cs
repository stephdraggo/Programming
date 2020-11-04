using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Delegates
{
    public class Resource : MonoBehaviour
    {
        #region Variables
        [SerializeField] private int baseGold;

        private int offsetGold;

        #endregion
        #region Properties
        public int GoldValue { get => baseGold + offsetGold; }

        #endregion
        #region Start
        void Start()
        {
            offsetGold = Random.Range(0, 10);
            GameManager.instance.RegisterResource(this);
        }
        #endregion
        #region Mouse Button
        private void OnMouseUpAsButton()
        {
            GameManager.instance.GatherResource(this);
            Destroy(gameObject);
        }
        #endregion
        #region Functions

        #endregion
    }
    #region Delegates
    public delegate void ResourceGatherDelegate(Resource _resource);
    public delegate void ResourceCountDelegate(int _count);
    #endregion
}