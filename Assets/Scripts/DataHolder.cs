using UnityEngine;
public static class DataHolder
{
    private static FieldPartState _tempPlayer = FieldPartState.PlayerX;
    private static FieldPartState _winner;

    public static FieldPartState TempPlayer => _tempPlayer;
    public static FieldPartState Winner => _winner;

    public static AbstractSceneBuilder SceneBuilder { get; set; }
    

    public static void ChangePlayer()
    {
        //Баг, следущая партия будет у ноликов, если поменять порядок подписок на событие OnCellClick

        Debug.Log("Change temporary player");
        if (_tempPlayer == FieldPartState.PlayerX)
        {
            _tempPlayer = FieldPartState.PlayerO;
        }
        else if (_tempPlayer == FieldPartState.PlayerO)
        {
            _tempPlayer = FieldPartState.PlayerX;
        }
        else
        {
            throw new System.ArgumentException($"Player can't be {_tempPlayer}");
        }
    }
    
    public static void Win(FieldPartState winState)
    {
        _winner = winState;
        _tempPlayer = FieldPartState.PlayerX;
    }  
}


