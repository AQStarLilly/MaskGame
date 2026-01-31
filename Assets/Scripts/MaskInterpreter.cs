using UnityEngine;

public class MaskInterpreter : MonoBehaviour
{
    [SerializeField] private Mask maskData;

    public MaskType MaskType => maskData.maskType;
    public string MaskName => maskData.maskName;
 
    public Mask MaskData => maskData;

    private void OnValidate()
    {       
        if (maskData != null)
            gameObject.name = "Mask_" + maskData.maskType.ToString();
    }
}
