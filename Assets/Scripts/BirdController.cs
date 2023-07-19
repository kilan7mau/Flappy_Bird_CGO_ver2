using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{ 
   public float jumpAngle;
   public Rigidbody2D rb;
   public float jumpForce;
   public float angleRotateSpeed;
   
   
   void Start()
   {
      rb = GetComponent<Rigidbody2D>();
      rb.gravityScale= 0;
   }
   void Update()
   {
      if (GameManager.Instance.isEndGame) return;
      bool isTap = Input.GetKeyDown(KeyCode.Space);
      if (isTap&&GameManager.Instance.isStartGame==true)
      {
         Jump();
      }
      if (GameManager.Instance.isStartGame == false) return;
      RotateBird();
   }
   
   public void StartGame()
   {
      rb.gravityScale = 1;
   }
   
   protected void RotateBird()
   {
      transform.eulerAngles -= new Vector3(0, 0, angleRotateSpeed * Time.deltaTime);
      
   }

   protected void Jump()
   {
      rb.velocity = Vector2.up * jumpForce;
      transform.eulerAngles = new Vector3(0, 0, jumpAngle);
      AudioManager.Instance.PlayFlapBirdAudio();
   }
}
