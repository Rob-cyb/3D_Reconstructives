using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public int maximum;
    public Image bar;
    private GameStateManager gsm;
    void Start()
    {
        gsm = FindObjectOfType<GameStateManager>();
    }

   
    void Update()
    {
        getCurrentFill();
    }

    void getCurrentFill()
    {
        float fillAmount = gsm.TrashScore/(float)maximum;
        bar.fillAmount = fillAmount;
    }
}
