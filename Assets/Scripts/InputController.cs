using UnityEngine;

public class InputController : MonoBehaviour
{
    public Rigidbody planet;
    public float jumpForce = 1;
    public float speed = 1;
    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.Space))
            GameController.Instance.Pause();

        if(Input.GetKeyDown(KeyCode.UpArrow))
            GameController.Instance.UpSpeed();

        if(Input.GetKeyDown(KeyCode.DownArrow))
            GameController.Instance.DownSpeed();
        */
        if(Input.GetKeyDown(KeyCode.Space))
        {
            this.planet.AddForce(Vector3.up * jumpForce * this.planet.mass);
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.planet.AddForce(Vector3.right * speed * this.planet.mass);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.planet.AddForce(Vector3.left * speed * this.planet.mass);
        }
    }
}
