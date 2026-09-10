using UnityEngine;
using UnityEngine.UI;

public class PanelSettings : MonoBehaviour
{
    //component
    public Toggle myToggle;
    void Start()
    {
        GameController.Instance.OnSpeedChange += InstanceOnOnSpeedChange;
    }
    void OnDestroy()
    {
        GameController.Instance.OnSpeedChange -= InstanceOnOnSpeedChange;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InstanceOnOnSpeedChange(float newspeed)
    {
        this.myToggle.SetIsOnWithoutNotify(GameController.Instance.Speed == 0);
    }
}
