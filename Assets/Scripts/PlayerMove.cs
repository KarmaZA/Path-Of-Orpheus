using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float SideForce = 500f;
    public Transform player;

    private bool InJump = false;

    // Start is called before the first frame update
    void Start()
    {
        //rb.AddForce(0,200,500);
    }

    // Update is called once per frame
    void FixedUpdate() //Fixed for Physics sutff
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        //WASD Movement
        if (Input.GetKey("d") )
        {
            rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //(x,y,z, forcoemode)
        }
        if (Input.GetKey("a") )
        {
            rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ((Input.GetKey(KeyCode.Space)) & (InJump == false))
        {
            rb.AddForce(0, SideForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            InJump = true;
        }

        if (player.position.y <= 2) //Player will techinically never have to hit the ground
        {
            InJump = false;
        }



        if (rb.position.y < -5)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
