using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaysManager : MonoBehaviour
{
    public static event Action<DayContentSO> OnDayChanged;
    public List<DayContentSO> days;

    public DayContentSO CurrentDay { get; private set; }
    public int CurrentDayIndex { get; private set; }
    public static DaysManager Instance { get; private set; }
    public static bool InstanceExists => Instance != null;
    public PlayerController playerController;
    [SerializeField] private GameObject finishBtn;
    [SerializeField] private GameObject reportBtn;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        CurrentDayIndex = 0;
        LoadDay(CurrentDayIndex);
    }

    public void LoadDay(int dayIndex)
    {
        CurrentDay = days[dayIndex];
        OnDayChanged?.Invoke(CurrentDay);
        finishBtn.SetActive(false);
        reportBtn.SetActive(false);
    }

    public void NextDay()
    {
        CurrentDayIndex++;
        
        if (CurrentDayIndex < days.Count)
        {
            LoadDay(CurrentDayIndex);
        }

        if (playerController != null)
        {
            playerController.ResetPlayerPosition();
        }
    }

    public void ResetDay()
    {
        CurrentDayIndex = 0;
    }

}
