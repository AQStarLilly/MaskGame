using UnityEngine;

[CreateAssetMenu(fileName = "NewMask", menuName = "Masks/Mask")]
public class Mask : ScriptableObject
{
    public string maskName;
    public MaskType maskType;



    //[TextArea]
    //public string description;
}

