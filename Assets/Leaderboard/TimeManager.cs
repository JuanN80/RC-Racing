using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class recordManager : MonoBehaviour
{

    private double record;
    [SerializeField] TextMeshProUGUI inputScore;
    [SerializeField] TMP_InputField inputName;
    
    void Start()
    {
        record = SaveManager.instance.BestLapTime;
        record = (int) record;
        inputScore.SetText(record.ToString());

    }

    public UnityEvent<string, int> submitScoreEvent;

    public void SubmitScore()
    {
        submitScoreEvent.Invoke(inputName.text, int.Parse(inputScore.text));



    }
    



}
