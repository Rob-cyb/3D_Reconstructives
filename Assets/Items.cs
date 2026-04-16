using UnityEngine;

public class Items : MonoBehaviour
{
    public KeyCode pickUp = KeyCode.P;
     private GameStateManager gsm;
     public bool PickUpArea = false;
    

    public void Start()
    {
        PickUpArea = false;
        gsm= GameObject.Find("GameStateManager").GetComponent<GameStateManager>(); 
    }
    private void OnTriggerEnter(Collider collision)
    {
         if (collision.gameObject.CompareTag("Player"))
        {
            PickUpArea = true;
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        PickUpArea = false;
    }

    public void Update()
    {
        if(PickUpArea == true){
    
         if (Input.GetKey(pickUp))
                {
                    if(gameObject.tag == "Benefit"){
                    gsm.adjustScore(1);
                    }
                    if(gameObject.tag == "Trash")
                {
                    gsm.adjustTrashScore(1);
                }
                    Destroy(gameObject);
                }
        }
    
    }

}
