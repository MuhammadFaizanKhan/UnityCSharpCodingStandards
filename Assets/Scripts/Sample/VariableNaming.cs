
using UnityEngine;
using UnityEngine.UI;
namespace CodingStandards
{
    /// <summary>
    /// Author: Muhammad Faizan Khan
    /// Create Date: 23-02-2021
    /// Purpose: To demonstrate variable naming convention
    /// </summary>
    public class VariableNaming : MonoBehaviour
    {
        // Here you can define your all variables and properties or static declarations
        #region Vars
        public static int counter;//Place static variable on top of the script

        public delegate void DlgAnimFinished();//place dlg before delegate name
        public event DlgAnimFinished AnimFinsihedEventHandler;//Events are associated with actions. Therefore, events are name with verbs: TiggerOccured, ButtonClicked, SceneLoaded etc


        [SerializeField] //Make SerializeField if you want to show the variable only on the inspector
        private Camera camActive;//right
        private Camera CamActive;//wrong! don't use PascalCase for variable name
        private Camera Cam_Active;//wrong! don't use Underscore in variable name

        public Button btnVersionSwitch;//right
        public Button ButtonVersionSwitch;//wrong! use button abbreviation

        public MiniMap MiniMapUIController;//right
        public MiniMap CtrlUIMM;//wrong! 5.	Write descrtipive, pronounceable and easily remembered names

        public Vector3 posX;//right
        public Vector3 xPos;//wrong! Keep the most common descriptor on the left

        #endregion
    }

    //Don't use Multiple classes in single script.
    public class MiniMap
    {
    }
}