using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConsoleDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            //there needs to be instances of our objects
            //to a)Roll and b) record the results of the
            // players' rolls.

            //recording players' rolls for history
            //the new causes the physical creation of the List<T> instance
             List<Turn> Turns = new List<Turn>();

            //we have a 2 player game
            //we need two dice, one per player
            Die[] dice = new Die[2];
            //fill the empty array elments with an instance of the dice
            dice[0] = new Die();  //default constructor of Die
            dice[1] = new Die(6, 3, "Green"); //greedy constructor of Die

            string menuChoice = "";
            do
            {
                Console.WriteLine("Game Menu:\n");
                Console.WriteLine("A) Set Die side count");
                Console.WriteLine("B) Roll the dice");
                Console.WriteLine("C) Display all game turn results");
                Console.WriteLine("X) Exit");
                Console.Write("Enter menu choice: ");
                menuChoice = Console.ReadLine();

                switch(menuChoice.ToUpper())
                {
                    case "A":
                        {
                            //this is a call to a method (subroutine)
                            //Since dice is an array, what is actually
                            //passd to the method is the address in memory
                            //of where the array physically exists
                            //Therefore any changes to the array data in the
                            //subroutine will be available to us on return
                            //from the subroutine.
                            SetDiceSides(dice);
                            break;
                        }
                    case "B":
                        {
                            //logic for a case can be placed within the case
                            //and have no method called

                            //roll the dice
                            //the contents of the array element is an
                            //instance of Die.
                            //Therefore when we access the element in the
                            //array we are actually touching the instance
                            //thus we can use the object dot operator
                            //and call a property or behaviour of the instance
                            dice[0].Roll();
                            dice[1].Roll();

                            //create a new instance of a turn
                            //each turn needs a physical different instance
                            //therefore the instance is created here on
                            //each turn instead of a global instance of the turn
                            Turn aturn = new Turn();

                            //recording the data from this turn
                            //property.set = property.get
                            aturn.Player1Roll = dice[0].FaceValue;
                            aturn.Player2Roll = dice[1].FaceValue;

                            //determine the turn winner
                            if (aturn.Player1Roll > aturn.Player2Roll)
                            {
                                aturn.Winner = "Player 1";
                            }
                            else if (aturn.Player1Roll < aturn.Player2Roll)
                            {
                                aturn.Winner = "Player 2";
                            }
                            else
                            {
                                aturn.Winner = "Draw";
                            }

                            //save the physical instance of this turn
                            //into the list of turns
                            Turns.Add(aturn);

                            Console.WriteLine(string.Format("Results: Player1 rolled: {0} Player2 rolled {1} Winner is {2}",
                                                                aturn.Player1Roll, aturn.Player2Roll, aturn.Winner));
                            break;
                        }
                    case "C":
                        {
                            DisplayGame(Turns);
                            break;
                        }
                    case "X":
                        {
                            int[] counts = new int [3];
                            foreach (var aturn in Turns)
                            {
                                if(aturn.Winner.Equals("Player1"))
                                {
                                    counts[0]++;
                                }
                                else if (aturn.Winner.Equals("Player2"))
                                {
                                    counts[1]++;
                                }
                                else
                                {
                                    counts[2]++;
                                }
                            }

                            Console.WriteLine("Player 1 wins {0} Player 2 {1} Draws {2}", counts[0], counts[1], counts[2]);
                            Console.WriteLine("Thank you for playing. Come again");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid menu choice. Retry.");
                            break;
                        }
                }
            } while (menuChoice.ToUpper() != "X");
            Console.ReadKey();
        }//eom

        public static void SetDiceSides(Die[] dice)
        {
            string facecount = "";
            int faces = 6;

            Console.WriteLine("Set dice face count to 6 or 12: ");
            Console.Write("Enter number of dice faces: ");
            facecount = Console.ReadLine();

            //validation
            if (string.IsNullOrEmpty(facecount))
            {
                Console.WriteLine("Did not enter any value. Retry.");
            }
            else if (int.TryParse(facecount, out faces))
            {
                if (faces == 6 || faces == 12)
                {
                    for (int x = 0; x < 2; x++)
                    {
                        dice[x].SetSides(faces);
                    }
                }
                else
                {
                    Console.WriteLine("Only allowable values are 6 or 12. Retry.");
                }
            }
            else
            {
                Console.WriteLine("Did not enter a number value. Retry.");
            }
        }//eom

        public static void DisplayGame(List<Turn> turns)
        {
            Console.WriteLine("This is the complete set of turns for this game.\n");

            //foreach() will traverse a collection from start to end
            //this loop will automatically move to the next item in the collection
            //there is no need for an index counter
            //the syntax of the loop is foreach(itemdatatype localitemname in collectionname)
            //this loop structure is great for any type of collection of unknown length
            //this is a Do While structure
            foreach(Turn aturn in turns)
            {
                Console.WriteLine(string.Format("Results: Player1 rolled: {0} Player2 rolled {1} Winner is {2}",
                                                               aturn.Player1Roll, aturn.Player2Roll, aturn.Winner));
            }
            Console.WriteLine("\n");

        }
    }
}
