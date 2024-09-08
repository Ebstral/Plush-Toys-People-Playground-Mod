using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;
using TMPro;
using UnityEngine.UI;

namespace Mod
{
    public class Mod
    {
        public static void Main()
        {
            CategoryBuilder.Create("Plush", "Cool Plush Toys", ModAPI.LoadSprite("category icon.png"));

            ModAPI.Register(
                           new Modification()
                           {
                               OriginalItem = ModAPI.FindSpawnable("Plastic Barrel"),
                               NameOverride = "Samira",
                               DescriptionOverride = "Samira is very tired(",
                               CategoryOverride = ModAPI.FindCategory("Plush"),
                               ThumbnailOverride = ModAPI.LoadSprite("icn/Samira.png"),
                               AfterSpawn = (Instance) =>
                               {
                                   Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("plush/Samira.png");
                                   Instance.FixColliders();                                  
                                                              
                               }
                           }
                       );
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Plastic Barrel"),
                    NameOverride = "Vasilisa",
                    DescriptionOverride = "Good captain, now bring me some coffee and meow.",
                    CategoryOverride = ModAPI.FindCategory("Plush"),
                    ThumbnailOverride = ModAPI.LoadSprite("icn/Vasilisa.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("plush/Vasilisa.png", 1f);
                        Instance.FixColliders();

                    }
                }
            );
                ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Plastic Barrel"),
                    NameOverride = "Kate",
                    DescriptionOverride = "Good HOS.. it's rare to come across someone like that.",
                    CategoryOverride = ModAPI.FindCategory("Plush"),
                    ThumbnailOverride = ModAPI.LoadSprite("icn/Kate.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("plush/Kate.png", 1f);
                        Instance.FixColliders();

                    }
                
                }
            ); 
                ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Plastic Barrel"),
                    NameOverride = "Koryo",
                    DescriptionOverride = "The cutest botanist.",
                    CategoryOverride = ModAPI.FindCategory("Plush"),
                    ThumbnailOverride = ModAPI.LoadSprite("icn/Koryo.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("plush/Koryo.png", 1f);
                        Instance.FixColliders();

                    }
                }
            ); 
                ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Plastic Barrel"),
                    NameOverride = "Sasha",
                    DescriptionOverride = "A professional in their field.",
                    CategoryOverride = ModAPI.FindCategory("Plush"),
                    ThumbnailOverride = ModAPI.LoadSprite("icn/Sasha.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("plush/Sasha.png", 1f);
                        Instance.FixColliders();

                    }
                }
            );
                ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Plastic Barrel"),
                    NameOverride = "Yuna",
                    DescriptionOverride = "A responsible Head of Personnel.",
                    CategoryOverride = ModAPI.FindCategory("Plush"),
                    ThumbnailOverride = ModAPI.LoadSprite("icn/Yuna.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("plush/Yuna.png", 1f);
                        Instance.FixColliders();

                    }
                }
            );
        
        
        
        
       
        
        
 
        
        
        
        
        }












        public class MultipleSpriteHumanBehaviour : MonoBehaviour
        {
            public Texture2D[] Textures = new Texture2D[0];
            public PersonBehaviour person;
            public int CurrentTexture = -2;
            public int Scale = 1;

            void Start()
            {
                SetTexture();
            }

            public void SetTexture()
            {
                if (Textures.Length == 0)
                    return;

                if (CurrentTexture == -2)
                {
                    CurrentTexture = UnityEngine.Random.Range(0, Textures.Length);
                }
                person.SetBodyTextures(Textures[CurrentTexture], null, null, Scale);
                for (int i = 0; i < person.Limbs.Length; i++)
                {
                    person.Limbs[i].gameObject.GetComponent<PhysicalBehaviour>().RefreshOutline();
                }
            }
        }
    }
}
