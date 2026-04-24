using UnityEngine;

public class Tile : MonoBehaviour
{
    [Header("Tile Settings")]
    public bool occupied { private set; get; } = false;
    public ITileOccupant occupiedObj { private set; get; }

    [SerializeField, Tooltip("Set the tile type.")]
    private TileType tileType = TileType.Grass;
    public TileType TileType { get { return tileType; } }

    private void Occupy(ITileOccupant pOccupant)
    {
        if (pOccupant == null) return;
        
        occupiedObj = pOccupant;
        occupied = true;
    }

    private void UnOccupy()
    {
        occupiedObj = null;
        occupied = false;
    }
}
