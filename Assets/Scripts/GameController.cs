using UnityEngine;

public class GameController : MonoBehaviour
{

    public static GameController Instance;

    public event System.Action<float> OnSpeedChange;

    [Range(0, 100)]
    [Tooltip("Global speed of the game")]

    

    private float _speed;
    public float Speed {
        get { return this._speed;}
        set{
            this._speed = value;
            if(this.OnSpeedChange != null)
            this.OnSpeedChange.Invoke(this._speed);
        }
    }
    private float? _previousSpeed;

    public Orbit GenericOrbit;

    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
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
