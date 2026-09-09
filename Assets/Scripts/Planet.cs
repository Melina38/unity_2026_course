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

    public void UpdateFromPreset(OrbitDataProvider preset)
    {
        var data = preset.GetData();
        this.distanceFromOrbit = data.OrbitRadius;
        this.bodySize = data.PlanetSize;

        if(this.myAutoRotate != null)
            this.myAutoRotate.speed = data.PlanetRotationSpeed;
        

        for(int i = 0; i < data.Satellites.Count; i++)
        {
            var satellitepresetToCreate = data.Satellites[i];
            if(this._existingOrbits.Count > i)
            {
                this._existingOrbits[i].preset = satellitepresetToCreate;
            }
            else if (satellitepresetToCreate != null)
            {
                var newOrbit = GameObject.Instantiate(GameController.Instance.GenericOrbit, this.transform);
                newOrbit.preset = satellitepresetToCreate;
                this._existingOrbits.Add(newOrbit);
            }
            
        }

        for(int j = data.Satellites.Count; j < this._existingOrbits.Count; j++)
        {
            var _existingOrbit = _existingOrbits[j];
            _existingOrbits.RemoveAt(j);
            j--;
            if (_existingOrbit != null)
                GameObject.Destroy(_existingOrbit.gameObject);
            
        }
    }


    void Update()
    {
        this.transform.localPosition = new Vector3(this.distanceFromOrbit, 0, 0);
        this.body.transform.localScale = new Vector3(this.bodySize, this.bodySize, this.bodySize);

    }
}
