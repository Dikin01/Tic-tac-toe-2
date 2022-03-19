using UnityEngine;
using UnityEngine.UI;

public abstract class AbstractSceneBuilder : ScriptableObject
{
    [SerializeField] protected AudioClip _backgroundMusic;
    [SerializeField] protected GameObject _gridPrefab;    
    [SerializeField] protected GameObject _background;
    
    protected Canvas _canvas;
    protected GameObject _cameraObject;
    public abstract void CreateCanvas();
    public abstract void CreateGrid();
    public abstract void CreateBackground();
    public abstract void CreateBackgroundMusic();
    public abstract void CreateEventSystem();
    public abstract void AddObserver();
}
