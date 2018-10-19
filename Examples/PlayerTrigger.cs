using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    public FloatBase HealthLevel;
    public FloatBase EvilPower;

    void OnTriggerEnter()
    {
        HealthLevel.Value -= EvilPower.Value;
    }
}