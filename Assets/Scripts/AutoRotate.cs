using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     UnityEngine.Debug.Log("Start");   
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Debug.Log("Update");
        //this.transform.position += new Vector3(0, 0, this.speed);
        this.transform.Rotate(Vector3.up, this.speed);

    }
}
