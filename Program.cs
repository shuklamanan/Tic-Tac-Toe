using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add
{
    public class tic_tac_toe
    {
        static void Main(string[] args)
        {
            string[] s = { "_", "_", "_", "_", "_", "_", "_", "_", "_" };
            Console.WriteLine("WELCOME TO TIC-TAC-TOE GAME WORLD");
            Dictionary<int,int> key = new Dictionary<int,int>();
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0) { Console.WriteLine(); }
                Console.Write(s[i]+ "   ");
            }
            Console.WriteLine();
            Console.WriteLine("Chhoose X or O");
            Console.Write("Player 1:");
            string player1 = Console.ReadLine();
            if (player1 != "X" && player1!="O")
            {
                Console.WriteLine("You entered wrong character for player 1");
                return;
            }
            string player2 = (player1 == "X") ? "O" : "X";
            Console.WriteLine("Player 2 has character : " + player2);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Positions of characters");
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0) { Console.WriteLine(); }
                Console.Write((i+1) + "   ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Created by Manan");
            for(int j=0 ; j < 10 ; j++)
            {
                if ((s[0] == s[4] && s[4] == s[8]) && (s[0]=="X" || s[0] == "O"))
                {
                    Console.WriteLine(s[0] + " wins!!! Congratulations "+ s[0]);
                    return;
                }
                else if ((s[2] == s[4] && s[4] == s[6]) && (s[2] == "X" || s[2] == "O"))
                {
                    Console.WriteLine(s[2] + " wins!!! Congratulations " + s[2]);
                    return;
                }
                else if ((s[0] == s[1] && s[1] == s[2]) && (s[1] == "X" || s[1] == "O"))
                {
                    Console.WriteLine(s[0] + " wins!!! Congratulations " + s[0]);
                    return;
                }
                else if((s[0] == s[3] && s[3] == s[6]) && (s[3] == "X" || s[3] == "O"))
                {
                    Console.WriteLine(s[0] + " wins!!! Congratulations " + s[0]);
                    return;
                }
                else if((s[7] == s[6] && s[6] == s[8]) && (s[6] == "X" || s[6] == "O"))
                {
                    Console.WriteLine(s[7] + " wins!!! Congratulations " + s[7]);
                    return;
                }
                else if((s[2] == s[5] && s[5] == s[8]) && (s[5] == "X" || s[5] == "O"))
                {
                    Console.WriteLine(s[2] + " wins!!! Congratulations " + s[2]);
                    return;
                }
                else if((s[1] == s[4] && s[4] == s[7]) && (s[4] == "X" || s[4] == "O"))
                {
                    Console.WriteLine(s[1] + " wins!!! Congratulations " + s[1]);
                    return;
                }
                else if((s[3] == s[4] && s[4] == s[5]) && (s[4] == "X" || s[4] == "O"))
                {
                    Console.WriteLine(s[4] + " wins!!! Congratulations " + s[4]);
                    return;
                }
                else
                {
                    bool gameon = true;
                    for(int k=0;k<9;k++)
                    {
                        if (s[k]=="_")
                        {
                            gameon = false;
                        }
                    }
                    if (gameon == true)
                    {
                        Console.WriteLine("----------------No WINS\n\nGame Over!!!!!--------------");
                        return;
                    }
                    if(j%2 == 0) {
                        up1:
                        Console.WriteLine("enter position player 1: ");
                        string s1 = Console.ReadLine();
                        int a1=Convert.ToInt32(s1);
                        if (key.ContainsKey(a1))
                        {
                            goto up1;
                        }
                        s[a1-1] = player1;
                        key.Add(a1,1);
                        for (int i = 0; i < 9; i++)
                        {
                            if (i % 3 == 0) { Console.WriteLine(); }
                            Console.Write(s[i] + "  ");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        up:
                        Console.WriteLine("enter position player 2: ");
                        string s1 = Console.ReadLine();
                        int a1 = Convert.ToInt32(s1);
                        if (key.ContainsKey(a1))
                        {
                            goto up;
                        }
                        s[a1-1] = player2;
                        key.Add(a1, 1);
                        for (int i = 0; i < 9; i++)
                        {
                            if (i % 3 == 0) { Console.WriteLine(); }
                            Console.Write(s[i] + "  ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
