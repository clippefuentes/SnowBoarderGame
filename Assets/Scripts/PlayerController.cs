using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    // Rigidbody2D rb2d;
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float baseSpeed = 20f;
    SurfaceEffector2D surfaceEffector2D;
    Rigidbody2D rb2d;

    bool canMove = true;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
  {
    if (canMove == true) {
      RotatePlayer();
      RespondToBoost();
    }
  }

  public void DisableControls() {
    canMove = false;
  }

  void RespondToBoost()
  {
    if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
    {
      surfaceEffector2D.speed = baseSpeed + 5f;
    }
    else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
    {
      surfaceEffector2D.speed = baseSpeed - 5f;
    }
  }

  void RotatePlayer()
  {
    if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.D))
    {
      rb2d.AddTorque(torqueAmount);
    }
    else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A))
    {
      rb2d.AddTorque(-torqueAmount);
    }
  }
}
