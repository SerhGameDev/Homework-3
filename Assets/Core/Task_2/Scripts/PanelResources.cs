using UnityEngine;
using UnityEngine.UI;

public class PanelResources : MonoBehaviour
{
    [SerializeField] private Image _imageIconResources;
    [SerializeField] private IconResources _iconResources;
    [SerializeField] private TypeIconResources _iconResourcesType;

    private void Start()
    {
        _imageIconResources.sprite = _iconResources.Get(_iconResourcesType);
    }
}
