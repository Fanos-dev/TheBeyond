using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class ModifyText : MonoBehaviour
{
    public TMP_Text yearText;
    public TMP_Text titleText;
    
    public GameObject back;

    public GameObject e;

    public GameObject r;

    public GameObject lifeUI;

    public GameObject titleUI;
    
    public int count;

    private string _year;
    private string _title;

    public void Update()
    {
        //Controls
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        back.SetActive(value: count > 2);
        if (Input.GetKeyDown(KeyCode.E) && count < 32f)
        {
            count += 1;
        }
        if (Input.GetKeyDown(KeyCode.Q) && count >= 2f)
        {
            count -= 1;
        }
        
        //UI set active
        lifeUI.SetActive(value: count > 0);
        titleUI.SetActive(value: count > 0);
        
        //Title control
        Title();
        
        //Years control
        switch (count) 
        {
            case 1:
                Birth();
                break;
            case 2:
                Year1();
                break;
            case 3:
                Year2();
                break;
            case 4:
                Year3();
                break;
            case 5:
                Year4();
                break;
            case 6:
                Year5();
                break;
            case 7:
                Year6();
                break;
            case 8:
                Year7();
                break;
            case 9:
                Year8();
                break;
            case 10:
                Year9();
                break;
            case 11:
                Year10();
                break;
            case 12:
                Year11();
                break;
            case 13:
                Year12();
                break;
            case 14:
                Year13();
                break;
            case 15:
                Year14();
                break;
            case 16:
                Year15();
                break;
            case 17:
                Year16();
                break;
            case 18:
                Year17();
                break;
            case 19:
                Year18();
                break;
            case 20:
                Year19();
                break;
            case 21:
                Year20();
                break;
            case 22:
                Year21();
                break;
            case 23:
                Year22();
                break;
            case 24:
                Year23();
                break;
            case 25:
                Year24();
                break;
            case 26:
                Year25();
                break;
            case 27:
                Year26();
                break;
            case 28:
                Year27();
                break;
            case 29:
                Year28();
                break;
            case 30:
                Year29();
                break;
            case 31:
                Year30();
                break;
            case 32:
                Limbo();
                break;
        }
        
        yearText.text = _year;
        titleText.text = _title;
    }
    
    //Title text for game
    private void Title()
    {
        _title = count switch
        {
            1 => "Birth",
            2 => "Year 1 of 30",
            3 => "Year 2 of 30",
            4 => "Year 3 of 30",
            5 => "Year 4 of 30",
            6 => "Year 5 of 30",
            7 => "Year 6 of 30",
            8 => "Year 7 of 30",
            9 => "Year 8 of 30",
            10 => "Year 9 of 30",
            11 => "Year 10 of 30",
            12 => "Year 11 of 30",
            13 => "Year 12 of 30",
            14 => "Year 13 of 30",
            15 => "Year 14 of 30",
            16 => "Year 15 of 30",
            17 => "Year 16 of 30",
            18 => "Year 17 of 30",
            19 => "Year 18 of 30",
            20 => "Year 19 of 30",
            21 => "Year 20 of 30",
            22 => "Year 21 of 30",
            23 => "Year 22 of 30",
            24 => "Year 23 of 30",
            25 => "Year 24 of 30",
            26 => "Year 25 of 30",
            27 => "Year 26 of 30",
            28 => "Year 27 of 30",
            29 => "Year 28 of 30",
            30 => "Year 29 of 30",
            31 => "Year 30 of 30",
            32 => "Limbo",
            _ => _title
        };
    }
    
    
    private void Birth()
    {
        _year = "Your birth was successful. Your parents are very happy.";
    }
    
    private void Year1()
    {
        _year = "Your parents are restless as you have kept them up in the night. They despise you!";
    }

    private void Year2()
    {
        _year = "You still can't walk or crawl yet. Your parents are worried you might be dumb.";
    }
    private void Year3()
    {
        _year = "Thanks to your mother's friends, your thinking level is higher than the average seven-year-old.";
    }
    
    private void Year4()
    {
        _year = "Your dad felt left out, so he took you to watch Deadpool. " +
                "You have learned more than you should have and were terrified " +
                "for the rest of the year.";
    }
    
    private void Year5()
    {
        _year = "On the first day of kindergarten," +
                " you wet your pants because the teacher said" +
                " 'SILENCE' so you stayed put. Everyone teases you now.";
    }
    
    private void Year6()
    {
        _year = "After last year's event, you hate everyone, so you dominated them to count to one hundred.";
    }
    
    private void Year7()
    {
        _year = "Your mother thinks you study too hard for a seven-year-old. " +
                "She took you to the park. You found out you have severe allergies to nature.";
    }
    
    private void Year8()
    {
        _year = "You found a book in the library about 'The Beyond.'" +
                " The book significantly impacts you, so you become very religious.";
    }
    
    private void Year9()
    {
        _year = "You have joined the Maths club in school. Your teachers motivate you to do their taxes with gold stars.";
    }
    
    private void Year10()
    {
        _year = "You turned ten, so your mother bought you an original Ben Ten Omnitrix. " +
                "You are the happiest person in the world.";
    }
    
    private void Year11()
    {
        _year = "Dad got a promotion. Your family celebrates by going on a " +
                "family vacation to the Bahamas, nothing too special.";
    }
    
    private void Year12()
    {
        _year = "You started noticing the girls in your class, but you still are friendless, so don't worry.";
    }
    
    private void Year13()
    {
        _year = "Puberty has struck. Your face looks like a warzone. " +
                "Your parents comfort you, but you have a mood swing at them.";
    }
    
    private void Year14()
    {
        _year = "Your mother's work at making you bright when you were young has worn off." +
                " Your IQ level is now below the average person's.";
    }
    
    private void Year15()
    {
        _year = "You now have friends who can relate to you. This makes you feel important.";
    }
    
    private void Year16()
    {
        _year = "Love is in the air. A girl has asked you out for Prom. " +
                "You eagerly agree. Surprisingly, she doesn't leave you for Brad. Everything went well.";
    }
    
    private void Year17()
    {
        _year = "The last year of high school is challenging, " +
                "but through some clever cheat notes you pass. Your friends are happy that you helped them.";
    }
    
    private void Year18()
    {
        _year = "You are taking a break before college. You decided to work at the local McDonald's.";
    }
    
    private void Year19()
    {
        _year = "The girl in High school is now your girlfriend. You started college with high morale.";
    }
    
    private void Year20()
    {
        _year = "You came across a Youtube video about a guy who drinks a lot of milk, " +
                "and you are now milk gang. Your parents are very proud of your journey so far.";
    }
    
    private void Year21()
    {
        _year = "College is easy, so you have more time with your girlfriend. " +
                "Some old friends offer you green grass, but you kindly say no.";
    }
    
    private void Year22()
    {
        _year = "Your parents phone you to tell you that you have a baby sister. " +
                "You ponder this conversation for the next few days instead of studying for finals.";
    }
    
    private void Year23()
    {
        _year = "You pass your final exam with average marks. " +
                "You see your family afterward. Your parents ask you to pay up for your childhood. You are now in debt.";
    }
    
    private void Year24()
    {
        _year = "You get a high-paying job through some old contacts in school. " +
                "You quickly pay off your debt to your parents since you were cheap.";
    }
    
    private void Year25()
    {
        _year = "You propose to your girlfriend. She said, 'Yes.' " +
                "You will have a honeymoon in Paris. Life is going well for you. You find your old book on 'The Beyond.'";
    }
    
    private void Year26()
    {
        _year = "You are promoted twice. You remember when you almost joined a gang. " +
                "You celebrate with your family until your wife says she is pregnant.";
    }
    
    private void Year27()
    {
        _year = "You are shocked to find out you have twin boys. " +
                "You are thrilled. The news is filled with Pewdiepie being on top again. Is this a sign?";
    }
    
    private void Year28()
    {
        _year = "The past few years were crazy for you. Your sister visits for a playdate with your boys.";
    }
    
    private void Year29()
    {
        _year = "You are highly praised for your work. You are awarded a gold medal. " +
                "You find your old Ben Ten watch, so you hide it for your sons to find.";
    }
    
    private void Year30()
    {
        _year = "You find many references to 'The Beyond'. You work hard to be a good person throughout the year. " +
                "On Christmas day, you slip into the bathroom and hit your head on the toilet.";
    }
    
    private void Limbo()
    {
        _year = @"Enter limbo

        You have a choice…";
        if (count == 32)
        {
            e.SetActive(value: false);
            r.SetActive(value: true);
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(sceneBuildIndex: 1);
            }
        }
        else
        {
            count -= 1;
            e.SetActive(value: true);
            r.SetActive(value: false);
        }
    }
}
