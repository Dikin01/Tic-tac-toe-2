using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Classic Builder", menuName = "Scene builders/Classic Builder")]
public class ClassicSceneBuilder : AbstractSceneBuilder
{

    public override void CreateEventSystem()
    {
        GameObject eventSystemObject = new GameObject("EventSystem");
        eventSystemObject.AddComponent<EventSystem>();
        eventSystemObject.AddComponent<StandaloneInputModule>();
    }

    public override void AddObserver()
    {
        Camera.main.gameObject.AddComponent<ScoreObserver>();

    }

    public override void CreateBackground()
    {
        Instantiate(_background, _canvas.gameObject.transform);
    }

    public override void CreateCanvas()
    {
        GameObject canvasObject = new GameObject("Canvas"); //Метод для создания Canvas
        _canvas = canvasObject.AddComponent<Canvas>();
        _canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        CanvasScaler canvasScaler = canvasObject.AddComponent<CanvasScaler>();
        canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        canvasScaler.referenceResolution = new Vector2(1920, 1080);

        canvasObject.AddComponent<GraphicRaycaster>();
        
        _canvas.gameObject.transform.parent = Camera.main.transform;
    }

    public override void CreateGrid()
    {        
        Instantiate(_gridPrefab, _canvas.transform);
    }

    public override void CreateBackgroundMusic()
    {
        var musicManager = new GameObject("MusicManager");
        var audioSource = musicManager.AddComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.playOnAwake = true;
        audioSource.clip = _backgroundMusic;
        audioSource.Play();
    }
}
