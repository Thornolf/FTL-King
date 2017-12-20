using System.Collections.Generic;
using System.Xml;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Script
{
    public class TradeModule : EventModule
    {   
        public List<Character> Traders;
        public Text DialogBoxText;
        public Item ItemToSell;
        
        void Start()
        {
            CharacterGenerator g = new CharacterGenerator();
            Traders = new List<Character>();
            int LimitCharacter = UnityEngine.Random.Range(0, 12);
            ItemToSell = g.Tables.AllItems[UnityEngine.Random.Range(0, g.Tables.AllItems.Count)];
            
            for (int i = 0; i < LimitCharacter; i++)
            {
                Traders.Add(g.GenerateRandomCharacter());
            }
            UpdatingDialogBoxText();
        }

        public void UpdatingDialogBoxText()
        {
            DialogBoxText.text = "Hi ! Do you want to buy " + ItemToSell.Name + " for " + ItemToSell.Price.Coins + "coin";
        }

        public void BuyingPositive()
        {
            if (gameManager.ActualPlayer.MainCharacter.CoinsMoney.Coins >= ItemToSell.Price.Coins)
            {
                Debug.Log("Player main Character bought " + ItemToSell.Name + "for an amount of " + ItemToSell.Price.Coins);
                TradeAnItem(gameManager.ActualPlayer.MainCharacter, ItemToSell);
            }
            else
            {
                Debug.Log("Player main Character doesn't have enough money");
                DialogBoxText.text = "Sorry but you don't have enough money !";
            }
            CloseTheDeal();
        }

        public void BuyingNegative()
        {
            Debug.Log("You don't buy anything and leave");
            CloseTheDeal();
        }
        
        public Character TradeAnItem(Character Buyer, Item ItemToSell)
        {
            Buyer.CoinsMoney.Coins -= ItemToSell.Price.Coins;
            Buyer.Inv.Invent.Add(ItemToSell);
            return (Buyer);
        }

        public void CloseTheDeal()
        {
            SceneManager.LoadScene("MainLevel");
        }
    }
}