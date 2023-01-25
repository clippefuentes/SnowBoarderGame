using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    // Rigidbody2D rb2d;
    [SerializeField] float torqueAmount = 1f;
    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.D)) {
            rb2d.AddTorque(torqueAmount);
        } else if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A)) {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
