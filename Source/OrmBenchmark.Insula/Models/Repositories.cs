/////////////////////////////////////////////////////////////////////////////////////////////
//  This code was generated from a template. Do NOT change it, edit the template instead.  //
/////////////////////////////////////////////////////////////////////////////////////////////

using System;
using Insula.Data.Orm;

namespace OrmBenchmark.Insula
{
    public partial class CustomerRepository : Repository<Customer>
    {
        public CustomerRepository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer GetByKey(string customerID)
        {
            return this.Query().Where(new { CustomerID = customerID }).GetSingle();  
        }
        
        public void DeleteByKey(string customerID)
        {
            this.Delete(new Customer() { CustomerID = customerID });
        }
    }


    public partial class Customer001Repository : Repository<Customer001>
    {
        public Customer001Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer001 GetByKey(string customer001ID)
        {
            return this.Query().Where(new { Customer001ID = customer001ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer001ID)
        {
            this.Delete(new Customer001() { Customer001ID = customer001ID });
        }
    }


    public partial class Customer002Repository : Repository<Customer002>
    {
        public Customer002Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer002 GetByKey(string customer002ID)
        {
            return this.Query().Where(new { Customer002ID = customer002ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer002ID)
        {
            this.Delete(new Customer002() { Customer002ID = customer002ID });
        }
    }


    public partial class Customer003Repository : Repository<Customer003>
    {
        public Customer003Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer003 GetByKey(string customer003ID)
        {
            return this.Query().Where(new { Customer003ID = customer003ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer003ID)
        {
            this.Delete(new Customer003() { Customer003ID = customer003ID });
        }
    }


    public partial class Customer004Repository : Repository<Customer004>
    {
        public Customer004Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer004 GetByKey(string customer004ID)
        {
            return this.Query().Where(new { Customer004ID = customer004ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer004ID)
        {
            this.Delete(new Customer004() { Customer004ID = customer004ID });
        }
    }


    public partial class Customer005Repository : Repository<Customer005>
    {
        public Customer005Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer005 GetByKey(string customer005ID)
        {
            return this.Query().Where(new { Customer005ID = customer005ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer005ID)
        {
            this.Delete(new Customer005() { Customer005ID = customer005ID });
        }
    }


    public partial class Customer006Repository : Repository<Customer006>
    {
        public Customer006Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer006 GetByKey(string customer006ID)
        {
            return this.Query().Where(new { Customer006ID = customer006ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer006ID)
        {
            this.Delete(new Customer006() { Customer006ID = customer006ID });
        }
    }


    public partial class Customer007Repository : Repository<Customer007>
    {
        public Customer007Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer007 GetByKey(string customer007ID)
        {
            return this.Query().Where(new { Customer007ID = customer007ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer007ID)
        {
            this.Delete(new Customer007() { Customer007ID = customer007ID });
        }
    }


    public partial class Customer008Repository : Repository<Customer008>
    {
        public Customer008Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer008 GetByKey(string customer008ID)
        {
            return this.Query().Where(new { Customer008ID = customer008ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer008ID)
        {
            this.Delete(new Customer008() { Customer008ID = customer008ID });
        }
    }


    public partial class Customer009Repository : Repository<Customer009>
    {
        public Customer009Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer009 GetByKey(string customer009ID)
        {
            return this.Query().Where(new { Customer009ID = customer009ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer009ID)
        {
            this.Delete(new Customer009() { Customer009ID = customer009ID });
        }
    }


    public partial class Customer010Repository : Repository<Customer010>
    {
        public Customer010Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer010 GetByKey(string customer010ID)
        {
            return this.Query().Where(new { Customer010ID = customer010ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer010ID)
        {
            this.Delete(new Customer010() { Customer010ID = customer010ID });
        }
    }


    public partial class Customer011Repository : Repository<Customer011>
    {
        public Customer011Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer011 GetByKey(string customer011ID)
        {
            return this.Query().Where(new { Customer011ID = customer011ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer011ID)
        {
            this.Delete(new Customer011() { Customer011ID = customer011ID });
        }
    }


    public partial class Customer012Repository : Repository<Customer012>
    {
        public Customer012Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer012 GetByKey(string customer012ID)
        {
            return this.Query().Where(new { Customer012ID = customer012ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer012ID)
        {
            this.Delete(new Customer012() { Customer012ID = customer012ID });
        }
    }


    public partial class Customer013Repository : Repository<Customer013>
    {
        public Customer013Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer013 GetByKey(string customer013ID)
        {
            return this.Query().Where(new { Customer013ID = customer013ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer013ID)
        {
            this.Delete(new Customer013() { Customer013ID = customer013ID });
        }
    }


    public partial class Customer014Repository : Repository<Customer014>
    {
        public Customer014Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer014 GetByKey(string customer014ID)
        {
            return this.Query().Where(new { Customer014ID = customer014ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer014ID)
        {
            this.Delete(new Customer014() { Customer014ID = customer014ID });
        }
    }


    public partial class Customer015Repository : Repository<Customer015>
    {
        public Customer015Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer015 GetByKey(string customer015ID)
        {
            return this.Query().Where(new { Customer015ID = customer015ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer015ID)
        {
            this.Delete(new Customer015() { Customer015ID = customer015ID });
        }
    }


    public partial class Customer016Repository : Repository<Customer016>
    {
        public Customer016Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer016 GetByKey(string customer016ID)
        {
            return this.Query().Where(new { Customer016ID = customer016ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer016ID)
        {
            this.Delete(new Customer016() { Customer016ID = customer016ID });
        }
    }


    public partial class Customer017Repository : Repository<Customer017>
    {
        public Customer017Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer017 GetByKey(string customer017ID)
        {
            return this.Query().Where(new { Customer017ID = customer017ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer017ID)
        {
            this.Delete(new Customer017() { Customer017ID = customer017ID });
        }
    }


    public partial class Customer018Repository : Repository<Customer018>
    {
        public Customer018Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer018 GetByKey(string customer018ID)
        {
            return this.Query().Where(new { Customer018ID = customer018ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer018ID)
        {
            this.Delete(new Customer018() { Customer018ID = customer018ID });
        }
    }


    public partial class Customer019Repository : Repository<Customer019>
    {
        public Customer019Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer019 GetByKey(string customer019ID)
        {
            return this.Query().Where(new { Customer019ID = customer019ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer019ID)
        {
            this.Delete(new Customer019() { Customer019ID = customer019ID });
        }
    }


    public partial class Customer020Repository : Repository<Customer020>
    {
        public Customer020Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer020 GetByKey(string customer020ID)
        {
            return this.Query().Where(new { Customer020ID = customer020ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer020ID)
        {
            this.Delete(new Customer020() { Customer020ID = customer020ID });
        }
    }


    public partial class Customer021Repository : Repository<Customer021>
    {
        public Customer021Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer021 GetByKey(string customer021ID)
        {
            return this.Query().Where(new { Customer021ID = customer021ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer021ID)
        {
            this.Delete(new Customer021() { Customer021ID = customer021ID });
        }
    }


    public partial class Customer022Repository : Repository<Customer022>
    {
        public Customer022Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer022 GetByKey(string customer022ID)
        {
            return this.Query().Where(new { Customer022ID = customer022ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer022ID)
        {
            this.Delete(new Customer022() { Customer022ID = customer022ID });
        }
    }


    public partial class Customer023Repository : Repository<Customer023>
    {
        public Customer023Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer023 GetByKey(string customer023ID)
        {
            return this.Query().Where(new { Customer023ID = customer023ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer023ID)
        {
            this.Delete(new Customer023() { Customer023ID = customer023ID });
        }
    }


    public partial class Customer024Repository : Repository<Customer024>
    {
        public Customer024Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer024 GetByKey(string customer024ID)
        {
            return this.Query().Where(new { Customer024ID = customer024ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer024ID)
        {
            this.Delete(new Customer024() { Customer024ID = customer024ID });
        }
    }


    public partial class Customer025Repository : Repository<Customer025>
    {
        public Customer025Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer025 GetByKey(string customer025ID)
        {
            return this.Query().Where(new { Customer025ID = customer025ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer025ID)
        {
            this.Delete(new Customer025() { Customer025ID = customer025ID });
        }
    }


    public partial class Customer026Repository : Repository<Customer026>
    {
        public Customer026Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer026 GetByKey(string customer026ID)
        {
            return this.Query().Where(new { Customer026ID = customer026ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer026ID)
        {
            this.Delete(new Customer026() { Customer026ID = customer026ID });
        }
    }


    public partial class Customer027Repository : Repository<Customer027>
    {
        public Customer027Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer027 GetByKey(string customer027ID)
        {
            return this.Query().Where(new { Customer027ID = customer027ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer027ID)
        {
            this.Delete(new Customer027() { Customer027ID = customer027ID });
        }
    }


    public partial class Customer028Repository : Repository<Customer028>
    {
        public Customer028Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer028 GetByKey(string customer028ID)
        {
            return this.Query().Where(new { Customer028ID = customer028ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer028ID)
        {
            this.Delete(new Customer028() { Customer028ID = customer028ID });
        }
    }


    public partial class Customer029Repository : Repository<Customer029>
    {
        public Customer029Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer029 GetByKey(string customer029ID)
        {
            return this.Query().Where(new { Customer029ID = customer029ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer029ID)
        {
            this.Delete(new Customer029() { Customer029ID = customer029ID });
        }
    }


    public partial class Customer030Repository : Repository<Customer030>
    {
        public Customer030Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer030 GetByKey(string customer030ID)
        {
            return this.Query().Where(new { Customer030ID = customer030ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer030ID)
        {
            this.Delete(new Customer030() { Customer030ID = customer030ID });
        }
    }


    public partial class Customer031Repository : Repository<Customer031>
    {
        public Customer031Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer031 GetByKey(string customer031ID)
        {
            return this.Query().Where(new { Customer031ID = customer031ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer031ID)
        {
            this.Delete(new Customer031() { Customer031ID = customer031ID });
        }
    }


    public partial class Customer032Repository : Repository<Customer032>
    {
        public Customer032Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer032 GetByKey(string customer032ID)
        {
            return this.Query().Where(new { Customer032ID = customer032ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer032ID)
        {
            this.Delete(new Customer032() { Customer032ID = customer032ID });
        }
    }


    public partial class Customer033Repository : Repository<Customer033>
    {
        public Customer033Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer033 GetByKey(string customer033ID)
        {
            return this.Query().Where(new { Customer033ID = customer033ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer033ID)
        {
            this.Delete(new Customer033() { Customer033ID = customer033ID });
        }
    }


    public partial class Customer034Repository : Repository<Customer034>
    {
        public Customer034Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer034 GetByKey(string customer034ID)
        {
            return this.Query().Where(new { Customer034ID = customer034ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer034ID)
        {
            this.Delete(new Customer034() { Customer034ID = customer034ID });
        }
    }


    public partial class Customer035Repository : Repository<Customer035>
    {
        public Customer035Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer035 GetByKey(string customer035ID)
        {
            return this.Query().Where(new { Customer035ID = customer035ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer035ID)
        {
            this.Delete(new Customer035() { Customer035ID = customer035ID });
        }
    }


    public partial class Customer036Repository : Repository<Customer036>
    {
        public Customer036Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer036 GetByKey(string customer036ID)
        {
            return this.Query().Where(new { Customer036ID = customer036ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer036ID)
        {
            this.Delete(new Customer036() { Customer036ID = customer036ID });
        }
    }


    public partial class Customer037Repository : Repository<Customer037>
    {
        public Customer037Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer037 GetByKey(string customer037ID)
        {
            return this.Query().Where(new { Customer037ID = customer037ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer037ID)
        {
            this.Delete(new Customer037() { Customer037ID = customer037ID });
        }
    }


    public partial class Customer038Repository : Repository<Customer038>
    {
        public Customer038Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer038 GetByKey(string customer038ID)
        {
            return this.Query().Where(new { Customer038ID = customer038ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer038ID)
        {
            this.Delete(new Customer038() { Customer038ID = customer038ID });
        }
    }


    public partial class Customer039Repository : Repository<Customer039>
    {
        public Customer039Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer039 GetByKey(string customer039ID)
        {
            return this.Query().Where(new { Customer039ID = customer039ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer039ID)
        {
            this.Delete(new Customer039() { Customer039ID = customer039ID });
        }
    }


    public partial class Customer040Repository : Repository<Customer040>
    {
        public Customer040Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer040 GetByKey(string customer040ID)
        {
            return this.Query().Where(new { Customer040ID = customer040ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer040ID)
        {
            this.Delete(new Customer040() { Customer040ID = customer040ID });
        }
    }


    public partial class Customer041Repository : Repository<Customer041>
    {
        public Customer041Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer041 GetByKey(string customer041ID)
        {
            return this.Query().Where(new { Customer041ID = customer041ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer041ID)
        {
            this.Delete(new Customer041() { Customer041ID = customer041ID });
        }
    }


    public partial class Customer042Repository : Repository<Customer042>
    {
        public Customer042Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer042 GetByKey(string customer042ID)
        {
            return this.Query().Where(new { Customer042ID = customer042ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer042ID)
        {
            this.Delete(new Customer042() { Customer042ID = customer042ID });
        }
    }


    public partial class Customer043Repository : Repository<Customer043>
    {
        public Customer043Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer043 GetByKey(string customer043ID)
        {
            return this.Query().Where(new { Customer043ID = customer043ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer043ID)
        {
            this.Delete(new Customer043() { Customer043ID = customer043ID });
        }
    }


    public partial class Customer044Repository : Repository<Customer044>
    {
        public Customer044Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer044 GetByKey(string customer044ID)
        {
            return this.Query().Where(new { Customer044ID = customer044ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer044ID)
        {
            this.Delete(new Customer044() { Customer044ID = customer044ID });
        }
    }


    public partial class Customer045Repository : Repository<Customer045>
    {
        public Customer045Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer045 GetByKey(string customer045ID)
        {
            return this.Query().Where(new { Customer045ID = customer045ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer045ID)
        {
            this.Delete(new Customer045() { Customer045ID = customer045ID });
        }
    }


    public partial class Customer046Repository : Repository<Customer046>
    {
        public Customer046Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer046 GetByKey(string customer046ID)
        {
            return this.Query().Where(new { Customer046ID = customer046ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer046ID)
        {
            this.Delete(new Customer046() { Customer046ID = customer046ID });
        }
    }


    public partial class Customer047Repository : Repository<Customer047>
    {
        public Customer047Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer047 GetByKey(string customer047ID)
        {
            return this.Query().Where(new { Customer047ID = customer047ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer047ID)
        {
            this.Delete(new Customer047() { Customer047ID = customer047ID });
        }
    }


    public partial class Customer048Repository : Repository<Customer048>
    {
        public Customer048Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer048 GetByKey(string customer048ID)
        {
            return this.Query().Where(new { Customer048ID = customer048ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer048ID)
        {
            this.Delete(new Customer048() { Customer048ID = customer048ID });
        }
    }


    public partial class Customer049Repository : Repository<Customer049>
    {
        public Customer049Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer049 GetByKey(string customer049ID)
        {
            return this.Query().Where(new { Customer049ID = customer049ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer049ID)
        {
            this.Delete(new Customer049() { Customer049ID = customer049ID });
        }
    }


    public partial class Customer050Repository : Repository<Customer050>
    {
        public Customer050Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer050 GetByKey(string customer050ID)
        {
            return this.Query().Where(new { Customer050ID = customer050ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer050ID)
        {
            this.Delete(new Customer050() { Customer050ID = customer050ID });
        }
    }


    public partial class Customer051Repository : Repository<Customer051>
    {
        public Customer051Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer051 GetByKey(string customer051ID)
        {
            return this.Query().Where(new { Customer051ID = customer051ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer051ID)
        {
            this.Delete(new Customer051() { Customer051ID = customer051ID });
        }
    }


    public partial class Customer052Repository : Repository<Customer052>
    {
        public Customer052Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer052 GetByKey(string customer052ID)
        {
            return this.Query().Where(new { Customer052ID = customer052ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer052ID)
        {
            this.Delete(new Customer052() { Customer052ID = customer052ID });
        }
    }


    public partial class Customer053Repository : Repository<Customer053>
    {
        public Customer053Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer053 GetByKey(string customer053ID)
        {
            return this.Query().Where(new { Customer053ID = customer053ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer053ID)
        {
            this.Delete(new Customer053() { Customer053ID = customer053ID });
        }
    }


    public partial class Customer054Repository : Repository<Customer054>
    {
        public Customer054Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer054 GetByKey(string customer054ID)
        {
            return this.Query().Where(new { Customer054ID = customer054ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer054ID)
        {
            this.Delete(new Customer054() { Customer054ID = customer054ID });
        }
    }


    public partial class Customer055Repository : Repository<Customer055>
    {
        public Customer055Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer055 GetByKey(string customer055ID)
        {
            return this.Query().Where(new { Customer055ID = customer055ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer055ID)
        {
            this.Delete(new Customer055() { Customer055ID = customer055ID });
        }
    }


    public partial class Customer056Repository : Repository<Customer056>
    {
        public Customer056Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer056 GetByKey(string customer056ID)
        {
            return this.Query().Where(new { Customer056ID = customer056ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer056ID)
        {
            this.Delete(new Customer056() { Customer056ID = customer056ID });
        }
    }


    public partial class Customer057Repository : Repository<Customer057>
    {
        public Customer057Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer057 GetByKey(string customer057ID)
        {
            return this.Query().Where(new { Customer057ID = customer057ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer057ID)
        {
            this.Delete(new Customer057() { Customer057ID = customer057ID });
        }
    }


    public partial class Customer058Repository : Repository<Customer058>
    {
        public Customer058Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer058 GetByKey(string customer058ID)
        {
            return this.Query().Where(new { Customer058ID = customer058ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer058ID)
        {
            this.Delete(new Customer058() { Customer058ID = customer058ID });
        }
    }


    public partial class Customer059Repository : Repository<Customer059>
    {
        public Customer059Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer059 GetByKey(string customer059ID)
        {
            return this.Query().Where(new { Customer059ID = customer059ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer059ID)
        {
            this.Delete(new Customer059() { Customer059ID = customer059ID });
        }
    }


    public partial class Customer060Repository : Repository<Customer060>
    {
        public Customer060Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer060 GetByKey(string customer060ID)
        {
            return this.Query().Where(new { Customer060ID = customer060ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer060ID)
        {
            this.Delete(new Customer060() { Customer060ID = customer060ID });
        }
    }


    public partial class Customer061Repository : Repository<Customer061>
    {
        public Customer061Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer061 GetByKey(string customer061ID)
        {
            return this.Query().Where(new { Customer061ID = customer061ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer061ID)
        {
            this.Delete(new Customer061() { Customer061ID = customer061ID });
        }
    }


    public partial class Customer062Repository : Repository<Customer062>
    {
        public Customer062Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer062 GetByKey(string customer062ID)
        {
            return this.Query().Where(new { Customer062ID = customer062ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer062ID)
        {
            this.Delete(new Customer062() { Customer062ID = customer062ID });
        }
    }


    public partial class Customer063Repository : Repository<Customer063>
    {
        public Customer063Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer063 GetByKey(string customer063ID)
        {
            return this.Query().Where(new { Customer063ID = customer063ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer063ID)
        {
            this.Delete(new Customer063() { Customer063ID = customer063ID });
        }
    }


    public partial class Customer064Repository : Repository<Customer064>
    {
        public Customer064Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer064 GetByKey(string customer064ID)
        {
            return this.Query().Where(new { Customer064ID = customer064ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer064ID)
        {
            this.Delete(new Customer064() { Customer064ID = customer064ID });
        }
    }


    public partial class Customer065Repository : Repository<Customer065>
    {
        public Customer065Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer065 GetByKey(string customer065ID)
        {
            return this.Query().Where(new { Customer065ID = customer065ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer065ID)
        {
            this.Delete(new Customer065() { Customer065ID = customer065ID });
        }
    }


    public partial class Customer066Repository : Repository<Customer066>
    {
        public Customer066Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer066 GetByKey(string customer066ID)
        {
            return this.Query().Where(new { Customer066ID = customer066ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer066ID)
        {
            this.Delete(new Customer066() { Customer066ID = customer066ID });
        }
    }


    public partial class Customer067Repository : Repository<Customer067>
    {
        public Customer067Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer067 GetByKey(string customer067ID)
        {
            return this.Query().Where(new { Customer067ID = customer067ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer067ID)
        {
            this.Delete(new Customer067() { Customer067ID = customer067ID });
        }
    }


    public partial class Customer068Repository : Repository<Customer068>
    {
        public Customer068Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer068 GetByKey(string customer068ID)
        {
            return this.Query().Where(new { Customer068ID = customer068ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer068ID)
        {
            this.Delete(new Customer068() { Customer068ID = customer068ID });
        }
    }


    public partial class Customer069Repository : Repository<Customer069>
    {
        public Customer069Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer069 GetByKey(string customer069ID)
        {
            return this.Query().Where(new { Customer069ID = customer069ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer069ID)
        {
            this.Delete(new Customer069() { Customer069ID = customer069ID });
        }
    }


    public partial class Customer070Repository : Repository<Customer070>
    {
        public Customer070Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer070 GetByKey(string customer070ID)
        {
            return this.Query().Where(new { Customer070ID = customer070ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer070ID)
        {
            this.Delete(new Customer070() { Customer070ID = customer070ID });
        }
    }


    public partial class Customer071Repository : Repository<Customer071>
    {
        public Customer071Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer071 GetByKey(string customer071ID)
        {
            return this.Query().Where(new { Customer071ID = customer071ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer071ID)
        {
            this.Delete(new Customer071() { Customer071ID = customer071ID });
        }
    }


    public partial class Customer072Repository : Repository<Customer072>
    {
        public Customer072Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer072 GetByKey(string customer072ID)
        {
            return this.Query().Where(new { Customer072ID = customer072ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer072ID)
        {
            this.Delete(new Customer072() { Customer072ID = customer072ID });
        }
    }


    public partial class Customer073Repository : Repository<Customer073>
    {
        public Customer073Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer073 GetByKey(string customer073ID)
        {
            return this.Query().Where(new { Customer073ID = customer073ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer073ID)
        {
            this.Delete(new Customer073() { Customer073ID = customer073ID });
        }
    }


    public partial class Customer074Repository : Repository<Customer074>
    {
        public Customer074Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer074 GetByKey(string customer074ID)
        {
            return this.Query().Where(new { Customer074ID = customer074ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer074ID)
        {
            this.Delete(new Customer074() { Customer074ID = customer074ID });
        }
    }


    public partial class Customer075Repository : Repository<Customer075>
    {
        public Customer075Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer075 GetByKey(string customer075ID)
        {
            return this.Query().Where(new { Customer075ID = customer075ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer075ID)
        {
            this.Delete(new Customer075() { Customer075ID = customer075ID });
        }
    }


    public partial class Customer076Repository : Repository<Customer076>
    {
        public Customer076Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer076 GetByKey(string customer076ID)
        {
            return this.Query().Where(new { Customer076ID = customer076ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer076ID)
        {
            this.Delete(new Customer076() { Customer076ID = customer076ID });
        }
    }


    public partial class Customer077Repository : Repository<Customer077>
    {
        public Customer077Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer077 GetByKey(string customer077ID)
        {
            return this.Query().Where(new { Customer077ID = customer077ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer077ID)
        {
            this.Delete(new Customer077() { Customer077ID = customer077ID });
        }
    }


    public partial class Customer078Repository : Repository<Customer078>
    {
        public Customer078Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer078 GetByKey(string customer078ID)
        {
            return this.Query().Where(new { Customer078ID = customer078ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer078ID)
        {
            this.Delete(new Customer078() { Customer078ID = customer078ID });
        }
    }


    public partial class Customer079Repository : Repository<Customer079>
    {
        public Customer079Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer079 GetByKey(string customer079ID)
        {
            return this.Query().Where(new { Customer079ID = customer079ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer079ID)
        {
            this.Delete(new Customer079() { Customer079ID = customer079ID });
        }
    }


    public partial class Customer080Repository : Repository<Customer080>
    {
        public Customer080Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer080 GetByKey(string customer080ID)
        {
            return this.Query().Where(new { Customer080ID = customer080ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer080ID)
        {
            this.Delete(new Customer080() { Customer080ID = customer080ID });
        }
    }


    public partial class Customer081Repository : Repository<Customer081>
    {
        public Customer081Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer081 GetByKey(string customer081ID)
        {
            return this.Query().Where(new { Customer081ID = customer081ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer081ID)
        {
            this.Delete(new Customer081() { Customer081ID = customer081ID });
        }
    }


    public partial class Customer082Repository : Repository<Customer082>
    {
        public Customer082Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer082 GetByKey(string customer082ID)
        {
            return this.Query().Where(new { Customer082ID = customer082ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer082ID)
        {
            this.Delete(new Customer082() { Customer082ID = customer082ID });
        }
    }


    public partial class Customer083Repository : Repository<Customer083>
    {
        public Customer083Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer083 GetByKey(string customer083ID)
        {
            return this.Query().Where(new { Customer083ID = customer083ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer083ID)
        {
            this.Delete(new Customer083() { Customer083ID = customer083ID });
        }
    }


    public partial class Customer084Repository : Repository<Customer084>
    {
        public Customer084Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer084 GetByKey(string customer084ID)
        {
            return this.Query().Where(new { Customer084ID = customer084ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer084ID)
        {
            this.Delete(new Customer084() { Customer084ID = customer084ID });
        }
    }


    public partial class Customer085Repository : Repository<Customer085>
    {
        public Customer085Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer085 GetByKey(string customer085ID)
        {
            return this.Query().Where(new { Customer085ID = customer085ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer085ID)
        {
            this.Delete(new Customer085() { Customer085ID = customer085ID });
        }
    }


    public partial class Customer086Repository : Repository<Customer086>
    {
        public Customer086Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer086 GetByKey(string customer086ID)
        {
            return this.Query().Where(new { Customer086ID = customer086ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer086ID)
        {
            this.Delete(new Customer086() { Customer086ID = customer086ID });
        }
    }


    public partial class Customer087Repository : Repository<Customer087>
    {
        public Customer087Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer087 GetByKey(string customer087ID)
        {
            return this.Query().Where(new { Customer087ID = customer087ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer087ID)
        {
            this.Delete(new Customer087() { Customer087ID = customer087ID });
        }
    }


    public partial class Customer088Repository : Repository<Customer088>
    {
        public Customer088Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer088 GetByKey(string customer088ID)
        {
            return this.Query().Where(new { Customer088ID = customer088ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer088ID)
        {
            this.Delete(new Customer088() { Customer088ID = customer088ID });
        }
    }


    public partial class Customer089Repository : Repository<Customer089>
    {
        public Customer089Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer089 GetByKey(string customer089ID)
        {
            return this.Query().Where(new { Customer089ID = customer089ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer089ID)
        {
            this.Delete(new Customer089() { Customer089ID = customer089ID });
        }
    }


    public partial class Customer090Repository : Repository<Customer090>
    {
        public Customer090Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer090 GetByKey(string customer090ID)
        {
            return this.Query().Where(new { Customer090ID = customer090ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer090ID)
        {
            this.Delete(new Customer090() { Customer090ID = customer090ID });
        }
    }


    public partial class Customer091Repository : Repository<Customer091>
    {
        public Customer091Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer091 GetByKey(string customer091ID)
        {
            return this.Query().Where(new { Customer091ID = customer091ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer091ID)
        {
            this.Delete(new Customer091() { Customer091ID = customer091ID });
        }
    }


    public partial class Customer092Repository : Repository<Customer092>
    {
        public Customer092Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer092 GetByKey(string customer092ID)
        {
            return this.Query().Where(new { Customer092ID = customer092ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer092ID)
        {
            this.Delete(new Customer092() { Customer092ID = customer092ID });
        }
    }


    public partial class Customer093Repository : Repository<Customer093>
    {
        public Customer093Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer093 GetByKey(string customer093ID)
        {
            return this.Query().Where(new { Customer093ID = customer093ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer093ID)
        {
            this.Delete(new Customer093() { Customer093ID = customer093ID });
        }
    }


    public partial class Customer094Repository : Repository<Customer094>
    {
        public Customer094Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer094 GetByKey(string customer094ID)
        {
            return this.Query().Where(new { Customer094ID = customer094ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer094ID)
        {
            this.Delete(new Customer094() { Customer094ID = customer094ID });
        }
    }


    public partial class Customer095Repository : Repository<Customer095>
    {
        public Customer095Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer095 GetByKey(string customer095ID)
        {
            return this.Query().Where(new { Customer095ID = customer095ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer095ID)
        {
            this.Delete(new Customer095() { Customer095ID = customer095ID });
        }
    }


    public partial class Customer096Repository : Repository<Customer096>
    {
        public Customer096Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer096 GetByKey(string customer096ID)
        {
            return this.Query().Where(new { Customer096ID = customer096ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer096ID)
        {
            this.Delete(new Customer096() { Customer096ID = customer096ID });
        }
    }


    public partial class Customer097Repository : Repository<Customer097>
    {
        public Customer097Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer097 GetByKey(string customer097ID)
        {
            return this.Query().Where(new { Customer097ID = customer097ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer097ID)
        {
            this.Delete(new Customer097() { Customer097ID = customer097ID });
        }
    }


    public partial class Customer098Repository : Repository<Customer098>
    {
        public Customer098Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer098 GetByKey(string customer098ID)
        {
            return this.Query().Where(new { Customer098ID = customer098ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer098ID)
        {
            this.Delete(new Customer098() { Customer098ID = customer098ID });
        }
    }


    public partial class Customer099Repository : Repository<Customer099>
    {
        public Customer099Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer099 GetByKey(string customer099ID)
        {
            return this.Query().Where(new { Customer099ID = customer099ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer099ID)
        {
            this.Delete(new Customer099() { Customer099ID = customer099ID });
        }
    }


    public partial class Customer100Repository : Repository<Customer100>
    {
        public Customer100Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Customer100 GetByKey(string customer100ID)
        {
            return this.Query().Where(new { Customer100ID = customer100ID }).GetSingle();  
        }
        
        public void DeleteByKey(string customer100ID)
        {
            this.Delete(new Customer100() { Customer100ID = customer100ID });
        }
    }


    public partial class DiscountRepository : Repository<Discount>
    {
        public DiscountRepository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Discount GetByKey(int discountID)
        {
            return this.Query().Where(new { DiscountID = discountID }).GetSingle();  
        }
        
        public void DeleteByKey(int discountID)
        {
            this.Delete(new Discount() { DiscountID = discountID });
        }
    }


    public partial class ItemRepository : Repository<Item>
    {
        public ItemRepository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item GetByKey(string itemID)
        {
            return this.Query().Where(new { ItemID = itemID }).GetSingle();  
        }
        
        public void DeleteByKey(string itemID)
        {
            this.Delete(new Item() { ItemID = itemID });
        }
    }


    public partial class Item001Repository : Repository<Item001>
    {
        public Item001Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item001 GetByKey(string item001ID)
        {
            return this.Query().Where(new { Item001ID = item001ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item001ID)
        {
            this.Delete(new Item001() { Item001ID = item001ID });
        }
    }


    public partial class Item002Repository : Repository<Item002>
    {
        public Item002Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item002 GetByKey(string item002ID)
        {
            return this.Query().Where(new { Item002ID = item002ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item002ID)
        {
            this.Delete(new Item002() { Item002ID = item002ID });
        }
    }


    public partial class Item003Repository : Repository<Item003>
    {
        public Item003Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item003 GetByKey(string item003ID)
        {
            return this.Query().Where(new { Item003ID = item003ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item003ID)
        {
            this.Delete(new Item003() { Item003ID = item003ID });
        }
    }


    public partial class Item004Repository : Repository<Item004>
    {
        public Item004Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item004 GetByKey(string item004ID)
        {
            return this.Query().Where(new { Item004ID = item004ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item004ID)
        {
            this.Delete(new Item004() { Item004ID = item004ID });
        }
    }


    public partial class Item005Repository : Repository<Item005>
    {
        public Item005Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item005 GetByKey(string item005ID)
        {
            return this.Query().Where(new { Item005ID = item005ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item005ID)
        {
            this.Delete(new Item005() { Item005ID = item005ID });
        }
    }


    public partial class Item006Repository : Repository<Item006>
    {
        public Item006Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item006 GetByKey(string item006ID)
        {
            return this.Query().Where(new { Item006ID = item006ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item006ID)
        {
            this.Delete(new Item006() { Item006ID = item006ID });
        }
    }


    public partial class Item007Repository : Repository<Item007>
    {
        public Item007Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item007 GetByKey(string item007ID)
        {
            return this.Query().Where(new { Item007ID = item007ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item007ID)
        {
            this.Delete(new Item007() { Item007ID = item007ID });
        }
    }


    public partial class Item008Repository : Repository<Item008>
    {
        public Item008Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item008 GetByKey(string item008ID)
        {
            return this.Query().Where(new { Item008ID = item008ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item008ID)
        {
            this.Delete(new Item008() { Item008ID = item008ID });
        }
    }


    public partial class Item009Repository : Repository<Item009>
    {
        public Item009Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item009 GetByKey(string item009ID)
        {
            return this.Query().Where(new { Item009ID = item009ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item009ID)
        {
            this.Delete(new Item009() { Item009ID = item009ID });
        }
    }


    public partial class Item010Repository : Repository<Item010>
    {
        public Item010Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item010 GetByKey(string item010ID)
        {
            return this.Query().Where(new { Item010ID = item010ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item010ID)
        {
            this.Delete(new Item010() { Item010ID = item010ID });
        }
    }


    public partial class Item011Repository : Repository<Item011>
    {
        public Item011Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item011 GetByKey(string item011ID)
        {
            return this.Query().Where(new { Item011ID = item011ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item011ID)
        {
            this.Delete(new Item011() { Item011ID = item011ID });
        }
    }


    public partial class Item012Repository : Repository<Item012>
    {
        public Item012Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item012 GetByKey(string item012ID)
        {
            return this.Query().Where(new { Item012ID = item012ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item012ID)
        {
            this.Delete(new Item012() { Item012ID = item012ID });
        }
    }


    public partial class Item013Repository : Repository<Item013>
    {
        public Item013Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item013 GetByKey(string item013ID)
        {
            return this.Query().Where(new { Item013ID = item013ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item013ID)
        {
            this.Delete(new Item013() { Item013ID = item013ID });
        }
    }


    public partial class Item014Repository : Repository<Item014>
    {
        public Item014Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item014 GetByKey(string item014ID)
        {
            return this.Query().Where(new { Item014ID = item014ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item014ID)
        {
            this.Delete(new Item014() { Item014ID = item014ID });
        }
    }


    public partial class Item015Repository : Repository<Item015>
    {
        public Item015Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item015 GetByKey(string item015ID)
        {
            return this.Query().Where(new { Item015ID = item015ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item015ID)
        {
            this.Delete(new Item015() { Item015ID = item015ID });
        }
    }


    public partial class Item016Repository : Repository<Item016>
    {
        public Item016Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item016 GetByKey(string item016ID)
        {
            return this.Query().Where(new { Item016ID = item016ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item016ID)
        {
            this.Delete(new Item016() { Item016ID = item016ID });
        }
    }


    public partial class Item017Repository : Repository<Item017>
    {
        public Item017Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item017 GetByKey(string item017ID)
        {
            return this.Query().Where(new { Item017ID = item017ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item017ID)
        {
            this.Delete(new Item017() { Item017ID = item017ID });
        }
    }


    public partial class Item018Repository : Repository<Item018>
    {
        public Item018Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item018 GetByKey(string item018ID)
        {
            return this.Query().Where(new { Item018ID = item018ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item018ID)
        {
            this.Delete(new Item018() { Item018ID = item018ID });
        }
    }


    public partial class Item019Repository : Repository<Item019>
    {
        public Item019Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item019 GetByKey(string item019ID)
        {
            return this.Query().Where(new { Item019ID = item019ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item019ID)
        {
            this.Delete(new Item019() { Item019ID = item019ID });
        }
    }


    public partial class Item020Repository : Repository<Item020>
    {
        public Item020Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item020 GetByKey(string item020ID)
        {
            return this.Query().Where(new { Item020ID = item020ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item020ID)
        {
            this.Delete(new Item020() { Item020ID = item020ID });
        }
    }


    public partial class Item021Repository : Repository<Item021>
    {
        public Item021Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item021 GetByKey(string item021ID)
        {
            return this.Query().Where(new { Item021ID = item021ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item021ID)
        {
            this.Delete(new Item021() { Item021ID = item021ID });
        }
    }


    public partial class Item022Repository : Repository<Item022>
    {
        public Item022Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item022 GetByKey(string item022ID)
        {
            return this.Query().Where(new { Item022ID = item022ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item022ID)
        {
            this.Delete(new Item022() { Item022ID = item022ID });
        }
    }


    public partial class Item023Repository : Repository<Item023>
    {
        public Item023Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item023 GetByKey(string item023ID)
        {
            return this.Query().Where(new { Item023ID = item023ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item023ID)
        {
            this.Delete(new Item023() { Item023ID = item023ID });
        }
    }


    public partial class Item024Repository : Repository<Item024>
    {
        public Item024Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item024 GetByKey(string item024ID)
        {
            return this.Query().Where(new { Item024ID = item024ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item024ID)
        {
            this.Delete(new Item024() { Item024ID = item024ID });
        }
    }


    public partial class Item025Repository : Repository<Item025>
    {
        public Item025Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item025 GetByKey(string item025ID)
        {
            return this.Query().Where(new { Item025ID = item025ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item025ID)
        {
            this.Delete(new Item025() { Item025ID = item025ID });
        }
    }


    public partial class Item026Repository : Repository<Item026>
    {
        public Item026Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item026 GetByKey(string item026ID)
        {
            return this.Query().Where(new { Item026ID = item026ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item026ID)
        {
            this.Delete(new Item026() { Item026ID = item026ID });
        }
    }


    public partial class Item027Repository : Repository<Item027>
    {
        public Item027Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item027 GetByKey(string item027ID)
        {
            return this.Query().Where(new { Item027ID = item027ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item027ID)
        {
            this.Delete(new Item027() { Item027ID = item027ID });
        }
    }


    public partial class Item028Repository : Repository<Item028>
    {
        public Item028Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item028 GetByKey(string item028ID)
        {
            return this.Query().Where(new { Item028ID = item028ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item028ID)
        {
            this.Delete(new Item028() { Item028ID = item028ID });
        }
    }


    public partial class Item029Repository : Repository<Item029>
    {
        public Item029Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item029 GetByKey(string item029ID)
        {
            return this.Query().Where(new { Item029ID = item029ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item029ID)
        {
            this.Delete(new Item029() { Item029ID = item029ID });
        }
    }


    public partial class Item030Repository : Repository<Item030>
    {
        public Item030Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item030 GetByKey(string item030ID)
        {
            return this.Query().Where(new { Item030ID = item030ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item030ID)
        {
            this.Delete(new Item030() { Item030ID = item030ID });
        }
    }


    public partial class Item031Repository : Repository<Item031>
    {
        public Item031Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item031 GetByKey(string item031ID)
        {
            return this.Query().Where(new { Item031ID = item031ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item031ID)
        {
            this.Delete(new Item031() { Item031ID = item031ID });
        }
    }


    public partial class Item032Repository : Repository<Item032>
    {
        public Item032Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item032 GetByKey(string item032ID)
        {
            return this.Query().Where(new { Item032ID = item032ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item032ID)
        {
            this.Delete(new Item032() { Item032ID = item032ID });
        }
    }


    public partial class Item033Repository : Repository<Item033>
    {
        public Item033Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item033 GetByKey(string item033ID)
        {
            return this.Query().Where(new { Item033ID = item033ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item033ID)
        {
            this.Delete(new Item033() { Item033ID = item033ID });
        }
    }


    public partial class Item034Repository : Repository<Item034>
    {
        public Item034Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item034 GetByKey(string item034ID)
        {
            return this.Query().Where(new { Item034ID = item034ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item034ID)
        {
            this.Delete(new Item034() { Item034ID = item034ID });
        }
    }


    public partial class Item035Repository : Repository<Item035>
    {
        public Item035Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item035 GetByKey(string item035ID)
        {
            return this.Query().Where(new { Item035ID = item035ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item035ID)
        {
            this.Delete(new Item035() { Item035ID = item035ID });
        }
    }


    public partial class Item036Repository : Repository<Item036>
    {
        public Item036Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item036 GetByKey(string item036ID)
        {
            return this.Query().Where(new { Item036ID = item036ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item036ID)
        {
            this.Delete(new Item036() { Item036ID = item036ID });
        }
    }


    public partial class Item037Repository : Repository<Item037>
    {
        public Item037Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item037 GetByKey(string item037ID)
        {
            return this.Query().Where(new { Item037ID = item037ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item037ID)
        {
            this.Delete(new Item037() { Item037ID = item037ID });
        }
    }


    public partial class Item038Repository : Repository<Item038>
    {
        public Item038Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item038 GetByKey(string item038ID)
        {
            return this.Query().Where(new { Item038ID = item038ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item038ID)
        {
            this.Delete(new Item038() { Item038ID = item038ID });
        }
    }


    public partial class Item039Repository : Repository<Item039>
    {
        public Item039Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item039 GetByKey(string item039ID)
        {
            return this.Query().Where(new { Item039ID = item039ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item039ID)
        {
            this.Delete(new Item039() { Item039ID = item039ID });
        }
    }


    public partial class Item040Repository : Repository<Item040>
    {
        public Item040Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item040 GetByKey(string item040ID)
        {
            return this.Query().Where(new { Item040ID = item040ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item040ID)
        {
            this.Delete(new Item040() { Item040ID = item040ID });
        }
    }


    public partial class Item041Repository : Repository<Item041>
    {
        public Item041Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item041 GetByKey(string item041ID)
        {
            return this.Query().Where(new { Item041ID = item041ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item041ID)
        {
            this.Delete(new Item041() { Item041ID = item041ID });
        }
    }


    public partial class Item042Repository : Repository<Item042>
    {
        public Item042Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item042 GetByKey(string item042ID)
        {
            return this.Query().Where(new { Item042ID = item042ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item042ID)
        {
            this.Delete(new Item042() { Item042ID = item042ID });
        }
    }


    public partial class Item043Repository : Repository<Item043>
    {
        public Item043Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item043 GetByKey(string item043ID)
        {
            return this.Query().Where(new { Item043ID = item043ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item043ID)
        {
            this.Delete(new Item043() { Item043ID = item043ID });
        }
    }


    public partial class Item044Repository : Repository<Item044>
    {
        public Item044Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item044 GetByKey(string item044ID)
        {
            return this.Query().Where(new { Item044ID = item044ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item044ID)
        {
            this.Delete(new Item044() { Item044ID = item044ID });
        }
    }


    public partial class Item045Repository : Repository<Item045>
    {
        public Item045Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item045 GetByKey(string item045ID)
        {
            return this.Query().Where(new { Item045ID = item045ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item045ID)
        {
            this.Delete(new Item045() { Item045ID = item045ID });
        }
    }


    public partial class Item046Repository : Repository<Item046>
    {
        public Item046Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item046 GetByKey(string item046ID)
        {
            return this.Query().Where(new { Item046ID = item046ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item046ID)
        {
            this.Delete(new Item046() { Item046ID = item046ID });
        }
    }


    public partial class Item047Repository : Repository<Item047>
    {
        public Item047Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item047 GetByKey(string item047ID)
        {
            return this.Query().Where(new { Item047ID = item047ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item047ID)
        {
            this.Delete(new Item047() { Item047ID = item047ID });
        }
    }


    public partial class Item048Repository : Repository<Item048>
    {
        public Item048Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item048 GetByKey(string item048ID)
        {
            return this.Query().Where(new { Item048ID = item048ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item048ID)
        {
            this.Delete(new Item048() { Item048ID = item048ID });
        }
    }


    public partial class Item049Repository : Repository<Item049>
    {
        public Item049Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item049 GetByKey(string item049ID)
        {
            return this.Query().Where(new { Item049ID = item049ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item049ID)
        {
            this.Delete(new Item049() { Item049ID = item049ID });
        }
    }


    public partial class Item050Repository : Repository<Item050>
    {
        public Item050Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item050 GetByKey(string item050ID)
        {
            return this.Query().Where(new { Item050ID = item050ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item050ID)
        {
            this.Delete(new Item050() { Item050ID = item050ID });
        }
    }


    public partial class Item051Repository : Repository<Item051>
    {
        public Item051Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item051 GetByKey(string item051ID)
        {
            return this.Query().Where(new { Item051ID = item051ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item051ID)
        {
            this.Delete(new Item051() { Item051ID = item051ID });
        }
    }


    public partial class Item052Repository : Repository<Item052>
    {
        public Item052Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item052 GetByKey(string item052ID)
        {
            return this.Query().Where(new { Item052ID = item052ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item052ID)
        {
            this.Delete(new Item052() { Item052ID = item052ID });
        }
    }


    public partial class Item053Repository : Repository<Item053>
    {
        public Item053Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item053 GetByKey(string item053ID)
        {
            return this.Query().Where(new { Item053ID = item053ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item053ID)
        {
            this.Delete(new Item053() { Item053ID = item053ID });
        }
    }


    public partial class Item054Repository : Repository<Item054>
    {
        public Item054Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item054 GetByKey(string item054ID)
        {
            return this.Query().Where(new { Item054ID = item054ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item054ID)
        {
            this.Delete(new Item054() { Item054ID = item054ID });
        }
    }


    public partial class Item055Repository : Repository<Item055>
    {
        public Item055Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item055 GetByKey(string item055ID)
        {
            return this.Query().Where(new { Item055ID = item055ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item055ID)
        {
            this.Delete(new Item055() { Item055ID = item055ID });
        }
    }


    public partial class Item056Repository : Repository<Item056>
    {
        public Item056Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item056 GetByKey(string item056ID)
        {
            return this.Query().Where(new { Item056ID = item056ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item056ID)
        {
            this.Delete(new Item056() { Item056ID = item056ID });
        }
    }


    public partial class Item057Repository : Repository<Item057>
    {
        public Item057Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item057 GetByKey(string item057ID)
        {
            return this.Query().Where(new { Item057ID = item057ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item057ID)
        {
            this.Delete(new Item057() { Item057ID = item057ID });
        }
    }


    public partial class Item058Repository : Repository<Item058>
    {
        public Item058Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item058 GetByKey(string item058ID)
        {
            return this.Query().Where(new { Item058ID = item058ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item058ID)
        {
            this.Delete(new Item058() { Item058ID = item058ID });
        }
    }


    public partial class Item059Repository : Repository<Item059>
    {
        public Item059Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item059 GetByKey(string item059ID)
        {
            return this.Query().Where(new { Item059ID = item059ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item059ID)
        {
            this.Delete(new Item059() { Item059ID = item059ID });
        }
    }


    public partial class Item060Repository : Repository<Item060>
    {
        public Item060Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item060 GetByKey(string item060ID)
        {
            return this.Query().Where(new { Item060ID = item060ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item060ID)
        {
            this.Delete(new Item060() { Item060ID = item060ID });
        }
    }


    public partial class Item061Repository : Repository<Item061>
    {
        public Item061Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item061 GetByKey(string item061ID)
        {
            return this.Query().Where(new { Item061ID = item061ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item061ID)
        {
            this.Delete(new Item061() { Item061ID = item061ID });
        }
    }


    public partial class Item062Repository : Repository<Item062>
    {
        public Item062Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item062 GetByKey(string item062ID)
        {
            return this.Query().Where(new { Item062ID = item062ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item062ID)
        {
            this.Delete(new Item062() { Item062ID = item062ID });
        }
    }


    public partial class Item063Repository : Repository<Item063>
    {
        public Item063Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item063 GetByKey(string item063ID)
        {
            return this.Query().Where(new { Item063ID = item063ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item063ID)
        {
            this.Delete(new Item063() { Item063ID = item063ID });
        }
    }


    public partial class Item064Repository : Repository<Item064>
    {
        public Item064Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item064 GetByKey(string item064ID)
        {
            return this.Query().Where(new { Item064ID = item064ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item064ID)
        {
            this.Delete(new Item064() { Item064ID = item064ID });
        }
    }


    public partial class Item065Repository : Repository<Item065>
    {
        public Item065Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item065 GetByKey(string item065ID)
        {
            return this.Query().Where(new { Item065ID = item065ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item065ID)
        {
            this.Delete(new Item065() { Item065ID = item065ID });
        }
    }


    public partial class Item066Repository : Repository<Item066>
    {
        public Item066Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item066 GetByKey(string item066ID)
        {
            return this.Query().Where(new { Item066ID = item066ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item066ID)
        {
            this.Delete(new Item066() { Item066ID = item066ID });
        }
    }


    public partial class Item067Repository : Repository<Item067>
    {
        public Item067Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item067 GetByKey(string item067ID)
        {
            return this.Query().Where(new { Item067ID = item067ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item067ID)
        {
            this.Delete(new Item067() { Item067ID = item067ID });
        }
    }


    public partial class Item068Repository : Repository<Item068>
    {
        public Item068Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item068 GetByKey(string item068ID)
        {
            return this.Query().Where(new { Item068ID = item068ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item068ID)
        {
            this.Delete(new Item068() { Item068ID = item068ID });
        }
    }


    public partial class Item069Repository : Repository<Item069>
    {
        public Item069Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item069 GetByKey(string item069ID)
        {
            return this.Query().Where(new { Item069ID = item069ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item069ID)
        {
            this.Delete(new Item069() { Item069ID = item069ID });
        }
    }


    public partial class Item070Repository : Repository<Item070>
    {
        public Item070Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item070 GetByKey(string item070ID)
        {
            return this.Query().Where(new { Item070ID = item070ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item070ID)
        {
            this.Delete(new Item070() { Item070ID = item070ID });
        }
    }


    public partial class Item071Repository : Repository<Item071>
    {
        public Item071Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item071 GetByKey(string item071ID)
        {
            return this.Query().Where(new { Item071ID = item071ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item071ID)
        {
            this.Delete(new Item071() { Item071ID = item071ID });
        }
    }


    public partial class Item072Repository : Repository<Item072>
    {
        public Item072Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item072 GetByKey(string item072ID)
        {
            return this.Query().Where(new { Item072ID = item072ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item072ID)
        {
            this.Delete(new Item072() { Item072ID = item072ID });
        }
    }


    public partial class Item073Repository : Repository<Item073>
    {
        public Item073Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item073 GetByKey(string item073ID)
        {
            return this.Query().Where(new { Item073ID = item073ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item073ID)
        {
            this.Delete(new Item073() { Item073ID = item073ID });
        }
    }


    public partial class Item074Repository : Repository<Item074>
    {
        public Item074Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item074 GetByKey(string item074ID)
        {
            return this.Query().Where(new { Item074ID = item074ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item074ID)
        {
            this.Delete(new Item074() { Item074ID = item074ID });
        }
    }


    public partial class Item075Repository : Repository<Item075>
    {
        public Item075Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item075 GetByKey(string item075ID)
        {
            return this.Query().Where(new { Item075ID = item075ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item075ID)
        {
            this.Delete(new Item075() { Item075ID = item075ID });
        }
    }


    public partial class Item076Repository : Repository<Item076>
    {
        public Item076Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item076 GetByKey(string item076ID)
        {
            return this.Query().Where(new { Item076ID = item076ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item076ID)
        {
            this.Delete(new Item076() { Item076ID = item076ID });
        }
    }


    public partial class Item077Repository : Repository<Item077>
    {
        public Item077Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item077 GetByKey(string item077ID)
        {
            return this.Query().Where(new { Item077ID = item077ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item077ID)
        {
            this.Delete(new Item077() { Item077ID = item077ID });
        }
    }


    public partial class Item078Repository : Repository<Item078>
    {
        public Item078Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item078 GetByKey(string item078ID)
        {
            return this.Query().Where(new { Item078ID = item078ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item078ID)
        {
            this.Delete(new Item078() { Item078ID = item078ID });
        }
    }


    public partial class Item079Repository : Repository<Item079>
    {
        public Item079Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item079 GetByKey(string item079ID)
        {
            return this.Query().Where(new { Item079ID = item079ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item079ID)
        {
            this.Delete(new Item079() { Item079ID = item079ID });
        }
    }


    public partial class Item080Repository : Repository<Item080>
    {
        public Item080Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item080 GetByKey(string item080ID)
        {
            return this.Query().Where(new { Item080ID = item080ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item080ID)
        {
            this.Delete(new Item080() { Item080ID = item080ID });
        }
    }


    public partial class Item081Repository : Repository<Item081>
    {
        public Item081Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item081 GetByKey(string item081ID)
        {
            return this.Query().Where(new { Item081ID = item081ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item081ID)
        {
            this.Delete(new Item081() { Item081ID = item081ID });
        }
    }


    public partial class Item082Repository : Repository<Item082>
    {
        public Item082Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item082 GetByKey(string item082ID)
        {
            return this.Query().Where(new { Item082ID = item082ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item082ID)
        {
            this.Delete(new Item082() { Item082ID = item082ID });
        }
    }


    public partial class Item083Repository : Repository<Item083>
    {
        public Item083Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item083 GetByKey(string item083ID)
        {
            return this.Query().Where(new { Item083ID = item083ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item083ID)
        {
            this.Delete(new Item083() { Item083ID = item083ID });
        }
    }


    public partial class Item084Repository : Repository<Item084>
    {
        public Item084Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item084 GetByKey(string item084ID)
        {
            return this.Query().Where(new { Item084ID = item084ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item084ID)
        {
            this.Delete(new Item084() { Item084ID = item084ID });
        }
    }


    public partial class Item085Repository : Repository<Item085>
    {
        public Item085Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item085 GetByKey(string item085ID)
        {
            return this.Query().Where(new { Item085ID = item085ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item085ID)
        {
            this.Delete(new Item085() { Item085ID = item085ID });
        }
    }


    public partial class Item086Repository : Repository<Item086>
    {
        public Item086Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item086 GetByKey(string item086ID)
        {
            return this.Query().Where(new { Item086ID = item086ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item086ID)
        {
            this.Delete(new Item086() { Item086ID = item086ID });
        }
    }


    public partial class Item087Repository : Repository<Item087>
    {
        public Item087Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item087 GetByKey(string item087ID)
        {
            return this.Query().Where(new { Item087ID = item087ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item087ID)
        {
            this.Delete(new Item087() { Item087ID = item087ID });
        }
    }


    public partial class Item088Repository : Repository<Item088>
    {
        public Item088Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item088 GetByKey(string item088ID)
        {
            return this.Query().Where(new { Item088ID = item088ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item088ID)
        {
            this.Delete(new Item088() { Item088ID = item088ID });
        }
    }


    public partial class Item089Repository : Repository<Item089>
    {
        public Item089Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item089 GetByKey(string item089ID)
        {
            return this.Query().Where(new { Item089ID = item089ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item089ID)
        {
            this.Delete(new Item089() { Item089ID = item089ID });
        }
    }


    public partial class Item090Repository : Repository<Item090>
    {
        public Item090Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item090 GetByKey(string item090ID)
        {
            return this.Query().Where(new { Item090ID = item090ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item090ID)
        {
            this.Delete(new Item090() { Item090ID = item090ID });
        }
    }


    public partial class Item091Repository : Repository<Item091>
    {
        public Item091Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item091 GetByKey(string item091ID)
        {
            return this.Query().Where(new { Item091ID = item091ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item091ID)
        {
            this.Delete(new Item091() { Item091ID = item091ID });
        }
    }


    public partial class Item092Repository : Repository<Item092>
    {
        public Item092Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item092 GetByKey(string item092ID)
        {
            return this.Query().Where(new { Item092ID = item092ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item092ID)
        {
            this.Delete(new Item092() { Item092ID = item092ID });
        }
    }


    public partial class Item093Repository : Repository<Item093>
    {
        public Item093Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item093 GetByKey(string item093ID)
        {
            return this.Query().Where(new { Item093ID = item093ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item093ID)
        {
            this.Delete(new Item093() { Item093ID = item093ID });
        }
    }


    public partial class Item094Repository : Repository<Item094>
    {
        public Item094Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item094 GetByKey(string item094ID)
        {
            return this.Query().Where(new { Item094ID = item094ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item094ID)
        {
            this.Delete(new Item094() { Item094ID = item094ID });
        }
    }


    public partial class Item095Repository : Repository<Item095>
    {
        public Item095Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item095 GetByKey(string item095ID)
        {
            return this.Query().Where(new { Item095ID = item095ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item095ID)
        {
            this.Delete(new Item095() { Item095ID = item095ID });
        }
    }


    public partial class Item096Repository : Repository<Item096>
    {
        public Item096Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item096 GetByKey(string item096ID)
        {
            return this.Query().Where(new { Item096ID = item096ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item096ID)
        {
            this.Delete(new Item096() { Item096ID = item096ID });
        }
    }


    public partial class Item097Repository : Repository<Item097>
    {
        public Item097Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item097 GetByKey(string item097ID)
        {
            return this.Query().Where(new { Item097ID = item097ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item097ID)
        {
            this.Delete(new Item097() { Item097ID = item097ID });
        }
    }


    public partial class Item098Repository : Repository<Item098>
    {
        public Item098Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item098 GetByKey(string item098ID)
        {
            return this.Query().Where(new { Item098ID = item098ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item098ID)
        {
            this.Delete(new Item098() { Item098ID = item098ID });
        }
    }


    public partial class Item099Repository : Repository<Item099>
    {
        public Item099Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item099 GetByKey(string item099ID)
        {
            return this.Query().Where(new { Item099ID = item099ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item099ID)
        {
            this.Delete(new Item099() { Item099ID = item099ID });
        }
    }


    public partial class Item100Repository : Repository<Item100>
    {
        public Item100Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Item100 GetByKey(string item100ID)
        {
            return this.Query().Where(new { Item100ID = item100ID }).GetSingle();  
        }
        
        public void DeleteByKey(string item100ID)
        {
            this.Delete(new Item100() { Item100ID = item100ID });
        }
    }


    public partial class OrderRepository : Repository<Order>
    {
        public OrderRepository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order GetByKey(int orderID)
        {
            return this.Query().Where(new { OrderID = orderID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderID)
        {
            this.Delete(new Order() { OrderID = orderID });
        }
    }


    public partial class Order001Repository : Repository<Order001>
    {
        public Order001Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order001 GetByKey(int order001ID)
        {
            return this.Query().Where(new { Order001ID = order001ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order001ID)
        {
            this.Delete(new Order001() { Order001ID = order001ID });
        }
    }


    public partial class Order002Repository : Repository<Order002>
    {
        public Order002Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order002 GetByKey(int order002ID)
        {
            return this.Query().Where(new { Order002ID = order002ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order002ID)
        {
            this.Delete(new Order002() { Order002ID = order002ID });
        }
    }


    public partial class Order003Repository : Repository<Order003>
    {
        public Order003Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order003 GetByKey(int order003ID)
        {
            return this.Query().Where(new { Order003ID = order003ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order003ID)
        {
            this.Delete(new Order003() { Order003ID = order003ID });
        }
    }


    public partial class Order004Repository : Repository<Order004>
    {
        public Order004Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order004 GetByKey(int order004ID)
        {
            return this.Query().Where(new { Order004ID = order004ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order004ID)
        {
            this.Delete(new Order004() { Order004ID = order004ID });
        }
    }


    public partial class Order005Repository : Repository<Order005>
    {
        public Order005Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order005 GetByKey(int order005ID)
        {
            return this.Query().Where(new { Order005ID = order005ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order005ID)
        {
            this.Delete(new Order005() { Order005ID = order005ID });
        }
    }


    public partial class Order006Repository : Repository<Order006>
    {
        public Order006Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order006 GetByKey(int order006ID)
        {
            return this.Query().Where(new { Order006ID = order006ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order006ID)
        {
            this.Delete(new Order006() { Order006ID = order006ID });
        }
    }


    public partial class Order007Repository : Repository<Order007>
    {
        public Order007Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order007 GetByKey(int order007ID)
        {
            return this.Query().Where(new { Order007ID = order007ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order007ID)
        {
            this.Delete(new Order007() { Order007ID = order007ID });
        }
    }


    public partial class Order008Repository : Repository<Order008>
    {
        public Order008Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order008 GetByKey(int order008ID)
        {
            return this.Query().Where(new { Order008ID = order008ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order008ID)
        {
            this.Delete(new Order008() { Order008ID = order008ID });
        }
    }


    public partial class Order009Repository : Repository<Order009>
    {
        public Order009Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order009 GetByKey(int order009ID)
        {
            return this.Query().Where(new { Order009ID = order009ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order009ID)
        {
            this.Delete(new Order009() { Order009ID = order009ID });
        }
    }


    public partial class Order010Repository : Repository<Order010>
    {
        public Order010Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order010 GetByKey(int order010ID)
        {
            return this.Query().Where(new { Order010ID = order010ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order010ID)
        {
            this.Delete(new Order010() { Order010ID = order010ID });
        }
    }


    public partial class Order011Repository : Repository<Order011>
    {
        public Order011Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order011 GetByKey(int order011ID)
        {
            return this.Query().Where(new { Order011ID = order011ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order011ID)
        {
            this.Delete(new Order011() { Order011ID = order011ID });
        }
    }


    public partial class Order012Repository : Repository<Order012>
    {
        public Order012Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order012 GetByKey(int order012ID)
        {
            return this.Query().Where(new { Order012ID = order012ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order012ID)
        {
            this.Delete(new Order012() { Order012ID = order012ID });
        }
    }


    public partial class Order013Repository : Repository<Order013>
    {
        public Order013Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order013 GetByKey(int order013ID)
        {
            return this.Query().Where(new { Order013ID = order013ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order013ID)
        {
            this.Delete(new Order013() { Order013ID = order013ID });
        }
    }


    public partial class Order014Repository : Repository<Order014>
    {
        public Order014Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order014 GetByKey(int order014ID)
        {
            return this.Query().Where(new { Order014ID = order014ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order014ID)
        {
            this.Delete(new Order014() { Order014ID = order014ID });
        }
    }


    public partial class Order015Repository : Repository<Order015>
    {
        public Order015Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order015 GetByKey(int order015ID)
        {
            return this.Query().Where(new { Order015ID = order015ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order015ID)
        {
            this.Delete(new Order015() { Order015ID = order015ID });
        }
    }


    public partial class Order016Repository : Repository<Order016>
    {
        public Order016Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order016 GetByKey(int order016ID)
        {
            return this.Query().Where(new { Order016ID = order016ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order016ID)
        {
            this.Delete(new Order016() { Order016ID = order016ID });
        }
    }


    public partial class Order017Repository : Repository<Order017>
    {
        public Order017Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order017 GetByKey(int order017ID)
        {
            return this.Query().Where(new { Order017ID = order017ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order017ID)
        {
            this.Delete(new Order017() { Order017ID = order017ID });
        }
    }


    public partial class Order018Repository : Repository<Order018>
    {
        public Order018Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order018 GetByKey(int order018ID)
        {
            return this.Query().Where(new { Order018ID = order018ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order018ID)
        {
            this.Delete(new Order018() { Order018ID = order018ID });
        }
    }


    public partial class Order019Repository : Repository<Order019>
    {
        public Order019Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order019 GetByKey(int order019ID)
        {
            return this.Query().Where(new { Order019ID = order019ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order019ID)
        {
            this.Delete(new Order019() { Order019ID = order019ID });
        }
    }


    public partial class Order020Repository : Repository<Order020>
    {
        public Order020Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order020 GetByKey(int order020ID)
        {
            return this.Query().Where(new { Order020ID = order020ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order020ID)
        {
            this.Delete(new Order020() { Order020ID = order020ID });
        }
    }


    public partial class Order021Repository : Repository<Order021>
    {
        public Order021Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order021 GetByKey(int order021ID)
        {
            return this.Query().Where(new { Order021ID = order021ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order021ID)
        {
            this.Delete(new Order021() { Order021ID = order021ID });
        }
    }


    public partial class Order022Repository : Repository<Order022>
    {
        public Order022Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order022 GetByKey(int order022ID)
        {
            return this.Query().Where(new { Order022ID = order022ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order022ID)
        {
            this.Delete(new Order022() { Order022ID = order022ID });
        }
    }


    public partial class Order023Repository : Repository<Order023>
    {
        public Order023Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order023 GetByKey(int order023ID)
        {
            return this.Query().Where(new { Order023ID = order023ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order023ID)
        {
            this.Delete(new Order023() { Order023ID = order023ID });
        }
    }


    public partial class Order024Repository : Repository<Order024>
    {
        public Order024Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order024 GetByKey(int order024ID)
        {
            return this.Query().Where(new { Order024ID = order024ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order024ID)
        {
            this.Delete(new Order024() { Order024ID = order024ID });
        }
    }


    public partial class Order025Repository : Repository<Order025>
    {
        public Order025Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order025 GetByKey(int order025ID)
        {
            return this.Query().Where(new { Order025ID = order025ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order025ID)
        {
            this.Delete(new Order025() { Order025ID = order025ID });
        }
    }


    public partial class Order026Repository : Repository<Order026>
    {
        public Order026Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order026 GetByKey(int order026ID)
        {
            return this.Query().Where(new { Order026ID = order026ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order026ID)
        {
            this.Delete(new Order026() { Order026ID = order026ID });
        }
    }


    public partial class Order027Repository : Repository<Order027>
    {
        public Order027Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order027 GetByKey(int order027ID)
        {
            return this.Query().Where(new { Order027ID = order027ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order027ID)
        {
            this.Delete(new Order027() { Order027ID = order027ID });
        }
    }


    public partial class Order028Repository : Repository<Order028>
    {
        public Order028Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order028 GetByKey(int order028ID)
        {
            return this.Query().Where(new { Order028ID = order028ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order028ID)
        {
            this.Delete(new Order028() { Order028ID = order028ID });
        }
    }


    public partial class Order029Repository : Repository<Order029>
    {
        public Order029Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order029 GetByKey(int order029ID)
        {
            return this.Query().Where(new { Order029ID = order029ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order029ID)
        {
            this.Delete(new Order029() { Order029ID = order029ID });
        }
    }


    public partial class Order030Repository : Repository<Order030>
    {
        public Order030Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order030 GetByKey(int order030ID)
        {
            return this.Query().Where(new { Order030ID = order030ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order030ID)
        {
            this.Delete(new Order030() { Order030ID = order030ID });
        }
    }


    public partial class Order031Repository : Repository<Order031>
    {
        public Order031Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order031 GetByKey(int order031ID)
        {
            return this.Query().Where(new { Order031ID = order031ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order031ID)
        {
            this.Delete(new Order031() { Order031ID = order031ID });
        }
    }


    public partial class Order032Repository : Repository<Order032>
    {
        public Order032Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order032 GetByKey(int order032ID)
        {
            return this.Query().Where(new { Order032ID = order032ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order032ID)
        {
            this.Delete(new Order032() { Order032ID = order032ID });
        }
    }


    public partial class Order033Repository : Repository<Order033>
    {
        public Order033Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order033 GetByKey(int order033ID)
        {
            return this.Query().Where(new { Order033ID = order033ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order033ID)
        {
            this.Delete(new Order033() { Order033ID = order033ID });
        }
    }


    public partial class Order034Repository : Repository<Order034>
    {
        public Order034Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order034 GetByKey(int order034ID)
        {
            return this.Query().Where(new { Order034ID = order034ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order034ID)
        {
            this.Delete(new Order034() { Order034ID = order034ID });
        }
    }


    public partial class Order035Repository : Repository<Order035>
    {
        public Order035Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order035 GetByKey(int order035ID)
        {
            return this.Query().Where(new { Order035ID = order035ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order035ID)
        {
            this.Delete(new Order035() { Order035ID = order035ID });
        }
    }


    public partial class Order036Repository : Repository<Order036>
    {
        public Order036Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order036 GetByKey(int order036ID)
        {
            return this.Query().Where(new { Order036ID = order036ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order036ID)
        {
            this.Delete(new Order036() { Order036ID = order036ID });
        }
    }


    public partial class Order037Repository : Repository<Order037>
    {
        public Order037Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order037 GetByKey(int order037ID)
        {
            return this.Query().Where(new { Order037ID = order037ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order037ID)
        {
            this.Delete(new Order037() { Order037ID = order037ID });
        }
    }


    public partial class Order038Repository : Repository<Order038>
    {
        public Order038Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order038 GetByKey(int order038ID)
        {
            return this.Query().Where(new { Order038ID = order038ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order038ID)
        {
            this.Delete(new Order038() { Order038ID = order038ID });
        }
    }


    public partial class Order039Repository : Repository<Order039>
    {
        public Order039Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order039 GetByKey(int order039ID)
        {
            return this.Query().Where(new { Order039ID = order039ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order039ID)
        {
            this.Delete(new Order039() { Order039ID = order039ID });
        }
    }


    public partial class Order040Repository : Repository<Order040>
    {
        public Order040Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order040 GetByKey(int order040ID)
        {
            return this.Query().Where(new { Order040ID = order040ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order040ID)
        {
            this.Delete(new Order040() { Order040ID = order040ID });
        }
    }


    public partial class Order041Repository : Repository<Order041>
    {
        public Order041Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order041 GetByKey(int order041ID)
        {
            return this.Query().Where(new { Order041ID = order041ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order041ID)
        {
            this.Delete(new Order041() { Order041ID = order041ID });
        }
    }


    public partial class Order042Repository : Repository<Order042>
    {
        public Order042Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order042 GetByKey(int order042ID)
        {
            return this.Query().Where(new { Order042ID = order042ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order042ID)
        {
            this.Delete(new Order042() { Order042ID = order042ID });
        }
    }


    public partial class Order043Repository : Repository<Order043>
    {
        public Order043Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order043 GetByKey(int order043ID)
        {
            return this.Query().Where(new { Order043ID = order043ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order043ID)
        {
            this.Delete(new Order043() { Order043ID = order043ID });
        }
    }


    public partial class Order044Repository : Repository<Order044>
    {
        public Order044Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order044 GetByKey(int order044ID)
        {
            return this.Query().Where(new { Order044ID = order044ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order044ID)
        {
            this.Delete(new Order044() { Order044ID = order044ID });
        }
    }


    public partial class Order045Repository : Repository<Order045>
    {
        public Order045Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order045 GetByKey(int order045ID)
        {
            return this.Query().Where(new { Order045ID = order045ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order045ID)
        {
            this.Delete(new Order045() { Order045ID = order045ID });
        }
    }


    public partial class Order046Repository : Repository<Order046>
    {
        public Order046Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order046 GetByKey(int order046ID)
        {
            return this.Query().Where(new { Order046ID = order046ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order046ID)
        {
            this.Delete(new Order046() { Order046ID = order046ID });
        }
    }


    public partial class Order047Repository : Repository<Order047>
    {
        public Order047Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order047 GetByKey(int order047ID)
        {
            return this.Query().Where(new { Order047ID = order047ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order047ID)
        {
            this.Delete(new Order047() { Order047ID = order047ID });
        }
    }


    public partial class Order048Repository : Repository<Order048>
    {
        public Order048Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order048 GetByKey(int order048ID)
        {
            return this.Query().Where(new { Order048ID = order048ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order048ID)
        {
            this.Delete(new Order048() { Order048ID = order048ID });
        }
    }


    public partial class Order049Repository : Repository<Order049>
    {
        public Order049Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order049 GetByKey(int order049ID)
        {
            return this.Query().Where(new { Order049ID = order049ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order049ID)
        {
            this.Delete(new Order049() { Order049ID = order049ID });
        }
    }


    public partial class Order050Repository : Repository<Order050>
    {
        public Order050Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order050 GetByKey(int order050ID)
        {
            return this.Query().Where(new { Order050ID = order050ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order050ID)
        {
            this.Delete(new Order050() { Order050ID = order050ID });
        }
    }


    public partial class Order051Repository : Repository<Order051>
    {
        public Order051Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order051 GetByKey(int order051ID)
        {
            return this.Query().Where(new { Order051ID = order051ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order051ID)
        {
            this.Delete(new Order051() { Order051ID = order051ID });
        }
    }


    public partial class Order052Repository : Repository<Order052>
    {
        public Order052Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order052 GetByKey(int order052ID)
        {
            return this.Query().Where(new { Order052ID = order052ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order052ID)
        {
            this.Delete(new Order052() { Order052ID = order052ID });
        }
    }


    public partial class Order053Repository : Repository<Order053>
    {
        public Order053Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order053 GetByKey(int order053ID)
        {
            return this.Query().Where(new { Order053ID = order053ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order053ID)
        {
            this.Delete(new Order053() { Order053ID = order053ID });
        }
    }


    public partial class Order054Repository : Repository<Order054>
    {
        public Order054Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order054 GetByKey(int order054ID)
        {
            return this.Query().Where(new { Order054ID = order054ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order054ID)
        {
            this.Delete(new Order054() { Order054ID = order054ID });
        }
    }


    public partial class Order055Repository : Repository<Order055>
    {
        public Order055Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order055 GetByKey(int order055ID)
        {
            return this.Query().Where(new { Order055ID = order055ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order055ID)
        {
            this.Delete(new Order055() { Order055ID = order055ID });
        }
    }


    public partial class Order056Repository : Repository<Order056>
    {
        public Order056Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order056 GetByKey(int order056ID)
        {
            return this.Query().Where(new { Order056ID = order056ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order056ID)
        {
            this.Delete(new Order056() { Order056ID = order056ID });
        }
    }


    public partial class Order057Repository : Repository<Order057>
    {
        public Order057Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order057 GetByKey(int order057ID)
        {
            return this.Query().Where(new { Order057ID = order057ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order057ID)
        {
            this.Delete(new Order057() { Order057ID = order057ID });
        }
    }


    public partial class Order058Repository : Repository<Order058>
    {
        public Order058Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order058 GetByKey(int order058ID)
        {
            return this.Query().Where(new { Order058ID = order058ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order058ID)
        {
            this.Delete(new Order058() { Order058ID = order058ID });
        }
    }


    public partial class Order059Repository : Repository<Order059>
    {
        public Order059Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order059 GetByKey(int order059ID)
        {
            return this.Query().Where(new { Order059ID = order059ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order059ID)
        {
            this.Delete(new Order059() { Order059ID = order059ID });
        }
    }


    public partial class Order060Repository : Repository<Order060>
    {
        public Order060Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order060 GetByKey(int order060ID)
        {
            return this.Query().Where(new { Order060ID = order060ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order060ID)
        {
            this.Delete(new Order060() { Order060ID = order060ID });
        }
    }


    public partial class Order061Repository : Repository<Order061>
    {
        public Order061Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order061 GetByKey(int order061ID)
        {
            return this.Query().Where(new { Order061ID = order061ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order061ID)
        {
            this.Delete(new Order061() { Order061ID = order061ID });
        }
    }


    public partial class Order062Repository : Repository<Order062>
    {
        public Order062Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order062 GetByKey(int order062ID)
        {
            return this.Query().Where(new { Order062ID = order062ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order062ID)
        {
            this.Delete(new Order062() { Order062ID = order062ID });
        }
    }


    public partial class Order063Repository : Repository<Order063>
    {
        public Order063Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order063 GetByKey(int order063ID)
        {
            return this.Query().Where(new { Order063ID = order063ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order063ID)
        {
            this.Delete(new Order063() { Order063ID = order063ID });
        }
    }


    public partial class Order064Repository : Repository<Order064>
    {
        public Order064Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order064 GetByKey(int order064ID)
        {
            return this.Query().Where(new { Order064ID = order064ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order064ID)
        {
            this.Delete(new Order064() { Order064ID = order064ID });
        }
    }


    public partial class Order065Repository : Repository<Order065>
    {
        public Order065Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order065 GetByKey(int order065ID)
        {
            return this.Query().Where(new { Order065ID = order065ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order065ID)
        {
            this.Delete(new Order065() { Order065ID = order065ID });
        }
    }


    public partial class Order066Repository : Repository<Order066>
    {
        public Order066Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order066 GetByKey(int order066ID)
        {
            return this.Query().Where(new { Order066ID = order066ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order066ID)
        {
            this.Delete(new Order066() { Order066ID = order066ID });
        }
    }


    public partial class Order067Repository : Repository<Order067>
    {
        public Order067Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order067 GetByKey(int order067ID)
        {
            return this.Query().Where(new { Order067ID = order067ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order067ID)
        {
            this.Delete(new Order067() { Order067ID = order067ID });
        }
    }


    public partial class Order068Repository : Repository<Order068>
    {
        public Order068Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order068 GetByKey(int order068ID)
        {
            return this.Query().Where(new { Order068ID = order068ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order068ID)
        {
            this.Delete(new Order068() { Order068ID = order068ID });
        }
    }


    public partial class Order069Repository : Repository<Order069>
    {
        public Order069Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order069 GetByKey(int order069ID)
        {
            return this.Query().Where(new { Order069ID = order069ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order069ID)
        {
            this.Delete(new Order069() { Order069ID = order069ID });
        }
    }


    public partial class Order070Repository : Repository<Order070>
    {
        public Order070Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order070 GetByKey(int order070ID)
        {
            return this.Query().Where(new { Order070ID = order070ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order070ID)
        {
            this.Delete(new Order070() { Order070ID = order070ID });
        }
    }


    public partial class Order071Repository : Repository<Order071>
    {
        public Order071Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order071 GetByKey(int order071ID)
        {
            return this.Query().Where(new { Order071ID = order071ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order071ID)
        {
            this.Delete(new Order071() { Order071ID = order071ID });
        }
    }


    public partial class Order072Repository : Repository<Order072>
    {
        public Order072Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order072 GetByKey(int order072ID)
        {
            return this.Query().Where(new { Order072ID = order072ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order072ID)
        {
            this.Delete(new Order072() { Order072ID = order072ID });
        }
    }


    public partial class Order073Repository : Repository<Order073>
    {
        public Order073Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order073 GetByKey(int order073ID)
        {
            return this.Query().Where(new { Order073ID = order073ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order073ID)
        {
            this.Delete(new Order073() { Order073ID = order073ID });
        }
    }


    public partial class Order074Repository : Repository<Order074>
    {
        public Order074Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order074 GetByKey(int order074ID)
        {
            return this.Query().Where(new { Order074ID = order074ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order074ID)
        {
            this.Delete(new Order074() { Order074ID = order074ID });
        }
    }


    public partial class Order075Repository : Repository<Order075>
    {
        public Order075Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order075 GetByKey(int order075ID)
        {
            return this.Query().Where(new { Order075ID = order075ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order075ID)
        {
            this.Delete(new Order075() { Order075ID = order075ID });
        }
    }


    public partial class Order076Repository : Repository<Order076>
    {
        public Order076Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order076 GetByKey(int order076ID)
        {
            return this.Query().Where(new { Order076ID = order076ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order076ID)
        {
            this.Delete(new Order076() { Order076ID = order076ID });
        }
    }


    public partial class Order077Repository : Repository<Order077>
    {
        public Order077Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order077 GetByKey(int order077ID)
        {
            return this.Query().Where(new { Order077ID = order077ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order077ID)
        {
            this.Delete(new Order077() { Order077ID = order077ID });
        }
    }


    public partial class Order078Repository : Repository<Order078>
    {
        public Order078Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order078 GetByKey(int order078ID)
        {
            return this.Query().Where(new { Order078ID = order078ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order078ID)
        {
            this.Delete(new Order078() { Order078ID = order078ID });
        }
    }


    public partial class Order079Repository : Repository<Order079>
    {
        public Order079Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order079 GetByKey(int order079ID)
        {
            return this.Query().Where(new { Order079ID = order079ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order079ID)
        {
            this.Delete(new Order079() { Order079ID = order079ID });
        }
    }


    public partial class Order080Repository : Repository<Order080>
    {
        public Order080Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order080 GetByKey(int order080ID)
        {
            return this.Query().Where(new { Order080ID = order080ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order080ID)
        {
            this.Delete(new Order080() { Order080ID = order080ID });
        }
    }


    public partial class Order081Repository : Repository<Order081>
    {
        public Order081Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order081 GetByKey(int order081ID)
        {
            return this.Query().Where(new { Order081ID = order081ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order081ID)
        {
            this.Delete(new Order081() { Order081ID = order081ID });
        }
    }


    public partial class Order082Repository : Repository<Order082>
    {
        public Order082Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order082 GetByKey(int order082ID)
        {
            return this.Query().Where(new { Order082ID = order082ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order082ID)
        {
            this.Delete(new Order082() { Order082ID = order082ID });
        }
    }


    public partial class Order083Repository : Repository<Order083>
    {
        public Order083Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order083 GetByKey(int order083ID)
        {
            return this.Query().Where(new { Order083ID = order083ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order083ID)
        {
            this.Delete(new Order083() { Order083ID = order083ID });
        }
    }


    public partial class Order084Repository : Repository<Order084>
    {
        public Order084Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order084 GetByKey(int order084ID)
        {
            return this.Query().Where(new { Order084ID = order084ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order084ID)
        {
            this.Delete(new Order084() { Order084ID = order084ID });
        }
    }


    public partial class Order085Repository : Repository<Order085>
    {
        public Order085Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order085 GetByKey(int order085ID)
        {
            return this.Query().Where(new { Order085ID = order085ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order085ID)
        {
            this.Delete(new Order085() { Order085ID = order085ID });
        }
    }


    public partial class Order086Repository : Repository<Order086>
    {
        public Order086Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order086 GetByKey(int order086ID)
        {
            return this.Query().Where(new { Order086ID = order086ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order086ID)
        {
            this.Delete(new Order086() { Order086ID = order086ID });
        }
    }


    public partial class Order087Repository : Repository<Order087>
    {
        public Order087Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order087 GetByKey(int order087ID)
        {
            return this.Query().Where(new { Order087ID = order087ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order087ID)
        {
            this.Delete(new Order087() { Order087ID = order087ID });
        }
    }


    public partial class Order088Repository : Repository<Order088>
    {
        public Order088Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order088 GetByKey(int order088ID)
        {
            return this.Query().Where(new { Order088ID = order088ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order088ID)
        {
            this.Delete(new Order088() { Order088ID = order088ID });
        }
    }


    public partial class Order089Repository : Repository<Order089>
    {
        public Order089Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order089 GetByKey(int order089ID)
        {
            return this.Query().Where(new { Order089ID = order089ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order089ID)
        {
            this.Delete(new Order089() { Order089ID = order089ID });
        }
    }


    public partial class Order090Repository : Repository<Order090>
    {
        public Order090Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order090 GetByKey(int order090ID)
        {
            return this.Query().Where(new { Order090ID = order090ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order090ID)
        {
            this.Delete(new Order090() { Order090ID = order090ID });
        }
    }


    public partial class Order091Repository : Repository<Order091>
    {
        public Order091Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order091 GetByKey(int order091ID)
        {
            return this.Query().Where(new { Order091ID = order091ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order091ID)
        {
            this.Delete(new Order091() { Order091ID = order091ID });
        }
    }


    public partial class Order092Repository : Repository<Order092>
    {
        public Order092Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order092 GetByKey(int order092ID)
        {
            return this.Query().Where(new { Order092ID = order092ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order092ID)
        {
            this.Delete(new Order092() { Order092ID = order092ID });
        }
    }


    public partial class Order093Repository : Repository<Order093>
    {
        public Order093Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order093 GetByKey(int order093ID)
        {
            return this.Query().Where(new { Order093ID = order093ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order093ID)
        {
            this.Delete(new Order093() { Order093ID = order093ID });
        }
    }


    public partial class Order094Repository : Repository<Order094>
    {
        public Order094Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order094 GetByKey(int order094ID)
        {
            return this.Query().Where(new { Order094ID = order094ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order094ID)
        {
            this.Delete(new Order094() { Order094ID = order094ID });
        }
    }


    public partial class Order095Repository : Repository<Order095>
    {
        public Order095Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order095 GetByKey(int order095ID)
        {
            return this.Query().Where(new { Order095ID = order095ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order095ID)
        {
            this.Delete(new Order095() { Order095ID = order095ID });
        }
    }


    public partial class Order096Repository : Repository<Order096>
    {
        public Order096Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order096 GetByKey(int order096ID)
        {
            return this.Query().Where(new { Order096ID = order096ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order096ID)
        {
            this.Delete(new Order096() { Order096ID = order096ID });
        }
    }


    public partial class Order097Repository : Repository<Order097>
    {
        public Order097Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order097 GetByKey(int order097ID)
        {
            return this.Query().Where(new { Order097ID = order097ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order097ID)
        {
            this.Delete(new Order097() { Order097ID = order097ID });
        }
    }


    public partial class Order098Repository : Repository<Order098>
    {
        public Order098Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order098 GetByKey(int order098ID)
        {
            return this.Query().Where(new { Order098ID = order098ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order098ID)
        {
            this.Delete(new Order098() { Order098ID = order098ID });
        }
    }


    public partial class Order099Repository : Repository<Order099>
    {
        public Order099Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order099 GetByKey(int order099ID)
        {
            return this.Query().Where(new { Order099ID = order099ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order099ID)
        {
            this.Delete(new Order099() { Order099ID = order099ID });
        }
    }


    public partial class Order100Repository : Repository<Order100>
    {
        public Order100Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public Order100 GetByKey(int order100ID)
        {
            return this.Query().Where(new { Order100ID = order100ID }).GetSingle();  
        }
        
        public void DeleteByKey(int order100ID)
        {
            this.Delete(new Order100() { Order100ID = order100ID });
        }
    }


    public partial class OrderLineRepository : Repository<OrderLine>
    {
        public OrderLineRepository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine GetByKey(int orderLineID)
        {
            return this.Query().Where(new { OrderLineID = orderLineID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLineID)
        {
            this.Delete(new OrderLine() { OrderLineID = orderLineID });
        }
    }


    public partial class OrderLine001Repository : Repository<OrderLine001>
    {
        public OrderLine001Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine001 GetByKey(int orderLine001ID)
        {
            return this.Query().Where(new { OrderLine001ID = orderLine001ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine001ID)
        {
            this.Delete(new OrderLine001() { OrderLine001ID = orderLine001ID });
        }
    }


    public partial class OrderLine002Repository : Repository<OrderLine002>
    {
        public OrderLine002Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine002 GetByKey(int orderLine002ID)
        {
            return this.Query().Where(new { OrderLine002ID = orderLine002ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine002ID)
        {
            this.Delete(new OrderLine002() { OrderLine002ID = orderLine002ID });
        }
    }


    public partial class OrderLine003Repository : Repository<OrderLine003>
    {
        public OrderLine003Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine003 GetByKey(int orderLine003ID)
        {
            return this.Query().Where(new { OrderLine003ID = orderLine003ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine003ID)
        {
            this.Delete(new OrderLine003() { OrderLine003ID = orderLine003ID });
        }
    }


    public partial class OrderLine004Repository : Repository<OrderLine004>
    {
        public OrderLine004Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine004 GetByKey(int orderLine004ID)
        {
            return this.Query().Where(new { OrderLine004ID = orderLine004ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine004ID)
        {
            this.Delete(new OrderLine004() { OrderLine004ID = orderLine004ID });
        }
    }


    public partial class OrderLine005Repository : Repository<OrderLine005>
    {
        public OrderLine005Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine005 GetByKey(int orderLine005ID)
        {
            return this.Query().Where(new { OrderLine005ID = orderLine005ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine005ID)
        {
            this.Delete(new OrderLine005() { OrderLine005ID = orderLine005ID });
        }
    }


    public partial class OrderLine006Repository : Repository<OrderLine006>
    {
        public OrderLine006Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine006 GetByKey(int orderLine006ID)
        {
            return this.Query().Where(new { OrderLine006ID = orderLine006ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine006ID)
        {
            this.Delete(new OrderLine006() { OrderLine006ID = orderLine006ID });
        }
    }


    public partial class OrderLine007Repository : Repository<OrderLine007>
    {
        public OrderLine007Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine007 GetByKey(int orderLine007ID)
        {
            return this.Query().Where(new { OrderLine007ID = orderLine007ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine007ID)
        {
            this.Delete(new OrderLine007() { OrderLine007ID = orderLine007ID });
        }
    }


    public partial class OrderLine008Repository : Repository<OrderLine008>
    {
        public OrderLine008Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine008 GetByKey(int orderLine008ID)
        {
            return this.Query().Where(new { OrderLine008ID = orderLine008ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine008ID)
        {
            this.Delete(new OrderLine008() { OrderLine008ID = orderLine008ID });
        }
    }


    public partial class OrderLine009Repository : Repository<OrderLine009>
    {
        public OrderLine009Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine009 GetByKey(int orderLine009ID)
        {
            return this.Query().Where(new { OrderLine009ID = orderLine009ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine009ID)
        {
            this.Delete(new OrderLine009() { OrderLine009ID = orderLine009ID });
        }
    }


    public partial class OrderLine010Repository : Repository<OrderLine010>
    {
        public OrderLine010Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine010 GetByKey(int orderLine010ID)
        {
            return this.Query().Where(new { OrderLine010ID = orderLine010ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine010ID)
        {
            this.Delete(new OrderLine010() { OrderLine010ID = orderLine010ID });
        }
    }


    public partial class OrderLine011Repository : Repository<OrderLine011>
    {
        public OrderLine011Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine011 GetByKey(int orderLine011ID)
        {
            return this.Query().Where(new { OrderLine011ID = orderLine011ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine011ID)
        {
            this.Delete(new OrderLine011() { OrderLine011ID = orderLine011ID });
        }
    }


    public partial class OrderLine012Repository : Repository<OrderLine012>
    {
        public OrderLine012Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine012 GetByKey(int orderLine012ID)
        {
            return this.Query().Where(new { OrderLine012ID = orderLine012ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine012ID)
        {
            this.Delete(new OrderLine012() { OrderLine012ID = orderLine012ID });
        }
    }


    public partial class OrderLine013Repository : Repository<OrderLine013>
    {
        public OrderLine013Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine013 GetByKey(int orderLine013ID)
        {
            return this.Query().Where(new { OrderLine013ID = orderLine013ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine013ID)
        {
            this.Delete(new OrderLine013() { OrderLine013ID = orderLine013ID });
        }
    }


    public partial class OrderLine014Repository : Repository<OrderLine014>
    {
        public OrderLine014Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine014 GetByKey(int orderLine014ID)
        {
            return this.Query().Where(new { OrderLine014ID = orderLine014ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine014ID)
        {
            this.Delete(new OrderLine014() { OrderLine014ID = orderLine014ID });
        }
    }


    public partial class OrderLine015Repository : Repository<OrderLine015>
    {
        public OrderLine015Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine015 GetByKey(int orderLine015ID)
        {
            return this.Query().Where(new { OrderLine015ID = orderLine015ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine015ID)
        {
            this.Delete(new OrderLine015() { OrderLine015ID = orderLine015ID });
        }
    }


    public partial class OrderLine016Repository : Repository<OrderLine016>
    {
        public OrderLine016Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine016 GetByKey(int orderLine016ID)
        {
            return this.Query().Where(new { OrderLine016ID = orderLine016ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine016ID)
        {
            this.Delete(new OrderLine016() { OrderLine016ID = orderLine016ID });
        }
    }


    public partial class OrderLine017Repository : Repository<OrderLine017>
    {
        public OrderLine017Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine017 GetByKey(int orderLine017ID)
        {
            return this.Query().Where(new { OrderLine017ID = orderLine017ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine017ID)
        {
            this.Delete(new OrderLine017() { OrderLine017ID = orderLine017ID });
        }
    }


    public partial class OrderLine018Repository : Repository<OrderLine018>
    {
        public OrderLine018Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine018 GetByKey(int orderLine018ID)
        {
            return this.Query().Where(new { OrderLine018ID = orderLine018ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine018ID)
        {
            this.Delete(new OrderLine018() { OrderLine018ID = orderLine018ID });
        }
    }


    public partial class OrderLine019Repository : Repository<OrderLine019>
    {
        public OrderLine019Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine019 GetByKey(int orderLine019ID)
        {
            return this.Query().Where(new { OrderLine019ID = orderLine019ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine019ID)
        {
            this.Delete(new OrderLine019() { OrderLine019ID = orderLine019ID });
        }
    }


    public partial class OrderLine020Repository : Repository<OrderLine020>
    {
        public OrderLine020Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine020 GetByKey(int orderLine020ID)
        {
            return this.Query().Where(new { OrderLine020ID = orderLine020ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine020ID)
        {
            this.Delete(new OrderLine020() { OrderLine020ID = orderLine020ID });
        }
    }


    public partial class OrderLine021Repository : Repository<OrderLine021>
    {
        public OrderLine021Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine021 GetByKey(int orderLine021ID)
        {
            return this.Query().Where(new { OrderLine021ID = orderLine021ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine021ID)
        {
            this.Delete(new OrderLine021() { OrderLine021ID = orderLine021ID });
        }
    }


    public partial class OrderLine022Repository : Repository<OrderLine022>
    {
        public OrderLine022Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine022 GetByKey(int orderLine022ID)
        {
            return this.Query().Where(new { OrderLine022ID = orderLine022ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine022ID)
        {
            this.Delete(new OrderLine022() { OrderLine022ID = orderLine022ID });
        }
    }


    public partial class OrderLine023Repository : Repository<OrderLine023>
    {
        public OrderLine023Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine023 GetByKey(int orderLine023ID)
        {
            return this.Query().Where(new { OrderLine023ID = orderLine023ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine023ID)
        {
            this.Delete(new OrderLine023() { OrderLine023ID = orderLine023ID });
        }
    }


    public partial class OrderLine024Repository : Repository<OrderLine024>
    {
        public OrderLine024Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine024 GetByKey(int orderLine024ID)
        {
            return this.Query().Where(new { OrderLine024ID = orderLine024ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine024ID)
        {
            this.Delete(new OrderLine024() { OrderLine024ID = orderLine024ID });
        }
    }


    public partial class OrderLine025Repository : Repository<OrderLine025>
    {
        public OrderLine025Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine025 GetByKey(int orderLine025ID)
        {
            return this.Query().Where(new { OrderLine025ID = orderLine025ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine025ID)
        {
            this.Delete(new OrderLine025() { OrderLine025ID = orderLine025ID });
        }
    }


    public partial class OrderLine026Repository : Repository<OrderLine026>
    {
        public OrderLine026Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine026 GetByKey(int orderLine026ID)
        {
            return this.Query().Where(new { OrderLine026ID = orderLine026ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine026ID)
        {
            this.Delete(new OrderLine026() { OrderLine026ID = orderLine026ID });
        }
    }


    public partial class OrderLine027Repository : Repository<OrderLine027>
    {
        public OrderLine027Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine027 GetByKey(int orderLine027ID)
        {
            return this.Query().Where(new { OrderLine027ID = orderLine027ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine027ID)
        {
            this.Delete(new OrderLine027() { OrderLine027ID = orderLine027ID });
        }
    }


    public partial class OrderLine028Repository : Repository<OrderLine028>
    {
        public OrderLine028Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine028 GetByKey(int orderLine028ID)
        {
            return this.Query().Where(new { OrderLine028ID = orderLine028ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine028ID)
        {
            this.Delete(new OrderLine028() { OrderLine028ID = orderLine028ID });
        }
    }


    public partial class OrderLine029Repository : Repository<OrderLine029>
    {
        public OrderLine029Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine029 GetByKey(int orderLine029ID)
        {
            return this.Query().Where(new { OrderLine029ID = orderLine029ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine029ID)
        {
            this.Delete(new OrderLine029() { OrderLine029ID = orderLine029ID });
        }
    }


    public partial class OrderLine030Repository : Repository<OrderLine030>
    {
        public OrderLine030Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine030 GetByKey(int orderLine030ID)
        {
            return this.Query().Where(new { OrderLine030ID = orderLine030ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine030ID)
        {
            this.Delete(new OrderLine030() { OrderLine030ID = orderLine030ID });
        }
    }


    public partial class OrderLine031Repository : Repository<OrderLine031>
    {
        public OrderLine031Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine031 GetByKey(int orderLine031ID)
        {
            return this.Query().Where(new { OrderLine031ID = orderLine031ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine031ID)
        {
            this.Delete(new OrderLine031() { OrderLine031ID = orderLine031ID });
        }
    }


    public partial class OrderLine032Repository : Repository<OrderLine032>
    {
        public OrderLine032Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine032 GetByKey(int orderLine032ID)
        {
            return this.Query().Where(new { OrderLine032ID = orderLine032ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine032ID)
        {
            this.Delete(new OrderLine032() { OrderLine032ID = orderLine032ID });
        }
    }


    public partial class OrderLine033Repository : Repository<OrderLine033>
    {
        public OrderLine033Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine033 GetByKey(int orderLine033ID)
        {
            return this.Query().Where(new { OrderLine033ID = orderLine033ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine033ID)
        {
            this.Delete(new OrderLine033() { OrderLine033ID = orderLine033ID });
        }
    }


    public partial class OrderLine034Repository : Repository<OrderLine034>
    {
        public OrderLine034Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine034 GetByKey(int orderLine034ID)
        {
            return this.Query().Where(new { OrderLine034ID = orderLine034ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine034ID)
        {
            this.Delete(new OrderLine034() { OrderLine034ID = orderLine034ID });
        }
    }


    public partial class OrderLine035Repository : Repository<OrderLine035>
    {
        public OrderLine035Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine035 GetByKey(int orderLine035ID)
        {
            return this.Query().Where(new { OrderLine035ID = orderLine035ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine035ID)
        {
            this.Delete(new OrderLine035() { OrderLine035ID = orderLine035ID });
        }
    }


    public partial class OrderLine036Repository : Repository<OrderLine036>
    {
        public OrderLine036Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine036 GetByKey(int orderLine036ID)
        {
            return this.Query().Where(new { OrderLine036ID = orderLine036ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine036ID)
        {
            this.Delete(new OrderLine036() { OrderLine036ID = orderLine036ID });
        }
    }


    public partial class OrderLine037Repository : Repository<OrderLine037>
    {
        public OrderLine037Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine037 GetByKey(int orderLine037ID)
        {
            return this.Query().Where(new { OrderLine037ID = orderLine037ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine037ID)
        {
            this.Delete(new OrderLine037() { OrderLine037ID = orderLine037ID });
        }
    }


    public partial class OrderLine038Repository : Repository<OrderLine038>
    {
        public OrderLine038Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine038 GetByKey(int orderLine038ID)
        {
            return this.Query().Where(new { OrderLine038ID = orderLine038ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine038ID)
        {
            this.Delete(new OrderLine038() { OrderLine038ID = orderLine038ID });
        }
    }


    public partial class OrderLine039Repository : Repository<OrderLine039>
    {
        public OrderLine039Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine039 GetByKey(int orderLine039ID)
        {
            return this.Query().Where(new { OrderLine039ID = orderLine039ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine039ID)
        {
            this.Delete(new OrderLine039() { OrderLine039ID = orderLine039ID });
        }
    }


    public partial class OrderLine040Repository : Repository<OrderLine040>
    {
        public OrderLine040Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine040 GetByKey(int orderLine040ID)
        {
            return this.Query().Where(new { OrderLine040ID = orderLine040ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine040ID)
        {
            this.Delete(new OrderLine040() { OrderLine040ID = orderLine040ID });
        }
    }


    public partial class OrderLine041Repository : Repository<OrderLine041>
    {
        public OrderLine041Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine041 GetByKey(int orderLine041ID)
        {
            return this.Query().Where(new { OrderLine041ID = orderLine041ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine041ID)
        {
            this.Delete(new OrderLine041() { OrderLine041ID = orderLine041ID });
        }
    }


    public partial class OrderLine042Repository : Repository<OrderLine042>
    {
        public OrderLine042Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine042 GetByKey(int orderLine042ID)
        {
            return this.Query().Where(new { OrderLine042ID = orderLine042ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine042ID)
        {
            this.Delete(new OrderLine042() { OrderLine042ID = orderLine042ID });
        }
    }


    public partial class OrderLine043Repository : Repository<OrderLine043>
    {
        public OrderLine043Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine043 GetByKey(int orderLine043ID)
        {
            return this.Query().Where(new { OrderLine043ID = orderLine043ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine043ID)
        {
            this.Delete(new OrderLine043() { OrderLine043ID = orderLine043ID });
        }
    }


    public partial class OrderLine044Repository : Repository<OrderLine044>
    {
        public OrderLine044Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine044 GetByKey(int orderLine044ID)
        {
            return this.Query().Where(new { OrderLine044ID = orderLine044ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine044ID)
        {
            this.Delete(new OrderLine044() { OrderLine044ID = orderLine044ID });
        }
    }


    public partial class OrderLine045Repository : Repository<OrderLine045>
    {
        public OrderLine045Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine045 GetByKey(int orderLine045ID)
        {
            return this.Query().Where(new { OrderLine045ID = orderLine045ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine045ID)
        {
            this.Delete(new OrderLine045() { OrderLine045ID = orderLine045ID });
        }
    }


    public partial class OrderLine046Repository : Repository<OrderLine046>
    {
        public OrderLine046Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine046 GetByKey(int orderLine046ID)
        {
            return this.Query().Where(new { OrderLine046ID = orderLine046ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine046ID)
        {
            this.Delete(new OrderLine046() { OrderLine046ID = orderLine046ID });
        }
    }


    public partial class OrderLine047Repository : Repository<OrderLine047>
    {
        public OrderLine047Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine047 GetByKey(int orderLine047ID)
        {
            return this.Query().Where(new { OrderLine047ID = orderLine047ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine047ID)
        {
            this.Delete(new OrderLine047() { OrderLine047ID = orderLine047ID });
        }
    }


    public partial class OrderLine048Repository : Repository<OrderLine048>
    {
        public OrderLine048Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine048 GetByKey(int orderLine048ID)
        {
            return this.Query().Where(new { OrderLine048ID = orderLine048ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine048ID)
        {
            this.Delete(new OrderLine048() { OrderLine048ID = orderLine048ID });
        }
    }


    public partial class OrderLine049Repository : Repository<OrderLine049>
    {
        public OrderLine049Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine049 GetByKey(int orderLine049ID)
        {
            return this.Query().Where(new { OrderLine049ID = orderLine049ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine049ID)
        {
            this.Delete(new OrderLine049() { OrderLine049ID = orderLine049ID });
        }
    }


    public partial class OrderLine050Repository : Repository<OrderLine050>
    {
        public OrderLine050Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine050 GetByKey(int orderLine050ID)
        {
            return this.Query().Where(new { OrderLine050ID = orderLine050ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine050ID)
        {
            this.Delete(new OrderLine050() { OrderLine050ID = orderLine050ID });
        }
    }


    public partial class OrderLine051Repository : Repository<OrderLine051>
    {
        public OrderLine051Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine051 GetByKey(int orderLine051ID)
        {
            return this.Query().Where(new { OrderLine051ID = orderLine051ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine051ID)
        {
            this.Delete(new OrderLine051() { OrderLine051ID = orderLine051ID });
        }
    }


    public partial class OrderLine052Repository : Repository<OrderLine052>
    {
        public OrderLine052Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine052 GetByKey(int orderLine052ID)
        {
            return this.Query().Where(new { OrderLine052ID = orderLine052ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine052ID)
        {
            this.Delete(new OrderLine052() { OrderLine052ID = orderLine052ID });
        }
    }


    public partial class OrderLine053Repository : Repository<OrderLine053>
    {
        public OrderLine053Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine053 GetByKey(int orderLine053ID)
        {
            return this.Query().Where(new { OrderLine053ID = orderLine053ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine053ID)
        {
            this.Delete(new OrderLine053() { OrderLine053ID = orderLine053ID });
        }
    }


    public partial class OrderLine054Repository : Repository<OrderLine054>
    {
        public OrderLine054Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine054 GetByKey(int orderLine054ID)
        {
            return this.Query().Where(new { OrderLine054ID = orderLine054ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine054ID)
        {
            this.Delete(new OrderLine054() { OrderLine054ID = orderLine054ID });
        }
    }


    public partial class OrderLine055Repository : Repository<OrderLine055>
    {
        public OrderLine055Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine055 GetByKey(int orderLine055ID)
        {
            return this.Query().Where(new { OrderLine055ID = orderLine055ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine055ID)
        {
            this.Delete(new OrderLine055() { OrderLine055ID = orderLine055ID });
        }
    }


    public partial class OrderLine056Repository : Repository<OrderLine056>
    {
        public OrderLine056Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine056 GetByKey(int orderLine056ID)
        {
            return this.Query().Where(new { OrderLine056ID = orderLine056ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine056ID)
        {
            this.Delete(new OrderLine056() { OrderLine056ID = orderLine056ID });
        }
    }


    public partial class OrderLine057Repository : Repository<OrderLine057>
    {
        public OrderLine057Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine057 GetByKey(int orderLine057ID)
        {
            return this.Query().Where(new { OrderLine057ID = orderLine057ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine057ID)
        {
            this.Delete(new OrderLine057() { OrderLine057ID = orderLine057ID });
        }
    }


    public partial class OrderLine058Repository : Repository<OrderLine058>
    {
        public OrderLine058Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine058 GetByKey(int orderLine058ID)
        {
            return this.Query().Where(new { OrderLine058ID = orderLine058ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine058ID)
        {
            this.Delete(new OrderLine058() { OrderLine058ID = orderLine058ID });
        }
    }


    public partial class OrderLine059Repository : Repository<OrderLine059>
    {
        public OrderLine059Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine059 GetByKey(int orderLine059ID)
        {
            return this.Query().Where(new { OrderLine059ID = orderLine059ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine059ID)
        {
            this.Delete(new OrderLine059() { OrderLine059ID = orderLine059ID });
        }
    }


    public partial class OrderLine060Repository : Repository<OrderLine060>
    {
        public OrderLine060Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine060 GetByKey(int orderLine060ID)
        {
            return this.Query().Where(new { OrderLine060ID = orderLine060ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine060ID)
        {
            this.Delete(new OrderLine060() { OrderLine060ID = orderLine060ID });
        }
    }


    public partial class OrderLine061Repository : Repository<OrderLine061>
    {
        public OrderLine061Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine061 GetByKey(int orderLine061ID)
        {
            return this.Query().Where(new { OrderLine061ID = orderLine061ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine061ID)
        {
            this.Delete(new OrderLine061() { OrderLine061ID = orderLine061ID });
        }
    }


    public partial class OrderLine062Repository : Repository<OrderLine062>
    {
        public OrderLine062Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine062 GetByKey(int orderLine062ID)
        {
            return this.Query().Where(new { OrderLine062ID = orderLine062ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine062ID)
        {
            this.Delete(new OrderLine062() { OrderLine062ID = orderLine062ID });
        }
    }


    public partial class OrderLine063Repository : Repository<OrderLine063>
    {
        public OrderLine063Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine063 GetByKey(int orderLine063ID)
        {
            return this.Query().Where(new { OrderLine063ID = orderLine063ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine063ID)
        {
            this.Delete(new OrderLine063() { OrderLine063ID = orderLine063ID });
        }
    }


    public partial class OrderLine064Repository : Repository<OrderLine064>
    {
        public OrderLine064Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine064 GetByKey(int orderLine064ID)
        {
            return this.Query().Where(new { OrderLine064ID = orderLine064ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine064ID)
        {
            this.Delete(new OrderLine064() { OrderLine064ID = orderLine064ID });
        }
    }


    public partial class OrderLine065Repository : Repository<OrderLine065>
    {
        public OrderLine065Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine065 GetByKey(int orderLine065ID)
        {
            return this.Query().Where(new { OrderLine065ID = orderLine065ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine065ID)
        {
            this.Delete(new OrderLine065() { OrderLine065ID = orderLine065ID });
        }
    }


    public partial class OrderLine066Repository : Repository<OrderLine066>
    {
        public OrderLine066Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine066 GetByKey(int orderLine066ID)
        {
            return this.Query().Where(new { OrderLine066ID = orderLine066ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine066ID)
        {
            this.Delete(new OrderLine066() { OrderLine066ID = orderLine066ID });
        }
    }


    public partial class OrderLine067Repository : Repository<OrderLine067>
    {
        public OrderLine067Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine067 GetByKey(int orderLine067ID)
        {
            return this.Query().Where(new { OrderLine067ID = orderLine067ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine067ID)
        {
            this.Delete(new OrderLine067() { OrderLine067ID = orderLine067ID });
        }
    }


    public partial class OrderLine068Repository : Repository<OrderLine068>
    {
        public OrderLine068Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine068 GetByKey(int orderLine068ID)
        {
            return this.Query().Where(new { OrderLine068ID = orderLine068ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine068ID)
        {
            this.Delete(new OrderLine068() { OrderLine068ID = orderLine068ID });
        }
    }


    public partial class OrderLine069Repository : Repository<OrderLine069>
    {
        public OrderLine069Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine069 GetByKey(int orderLine069ID)
        {
            return this.Query().Where(new { OrderLine069ID = orderLine069ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine069ID)
        {
            this.Delete(new OrderLine069() { OrderLine069ID = orderLine069ID });
        }
    }


    public partial class OrderLine070Repository : Repository<OrderLine070>
    {
        public OrderLine070Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine070 GetByKey(int orderLine070ID)
        {
            return this.Query().Where(new { OrderLine070ID = orderLine070ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine070ID)
        {
            this.Delete(new OrderLine070() { OrderLine070ID = orderLine070ID });
        }
    }


    public partial class OrderLine071Repository : Repository<OrderLine071>
    {
        public OrderLine071Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine071 GetByKey(int orderLine071ID)
        {
            return this.Query().Where(new { OrderLine071ID = orderLine071ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine071ID)
        {
            this.Delete(new OrderLine071() { OrderLine071ID = orderLine071ID });
        }
    }


    public partial class OrderLine072Repository : Repository<OrderLine072>
    {
        public OrderLine072Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine072 GetByKey(int orderLine072ID)
        {
            return this.Query().Where(new { OrderLine072ID = orderLine072ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine072ID)
        {
            this.Delete(new OrderLine072() { OrderLine072ID = orderLine072ID });
        }
    }


    public partial class OrderLine073Repository : Repository<OrderLine073>
    {
        public OrderLine073Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine073 GetByKey(int orderLine073ID)
        {
            return this.Query().Where(new { OrderLine073ID = orderLine073ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine073ID)
        {
            this.Delete(new OrderLine073() { OrderLine073ID = orderLine073ID });
        }
    }


    public partial class OrderLine074Repository : Repository<OrderLine074>
    {
        public OrderLine074Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine074 GetByKey(int orderLine074ID)
        {
            return this.Query().Where(new { OrderLine074ID = orderLine074ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine074ID)
        {
            this.Delete(new OrderLine074() { OrderLine074ID = orderLine074ID });
        }
    }


    public partial class OrderLine075Repository : Repository<OrderLine075>
    {
        public OrderLine075Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine075 GetByKey(int orderLine075ID)
        {
            return this.Query().Where(new { OrderLine075ID = orderLine075ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine075ID)
        {
            this.Delete(new OrderLine075() { OrderLine075ID = orderLine075ID });
        }
    }


    public partial class OrderLine076Repository : Repository<OrderLine076>
    {
        public OrderLine076Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine076 GetByKey(int orderLine076ID)
        {
            return this.Query().Where(new { OrderLine076ID = orderLine076ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine076ID)
        {
            this.Delete(new OrderLine076() { OrderLine076ID = orderLine076ID });
        }
    }


    public partial class OrderLine077Repository : Repository<OrderLine077>
    {
        public OrderLine077Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine077 GetByKey(int orderLine077ID)
        {
            return this.Query().Where(new { OrderLine077ID = orderLine077ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine077ID)
        {
            this.Delete(new OrderLine077() { OrderLine077ID = orderLine077ID });
        }
    }


    public partial class OrderLine078Repository : Repository<OrderLine078>
    {
        public OrderLine078Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine078 GetByKey(int orderLine078ID)
        {
            return this.Query().Where(new { OrderLine078ID = orderLine078ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine078ID)
        {
            this.Delete(new OrderLine078() { OrderLine078ID = orderLine078ID });
        }
    }


    public partial class OrderLine079Repository : Repository<OrderLine079>
    {
        public OrderLine079Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine079 GetByKey(int orderLine079ID)
        {
            return this.Query().Where(new { OrderLine079ID = orderLine079ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine079ID)
        {
            this.Delete(new OrderLine079() { OrderLine079ID = orderLine079ID });
        }
    }


    public partial class OrderLine080Repository : Repository<OrderLine080>
    {
        public OrderLine080Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine080 GetByKey(int orderLine080ID)
        {
            return this.Query().Where(new { OrderLine080ID = orderLine080ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine080ID)
        {
            this.Delete(new OrderLine080() { OrderLine080ID = orderLine080ID });
        }
    }


    public partial class OrderLine081Repository : Repository<OrderLine081>
    {
        public OrderLine081Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine081 GetByKey(int orderLine081ID)
        {
            return this.Query().Where(new { OrderLine081ID = orderLine081ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine081ID)
        {
            this.Delete(new OrderLine081() { OrderLine081ID = orderLine081ID });
        }
    }


    public partial class OrderLine082Repository : Repository<OrderLine082>
    {
        public OrderLine082Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine082 GetByKey(int orderLine082ID)
        {
            return this.Query().Where(new { OrderLine082ID = orderLine082ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine082ID)
        {
            this.Delete(new OrderLine082() { OrderLine082ID = orderLine082ID });
        }
    }


    public partial class OrderLine083Repository : Repository<OrderLine083>
    {
        public OrderLine083Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine083 GetByKey(int orderLine083ID)
        {
            return this.Query().Where(new { OrderLine083ID = orderLine083ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine083ID)
        {
            this.Delete(new OrderLine083() { OrderLine083ID = orderLine083ID });
        }
    }


    public partial class OrderLine084Repository : Repository<OrderLine084>
    {
        public OrderLine084Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine084 GetByKey(int orderLine084ID)
        {
            return this.Query().Where(new { OrderLine084ID = orderLine084ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine084ID)
        {
            this.Delete(new OrderLine084() { OrderLine084ID = orderLine084ID });
        }
    }


    public partial class OrderLine085Repository : Repository<OrderLine085>
    {
        public OrderLine085Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine085 GetByKey(int orderLine085ID)
        {
            return this.Query().Where(new { OrderLine085ID = orderLine085ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine085ID)
        {
            this.Delete(new OrderLine085() { OrderLine085ID = orderLine085ID });
        }
    }


    public partial class OrderLine086Repository : Repository<OrderLine086>
    {
        public OrderLine086Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine086 GetByKey(int orderLine086ID)
        {
            return this.Query().Where(new { OrderLine086ID = orderLine086ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine086ID)
        {
            this.Delete(new OrderLine086() { OrderLine086ID = orderLine086ID });
        }
    }


    public partial class OrderLine087Repository : Repository<OrderLine087>
    {
        public OrderLine087Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine087 GetByKey(int orderLine087ID)
        {
            return this.Query().Where(new { OrderLine087ID = orderLine087ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine087ID)
        {
            this.Delete(new OrderLine087() { OrderLine087ID = orderLine087ID });
        }
    }


    public partial class OrderLine088Repository : Repository<OrderLine088>
    {
        public OrderLine088Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine088 GetByKey(int orderLine088ID)
        {
            return this.Query().Where(new { OrderLine088ID = orderLine088ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine088ID)
        {
            this.Delete(new OrderLine088() { OrderLine088ID = orderLine088ID });
        }
    }


    public partial class OrderLine089Repository : Repository<OrderLine089>
    {
        public OrderLine089Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine089 GetByKey(int orderLine089ID)
        {
            return this.Query().Where(new { OrderLine089ID = orderLine089ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine089ID)
        {
            this.Delete(new OrderLine089() { OrderLine089ID = orderLine089ID });
        }
    }


    public partial class OrderLine090Repository : Repository<OrderLine090>
    {
        public OrderLine090Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine090 GetByKey(int orderLine090ID)
        {
            return this.Query().Where(new { OrderLine090ID = orderLine090ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine090ID)
        {
            this.Delete(new OrderLine090() { OrderLine090ID = orderLine090ID });
        }
    }


    public partial class OrderLine091Repository : Repository<OrderLine091>
    {
        public OrderLine091Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine091 GetByKey(int orderLine091ID)
        {
            return this.Query().Where(new { OrderLine091ID = orderLine091ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine091ID)
        {
            this.Delete(new OrderLine091() { OrderLine091ID = orderLine091ID });
        }
    }


    public partial class OrderLine092Repository : Repository<OrderLine092>
    {
        public OrderLine092Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine092 GetByKey(int orderLine092ID)
        {
            return this.Query().Where(new { OrderLine092ID = orderLine092ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine092ID)
        {
            this.Delete(new OrderLine092() { OrderLine092ID = orderLine092ID });
        }
    }


    public partial class OrderLine093Repository : Repository<OrderLine093>
    {
        public OrderLine093Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine093 GetByKey(int orderLine093ID)
        {
            return this.Query().Where(new { OrderLine093ID = orderLine093ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine093ID)
        {
            this.Delete(new OrderLine093() { OrderLine093ID = orderLine093ID });
        }
    }


    public partial class OrderLine094Repository : Repository<OrderLine094>
    {
        public OrderLine094Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine094 GetByKey(int orderLine094ID)
        {
            return this.Query().Where(new { OrderLine094ID = orderLine094ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine094ID)
        {
            this.Delete(new OrderLine094() { OrderLine094ID = orderLine094ID });
        }
    }


    public partial class OrderLine095Repository : Repository<OrderLine095>
    {
        public OrderLine095Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine095 GetByKey(int orderLine095ID)
        {
            return this.Query().Where(new { OrderLine095ID = orderLine095ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine095ID)
        {
            this.Delete(new OrderLine095() { OrderLine095ID = orderLine095ID });
        }
    }


    public partial class OrderLine096Repository : Repository<OrderLine096>
    {
        public OrderLine096Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine096 GetByKey(int orderLine096ID)
        {
            return this.Query().Where(new { OrderLine096ID = orderLine096ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine096ID)
        {
            this.Delete(new OrderLine096() { OrderLine096ID = orderLine096ID });
        }
    }


    public partial class OrderLine097Repository : Repository<OrderLine097>
    {
        public OrderLine097Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine097 GetByKey(int orderLine097ID)
        {
            return this.Query().Where(new { OrderLine097ID = orderLine097ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine097ID)
        {
            this.Delete(new OrderLine097() { OrderLine097ID = orderLine097ID });
        }
    }


    public partial class OrderLine098Repository : Repository<OrderLine098>
    {
        public OrderLine098Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine098 GetByKey(int orderLine098ID)
        {
            return this.Query().Where(new { OrderLine098ID = orderLine098ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine098ID)
        {
            this.Delete(new OrderLine098() { OrderLine098ID = orderLine098ID });
        }
    }


    public partial class OrderLine099Repository : Repository<OrderLine099>
    {
        public OrderLine099Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine099 GetByKey(int orderLine099ID)
        {
            return this.Query().Where(new { OrderLine099ID = orderLine099ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine099ID)
        {
            this.Delete(new OrderLine099() { OrderLine099ID = orderLine099ID });
        }
    }


    public partial class OrderLine100Repository : Repository<OrderLine100>
    {
        public OrderLine100Repository(InsulaDatabase database)
            : base(database)
        {
        }
        
        public OrderLine100 GetByKey(int orderLine100ID)
        {
            return this.Query().Where(new { OrderLine100ID = orderLine100ID }).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine100ID)
        {
            this.Delete(new OrderLine100() { OrderLine100ID = orderLine100ID });
        }
    }


}