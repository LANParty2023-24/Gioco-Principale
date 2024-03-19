// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;


// public class PlayerController : MonoBehaviour
// {
//     void Start() {
//         defaultPos = gameObject.transform.localPosition;
//         newPos = gameObject.transform.localPosition;
//     }

//     function Update() {
//         newPos.x += Input.GetAxis("Mouse X") * moveSpeed * Time.deltaTime;
//         newPos.y += Input.GetAxis("Mouse Y") * moveSpeed * Time.deltaTime;
//         gameObject.transform.localPosition = newPos;
//         newPos.x = Mathf.Clamp(newPos.x, minimumX, maximumX);
//         newPos.y = Mathf.Clamp(newPos.y, minimumY, maximumY);
//     }
// }