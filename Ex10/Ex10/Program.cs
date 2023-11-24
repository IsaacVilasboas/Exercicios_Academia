namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] m = new int[4, 4];
            int[,] m2 = new int[4, 4];
            Random random = new Random();
            int cont = 0;
            int maiormA = 0;
            int menormA = 0;
            int maiormB = 0;
            int menormB = 0;
            double mediaA = 0;
            double mediaB = 0;
           
            for (int i = 0; i < 4; i++) { 
                for (int j = 0; j < 4; j++)
                {
                    m[i, j] = random.Next(0,5);
                    cont++;
                }
            }
            for (int i = 0;i < 4; i++)
            {
                for (int j = 0;j < 4; j++)
                {
                    m2[i, j] = random.Next(0,5);
                    cont++;
                }
             
            }
            //mediaA
            for(int i = 0;i<4; i++)
            {
                for(int j = 0;j<4; j++)
                {
                    mediaA = m[i,j] / cont;
                } 
            }
            //mediaB
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    mediaB = m2[i, j] / cont;
                }
            }
            for(int i =0;i<4; i++)
            {
                for(int j = 0; j < 4;j++)
                {
                    if (mediaA > m[i, j])
                    {
                        menormA++;

                    }
                    if (mediaA == m[i, j])
                    {
                        mediaA++;
                    }
                    else if (mediaA < m[i, j])
                    {
                        maiormA++;
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0;j < 4; j++)
                {
                    if (mediaB > m2[i, j])
                    {
                        menormB++;

                    }
                    if (mediaB == m2[i, j])
                    {
                        mediaB++;
                    }
                    else if (mediaB < m2[i, j])
                    {
                        maiormB++;
                    }
                }
            }
            Console.WriteLine("números lidos que estão abaixo da média B : " + menormB);
            Console.WriteLine("números lidos que estão abaixo da média A : " + menormA);
            Console.WriteLine("números lidos que estão acima da média B : " + maiormB);
            Console.WriteLine("números lidos que estão acima da média A : " + maiormA);
            Console.WriteLine("números lidos que estão na média B : " + mediaB);
            Console.WriteLine("números lidos que estão na média A : " + mediaA);

        }
    }
}