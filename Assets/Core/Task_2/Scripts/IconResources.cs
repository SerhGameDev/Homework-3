using UnityEngine;

[CreateAssetMenu(fileName = "Icon", menuName = "IconResources", order = 1)]
public class IconResources : ScriptableObject
{
    [SerializeField] private Sprite _iconRed;
    [SerializeField] private Sprite _iconBlue;
    [SerializeField] private Sprite _iconOrange;
    public Sprite Get(TypeIconResources typeIconResources)
    {
        switch(typeIconResources)
        {
            case TypeIconResources.Red:
                return _iconRed;
            case TypeIconResources.Blue:
                return _iconBlue;
            case TypeIconResources.Orange:
                return _iconOrange;
            default:
                return null;
        }
        
    }
}
