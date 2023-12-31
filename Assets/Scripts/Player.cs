using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public FixedJoystick Joystick;
    public float moveSpeed;
    [SerializeField]
    private GameObject winText;
    public int gameScore;
    [SerializeField]
    private GameObject QuitButton;
    // get horizontal input and vertical input  
    float hInput, vInput;
    int score;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    private void FixedUpdate()
    {
        hInput = Joystick.Horizontal * moveSpeed;
        vInput = Joystick.Vertical * moveSpeed;

        transform.Translate(hInput, vInput, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Carrot")
        {
            score++;

            Destroy(collision.gameObject);

            if (score > 5)
            {
                winText.SetActive(true);
                moveSpeed = 0.0f;
                QuitButton.SetActive(true);
            }

            
        }


    }
}
