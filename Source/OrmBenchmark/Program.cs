using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start . . .");
            Console.ReadKey();

            WarmUp();
            TestPetaPoco();
            TestInsula();
            TestEntityFramework();

            Console.WriteLine();
        }

        private static void ExecuteAction(string description, Action actionToExecute)
        {
            var sw = new Stopwatch();
            Console.Write(description.PadRight(45));
            sw.Start();
            actionToExecute();
            sw.Stop();
            Console.WriteLine(string.Format("{0} ms", sw.ElapsedMilliseconds).PadLeft(15));
        }

        private static void WarmUp()
        {
            var tables = new[] { "Customer", "Item", "Order", "OrderLine" };
            var totalRecordCount = 0;

            Console.WriteLine();
            ExecuteAction("Warming up . . .", () =>
            {
                using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["OrmBenchmark"].ConnectionString))
                {
                    var cmd = conn.CreateCommand();
                    conn.Open();
                    foreach (var table in tables)
                    {
                        cmd.CommandText = string.Format("SELECT * FROM [{0}]", table);
                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                totalRecordCount++;
                            }
                        }
                    }
                }
            });

            Console.WriteLine("Total {0} records in {1} tables", totalRecordCount, tables.Length);
        }

        private static void TestInsula()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Insula.Data");
            Console.WriteLine("------------------------------------------------------------");

            OrmBenchmark.Insula.InsulaDatabaseContext db = null;

            ExecuteAction("Instantiating context", () =>
            {
                db = new OrmBenchmark.Insula.InsulaDatabaseContext();
            });

            ExecuteAction("First query", () =>
            {
                var cust = db.CustomerRepository.GetByKey("CUST-00001");
            });

            ExecuteAction("Loading 100 customers one by one", () =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    var custID = string.Format("CUST-{0}", i.ToString("00000"));
                    var cust = db.CustomerRepository.GetByKey(custID);
                }
            });

            ExecuteAction("Loading 10000 customers at once", () =>
            {
                var cust = db.CustomerRepository.Query().GetAll();
            });

            ExecuteAction("Loading 200000 order lines at once", () =>
            {
                var cust = db.OrderLineRepository.Query().GetAll();
            });

            ExecuteAction("Loading 10000 orders with related customers", () =>
            {
                var orders = db.OrderRepository.Query().Include("Customer").GetAll();
            });

            ExecuteAction("Loading and updating 1000 customers", () =>
            {
                var custs = db.CustomerRepository.Query().GetTop(1000);

                foreach (var c in custs)
                {
                    c.Name = DateTime.Now.ToString();
                    db.CustomerRepository.Update(c);
                }
            });

            db.Dispose();
        }

        private static void TestPetaPoco()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("PetaPoco");
            Console.WriteLine("------------------------------------------------------------");

            OrmBenchmark.PetaPoco.OrmBenchmarkDB db = null;

            ExecuteAction("Instantiating context", () =>
            {
                db = new OrmBenchmark.PetaPoco.OrmBenchmarkDB("OrmBenchmark");
            });

            ExecuteAction("First query", () =>
            {
                var cust = db.SingleOrDefault<OrmBenchmark.PetaPoco.Customer>("WHERE CustomerID = @0", "CUST-00001");
            });

            ExecuteAction("Loading 100 customers one by one", () =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    var custID = string.Format("CUST-{0}", i.ToString("00000"));
                    var cust = db.SingleOrDefault<OrmBenchmark.PetaPoco.Customer>("WHERE CustomerID = @0", custID);
                }
            });

            ExecuteAction("Loading 10000 customers at once", () =>
            {
                var cust = db.Fetch<OrmBenchmark.PetaPoco.Customer>(string.Empty);
            });

            ExecuteAction("Loading 200000 order lines at once", () =>
            {
                var cust = db.Fetch<OrmBenchmark.PetaPoco.OrderLine>(string.Empty);
            });

            ExecuteAction("Loading 10000 orders with related customers", () =>
            {
                var orders = db.Fetch<OrmBenchmark.PetaPoco.Order, OrmBenchmark.PetaPoco.Customer>(
                    "SELECT * FROM [Order] LEFT OUTER JOIN [Customer] ON [Order].CustomerID = [Customer].CustomerID");
            });

            ExecuteAction("Loading and updating 1000 customers", () =>
            {
                db.BeginTransaction();

                var custs = db.Fetch<OrmBenchmark.PetaPoco.Customer>("SELECT TOP 1000 * FROM Customer");

                foreach (var c in custs)
                {
                    c.Name = DateTime.Now.ToString();
                    db.Update("Customer", "CustomerID", c);
                }

                db.CompleteTransaction();
            });
        }

        private static void TestEntityFramework()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Entity Framework 5.0 - Code First");
            Console.WriteLine("------------------------------------------------------------");

            EntityFramework.Models.OrmBenchmarkContext db = null;

            ExecuteAction("Instantiating context", () =>
            {
                db = new EntityFramework.Models.OrmBenchmarkContext();
            });

            ExecuteAction("First query", () =>
            {
                var cust = db.Customers.Single(c => c.CustomerID == "CUST-00001");
            });

            db = new EntityFramework.Models.OrmBenchmarkContext();
            ExecuteAction("Loading 100 customers one by one", () =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    var custID = string.Format("CUST-{0}", i.ToString("00000"));
                    var cust = db.Customers.Single(c => c.CustomerID == custID);
                }
            });

            db = new EntityFramework.Models.OrmBenchmarkContext();
            ExecuteAction("Loading 10000 customers at once", () =>
            {
                var cust = db.Customers.ToList();
            });

            db = new EntityFramework.Models.OrmBenchmarkContext();
            ExecuteAction("Loading 200000 order lines at once", () =>
            {
                var cust = db.OrderLines.ToList();
            });

            db = new EntityFramework.Models.OrmBenchmarkContext();
            ExecuteAction("Loading 10000 orders with related customers", () =>
            {
                var orders = db.Orders.Include("Customer").ToList();
            });

            db = new EntityFramework.Models.OrmBenchmarkContext();
            ExecuteAction("Loading and updating 1000 customers", () =>
            {
                var custs = db.Customers.Take(1000).ToList();

                foreach (var c in custs)
                {
                    c.Name = DateTime.Now.ToString();
                }

                db.SaveChanges();
            });
        }
    }
}
