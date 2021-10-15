using MyLibrary.Queue.Array;
using MyLibrary.Stack.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorensVanHanoi
{
    public class TowersOfHanoiGame
    {
        //Number of disks for this game
        private readonly int noDisks;
        //The 3 towers
        private StackInt[] towers = new StackInt[3];
        //The number of moves done
        private int Counter = 0;
        //A queue to store the moves for game autoplay
        private LineairQueueString moves = new LineairQueueString();

        /// <summary>
        /// Create a new game, specifying the number of disks
        /// </summary>
        /// <param name="noDisks">a positive number</param>
        public TowersOfHanoiGame(int noDisks)
        {
            this.noDisks = noDisks;
            this.Restart();
        }

        
        /// <summary>
        /// The game is finished when the last tower contains all the disks
        /// </summary>
        public bool IsGameFinished
        {
            get
            {
                return towers[2].Items.Length == noDisks;
            }
        }

        /// <summary>
        /// Get the number of moves that where already taken
        /// </summary>
        public int Moves
        {
            get
            {
                return Counter;
            }
        }

        /// <summary>
        /// Get the minimum number of moves required for this game
        /// </summary>
        public int MinimumMoves
        {
            get
            {
                return (int)Math.Pow(2, noDisks) - 1;
            }
        }

        /// <summary>
        /// Move a disk from one tower to another tower
        /// </summary>
        /// <param name="fromTower">Tower number between 1 and 3</param>
        /// <param name="toTower">Tower number between 1 and 3</param>
        /// <returns>TRUE if the move was allowed and done</returns>
        public bool Move(int fromTower, int toTower)
        {
            if (fromTower < 1 || fromTower > 3 || toTower < 1 || toTower > 3)
                throw new Exception("tower number must be between 1 and 3");

            fromTower--;
            toTower--;

            //Check if the move is possible (tower is not empty) and allowed (there is no smaller disk on the destination tower already)
            if (!towers[fromTower].IsEmpty && (towers[toTower].IsEmpty || towers[toTower].Peek() > towers[fromTower].Peek()))
            {
                towers[toTower].Push(towers[fromTower].Pop());
                Counter++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get all the items in a specific tower
        /// </summary>
        /// <param name="tower">tower number between 1 and 3</param>
        /// <returns></returns>
        public int[] TowerItems(int tower)
        {
            if (tower < 1 || tower > 3)
                throw new Exception("tower number must be between 1 and 3");

            return towers[tower - 1].Items;
        }

        /// <summary>
        /// Return a queue with all the moves to (auto) play this game step by step
        /// </summary>
        /// <returns></returns>
        public LineairQueueString CalculateAllMoves()
        {
            moves.Clear();
            MoveDisks(noDisks, 0, 2, 1);
            return moves;
        }

        /// <summary>
        /// Move the specified disk (and all above) from one tower to another tower
        /// </summary>
        /// <param name="disk"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="helper"></param>
        private void MoveDisks(int disk, int from, int to, int helper)
        {
            if (disk == 1)
            {
                moves.Enqueue(string.Concat(from + 1, to + 1));  //store move in queue
                return;
            }
            MoveDisks(disk - 1, from, helper, to);
            moves.Enqueue(string.Concat(from + 1, to + 1));     //store move in queue
            MoveDisks(disk - 1, helper, to, from);
        }

        /// <summary>
        /// Reset the game
        /// </summary>
        private void Restart()
        {
            //initialize the stacks for the towers
            for (int f = 0; f < towers.Length; f++)
            {
                towers[f] = new StackInt(5);
            }
            //Add all the disks into the first tower
            //each disk is represented by a number
            //1 = the smallest disk, 2 = the 2nd smallest,...
            for (int i = noDisks; i >= 1; i--)  // 5 - 4 - 3 - 2 - 1
            {
                towers[0].Push(i);
            }
            Counter = 0;
        }

    }
}
