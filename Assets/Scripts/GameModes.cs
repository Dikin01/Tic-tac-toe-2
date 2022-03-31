using UnityEngine;

public class GameModes : MonoBehaviour
{
    [SerializeField] private ClassicSceneBuilder _classicSceneBuilder;
    [SerializeField] private StrategySceneBuilder _strategySceneBuilder;
    public ClassicSceneBuilder ClassicSceneBuilder { get => _classicSceneBuilder; set => _classicSceneBuilder = value; }
    public StrategySceneBuilder StrategySceneBuilder { get => _strategySceneBuilder; set => _strategySceneBuilder = value; }
}
