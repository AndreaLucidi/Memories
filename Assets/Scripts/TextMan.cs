using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextMan : MonoBehaviour
{
    private bool showText = false;
    public GameObject Testo;

    void OnTriggerEnter(Collider other)
    {

        showText = true;

    }

    void Update()
    {
        if (showText)
        {
            if (name == "Text 1")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "When I entered into that helicopter, I knew that I would never get back home. I was sitting next to Billy and Johnny, my two childhood friends, and Billy was shaking...I tried to calm him, but it was useless “we all gonna die in that fucking jungle” he kept murmuring during all the trip “we all gonna die...”.";

                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "Text 2")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "We arrived during a massive attack and I saw a lot of US soldiers dying killed by those despicable Viet Congs: If we had never jump off that hill, we’d probably be killed by that gunfire too…";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "Text 4")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "Billy was screaming of fear while Johnny was very psyched up and he started shooting like a maniac, he killed 10 men with just one magazine and he was the happiest man on earth. After that battle we hidden ourselves into a foxhole: crawling was essential to survive...even through that fucking stinky mud.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "Text 5")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "Some hours later we (me and Johnny, Billy was in a faint) were went to examine a little area not very far from our military camp; we walked for less than an hour and we found a peaceful lake with some lotus flowers. Johnny sniggered and said “fuck this place, I miss my New Orleans” and he lighted up a cigarette.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "Text 7")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "I set down and I figured out that, in all this mess, I would only found peace by sitting next to this little lake on the right...gee, I love those Lotus flowers.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "Text 8")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "But there’s no peace in Vietnam...we had been attacked by a little army “Run Michael, run for fuck sake” Johnny screamed at me. We ran through that thick forest for I don’t know how much time and we found ourselves in a very little village. We were dressed like US soldiers so I thought “Ok they’re gonna kill us”...but the eldest lady come to us and whispered something in her language, then she took us into her hut: that woman saved us that cloudy day…I’ll never thank her enough for this!";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "Text 10")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "The morning after we decided to explore again, this time further from the village. The old lady gave us a dreamcatcher for good luck, she kinda reminded me my granny; We walked the entire day, just me and Johnny and we haven’t met an army or something like that...it was strange, really really strange; we arrived into an huge field and everything seemed so suspicious: Johnny was walking in front of me, but his mind was in clouds “I miss my girlfriend, she is…”";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "Text 11")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "He never finished that sentence...Johnny, why the hell you went to the right, that fucking mine killed you. I was crying like a baby by seeing his corpse distended for that bomb; my grandpa used to say “war gives, war takes” and he was so right. I went back from my steps and ran to the camp, the rage was massive but also the sadness. I kept telling me “he’s dead” at least forty times before starting believing in it.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "Text 13")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "I finally arrived and I immediately looked at Billy, he started to scream “no” and he hugged me. I felt nothing, I wasn’t able anymore because “war gives, war takes” was a law and I had to obey it. My Captain didn’t say a word and offered me some Irish Whiskey and I drank it all, almost. I felt good for some while because I know I wasn’t alone anymore so I looked Billy in his tearing eyes and I just said “I will kill the motherfuckers who did this Billy, I will fucking kill them all”.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "Text 14")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "Billy was a fragile soul, and he’s ginger hair already said it for him, he had tattooed his mother’s name on his armpit, “Helena”: I knew her, she used to make us lemonade every time we were at her house, what a lovely human being…Billy lost his mom because of breast cancer three years ago and this made him an orphan. His dad was a cop and, during a robbery, a bastard head-shot him: Billy was only 6 when this happened. He’s the best friend a man can wish for, I would kill and be killed to save his life.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "Text 16")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "There was this girl, she must have been 18 like me, that used to took us water and some crusts: we have been in that cell for two weeks and she came here every day to chat with us, she used to speak a very good english “Where are you from?” she gently asked “New Orleans” I replied while smiling “Never been there” she answered giggling; she smelled so good and her eyes were like two dark stars in the sky. I was in love? Yeah, maybe, why not.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "Text 17")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "She helped us and we escaped that prison without being caught…I don’t know what happened to her, she waved her hand from the distance and she was smiling. In those days of agony, she was my sunshine.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "Text 19")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "My mum used to write me every day and I think it was beautiful, she also send me some pictures of her and my lovely doggy, Sissy, I miss them both very much. Who I don’t miss at all is that asshole of my father, a stupid old mine worker. He hated me for no reason at all.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "Text 20")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "Billy was wasted by this situation. I have to stop one moment, this part of the story is not going to be fine for me: it was a June evening so me and Billy went to a waterfall to drink some beer and chat like we used to at New Orleans; gosh is so horrible to say, I can’t do this.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "Text 22")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "And then he jumped off that waterfall. My best friend killed himself right in front of me, I was speechless; I tried to look down to see if he was swimming, but what I saw was only his body slowly skimming. “FUCK” I screamed until my lungs collapsed and then I cried again…I decided to took some branches and made two symbolical crosses, one for Johnny and one for Billy: They weren’t just my two best friends, they were my family, my life - saving anchor, I’ll miss them forever and ever.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "Text 23")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "I went back to the camp alone and I went into Billy’s tent: there was a piece of paper and there was written “this is the end, my only friend, the end” God, he used to love that song…";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "Text 25")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "So now I was very alone: my two friends died and, during another mission, we lost 10 soldiers…so now we were only 18, like my age. We had this kind of mass grave on the left of our camp, and horrible mass grave full of crosses, I used to hate it so much.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "Text 26")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "After one year, we survived in 5. I was tired and so done with all these bullshits. I just want to EXIT this fucking period.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "WText 1")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "The first thing I noticed was a mass grave next to our camp, and I found it horrible...I can’t believe I may have been there one day or another…";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "WText 2")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "All the paths were exactly the same, It used to be very easy to get lost in that jungle so we decided to put some marks on the threes to never get lost again.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "WText 4")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "In New Orleans I have a very nice dog, her name is Sissy and I miss her every single day. She’s so happy everytime she sees me and I can’t wait to hug her again…";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "WText 5")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "Helping each other was the rule, anyone else will leave the weak ones behind...but not me, I’ll always give them an hand.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "WText 7")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "Sometimes we have to took a very precarious boat to pass through a river and one day our anchor got broken so we have to jump in the water and start swimming into the tempestuous brook, two of us died drowned, terrible experience.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "WText 8")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "One night I was sitting outside on patrol and I looked up to the sky...all those stars, they were so bright and stunning, I’ve never seen a sky as beautiful as this in New Orleans, who knows I would have found it in Vietnam?";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "WText 10")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "The worst parts of this war were the foxholes: they were dirty, rotten, stinky and tiny and the air was a miasma. I never thought this was gonna be my house for all these time, I bet I have hepatitis...for fuck sake.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "WText 11")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "It was an hot morning when my commander allow me to shoot with a bazooka from one of our helicopters and I was terrified: if I didn’t get the village with one hit they will know our position and kill us all. I was lucky,I destroyed the village...but, am I a monster?";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "WText 13")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "Everytime I keep saying my self “he’s dead”, my memories  went to the past. My granpa too was a soldier; I was a child when he died and at his  funeral I stayed all day long sitting on the ground next to his grave. I used to love him, he was a nice man. When the evening came my stomach started to grumble and so I walked to the cemetery’s gates but the doors were closed. I felt alone and abandoned.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "WText 14")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "Too many people were  dying in this fucking war. Suddenly a quote from my favorite wirter, Ernest Hemingway  came in my mind  “Never think that war, no matter how necessary, nor how justified, is not a crime.”";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "WText 16")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "We tried to escape by jumping off a little cliff but they took us just in time: I didn’t noticed that the cliff was little but just at the end of it, there was a tiger sleeping. That filthy Vietcong saved our U-ASS-A (saved our lives)";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "WText 17")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "Sometimes that girl used to took me some little presents, like food or some fresh water. But the biggest gift she use to gave me were one or two sigarettes that she stoled from her village’s army. She used to bring a pair of them: one for me and of course one for her. In those moments all the tension flyed away because she always thoughts about me.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "WText 19")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "The situation was going from bad to wrost, like there was no end. Immediatly I thought about that fucking lime that everyone uses here: sour as hell. And I was getting sour too, all because of this fucking war.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "WText 25")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "Inside Billy’s tent I found a dreamcatcher, like the one that the old Vietnamese lady gave us in that lost village. He should have been there, but how? Maybe God was sending me a sign: my friends were both dead, trapped in this dreamcatcher.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }
            }
            if (name == "WText 23")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "I went back to the camp alone and I went into Billy’s tent: there was a piece of paper and there was written “I look inside myself and see my heart is black” God, he used to love that song…";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }

            }
            if (name == "WText 22")
            {
                Testo.SetActive(true);
                Testo.GetComponentInChildren<Text>().text = "And then he jumped off that waterfall. My best friend killed himself right in front of me, I was speechless; I tried to look down to see if he was swimming, but what I saw was only his body slowly skimming. “FUCK” I screamed until my lungs collapsed and then I cried again…I decided to took some branches and made two symbolical crosses, one for Johnny and one for Billy: They weren’t just my two best friends, they were my family, my life - saving anchor, I’ll miss them forever and ever.";
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    showText = false;
                    Testo.SetActive(false);
                }

            }
        }

    }
}