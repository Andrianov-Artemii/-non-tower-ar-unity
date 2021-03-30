using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obvodka : MonoBehaviour
{
    public GameObject bezobvodki;
    public GameObject cobvodkoy;
    public bool torf;
    
    public void vkluchitobvodky()
    {
        bezobvodki.SetActive(false);
        cobvodkoy.SetActive(true);
        torf = true;

    }

    public void vikluchitobvodky()

    {
        bezobvodki.SetActive(true);
        cobvodkoy.SetActive(false);
        torf = false;

    }

    public void obvodka123()
    {
        if (torf == true)
        {
            vikluchitobvodky();
        }
        else
        {
            vkluchitobvodky();
        }
    }
    
    

    // Start is called before the first frame update
    void Start()
    {
        vikluchitobvodky();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
