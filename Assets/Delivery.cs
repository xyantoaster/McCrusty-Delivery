using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Delivery : MonoBehaviour
{
    public Driver driver;
    bool hasCrustyMeal = false;
    // *HouseDelivered bools
    bool brownHouseDelivered = false;
    bool blueHouseDelivered = false;
    bool redHouseDelivered = false;
    bool greenHouseDelivered = false;
    bool pinkHouseDelivered = false;
    bool house705Delivered = false;
    bool house706Delivered = false;
    bool house707Delivered = false;
    bool house708Delivered = false;
    bool house709Delivered = false;
    bool house710Delivered = false;
    bool house711Delivered = false;
    // end *HouseDelivered bools
    string whichCrustyMeal;
    public TextMeshProUGUI deliverText;
    public TextMeshProUGUI deliveredAmt;
    int crustyMealsDelivered = 0;
    public int hits;
    // TIMER Vars
    public static Delivery instance;
    public TextMeshProUGUI timerText;
    public Canvas timerTextCanvas;
    private TimeSpan timePlaying;
    private bool timerGoing;
    private float elapsedTime;
    public GameObject fadeOutObject;
    public GameObject deliverTextObj;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(timerText);
        DontDestroyOnLoad(timerTextCanvas);
    }

    private void Start()
    {
        timerText.text = "Time: 00:00.00";
        timerGoing = false;

        BeginTimer();
    }

    public void BeginTimer()
    {
        timerGoing = true;
        elapsedTime = 0f;

        StartCoroutine(UpdateTimer());
    }

    public IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'fff");
            timerText.text = timePlayingStr;

            yield return null;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "speedChanger")
            StartCoroutine(ChangeSpeed());

        else if (other.tag == "CrustyMeal" && !hasCrustyMeal)
        {
            Debug.Log("Crusty Meal Obtained!");
            hasCrustyMeal = true;
            whichCrustyMeal = other.name;
            FigureOutWhichCrustyMeal();
            Destroy(other.gameObject);
        }
        else if (other.tag == "McCrusty" && crustyMealsDelivered == 12)
        {
            FinishGame();
        }
        else if (other.tag == "house" && hasCrustyMeal)
        {

            if (other.name == "Brown Delivery spot" && !brownHouseDelivered && whichCrustyMeal == "CrustyMeal (3)")
            {
                brownHouseDelivered = true;
                hasCrustyMeal = false;
                Debug.Log("Crusty Meal Delivered to Brown House");
                crustyMealsDelivered++;
                deliverText.text = "Pick up another Crusty Meal!";
            }
            else if (other.name == "Blue Delivery spot" && !blueHouseDelivered && whichCrustyMeal == "CrustyMeal")
            {
                blueHouseDelivered = true;
                hasCrustyMeal = false;
                Debug.Log("Crusty Meal Delivered to Blue House");
                crustyMealsDelivered++;
                deliverText.text = "Pick up another Crusty Meal!";
            }
            else if (other.name == "Red Delivery spot" && !redHouseDelivered && whichCrustyMeal == "CrustyMeal (5)")
            {
                redHouseDelivered = true;
                hasCrustyMeal = false;
                Debug.Log("Crusty Meal Delivered to Red House");
                crustyMealsDelivered++;
                deliverText.text = "Pick up another Crusty Meal!";
            }
            else if (other.name == "Green Delivery spot" && !greenHouseDelivered && whichCrustyMeal == "CrustyMeal (7)")
            {
                greenHouseDelivered = true;
                hasCrustyMeal = false;
                Debug.Log("Crusty Meal Delivered to Green House");
                crustyMealsDelivered++;
                deliverText.text = "Pick up another Crusty Meal!";
            }
            else if (other.name == "Pink Delivery spot" && !pinkHouseDelivered && whichCrustyMeal == "CrustyMeal (2)")
            {
                pinkHouseDelivered = true;
                hasCrustyMeal = false;
                Debug.Log("Crusty Meal Delivered to Pink House");
                crustyMealsDelivered++;
                deliverText.text = "Pick up another Crusty Meal!";
            }
            else if (other.name == "705 Delivery spot" && !house705Delivered && whichCrustyMeal == "CrustyMeal (10)")
            {
                house705Delivered = true;
                hasCrustyMeal = false;
                Debug.Log("Crusty Meal Delivered to 705");
                crustyMealsDelivered++;
                deliverText.text = "Pick up another Crusty Meal!";
            }
            else if (other.name == "706 Delivery spot" && !house706Delivered && whichCrustyMeal == "CrustyMeal (8)")
            {
                house706Delivered = true;
                hasCrustyMeal = false;
                Debug.Log("Crusty Meal Delivered to 706");
                crustyMealsDelivered++;
                deliverText.text = "Pick up another Crusty Meal!";
            }
            else if (other.name == "707 Delivery spot" && !house707Delivered && whichCrustyMeal == "CrustyMeal (11)")
            {
                house707Delivered = true;
                hasCrustyMeal = false;
                Debug.Log("Crusty Meal Delivered to 707");
                crustyMealsDelivered++;
                deliverText.text = "Pick up another Crusty Meal!";
            }
            else if (other.name == "708 Delivery spot" && !house708Delivered && whichCrustyMeal == "CrustyMeal (9)")
            {
                house708Delivered = true;
                hasCrustyMeal = false;
                Debug.Log("Crusty Meal Delivered to 708");
                crustyMealsDelivered++;
                deliverText.text = "Pick up another Crusty Meal!";
            }
            else if (other.name == "709 Delivery spot" && !house709Delivered && whichCrustyMeal == "CrustyMeal (6)")
            {
                house709Delivered = true;
                hasCrustyMeal = false;
                Debug.Log("Crusty Meal Delivered to 709");
                crustyMealsDelivered++;
                deliverText.text = "Pick up another Crusty Meal!";
            }
            else if (other.name == "710 Delivery spot" && !house710Delivered && whichCrustyMeal == "CrustyMeal (1)")
            {
                house710Delivered = true;
                hasCrustyMeal = false;
                Debug.Log("Crusty Meal Delivered to 710");
                crustyMealsDelivered++;
                deliverText.text = "Pick up another Crusty Meal!";
            }
            else if (other.name == "711 Delivery spot" && !house711Delivered && whichCrustyMeal == "CrustyMeal (4)")
            {
                house711Delivered = true;
                hasCrustyMeal = false;
                Debug.Log("Crusty Meal Delivered to 711");
                crustyMealsDelivered++;
                deliverText.text = "Pick up another Crusty Meal!";
            }

        }
            
    }

    IEnumerator ChangeSpeed()
    {
        driver.moveSpeed = 24;
        yield return new WaitForSeconds(5);
        driver.moveSpeed = 16;

    }

    void FigureOutWhichCrustyMeal()
    {
        if (whichCrustyMeal == "CrustyMeal (3)")
            deliverText.text = "Deliver to: 700";
        if (whichCrustyMeal == "CrustyMeal")
            deliverText.text = "Deliver to: 701";
        if (whichCrustyMeal == "CrustyMeal (5)")
            deliverText.text = "Deliver to: 702";
        if (whichCrustyMeal == "CrustyMeal (7)")
            deliverText.text = "Deliver to: 703";
        if (whichCrustyMeal == "CrustyMeal (2)")
            deliverText.text = "Deliver to: 704";
        if (whichCrustyMeal == "CrustyMeal (10)")
            deliverText.text = "Deliver to: 705";
        if (whichCrustyMeal == "CrustyMeal (8)")
            deliverText.text = "Deliver to: 706";
        if (whichCrustyMeal == "CrustyMeal (11)")
            deliverText.text = "Deliver to: 707";
        if (whichCrustyMeal == "CrustyMeal (9)")
            deliverText.text = "Deliver to: 708";
        if (whichCrustyMeal == "CrustyMeal (6)")
            deliverText.text = "Deliver to: 709";
        if (whichCrustyMeal == "CrustyMeal (1)")
            deliverText.text = "Deliver to: 710";
        if (whichCrustyMeal == "CrustyMeal (4)")
            deliverText.text = "Deliver to: 711";
    }

    private void Update()
    {
        if (crustyMealsDelivered < 12)
            deliveredAmt.text = "Crusty Meals Delivered: " + crustyMealsDelivered;
        else
        {
            deliveredAmt.text = "";
            deliverText.text = "Return to McCrusty for your paycheck!";
        }
        if (SceneManager.GetActiveScene().name == "Finished" || SceneManager.GetActiveScene().name == "Menu")
        {
            EndTimer();
            Destroy(fadeOutObject.gameObject);
            deliverText.text = null;
            Destroy(deliverTextObj.gameObject);
            deliveredAmt.text = null;
            if(SceneManager.GetActiveScene().name == "Menu")
            {
                StartCoroutine(DelMenuObjects());
            }
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    IEnumerator DelMenuObjects()
    {
        Destroy(deliveredAmt.gameObject);
        Destroy(timerTextCanvas.gameObject);
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hits += 1;
    }

    public void EndTimer()
    {
        timerGoing = false;
    }

    void FinishGame()
    {
        SceneManager.LoadScene("Finished");
    }
}
