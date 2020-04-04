using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float time = 3;
    public GameObject ob;


    private Vector2 targetPos;
    public static bool dead = false;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        dead = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if(!dead)
        {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, 100 * Time.deltaTime);

    
        if (Input.GetKey("d"))
        {

            targetPos = new Vector2(transform.position.x + speed, transform.position.y);

        }
        if (Input.GetKey("a"))
        {
            targetPos = new Vector2(transform.position.x - speed, transform.position.y);

        }
        if (rb.position.x < -17f || rb.position.x > 16f)
        {
            rb.useGravity = true;
            rb.AddForce(Vector3.up * -40f);

            if (rb.position.y < -2f)
                SceneManager.LoadScene("SampleScene");
        }
        }
        else
        {
            CountDown();

        }

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            ob= Instantiate (Resources.Load ("DeathAudio")) as GameObject;
            dead = true;
        }
    }

    void CountDown()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
