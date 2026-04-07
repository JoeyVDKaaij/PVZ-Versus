using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField, Tooltip("Set the ability usage rate.")]
    protected float abilityUsageRate;
    [SerializeField, Tooltip("Set the tiles where the plant cannot be planted on.")]
    private TileType[] unreachableTileTypes;

    private float _timer = 0;
    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= abilityUsageRate)
        {
            _timer = 0;
            
            ActivateAbility();
        }
    }

    protected virtual void ActivateAbility() {}
}