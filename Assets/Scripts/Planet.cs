using UnityEngine;

public class Planet : MonoBehaviour
{

    [Range(0, 100)]
    [Tooltip("Distance from the orbit in thousand of km")]
    public float distanceFromOrbit;
    [Range(1, 200)]
    [Tooltip("Size of the planet in thousand of km")]
    public float bodySize;

    public MeshRenderer body;

    void Start()
    {
        //this.body = this.GetComponentInChildren<MeshRenderer>();
    }


    void Update()
    {
        this.transform.localPosition = new Vector3(this.distanceFromOrbit, 0, 0);
        this.body.transform.localScale = new Vector3(this.bodySize, this.bodySize, this.bodySize);

    }
}
