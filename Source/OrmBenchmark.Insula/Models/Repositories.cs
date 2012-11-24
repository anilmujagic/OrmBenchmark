/////////////////////////////////////////////////////////////////////////////////////////////
//  This code was generated from a template. Do NOT change it, edit the template instead.  //
/////////////////////////////////////////////////////////////////////////////////////////////

using System;
using Insula.Data.Orm;

namespace OrmBenchmark.Insula
{
    public partial class CustomerRepository : Repository<Customer>
    {
        public CustomerRepository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer GetByKey(string customerID)
        {
            return this.Query().Where("[CustomerID] = @0", customerID).GetSingle();  
        }
        
        public void DeleteByKey(string customerID)
        {
            this.Delete(new Customer() { CustomerID = customerID });
        }
    }


    public partial class Customer001Repository : Repository<Customer001>
    {
        public Customer001Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer001 GetByKey(string customer001ID)
        {
            return this.Query().Where("[Customer001ID] = @0", customer001ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer001ID)
        {
            this.Delete(new Customer001() { Customer001ID = customer001ID });
        }
    }


    public partial class Customer002Repository : Repository<Customer002>
    {
        public Customer002Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer002 GetByKey(string customer002ID)
        {
            return this.Query().Where("[Customer002ID] = @0", customer002ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer002ID)
        {
            this.Delete(new Customer002() { Customer002ID = customer002ID });
        }
    }


    public partial class Customer003Repository : Repository<Customer003>
    {
        public Customer003Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer003 GetByKey(string customer003ID)
        {
            return this.Query().Where("[Customer003ID] = @0", customer003ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer003ID)
        {
            this.Delete(new Customer003() { Customer003ID = customer003ID });
        }
    }


    public partial class Customer004Repository : Repository<Customer004>
    {
        public Customer004Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer004 GetByKey(string customer004ID)
        {
            return this.Query().Where("[Customer004ID] = @0", customer004ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer004ID)
        {
            this.Delete(new Customer004() { Customer004ID = customer004ID });
        }
    }


    public partial class Customer005Repository : Repository<Customer005>
    {
        public Customer005Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer005 GetByKey(string customer005ID)
        {
            return this.Query().Where("[Customer005ID] = @0", customer005ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer005ID)
        {
            this.Delete(new Customer005() { Customer005ID = customer005ID });
        }
    }


    public partial class Customer006Repository : Repository<Customer006>
    {
        public Customer006Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer006 GetByKey(string customer006ID)
        {
            return this.Query().Where("[Customer006ID] = @0", customer006ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer006ID)
        {
            this.Delete(new Customer006() { Customer006ID = customer006ID });
        }
    }


    public partial class Customer007Repository : Repository<Customer007>
    {
        public Customer007Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer007 GetByKey(string customer007ID)
        {
            return this.Query().Where("[Customer007ID] = @0", customer007ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer007ID)
        {
            this.Delete(new Customer007() { Customer007ID = customer007ID });
        }
    }


    public partial class Customer008Repository : Repository<Customer008>
    {
        public Customer008Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer008 GetByKey(string customer008ID)
        {
            return this.Query().Where("[Customer008ID] = @0", customer008ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer008ID)
        {
            this.Delete(new Customer008() { Customer008ID = customer008ID });
        }
    }


    public partial class Customer009Repository : Repository<Customer009>
    {
        public Customer009Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer009 GetByKey(string customer009ID)
        {
            return this.Query().Where("[Customer009ID] = @0", customer009ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer009ID)
        {
            this.Delete(new Customer009() { Customer009ID = customer009ID });
        }
    }


    public partial class Customer010Repository : Repository<Customer010>
    {
        public Customer010Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer010 GetByKey(string customer010ID)
        {
            return this.Query().Where("[Customer010ID] = @0", customer010ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer010ID)
        {
            this.Delete(new Customer010() { Customer010ID = customer010ID });
        }
    }


    public partial class Customer011Repository : Repository<Customer011>
    {
        public Customer011Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer011 GetByKey(string customer011ID)
        {
            return this.Query().Where("[Customer011ID] = @0", customer011ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer011ID)
        {
            this.Delete(new Customer011() { Customer011ID = customer011ID });
        }
    }


    public partial class Customer012Repository : Repository<Customer012>
    {
        public Customer012Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer012 GetByKey(string customer012ID)
        {
            return this.Query().Where("[Customer012ID] = @0", customer012ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer012ID)
        {
            this.Delete(new Customer012() { Customer012ID = customer012ID });
        }
    }


    public partial class Customer013Repository : Repository<Customer013>
    {
        public Customer013Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer013 GetByKey(string customer013ID)
        {
            return this.Query().Where("[Customer013ID] = @0", customer013ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer013ID)
        {
            this.Delete(new Customer013() { Customer013ID = customer013ID });
        }
    }


    public partial class Customer014Repository : Repository<Customer014>
    {
        public Customer014Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer014 GetByKey(string customer014ID)
        {
            return this.Query().Where("[Customer014ID] = @0", customer014ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer014ID)
        {
            this.Delete(new Customer014() { Customer014ID = customer014ID });
        }
    }


    public partial class Customer015Repository : Repository<Customer015>
    {
        public Customer015Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer015 GetByKey(string customer015ID)
        {
            return this.Query().Where("[Customer015ID] = @0", customer015ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer015ID)
        {
            this.Delete(new Customer015() { Customer015ID = customer015ID });
        }
    }


    public partial class Customer016Repository : Repository<Customer016>
    {
        public Customer016Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer016 GetByKey(string customer016ID)
        {
            return this.Query().Where("[Customer016ID] = @0", customer016ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer016ID)
        {
            this.Delete(new Customer016() { Customer016ID = customer016ID });
        }
    }


    public partial class Customer017Repository : Repository<Customer017>
    {
        public Customer017Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer017 GetByKey(string customer017ID)
        {
            return this.Query().Where("[Customer017ID] = @0", customer017ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer017ID)
        {
            this.Delete(new Customer017() { Customer017ID = customer017ID });
        }
    }


    public partial class Customer018Repository : Repository<Customer018>
    {
        public Customer018Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer018 GetByKey(string customer018ID)
        {
            return this.Query().Where("[Customer018ID] = @0", customer018ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer018ID)
        {
            this.Delete(new Customer018() { Customer018ID = customer018ID });
        }
    }


    public partial class Customer019Repository : Repository<Customer019>
    {
        public Customer019Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer019 GetByKey(string customer019ID)
        {
            return this.Query().Where("[Customer019ID] = @0", customer019ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer019ID)
        {
            this.Delete(new Customer019() { Customer019ID = customer019ID });
        }
    }


    public partial class Customer020Repository : Repository<Customer020>
    {
        public Customer020Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer020 GetByKey(string customer020ID)
        {
            return this.Query().Where("[Customer020ID] = @0", customer020ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer020ID)
        {
            this.Delete(new Customer020() { Customer020ID = customer020ID });
        }
    }


    public partial class Customer021Repository : Repository<Customer021>
    {
        public Customer021Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer021 GetByKey(string customer021ID)
        {
            return this.Query().Where("[Customer021ID] = @0", customer021ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer021ID)
        {
            this.Delete(new Customer021() { Customer021ID = customer021ID });
        }
    }


    public partial class Customer022Repository : Repository<Customer022>
    {
        public Customer022Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer022 GetByKey(string customer022ID)
        {
            return this.Query().Where("[Customer022ID] = @0", customer022ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer022ID)
        {
            this.Delete(new Customer022() { Customer022ID = customer022ID });
        }
    }


    public partial class Customer023Repository : Repository<Customer023>
    {
        public Customer023Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer023 GetByKey(string customer023ID)
        {
            return this.Query().Where("[Customer023ID] = @0", customer023ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer023ID)
        {
            this.Delete(new Customer023() { Customer023ID = customer023ID });
        }
    }


    public partial class Customer024Repository : Repository<Customer024>
    {
        public Customer024Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer024 GetByKey(string customer024ID)
        {
            return this.Query().Where("[Customer024ID] = @0", customer024ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer024ID)
        {
            this.Delete(new Customer024() { Customer024ID = customer024ID });
        }
    }


    public partial class Customer025Repository : Repository<Customer025>
    {
        public Customer025Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer025 GetByKey(string customer025ID)
        {
            return this.Query().Where("[Customer025ID] = @0", customer025ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer025ID)
        {
            this.Delete(new Customer025() { Customer025ID = customer025ID });
        }
    }


    public partial class Customer026Repository : Repository<Customer026>
    {
        public Customer026Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer026 GetByKey(string customer026ID)
        {
            return this.Query().Where("[Customer026ID] = @0", customer026ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer026ID)
        {
            this.Delete(new Customer026() { Customer026ID = customer026ID });
        }
    }


    public partial class Customer027Repository : Repository<Customer027>
    {
        public Customer027Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer027 GetByKey(string customer027ID)
        {
            return this.Query().Where("[Customer027ID] = @0", customer027ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer027ID)
        {
            this.Delete(new Customer027() { Customer027ID = customer027ID });
        }
    }


    public partial class Customer028Repository : Repository<Customer028>
    {
        public Customer028Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer028 GetByKey(string customer028ID)
        {
            return this.Query().Where("[Customer028ID] = @0", customer028ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer028ID)
        {
            this.Delete(new Customer028() { Customer028ID = customer028ID });
        }
    }


    public partial class Customer029Repository : Repository<Customer029>
    {
        public Customer029Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer029 GetByKey(string customer029ID)
        {
            return this.Query().Where("[Customer029ID] = @0", customer029ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer029ID)
        {
            this.Delete(new Customer029() { Customer029ID = customer029ID });
        }
    }


    public partial class Customer030Repository : Repository<Customer030>
    {
        public Customer030Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer030 GetByKey(string customer030ID)
        {
            return this.Query().Where("[Customer030ID] = @0", customer030ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer030ID)
        {
            this.Delete(new Customer030() { Customer030ID = customer030ID });
        }
    }


    public partial class Customer031Repository : Repository<Customer031>
    {
        public Customer031Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer031 GetByKey(string customer031ID)
        {
            return this.Query().Where("[Customer031ID] = @0", customer031ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer031ID)
        {
            this.Delete(new Customer031() { Customer031ID = customer031ID });
        }
    }


    public partial class Customer032Repository : Repository<Customer032>
    {
        public Customer032Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer032 GetByKey(string customer032ID)
        {
            return this.Query().Where("[Customer032ID] = @0", customer032ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer032ID)
        {
            this.Delete(new Customer032() { Customer032ID = customer032ID });
        }
    }


    public partial class Customer033Repository : Repository<Customer033>
    {
        public Customer033Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer033 GetByKey(string customer033ID)
        {
            return this.Query().Where("[Customer033ID] = @0", customer033ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer033ID)
        {
            this.Delete(new Customer033() { Customer033ID = customer033ID });
        }
    }


    public partial class Customer034Repository : Repository<Customer034>
    {
        public Customer034Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer034 GetByKey(string customer034ID)
        {
            return this.Query().Where("[Customer034ID] = @0", customer034ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer034ID)
        {
            this.Delete(new Customer034() { Customer034ID = customer034ID });
        }
    }


    public partial class Customer035Repository : Repository<Customer035>
    {
        public Customer035Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer035 GetByKey(string customer035ID)
        {
            return this.Query().Where("[Customer035ID] = @0", customer035ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer035ID)
        {
            this.Delete(new Customer035() { Customer035ID = customer035ID });
        }
    }


    public partial class Customer036Repository : Repository<Customer036>
    {
        public Customer036Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer036 GetByKey(string customer036ID)
        {
            return this.Query().Where("[Customer036ID] = @0", customer036ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer036ID)
        {
            this.Delete(new Customer036() { Customer036ID = customer036ID });
        }
    }


    public partial class Customer037Repository : Repository<Customer037>
    {
        public Customer037Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer037 GetByKey(string customer037ID)
        {
            return this.Query().Where("[Customer037ID] = @0", customer037ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer037ID)
        {
            this.Delete(new Customer037() { Customer037ID = customer037ID });
        }
    }


    public partial class Customer038Repository : Repository<Customer038>
    {
        public Customer038Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer038 GetByKey(string customer038ID)
        {
            return this.Query().Where("[Customer038ID] = @0", customer038ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer038ID)
        {
            this.Delete(new Customer038() { Customer038ID = customer038ID });
        }
    }


    public partial class Customer039Repository : Repository<Customer039>
    {
        public Customer039Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer039 GetByKey(string customer039ID)
        {
            return this.Query().Where("[Customer039ID] = @0", customer039ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer039ID)
        {
            this.Delete(new Customer039() { Customer039ID = customer039ID });
        }
    }


    public partial class Customer040Repository : Repository<Customer040>
    {
        public Customer040Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer040 GetByKey(string customer040ID)
        {
            return this.Query().Where("[Customer040ID] = @0", customer040ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer040ID)
        {
            this.Delete(new Customer040() { Customer040ID = customer040ID });
        }
    }


    public partial class Customer041Repository : Repository<Customer041>
    {
        public Customer041Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer041 GetByKey(string customer041ID)
        {
            return this.Query().Where("[Customer041ID] = @0", customer041ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer041ID)
        {
            this.Delete(new Customer041() { Customer041ID = customer041ID });
        }
    }


    public partial class Customer042Repository : Repository<Customer042>
    {
        public Customer042Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer042 GetByKey(string customer042ID)
        {
            return this.Query().Where("[Customer042ID] = @0", customer042ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer042ID)
        {
            this.Delete(new Customer042() { Customer042ID = customer042ID });
        }
    }


    public partial class Customer043Repository : Repository<Customer043>
    {
        public Customer043Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer043 GetByKey(string customer043ID)
        {
            return this.Query().Where("[Customer043ID] = @0", customer043ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer043ID)
        {
            this.Delete(new Customer043() { Customer043ID = customer043ID });
        }
    }


    public partial class Customer044Repository : Repository<Customer044>
    {
        public Customer044Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer044 GetByKey(string customer044ID)
        {
            return this.Query().Where("[Customer044ID] = @0", customer044ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer044ID)
        {
            this.Delete(new Customer044() { Customer044ID = customer044ID });
        }
    }


    public partial class Customer045Repository : Repository<Customer045>
    {
        public Customer045Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer045 GetByKey(string customer045ID)
        {
            return this.Query().Where("[Customer045ID] = @0", customer045ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer045ID)
        {
            this.Delete(new Customer045() { Customer045ID = customer045ID });
        }
    }


    public partial class Customer046Repository : Repository<Customer046>
    {
        public Customer046Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer046 GetByKey(string customer046ID)
        {
            return this.Query().Where("[Customer046ID] = @0", customer046ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer046ID)
        {
            this.Delete(new Customer046() { Customer046ID = customer046ID });
        }
    }


    public partial class Customer047Repository : Repository<Customer047>
    {
        public Customer047Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer047 GetByKey(string customer047ID)
        {
            return this.Query().Where("[Customer047ID] = @0", customer047ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer047ID)
        {
            this.Delete(new Customer047() { Customer047ID = customer047ID });
        }
    }


    public partial class Customer048Repository : Repository<Customer048>
    {
        public Customer048Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer048 GetByKey(string customer048ID)
        {
            return this.Query().Where("[Customer048ID] = @0", customer048ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer048ID)
        {
            this.Delete(new Customer048() { Customer048ID = customer048ID });
        }
    }


    public partial class Customer049Repository : Repository<Customer049>
    {
        public Customer049Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer049 GetByKey(string customer049ID)
        {
            return this.Query().Where("[Customer049ID] = @0", customer049ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer049ID)
        {
            this.Delete(new Customer049() { Customer049ID = customer049ID });
        }
    }


    public partial class Customer050Repository : Repository<Customer050>
    {
        public Customer050Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer050 GetByKey(string customer050ID)
        {
            return this.Query().Where("[Customer050ID] = @0", customer050ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer050ID)
        {
            this.Delete(new Customer050() { Customer050ID = customer050ID });
        }
    }


    public partial class Customer051Repository : Repository<Customer051>
    {
        public Customer051Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer051 GetByKey(string customer051ID)
        {
            return this.Query().Where("[Customer051ID] = @0", customer051ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer051ID)
        {
            this.Delete(new Customer051() { Customer051ID = customer051ID });
        }
    }


    public partial class Customer052Repository : Repository<Customer052>
    {
        public Customer052Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer052 GetByKey(string customer052ID)
        {
            return this.Query().Where("[Customer052ID] = @0", customer052ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer052ID)
        {
            this.Delete(new Customer052() { Customer052ID = customer052ID });
        }
    }


    public partial class Customer053Repository : Repository<Customer053>
    {
        public Customer053Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer053 GetByKey(string customer053ID)
        {
            return this.Query().Where("[Customer053ID] = @0", customer053ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer053ID)
        {
            this.Delete(new Customer053() { Customer053ID = customer053ID });
        }
    }


    public partial class Customer054Repository : Repository<Customer054>
    {
        public Customer054Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer054 GetByKey(string customer054ID)
        {
            return this.Query().Where("[Customer054ID] = @0", customer054ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer054ID)
        {
            this.Delete(new Customer054() { Customer054ID = customer054ID });
        }
    }


    public partial class Customer055Repository : Repository<Customer055>
    {
        public Customer055Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer055 GetByKey(string customer055ID)
        {
            return this.Query().Where("[Customer055ID] = @0", customer055ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer055ID)
        {
            this.Delete(new Customer055() { Customer055ID = customer055ID });
        }
    }


    public partial class Customer056Repository : Repository<Customer056>
    {
        public Customer056Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer056 GetByKey(string customer056ID)
        {
            return this.Query().Where("[Customer056ID] = @0", customer056ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer056ID)
        {
            this.Delete(new Customer056() { Customer056ID = customer056ID });
        }
    }


    public partial class Customer057Repository : Repository<Customer057>
    {
        public Customer057Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer057 GetByKey(string customer057ID)
        {
            return this.Query().Where("[Customer057ID] = @0", customer057ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer057ID)
        {
            this.Delete(new Customer057() { Customer057ID = customer057ID });
        }
    }


    public partial class Customer058Repository : Repository<Customer058>
    {
        public Customer058Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer058 GetByKey(string customer058ID)
        {
            return this.Query().Where("[Customer058ID] = @0", customer058ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer058ID)
        {
            this.Delete(new Customer058() { Customer058ID = customer058ID });
        }
    }


    public partial class Customer059Repository : Repository<Customer059>
    {
        public Customer059Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer059 GetByKey(string customer059ID)
        {
            return this.Query().Where("[Customer059ID] = @0", customer059ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer059ID)
        {
            this.Delete(new Customer059() { Customer059ID = customer059ID });
        }
    }


    public partial class Customer060Repository : Repository<Customer060>
    {
        public Customer060Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer060 GetByKey(string customer060ID)
        {
            return this.Query().Where("[Customer060ID] = @0", customer060ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer060ID)
        {
            this.Delete(new Customer060() { Customer060ID = customer060ID });
        }
    }


    public partial class Customer061Repository : Repository<Customer061>
    {
        public Customer061Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer061 GetByKey(string customer061ID)
        {
            return this.Query().Where("[Customer061ID] = @0", customer061ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer061ID)
        {
            this.Delete(new Customer061() { Customer061ID = customer061ID });
        }
    }


    public partial class Customer062Repository : Repository<Customer062>
    {
        public Customer062Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer062 GetByKey(string customer062ID)
        {
            return this.Query().Where("[Customer062ID] = @0", customer062ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer062ID)
        {
            this.Delete(new Customer062() { Customer062ID = customer062ID });
        }
    }


    public partial class Customer063Repository : Repository<Customer063>
    {
        public Customer063Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer063 GetByKey(string customer063ID)
        {
            return this.Query().Where("[Customer063ID] = @0", customer063ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer063ID)
        {
            this.Delete(new Customer063() { Customer063ID = customer063ID });
        }
    }


    public partial class Customer064Repository : Repository<Customer064>
    {
        public Customer064Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer064 GetByKey(string customer064ID)
        {
            return this.Query().Where("[Customer064ID] = @0", customer064ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer064ID)
        {
            this.Delete(new Customer064() { Customer064ID = customer064ID });
        }
    }


    public partial class Customer065Repository : Repository<Customer065>
    {
        public Customer065Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer065 GetByKey(string customer065ID)
        {
            return this.Query().Where("[Customer065ID] = @0", customer065ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer065ID)
        {
            this.Delete(new Customer065() { Customer065ID = customer065ID });
        }
    }


    public partial class Customer066Repository : Repository<Customer066>
    {
        public Customer066Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer066 GetByKey(string customer066ID)
        {
            return this.Query().Where("[Customer066ID] = @0", customer066ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer066ID)
        {
            this.Delete(new Customer066() { Customer066ID = customer066ID });
        }
    }


    public partial class Customer067Repository : Repository<Customer067>
    {
        public Customer067Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer067 GetByKey(string customer067ID)
        {
            return this.Query().Where("[Customer067ID] = @0", customer067ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer067ID)
        {
            this.Delete(new Customer067() { Customer067ID = customer067ID });
        }
    }


    public partial class Customer068Repository : Repository<Customer068>
    {
        public Customer068Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer068 GetByKey(string customer068ID)
        {
            return this.Query().Where("[Customer068ID] = @0", customer068ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer068ID)
        {
            this.Delete(new Customer068() { Customer068ID = customer068ID });
        }
    }


    public partial class Customer069Repository : Repository<Customer069>
    {
        public Customer069Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer069 GetByKey(string customer069ID)
        {
            return this.Query().Where("[Customer069ID] = @0", customer069ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer069ID)
        {
            this.Delete(new Customer069() { Customer069ID = customer069ID });
        }
    }


    public partial class Customer070Repository : Repository<Customer070>
    {
        public Customer070Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer070 GetByKey(string customer070ID)
        {
            return this.Query().Where("[Customer070ID] = @0", customer070ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer070ID)
        {
            this.Delete(new Customer070() { Customer070ID = customer070ID });
        }
    }


    public partial class Customer071Repository : Repository<Customer071>
    {
        public Customer071Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer071 GetByKey(string customer071ID)
        {
            return this.Query().Where("[Customer071ID] = @0", customer071ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer071ID)
        {
            this.Delete(new Customer071() { Customer071ID = customer071ID });
        }
    }


    public partial class Customer072Repository : Repository<Customer072>
    {
        public Customer072Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer072 GetByKey(string customer072ID)
        {
            return this.Query().Where("[Customer072ID] = @0", customer072ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer072ID)
        {
            this.Delete(new Customer072() { Customer072ID = customer072ID });
        }
    }


    public partial class Customer073Repository : Repository<Customer073>
    {
        public Customer073Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer073 GetByKey(string customer073ID)
        {
            return this.Query().Where("[Customer073ID] = @0", customer073ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer073ID)
        {
            this.Delete(new Customer073() { Customer073ID = customer073ID });
        }
    }


    public partial class Customer074Repository : Repository<Customer074>
    {
        public Customer074Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer074 GetByKey(string customer074ID)
        {
            return this.Query().Where("[Customer074ID] = @0", customer074ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer074ID)
        {
            this.Delete(new Customer074() { Customer074ID = customer074ID });
        }
    }


    public partial class Customer075Repository : Repository<Customer075>
    {
        public Customer075Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer075 GetByKey(string customer075ID)
        {
            return this.Query().Where("[Customer075ID] = @0", customer075ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer075ID)
        {
            this.Delete(new Customer075() { Customer075ID = customer075ID });
        }
    }


    public partial class Customer076Repository : Repository<Customer076>
    {
        public Customer076Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer076 GetByKey(string customer076ID)
        {
            return this.Query().Where("[Customer076ID] = @0", customer076ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer076ID)
        {
            this.Delete(new Customer076() { Customer076ID = customer076ID });
        }
    }


    public partial class Customer077Repository : Repository<Customer077>
    {
        public Customer077Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer077 GetByKey(string customer077ID)
        {
            return this.Query().Where("[Customer077ID] = @0", customer077ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer077ID)
        {
            this.Delete(new Customer077() { Customer077ID = customer077ID });
        }
    }


    public partial class Customer078Repository : Repository<Customer078>
    {
        public Customer078Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer078 GetByKey(string customer078ID)
        {
            return this.Query().Where("[Customer078ID] = @0", customer078ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer078ID)
        {
            this.Delete(new Customer078() { Customer078ID = customer078ID });
        }
    }


    public partial class Customer079Repository : Repository<Customer079>
    {
        public Customer079Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer079 GetByKey(string customer079ID)
        {
            return this.Query().Where("[Customer079ID] = @0", customer079ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer079ID)
        {
            this.Delete(new Customer079() { Customer079ID = customer079ID });
        }
    }


    public partial class Customer080Repository : Repository<Customer080>
    {
        public Customer080Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer080 GetByKey(string customer080ID)
        {
            return this.Query().Where("[Customer080ID] = @0", customer080ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer080ID)
        {
            this.Delete(new Customer080() { Customer080ID = customer080ID });
        }
    }


    public partial class Customer081Repository : Repository<Customer081>
    {
        public Customer081Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer081 GetByKey(string customer081ID)
        {
            return this.Query().Where("[Customer081ID] = @0", customer081ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer081ID)
        {
            this.Delete(new Customer081() { Customer081ID = customer081ID });
        }
    }


    public partial class Customer082Repository : Repository<Customer082>
    {
        public Customer082Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer082 GetByKey(string customer082ID)
        {
            return this.Query().Where("[Customer082ID] = @0", customer082ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer082ID)
        {
            this.Delete(new Customer082() { Customer082ID = customer082ID });
        }
    }


    public partial class Customer083Repository : Repository<Customer083>
    {
        public Customer083Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer083 GetByKey(string customer083ID)
        {
            return this.Query().Where("[Customer083ID] = @0", customer083ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer083ID)
        {
            this.Delete(new Customer083() { Customer083ID = customer083ID });
        }
    }


    public partial class Customer084Repository : Repository<Customer084>
    {
        public Customer084Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer084 GetByKey(string customer084ID)
        {
            return this.Query().Where("[Customer084ID] = @0", customer084ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer084ID)
        {
            this.Delete(new Customer084() { Customer084ID = customer084ID });
        }
    }


    public partial class Customer085Repository : Repository<Customer085>
    {
        public Customer085Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer085 GetByKey(string customer085ID)
        {
            return this.Query().Where("[Customer085ID] = @0", customer085ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer085ID)
        {
            this.Delete(new Customer085() { Customer085ID = customer085ID });
        }
    }


    public partial class Customer086Repository : Repository<Customer086>
    {
        public Customer086Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer086 GetByKey(string customer086ID)
        {
            return this.Query().Where("[Customer086ID] = @0", customer086ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer086ID)
        {
            this.Delete(new Customer086() { Customer086ID = customer086ID });
        }
    }


    public partial class Customer087Repository : Repository<Customer087>
    {
        public Customer087Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer087 GetByKey(string customer087ID)
        {
            return this.Query().Where("[Customer087ID] = @0", customer087ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer087ID)
        {
            this.Delete(new Customer087() { Customer087ID = customer087ID });
        }
    }


    public partial class Customer088Repository : Repository<Customer088>
    {
        public Customer088Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer088 GetByKey(string customer088ID)
        {
            return this.Query().Where("[Customer088ID] = @0", customer088ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer088ID)
        {
            this.Delete(new Customer088() { Customer088ID = customer088ID });
        }
    }


    public partial class Customer089Repository : Repository<Customer089>
    {
        public Customer089Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer089 GetByKey(string customer089ID)
        {
            return this.Query().Where("[Customer089ID] = @0", customer089ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer089ID)
        {
            this.Delete(new Customer089() { Customer089ID = customer089ID });
        }
    }


    public partial class Customer090Repository : Repository<Customer090>
    {
        public Customer090Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer090 GetByKey(string customer090ID)
        {
            return this.Query().Where("[Customer090ID] = @0", customer090ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer090ID)
        {
            this.Delete(new Customer090() { Customer090ID = customer090ID });
        }
    }


    public partial class Customer091Repository : Repository<Customer091>
    {
        public Customer091Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer091 GetByKey(string customer091ID)
        {
            return this.Query().Where("[Customer091ID] = @0", customer091ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer091ID)
        {
            this.Delete(new Customer091() { Customer091ID = customer091ID });
        }
    }


    public partial class Customer092Repository : Repository<Customer092>
    {
        public Customer092Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer092 GetByKey(string customer092ID)
        {
            return this.Query().Where("[Customer092ID] = @0", customer092ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer092ID)
        {
            this.Delete(new Customer092() { Customer092ID = customer092ID });
        }
    }


    public partial class Customer093Repository : Repository<Customer093>
    {
        public Customer093Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer093 GetByKey(string customer093ID)
        {
            return this.Query().Where("[Customer093ID] = @0", customer093ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer093ID)
        {
            this.Delete(new Customer093() { Customer093ID = customer093ID });
        }
    }


    public partial class Customer094Repository : Repository<Customer094>
    {
        public Customer094Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer094 GetByKey(string customer094ID)
        {
            return this.Query().Where("[Customer094ID] = @0", customer094ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer094ID)
        {
            this.Delete(new Customer094() { Customer094ID = customer094ID });
        }
    }


    public partial class Customer095Repository : Repository<Customer095>
    {
        public Customer095Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer095 GetByKey(string customer095ID)
        {
            return this.Query().Where("[Customer095ID] = @0", customer095ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer095ID)
        {
            this.Delete(new Customer095() { Customer095ID = customer095ID });
        }
    }


    public partial class Customer096Repository : Repository<Customer096>
    {
        public Customer096Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer096 GetByKey(string customer096ID)
        {
            return this.Query().Where("[Customer096ID] = @0", customer096ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer096ID)
        {
            this.Delete(new Customer096() { Customer096ID = customer096ID });
        }
    }


    public partial class Customer097Repository : Repository<Customer097>
    {
        public Customer097Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer097 GetByKey(string customer097ID)
        {
            return this.Query().Where("[Customer097ID] = @0", customer097ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer097ID)
        {
            this.Delete(new Customer097() { Customer097ID = customer097ID });
        }
    }


    public partial class Customer098Repository : Repository<Customer098>
    {
        public Customer098Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer098 GetByKey(string customer098ID)
        {
            return this.Query().Where("[Customer098ID] = @0", customer098ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer098ID)
        {
            this.Delete(new Customer098() { Customer098ID = customer098ID });
        }
    }


    public partial class Customer099Repository : Repository<Customer099>
    {
        public Customer099Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer099 GetByKey(string customer099ID)
        {
            return this.Query().Where("[Customer099ID] = @0", customer099ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer099ID)
        {
            this.Delete(new Customer099() { Customer099ID = customer099ID });
        }
    }


    public partial class Customer100Repository : Repository<Customer100>
    {
        public Customer100Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Customer100 GetByKey(string customer100ID)
        {
            return this.Query().Where("[Customer100ID] = @0", customer100ID).GetSingle();  
        }
        
        public void DeleteByKey(string customer100ID)
        {
            this.Delete(new Customer100() { Customer100ID = customer100ID });
        }
    }


    public partial class ItemRepository : Repository<Item>
    {
        public ItemRepository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item GetByKey(string itemID)
        {
            return this.Query().Where("[ItemID] = @0", itemID).GetSingle();  
        }
        
        public void DeleteByKey(string itemID)
        {
            this.Delete(new Item() { ItemID = itemID });
        }
    }


    public partial class Item001Repository : Repository<Item001>
    {
        public Item001Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item001 GetByKey(string item001ID)
        {
            return this.Query().Where("[Item001ID] = @0", item001ID).GetSingle();  
        }
        
        public void DeleteByKey(string item001ID)
        {
            this.Delete(new Item001() { Item001ID = item001ID });
        }
    }


    public partial class Item002Repository : Repository<Item002>
    {
        public Item002Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item002 GetByKey(string item002ID)
        {
            return this.Query().Where("[Item002ID] = @0", item002ID).GetSingle();  
        }
        
        public void DeleteByKey(string item002ID)
        {
            this.Delete(new Item002() { Item002ID = item002ID });
        }
    }


    public partial class Item003Repository : Repository<Item003>
    {
        public Item003Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item003 GetByKey(string item003ID)
        {
            return this.Query().Where("[Item003ID] = @0", item003ID).GetSingle();  
        }
        
        public void DeleteByKey(string item003ID)
        {
            this.Delete(new Item003() { Item003ID = item003ID });
        }
    }


    public partial class Item004Repository : Repository<Item004>
    {
        public Item004Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item004 GetByKey(string item004ID)
        {
            return this.Query().Where("[Item004ID] = @0", item004ID).GetSingle();  
        }
        
        public void DeleteByKey(string item004ID)
        {
            this.Delete(new Item004() { Item004ID = item004ID });
        }
    }


    public partial class Item005Repository : Repository<Item005>
    {
        public Item005Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item005 GetByKey(string item005ID)
        {
            return this.Query().Where("[Item005ID] = @0", item005ID).GetSingle();  
        }
        
        public void DeleteByKey(string item005ID)
        {
            this.Delete(new Item005() { Item005ID = item005ID });
        }
    }


    public partial class Item006Repository : Repository<Item006>
    {
        public Item006Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item006 GetByKey(string item006ID)
        {
            return this.Query().Where("[Item006ID] = @0", item006ID).GetSingle();  
        }
        
        public void DeleteByKey(string item006ID)
        {
            this.Delete(new Item006() { Item006ID = item006ID });
        }
    }


    public partial class Item007Repository : Repository<Item007>
    {
        public Item007Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item007 GetByKey(string item007ID)
        {
            return this.Query().Where("[Item007ID] = @0", item007ID).GetSingle();  
        }
        
        public void DeleteByKey(string item007ID)
        {
            this.Delete(new Item007() { Item007ID = item007ID });
        }
    }


    public partial class Item008Repository : Repository<Item008>
    {
        public Item008Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item008 GetByKey(string item008ID)
        {
            return this.Query().Where("[Item008ID] = @0", item008ID).GetSingle();  
        }
        
        public void DeleteByKey(string item008ID)
        {
            this.Delete(new Item008() { Item008ID = item008ID });
        }
    }


    public partial class Item009Repository : Repository<Item009>
    {
        public Item009Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item009 GetByKey(string item009ID)
        {
            return this.Query().Where("[Item009ID] = @0", item009ID).GetSingle();  
        }
        
        public void DeleteByKey(string item009ID)
        {
            this.Delete(new Item009() { Item009ID = item009ID });
        }
    }


    public partial class Item010Repository : Repository<Item010>
    {
        public Item010Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item010 GetByKey(string item010ID)
        {
            return this.Query().Where("[Item010ID] = @0", item010ID).GetSingle();  
        }
        
        public void DeleteByKey(string item010ID)
        {
            this.Delete(new Item010() { Item010ID = item010ID });
        }
    }


    public partial class Item011Repository : Repository<Item011>
    {
        public Item011Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item011 GetByKey(string item011ID)
        {
            return this.Query().Where("[Item011ID] = @0", item011ID).GetSingle();  
        }
        
        public void DeleteByKey(string item011ID)
        {
            this.Delete(new Item011() { Item011ID = item011ID });
        }
    }


    public partial class Item012Repository : Repository<Item012>
    {
        public Item012Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item012 GetByKey(string item012ID)
        {
            return this.Query().Where("[Item012ID] = @0", item012ID).GetSingle();  
        }
        
        public void DeleteByKey(string item012ID)
        {
            this.Delete(new Item012() { Item012ID = item012ID });
        }
    }


    public partial class Item013Repository : Repository<Item013>
    {
        public Item013Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item013 GetByKey(string item013ID)
        {
            return this.Query().Where("[Item013ID] = @0", item013ID).GetSingle();  
        }
        
        public void DeleteByKey(string item013ID)
        {
            this.Delete(new Item013() { Item013ID = item013ID });
        }
    }


    public partial class Item014Repository : Repository<Item014>
    {
        public Item014Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item014 GetByKey(string item014ID)
        {
            return this.Query().Where("[Item014ID] = @0", item014ID).GetSingle();  
        }
        
        public void DeleteByKey(string item014ID)
        {
            this.Delete(new Item014() { Item014ID = item014ID });
        }
    }


    public partial class Item015Repository : Repository<Item015>
    {
        public Item015Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item015 GetByKey(string item015ID)
        {
            return this.Query().Where("[Item015ID] = @0", item015ID).GetSingle();  
        }
        
        public void DeleteByKey(string item015ID)
        {
            this.Delete(new Item015() { Item015ID = item015ID });
        }
    }


    public partial class Item016Repository : Repository<Item016>
    {
        public Item016Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item016 GetByKey(string item016ID)
        {
            return this.Query().Where("[Item016ID] = @0", item016ID).GetSingle();  
        }
        
        public void DeleteByKey(string item016ID)
        {
            this.Delete(new Item016() { Item016ID = item016ID });
        }
    }


    public partial class Item017Repository : Repository<Item017>
    {
        public Item017Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item017 GetByKey(string item017ID)
        {
            return this.Query().Where("[Item017ID] = @0", item017ID).GetSingle();  
        }
        
        public void DeleteByKey(string item017ID)
        {
            this.Delete(new Item017() { Item017ID = item017ID });
        }
    }


    public partial class Item018Repository : Repository<Item018>
    {
        public Item018Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item018 GetByKey(string item018ID)
        {
            return this.Query().Where("[Item018ID] = @0", item018ID).GetSingle();  
        }
        
        public void DeleteByKey(string item018ID)
        {
            this.Delete(new Item018() { Item018ID = item018ID });
        }
    }


    public partial class Item019Repository : Repository<Item019>
    {
        public Item019Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item019 GetByKey(string item019ID)
        {
            return this.Query().Where("[Item019ID] = @0", item019ID).GetSingle();  
        }
        
        public void DeleteByKey(string item019ID)
        {
            this.Delete(new Item019() { Item019ID = item019ID });
        }
    }


    public partial class Item020Repository : Repository<Item020>
    {
        public Item020Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item020 GetByKey(string item020ID)
        {
            return this.Query().Where("[Item020ID] = @0", item020ID).GetSingle();  
        }
        
        public void DeleteByKey(string item020ID)
        {
            this.Delete(new Item020() { Item020ID = item020ID });
        }
    }


    public partial class Item021Repository : Repository<Item021>
    {
        public Item021Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item021 GetByKey(string item021ID)
        {
            return this.Query().Where("[Item021ID] = @0", item021ID).GetSingle();  
        }
        
        public void DeleteByKey(string item021ID)
        {
            this.Delete(new Item021() { Item021ID = item021ID });
        }
    }


    public partial class Item022Repository : Repository<Item022>
    {
        public Item022Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item022 GetByKey(string item022ID)
        {
            return this.Query().Where("[Item022ID] = @0", item022ID).GetSingle();  
        }
        
        public void DeleteByKey(string item022ID)
        {
            this.Delete(new Item022() { Item022ID = item022ID });
        }
    }


    public partial class Item023Repository : Repository<Item023>
    {
        public Item023Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item023 GetByKey(string item023ID)
        {
            return this.Query().Where("[Item023ID] = @0", item023ID).GetSingle();  
        }
        
        public void DeleteByKey(string item023ID)
        {
            this.Delete(new Item023() { Item023ID = item023ID });
        }
    }


    public partial class Item024Repository : Repository<Item024>
    {
        public Item024Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item024 GetByKey(string item024ID)
        {
            return this.Query().Where("[Item024ID] = @0", item024ID).GetSingle();  
        }
        
        public void DeleteByKey(string item024ID)
        {
            this.Delete(new Item024() { Item024ID = item024ID });
        }
    }


    public partial class Item025Repository : Repository<Item025>
    {
        public Item025Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item025 GetByKey(string item025ID)
        {
            return this.Query().Where("[Item025ID] = @0", item025ID).GetSingle();  
        }
        
        public void DeleteByKey(string item025ID)
        {
            this.Delete(new Item025() { Item025ID = item025ID });
        }
    }


    public partial class Item026Repository : Repository<Item026>
    {
        public Item026Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item026 GetByKey(string item026ID)
        {
            return this.Query().Where("[Item026ID] = @0", item026ID).GetSingle();  
        }
        
        public void DeleteByKey(string item026ID)
        {
            this.Delete(new Item026() { Item026ID = item026ID });
        }
    }


    public partial class Item027Repository : Repository<Item027>
    {
        public Item027Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item027 GetByKey(string item027ID)
        {
            return this.Query().Where("[Item027ID] = @0", item027ID).GetSingle();  
        }
        
        public void DeleteByKey(string item027ID)
        {
            this.Delete(new Item027() { Item027ID = item027ID });
        }
    }


    public partial class Item028Repository : Repository<Item028>
    {
        public Item028Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item028 GetByKey(string item028ID)
        {
            return this.Query().Where("[Item028ID] = @0", item028ID).GetSingle();  
        }
        
        public void DeleteByKey(string item028ID)
        {
            this.Delete(new Item028() { Item028ID = item028ID });
        }
    }


    public partial class Item029Repository : Repository<Item029>
    {
        public Item029Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item029 GetByKey(string item029ID)
        {
            return this.Query().Where("[Item029ID] = @0", item029ID).GetSingle();  
        }
        
        public void DeleteByKey(string item029ID)
        {
            this.Delete(new Item029() { Item029ID = item029ID });
        }
    }


    public partial class Item030Repository : Repository<Item030>
    {
        public Item030Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item030 GetByKey(string item030ID)
        {
            return this.Query().Where("[Item030ID] = @0", item030ID).GetSingle();  
        }
        
        public void DeleteByKey(string item030ID)
        {
            this.Delete(new Item030() { Item030ID = item030ID });
        }
    }


    public partial class Item031Repository : Repository<Item031>
    {
        public Item031Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item031 GetByKey(string item031ID)
        {
            return this.Query().Where("[Item031ID] = @0", item031ID).GetSingle();  
        }
        
        public void DeleteByKey(string item031ID)
        {
            this.Delete(new Item031() { Item031ID = item031ID });
        }
    }


    public partial class Item032Repository : Repository<Item032>
    {
        public Item032Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item032 GetByKey(string item032ID)
        {
            return this.Query().Where("[Item032ID] = @0", item032ID).GetSingle();  
        }
        
        public void DeleteByKey(string item032ID)
        {
            this.Delete(new Item032() { Item032ID = item032ID });
        }
    }


    public partial class Item033Repository : Repository<Item033>
    {
        public Item033Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item033 GetByKey(string item033ID)
        {
            return this.Query().Where("[Item033ID] = @0", item033ID).GetSingle();  
        }
        
        public void DeleteByKey(string item033ID)
        {
            this.Delete(new Item033() { Item033ID = item033ID });
        }
    }


    public partial class Item034Repository : Repository<Item034>
    {
        public Item034Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item034 GetByKey(string item034ID)
        {
            return this.Query().Where("[Item034ID] = @0", item034ID).GetSingle();  
        }
        
        public void DeleteByKey(string item034ID)
        {
            this.Delete(new Item034() { Item034ID = item034ID });
        }
    }


    public partial class Item035Repository : Repository<Item035>
    {
        public Item035Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item035 GetByKey(string item035ID)
        {
            return this.Query().Where("[Item035ID] = @0", item035ID).GetSingle();  
        }
        
        public void DeleteByKey(string item035ID)
        {
            this.Delete(new Item035() { Item035ID = item035ID });
        }
    }


    public partial class Item036Repository : Repository<Item036>
    {
        public Item036Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item036 GetByKey(string item036ID)
        {
            return this.Query().Where("[Item036ID] = @0", item036ID).GetSingle();  
        }
        
        public void DeleteByKey(string item036ID)
        {
            this.Delete(new Item036() { Item036ID = item036ID });
        }
    }


    public partial class Item037Repository : Repository<Item037>
    {
        public Item037Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item037 GetByKey(string item037ID)
        {
            return this.Query().Where("[Item037ID] = @0", item037ID).GetSingle();  
        }
        
        public void DeleteByKey(string item037ID)
        {
            this.Delete(new Item037() { Item037ID = item037ID });
        }
    }


    public partial class Item038Repository : Repository<Item038>
    {
        public Item038Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item038 GetByKey(string item038ID)
        {
            return this.Query().Where("[Item038ID] = @0", item038ID).GetSingle();  
        }
        
        public void DeleteByKey(string item038ID)
        {
            this.Delete(new Item038() { Item038ID = item038ID });
        }
    }


    public partial class Item039Repository : Repository<Item039>
    {
        public Item039Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item039 GetByKey(string item039ID)
        {
            return this.Query().Where("[Item039ID] = @0", item039ID).GetSingle();  
        }
        
        public void DeleteByKey(string item039ID)
        {
            this.Delete(new Item039() { Item039ID = item039ID });
        }
    }


    public partial class Item040Repository : Repository<Item040>
    {
        public Item040Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item040 GetByKey(string item040ID)
        {
            return this.Query().Where("[Item040ID] = @0", item040ID).GetSingle();  
        }
        
        public void DeleteByKey(string item040ID)
        {
            this.Delete(new Item040() { Item040ID = item040ID });
        }
    }


    public partial class Item041Repository : Repository<Item041>
    {
        public Item041Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item041 GetByKey(string item041ID)
        {
            return this.Query().Where("[Item041ID] = @0", item041ID).GetSingle();  
        }
        
        public void DeleteByKey(string item041ID)
        {
            this.Delete(new Item041() { Item041ID = item041ID });
        }
    }


    public partial class Item042Repository : Repository<Item042>
    {
        public Item042Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item042 GetByKey(string item042ID)
        {
            return this.Query().Where("[Item042ID] = @0", item042ID).GetSingle();  
        }
        
        public void DeleteByKey(string item042ID)
        {
            this.Delete(new Item042() { Item042ID = item042ID });
        }
    }


    public partial class Item043Repository : Repository<Item043>
    {
        public Item043Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item043 GetByKey(string item043ID)
        {
            return this.Query().Where("[Item043ID] = @0", item043ID).GetSingle();  
        }
        
        public void DeleteByKey(string item043ID)
        {
            this.Delete(new Item043() { Item043ID = item043ID });
        }
    }


    public partial class Item044Repository : Repository<Item044>
    {
        public Item044Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item044 GetByKey(string item044ID)
        {
            return this.Query().Where("[Item044ID] = @0", item044ID).GetSingle();  
        }
        
        public void DeleteByKey(string item044ID)
        {
            this.Delete(new Item044() { Item044ID = item044ID });
        }
    }


    public partial class Item045Repository : Repository<Item045>
    {
        public Item045Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item045 GetByKey(string item045ID)
        {
            return this.Query().Where("[Item045ID] = @0", item045ID).GetSingle();  
        }
        
        public void DeleteByKey(string item045ID)
        {
            this.Delete(new Item045() { Item045ID = item045ID });
        }
    }


    public partial class Item046Repository : Repository<Item046>
    {
        public Item046Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item046 GetByKey(string item046ID)
        {
            return this.Query().Where("[Item046ID] = @0", item046ID).GetSingle();  
        }
        
        public void DeleteByKey(string item046ID)
        {
            this.Delete(new Item046() { Item046ID = item046ID });
        }
    }


    public partial class Item047Repository : Repository<Item047>
    {
        public Item047Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item047 GetByKey(string item047ID)
        {
            return this.Query().Where("[Item047ID] = @0", item047ID).GetSingle();  
        }
        
        public void DeleteByKey(string item047ID)
        {
            this.Delete(new Item047() { Item047ID = item047ID });
        }
    }


    public partial class Item048Repository : Repository<Item048>
    {
        public Item048Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item048 GetByKey(string item048ID)
        {
            return this.Query().Where("[Item048ID] = @0", item048ID).GetSingle();  
        }
        
        public void DeleteByKey(string item048ID)
        {
            this.Delete(new Item048() { Item048ID = item048ID });
        }
    }


    public partial class Item049Repository : Repository<Item049>
    {
        public Item049Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item049 GetByKey(string item049ID)
        {
            return this.Query().Where("[Item049ID] = @0", item049ID).GetSingle();  
        }
        
        public void DeleteByKey(string item049ID)
        {
            this.Delete(new Item049() { Item049ID = item049ID });
        }
    }


    public partial class Item050Repository : Repository<Item050>
    {
        public Item050Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item050 GetByKey(string item050ID)
        {
            return this.Query().Where("[Item050ID] = @0", item050ID).GetSingle();  
        }
        
        public void DeleteByKey(string item050ID)
        {
            this.Delete(new Item050() { Item050ID = item050ID });
        }
    }


    public partial class Item051Repository : Repository<Item051>
    {
        public Item051Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item051 GetByKey(string item051ID)
        {
            return this.Query().Where("[Item051ID] = @0", item051ID).GetSingle();  
        }
        
        public void DeleteByKey(string item051ID)
        {
            this.Delete(new Item051() { Item051ID = item051ID });
        }
    }


    public partial class Item052Repository : Repository<Item052>
    {
        public Item052Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item052 GetByKey(string item052ID)
        {
            return this.Query().Where("[Item052ID] = @0", item052ID).GetSingle();  
        }
        
        public void DeleteByKey(string item052ID)
        {
            this.Delete(new Item052() { Item052ID = item052ID });
        }
    }


    public partial class Item053Repository : Repository<Item053>
    {
        public Item053Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item053 GetByKey(string item053ID)
        {
            return this.Query().Where("[Item053ID] = @0", item053ID).GetSingle();  
        }
        
        public void DeleteByKey(string item053ID)
        {
            this.Delete(new Item053() { Item053ID = item053ID });
        }
    }


    public partial class Item054Repository : Repository<Item054>
    {
        public Item054Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item054 GetByKey(string item054ID)
        {
            return this.Query().Where("[Item054ID] = @0", item054ID).GetSingle();  
        }
        
        public void DeleteByKey(string item054ID)
        {
            this.Delete(new Item054() { Item054ID = item054ID });
        }
    }


    public partial class Item055Repository : Repository<Item055>
    {
        public Item055Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item055 GetByKey(string item055ID)
        {
            return this.Query().Where("[Item055ID] = @0", item055ID).GetSingle();  
        }
        
        public void DeleteByKey(string item055ID)
        {
            this.Delete(new Item055() { Item055ID = item055ID });
        }
    }


    public partial class Item056Repository : Repository<Item056>
    {
        public Item056Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item056 GetByKey(string item056ID)
        {
            return this.Query().Where("[Item056ID] = @0", item056ID).GetSingle();  
        }
        
        public void DeleteByKey(string item056ID)
        {
            this.Delete(new Item056() { Item056ID = item056ID });
        }
    }


    public partial class Item057Repository : Repository<Item057>
    {
        public Item057Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item057 GetByKey(string item057ID)
        {
            return this.Query().Where("[Item057ID] = @0", item057ID).GetSingle();  
        }
        
        public void DeleteByKey(string item057ID)
        {
            this.Delete(new Item057() { Item057ID = item057ID });
        }
    }


    public partial class Item058Repository : Repository<Item058>
    {
        public Item058Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item058 GetByKey(string item058ID)
        {
            return this.Query().Where("[Item058ID] = @0", item058ID).GetSingle();  
        }
        
        public void DeleteByKey(string item058ID)
        {
            this.Delete(new Item058() { Item058ID = item058ID });
        }
    }


    public partial class Item059Repository : Repository<Item059>
    {
        public Item059Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item059 GetByKey(string item059ID)
        {
            return this.Query().Where("[Item059ID] = @0", item059ID).GetSingle();  
        }
        
        public void DeleteByKey(string item059ID)
        {
            this.Delete(new Item059() { Item059ID = item059ID });
        }
    }


    public partial class Item060Repository : Repository<Item060>
    {
        public Item060Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item060 GetByKey(string item060ID)
        {
            return this.Query().Where("[Item060ID] = @0", item060ID).GetSingle();  
        }
        
        public void DeleteByKey(string item060ID)
        {
            this.Delete(new Item060() { Item060ID = item060ID });
        }
    }


    public partial class Item061Repository : Repository<Item061>
    {
        public Item061Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item061 GetByKey(string item061ID)
        {
            return this.Query().Where("[Item061ID] = @0", item061ID).GetSingle();  
        }
        
        public void DeleteByKey(string item061ID)
        {
            this.Delete(new Item061() { Item061ID = item061ID });
        }
    }


    public partial class Item062Repository : Repository<Item062>
    {
        public Item062Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item062 GetByKey(string item062ID)
        {
            return this.Query().Where("[Item062ID] = @0", item062ID).GetSingle();  
        }
        
        public void DeleteByKey(string item062ID)
        {
            this.Delete(new Item062() { Item062ID = item062ID });
        }
    }


    public partial class Item063Repository : Repository<Item063>
    {
        public Item063Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item063 GetByKey(string item063ID)
        {
            return this.Query().Where("[Item063ID] = @0", item063ID).GetSingle();  
        }
        
        public void DeleteByKey(string item063ID)
        {
            this.Delete(new Item063() { Item063ID = item063ID });
        }
    }


    public partial class Item064Repository : Repository<Item064>
    {
        public Item064Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item064 GetByKey(string item064ID)
        {
            return this.Query().Where("[Item064ID] = @0", item064ID).GetSingle();  
        }
        
        public void DeleteByKey(string item064ID)
        {
            this.Delete(new Item064() { Item064ID = item064ID });
        }
    }


    public partial class Item065Repository : Repository<Item065>
    {
        public Item065Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item065 GetByKey(string item065ID)
        {
            return this.Query().Where("[Item065ID] = @0", item065ID).GetSingle();  
        }
        
        public void DeleteByKey(string item065ID)
        {
            this.Delete(new Item065() { Item065ID = item065ID });
        }
    }


    public partial class Item066Repository : Repository<Item066>
    {
        public Item066Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item066 GetByKey(string item066ID)
        {
            return this.Query().Where("[Item066ID] = @0", item066ID).GetSingle();  
        }
        
        public void DeleteByKey(string item066ID)
        {
            this.Delete(new Item066() { Item066ID = item066ID });
        }
    }


    public partial class Item067Repository : Repository<Item067>
    {
        public Item067Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item067 GetByKey(string item067ID)
        {
            return this.Query().Where("[Item067ID] = @0", item067ID).GetSingle();  
        }
        
        public void DeleteByKey(string item067ID)
        {
            this.Delete(new Item067() { Item067ID = item067ID });
        }
    }


    public partial class Item068Repository : Repository<Item068>
    {
        public Item068Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item068 GetByKey(string item068ID)
        {
            return this.Query().Where("[Item068ID] = @0", item068ID).GetSingle();  
        }
        
        public void DeleteByKey(string item068ID)
        {
            this.Delete(new Item068() { Item068ID = item068ID });
        }
    }


    public partial class Item069Repository : Repository<Item069>
    {
        public Item069Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item069 GetByKey(string item069ID)
        {
            return this.Query().Where("[Item069ID] = @0", item069ID).GetSingle();  
        }
        
        public void DeleteByKey(string item069ID)
        {
            this.Delete(new Item069() { Item069ID = item069ID });
        }
    }


    public partial class Item070Repository : Repository<Item070>
    {
        public Item070Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item070 GetByKey(string item070ID)
        {
            return this.Query().Where("[Item070ID] = @0", item070ID).GetSingle();  
        }
        
        public void DeleteByKey(string item070ID)
        {
            this.Delete(new Item070() { Item070ID = item070ID });
        }
    }


    public partial class Item071Repository : Repository<Item071>
    {
        public Item071Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item071 GetByKey(string item071ID)
        {
            return this.Query().Where("[Item071ID] = @0", item071ID).GetSingle();  
        }
        
        public void DeleteByKey(string item071ID)
        {
            this.Delete(new Item071() { Item071ID = item071ID });
        }
    }


    public partial class Item072Repository : Repository<Item072>
    {
        public Item072Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item072 GetByKey(string item072ID)
        {
            return this.Query().Where("[Item072ID] = @0", item072ID).GetSingle();  
        }
        
        public void DeleteByKey(string item072ID)
        {
            this.Delete(new Item072() { Item072ID = item072ID });
        }
    }


    public partial class Item073Repository : Repository<Item073>
    {
        public Item073Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item073 GetByKey(string item073ID)
        {
            return this.Query().Where("[Item073ID] = @0", item073ID).GetSingle();  
        }
        
        public void DeleteByKey(string item073ID)
        {
            this.Delete(new Item073() { Item073ID = item073ID });
        }
    }


    public partial class Item074Repository : Repository<Item074>
    {
        public Item074Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item074 GetByKey(string item074ID)
        {
            return this.Query().Where("[Item074ID] = @0", item074ID).GetSingle();  
        }
        
        public void DeleteByKey(string item074ID)
        {
            this.Delete(new Item074() { Item074ID = item074ID });
        }
    }


    public partial class Item075Repository : Repository<Item075>
    {
        public Item075Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item075 GetByKey(string item075ID)
        {
            return this.Query().Where("[Item075ID] = @0", item075ID).GetSingle();  
        }
        
        public void DeleteByKey(string item075ID)
        {
            this.Delete(new Item075() { Item075ID = item075ID });
        }
    }


    public partial class Item076Repository : Repository<Item076>
    {
        public Item076Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item076 GetByKey(string item076ID)
        {
            return this.Query().Where("[Item076ID] = @0", item076ID).GetSingle();  
        }
        
        public void DeleteByKey(string item076ID)
        {
            this.Delete(new Item076() { Item076ID = item076ID });
        }
    }


    public partial class Item077Repository : Repository<Item077>
    {
        public Item077Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item077 GetByKey(string item077ID)
        {
            return this.Query().Where("[Item077ID] = @0", item077ID).GetSingle();  
        }
        
        public void DeleteByKey(string item077ID)
        {
            this.Delete(new Item077() { Item077ID = item077ID });
        }
    }


    public partial class Item078Repository : Repository<Item078>
    {
        public Item078Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item078 GetByKey(string item078ID)
        {
            return this.Query().Where("[Item078ID] = @0", item078ID).GetSingle();  
        }
        
        public void DeleteByKey(string item078ID)
        {
            this.Delete(new Item078() { Item078ID = item078ID });
        }
    }


    public partial class Item079Repository : Repository<Item079>
    {
        public Item079Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item079 GetByKey(string item079ID)
        {
            return this.Query().Where("[Item079ID] = @0", item079ID).GetSingle();  
        }
        
        public void DeleteByKey(string item079ID)
        {
            this.Delete(new Item079() { Item079ID = item079ID });
        }
    }


    public partial class Item080Repository : Repository<Item080>
    {
        public Item080Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item080 GetByKey(string item080ID)
        {
            return this.Query().Where("[Item080ID] = @0", item080ID).GetSingle();  
        }
        
        public void DeleteByKey(string item080ID)
        {
            this.Delete(new Item080() { Item080ID = item080ID });
        }
    }


    public partial class Item081Repository : Repository<Item081>
    {
        public Item081Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item081 GetByKey(string item081ID)
        {
            return this.Query().Where("[Item081ID] = @0", item081ID).GetSingle();  
        }
        
        public void DeleteByKey(string item081ID)
        {
            this.Delete(new Item081() { Item081ID = item081ID });
        }
    }


    public partial class Item082Repository : Repository<Item082>
    {
        public Item082Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item082 GetByKey(string item082ID)
        {
            return this.Query().Where("[Item082ID] = @0", item082ID).GetSingle();  
        }
        
        public void DeleteByKey(string item082ID)
        {
            this.Delete(new Item082() { Item082ID = item082ID });
        }
    }


    public partial class Item083Repository : Repository<Item083>
    {
        public Item083Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item083 GetByKey(string item083ID)
        {
            return this.Query().Where("[Item083ID] = @0", item083ID).GetSingle();  
        }
        
        public void DeleteByKey(string item083ID)
        {
            this.Delete(new Item083() { Item083ID = item083ID });
        }
    }


    public partial class Item084Repository : Repository<Item084>
    {
        public Item084Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item084 GetByKey(string item084ID)
        {
            return this.Query().Where("[Item084ID] = @0", item084ID).GetSingle();  
        }
        
        public void DeleteByKey(string item084ID)
        {
            this.Delete(new Item084() { Item084ID = item084ID });
        }
    }


    public partial class Item085Repository : Repository<Item085>
    {
        public Item085Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item085 GetByKey(string item085ID)
        {
            return this.Query().Where("[Item085ID] = @0", item085ID).GetSingle();  
        }
        
        public void DeleteByKey(string item085ID)
        {
            this.Delete(new Item085() { Item085ID = item085ID });
        }
    }


    public partial class Item086Repository : Repository<Item086>
    {
        public Item086Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item086 GetByKey(string item086ID)
        {
            return this.Query().Where("[Item086ID] = @0", item086ID).GetSingle();  
        }
        
        public void DeleteByKey(string item086ID)
        {
            this.Delete(new Item086() { Item086ID = item086ID });
        }
    }


    public partial class Item087Repository : Repository<Item087>
    {
        public Item087Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item087 GetByKey(string item087ID)
        {
            return this.Query().Where("[Item087ID] = @0", item087ID).GetSingle();  
        }
        
        public void DeleteByKey(string item087ID)
        {
            this.Delete(new Item087() { Item087ID = item087ID });
        }
    }


    public partial class Item088Repository : Repository<Item088>
    {
        public Item088Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item088 GetByKey(string item088ID)
        {
            return this.Query().Where("[Item088ID] = @0", item088ID).GetSingle();  
        }
        
        public void DeleteByKey(string item088ID)
        {
            this.Delete(new Item088() { Item088ID = item088ID });
        }
    }


    public partial class Item089Repository : Repository<Item089>
    {
        public Item089Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item089 GetByKey(string item089ID)
        {
            return this.Query().Where("[Item089ID] = @0", item089ID).GetSingle();  
        }
        
        public void DeleteByKey(string item089ID)
        {
            this.Delete(new Item089() { Item089ID = item089ID });
        }
    }


    public partial class Item090Repository : Repository<Item090>
    {
        public Item090Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item090 GetByKey(string item090ID)
        {
            return this.Query().Where("[Item090ID] = @0", item090ID).GetSingle();  
        }
        
        public void DeleteByKey(string item090ID)
        {
            this.Delete(new Item090() { Item090ID = item090ID });
        }
    }


    public partial class Item091Repository : Repository<Item091>
    {
        public Item091Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item091 GetByKey(string item091ID)
        {
            return this.Query().Where("[Item091ID] = @0", item091ID).GetSingle();  
        }
        
        public void DeleteByKey(string item091ID)
        {
            this.Delete(new Item091() { Item091ID = item091ID });
        }
    }


    public partial class Item092Repository : Repository<Item092>
    {
        public Item092Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item092 GetByKey(string item092ID)
        {
            return this.Query().Where("[Item092ID] = @0", item092ID).GetSingle();  
        }
        
        public void DeleteByKey(string item092ID)
        {
            this.Delete(new Item092() { Item092ID = item092ID });
        }
    }


    public partial class Item093Repository : Repository<Item093>
    {
        public Item093Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item093 GetByKey(string item093ID)
        {
            return this.Query().Where("[Item093ID] = @0", item093ID).GetSingle();  
        }
        
        public void DeleteByKey(string item093ID)
        {
            this.Delete(new Item093() { Item093ID = item093ID });
        }
    }


    public partial class Item094Repository : Repository<Item094>
    {
        public Item094Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item094 GetByKey(string item094ID)
        {
            return this.Query().Where("[Item094ID] = @0", item094ID).GetSingle();  
        }
        
        public void DeleteByKey(string item094ID)
        {
            this.Delete(new Item094() { Item094ID = item094ID });
        }
    }


    public partial class Item095Repository : Repository<Item095>
    {
        public Item095Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item095 GetByKey(string item095ID)
        {
            return this.Query().Where("[Item095ID] = @0", item095ID).GetSingle();  
        }
        
        public void DeleteByKey(string item095ID)
        {
            this.Delete(new Item095() { Item095ID = item095ID });
        }
    }


    public partial class Item096Repository : Repository<Item096>
    {
        public Item096Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item096 GetByKey(string item096ID)
        {
            return this.Query().Where("[Item096ID] = @0", item096ID).GetSingle();  
        }
        
        public void DeleteByKey(string item096ID)
        {
            this.Delete(new Item096() { Item096ID = item096ID });
        }
    }


    public partial class Item097Repository : Repository<Item097>
    {
        public Item097Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item097 GetByKey(string item097ID)
        {
            return this.Query().Where("[Item097ID] = @0", item097ID).GetSingle();  
        }
        
        public void DeleteByKey(string item097ID)
        {
            this.Delete(new Item097() { Item097ID = item097ID });
        }
    }


    public partial class Item098Repository : Repository<Item098>
    {
        public Item098Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item098 GetByKey(string item098ID)
        {
            return this.Query().Where("[Item098ID] = @0", item098ID).GetSingle();  
        }
        
        public void DeleteByKey(string item098ID)
        {
            this.Delete(new Item098() { Item098ID = item098ID });
        }
    }


    public partial class Item099Repository : Repository<Item099>
    {
        public Item099Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item099 GetByKey(string item099ID)
        {
            return this.Query().Where("[Item099ID] = @0", item099ID).GetSingle();  
        }
        
        public void DeleteByKey(string item099ID)
        {
            this.Delete(new Item099() { Item099ID = item099ID });
        }
    }


    public partial class Item100Repository : Repository<Item100>
    {
        public Item100Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Item100 GetByKey(string item100ID)
        {
            return this.Query().Where("[Item100ID] = @0", item100ID).GetSingle();  
        }
        
        public void DeleteByKey(string item100ID)
        {
            this.Delete(new Item100() { Item100ID = item100ID });
        }
    }


    public partial class OrderRepository : Repository<Order>
    {
        public OrderRepository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order GetByKey(int orderID)
        {
            return this.Query().Where("[OrderID] = @0", orderID).GetSingle();  
        }
        
        public void DeleteByKey(int orderID)
        {
            this.Delete(new Order() { OrderID = orderID });
        }
    }


    public partial class Order001Repository : Repository<Order001>
    {
        public Order001Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order001 GetByKey(int order001ID)
        {
            return this.Query().Where("[Order001ID] = @0", order001ID).GetSingle();  
        }
        
        public void DeleteByKey(int order001ID)
        {
            this.Delete(new Order001() { Order001ID = order001ID });
        }
    }


    public partial class Order002Repository : Repository<Order002>
    {
        public Order002Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order002 GetByKey(int order002ID)
        {
            return this.Query().Where("[Order002ID] = @0", order002ID).GetSingle();  
        }
        
        public void DeleteByKey(int order002ID)
        {
            this.Delete(new Order002() { Order002ID = order002ID });
        }
    }


    public partial class Order003Repository : Repository<Order003>
    {
        public Order003Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order003 GetByKey(int order003ID)
        {
            return this.Query().Where("[Order003ID] = @0", order003ID).GetSingle();  
        }
        
        public void DeleteByKey(int order003ID)
        {
            this.Delete(new Order003() { Order003ID = order003ID });
        }
    }


    public partial class Order004Repository : Repository<Order004>
    {
        public Order004Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order004 GetByKey(int order004ID)
        {
            return this.Query().Where("[Order004ID] = @0", order004ID).GetSingle();  
        }
        
        public void DeleteByKey(int order004ID)
        {
            this.Delete(new Order004() { Order004ID = order004ID });
        }
    }


    public partial class Order005Repository : Repository<Order005>
    {
        public Order005Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order005 GetByKey(int order005ID)
        {
            return this.Query().Where("[Order005ID] = @0", order005ID).GetSingle();  
        }
        
        public void DeleteByKey(int order005ID)
        {
            this.Delete(new Order005() { Order005ID = order005ID });
        }
    }


    public partial class Order006Repository : Repository<Order006>
    {
        public Order006Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order006 GetByKey(int order006ID)
        {
            return this.Query().Where("[Order006ID] = @0", order006ID).GetSingle();  
        }
        
        public void DeleteByKey(int order006ID)
        {
            this.Delete(new Order006() { Order006ID = order006ID });
        }
    }


    public partial class Order007Repository : Repository<Order007>
    {
        public Order007Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order007 GetByKey(int order007ID)
        {
            return this.Query().Where("[Order007ID] = @0", order007ID).GetSingle();  
        }
        
        public void DeleteByKey(int order007ID)
        {
            this.Delete(new Order007() { Order007ID = order007ID });
        }
    }


    public partial class Order008Repository : Repository<Order008>
    {
        public Order008Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order008 GetByKey(int order008ID)
        {
            return this.Query().Where("[Order008ID] = @0", order008ID).GetSingle();  
        }
        
        public void DeleteByKey(int order008ID)
        {
            this.Delete(new Order008() { Order008ID = order008ID });
        }
    }


    public partial class Order009Repository : Repository<Order009>
    {
        public Order009Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order009 GetByKey(int order009ID)
        {
            return this.Query().Where("[Order009ID] = @0", order009ID).GetSingle();  
        }
        
        public void DeleteByKey(int order009ID)
        {
            this.Delete(new Order009() { Order009ID = order009ID });
        }
    }


    public partial class Order010Repository : Repository<Order010>
    {
        public Order010Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order010 GetByKey(int order010ID)
        {
            return this.Query().Where("[Order010ID] = @0", order010ID).GetSingle();  
        }
        
        public void DeleteByKey(int order010ID)
        {
            this.Delete(new Order010() { Order010ID = order010ID });
        }
    }


    public partial class Order011Repository : Repository<Order011>
    {
        public Order011Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order011 GetByKey(int order011ID)
        {
            return this.Query().Where("[Order011ID] = @0", order011ID).GetSingle();  
        }
        
        public void DeleteByKey(int order011ID)
        {
            this.Delete(new Order011() { Order011ID = order011ID });
        }
    }


    public partial class Order012Repository : Repository<Order012>
    {
        public Order012Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order012 GetByKey(int order012ID)
        {
            return this.Query().Where("[Order012ID] = @0", order012ID).GetSingle();  
        }
        
        public void DeleteByKey(int order012ID)
        {
            this.Delete(new Order012() { Order012ID = order012ID });
        }
    }


    public partial class Order013Repository : Repository<Order013>
    {
        public Order013Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order013 GetByKey(int order013ID)
        {
            return this.Query().Where("[Order013ID] = @0", order013ID).GetSingle();  
        }
        
        public void DeleteByKey(int order013ID)
        {
            this.Delete(new Order013() { Order013ID = order013ID });
        }
    }


    public partial class Order014Repository : Repository<Order014>
    {
        public Order014Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order014 GetByKey(int order014ID)
        {
            return this.Query().Where("[Order014ID] = @0", order014ID).GetSingle();  
        }
        
        public void DeleteByKey(int order014ID)
        {
            this.Delete(new Order014() { Order014ID = order014ID });
        }
    }


    public partial class Order015Repository : Repository<Order015>
    {
        public Order015Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order015 GetByKey(int order015ID)
        {
            return this.Query().Where("[Order015ID] = @0", order015ID).GetSingle();  
        }
        
        public void DeleteByKey(int order015ID)
        {
            this.Delete(new Order015() { Order015ID = order015ID });
        }
    }


    public partial class Order016Repository : Repository<Order016>
    {
        public Order016Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order016 GetByKey(int order016ID)
        {
            return this.Query().Where("[Order016ID] = @0", order016ID).GetSingle();  
        }
        
        public void DeleteByKey(int order016ID)
        {
            this.Delete(new Order016() { Order016ID = order016ID });
        }
    }


    public partial class Order017Repository : Repository<Order017>
    {
        public Order017Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order017 GetByKey(int order017ID)
        {
            return this.Query().Where("[Order017ID] = @0", order017ID).GetSingle();  
        }
        
        public void DeleteByKey(int order017ID)
        {
            this.Delete(new Order017() { Order017ID = order017ID });
        }
    }


    public partial class Order018Repository : Repository<Order018>
    {
        public Order018Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order018 GetByKey(int order018ID)
        {
            return this.Query().Where("[Order018ID] = @0", order018ID).GetSingle();  
        }
        
        public void DeleteByKey(int order018ID)
        {
            this.Delete(new Order018() { Order018ID = order018ID });
        }
    }


    public partial class Order019Repository : Repository<Order019>
    {
        public Order019Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order019 GetByKey(int order019ID)
        {
            return this.Query().Where("[Order019ID] = @0", order019ID).GetSingle();  
        }
        
        public void DeleteByKey(int order019ID)
        {
            this.Delete(new Order019() { Order019ID = order019ID });
        }
    }


    public partial class Order020Repository : Repository<Order020>
    {
        public Order020Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order020 GetByKey(int order020ID)
        {
            return this.Query().Where("[Order020ID] = @0", order020ID).GetSingle();  
        }
        
        public void DeleteByKey(int order020ID)
        {
            this.Delete(new Order020() { Order020ID = order020ID });
        }
    }


    public partial class Order021Repository : Repository<Order021>
    {
        public Order021Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order021 GetByKey(int order021ID)
        {
            return this.Query().Where("[Order021ID] = @0", order021ID).GetSingle();  
        }
        
        public void DeleteByKey(int order021ID)
        {
            this.Delete(new Order021() { Order021ID = order021ID });
        }
    }


    public partial class Order022Repository : Repository<Order022>
    {
        public Order022Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order022 GetByKey(int order022ID)
        {
            return this.Query().Where("[Order022ID] = @0", order022ID).GetSingle();  
        }
        
        public void DeleteByKey(int order022ID)
        {
            this.Delete(new Order022() { Order022ID = order022ID });
        }
    }


    public partial class Order023Repository : Repository<Order023>
    {
        public Order023Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order023 GetByKey(int order023ID)
        {
            return this.Query().Where("[Order023ID] = @0", order023ID).GetSingle();  
        }
        
        public void DeleteByKey(int order023ID)
        {
            this.Delete(new Order023() { Order023ID = order023ID });
        }
    }


    public partial class Order024Repository : Repository<Order024>
    {
        public Order024Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order024 GetByKey(int order024ID)
        {
            return this.Query().Where("[Order024ID] = @0", order024ID).GetSingle();  
        }
        
        public void DeleteByKey(int order024ID)
        {
            this.Delete(new Order024() { Order024ID = order024ID });
        }
    }


    public partial class Order025Repository : Repository<Order025>
    {
        public Order025Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order025 GetByKey(int order025ID)
        {
            return this.Query().Where("[Order025ID] = @0", order025ID).GetSingle();  
        }
        
        public void DeleteByKey(int order025ID)
        {
            this.Delete(new Order025() { Order025ID = order025ID });
        }
    }


    public partial class Order026Repository : Repository<Order026>
    {
        public Order026Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order026 GetByKey(int order026ID)
        {
            return this.Query().Where("[Order026ID] = @0", order026ID).GetSingle();  
        }
        
        public void DeleteByKey(int order026ID)
        {
            this.Delete(new Order026() { Order026ID = order026ID });
        }
    }


    public partial class Order027Repository : Repository<Order027>
    {
        public Order027Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order027 GetByKey(int order027ID)
        {
            return this.Query().Where("[Order027ID] = @0", order027ID).GetSingle();  
        }
        
        public void DeleteByKey(int order027ID)
        {
            this.Delete(new Order027() { Order027ID = order027ID });
        }
    }


    public partial class Order028Repository : Repository<Order028>
    {
        public Order028Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order028 GetByKey(int order028ID)
        {
            return this.Query().Where("[Order028ID] = @0", order028ID).GetSingle();  
        }
        
        public void DeleteByKey(int order028ID)
        {
            this.Delete(new Order028() { Order028ID = order028ID });
        }
    }


    public partial class Order029Repository : Repository<Order029>
    {
        public Order029Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order029 GetByKey(int order029ID)
        {
            return this.Query().Where("[Order029ID] = @0", order029ID).GetSingle();  
        }
        
        public void DeleteByKey(int order029ID)
        {
            this.Delete(new Order029() { Order029ID = order029ID });
        }
    }


    public partial class Order030Repository : Repository<Order030>
    {
        public Order030Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order030 GetByKey(int order030ID)
        {
            return this.Query().Where("[Order030ID] = @0", order030ID).GetSingle();  
        }
        
        public void DeleteByKey(int order030ID)
        {
            this.Delete(new Order030() { Order030ID = order030ID });
        }
    }


    public partial class Order031Repository : Repository<Order031>
    {
        public Order031Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order031 GetByKey(int order031ID)
        {
            return this.Query().Where("[Order031ID] = @0", order031ID).GetSingle();  
        }
        
        public void DeleteByKey(int order031ID)
        {
            this.Delete(new Order031() { Order031ID = order031ID });
        }
    }


    public partial class Order032Repository : Repository<Order032>
    {
        public Order032Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order032 GetByKey(int order032ID)
        {
            return this.Query().Where("[Order032ID] = @0", order032ID).GetSingle();  
        }
        
        public void DeleteByKey(int order032ID)
        {
            this.Delete(new Order032() { Order032ID = order032ID });
        }
    }


    public partial class Order033Repository : Repository<Order033>
    {
        public Order033Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order033 GetByKey(int order033ID)
        {
            return this.Query().Where("[Order033ID] = @0", order033ID).GetSingle();  
        }
        
        public void DeleteByKey(int order033ID)
        {
            this.Delete(new Order033() { Order033ID = order033ID });
        }
    }


    public partial class Order034Repository : Repository<Order034>
    {
        public Order034Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order034 GetByKey(int order034ID)
        {
            return this.Query().Where("[Order034ID] = @0", order034ID).GetSingle();  
        }
        
        public void DeleteByKey(int order034ID)
        {
            this.Delete(new Order034() { Order034ID = order034ID });
        }
    }


    public partial class Order035Repository : Repository<Order035>
    {
        public Order035Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order035 GetByKey(int order035ID)
        {
            return this.Query().Where("[Order035ID] = @0", order035ID).GetSingle();  
        }
        
        public void DeleteByKey(int order035ID)
        {
            this.Delete(new Order035() { Order035ID = order035ID });
        }
    }


    public partial class Order036Repository : Repository<Order036>
    {
        public Order036Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order036 GetByKey(int order036ID)
        {
            return this.Query().Where("[Order036ID] = @0", order036ID).GetSingle();  
        }
        
        public void DeleteByKey(int order036ID)
        {
            this.Delete(new Order036() { Order036ID = order036ID });
        }
    }


    public partial class Order037Repository : Repository<Order037>
    {
        public Order037Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order037 GetByKey(int order037ID)
        {
            return this.Query().Where("[Order037ID] = @0", order037ID).GetSingle();  
        }
        
        public void DeleteByKey(int order037ID)
        {
            this.Delete(new Order037() { Order037ID = order037ID });
        }
    }


    public partial class Order038Repository : Repository<Order038>
    {
        public Order038Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order038 GetByKey(int order038ID)
        {
            return this.Query().Where("[Order038ID] = @0", order038ID).GetSingle();  
        }
        
        public void DeleteByKey(int order038ID)
        {
            this.Delete(new Order038() { Order038ID = order038ID });
        }
    }


    public partial class Order039Repository : Repository<Order039>
    {
        public Order039Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order039 GetByKey(int order039ID)
        {
            return this.Query().Where("[Order039ID] = @0", order039ID).GetSingle();  
        }
        
        public void DeleteByKey(int order039ID)
        {
            this.Delete(new Order039() { Order039ID = order039ID });
        }
    }


    public partial class Order040Repository : Repository<Order040>
    {
        public Order040Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order040 GetByKey(int order040ID)
        {
            return this.Query().Where("[Order040ID] = @0", order040ID).GetSingle();  
        }
        
        public void DeleteByKey(int order040ID)
        {
            this.Delete(new Order040() { Order040ID = order040ID });
        }
    }


    public partial class Order041Repository : Repository<Order041>
    {
        public Order041Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order041 GetByKey(int order041ID)
        {
            return this.Query().Where("[Order041ID] = @0", order041ID).GetSingle();  
        }
        
        public void DeleteByKey(int order041ID)
        {
            this.Delete(new Order041() { Order041ID = order041ID });
        }
    }


    public partial class Order042Repository : Repository<Order042>
    {
        public Order042Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order042 GetByKey(int order042ID)
        {
            return this.Query().Where("[Order042ID] = @0", order042ID).GetSingle();  
        }
        
        public void DeleteByKey(int order042ID)
        {
            this.Delete(new Order042() { Order042ID = order042ID });
        }
    }


    public partial class Order043Repository : Repository<Order043>
    {
        public Order043Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order043 GetByKey(int order043ID)
        {
            return this.Query().Where("[Order043ID] = @0", order043ID).GetSingle();  
        }
        
        public void DeleteByKey(int order043ID)
        {
            this.Delete(new Order043() { Order043ID = order043ID });
        }
    }


    public partial class Order044Repository : Repository<Order044>
    {
        public Order044Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order044 GetByKey(int order044ID)
        {
            return this.Query().Where("[Order044ID] = @0", order044ID).GetSingle();  
        }
        
        public void DeleteByKey(int order044ID)
        {
            this.Delete(new Order044() { Order044ID = order044ID });
        }
    }


    public partial class Order045Repository : Repository<Order045>
    {
        public Order045Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order045 GetByKey(int order045ID)
        {
            return this.Query().Where("[Order045ID] = @0", order045ID).GetSingle();  
        }
        
        public void DeleteByKey(int order045ID)
        {
            this.Delete(new Order045() { Order045ID = order045ID });
        }
    }


    public partial class Order046Repository : Repository<Order046>
    {
        public Order046Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order046 GetByKey(int order046ID)
        {
            return this.Query().Where("[Order046ID] = @0", order046ID).GetSingle();  
        }
        
        public void DeleteByKey(int order046ID)
        {
            this.Delete(new Order046() { Order046ID = order046ID });
        }
    }


    public partial class Order047Repository : Repository<Order047>
    {
        public Order047Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order047 GetByKey(int order047ID)
        {
            return this.Query().Where("[Order047ID] = @0", order047ID).GetSingle();  
        }
        
        public void DeleteByKey(int order047ID)
        {
            this.Delete(new Order047() { Order047ID = order047ID });
        }
    }


    public partial class Order048Repository : Repository<Order048>
    {
        public Order048Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order048 GetByKey(int order048ID)
        {
            return this.Query().Where("[Order048ID] = @0", order048ID).GetSingle();  
        }
        
        public void DeleteByKey(int order048ID)
        {
            this.Delete(new Order048() { Order048ID = order048ID });
        }
    }


    public partial class Order049Repository : Repository<Order049>
    {
        public Order049Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order049 GetByKey(int order049ID)
        {
            return this.Query().Where("[Order049ID] = @0", order049ID).GetSingle();  
        }
        
        public void DeleteByKey(int order049ID)
        {
            this.Delete(new Order049() { Order049ID = order049ID });
        }
    }


    public partial class Order050Repository : Repository<Order050>
    {
        public Order050Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order050 GetByKey(int order050ID)
        {
            return this.Query().Where("[Order050ID] = @0", order050ID).GetSingle();  
        }
        
        public void DeleteByKey(int order050ID)
        {
            this.Delete(new Order050() { Order050ID = order050ID });
        }
    }


    public partial class Order051Repository : Repository<Order051>
    {
        public Order051Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order051 GetByKey(int order051ID)
        {
            return this.Query().Where("[Order051ID] = @0", order051ID).GetSingle();  
        }
        
        public void DeleteByKey(int order051ID)
        {
            this.Delete(new Order051() { Order051ID = order051ID });
        }
    }


    public partial class Order052Repository : Repository<Order052>
    {
        public Order052Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order052 GetByKey(int order052ID)
        {
            return this.Query().Where("[Order052ID] = @0", order052ID).GetSingle();  
        }
        
        public void DeleteByKey(int order052ID)
        {
            this.Delete(new Order052() { Order052ID = order052ID });
        }
    }


    public partial class Order053Repository : Repository<Order053>
    {
        public Order053Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order053 GetByKey(int order053ID)
        {
            return this.Query().Where("[Order053ID] = @0", order053ID).GetSingle();  
        }
        
        public void DeleteByKey(int order053ID)
        {
            this.Delete(new Order053() { Order053ID = order053ID });
        }
    }


    public partial class Order054Repository : Repository<Order054>
    {
        public Order054Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order054 GetByKey(int order054ID)
        {
            return this.Query().Where("[Order054ID] = @0", order054ID).GetSingle();  
        }
        
        public void DeleteByKey(int order054ID)
        {
            this.Delete(new Order054() { Order054ID = order054ID });
        }
    }


    public partial class Order055Repository : Repository<Order055>
    {
        public Order055Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order055 GetByKey(int order055ID)
        {
            return this.Query().Where("[Order055ID] = @0", order055ID).GetSingle();  
        }
        
        public void DeleteByKey(int order055ID)
        {
            this.Delete(new Order055() { Order055ID = order055ID });
        }
    }


    public partial class Order056Repository : Repository<Order056>
    {
        public Order056Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order056 GetByKey(int order056ID)
        {
            return this.Query().Where("[Order056ID] = @0", order056ID).GetSingle();  
        }
        
        public void DeleteByKey(int order056ID)
        {
            this.Delete(new Order056() { Order056ID = order056ID });
        }
    }


    public partial class Order057Repository : Repository<Order057>
    {
        public Order057Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order057 GetByKey(int order057ID)
        {
            return this.Query().Where("[Order057ID] = @0", order057ID).GetSingle();  
        }
        
        public void DeleteByKey(int order057ID)
        {
            this.Delete(new Order057() { Order057ID = order057ID });
        }
    }


    public partial class Order058Repository : Repository<Order058>
    {
        public Order058Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order058 GetByKey(int order058ID)
        {
            return this.Query().Where("[Order058ID] = @0", order058ID).GetSingle();  
        }
        
        public void DeleteByKey(int order058ID)
        {
            this.Delete(new Order058() { Order058ID = order058ID });
        }
    }


    public partial class Order059Repository : Repository<Order059>
    {
        public Order059Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order059 GetByKey(int order059ID)
        {
            return this.Query().Where("[Order059ID] = @0", order059ID).GetSingle();  
        }
        
        public void DeleteByKey(int order059ID)
        {
            this.Delete(new Order059() { Order059ID = order059ID });
        }
    }


    public partial class Order060Repository : Repository<Order060>
    {
        public Order060Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order060 GetByKey(int order060ID)
        {
            return this.Query().Where("[Order060ID] = @0", order060ID).GetSingle();  
        }
        
        public void DeleteByKey(int order060ID)
        {
            this.Delete(new Order060() { Order060ID = order060ID });
        }
    }


    public partial class Order061Repository : Repository<Order061>
    {
        public Order061Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order061 GetByKey(int order061ID)
        {
            return this.Query().Where("[Order061ID] = @0", order061ID).GetSingle();  
        }
        
        public void DeleteByKey(int order061ID)
        {
            this.Delete(new Order061() { Order061ID = order061ID });
        }
    }


    public partial class Order062Repository : Repository<Order062>
    {
        public Order062Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order062 GetByKey(int order062ID)
        {
            return this.Query().Where("[Order062ID] = @0", order062ID).GetSingle();  
        }
        
        public void DeleteByKey(int order062ID)
        {
            this.Delete(new Order062() { Order062ID = order062ID });
        }
    }


    public partial class Order063Repository : Repository<Order063>
    {
        public Order063Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order063 GetByKey(int order063ID)
        {
            return this.Query().Where("[Order063ID] = @0", order063ID).GetSingle();  
        }
        
        public void DeleteByKey(int order063ID)
        {
            this.Delete(new Order063() { Order063ID = order063ID });
        }
    }


    public partial class Order064Repository : Repository<Order064>
    {
        public Order064Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order064 GetByKey(int order064ID)
        {
            return this.Query().Where("[Order064ID] = @0", order064ID).GetSingle();  
        }
        
        public void DeleteByKey(int order064ID)
        {
            this.Delete(new Order064() { Order064ID = order064ID });
        }
    }


    public partial class Order065Repository : Repository<Order065>
    {
        public Order065Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order065 GetByKey(int order065ID)
        {
            return this.Query().Where("[Order065ID] = @0", order065ID).GetSingle();  
        }
        
        public void DeleteByKey(int order065ID)
        {
            this.Delete(new Order065() { Order065ID = order065ID });
        }
    }


    public partial class Order066Repository : Repository<Order066>
    {
        public Order066Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order066 GetByKey(int order066ID)
        {
            return this.Query().Where("[Order066ID] = @0", order066ID).GetSingle();  
        }
        
        public void DeleteByKey(int order066ID)
        {
            this.Delete(new Order066() { Order066ID = order066ID });
        }
    }


    public partial class Order067Repository : Repository<Order067>
    {
        public Order067Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order067 GetByKey(int order067ID)
        {
            return this.Query().Where("[Order067ID] = @0", order067ID).GetSingle();  
        }
        
        public void DeleteByKey(int order067ID)
        {
            this.Delete(new Order067() { Order067ID = order067ID });
        }
    }


    public partial class Order068Repository : Repository<Order068>
    {
        public Order068Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order068 GetByKey(int order068ID)
        {
            return this.Query().Where("[Order068ID] = @0", order068ID).GetSingle();  
        }
        
        public void DeleteByKey(int order068ID)
        {
            this.Delete(new Order068() { Order068ID = order068ID });
        }
    }


    public partial class Order069Repository : Repository<Order069>
    {
        public Order069Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order069 GetByKey(int order069ID)
        {
            return this.Query().Where("[Order069ID] = @0", order069ID).GetSingle();  
        }
        
        public void DeleteByKey(int order069ID)
        {
            this.Delete(new Order069() { Order069ID = order069ID });
        }
    }


    public partial class Order070Repository : Repository<Order070>
    {
        public Order070Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order070 GetByKey(int order070ID)
        {
            return this.Query().Where("[Order070ID] = @0", order070ID).GetSingle();  
        }
        
        public void DeleteByKey(int order070ID)
        {
            this.Delete(new Order070() { Order070ID = order070ID });
        }
    }


    public partial class Order071Repository : Repository<Order071>
    {
        public Order071Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order071 GetByKey(int order071ID)
        {
            return this.Query().Where("[Order071ID] = @0", order071ID).GetSingle();  
        }
        
        public void DeleteByKey(int order071ID)
        {
            this.Delete(new Order071() { Order071ID = order071ID });
        }
    }


    public partial class Order072Repository : Repository<Order072>
    {
        public Order072Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order072 GetByKey(int order072ID)
        {
            return this.Query().Where("[Order072ID] = @0", order072ID).GetSingle();  
        }
        
        public void DeleteByKey(int order072ID)
        {
            this.Delete(new Order072() { Order072ID = order072ID });
        }
    }


    public partial class Order073Repository : Repository<Order073>
    {
        public Order073Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order073 GetByKey(int order073ID)
        {
            return this.Query().Where("[Order073ID] = @0", order073ID).GetSingle();  
        }
        
        public void DeleteByKey(int order073ID)
        {
            this.Delete(new Order073() { Order073ID = order073ID });
        }
    }


    public partial class Order074Repository : Repository<Order074>
    {
        public Order074Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order074 GetByKey(int order074ID)
        {
            return this.Query().Where("[Order074ID] = @0", order074ID).GetSingle();  
        }
        
        public void DeleteByKey(int order074ID)
        {
            this.Delete(new Order074() { Order074ID = order074ID });
        }
    }


    public partial class Order075Repository : Repository<Order075>
    {
        public Order075Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order075 GetByKey(int order075ID)
        {
            return this.Query().Where("[Order075ID] = @0", order075ID).GetSingle();  
        }
        
        public void DeleteByKey(int order075ID)
        {
            this.Delete(new Order075() { Order075ID = order075ID });
        }
    }


    public partial class Order076Repository : Repository<Order076>
    {
        public Order076Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order076 GetByKey(int order076ID)
        {
            return this.Query().Where("[Order076ID] = @0", order076ID).GetSingle();  
        }
        
        public void DeleteByKey(int order076ID)
        {
            this.Delete(new Order076() { Order076ID = order076ID });
        }
    }


    public partial class Order077Repository : Repository<Order077>
    {
        public Order077Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order077 GetByKey(int order077ID)
        {
            return this.Query().Where("[Order077ID] = @0", order077ID).GetSingle();  
        }
        
        public void DeleteByKey(int order077ID)
        {
            this.Delete(new Order077() { Order077ID = order077ID });
        }
    }


    public partial class Order078Repository : Repository<Order078>
    {
        public Order078Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order078 GetByKey(int order078ID)
        {
            return this.Query().Where("[Order078ID] = @0", order078ID).GetSingle();  
        }
        
        public void DeleteByKey(int order078ID)
        {
            this.Delete(new Order078() { Order078ID = order078ID });
        }
    }


    public partial class Order079Repository : Repository<Order079>
    {
        public Order079Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order079 GetByKey(int order079ID)
        {
            return this.Query().Where("[Order079ID] = @0", order079ID).GetSingle();  
        }
        
        public void DeleteByKey(int order079ID)
        {
            this.Delete(new Order079() { Order079ID = order079ID });
        }
    }


    public partial class Order080Repository : Repository<Order080>
    {
        public Order080Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order080 GetByKey(int order080ID)
        {
            return this.Query().Where("[Order080ID] = @0", order080ID).GetSingle();  
        }
        
        public void DeleteByKey(int order080ID)
        {
            this.Delete(new Order080() { Order080ID = order080ID });
        }
    }


    public partial class Order081Repository : Repository<Order081>
    {
        public Order081Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order081 GetByKey(int order081ID)
        {
            return this.Query().Where("[Order081ID] = @0", order081ID).GetSingle();  
        }
        
        public void DeleteByKey(int order081ID)
        {
            this.Delete(new Order081() { Order081ID = order081ID });
        }
    }


    public partial class Order082Repository : Repository<Order082>
    {
        public Order082Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order082 GetByKey(int order082ID)
        {
            return this.Query().Where("[Order082ID] = @0", order082ID).GetSingle();  
        }
        
        public void DeleteByKey(int order082ID)
        {
            this.Delete(new Order082() { Order082ID = order082ID });
        }
    }


    public partial class Order083Repository : Repository<Order083>
    {
        public Order083Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order083 GetByKey(int order083ID)
        {
            return this.Query().Where("[Order083ID] = @0", order083ID).GetSingle();  
        }
        
        public void DeleteByKey(int order083ID)
        {
            this.Delete(new Order083() { Order083ID = order083ID });
        }
    }


    public partial class Order084Repository : Repository<Order084>
    {
        public Order084Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order084 GetByKey(int order084ID)
        {
            return this.Query().Where("[Order084ID] = @0", order084ID).GetSingle();  
        }
        
        public void DeleteByKey(int order084ID)
        {
            this.Delete(new Order084() { Order084ID = order084ID });
        }
    }


    public partial class Order085Repository : Repository<Order085>
    {
        public Order085Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order085 GetByKey(int order085ID)
        {
            return this.Query().Where("[Order085ID] = @0", order085ID).GetSingle();  
        }
        
        public void DeleteByKey(int order085ID)
        {
            this.Delete(new Order085() { Order085ID = order085ID });
        }
    }


    public partial class Order086Repository : Repository<Order086>
    {
        public Order086Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order086 GetByKey(int order086ID)
        {
            return this.Query().Where("[Order086ID] = @0", order086ID).GetSingle();  
        }
        
        public void DeleteByKey(int order086ID)
        {
            this.Delete(new Order086() { Order086ID = order086ID });
        }
    }


    public partial class Order087Repository : Repository<Order087>
    {
        public Order087Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order087 GetByKey(int order087ID)
        {
            return this.Query().Where("[Order087ID] = @0", order087ID).GetSingle();  
        }
        
        public void DeleteByKey(int order087ID)
        {
            this.Delete(new Order087() { Order087ID = order087ID });
        }
    }


    public partial class Order088Repository : Repository<Order088>
    {
        public Order088Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order088 GetByKey(int order088ID)
        {
            return this.Query().Where("[Order088ID] = @0", order088ID).GetSingle();  
        }
        
        public void DeleteByKey(int order088ID)
        {
            this.Delete(new Order088() { Order088ID = order088ID });
        }
    }


    public partial class Order089Repository : Repository<Order089>
    {
        public Order089Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order089 GetByKey(int order089ID)
        {
            return this.Query().Where("[Order089ID] = @0", order089ID).GetSingle();  
        }
        
        public void DeleteByKey(int order089ID)
        {
            this.Delete(new Order089() { Order089ID = order089ID });
        }
    }


    public partial class Order090Repository : Repository<Order090>
    {
        public Order090Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order090 GetByKey(int order090ID)
        {
            return this.Query().Where("[Order090ID] = @0", order090ID).GetSingle();  
        }
        
        public void DeleteByKey(int order090ID)
        {
            this.Delete(new Order090() { Order090ID = order090ID });
        }
    }


    public partial class Order091Repository : Repository<Order091>
    {
        public Order091Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order091 GetByKey(int order091ID)
        {
            return this.Query().Where("[Order091ID] = @0", order091ID).GetSingle();  
        }
        
        public void DeleteByKey(int order091ID)
        {
            this.Delete(new Order091() { Order091ID = order091ID });
        }
    }


    public partial class Order092Repository : Repository<Order092>
    {
        public Order092Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order092 GetByKey(int order092ID)
        {
            return this.Query().Where("[Order092ID] = @0", order092ID).GetSingle();  
        }
        
        public void DeleteByKey(int order092ID)
        {
            this.Delete(new Order092() { Order092ID = order092ID });
        }
    }


    public partial class Order093Repository : Repository<Order093>
    {
        public Order093Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order093 GetByKey(int order093ID)
        {
            return this.Query().Where("[Order093ID] = @0", order093ID).GetSingle();  
        }
        
        public void DeleteByKey(int order093ID)
        {
            this.Delete(new Order093() { Order093ID = order093ID });
        }
    }


    public partial class Order094Repository : Repository<Order094>
    {
        public Order094Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order094 GetByKey(int order094ID)
        {
            return this.Query().Where("[Order094ID] = @0", order094ID).GetSingle();  
        }
        
        public void DeleteByKey(int order094ID)
        {
            this.Delete(new Order094() { Order094ID = order094ID });
        }
    }


    public partial class Order095Repository : Repository<Order095>
    {
        public Order095Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order095 GetByKey(int order095ID)
        {
            return this.Query().Where("[Order095ID] = @0", order095ID).GetSingle();  
        }
        
        public void DeleteByKey(int order095ID)
        {
            this.Delete(new Order095() { Order095ID = order095ID });
        }
    }


    public partial class Order096Repository : Repository<Order096>
    {
        public Order096Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order096 GetByKey(int order096ID)
        {
            return this.Query().Where("[Order096ID] = @0", order096ID).GetSingle();  
        }
        
        public void DeleteByKey(int order096ID)
        {
            this.Delete(new Order096() { Order096ID = order096ID });
        }
    }


    public partial class Order097Repository : Repository<Order097>
    {
        public Order097Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order097 GetByKey(int order097ID)
        {
            return this.Query().Where("[Order097ID] = @0", order097ID).GetSingle();  
        }
        
        public void DeleteByKey(int order097ID)
        {
            this.Delete(new Order097() { Order097ID = order097ID });
        }
    }


    public partial class Order098Repository : Repository<Order098>
    {
        public Order098Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order098 GetByKey(int order098ID)
        {
            return this.Query().Where("[Order098ID] = @0", order098ID).GetSingle();  
        }
        
        public void DeleteByKey(int order098ID)
        {
            this.Delete(new Order098() { Order098ID = order098ID });
        }
    }


    public partial class Order099Repository : Repository<Order099>
    {
        public Order099Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order099 GetByKey(int order099ID)
        {
            return this.Query().Where("[Order099ID] = @0", order099ID).GetSingle();  
        }
        
        public void DeleteByKey(int order099ID)
        {
            this.Delete(new Order099() { Order099ID = order099ID });
        }
    }


    public partial class Order100Repository : Repository<Order100>
    {
        public Order100Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public Order100 GetByKey(int order100ID)
        {
            return this.Query().Where("[Order100ID] = @0", order100ID).GetSingle();  
        }
        
        public void DeleteByKey(int order100ID)
        {
            this.Delete(new Order100() { Order100ID = order100ID });
        }
    }


    public partial class OrderLineRepository : Repository<OrderLine>
    {
        public OrderLineRepository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine GetByKey(int orderLineID)
        {
            return this.Query().Where("[OrderLineID] = @0", orderLineID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLineID)
        {
            this.Delete(new OrderLine() { OrderLineID = orderLineID });
        }
    }


    public partial class OrderLine001Repository : Repository<OrderLine001>
    {
        public OrderLine001Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine001 GetByKey(int orderLine001ID)
        {
            return this.Query().Where("[OrderLine001ID] = @0", orderLine001ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine001ID)
        {
            this.Delete(new OrderLine001() { OrderLine001ID = orderLine001ID });
        }
    }


    public partial class OrderLine002Repository : Repository<OrderLine002>
    {
        public OrderLine002Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine002 GetByKey(int orderLine002ID)
        {
            return this.Query().Where("[OrderLine002ID] = @0", orderLine002ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine002ID)
        {
            this.Delete(new OrderLine002() { OrderLine002ID = orderLine002ID });
        }
    }


    public partial class OrderLine003Repository : Repository<OrderLine003>
    {
        public OrderLine003Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine003 GetByKey(int orderLine003ID)
        {
            return this.Query().Where("[OrderLine003ID] = @0", orderLine003ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine003ID)
        {
            this.Delete(new OrderLine003() { OrderLine003ID = orderLine003ID });
        }
    }


    public partial class OrderLine004Repository : Repository<OrderLine004>
    {
        public OrderLine004Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine004 GetByKey(int orderLine004ID)
        {
            return this.Query().Where("[OrderLine004ID] = @0", orderLine004ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine004ID)
        {
            this.Delete(new OrderLine004() { OrderLine004ID = orderLine004ID });
        }
    }


    public partial class OrderLine005Repository : Repository<OrderLine005>
    {
        public OrderLine005Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine005 GetByKey(int orderLine005ID)
        {
            return this.Query().Where("[OrderLine005ID] = @0", orderLine005ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine005ID)
        {
            this.Delete(new OrderLine005() { OrderLine005ID = orderLine005ID });
        }
    }


    public partial class OrderLine006Repository : Repository<OrderLine006>
    {
        public OrderLine006Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine006 GetByKey(int orderLine006ID)
        {
            return this.Query().Where("[OrderLine006ID] = @0", orderLine006ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine006ID)
        {
            this.Delete(new OrderLine006() { OrderLine006ID = orderLine006ID });
        }
    }


    public partial class OrderLine007Repository : Repository<OrderLine007>
    {
        public OrderLine007Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine007 GetByKey(int orderLine007ID)
        {
            return this.Query().Where("[OrderLine007ID] = @0", orderLine007ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine007ID)
        {
            this.Delete(new OrderLine007() { OrderLine007ID = orderLine007ID });
        }
    }


    public partial class OrderLine008Repository : Repository<OrderLine008>
    {
        public OrderLine008Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine008 GetByKey(int orderLine008ID)
        {
            return this.Query().Where("[OrderLine008ID] = @0", orderLine008ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine008ID)
        {
            this.Delete(new OrderLine008() { OrderLine008ID = orderLine008ID });
        }
    }


    public partial class OrderLine009Repository : Repository<OrderLine009>
    {
        public OrderLine009Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine009 GetByKey(int orderLine009ID)
        {
            return this.Query().Where("[OrderLine009ID] = @0", orderLine009ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine009ID)
        {
            this.Delete(new OrderLine009() { OrderLine009ID = orderLine009ID });
        }
    }


    public partial class OrderLine010Repository : Repository<OrderLine010>
    {
        public OrderLine010Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine010 GetByKey(int orderLine010ID)
        {
            return this.Query().Where("[OrderLine010ID] = @0", orderLine010ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine010ID)
        {
            this.Delete(new OrderLine010() { OrderLine010ID = orderLine010ID });
        }
    }


    public partial class OrderLine011Repository : Repository<OrderLine011>
    {
        public OrderLine011Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine011 GetByKey(int orderLine011ID)
        {
            return this.Query().Where("[OrderLine011ID] = @0", orderLine011ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine011ID)
        {
            this.Delete(new OrderLine011() { OrderLine011ID = orderLine011ID });
        }
    }


    public partial class OrderLine012Repository : Repository<OrderLine012>
    {
        public OrderLine012Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine012 GetByKey(int orderLine012ID)
        {
            return this.Query().Where("[OrderLine012ID] = @0", orderLine012ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine012ID)
        {
            this.Delete(new OrderLine012() { OrderLine012ID = orderLine012ID });
        }
    }


    public partial class OrderLine013Repository : Repository<OrderLine013>
    {
        public OrderLine013Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine013 GetByKey(int orderLine013ID)
        {
            return this.Query().Where("[OrderLine013ID] = @0", orderLine013ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine013ID)
        {
            this.Delete(new OrderLine013() { OrderLine013ID = orderLine013ID });
        }
    }


    public partial class OrderLine014Repository : Repository<OrderLine014>
    {
        public OrderLine014Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine014 GetByKey(int orderLine014ID)
        {
            return this.Query().Where("[OrderLine014ID] = @0", orderLine014ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine014ID)
        {
            this.Delete(new OrderLine014() { OrderLine014ID = orderLine014ID });
        }
    }


    public partial class OrderLine015Repository : Repository<OrderLine015>
    {
        public OrderLine015Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine015 GetByKey(int orderLine015ID)
        {
            return this.Query().Where("[OrderLine015ID] = @0", orderLine015ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine015ID)
        {
            this.Delete(new OrderLine015() { OrderLine015ID = orderLine015ID });
        }
    }


    public partial class OrderLine016Repository : Repository<OrderLine016>
    {
        public OrderLine016Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine016 GetByKey(int orderLine016ID)
        {
            return this.Query().Where("[OrderLine016ID] = @0", orderLine016ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine016ID)
        {
            this.Delete(new OrderLine016() { OrderLine016ID = orderLine016ID });
        }
    }


    public partial class OrderLine017Repository : Repository<OrderLine017>
    {
        public OrderLine017Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine017 GetByKey(int orderLine017ID)
        {
            return this.Query().Where("[OrderLine017ID] = @0", orderLine017ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine017ID)
        {
            this.Delete(new OrderLine017() { OrderLine017ID = orderLine017ID });
        }
    }


    public partial class OrderLine018Repository : Repository<OrderLine018>
    {
        public OrderLine018Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine018 GetByKey(int orderLine018ID)
        {
            return this.Query().Where("[OrderLine018ID] = @0", orderLine018ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine018ID)
        {
            this.Delete(new OrderLine018() { OrderLine018ID = orderLine018ID });
        }
    }


    public partial class OrderLine019Repository : Repository<OrderLine019>
    {
        public OrderLine019Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine019 GetByKey(int orderLine019ID)
        {
            return this.Query().Where("[OrderLine019ID] = @0", orderLine019ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine019ID)
        {
            this.Delete(new OrderLine019() { OrderLine019ID = orderLine019ID });
        }
    }


    public partial class OrderLine020Repository : Repository<OrderLine020>
    {
        public OrderLine020Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine020 GetByKey(int orderLine020ID)
        {
            return this.Query().Where("[OrderLine020ID] = @0", orderLine020ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine020ID)
        {
            this.Delete(new OrderLine020() { OrderLine020ID = orderLine020ID });
        }
    }


    public partial class OrderLine021Repository : Repository<OrderLine021>
    {
        public OrderLine021Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine021 GetByKey(int orderLine021ID)
        {
            return this.Query().Where("[OrderLine021ID] = @0", orderLine021ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine021ID)
        {
            this.Delete(new OrderLine021() { OrderLine021ID = orderLine021ID });
        }
    }


    public partial class OrderLine022Repository : Repository<OrderLine022>
    {
        public OrderLine022Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine022 GetByKey(int orderLine022ID)
        {
            return this.Query().Where("[OrderLine022ID] = @0", orderLine022ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine022ID)
        {
            this.Delete(new OrderLine022() { OrderLine022ID = orderLine022ID });
        }
    }


    public partial class OrderLine023Repository : Repository<OrderLine023>
    {
        public OrderLine023Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine023 GetByKey(int orderLine023ID)
        {
            return this.Query().Where("[OrderLine023ID] = @0", orderLine023ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine023ID)
        {
            this.Delete(new OrderLine023() { OrderLine023ID = orderLine023ID });
        }
    }


    public partial class OrderLine024Repository : Repository<OrderLine024>
    {
        public OrderLine024Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine024 GetByKey(int orderLine024ID)
        {
            return this.Query().Where("[OrderLine024ID] = @0", orderLine024ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine024ID)
        {
            this.Delete(new OrderLine024() { OrderLine024ID = orderLine024ID });
        }
    }


    public partial class OrderLine025Repository : Repository<OrderLine025>
    {
        public OrderLine025Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine025 GetByKey(int orderLine025ID)
        {
            return this.Query().Where("[OrderLine025ID] = @0", orderLine025ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine025ID)
        {
            this.Delete(new OrderLine025() { OrderLine025ID = orderLine025ID });
        }
    }


    public partial class OrderLine026Repository : Repository<OrderLine026>
    {
        public OrderLine026Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine026 GetByKey(int orderLine026ID)
        {
            return this.Query().Where("[OrderLine026ID] = @0", orderLine026ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine026ID)
        {
            this.Delete(new OrderLine026() { OrderLine026ID = orderLine026ID });
        }
    }


    public partial class OrderLine027Repository : Repository<OrderLine027>
    {
        public OrderLine027Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine027 GetByKey(int orderLine027ID)
        {
            return this.Query().Where("[OrderLine027ID] = @0", orderLine027ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine027ID)
        {
            this.Delete(new OrderLine027() { OrderLine027ID = orderLine027ID });
        }
    }


    public partial class OrderLine028Repository : Repository<OrderLine028>
    {
        public OrderLine028Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine028 GetByKey(int orderLine028ID)
        {
            return this.Query().Where("[OrderLine028ID] = @0", orderLine028ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine028ID)
        {
            this.Delete(new OrderLine028() { OrderLine028ID = orderLine028ID });
        }
    }


    public partial class OrderLine029Repository : Repository<OrderLine029>
    {
        public OrderLine029Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine029 GetByKey(int orderLine029ID)
        {
            return this.Query().Where("[OrderLine029ID] = @0", orderLine029ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine029ID)
        {
            this.Delete(new OrderLine029() { OrderLine029ID = orderLine029ID });
        }
    }


    public partial class OrderLine030Repository : Repository<OrderLine030>
    {
        public OrderLine030Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine030 GetByKey(int orderLine030ID)
        {
            return this.Query().Where("[OrderLine030ID] = @0", orderLine030ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine030ID)
        {
            this.Delete(new OrderLine030() { OrderLine030ID = orderLine030ID });
        }
    }


    public partial class OrderLine031Repository : Repository<OrderLine031>
    {
        public OrderLine031Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine031 GetByKey(int orderLine031ID)
        {
            return this.Query().Where("[OrderLine031ID] = @0", orderLine031ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine031ID)
        {
            this.Delete(new OrderLine031() { OrderLine031ID = orderLine031ID });
        }
    }


    public partial class OrderLine032Repository : Repository<OrderLine032>
    {
        public OrderLine032Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine032 GetByKey(int orderLine032ID)
        {
            return this.Query().Where("[OrderLine032ID] = @0", orderLine032ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine032ID)
        {
            this.Delete(new OrderLine032() { OrderLine032ID = orderLine032ID });
        }
    }


    public partial class OrderLine033Repository : Repository<OrderLine033>
    {
        public OrderLine033Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine033 GetByKey(int orderLine033ID)
        {
            return this.Query().Where("[OrderLine033ID] = @0", orderLine033ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine033ID)
        {
            this.Delete(new OrderLine033() { OrderLine033ID = orderLine033ID });
        }
    }


    public partial class OrderLine034Repository : Repository<OrderLine034>
    {
        public OrderLine034Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine034 GetByKey(int orderLine034ID)
        {
            return this.Query().Where("[OrderLine034ID] = @0", orderLine034ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine034ID)
        {
            this.Delete(new OrderLine034() { OrderLine034ID = orderLine034ID });
        }
    }


    public partial class OrderLine035Repository : Repository<OrderLine035>
    {
        public OrderLine035Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine035 GetByKey(int orderLine035ID)
        {
            return this.Query().Where("[OrderLine035ID] = @0", orderLine035ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine035ID)
        {
            this.Delete(new OrderLine035() { OrderLine035ID = orderLine035ID });
        }
    }


    public partial class OrderLine036Repository : Repository<OrderLine036>
    {
        public OrderLine036Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine036 GetByKey(int orderLine036ID)
        {
            return this.Query().Where("[OrderLine036ID] = @0", orderLine036ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine036ID)
        {
            this.Delete(new OrderLine036() { OrderLine036ID = orderLine036ID });
        }
    }


    public partial class OrderLine037Repository : Repository<OrderLine037>
    {
        public OrderLine037Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine037 GetByKey(int orderLine037ID)
        {
            return this.Query().Where("[OrderLine037ID] = @0", orderLine037ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine037ID)
        {
            this.Delete(new OrderLine037() { OrderLine037ID = orderLine037ID });
        }
    }


    public partial class OrderLine038Repository : Repository<OrderLine038>
    {
        public OrderLine038Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine038 GetByKey(int orderLine038ID)
        {
            return this.Query().Where("[OrderLine038ID] = @0", orderLine038ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine038ID)
        {
            this.Delete(new OrderLine038() { OrderLine038ID = orderLine038ID });
        }
    }


    public partial class OrderLine039Repository : Repository<OrderLine039>
    {
        public OrderLine039Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine039 GetByKey(int orderLine039ID)
        {
            return this.Query().Where("[OrderLine039ID] = @0", orderLine039ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine039ID)
        {
            this.Delete(new OrderLine039() { OrderLine039ID = orderLine039ID });
        }
    }


    public partial class OrderLine040Repository : Repository<OrderLine040>
    {
        public OrderLine040Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine040 GetByKey(int orderLine040ID)
        {
            return this.Query().Where("[OrderLine040ID] = @0", orderLine040ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine040ID)
        {
            this.Delete(new OrderLine040() { OrderLine040ID = orderLine040ID });
        }
    }


    public partial class OrderLine041Repository : Repository<OrderLine041>
    {
        public OrderLine041Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine041 GetByKey(int orderLine041ID)
        {
            return this.Query().Where("[OrderLine041ID] = @0", orderLine041ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine041ID)
        {
            this.Delete(new OrderLine041() { OrderLine041ID = orderLine041ID });
        }
    }


    public partial class OrderLine042Repository : Repository<OrderLine042>
    {
        public OrderLine042Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine042 GetByKey(int orderLine042ID)
        {
            return this.Query().Where("[OrderLine042ID] = @0", orderLine042ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine042ID)
        {
            this.Delete(new OrderLine042() { OrderLine042ID = orderLine042ID });
        }
    }


    public partial class OrderLine043Repository : Repository<OrderLine043>
    {
        public OrderLine043Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine043 GetByKey(int orderLine043ID)
        {
            return this.Query().Where("[OrderLine043ID] = @0", orderLine043ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine043ID)
        {
            this.Delete(new OrderLine043() { OrderLine043ID = orderLine043ID });
        }
    }


    public partial class OrderLine044Repository : Repository<OrderLine044>
    {
        public OrderLine044Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine044 GetByKey(int orderLine044ID)
        {
            return this.Query().Where("[OrderLine044ID] = @0", orderLine044ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine044ID)
        {
            this.Delete(new OrderLine044() { OrderLine044ID = orderLine044ID });
        }
    }


    public partial class OrderLine045Repository : Repository<OrderLine045>
    {
        public OrderLine045Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine045 GetByKey(int orderLine045ID)
        {
            return this.Query().Where("[OrderLine045ID] = @0", orderLine045ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine045ID)
        {
            this.Delete(new OrderLine045() { OrderLine045ID = orderLine045ID });
        }
    }


    public partial class OrderLine046Repository : Repository<OrderLine046>
    {
        public OrderLine046Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine046 GetByKey(int orderLine046ID)
        {
            return this.Query().Where("[OrderLine046ID] = @0", orderLine046ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine046ID)
        {
            this.Delete(new OrderLine046() { OrderLine046ID = orderLine046ID });
        }
    }


    public partial class OrderLine047Repository : Repository<OrderLine047>
    {
        public OrderLine047Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine047 GetByKey(int orderLine047ID)
        {
            return this.Query().Where("[OrderLine047ID] = @0", orderLine047ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine047ID)
        {
            this.Delete(new OrderLine047() { OrderLine047ID = orderLine047ID });
        }
    }


    public partial class OrderLine048Repository : Repository<OrderLine048>
    {
        public OrderLine048Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine048 GetByKey(int orderLine048ID)
        {
            return this.Query().Where("[OrderLine048ID] = @0", orderLine048ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine048ID)
        {
            this.Delete(new OrderLine048() { OrderLine048ID = orderLine048ID });
        }
    }


    public partial class OrderLine049Repository : Repository<OrderLine049>
    {
        public OrderLine049Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine049 GetByKey(int orderLine049ID)
        {
            return this.Query().Where("[OrderLine049ID] = @0", orderLine049ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine049ID)
        {
            this.Delete(new OrderLine049() { OrderLine049ID = orderLine049ID });
        }
    }


    public partial class OrderLine050Repository : Repository<OrderLine050>
    {
        public OrderLine050Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine050 GetByKey(int orderLine050ID)
        {
            return this.Query().Where("[OrderLine050ID] = @0", orderLine050ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine050ID)
        {
            this.Delete(new OrderLine050() { OrderLine050ID = orderLine050ID });
        }
    }


    public partial class OrderLine051Repository : Repository<OrderLine051>
    {
        public OrderLine051Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine051 GetByKey(int orderLine051ID)
        {
            return this.Query().Where("[OrderLine051ID] = @0", orderLine051ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine051ID)
        {
            this.Delete(new OrderLine051() { OrderLine051ID = orderLine051ID });
        }
    }


    public partial class OrderLine052Repository : Repository<OrderLine052>
    {
        public OrderLine052Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine052 GetByKey(int orderLine052ID)
        {
            return this.Query().Where("[OrderLine052ID] = @0", orderLine052ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine052ID)
        {
            this.Delete(new OrderLine052() { OrderLine052ID = orderLine052ID });
        }
    }


    public partial class OrderLine053Repository : Repository<OrderLine053>
    {
        public OrderLine053Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine053 GetByKey(int orderLine053ID)
        {
            return this.Query().Where("[OrderLine053ID] = @0", orderLine053ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine053ID)
        {
            this.Delete(new OrderLine053() { OrderLine053ID = orderLine053ID });
        }
    }


    public partial class OrderLine054Repository : Repository<OrderLine054>
    {
        public OrderLine054Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine054 GetByKey(int orderLine054ID)
        {
            return this.Query().Where("[OrderLine054ID] = @0", orderLine054ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine054ID)
        {
            this.Delete(new OrderLine054() { OrderLine054ID = orderLine054ID });
        }
    }


    public partial class OrderLine055Repository : Repository<OrderLine055>
    {
        public OrderLine055Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine055 GetByKey(int orderLine055ID)
        {
            return this.Query().Where("[OrderLine055ID] = @0", orderLine055ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine055ID)
        {
            this.Delete(new OrderLine055() { OrderLine055ID = orderLine055ID });
        }
    }


    public partial class OrderLine056Repository : Repository<OrderLine056>
    {
        public OrderLine056Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine056 GetByKey(int orderLine056ID)
        {
            return this.Query().Where("[OrderLine056ID] = @0", orderLine056ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine056ID)
        {
            this.Delete(new OrderLine056() { OrderLine056ID = orderLine056ID });
        }
    }


    public partial class OrderLine057Repository : Repository<OrderLine057>
    {
        public OrderLine057Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine057 GetByKey(int orderLine057ID)
        {
            return this.Query().Where("[OrderLine057ID] = @0", orderLine057ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine057ID)
        {
            this.Delete(new OrderLine057() { OrderLine057ID = orderLine057ID });
        }
    }


    public partial class OrderLine058Repository : Repository<OrderLine058>
    {
        public OrderLine058Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine058 GetByKey(int orderLine058ID)
        {
            return this.Query().Where("[OrderLine058ID] = @0", orderLine058ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine058ID)
        {
            this.Delete(new OrderLine058() { OrderLine058ID = orderLine058ID });
        }
    }


    public partial class OrderLine059Repository : Repository<OrderLine059>
    {
        public OrderLine059Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine059 GetByKey(int orderLine059ID)
        {
            return this.Query().Where("[OrderLine059ID] = @0", orderLine059ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine059ID)
        {
            this.Delete(new OrderLine059() { OrderLine059ID = orderLine059ID });
        }
    }


    public partial class OrderLine060Repository : Repository<OrderLine060>
    {
        public OrderLine060Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine060 GetByKey(int orderLine060ID)
        {
            return this.Query().Where("[OrderLine060ID] = @0", orderLine060ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine060ID)
        {
            this.Delete(new OrderLine060() { OrderLine060ID = orderLine060ID });
        }
    }


    public partial class OrderLine061Repository : Repository<OrderLine061>
    {
        public OrderLine061Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine061 GetByKey(int orderLine061ID)
        {
            return this.Query().Where("[OrderLine061ID] = @0", orderLine061ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine061ID)
        {
            this.Delete(new OrderLine061() { OrderLine061ID = orderLine061ID });
        }
    }


    public partial class OrderLine062Repository : Repository<OrderLine062>
    {
        public OrderLine062Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine062 GetByKey(int orderLine062ID)
        {
            return this.Query().Where("[OrderLine062ID] = @0", orderLine062ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine062ID)
        {
            this.Delete(new OrderLine062() { OrderLine062ID = orderLine062ID });
        }
    }


    public partial class OrderLine063Repository : Repository<OrderLine063>
    {
        public OrderLine063Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine063 GetByKey(int orderLine063ID)
        {
            return this.Query().Where("[OrderLine063ID] = @0", orderLine063ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine063ID)
        {
            this.Delete(new OrderLine063() { OrderLine063ID = orderLine063ID });
        }
    }


    public partial class OrderLine064Repository : Repository<OrderLine064>
    {
        public OrderLine064Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine064 GetByKey(int orderLine064ID)
        {
            return this.Query().Where("[OrderLine064ID] = @0", orderLine064ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine064ID)
        {
            this.Delete(new OrderLine064() { OrderLine064ID = orderLine064ID });
        }
    }


    public partial class OrderLine065Repository : Repository<OrderLine065>
    {
        public OrderLine065Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine065 GetByKey(int orderLine065ID)
        {
            return this.Query().Where("[OrderLine065ID] = @0", orderLine065ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine065ID)
        {
            this.Delete(new OrderLine065() { OrderLine065ID = orderLine065ID });
        }
    }


    public partial class OrderLine066Repository : Repository<OrderLine066>
    {
        public OrderLine066Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine066 GetByKey(int orderLine066ID)
        {
            return this.Query().Where("[OrderLine066ID] = @0", orderLine066ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine066ID)
        {
            this.Delete(new OrderLine066() { OrderLine066ID = orderLine066ID });
        }
    }


    public partial class OrderLine067Repository : Repository<OrderLine067>
    {
        public OrderLine067Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine067 GetByKey(int orderLine067ID)
        {
            return this.Query().Where("[OrderLine067ID] = @0", orderLine067ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine067ID)
        {
            this.Delete(new OrderLine067() { OrderLine067ID = orderLine067ID });
        }
    }


    public partial class OrderLine068Repository : Repository<OrderLine068>
    {
        public OrderLine068Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine068 GetByKey(int orderLine068ID)
        {
            return this.Query().Where("[OrderLine068ID] = @0", orderLine068ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine068ID)
        {
            this.Delete(new OrderLine068() { OrderLine068ID = orderLine068ID });
        }
    }


    public partial class OrderLine069Repository : Repository<OrderLine069>
    {
        public OrderLine069Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine069 GetByKey(int orderLine069ID)
        {
            return this.Query().Where("[OrderLine069ID] = @0", orderLine069ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine069ID)
        {
            this.Delete(new OrderLine069() { OrderLine069ID = orderLine069ID });
        }
    }


    public partial class OrderLine070Repository : Repository<OrderLine070>
    {
        public OrderLine070Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine070 GetByKey(int orderLine070ID)
        {
            return this.Query().Where("[OrderLine070ID] = @0", orderLine070ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine070ID)
        {
            this.Delete(new OrderLine070() { OrderLine070ID = orderLine070ID });
        }
    }


    public partial class OrderLine071Repository : Repository<OrderLine071>
    {
        public OrderLine071Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine071 GetByKey(int orderLine071ID)
        {
            return this.Query().Where("[OrderLine071ID] = @0", orderLine071ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine071ID)
        {
            this.Delete(new OrderLine071() { OrderLine071ID = orderLine071ID });
        }
    }


    public partial class OrderLine072Repository : Repository<OrderLine072>
    {
        public OrderLine072Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine072 GetByKey(int orderLine072ID)
        {
            return this.Query().Where("[OrderLine072ID] = @0", orderLine072ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine072ID)
        {
            this.Delete(new OrderLine072() { OrderLine072ID = orderLine072ID });
        }
    }


    public partial class OrderLine073Repository : Repository<OrderLine073>
    {
        public OrderLine073Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine073 GetByKey(int orderLine073ID)
        {
            return this.Query().Where("[OrderLine073ID] = @0", orderLine073ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine073ID)
        {
            this.Delete(new OrderLine073() { OrderLine073ID = orderLine073ID });
        }
    }


    public partial class OrderLine074Repository : Repository<OrderLine074>
    {
        public OrderLine074Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine074 GetByKey(int orderLine074ID)
        {
            return this.Query().Where("[OrderLine074ID] = @0", orderLine074ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine074ID)
        {
            this.Delete(new OrderLine074() { OrderLine074ID = orderLine074ID });
        }
    }


    public partial class OrderLine075Repository : Repository<OrderLine075>
    {
        public OrderLine075Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine075 GetByKey(int orderLine075ID)
        {
            return this.Query().Where("[OrderLine075ID] = @0", orderLine075ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine075ID)
        {
            this.Delete(new OrderLine075() { OrderLine075ID = orderLine075ID });
        }
    }


    public partial class OrderLine076Repository : Repository<OrderLine076>
    {
        public OrderLine076Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine076 GetByKey(int orderLine076ID)
        {
            return this.Query().Where("[OrderLine076ID] = @0", orderLine076ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine076ID)
        {
            this.Delete(new OrderLine076() { OrderLine076ID = orderLine076ID });
        }
    }


    public partial class OrderLine077Repository : Repository<OrderLine077>
    {
        public OrderLine077Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine077 GetByKey(int orderLine077ID)
        {
            return this.Query().Where("[OrderLine077ID] = @0", orderLine077ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine077ID)
        {
            this.Delete(new OrderLine077() { OrderLine077ID = orderLine077ID });
        }
    }


    public partial class OrderLine078Repository : Repository<OrderLine078>
    {
        public OrderLine078Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine078 GetByKey(int orderLine078ID)
        {
            return this.Query().Where("[OrderLine078ID] = @0", orderLine078ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine078ID)
        {
            this.Delete(new OrderLine078() { OrderLine078ID = orderLine078ID });
        }
    }


    public partial class OrderLine079Repository : Repository<OrderLine079>
    {
        public OrderLine079Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine079 GetByKey(int orderLine079ID)
        {
            return this.Query().Where("[OrderLine079ID] = @0", orderLine079ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine079ID)
        {
            this.Delete(new OrderLine079() { OrderLine079ID = orderLine079ID });
        }
    }


    public partial class OrderLine080Repository : Repository<OrderLine080>
    {
        public OrderLine080Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine080 GetByKey(int orderLine080ID)
        {
            return this.Query().Where("[OrderLine080ID] = @0", orderLine080ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine080ID)
        {
            this.Delete(new OrderLine080() { OrderLine080ID = orderLine080ID });
        }
    }


    public partial class OrderLine081Repository : Repository<OrderLine081>
    {
        public OrderLine081Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine081 GetByKey(int orderLine081ID)
        {
            return this.Query().Where("[OrderLine081ID] = @0", orderLine081ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine081ID)
        {
            this.Delete(new OrderLine081() { OrderLine081ID = orderLine081ID });
        }
    }


    public partial class OrderLine082Repository : Repository<OrderLine082>
    {
        public OrderLine082Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine082 GetByKey(int orderLine082ID)
        {
            return this.Query().Where("[OrderLine082ID] = @0", orderLine082ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine082ID)
        {
            this.Delete(new OrderLine082() { OrderLine082ID = orderLine082ID });
        }
    }


    public partial class OrderLine083Repository : Repository<OrderLine083>
    {
        public OrderLine083Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine083 GetByKey(int orderLine083ID)
        {
            return this.Query().Where("[OrderLine083ID] = @0", orderLine083ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine083ID)
        {
            this.Delete(new OrderLine083() { OrderLine083ID = orderLine083ID });
        }
    }


    public partial class OrderLine084Repository : Repository<OrderLine084>
    {
        public OrderLine084Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine084 GetByKey(int orderLine084ID)
        {
            return this.Query().Where("[OrderLine084ID] = @0", orderLine084ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine084ID)
        {
            this.Delete(new OrderLine084() { OrderLine084ID = orderLine084ID });
        }
    }


    public partial class OrderLine085Repository : Repository<OrderLine085>
    {
        public OrderLine085Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine085 GetByKey(int orderLine085ID)
        {
            return this.Query().Where("[OrderLine085ID] = @0", orderLine085ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine085ID)
        {
            this.Delete(new OrderLine085() { OrderLine085ID = orderLine085ID });
        }
    }


    public partial class OrderLine086Repository : Repository<OrderLine086>
    {
        public OrderLine086Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine086 GetByKey(int orderLine086ID)
        {
            return this.Query().Where("[OrderLine086ID] = @0", orderLine086ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine086ID)
        {
            this.Delete(new OrderLine086() { OrderLine086ID = orderLine086ID });
        }
    }


    public partial class OrderLine087Repository : Repository<OrderLine087>
    {
        public OrderLine087Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine087 GetByKey(int orderLine087ID)
        {
            return this.Query().Where("[OrderLine087ID] = @0", orderLine087ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine087ID)
        {
            this.Delete(new OrderLine087() { OrderLine087ID = orderLine087ID });
        }
    }


    public partial class OrderLine088Repository : Repository<OrderLine088>
    {
        public OrderLine088Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine088 GetByKey(int orderLine088ID)
        {
            return this.Query().Where("[OrderLine088ID] = @0", orderLine088ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine088ID)
        {
            this.Delete(new OrderLine088() { OrderLine088ID = orderLine088ID });
        }
    }


    public partial class OrderLine089Repository : Repository<OrderLine089>
    {
        public OrderLine089Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine089 GetByKey(int orderLine089ID)
        {
            return this.Query().Where("[OrderLine089ID] = @0", orderLine089ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine089ID)
        {
            this.Delete(new OrderLine089() { OrderLine089ID = orderLine089ID });
        }
    }


    public partial class OrderLine090Repository : Repository<OrderLine090>
    {
        public OrderLine090Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine090 GetByKey(int orderLine090ID)
        {
            return this.Query().Where("[OrderLine090ID] = @0", orderLine090ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine090ID)
        {
            this.Delete(new OrderLine090() { OrderLine090ID = orderLine090ID });
        }
    }


    public partial class OrderLine091Repository : Repository<OrderLine091>
    {
        public OrderLine091Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine091 GetByKey(int orderLine091ID)
        {
            return this.Query().Where("[OrderLine091ID] = @0", orderLine091ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine091ID)
        {
            this.Delete(new OrderLine091() { OrderLine091ID = orderLine091ID });
        }
    }


    public partial class OrderLine092Repository : Repository<OrderLine092>
    {
        public OrderLine092Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine092 GetByKey(int orderLine092ID)
        {
            return this.Query().Where("[OrderLine092ID] = @0", orderLine092ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine092ID)
        {
            this.Delete(new OrderLine092() { OrderLine092ID = orderLine092ID });
        }
    }


    public partial class OrderLine093Repository : Repository<OrderLine093>
    {
        public OrderLine093Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine093 GetByKey(int orderLine093ID)
        {
            return this.Query().Where("[OrderLine093ID] = @0", orderLine093ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine093ID)
        {
            this.Delete(new OrderLine093() { OrderLine093ID = orderLine093ID });
        }
    }


    public partial class OrderLine094Repository : Repository<OrderLine094>
    {
        public OrderLine094Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine094 GetByKey(int orderLine094ID)
        {
            return this.Query().Where("[OrderLine094ID] = @0", orderLine094ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine094ID)
        {
            this.Delete(new OrderLine094() { OrderLine094ID = orderLine094ID });
        }
    }


    public partial class OrderLine095Repository : Repository<OrderLine095>
    {
        public OrderLine095Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine095 GetByKey(int orderLine095ID)
        {
            return this.Query().Where("[OrderLine095ID] = @0", orderLine095ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine095ID)
        {
            this.Delete(new OrderLine095() { OrderLine095ID = orderLine095ID });
        }
    }


    public partial class OrderLine096Repository : Repository<OrderLine096>
    {
        public OrderLine096Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine096 GetByKey(int orderLine096ID)
        {
            return this.Query().Where("[OrderLine096ID] = @0", orderLine096ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine096ID)
        {
            this.Delete(new OrderLine096() { OrderLine096ID = orderLine096ID });
        }
    }


    public partial class OrderLine097Repository : Repository<OrderLine097>
    {
        public OrderLine097Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine097 GetByKey(int orderLine097ID)
        {
            return this.Query().Where("[OrderLine097ID] = @0", orderLine097ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine097ID)
        {
            this.Delete(new OrderLine097() { OrderLine097ID = orderLine097ID });
        }
    }


    public partial class OrderLine098Repository : Repository<OrderLine098>
    {
        public OrderLine098Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine098 GetByKey(int orderLine098ID)
        {
            return this.Query().Where("[OrderLine098ID] = @0", orderLine098ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine098ID)
        {
            this.Delete(new OrderLine098() { OrderLine098ID = orderLine098ID });
        }
    }


    public partial class OrderLine099Repository : Repository<OrderLine099>
    {
        public OrderLine099Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine099 GetByKey(int orderLine099ID)
        {
            return this.Query().Where("[OrderLine099ID] = @0", orderLine099ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine099ID)
        {
            this.Delete(new OrderLine099() { OrderLine099ID = orderLine099ID });
        }
    }


    public partial class OrderLine100Repository : Repository<OrderLine100>
    {
        public OrderLine100Repository(InsulaDatabaseContext context)
            : base(context)
        {
        }
        
        public OrderLine100 GetByKey(int orderLine100ID)
        {
            return this.Query().Where("[OrderLine100ID] = @0", orderLine100ID).GetSingle();  
        }
        
        public void DeleteByKey(int orderLine100ID)
        {
            this.Delete(new OrderLine100() { OrderLine100ID = orderLine100ID });
        }
    }


}