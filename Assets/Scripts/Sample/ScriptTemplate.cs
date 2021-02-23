using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace CodingStandards
{
    /// <summary>
    /// Author: Muhammad Faizan Khan
    /// Create Date: 23-02-2021
    /// Purpose: To demonstrate basic strucutre of a script for MonoBehaviour
    /// </summary>
    public class ScriptTemplate : MonoBehaviour
    {

        // Here you can define your all variables and properties or static declarations
        #region Vars

        [SerializeField] //Make SerializeField if you want to show the variable only on the inspector
        private Camera camActive;


        #endregion

        //All Unity Related Events will be written in this Region. If Your script is not using any unity events then remove it (specially Update Event)
        #region UnityEvents
        void Start()
        {

        }

        void Update()
        {

        }

        #endregion UnityEvents

        ///These are the methods that you will called 
        #region CustomMethods
        void MovementOnKeys()
        {

        }
        #endregion CustomMethods

        //Method that will be used as events
        #region CustomEventsMethod
        ///Login button click will fire this event
        public void BtnLoginClicked()
        {

        }

        #endregion CustomEventsMethod

    }
}
