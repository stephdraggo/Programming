using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Delegates
{
    public class GameManager : MonoBehaviour
    {
        #region Variables
        public static GameManager instance = null;

        private ResourceGatherDelegate gatherCallback;
        private ResourceCountDelegate countCallback;

        private List<Resource> resources = new List<Resource>();
        #endregion
        #region Properties

        #endregion
        #region Awake - set up instance
        void Awake()
        {
            if (instance == null) //if the instance doesn't exist
            {
                instance = this; //set this as instance
            }
            else if (instance != this) //if there is an instance but it isn't this object
            {
                Destroy(gameObject); //delete this
                return; //exit code early
            }
            DontDestroyOnLoad(gameObject); //always be able to access the original instance
        }
        #endregion
        #region Functions
        /// <summary>
        /// Adds resource to the resource list.
        /// </summary>
        /// <param name="_resource">Resource to be added.</param>
        public void RegisterResource(Resource _resource)
        {
            resources.Add(_resource);
        }
        /// <summary>
        /// Subscribe new function to gather function set.
        /// </summary>
        /// <param name="_callback">gather function</param>
        public void ListenForResourceGather(ResourceGatherDelegate _callback)
        {
            gatherCallback += _callback;
        }
        /// <summary>
        /// Subscribe new function to count function set.
        /// </summary>
        /// <param name="_callback">count function</param>
        public void ListenForResourceCount(ResourceCountDelegate _callback)
        {
            countCallback += _callback;
        }
        /// <summary>
        /// Runs gather delegate and removes resource from list when resource is clicked.
        /// </summary>
        /// <param name="_resource">resource being gathered</param>
        public void GatherResource(Resource _resource)
        {
            if (gatherCallback != null)
            {
                gatherCallback(_resource);
            }
            resources.Remove(_resource);
        }
        /// <summary>
        /// Finds out how many resources are left in the scene.
        /// </summary>
        public void CountResource()
        {
            if (countCallback != null)
            {
                countCallback(resources.Count);
            }
        }
        #endregion
    }
}