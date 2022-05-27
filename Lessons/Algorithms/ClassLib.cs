using System;
using System.Collections.Generic;

namespace CoreSolution
{
    public class ClassLib
    {
        public int GetMaximumPairOfSocks(int noOfWashes, int[] cleanPile, int[] dirtyPile)
        {
            // Your code goes here
            bool[] cleanPileCheck = new bool[cleanPile.Length];
            bool[] dirtyPileCheck  = new bool[dirtyPile.Length];
            int pairs = 0;
            
            for (int i = 0; i < cleanPile.Length; i++)
            {
                bool wasPaired = false;
                if (cleanPileCheck[i])
                {
                    continue;
                }
                for(int j = i + 1; j < cleanPile.Length; j++)
                {
                    if (cleanPileCheck[j])
                    {
                        continue;
                    }
                    if(cleanPile[i] == cleanPile[j] )
                    {
                        pairs++;
                        cleanPileCheck[i] = true;
                        cleanPileCheck[j] = true; 
                        wasPaired = true;
                        break;
                    }
                }
                if(wasPaired || noOfWashes <= 0)
                {
                    continue;
                }

                for(int j = 0; j < dirtyPile.Length; j++)
                {
                    if (dirtyPileCheck[j])
                    {
                        continue;
                    }
                    if(cleanPile[i] == dirtyPile[j] )
                    {
                        cleanPileCheck[i] = true;
                        dirtyPileCheck[j] = true;
                        pairs++;
                        noOfWashes--;
                       
                        break;
                    }
                }
            }
            
            for(int i = 0; i < dirtyPile.Length; i++)
            {
               
                if(noOfWashes <= 0)
                {
                    break;
                }
                if(dirtyPileCheck[i])
                {
                    continue;
                }
                for(int j = i + 1; j < dirtyPile.Length; j++)
                {
                    if(dirtyPileCheck[j])
                    {
                        continue;
                    }

                    if(dirtyPile[i] == dirtyPile[j] )
                    {
                        dirtyPileCheck[i] = true;
                        dirtyPileCheck[j] = true;
                        pairs++;
                        noOfWashes -= 2;
                        break;
                        
                    }
                }

            }
            return pairs;
        }
    }
}
