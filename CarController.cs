using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputManager))]
public class CarController : MonoBehaviour
{
   public InputManager im;
   public List<WheelCollider> throttleWheels;
   public List<WheelCollider> steeringWheels;
   public float strengthCoefficient = 20000f;
   public float maxturn = 20f;


   // Start is called before the first frame update
   void Start(){
      im = GetComponent<InputManager>();
   }

   // Update is called once per frame
   void FixedUpdate(){
      foreach (WheelCollider wheel in throttleWheels)
      {
         wheel.motorTorque = strengthCoefficient * Time.deltaTime * im.throttle;
      }

      foreach (WheelCollider wheel in steeringWheels)
      {
         wheel.steerAngle = maxturn * im.steer;
      }
   }
}
