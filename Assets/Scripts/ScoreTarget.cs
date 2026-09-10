using UnityEngine;

public class ScoreTarget : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("TouchTarget");
    }
}
