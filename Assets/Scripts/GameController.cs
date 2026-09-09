using UnityEngine;

public class GameController : MonoBehaviour
{

    public static GameController Instance;


    [Range(0, 100)]
    [Tooltip("Global speed of the game")]
    public float Speed;
    private float? _previousSpeed;

    public Orbit GenericOrbit;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Instance == null)
        Instance = this;
        
        
        
    }


    public void Pause()
    {
        if (this.Speed == 0)
        {
            this.Speed = this._previousSpeed.GetValueOrDefault(1);
            
        }
        else
        {
            this._previousSpeed = this.Speed;
            this.Speed = 0;

        }
        
    }

    public void UpSpeed()
    {
        // Increase the speed of the game by 1 when the user presses the "Up" key
        this.Speed += 1;
    }

    public void DownSpeed()
    {
        // Decrease the speed of the game by 1 when the user presses the "Down" key
        this.Speed -= 1;
    }

}
