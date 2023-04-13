namespace Wyjatki.MyClass
{
    internal class RownanieKwadratowe
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public RownanieKwadratowe(int a, int b, int c) 
        { 
            this.a = a; this.b = b; this.c = c;
        }
        private int ObliczDelte()
        {
            return (b * b) - (4 * a * c);
        }
        public double[] ObliczRzowziazanie()
        {
            double[] x = new double[2];

            double Delta = ObliczDelte();
            if (Delta < 0)
                throw new Exception("Delta ujemna nie ma rozwiązań");
            if (Delta > 0)
            {
                
                x[0] = (-b - Math.Sqrt(Delta)) / 2 * a;
                x[1] = (-b + Math.Sqrt(Delta)) / 2 * a;
            }
            if (Delta == 0)
            {
                x[0] = -b / 2 * a;
                x[1] = -b / 2 * a;
            }
            return x;
        }
        public override string ToString()
        {
            try
            {
                string write = "";
                double[] x = new double[2];
                x = ObliczRzowziazanie();
                for (int i = 0; i < 2; i++)
                {
                    write += ($"x{i + 1} = {x[i]}\n");
                }
                return write;
            }
            catch (Exception exc)
            {
                return $"{exc.Message}";
            }
        }
    }
}
