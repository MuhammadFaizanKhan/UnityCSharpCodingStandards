using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CodingStandards
{
    /// <summary>
    /// Author: Muhammad Faizan Khan
    /// Create Date: 23-02-2021
    /// Purpose: To demonstrate basic strucutre of a method
    /// </summary>
    public class MethodNaming : MonoBehaviour
    {
        //Use PascalCase for custom file- and folder names, like this: UtilityClasses, ProjectIcons. Do not use spaces, underscores, or hyphens,
        //with one exception (see Naming Different Aspects of the Same Thing).


        ///These are the methods that you will called 
        #region CustomMethods
        void MovementOnKeys()
        {
            //implementation
        }

        
        #endregion CustomMethods

        //Method that will be used as events
        #region CustomEventsMethod
        ///Login button click will fire this event
        public void BtnPressed() //right
        {

        }

        public void Pressed()//wrong! Write descriptive name
        {

        }

        #endregion CustomEventsMethod
    }
}