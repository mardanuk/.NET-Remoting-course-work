using System;
using System.Runtime.Remoting.Lifetime;

namespace DB_project.Classes
{
    public class MyClientSponsor : MarshalByRefObject, ISponsor
    {
        private DateTime lastRenewal;
        private int count = 0;

        public MyClientSponsor()
        {
            lastRenewal = DateTime.Now;
        }

        public TimeSpan Renewal(ILease lease)
        {
            count++;

            Console.WriteLine($"\nВызван метод Renewal спонсора '{count}'-ый раз");
            Console.WriteLine($"Время с момента последнего вызова: '{(DateTime.Now - lastRenewal).ToString()}'");
            lastRenewal = DateTime.Now;

            return TimeSpan.FromSeconds(10);
        }
    }
}