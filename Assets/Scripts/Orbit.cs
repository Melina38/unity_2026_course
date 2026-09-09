using UnityEngine;

public class Orbit : MonoBehaviour
{
    public OrbitPreset preset;
    public AutoRotate myAutoRotate;
    public Planet myPlanet;

    public void Start()
    {
        this.myPlanet = GameObject.Instantiate(this.preset.PlanetPrefab, this.transform);
    }
    public void Update()
    {
        this.UpdateWithPreset();
    }

    public void UpdateWithPreset()
    {
        //set values from preset to autoroatate
        myAutoRotate.speed = this.preset.OrbitalSpeed;
        myPlanet.UpdateFromOrbitPreset(this.preset);
    }
}