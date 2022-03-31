using UnityEngine;
using UnityEngine.UI;

public class FinishTitle : MonoBehaviour
{
    [SerializeField] private Text winnerText;

    private void Awake()
    {
        if (winnerText == null)
        {
            winnerText = GetComponent<Text>();
        }

        switch (DataHolder.Winner)
        {
            case FieldPartState.PlayerX:
                winnerText.text = "Крестики победили!";
                winnerText.color = new Color(155, 255, 249, 255) / 255f;
                break;
            case FieldPartState.PlayerO:
                winnerText.text = "Нолики победили!";
                winnerText.color = new Color(255, 129, 220, 255) / 255f;
                break;
            case FieldPartState.Tie:
                winnerText.text = "Ничья!";
                winnerText.color = new Color(134, 129, 255, 255) / 255f;
                break;
        }

    }

}
