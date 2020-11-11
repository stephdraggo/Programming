using UnityEngine;
using UnityEngine.UI;

namespace TernaryOops
{
    public class TernaryTime : MonoBehaviour
    {
        #region Variables
        [SerializeField] private float baseSpeed = 5, sprintModifier = 2, crouchModifier = 0.5f;

        [SerializeField] private Text type1, type2, type3, type4;

        private bool isSprinting = false, isCrouching = false;
        #endregion
        #region Properties

        #endregion
        #region Update
        void Update()
        {
            isSprinting = Input.GetKey(KeyCode.LeftShift);
            isCrouching = Input.GetKey(KeyCode.LeftControl);

            type1.text = "Type 1 speed: " + CalculateType1Speed().ToString();
            type2.text = "Type 2 speed: " + CalculateType2Speed().ToString();
            type3.text = "Type 3 speed: " + CalculateType3Speed().ToString();
            type4.text = "Type 4 speed: " + CalculateType4Speed().ToString();
        }
        #endregion
        #region Functions
        /// <summary>
        /// Calculate speed using if statements.
        /// </summary>
        private float CalculateType1Speed()
        {
            float speed = baseSpeed;
            if (isSprinting)
            {
                speed = baseSpeed * sprintModifier;
            }
            else
            {
                //speed = baseSpeed;
            }

            if (isCrouching)
            {
                speed = baseSpeed * crouchModifier;
            }
            else
            {
                //speed = baseSpeed;
            }

            return speed;
        }
       
        /// <summary>
        /// Calculate speed with ternary operators.
        /// </summary>
        private float CalculateType2Speed()
        {
            float speed = baseSpeed;

            //ternary operators are a one line if-else *assignment* statement
            //ternary operator = <condition> ? <true value> : <false value>
            //? = if, : = else
            speed *= isSprinting ? sprintModifier : 1;
            speed *= isCrouching ? crouchModifier : 1;

            return speed;
        }
       
        /// <summary>
        /// Calulate speed with ternary operators in return (one line).
        /// </summary>
        private float CalculateType3Speed()
        {
            return baseSpeed * (isSprinting ? sprintModifier : 1) * (isCrouching ? crouchModifier : 1);
        }
      
        /// <summary>
        /// Calculate speed using nested ternary operators and function calls.
        /// </summary>
        private float CalculateType4Speed()
        {
            return isSprinting ? GetSprintSpeed() : isCrouching ? GetCrouchSpeed() : baseSpeed;
        }
        #region extra functions for type 4
        private float GetSprintSpeed()
        {
            return baseSpeed * sprintModifier;
        }
        private float GetCrouchSpeed()
        {
            return baseSpeed * crouchModifier;
        }
        #endregion
        #endregion
    }
}