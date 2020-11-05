using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    bool a = false;

    public Joystick variableJoystick;
    public Rigidbody2D rigidbody;
    public float speed = 10000;
    private string move;

    public Button restartButton;
    // Start is called before the first frame update
    void Start()
    {
        move = PlayerPrefs.GetString("move");

        rigidbody.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        if (move == "Joystick")
        {
            variableJoystick.gameObject.SetActive(true);
            Vector2 direction = Vector2.right * variableJoystick.Horizontal + Vector2.up * variableJoystick.Vertical;
            rigidbody.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode2D.Force);
        }
        else
        {
            variableJoystick.gameObject.SetActive(false);

            Vector2 dir = Vector2.zero;

            dir.x = Input.acceleration.x;
            dir.y = Input.acceleration.y;

            if (dir.sqrMagnitude > 1)
                dir.Normalize();

            dir *= Time.deltaTime;
            transform.Translate(dir * 10);
        }

        //gameObject.transform.Translate(direction * Time.fixedDeltaTime);

        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wall")
        {
            Destroy(gameObject);
        }
        if (collision.tag == "Finish")
        {
            Debug.Log("This game is yours!");
        }
        restartButton.gameObject.SetActive(true);
    }


}
