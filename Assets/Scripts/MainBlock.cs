using UnityEngine;

[RequireComponent(typeof(Block))]
public class MainBlock : MonoBehaviour
{
    public Block GetBlock()
    {
        return gameObject.GetComponent<Block>();
    }
}
