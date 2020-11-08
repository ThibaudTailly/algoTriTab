using System;

namespace algoTri
{
    class Program
    {
        public static int[] triSelection(int[] tableauSelec)
        {
            int min;
            int tmp;

            for (int i = 0; i <= tableauSelec.Length - 2; i++)
            {
                min = i;
                for (int j = i + 1; j < tableauSelec.Length; j++)
                {
                    if (tableauSelec[j] < tableauSelec[min])
                    {
                        min = j;
                    }
                }
                if (min < i || min > i)
                {
                    tmp = tableauSelec[i];
                    tableauSelec[i] = tableauSelec[min];
                    tableauSelec[min] = tmp;
                }
            }

            return tableauSelec;
        }

        public static int[] triInsertion(int[] tableauSelec)
        {
            int valeur;
            int cpt;
            for(int i = 1; i < tableauSelec.Length ; i++)
            {
                valeur = tableauSelec[i];
                cpt = i;
                while(cpt>0 && tableauSelec[cpt-1] > valeur)
                {
                    tableauSelec[cpt] = tableauSelec[cpt - 1];
                    cpt = cpt - 1;
                }
                tableauSelec[cpt] = valeur;
            }
            return tableauSelec;
        }

        public static int[] triBulles(int[] tableauSelec)
        {
            int tmp;
            for(int i = 0; i< tableauSelec.Length; i++)
            {
                for (int j = 0; j <i; j++)
                    if (tableauSelec[j + 1] < tableauSelec[j]) 
                    {
                        tmp = tableauSelec[j + 1];
                        tableauSelec[j + 1] = tableauSelec[j];
                        tableauSelec[j] = tmp;

                    }
            }
            return tableauSelec;
        }


        static void Main(string[] args)
        {
            
            //variable

            int[] tableauTri = new int[] { 1, 6, 4, 2, 3, 12, 10 };
            int[] tableauTri2 = new int[] { 1, 6, 4, 2, 3, 12, 10 };
            int[] tableauTri3 = new int[] { 1, 6, 4, 2, 3, 12, 10 };

            triBulles(tableauTri);

            foreach (int elemts in tableauTri)
            {
                Console.WriteLine(elemts);
            }
            
        }
    }
}
