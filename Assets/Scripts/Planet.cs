using UnityEngine;
using System.Collections.Generic;

public class Planet : MonoBehaviour
{

    [Range(0, 1000)]
    [Tooltip("Distance from the orbit in thousand of km")]
    public float distanceFromOrbit;
    [Range(1, 200)]
    [Tooltip("Size of the planet in thousand of km")]
    public float bodySize;
    public AutoRotate myAutoRotate;

    public MeshRenderer body;

    public List<Orbit> _existingOrbits = new List<Orbit>();

    public void UpdateFromOrbitPreset(OrbitPreset preset)
    {
        this.distanceFromOrbit = preset.OrbitRadius;
        this.bodySize = preset.PlanetSize;
        this.myAutoRotate.speed = preset.PlanetRotationSpeed;

        for(int i = 0; i < preset.satellites.Count; i++)
        {
            var satellitePreset = preset.satellites[i];
            if(this._existingOrbits.Count > i)
            {
                this._existingOrbits[i].preset = satellitePreset;
            }
            else if (satellitePreset != null)
            {
                var newOrbit = GameObject.Instantiate(GameController.Instance.GenericOrbit, this.transform);
                newOrbit.preset = satellitePreset;
                this._existingOrbits.Add(newOrbit);
            }
            
        }

        for(int j = preset.satellites.Count; j < this._existingOrbits.Count; j++)
        {
            var existingOrbit = this._existingOrbits[j];
            this._existingOrbits.RemoveAt(j);
            GameObject.Destroy(existingOrbit.gameObject);
        }
    }


    void Update()
    {
        this.transform.localPosition = new Vector3(this.distanceFromOrbit, 0, 0);
        this.body.transform.localScale = new Vector3(this.bodySize, this.bodySize, this.bodySize);

    }
}
