using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
    public LogicScript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (IsPotCollision(collision))
        {
            logic.AddScore(1);
        }
    }

    private bool IsPotCollision(Collider2D collision)
    {
        return collision.gameObject.layer == 3;
    }
}
