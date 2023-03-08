using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterMenu : MonoBehaviour
{
  
  // Text fields
  public TextMeshProUGUI levelText, hitpointText, pesosText, upgradeCostText, xpText;

  //Logic
  private int currentCharacterSelection = 0;
  public Image characterSelectionSprite;
  public Image weaponSprite;
  public RectTransform xpBar;

  //Character Selection
  public void OnArrowCLick(bool right){
    if(right){
        currentCharacterSelection++;
        if(currentCharacterSelection == GameManager.instance.playerSprites.Count)
            currentCharacterSelection = 0;

        OnSelectionChanged();
    }
    else{

        currentCharacterSelection-- ;
        if(currentCharacterSelection < 0)
            currentCharacterSelection  = GameManager.instance.playerSprites.Count - 1;

        OnSelectionChanged();
    }
  }
  private void OnSelectionChanged(){
    characterSelectionSprite.sprite = GameManager.instance.playerSprites[currentCharacterSelection];
  }

  // Weapon Upgrade
  public void OnUpgradeClick(){
    //
  }

  //Update the character Information
  public void UpdateMenu(){

     //Weapon
     weaponSprite.sprite = GameManager.instance.weaponSprites[0];
     upgradeCostText.text = "NOT IMPLEMENTED";
     // Meta
     levelText.text = "NOT IMPLEMENTED";
     hitpointText.text = GameManager.instance.player.hitpoint.ToString();
     pesosText.text =  GameManager.instance.pesos.ToString();
     
     // xp Bar
     xpText.text = "NOT IMPLEMENTED";
     xpBar.localScale = new Vector3(0.5f, 0, 0);
  }
}
