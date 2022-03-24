using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    //[SerializeField] private string GeamName;
    //public int GeamValue;

    //[SerializeField] private int GeamAmount;

    // [SerializeField] private int collidedGeamValue;

    // void Start()
    // {
    //    GeamName = name.Substring(0, 4);
    //    switch (GeamName)
    //  {
    //     case "Gems_0":
    //         GeamValue = 1;
    //break;
    //   case "Gems_1":
    //       GeamValue = 5;
    //      break;
    //  case "Gems_2":
    //      GeamValue = 10;
    //      break;
    // case "Gems_3":
    //     GeamValue = 15;
    //     break;
    // case "Gems_4":
    //    GeamValue = 20;
    //   break;

    // }
    // }


    void OnTriggerEnter2D(Collider2D col)
    {
        score.coinAmount += 1;
        //Destroy(gameObject);

        if (col.gameObject.tag == "Player")
        {
            Playermovent.instance.speeddw(speed);

            Destroy(gameObject);

        }

    }
}
