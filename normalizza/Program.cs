namespace normalizza
{
    internal class Program
    {
        static float[] Normalizza(float[] m)
        {
            float[] result = new float[m.Length];

            for (int i = 0; i < m.Length; i++) {

                if (i == 0)
                {
                    result[0] = (m[0] + m[0] + m[1]) / 3;

                }
                else if (i == m.Length - 1) {

                    result[m.Length - 1] = (m[m.Length - 1] + m[m.Length - 1] + m[m.Length - 2]) / 3;

                }
                else
                {
                    result[i] = (m[i] + m[i + 1] + m[i - 1]) / 3;
                }
               
            }

            return result;

        }
        static void Main(string[] args)
        {
            float[] vet1 = { 4, 5, 2, 8, 5 };

            float[] vet2 = Normalizza(vet1);

            for (int i = 0; i < vet2.Length; i++) {

                Console.Write("[" + vet2[i] + "]");
            
            }

        }
    }
}
