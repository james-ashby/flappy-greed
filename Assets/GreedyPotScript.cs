using UnityEngine;

public class GreedyPotScript : MonoBehaviour
{
    public Rigidbody2D body;
    public float flapStrength;
    public LogicScript logic;
    public bool potIsAlive = true;
    public float lowerScreenDeathZone = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && potIsAlive)
        {
            body.linearVelocity = Vector2.up * flapStrength;
        }

        if (transform.position.y < - lowerScreenDeathZone)
        {
            logic.GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
    }
}
