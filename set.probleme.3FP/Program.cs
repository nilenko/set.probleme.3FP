using System;

namespace ex.creare.set.probleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configurare pentru afișarea corectă a caracterelor speciale (diacritice)
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("Introduceți numărul problemei (1-11) sau orice alt număr pentru a ieși:");

                int v = int.Parse(Console.ReadLine());

                switch (v)
                {
                    case 1: // Suma elementelor unui vector
                        SumaElementelorVector();
                        break;
                    case 2: // Prima poziție din vector unde apare o valoare k
                        PrimaPozitieValoare();
                        break;
                    case 3: // Pozițiile minimului și maximului din vector
                        PozitiiMinMax();
                        break;
                    case 4: // Determinarea minimului și maximului și a frecvenței lor
                        MinMaxSiFrecventa();
                        break;
                    case 5: // Inserarea unui element într-un vector
                        InserareElement();
                        break;
                    case 6: // Ștergerea unui element dintr-un vector
                        StergereElement();
                        break;
                    case 7: // Inversarea ordinii elementelor din vector
                        InversareVector();
                        break;
                    case 8: // Rotirea elementelor vectorului cu o poziție spre stânga
                        RotireStanga();
                        break;
                    case 9: // Rotirea elementelor vectorului cu k poziții spre stânga
                        RotireK();
                        break;
                    case 10: // Căutare binară într-un vector sortat
                        CautareBinara();
                        break;
                    case 11: // Ciurul lui Eratostene pentru numere prime
                        CiurulEratostene();
                        break;
                    default:
                        Console.WriteLine("Ieșire din program.");
                        return;
                }
            }
        }

        private static void SumaElementelorVector()
        {
            Console.WriteLine("Calculați suma elementelor unui vector.");
            Console.WriteLine("Introduceți numărul de elemente ale vectorului:");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            Console.WriteLine("Introduceți elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            int suma = 0;
            foreach (int elem in vector)
            {
                suma += elem;
            }

            Console.WriteLine($"Suma elementelor vectorului este: {suma}");
        }

        private static void PrimaPozitieValoare()
        {
            Console.WriteLine("Găsiți prima poziție din vector unde apare o valoare k.");
            Console.WriteLine("Introduceți numărul de elemente ale vectorului:");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            Console.WriteLine("Introduceți elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Introduceți valoarea k:");
            int k = int.Parse(Console.ReadLine());

            int pozitie = -1;
            for (int i = 0; i < n; i++)
            {
                if (vector[i] == k)
                {
                    pozitie = i;
                    break;
                }
            }

            Console.WriteLine($"Prima poziție unde apare {k} este: {pozitie}");
        }

        private static void PozitiiMinMax()
        {
            Console.WriteLine("Găsiți pozițiile minimului și maximului din vector.");
            Console.WriteLine("Introduceți numărul de elemente ale vectorului:");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            Console.WriteLine("Introduceți elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            int min = vector[0], max = vector[0], pozMin = 0, pozMax = 0;

            for (int i = 1; i < n; i++)
            {
                if (vector[i] < min)
                {
                    min = vector[i];
                    pozMin = i;
                }

                if (vector[i] > max)
                {
                    max = vector[i];
                    pozMax = i;
                }
            }

            Console.WriteLine($"Poziția minimului este: {pozMin}, iar poziția maximului este: {pozMax}");
        }

        private static void MinMaxSiFrecventa()
        {
            Console.WriteLine("Determinați minimul, maximul și de câte ori apar acestea.");
            Console.WriteLine("Introduceți numărul de elemente ale vectorului:");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            Console.WriteLine("Introduceți elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            int min = vector[0], max = vector[0], frecMin = 0, frecMax = 0;

            foreach (int elem in vector)
            {
                if (elem == min)
                {
                    frecMin++;
                }
                else if (elem < min)
                {
                    min = elem;
                    frecMin = 1;
                }

                if (elem == max)
                {
                    frecMax++;
                }
                else if (elem > max)
                {
                    max = elem;
                    frecMax = 1;
                }
            }

            Console.WriteLine($"Minimul este {min}, apare de {frecMin} ori.");
            Console.WriteLine($"Maximul este {max}, apare de {frecMax} ori.");
        }

        private static void InserareElement()
        {
            Console.WriteLine("Inserarea unui element pe o anumită poziție în vector.");
            Console.WriteLine("Introduceți numărul de elemente ale vectorului:");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n + 1];
            Console.WriteLine("Introduceți elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Introduceți valoarea e:");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceți poziția k:");
            int k = int.Parse(Console.ReadLine());

            for (int i = n; i > k; i--)
            {
                vector[i] = vector[i - 1];
            }

            vector[k] = e;

            Console.WriteLine("Vectorul rezultat este:");
            foreach (int elem in vector)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }

        private static void StergereElement()
        {
            Console.WriteLine("Ștergerea unui element din vector.");
            Console.WriteLine("Introduceți numărul de elemente ale vectorului:");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            Console.WriteLine("Introduceți elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Introduceți poziția k:");
            int k = int.Parse(Console.ReadLine());

            for (int i = k; i < n - 1; i++)
            {
                vector[i] = vector[i + 1];
            }

            Console.WriteLine("Vectorul rezultat este:");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();
        }

        private static void InversareVector()
        {
            Console.WriteLine("Inversarea ordinii elementelor din vector.");
            Console.WriteLine("Introduceți numărul de elemente ale vectorului:");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            Console.WriteLine("Introduceți elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n / 2; i++)
            {
                int temp = vector[i];
                vector[i] = vector[n - i - 1];
                vector[n - i - 1] = temp;
            }

            Console.WriteLine("Vectorul inversat este:");
            foreach (int elem in vector)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }

        private static void RotireStanga()
        {
            Console.WriteLine("Rotirea elementelor vectorului cu o poziție spre stânga.");
            Console.WriteLine("Introduceți numărul de elemente ale vectorului:");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            Console.WriteLine("Introduceți elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            int primul = vector[0];
            for (int i = 0; i < n - 1; i++)
            {
                vector[i] = vector[i + 1];
            }
            vector[n - 1] = primul;

            Console.WriteLine("Vectorul rezultat este:");
            foreach (int elem in vector)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }

        private static void RotireK()
        {
            Console.WriteLine("Rotirea elementelor vectorului cu k poziții spre stânga.");
            Console.WriteLine("Introduceți numărul de elemente ale vectorului:");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            Console.WriteLine("Introduceți elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Introduceți valoarea k:");
            int k = int.Parse(Console.ReadLine());
            k = k % n; // Optimizare

            int[] rezultat = new int[n];
            for (int i = 0; i < n; i++)
            {
                rezultat[i] = vector[(i + k) % n];
            }

            Console.WriteLine("Vectorul rezultat este:");
            foreach (int elem in rezultat)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }

        private static void CautareBinara()
        {
            Console.WriteLine("Căutare binară într-un vector sortat.");
            Console.WriteLine("Introduceți numărul de elemente ale vectorului:");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            Console.WriteLine("Introduceți elementele vectorului sortate crescător:");
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Introduceți valoarea k pe care doriți să o găsiți:");
            int k = int.Parse(Console.ReadLine());

            int st = 0, dr = n - 1, pozitie = -1;

            while (st <= dr)
            {
                int mijloc = (st + dr) / 2;
                if (vector[mijloc] == k)
                {
                    pozitie = mijloc;
                    break;
                }
                else if (vector[mijloc] < k)
                {
                    st = mijloc + 1;
                }
                else
                {
                    dr = mijloc - 1;
                }
            }

            Console.WriteLine($"Poziția lui {k} în vector este: {pozitie}");
        }

        private static void CiurulEratostene()
        {
            Console.WriteLine("Determinarea numerelor prime mai mici sau egale cu n (ciurul lui Eratostene).");
            Console.WriteLine("Introduceți numărul n:");
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("Nu există numere prime mai mici sau egale cu 1.");
                return;
            }

            bool[] estePrim = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                estePrim[i] = true;
            }

            for (int p = 2; p * p <= n; p++)
            {
                if (estePrim[p])
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        estePrim[i] = false;
                    }
                }
            }

            Console.WriteLine("Numerele prime mai mici sau egale cu n sunt:");
            for (int i = 2; i <= n; i++)
            {
                if (estePrim[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

    }
}
