# Game24

[VP] Game24 ############################################################################################# Македонски:
1.Опис на апликацијата
Развиената апликација е класична игра со карти, која е проширена во дополнителни 3 варијанти на истата: Practice Mode, Time Attack, и Brain Crunch (исто така се работи на Multiplayer верзија на играта). Со цел обезбедување на комплетно задоволство кај играчот, покрај едноставниот дизајн, имплементирани се различни алгоритми соодветни за варијантите на играта и High Score за сите веријанти на играта.Исто така, може да се аплицира и за усовршување на четирите аритметички операции во основните училишта , односно во реализација на програмата по Математика за второ и трето одделение.
2.Упатство за користење
2.1 Почнување на нова игра
На почетниот прозорец, при стартување на некоја варијанта на играта, имаме можност да ставиме наш прекар или име под кое ќе се чуваат и соодветните најдобри резултати (истите не можаат да бидат прегледани без да се заврши соодветната игра).
Доколку сакаме да започнеме нова Single Player игра, најпрво треба да се избере и кој тип на игра ќе го започнеме, односно:
•	Practice Mode
•	Time Attack
•	Brain Crunch
2.2 High Score
Тука се чуваат најдобрите 10 играчи, сортирани според најдоброто време (Brain Crunch) и според бројот на освоени поени(Time Attack).
После секоја завршена игра се појавува MessageBox што ни дава информации за нашиот резултат во дадената игра, а потоа се појавува формата каде што се чуваат најдобрите 10 играчи за дадената категорија. По завршување на играта, корисникот има можност да ги ресетира резултатите во соодветната категорија.
Резултатите се serializable. Тоа значи дека по исклучување на апликацијата, тие се ажурираат, и новата верзија се запишува врз старата.
2.3 Правила на играта
Правилата се едноставни: -Треба да се изкористат сите четири карти (цифри) -Изразот мора да биде точно напишан -Вредноста на изразот треба да биде еднаков на 24
3. Упатство за користење
3.1 Податочни структури
Главните податоци и функции за играта се чуваат во класата Game24, со која се претставени сите варијанти на играта. Секоја променлива и функција содржи краток коментар со објаснување.
public class Game24 
{
    public Dictionary<String,String> combinations; //Dictionary of all solvable combinations with one possible solution
    public int Card1 {get ;set;} //Value of first card
    public int Card2 {get ;set;} //Value of second card
    public int Card3 {get ;set;} //Value of third card
    public int Card4 {get; set;} //Value of fourth card
    public Random rand; //Random used to generate digits
    public string combination; //String with the chosen combination (digits ordered in ascending order) 

    public Game24() {
        rand = new Random();
        combinations = new Dictionary<string,string>();
        combination = null;
        loadSolutions();

    }

    // Read the <Key,Value> pair for all solvable puzzles of Game24 where Key is the combination solution , Value is the solution
    private void loadSolutions() {
        string line;
        System.IO.StreamReader file =
                new System.IO.StreamReader("combinations.txt");
        while ((line = file.ReadLine()) != null)
        {
            string[] parts = line.Split("\t".ToCharArray());
            if (combinations.ContainsKey(parts[0]) == false)
                combinations.Add(parts[0], parts[1]);

        }

        file.Close();
    }

    //Generate a new solvable puzzle
    public void Generate() {
        do
        {
            Card1 = rand.Next(1, 10);
            Card2 = rand.Next(1, 10);
            Card3 = rand.Next(1, 10);
            Card4 = rand.Next(1, 10);

            List<int> lis = new List<int>();
            lis.Add(Card2);
            lis.Add(Card1);
            lis.Add(Card3);
            lis.Add(Card4);
            lis.Sort();
            combination = ""+lis.ElementAt(0) + lis.ElementAt(1) + lis.ElementAt(2) + lis.ElementAt(3);

        } while (!combinations.ContainsKey(combination));
        
    }

    //Override of ToString method
    public override string ToString()
    {
        return String.Format("{0} {1} {2} {3}", Card1, Card2, Card3, Card4);
    }
    
    //Solution for given combination
    public string getSolution()
    {
        return combinations[combination];
    }
}
3.2 Сериализација
За некои податоци да бидат достапни и по терминација на програмата, искористивме бинарна сериализација.
Кога играчот за прв пат ја вклучува апликацијата на својот компјутер, кај него се креираат 2 документи за High Score, едниот за Brain Crunch, другиот за Time Attack, кои се ажурираат само во извршната верзија, а за време на затворањето на апликацијата, новите верзии од резултатите се сериализираат во нивните респективни фајлови. За еден објект да можеме да го сериализираме, потребно е класата од која е инстанциран да биде сериализабилна. За читање на веќе внесени податоци во овие фајлови се повикува методот Deserialize(); со FileStream од содржината на сериализираниот фајл како аргумент. Излезот од овој метод се кастира како соодветен објект и се доделува на веќе инстанциран null објект од иста класа.
3.3 Алгоритми и методи
За да биде целосна играта на Game24 имплементирани се различни алгоритми за генерирање и валидирање на успешно решение.
•	Generate: Со повикуавање на овој метод (функција), на случаен начин се генерираат 4 нови вредности и се проверува дали дадената комбинација има решение. Ако нема, тогаш се генерираат нови 4 вредности се додека дадената комбинација нема решение.
•	getSolution: Со повикување на овој метод (функција), се пребарува низ дефинираниот речник за едно можно решение за дадената комбинација од цифри. Овој метод е достапен и се повикува само во Practice Mode.
3.4 GUI
За претставување на играта користиме buttons кои ги представуваат картите и операторите кои можаат да се користат во играта.
#############################################################################################

