using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Banner", menuName = "Banner/New Banner")]

public class BannerManager : ScriptableObject
{
   [SerializeField] Image bannerImage;
   [SerializeField] string bannerName;
   [SerializeField] Image[] featuredCharacters; 
   public List <UnitManager> bannerUnits = new List<UnitManager>();
}
