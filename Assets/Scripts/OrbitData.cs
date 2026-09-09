using UnityEngine;
using System.Collections.Generic;

public abstract class OrbitDataProvider : ScriptableObject
{
    public abstract OrbitData GetData();
}

public class OrbitData
{
    public float OrbitalSpeed;
    public float OrbitRadius;
    public float PlanetRotationSpeed;
    public float PlanetSize;
    public Planet PlanetPrefab;
    public List<OrbitDataProvider> Satellites;

    
}