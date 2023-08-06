using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Transform attackerObject;
    public Rigidbody car;
    public float movementSpeed;
    public float rotationSpeed;
    public float cylinderSpeed;

    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        float mouseY = Input.GetAxis("Mouse Y");
        Vector3 movement = new Vector3(horizontalMovement, 0f, verticalMovement).normalized;

        if (movement.z != 0f)
        {

            Vector3 moveDirection = car.transform.forward * movement.z;
            car.MovePosition(car.position + moveDirection * movementSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {

            car.MoveRotation(car.rotation * Quaternion.Euler(Vector3.up * rotationSpeed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.A))
        {
            car.MoveRotation(car.rotation * Quaternion.Euler(Vector3.up * -rotationSpeed * Time.deltaTime));
        }

        NamluDonus(mouseY);
    }


    void NamluDonus(float mouseY)
    {
        float ClampedRotation = Mathf.Clamp(attackerObject.localEulerAngles.x + (-mouseY * cylinderSpeed), 20f, 60f);
        attackerObject.localEulerAngles = new Vector3(ClampedRotation, attackerObject.localEulerAngles.y, attackerObject.localEulerAngles.z);
    }
}


