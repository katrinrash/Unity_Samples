using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CombVizualizer : MonoBehaviour
{ 
    public TextMeshProUGUI targetComboText;
    public TextMeshProUGUI choicesText;

    private CombGenerator combGenerator = new CombGenerator();
    public List<string> targetCombination { get; private set; }

    void Start()
    {
        CreateTarget();
    }

    public void CreateTarget()
    {
        targetCombination = combGenerator.GenerateCombination();
        targetComboText.text = "Your Target: " + string.Join(" ", targetCombination);
        choicesText.text = "Your Choices: ";

        MiniGameManager.Instance.Init();
    }

    public void UpdateChoicesText(string value)
    {
        choicesText.text += value + " ";
    }

}
