using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_project_AP
{
    public class Player
    {

    }
    class Program
    {
        public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {
            Start();
            Encounters.FirstEncounter();
        }
        private static bool random;
        private static bool name;
        private static bool power;
        private static int health;
        private static void Start(bool power, bool name)
        {
            throw new NotImplementedException();
        }

        static void Start(int power, string name)
        {
            Console.WriteLine("Ender's Dungeon");
            Console.WriteLine("Name");
            currentPlayer.name = Console.ReadLine();
            Console.WriteLine("You awake in a cold, stone, dark room. You feel dazed and are having trouble remembering");
            Console.WriteLine("Anything about your past");
            if (currentPlayer.name == "")
                Console.WriteLine("You can't even remember you own name...");
            else
                Console.WriteLine("You know your name is " + currentPlayer.name);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You grope around in the darkness until you find a door handle. You feel some resistance as");
            Console.WriteLine("you turn the handle, but the rusty lock breaks with little effort. You see your captor");
            Console.WriteLine("Standing with his back to you outside the door");

            {
                static Random rand = new Random();
                //Encounters Generic


                //Encounters
                static void FirstEncounter()
                {
                    Console.WriteLine("You open the door and take a sword and charge toward your captor");
                    Console.WriteLine();
                    Console.ReadKey();
                    Combat(false, "Human Rouge", 1, 4);
                }

                {
                    string n = "";
                    int p = 0;
                    int h = 0;
                    if (random) ;
                    {

                    }
                    else
                    {
                        n = name;
                        p = power;
                        h = health;
                    }
                    while (h > 0)
                    {
                        Console.WriteLine("=====================");
                        Console.WriteLine("| (A)ttack (D)efend |");
                        Console.WriteLine("| (R)un      (H)eal |");
                        Console.WriteLine("=====================");
                        Console.WriteLine("potions: " + Program.currentPlayer.potions + " Health: " + Program.currentPlayer.health);
                        string input = Console.ReadLine();
                        if (input.ToLower() == "a" || input.ToLower() == "attack")
                        {
                            //Attack
                            Console.WriteLine("How dare you attack me, Die you foul creature! As you pass, the " + n + " strikes you back ");
                            int damage = p - Program.currentPlayer.armorValue;
                            if (damage < 0)
                                damage = 0;
                            int attack = rand.Next(0, currentPlayer.weaponValue) + rand.Next(1, 4);
                            Console.WriteLine("You lose " + damage + "health and deal " + attack + " damage");
                            Program.currentPlayer.health -= damage;
                            h -= attack;
                        }
                        else if (input.ToLower() == "d" || input.ToLower() == "defend")
                        {
                            //Defend
                            Console.WriteLine("As the " + n + "its impossible to hurt me with your attacks!");
                            int damage = (p / 4) - Program.currentPlayer.armorValue;
                            if (damage < 0)
                                damage = 0;
                            int attack = rand.Next(0, currentPlayer.weaponValue) / 2;
                            Console.WriteLine("You lose " + damage + "health and deal " + attack + " damage");
                            Program.currentPlayer.health -= damage;
                            h -= attack;
                        }
                        else if (input.ToLower() == "r" || input.ToLower() == "run")
                        {
                            //Run
                            if (rand.Next(0, 2) == 0)
                            {
                                Console.WriteLine("When you sprint aways from the " + n + ", Its strike cathes you in the back, now is the perfect time to run!");
                                int damage = p - Program.currentPlayer.armorvalue;
                                if (damage < 0)
                                    damage = 0;
                                Console.WriteLine("You lose " + damage + "health and are unable to escape.");
                                Console.ReadKey();
                                //go to store
                            }
                            else
                            {
                                Console.WriteLine("You use your agile ninja moves to evade the " + n + " and you succesfully escape!");

                            }
                        }
                        else if (input.ToLower() == "h" || input.ToLower() == "heal")
                        {
                            //Heal
                            if (Program.currentPlayer.potion == 0)
                            {
                                Console.WriteLine("As you desperately grasp for a potion in your bag, all that you can do is using performanace of a 1000 healing priestess!");
                                int damage = p - Program.currentPlayer.armorvalue;
                                if (damage < 0)
                                    damage = 0;
                                Console.WriteLine("The " + n + " strikes you with a heavy hit and you lose" + damage + " health!");
                            }
                            else
                            {
                                Console.WriteLine("You can reach into your bag and pull out a glowing , black flask. You take a long drink.");
                                int health =
                                Console.WriteLine("You obtain " + health + " health");
                                {

                                }
                            }
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
    }




