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
        float dt = Time.deltaTime;
        //d = t*v
        float angle = dt * speed * GameController.Instance.Speed;
        this.transform.Rotate(Vector3.up, speed * GameController.Instance.Speed);
    }
}
