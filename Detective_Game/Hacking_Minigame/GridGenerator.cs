using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public GameObject buttonPrefab;
    public Transform container;

    public List<GameObject> createdButtons;

    private string[] possibleElements = { "A7", "B5", "D9", "0E" };

    private int gridLength = 5;

    void Start()
    {
        GenerateGrid();
    }

    public void GenerateGrid()
    { 

        for (int i = 0; i < createdButtons.Count; i++)
        {
            createdButtons[i].transform.SetParent(container, false);
            createdButtons[i].SetActive(true);

            var buttonLogic = createdButtons[i].GetComponent<ButtonLogic>();

            buttonLogic.Setup(
                possibleElements[Random.Range(0, possibleElements.Length)], // Randomly selects an element from the array
                i / gridLength, // Row index
                i % gridLength // Column index
                );
        }

    }

    public void ResetGrid()
    {
        foreach (GameObject btn in createdButtons)
        {
            btn.GetComponent<ButtonLogic>().ResetButton(value: possibleElements[Random.Range(0, possibleElements.Length)]); 
        }
    }

}
