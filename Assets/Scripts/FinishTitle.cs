using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishTitle : MonoBehaviour
{
    //переделать надо
    [SerializeField] private GameObject _winTextPlayerX;
    [SerializeField] private GameObject _winTextPlayerO;
    [SerializeField] private GameObject _winTextTie;

    //переделать надо
    private void Awake()
    {
        switch (DataHolder.result)
        {
            case FieldPartState.PlayerX:
                Instantiate(_winTextPlayerX, gameObject.transform);
                break;
            case FieldPartState.PlayerO:
                Instantiate(_winTextPlayerO, gameObject.transform);
                break;
            case FieldPartState.Tie:
                Instantiate(_winTextTie, gameObject.transform);
                break;
        }

    }

}
