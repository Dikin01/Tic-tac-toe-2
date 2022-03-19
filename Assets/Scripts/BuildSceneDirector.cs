using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSceneDirector : MonoBehaviour
{
    private AbstractSceneBuilder _sceneBuilder;
    public AbstractSceneBuilder SceneBuilder { get => _sceneBuilder; set => _sceneBuilder = value; }

    private void Awake()
    {
        _sceneBuilder = DataHolder.SceneBuilder;        
        �ustomizeScene();
    }

    public void �ustomizeScene()
    {
        if (_sceneBuilder is null)
            throw new System.Exception("��� ������ �� SceneBuilder");
        _sceneBuilder.CreateEventSystem();
        _sceneBuilder.CreateCanvas();
        _sceneBuilder.CreateBackground();
        _sceneBuilder.CreateBackgroundMusic();
        _sceneBuilder.CreateGrid();
        _sceneBuilder.AddObserver();
    }
}
