using UnityEngine;

public class Orbit : MonoBehaviour
{
    public OrbitDataProvider preset;
    public AutoRotate myAutoRotate;
    public Planet myPlanet;

    public void Start()
    {
        this.Generate();
    }
    public void Generate()
    {
        OrbitData data = this.preset.GetData();
        if (this.myPlanet != null)
            this.myPlanet = GameObject.Instantiate(data.PlanetPrefab, this.transform);

        if (this.preset != null)
            this.UpdateWithPreset();
    }
    public void Update()
    {
        this.UpdateWithPreset();
    }

    public void UpdateWithPreset()
    {
        OrbitData data = this.preset.GetData();
        //set values from preset to autoroatate
        myAutoRotate.speed = data.OrbitalSpeed;
        myPlanet.UpdateFromPreset(this.preset);

    }
}