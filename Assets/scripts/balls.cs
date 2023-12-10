using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class balls : MonoBehaviour 
{
    
    
    
    public void Red()
    {
        if (color.activeColor == 1)
        {
           color.score++;
            efects.red = true;
        }
        else
        {
            color.hp--;
        }
        Destroy(gameObject);
       
    }
    public void Blue()
    {
        if (color.activeColor == 2)
        {
            color.score++;
            efects.blue = true;
        }
        else
        {
            color.hp--;
        }
        
        Destroy(gameObject, 0.1f);
        
    }
    public void Green()
    {
        if (color.activeColor == 3)
        {
            color.score++;
            efects.green = true;
        }
        else
        {
            color.hp--;
        }
        Destroy(gameObject);
        
    }
    public void Purple()
    {
        if (color.activeColor == 4)
        {
            color.score++;
            efects.purple = true;
        }
        else
        {
            color.hp--;
        }
        Destroy(gameObject);
        
    }
}
   


