using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Orbit", menuName = "ScriptableObjects/OrbitPreset")]

public class OrbitPreset : ScriptableObject
{
    [Header("Orbit")]
    //Orbit variables
    [Tooltip("speed of rotation of the orbit.")]

    [Range(-100, 100)]
    public float OrbitalSpeed;
    [Tooltip("Radius of the orbit in millions of km")]
    [Range(0, 10000)]
    public float OrbitRadius;

    [Header("Planet")]
    [Tooltip("Prefab used for the planet")]
    public Planet PlanetPrefab;

    [Header("Planet")]
    //planet variables
    [Tooltip("Speed of rotation of the planet")]
    [Range(-400, 400)]
    public float PlanetRotationSpeed;

    [Tooltip("Radius of the planet in km")]
    [Range(0, 1000)]
    public float PlanetSize;

    public List<OrbitPreset> satellites;


}
