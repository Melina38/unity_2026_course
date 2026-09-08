using UnityEngine;

public class InputController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            GameController.Instance.Pause();

        if(Input.GetKeyDown(KeyCode.UpArrow))
            GameController.Instance.UpSpeed();

        if(Input.GetKeyDown(KeyCode.DownArrow))
            GameController.Instance.DownSpeed();
        
    }
}
