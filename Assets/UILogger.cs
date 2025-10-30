using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

public class UILogger : MonoBehaviour
{
    [SerializeField] private IntValueList _intValueList;
    [SerializeField] private Text _label1;
    [SerializeField] private Text _label2;

    void Start()
    {
        if (_intValueList == null)
        {
            Debug.LogError("IntValueList is not assigned");
            return;
        }

        if (_intValueList.List.Count < 2)
        {
            Debug.LogError("IntValueList must have at least 2 values");
            return;
        }

        _label1.text = _intValueList.List[0].ToString();
        _label2.text = _intValueList.List[1].ToString();
    }

    public void UpdateLabels()
    {
        if (_intValueList.List.Count < 2)
        {
            Debug.LogError("IntValueList must have at least 2 values");
            return;
        }

        _label1.text = _intValueList.List[0].ToString();
        _label2.text = _intValueList.List[1].ToString();
    }
}
