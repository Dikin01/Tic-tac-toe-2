using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModes : MonoBehaviour
{
    [SerializeField] private ClassicSceneBuilder _classicSceneBuilder;
    public ClassicSceneBuilder ClassicSceneBuilder { get => _classicSceneBuilder; set => _classicSceneBuilder = value; }

    [SerializeField] private StrategySceneBuilder _strategySceneBuilder;
    public StrategySceneBuilder StrategySceneBuilder { get => _strategySceneBuilder; set => _strategySceneBuilder = value; }
}
