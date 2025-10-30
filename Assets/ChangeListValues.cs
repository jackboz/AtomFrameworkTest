using UnityEngine;
using UnityAtoms.BaseAtoms;

public class ChangeListValues : MonoBehaviour
{
    [SerializeField] private IntValueList _intValueList;

    void Awake()
    {
        if (_intValueList == null)
        {
            Debug.LogError("IntValueList is not assigned");
            return;
        }

        for (int i = 0; i < _intValueList.List.Count; i++)
        {
            Debug.Log("IntValueList[" + i + "] = " + _intValueList.List[i]);
        }

        _intValueList.List[0] = 1;
    }
}
