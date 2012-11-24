using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using OrmBenchmark.EntityFramework.Models.Mapping;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrmBenchmarkContext : DbContext
    {
        static OrmBenchmarkContext()
        {
            Database.SetInitializer<OrmBenchmarkContext>(null);
        }

		public OrmBenchmarkContext()
            : base("Name=OrmBenchmark")
		{
		}

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Customer001> Customer001 { get; set; }
        public DbSet<Customer002> Customer002 { get; set; }
        public DbSet<Customer003> Customer003 { get; set; }
        public DbSet<Customer004> Customer004 { get; set; }
        public DbSet<Customer005> Customer005 { get; set; }
        public DbSet<Customer006> Customer006 { get; set; }
        public DbSet<Customer007> Customer007 { get; set; }
        public DbSet<Customer008> Customer008 { get; set; }
        public DbSet<Customer009> Customer009 { get; set; }
        public DbSet<Customer010> Customer010 { get; set; }
        public DbSet<Customer011> Customer011 { get; set; }
        public DbSet<Customer012> Customer012 { get; set; }
        public DbSet<Customer013> Customer013 { get; set; }
        public DbSet<Customer014> Customer014 { get; set; }
        public DbSet<Customer015> Customer015 { get; set; }
        public DbSet<Customer016> Customer016 { get; set; }
        public DbSet<Customer017> Customer017 { get; set; }
        public DbSet<Customer018> Customer018 { get; set; }
        public DbSet<Customer019> Customer019 { get; set; }
        public DbSet<Customer020> Customer020 { get; set; }
        public DbSet<Customer021> Customer021 { get; set; }
        public DbSet<Customer022> Customer022 { get; set; }
        public DbSet<Customer023> Customer023 { get; set; }
        public DbSet<Customer024> Customer024 { get; set; }
        public DbSet<Customer025> Customer025 { get; set; }
        public DbSet<Customer026> Customer026 { get; set; }
        public DbSet<Customer027> Customer027 { get; set; }
        public DbSet<Customer028> Customer028 { get; set; }
        public DbSet<Customer029> Customer029 { get; set; }
        public DbSet<Customer030> Customer030 { get; set; }
        public DbSet<Customer031> Customer031 { get; set; }
        public DbSet<Customer032> Customer032 { get; set; }
        public DbSet<Customer033> Customer033 { get; set; }
        public DbSet<Customer034> Customer034 { get; set; }
        public DbSet<Customer035> Customer035 { get; set; }
        public DbSet<Customer036> Customer036 { get; set; }
        public DbSet<Customer037> Customer037 { get; set; }
        public DbSet<Customer038> Customer038 { get; set; }
        public DbSet<Customer039> Customer039 { get; set; }
        public DbSet<Customer040> Customer040 { get; set; }
        public DbSet<Customer041> Customer041 { get; set; }
        public DbSet<Customer042> Customer042 { get; set; }
        public DbSet<Customer043> Customer043 { get; set; }
        public DbSet<Customer044> Customer044 { get; set; }
        public DbSet<Customer045> Customer045 { get; set; }
        public DbSet<Customer046> Customer046 { get; set; }
        public DbSet<Customer047> Customer047 { get; set; }
        public DbSet<Customer048> Customer048 { get; set; }
        public DbSet<Customer049> Customer049 { get; set; }
        public DbSet<Customer050> Customer050 { get; set; }
        public DbSet<Customer051> Customer051 { get; set; }
        public DbSet<Customer052> Customer052 { get; set; }
        public DbSet<Customer053> Customer053 { get; set; }
        public DbSet<Customer054> Customer054 { get; set; }
        public DbSet<Customer055> Customer055 { get; set; }
        public DbSet<Customer056> Customer056 { get; set; }
        public DbSet<Customer057> Customer057 { get; set; }
        public DbSet<Customer058> Customer058 { get; set; }
        public DbSet<Customer059> Customer059 { get; set; }
        public DbSet<Customer060> Customer060 { get; set; }
        public DbSet<Customer061> Customer061 { get; set; }
        public DbSet<Customer062> Customer062 { get; set; }
        public DbSet<Customer063> Customer063 { get; set; }
        public DbSet<Customer064> Customer064 { get; set; }
        public DbSet<Customer065> Customer065 { get; set; }
        public DbSet<Customer066> Customer066 { get; set; }
        public DbSet<Customer067> Customer067 { get; set; }
        public DbSet<Customer068> Customer068 { get; set; }
        public DbSet<Customer069> Customer069 { get; set; }
        public DbSet<Customer070> Customer070 { get; set; }
        public DbSet<Customer071> Customer071 { get; set; }
        public DbSet<Customer072> Customer072 { get; set; }
        public DbSet<Customer073> Customer073 { get; set; }
        public DbSet<Customer074> Customer074 { get; set; }
        public DbSet<Customer075> Customer075 { get; set; }
        public DbSet<Customer076> Customer076 { get; set; }
        public DbSet<Customer077> Customer077 { get; set; }
        public DbSet<Customer078> Customer078 { get; set; }
        public DbSet<Customer079> Customer079 { get; set; }
        public DbSet<Customer080> Customer080 { get; set; }
        public DbSet<Customer081> Customer081 { get; set; }
        public DbSet<Customer082> Customer082 { get; set; }
        public DbSet<Customer083> Customer083 { get; set; }
        public DbSet<Customer084> Customer084 { get; set; }
        public DbSet<Customer085> Customer085 { get; set; }
        public DbSet<Customer086> Customer086 { get; set; }
        public DbSet<Customer087> Customer087 { get; set; }
        public DbSet<Customer088> Customer088 { get; set; }
        public DbSet<Customer089> Customer089 { get; set; }
        public DbSet<Customer090> Customer090 { get; set; }
        public DbSet<Customer091> Customer091 { get; set; }
        public DbSet<Customer092> Customer092 { get; set; }
        public DbSet<Customer093> Customer093 { get; set; }
        public DbSet<Customer094> Customer094 { get; set; }
        public DbSet<Customer095> Customer095 { get; set; }
        public DbSet<Customer096> Customer096 { get; set; }
        public DbSet<Customer097> Customer097 { get; set; }
        public DbSet<Customer098> Customer098 { get; set; }
        public DbSet<Customer099> Customer099 { get; set; }
        public DbSet<Customer100> Customer100 { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Item001> Item001 { get; set; }
        public DbSet<Item002> Item002 { get; set; }
        public DbSet<Item003> Item003 { get; set; }
        public DbSet<Item004> Item004 { get; set; }
        public DbSet<Item005> Item005 { get; set; }
        public DbSet<Item006> Item006 { get; set; }
        public DbSet<Item007> Item007 { get; set; }
        public DbSet<Item008> Item008 { get; set; }
        public DbSet<Item009> Item009 { get; set; }
        public DbSet<Item010> Item010 { get; set; }
        public DbSet<Item011> Item011 { get; set; }
        public DbSet<Item012> Item012 { get; set; }
        public DbSet<Item013> Item013 { get; set; }
        public DbSet<Item014> Item014 { get; set; }
        public DbSet<Item015> Item015 { get; set; }
        public DbSet<Item016> Item016 { get; set; }
        public DbSet<Item017> Item017 { get; set; }
        public DbSet<Item018> Item018 { get; set; }
        public DbSet<Item019> Item019 { get; set; }
        public DbSet<Item020> Item020 { get; set; }
        public DbSet<Item021> Item021 { get; set; }
        public DbSet<Item022> Item022 { get; set; }
        public DbSet<Item023> Item023 { get; set; }
        public DbSet<Item024> Item024 { get; set; }
        public DbSet<Item025> Item025 { get; set; }
        public DbSet<Item026> Item026 { get; set; }
        public DbSet<Item027> Item027 { get; set; }
        public DbSet<Item028> Item028 { get; set; }
        public DbSet<Item029> Item029 { get; set; }
        public DbSet<Item030> Item030 { get; set; }
        public DbSet<Item031> Item031 { get; set; }
        public DbSet<Item032> Item032 { get; set; }
        public DbSet<Item033> Item033 { get; set; }
        public DbSet<Item034> Item034 { get; set; }
        public DbSet<Item035> Item035 { get; set; }
        public DbSet<Item036> Item036 { get; set; }
        public DbSet<Item037> Item037 { get; set; }
        public DbSet<Item038> Item038 { get; set; }
        public DbSet<Item039> Item039 { get; set; }
        public DbSet<Item040> Item040 { get; set; }
        public DbSet<Item041> Item041 { get; set; }
        public DbSet<Item042> Item042 { get; set; }
        public DbSet<Item043> Item043 { get; set; }
        public DbSet<Item044> Item044 { get; set; }
        public DbSet<Item045> Item045 { get; set; }
        public DbSet<Item046> Item046 { get; set; }
        public DbSet<Item047> Item047 { get; set; }
        public DbSet<Item048> Item048 { get; set; }
        public DbSet<Item049> Item049 { get; set; }
        public DbSet<Item050> Item050 { get; set; }
        public DbSet<Item051> Item051 { get; set; }
        public DbSet<Item052> Item052 { get; set; }
        public DbSet<Item053> Item053 { get; set; }
        public DbSet<Item054> Item054 { get; set; }
        public DbSet<Item055> Item055 { get; set; }
        public DbSet<Item056> Item056 { get; set; }
        public DbSet<Item057> Item057 { get; set; }
        public DbSet<Item058> Item058 { get; set; }
        public DbSet<Item059> Item059 { get; set; }
        public DbSet<Item060> Item060 { get; set; }
        public DbSet<Item061> Item061 { get; set; }
        public DbSet<Item062> Item062 { get; set; }
        public DbSet<Item063> Item063 { get; set; }
        public DbSet<Item064> Item064 { get; set; }
        public DbSet<Item065> Item065 { get; set; }
        public DbSet<Item066> Item066 { get; set; }
        public DbSet<Item067> Item067 { get; set; }
        public DbSet<Item068> Item068 { get; set; }
        public DbSet<Item069> Item069 { get; set; }
        public DbSet<Item070> Item070 { get; set; }
        public DbSet<Item071> Item071 { get; set; }
        public DbSet<Item072> Item072 { get; set; }
        public DbSet<Item073> Item073 { get; set; }
        public DbSet<Item074> Item074 { get; set; }
        public DbSet<Item075> Item075 { get; set; }
        public DbSet<Item076> Item076 { get; set; }
        public DbSet<Item077> Item077 { get; set; }
        public DbSet<Item078> Item078 { get; set; }
        public DbSet<Item079> Item079 { get; set; }
        public DbSet<Item080> Item080 { get; set; }
        public DbSet<Item081> Item081 { get; set; }
        public DbSet<Item082> Item082 { get; set; }
        public DbSet<Item083> Item083 { get; set; }
        public DbSet<Item084> Item084 { get; set; }
        public DbSet<Item085> Item085 { get; set; }
        public DbSet<Item086> Item086 { get; set; }
        public DbSet<Item087> Item087 { get; set; }
        public DbSet<Item088> Item088 { get; set; }
        public DbSet<Item089> Item089 { get; set; }
        public DbSet<Item090> Item090 { get; set; }
        public DbSet<Item091> Item091 { get; set; }
        public DbSet<Item092> Item092 { get; set; }
        public DbSet<Item093> Item093 { get; set; }
        public DbSet<Item094> Item094 { get; set; }
        public DbSet<Item095> Item095 { get; set; }
        public DbSet<Item096> Item096 { get; set; }
        public DbSet<Item097> Item097 { get; set; }
        public DbSet<Item098> Item098 { get; set; }
        public DbSet<Item099> Item099 { get; set; }
        public DbSet<Item100> Item100 { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order001> Order001 { get; set; }
        public DbSet<Order002> Order002 { get; set; }
        public DbSet<Order003> Order003 { get; set; }
        public DbSet<Order004> Order004 { get; set; }
        public DbSet<Order005> Order005 { get; set; }
        public DbSet<Order006> Order006 { get; set; }
        public DbSet<Order007> Order007 { get; set; }
        public DbSet<Order008> Order008 { get; set; }
        public DbSet<Order009> Order009 { get; set; }
        public DbSet<Order010> Order010 { get; set; }
        public DbSet<Order011> Order011 { get; set; }
        public DbSet<Order012> Order012 { get; set; }
        public DbSet<Order013> Order013 { get; set; }
        public DbSet<Order014> Order014 { get; set; }
        public DbSet<Order015> Order015 { get; set; }
        public DbSet<Order016> Order016 { get; set; }
        public DbSet<Order017> Order017 { get; set; }
        public DbSet<Order018> Order018 { get; set; }
        public DbSet<Order019> Order019 { get; set; }
        public DbSet<Order020> Order020 { get; set; }
        public DbSet<Order021> Order021 { get; set; }
        public DbSet<Order022> Order022 { get; set; }
        public DbSet<Order023> Order023 { get; set; }
        public DbSet<Order024> Order024 { get; set; }
        public DbSet<Order025> Order025 { get; set; }
        public DbSet<Order026> Order026 { get; set; }
        public DbSet<Order027> Order027 { get; set; }
        public DbSet<Order028> Order028 { get; set; }
        public DbSet<Order029> Order029 { get; set; }
        public DbSet<Order030> Order030 { get; set; }
        public DbSet<Order031> Order031 { get; set; }
        public DbSet<Order032> Order032 { get; set; }
        public DbSet<Order033> Order033 { get; set; }
        public DbSet<Order034> Order034 { get; set; }
        public DbSet<Order035> Order035 { get; set; }
        public DbSet<Order036> Order036 { get; set; }
        public DbSet<Order037> Order037 { get; set; }
        public DbSet<Order038> Order038 { get; set; }
        public DbSet<Order039> Order039 { get; set; }
        public DbSet<Order040> Order040 { get; set; }
        public DbSet<Order041> Order041 { get; set; }
        public DbSet<Order042> Order042 { get; set; }
        public DbSet<Order043> Order043 { get; set; }
        public DbSet<Order044> Order044 { get; set; }
        public DbSet<Order045> Order045 { get; set; }
        public DbSet<Order046> Order046 { get; set; }
        public DbSet<Order047> Order047 { get; set; }
        public DbSet<Order048> Order048 { get; set; }
        public DbSet<Order049> Order049 { get; set; }
        public DbSet<Order050> Order050 { get; set; }
        public DbSet<Order051> Order051 { get; set; }
        public DbSet<Order052> Order052 { get; set; }
        public DbSet<Order053> Order053 { get; set; }
        public DbSet<Order054> Order054 { get; set; }
        public DbSet<Order055> Order055 { get; set; }
        public DbSet<Order056> Order056 { get; set; }
        public DbSet<Order057> Order057 { get; set; }
        public DbSet<Order058> Order058 { get; set; }
        public DbSet<Order059> Order059 { get; set; }
        public DbSet<Order060> Order060 { get; set; }
        public DbSet<Order061> Order061 { get; set; }
        public DbSet<Order062> Order062 { get; set; }
        public DbSet<Order063> Order063 { get; set; }
        public DbSet<Order064> Order064 { get; set; }
        public DbSet<Order065> Order065 { get; set; }
        public DbSet<Order066> Order066 { get; set; }
        public DbSet<Order067> Order067 { get; set; }
        public DbSet<Order068> Order068 { get; set; }
        public DbSet<Order069> Order069 { get; set; }
        public DbSet<Order070> Order070 { get; set; }
        public DbSet<Order071> Order071 { get; set; }
        public DbSet<Order072> Order072 { get; set; }
        public DbSet<Order073> Order073 { get; set; }
        public DbSet<Order074> Order074 { get; set; }
        public DbSet<Order075> Order075 { get; set; }
        public DbSet<Order076> Order076 { get; set; }
        public DbSet<Order077> Order077 { get; set; }
        public DbSet<Order078> Order078 { get; set; }
        public DbSet<Order079> Order079 { get; set; }
        public DbSet<Order080> Order080 { get; set; }
        public DbSet<Order081> Order081 { get; set; }
        public DbSet<Order082> Order082 { get; set; }
        public DbSet<Order083> Order083 { get; set; }
        public DbSet<Order084> Order084 { get; set; }
        public DbSet<Order085> Order085 { get; set; }
        public DbSet<Order086> Order086 { get; set; }
        public DbSet<Order087> Order087 { get; set; }
        public DbSet<Order088> Order088 { get; set; }
        public DbSet<Order089> Order089 { get; set; }
        public DbSet<Order090> Order090 { get; set; }
        public DbSet<Order091> Order091 { get; set; }
        public DbSet<Order092> Order092 { get; set; }
        public DbSet<Order093> Order093 { get; set; }
        public DbSet<Order094> Order094 { get; set; }
        public DbSet<Order095> Order095 { get; set; }
        public DbSet<Order096> Order096 { get; set; }
        public DbSet<Order097> Order097 { get; set; }
        public DbSet<Order098> Order098 { get; set; }
        public DbSet<Order099> Order099 { get; set; }
        public DbSet<Order100> Order100 { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<OrderLine001> OrderLine001 { get; set; }
        public DbSet<OrderLine002> OrderLine002 { get; set; }
        public DbSet<OrderLine003> OrderLine003 { get; set; }
        public DbSet<OrderLine004> OrderLine004 { get; set; }
        public DbSet<OrderLine005> OrderLine005 { get; set; }
        public DbSet<OrderLine006> OrderLine006 { get; set; }
        public DbSet<OrderLine007> OrderLine007 { get; set; }
        public DbSet<OrderLine008> OrderLine008 { get; set; }
        public DbSet<OrderLine009> OrderLine009 { get; set; }
        public DbSet<OrderLine010> OrderLine010 { get; set; }
        public DbSet<OrderLine011> OrderLine011 { get; set; }
        public DbSet<OrderLine012> OrderLine012 { get; set; }
        public DbSet<OrderLine013> OrderLine013 { get; set; }
        public DbSet<OrderLine014> OrderLine014 { get; set; }
        public DbSet<OrderLine015> OrderLine015 { get; set; }
        public DbSet<OrderLine016> OrderLine016 { get; set; }
        public DbSet<OrderLine017> OrderLine017 { get; set; }
        public DbSet<OrderLine018> OrderLine018 { get; set; }
        public DbSet<OrderLine019> OrderLine019 { get; set; }
        public DbSet<OrderLine020> OrderLine020 { get; set; }
        public DbSet<OrderLine021> OrderLine021 { get; set; }
        public DbSet<OrderLine022> OrderLine022 { get; set; }
        public DbSet<OrderLine023> OrderLine023 { get; set; }
        public DbSet<OrderLine024> OrderLine024 { get; set; }
        public DbSet<OrderLine025> OrderLine025 { get; set; }
        public DbSet<OrderLine026> OrderLine026 { get; set; }
        public DbSet<OrderLine027> OrderLine027 { get; set; }
        public DbSet<OrderLine028> OrderLine028 { get; set; }
        public DbSet<OrderLine029> OrderLine029 { get; set; }
        public DbSet<OrderLine030> OrderLine030 { get; set; }
        public DbSet<OrderLine031> OrderLine031 { get; set; }
        public DbSet<OrderLine032> OrderLine032 { get; set; }
        public DbSet<OrderLine033> OrderLine033 { get; set; }
        public DbSet<OrderLine034> OrderLine034 { get; set; }
        public DbSet<OrderLine035> OrderLine035 { get; set; }
        public DbSet<OrderLine036> OrderLine036 { get; set; }
        public DbSet<OrderLine037> OrderLine037 { get; set; }
        public DbSet<OrderLine038> OrderLine038 { get; set; }
        public DbSet<OrderLine039> OrderLine039 { get; set; }
        public DbSet<OrderLine040> OrderLine040 { get; set; }
        public DbSet<OrderLine041> OrderLine041 { get; set; }
        public DbSet<OrderLine042> OrderLine042 { get; set; }
        public DbSet<OrderLine043> OrderLine043 { get; set; }
        public DbSet<OrderLine044> OrderLine044 { get; set; }
        public DbSet<OrderLine045> OrderLine045 { get; set; }
        public DbSet<OrderLine046> OrderLine046 { get; set; }
        public DbSet<OrderLine047> OrderLine047 { get; set; }
        public DbSet<OrderLine048> OrderLine048 { get; set; }
        public DbSet<OrderLine049> OrderLine049 { get; set; }
        public DbSet<OrderLine050> OrderLine050 { get; set; }
        public DbSet<OrderLine051> OrderLine051 { get; set; }
        public DbSet<OrderLine052> OrderLine052 { get; set; }
        public DbSet<OrderLine053> OrderLine053 { get; set; }
        public DbSet<OrderLine054> OrderLine054 { get; set; }
        public DbSet<OrderLine055> OrderLine055 { get; set; }
        public DbSet<OrderLine056> OrderLine056 { get; set; }
        public DbSet<OrderLine057> OrderLine057 { get; set; }
        public DbSet<OrderLine058> OrderLine058 { get; set; }
        public DbSet<OrderLine059> OrderLine059 { get; set; }
        public DbSet<OrderLine060> OrderLine060 { get; set; }
        public DbSet<OrderLine061> OrderLine061 { get; set; }
        public DbSet<OrderLine062> OrderLine062 { get; set; }
        public DbSet<OrderLine063> OrderLine063 { get; set; }
        public DbSet<OrderLine064> OrderLine064 { get; set; }
        public DbSet<OrderLine065> OrderLine065 { get; set; }
        public DbSet<OrderLine066> OrderLine066 { get; set; }
        public DbSet<OrderLine067> OrderLine067 { get; set; }
        public DbSet<OrderLine068> OrderLine068 { get; set; }
        public DbSet<OrderLine069> OrderLine069 { get; set; }
        public DbSet<OrderLine070> OrderLine070 { get; set; }
        public DbSet<OrderLine071> OrderLine071 { get; set; }
        public DbSet<OrderLine072> OrderLine072 { get; set; }
        public DbSet<OrderLine073> OrderLine073 { get; set; }
        public DbSet<OrderLine074> OrderLine074 { get; set; }
        public DbSet<OrderLine075> OrderLine075 { get; set; }
        public DbSet<OrderLine076> OrderLine076 { get; set; }
        public DbSet<OrderLine077> OrderLine077 { get; set; }
        public DbSet<OrderLine078> OrderLine078 { get; set; }
        public DbSet<OrderLine079> OrderLine079 { get; set; }
        public DbSet<OrderLine080> OrderLine080 { get; set; }
        public DbSet<OrderLine081> OrderLine081 { get; set; }
        public DbSet<OrderLine082> OrderLine082 { get; set; }
        public DbSet<OrderLine083> OrderLine083 { get; set; }
        public DbSet<OrderLine084> OrderLine084 { get; set; }
        public DbSet<OrderLine085> OrderLine085 { get; set; }
        public DbSet<OrderLine086> OrderLine086 { get; set; }
        public DbSet<OrderLine087> OrderLine087 { get; set; }
        public DbSet<OrderLine088> OrderLine088 { get; set; }
        public DbSet<OrderLine089> OrderLine089 { get; set; }
        public DbSet<OrderLine090> OrderLine090 { get; set; }
        public DbSet<OrderLine091> OrderLine091 { get; set; }
        public DbSet<OrderLine092> OrderLine092 { get; set; }
        public DbSet<OrderLine093> OrderLine093 { get; set; }
        public DbSet<OrderLine094> OrderLine094 { get; set; }
        public DbSet<OrderLine095> OrderLine095 { get; set; }
        public DbSet<OrderLine096> OrderLine096 { get; set; }
        public DbSet<OrderLine097> OrderLine097 { get; set; }
        public DbSet<OrderLine098> OrderLine098 { get; set; }
        public DbSet<OrderLine099> OrderLine099 { get; set; }
        public DbSet<OrderLine100> OrderLine100 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new Customer001Map());
            modelBuilder.Configurations.Add(new Customer002Map());
            modelBuilder.Configurations.Add(new Customer003Map());
            modelBuilder.Configurations.Add(new Customer004Map());
            modelBuilder.Configurations.Add(new Customer005Map());
            modelBuilder.Configurations.Add(new Customer006Map());
            modelBuilder.Configurations.Add(new Customer007Map());
            modelBuilder.Configurations.Add(new Customer008Map());
            modelBuilder.Configurations.Add(new Customer009Map());
            modelBuilder.Configurations.Add(new Customer010Map());
            modelBuilder.Configurations.Add(new Customer011Map());
            modelBuilder.Configurations.Add(new Customer012Map());
            modelBuilder.Configurations.Add(new Customer013Map());
            modelBuilder.Configurations.Add(new Customer014Map());
            modelBuilder.Configurations.Add(new Customer015Map());
            modelBuilder.Configurations.Add(new Customer016Map());
            modelBuilder.Configurations.Add(new Customer017Map());
            modelBuilder.Configurations.Add(new Customer018Map());
            modelBuilder.Configurations.Add(new Customer019Map());
            modelBuilder.Configurations.Add(new Customer020Map());
            modelBuilder.Configurations.Add(new Customer021Map());
            modelBuilder.Configurations.Add(new Customer022Map());
            modelBuilder.Configurations.Add(new Customer023Map());
            modelBuilder.Configurations.Add(new Customer024Map());
            modelBuilder.Configurations.Add(new Customer025Map());
            modelBuilder.Configurations.Add(new Customer026Map());
            modelBuilder.Configurations.Add(new Customer027Map());
            modelBuilder.Configurations.Add(new Customer028Map());
            modelBuilder.Configurations.Add(new Customer029Map());
            modelBuilder.Configurations.Add(new Customer030Map());
            modelBuilder.Configurations.Add(new Customer031Map());
            modelBuilder.Configurations.Add(new Customer032Map());
            modelBuilder.Configurations.Add(new Customer033Map());
            modelBuilder.Configurations.Add(new Customer034Map());
            modelBuilder.Configurations.Add(new Customer035Map());
            modelBuilder.Configurations.Add(new Customer036Map());
            modelBuilder.Configurations.Add(new Customer037Map());
            modelBuilder.Configurations.Add(new Customer038Map());
            modelBuilder.Configurations.Add(new Customer039Map());
            modelBuilder.Configurations.Add(new Customer040Map());
            modelBuilder.Configurations.Add(new Customer041Map());
            modelBuilder.Configurations.Add(new Customer042Map());
            modelBuilder.Configurations.Add(new Customer043Map());
            modelBuilder.Configurations.Add(new Customer044Map());
            modelBuilder.Configurations.Add(new Customer045Map());
            modelBuilder.Configurations.Add(new Customer046Map());
            modelBuilder.Configurations.Add(new Customer047Map());
            modelBuilder.Configurations.Add(new Customer048Map());
            modelBuilder.Configurations.Add(new Customer049Map());
            modelBuilder.Configurations.Add(new Customer050Map());
            modelBuilder.Configurations.Add(new Customer051Map());
            modelBuilder.Configurations.Add(new Customer052Map());
            modelBuilder.Configurations.Add(new Customer053Map());
            modelBuilder.Configurations.Add(new Customer054Map());
            modelBuilder.Configurations.Add(new Customer055Map());
            modelBuilder.Configurations.Add(new Customer056Map());
            modelBuilder.Configurations.Add(new Customer057Map());
            modelBuilder.Configurations.Add(new Customer058Map());
            modelBuilder.Configurations.Add(new Customer059Map());
            modelBuilder.Configurations.Add(new Customer060Map());
            modelBuilder.Configurations.Add(new Customer061Map());
            modelBuilder.Configurations.Add(new Customer062Map());
            modelBuilder.Configurations.Add(new Customer063Map());
            modelBuilder.Configurations.Add(new Customer064Map());
            modelBuilder.Configurations.Add(new Customer065Map());
            modelBuilder.Configurations.Add(new Customer066Map());
            modelBuilder.Configurations.Add(new Customer067Map());
            modelBuilder.Configurations.Add(new Customer068Map());
            modelBuilder.Configurations.Add(new Customer069Map());
            modelBuilder.Configurations.Add(new Customer070Map());
            modelBuilder.Configurations.Add(new Customer071Map());
            modelBuilder.Configurations.Add(new Customer072Map());
            modelBuilder.Configurations.Add(new Customer073Map());
            modelBuilder.Configurations.Add(new Customer074Map());
            modelBuilder.Configurations.Add(new Customer075Map());
            modelBuilder.Configurations.Add(new Customer076Map());
            modelBuilder.Configurations.Add(new Customer077Map());
            modelBuilder.Configurations.Add(new Customer078Map());
            modelBuilder.Configurations.Add(new Customer079Map());
            modelBuilder.Configurations.Add(new Customer080Map());
            modelBuilder.Configurations.Add(new Customer081Map());
            modelBuilder.Configurations.Add(new Customer082Map());
            modelBuilder.Configurations.Add(new Customer083Map());
            modelBuilder.Configurations.Add(new Customer084Map());
            modelBuilder.Configurations.Add(new Customer085Map());
            modelBuilder.Configurations.Add(new Customer086Map());
            modelBuilder.Configurations.Add(new Customer087Map());
            modelBuilder.Configurations.Add(new Customer088Map());
            modelBuilder.Configurations.Add(new Customer089Map());
            modelBuilder.Configurations.Add(new Customer090Map());
            modelBuilder.Configurations.Add(new Customer091Map());
            modelBuilder.Configurations.Add(new Customer092Map());
            modelBuilder.Configurations.Add(new Customer093Map());
            modelBuilder.Configurations.Add(new Customer094Map());
            modelBuilder.Configurations.Add(new Customer095Map());
            modelBuilder.Configurations.Add(new Customer096Map());
            modelBuilder.Configurations.Add(new Customer097Map());
            modelBuilder.Configurations.Add(new Customer098Map());
            modelBuilder.Configurations.Add(new Customer099Map());
            modelBuilder.Configurations.Add(new Customer100Map());
            modelBuilder.Configurations.Add(new ItemMap());
            modelBuilder.Configurations.Add(new Item001Map());
            modelBuilder.Configurations.Add(new Item002Map());
            modelBuilder.Configurations.Add(new Item003Map());
            modelBuilder.Configurations.Add(new Item004Map());
            modelBuilder.Configurations.Add(new Item005Map());
            modelBuilder.Configurations.Add(new Item006Map());
            modelBuilder.Configurations.Add(new Item007Map());
            modelBuilder.Configurations.Add(new Item008Map());
            modelBuilder.Configurations.Add(new Item009Map());
            modelBuilder.Configurations.Add(new Item010Map());
            modelBuilder.Configurations.Add(new Item011Map());
            modelBuilder.Configurations.Add(new Item012Map());
            modelBuilder.Configurations.Add(new Item013Map());
            modelBuilder.Configurations.Add(new Item014Map());
            modelBuilder.Configurations.Add(new Item015Map());
            modelBuilder.Configurations.Add(new Item016Map());
            modelBuilder.Configurations.Add(new Item017Map());
            modelBuilder.Configurations.Add(new Item018Map());
            modelBuilder.Configurations.Add(new Item019Map());
            modelBuilder.Configurations.Add(new Item020Map());
            modelBuilder.Configurations.Add(new Item021Map());
            modelBuilder.Configurations.Add(new Item022Map());
            modelBuilder.Configurations.Add(new Item023Map());
            modelBuilder.Configurations.Add(new Item024Map());
            modelBuilder.Configurations.Add(new Item025Map());
            modelBuilder.Configurations.Add(new Item026Map());
            modelBuilder.Configurations.Add(new Item027Map());
            modelBuilder.Configurations.Add(new Item028Map());
            modelBuilder.Configurations.Add(new Item029Map());
            modelBuilder.Configurations.Add(new Item030Map());
            modelBuilder.Configurations.Add(new Item031Map());
            modelBuilder.Configurations.Add(new Item032Map());
            modelBuilder.Configurations.Add(new Item033Map());
            modelBuilder.Configurations.Add(new Item034Map());
            modelBuilder.Configurations.Add(new Item035Map());
            modelBuilder.Configurations.Add(new Item036Map());
            modelBuilder.Configurations.Add(new Item037Map());
            modelBuilder.Configurations.Add(new Item038Map());
            modelBuilder.Configurations.Add(new Item039Map());
            modelBuilder.Configurations.Add(new Item040Map());
            modelBuilder.Configurations.Add(new Item041Map());
            modelBuilder.Configurations.Add(new Item042Map());
            modelBuilder.Configurations.Add(new Item043Map());
            modelBuilder.Configurations.Add(new Item044Map());
            modelBuilder.Configurations.Add(new Item045Map());
            modelBuilder.Configurations.Add(new Item046Map());
            modelBuilder.Configurations.Add(new Item047Map());
            modelBuilder.Configurations.Add(new Item048Map());
            modelBuilder.Configurations.Add(new Item049Map());
            modelBuilder.Configurations.Add(new Item050Map());
            modelBuilder.Configurations.Add(new Item051Map());
            modelBuilder.Configurations.Add(new Item052Map());
            modelBuilder.Configurations.Add(new Item053Map());
            modelBuilder.Configurations.Add(new Item054Map());
            modelBuilder.Configurations.Add(new Item055Map());
            modelBuilder.Configurations.Add(new Item056Map());
            modelBuilder.Configurations.Add(new Item057Map());
            modelBuilder.Configurations.Add(new Item058Map());
            modelBuilder.Configurations.Add(new Item059Map());
            modelBuilder.Configurations.Add(new Item060Map());
            modelBuilder.Configurations.Add(new Item061Map());
            modelBuilder.Configurations.Add(new Item062Map());
            modelBuilder.Configurations.Add(new Item063Map());
            modelBuilder.Configurations.Add(new Item064Map());
            modelBuilder.Configurations.Add(new Item065Map());
            modelBuilder.Configurations.Add(new Item066Map());
            modelBuilder.Configurations.Add(new Item067Map());
            modelBuilder.Configurations.Add(new Item068Map());
            modelBuilder.Configurations.Add(new Item069Map());
            modelBuilder.Configurations.Add(new Item070Map());
            modelBuilder.Configurations.Add(new Item071Map());
            modelBuilder.Configurations.Add(new Item072Map());
            modelBuilder.Configurations.Add(new Item073Map());
            modelBuilder.Configurations.Add(new Item074Map());
            modelBuilder.Configurations.Add(new Item075Map());
            modelBuilder.Configurations.Add(new Item076Map());
            modelBuilder.Configurations.Add(new Item077Map());
            modelBuilder.Configurations.Add(new Item078Map());
            modelBuilder.Configurations.Add(new Item079Map());
            modelBuilder.Configurations.Add(new Item080Map());
            modelBuilder.Configurations.Add(new Item081Map());
            modelBuilder.Configurations.Add(new Item082Map());
            modelBuilder.Configurations.Add(new Item083Map());
            modelBuilder.Configurations.Add(new Item084Map());
            modelBuilder.Configurations.Add(new Item085Map());
            modelBuilder.Configurations.Add(new Item086Map());
            modelBuilder.Configurations.Add(new Item087Map());
            modelBuilder.Configurations.Add(new Item088Map());
            modelBuilder.Configurations.Add(new Item089Map());
            modelBuilder.Configurations.Add(new Item090Map());
            modelBuilder.Configurations.Add(new Item091Map());
            modelBuilder.Configurations.Add(new Item092Map());
            modelBuilder.Configurations.Add(new Item093Map());
            modelBuilder.Configurations.Add(new Item094Map());
            modelBuilder.Configurations.Add(new Item095Map());
            modelBuilder.Configurations.Add(new Item096Map());
            modelBuilder.Configurations.Add(new Item097Map());
            modelBuilder.Configurations.Add(new Item098Map());
            modelBuilder.Configurations.Add(new Item099Map());
            modelBuilder.Configurations.Add(new Item100Map());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new Order001Map());
            modelBuilder.Configurations.Add(new Order002Map());
            modelBuilder.Configurations.Add(new Order003Map());
            modelBuilder.Configurations.Add(new Order004Map());
            modelBuilder.Configurations.Add(new Order005Map());
            modelBuilder.Configurations.Add(new Order006Map());
            modelBuilder.Configurations.Add(new Order007Map());
            modelBuilder.Configurations.Add(new Order008Map());
            modelBuilder.Configurations.Add(new Order009Map());
            modelBuilder.Configurations.Add(new Order010Map());
            modelBuilder.Configurations.Add(new Order011Map());
            modelBuilder.Configurations.Add(new Order012Map());
            modelBuilder.Configurations.Add(new Order013Map());
            modelBuilder.Configurations.Add(new Order014Map());
            modelBuilder.Configurations.Add(new Order015Map());
            modelBuilder.Configurations.Add(new Order016Map());
            modelBuilder.Configurations.Add(new Order017Map());
            modelBuilder.Configurations.Add(new Order018Map());
            modelBuilder.Configurations.Add(new Order019Map());
            modelBuilder.Configurations.Add(new Order020Map());
            modelBuilder.Configurations.Add(new Order021Map());
            modelBuilder.Configurations.Add(new Order022Map());
            modelBuilder.Configurations.Add(new Order023Map());
            modelBuilder.Configurations.Add(new Order024Map());
            modelBuilder.Configurations.Add(new Order025Map());
            modelBuilder.Configurations.Add(new Order026Map());
            modelBuilder.Configurations.Add(new Order027Map());
            modelBuilder.Configurations.Add(new Order028Map());
            modelBuilder.Configurations.Add(new Order029Map());
            modelBuilder.Configurations.Add(new Order030Map());
            modelBuilder.Configurations.Add(new Order031Map());
            modelBuilder.Configurations.Add(new Order032Map());
            modelBuilder.Configurations.Add(new Order033Map());
            modelBuilder.Configurations.Add(new Order034Map());
            modelBuilder.Configurations.Add(new Order035Map());
            modelBuilder.Configurations.Add(new Order036Map());
            modelBuilder.Configurations.Add(new Order037Map());
            modelBuilder.Configurations.Add(new Order038Map());
            modelBuilder.Configurations.Add(new Order039Map());
            modelBuilder.Configurations.Add(new Order040Map());
            modelBuilder.Configurations.Add(new Order041Map());
            modelBuilder.Configurations.Add(new Order042Map());
            modelBuilder.Configurations.Add(new Order043Map());
            modelBuilder.Configurations.Add(new Order044Map());
            modelBuilder.Configurations.Add(new Order045Map());
            modelBuilder.Configurations.Add(new Order046Map());
            modelBuilder.Configurations.Add(new Order047Map());
            modelBuilder.Configurations.Add(new Order048Map());
            modelBuilder.Configurations.Add(new Order049Map());
            modelBuilder.Configurations.Add(new Order050Map());
            modelBuilder.Configurations.Add(new Order051Map());
            modelBuilder.Configurations.Add(new Order052Map());
            modelBuilder.Configurations.Add(new Order053Map());
            modelBuilder.Configurations.Add(new Order054Map());
            modelBuilder.Configurations.Add(new Order055Map());
            modelBuilder.Configurations.Add(new Order056Map());
            modelBuilder.Configurations.Add(new Order057Map());
            modelBuilder.Configurations.Add(new Order058Map());
            modelBuilder.Configurations.Add(new Order059Map());
            modelBuilder.Configurations.Add(new Order060Map());
            modelBuilder.Configurations.Add(new Order061Map());
            modelBuilder.Configurations.Add(new Order062Map());
            modelBuilder.Configurations.Add(new Order063Map());
            modelBuilder.Configurations.Add(new Order064Map());
            modelBuilder.Configurations.Add(new Order065Map());
            modelBuilder.Configurations.Add(new Order066Map());
            modelBuilder.Configurations.Add(new Order067Map());
            modelBuilder.Configurations.Add(new Order068Map());
            modelBuilder.Configurations.Add(new Order069Map());
            modelBuilder.Configurations.Add(new Order070Map());
            modelBuilder.Configurations.Add(new Order071Map());
            modelBuilder.Configurations.Add(new Order072Map());
            modelBuilder.Configurations.Add(new Order073Map());
            modelBuilder.Configurations.Add(new Order074Map());
            modelBuilder.Configurations.Add(new Order075Map());
            modelBuilder.Configurations.Add(new Order076Map());
            modelBuilder.Configurations.Add(new Order077Map());
            modelBuilder.Configurations.Add(new Order078Map());
            modelBuilder.Configurations.Add(new Order079Map());
            modelBuilder.Configurations.Add(new Order080Map());
            modelBuilder.Configurations.Add(new Order081Map());
            modelBuilder.Configurations.Add(new Order082Map());
            modelBuilder.Configurations.Add(new Order083Map());
            modelBuilder.Configurations.Add(new Order084Map());
            modelBuilder.Configurations.Add(new Order085Map());
            modelBuilder.Configurations.Add(new Order086Map());
            modelBuilder.Configurations.Add(new Order087Map());
            modelBuilder.Configurations.Add(new Order088Map());
            modelBuilder.Configurations.Add(new Order089Map());
            modelBuilder.Configurations.Add(new Order090Map());
            modelBuilder.Configurations.Add(new Order091Map());
            modelBuilder.Configurations.Add(new Order092Map());
            modelBuilder.Configurations.Add(new Order093Map());
            modelBuilder.Configurations.Add(new Order094Map());
            modelBuilder.Configurations.Add(new Order095Map());
            modelBuilder.Configurations.Add(new Order096Map());
            modelBuilder.Configurations.Add(new Order097Map());
            modelBuilder.Configurations.Add(new Order098Map());
            modelBuilder.Configurations.Add(new Order099Map());
            modelBuilder.Configurations.Add(new Order100Map());
            modelBuilder.Configurations.Add(new OrderLineMap());
            modelBuilder.Configurations.Add(new OrderLine001Map());
            modelBuilder.Configurations.Add(new OrderLine002Map());
            modelBuilder.Configurations.Add(new OrderLine003Map());
            modelBuilder.Configurations.Add(new OrderLine004Map());
            modelBuilder.Configurations.Add(new OrderLine005Map());
            modelBuilder.Configurations.Add(new OrderLine006Map());
            modelBuilder.Configurations.Add(new OrderLine007Map());
            modelBuilder.Configurations.Add(new OrderLine008Map());
            modelBuilder.Configurations.Add(new OrderLine009Map());
            modelBuilder.Configurations.Add(new OrderLine010Map());
            modelBuilder.Configurations.Add(new OrderLine011Map());
            modelBuilder.Configurations.Add(new OrderLine012Map());
            modelBuilder.Configurations.Add(new OrderLine013Map());
            modelBuilder.Configurations.Add(new OrderLine014Map());
            modelBuilder.Configurations.Add(new OrderLine015Map());
            modelBuilder.Configurations.Add(new OrderLine016Map());
            modelBuilder.Configurations.Add(new OrderLine017Map());
            modelBuilder.Configurations.Add(new OrderLine018Map());
            modelBuilder.Configurations.Add(new OrderLine019Map());
            modelBuilder.Configurations.Add(new OrderLine020Map());
            modelBuilder.Configurations.Add(new OrderLine021Map());
            modelBuilder.Configurations.Add(new OrderLine022Map());
            modelBuilder.Configurations.Add(new OrderLine023Map());
            modelBuilder.Configurations.Add(new OrderLine024Map());
            modelBuilder.Configurations.Add(new OrderLine025Map());
            modelBuilder.Configurations.Add(new OrderLine026Map());
            modelBuilder.Configurations.Add(new OrderLine027Map());
            modelBuilder.Configurations.Add(new OrderLine028Map());
            modelBuilder.Configurations.Add(new OrderLine029Map());
            modelBuilder.Configurations.Add(new OrderLine030Map());
            modelBuilder.Configurations.Add(new OrderLine031Map());
            modelBuilder.Configurations.Add(new OrderLine032Map());
            modelBuilder.Configurations.Add(new OrderLine033Map());
            modelBuilder.Configurations.Add(new OrderLine034Map());
            modelBuilder.Configurations.Add(new OrderLine035Map());
            modelBuilder.Configurations.Add(new OrderLine036Map());
            modelBuilder.Configurations.Add(new OrderLine037Map());
            modelBuilder.Configurations.Add(new OrderLine038Map());
            modelBuilder.Configurations.Add(new OrderLine039Map());
            modelBuilder.Configurations.Add(new OrderLine040Map());
            modelBuilder.Configurations.Add(new OrderLine041Map());
            modelBuilder.Configurations.Add(new OrderLine042Map());
            modelBuilder.Configurations.Add(new OrderLine043Map());
            modelBuilder.Configurations.Add(new OrderLine044Map());
            modelBuilder.Configurations.Add(new OrderLine045Map());
            modelBuilder.Configurations.Add(new OrderLine046Map());
            modelBuilder.Configurations.Add(new OrderLine047Map());
            modelBuilder.Configurations.Add(new OrderLine048Map());
            modelBuilder.Configurations.Add(new OrderLine049Map());
            modelBuilder.Configurations.Add(new OrderLine050Map());
            modelBuilder.Configurations.Add(new OrderLine051Map());
            modelBuilder.Configurations.Add(new OrderLine052Map());
            modelBuilder.Configurations.Add(new OrderLine053Map());
            modelBuilder.Configurations.Add(new OrderLine054Map());
            modelBuilder.Configurations.Add(new OrderLine055Map());
            modelBuilder.Configurations.Add(new OrderLine056Map());
            modelBuilder.Configurations.Add(new OrderLine057Map());
            modelBuilder.Configurations.Add(new OrderLine058Map());
            modelBuilder.Configurations.Add(new OrderLine059Map());
            modelBuilder.Configurations.Add(new OrderLine060Map());
            modelBuilder.Configurations.Add(new OrderLine061Map());
            modelBuilder.Configurations.Add(new OrderLine062Map());
            modelBuilder.Configurations.Add(new OrderLine063Map());
            modelBuilder.Configurations.Add(new OrderLine064Map());
            modelBuilder.Configurations.Add(new OrderLine065Map());
            modelBuilder.Configurations.Add(new OrderLine066Map());
            modelBuilder.Configurations.Add(new OrderLine067Map());
            modelBuilder.Configurations.Add(new OrderLine068Map());
            modelBuilder.Configurations.Add(new OrderLine069Map());
            modelBuilder.Configurations.Add(new OrderLine070Map());
            modelBuilder.Configurations.Add(new OrderLine071Map());
            modelBuilder.Configurations.Add(new OrderLine072Map());
            modelBuilder.Configurations.Add(new OrderLine073Map());
            modelBuilder.Configurations.Add(new OrderLine074Map());
            modelBuilder.Configurations.Add(new OrderLine075Map());
            modelBuilder.Configurations.Add(new OrderLine076Map());
            modelBuilder.Configurations.Add(new OrderLine077Map());
            modelBuilder.Configurations.Add(new OrderLine078Map());
            modelBuilder.Configurations.Add(new OrderLine079Map());
            modelBuilder.Configurations.Add(new OrderLine080Map());
            modelBuilder.Configurations.Add(new OrderLine081Map());
            modelBuilder.Configurations.Add(new OrderLine082Map());
            modelBuilder.Configurations.Add(new OrderLine083Map());
            modelBuilder.Configurations.Add(new OrderLine084Map());
            modelBuilder.Configurations.Add(new OrderLine085Map());
            modelBuilder.Configurations.Add(new OrderLine086Map());
            modelBuilder.Configurations.Add(new OrderLine087Map());
            modelBuilder.Configurations.Add(new OrderLine088Map());
            modelBuilder.Configurations.Add(new OrderLine089Map());
            modelBuilder.Configurations.Add(new OrderLine090Map());
            modelBuilder.Configurations.Add(new OrderLine091Map());
            modelBuilder.Configurations.Add(new OrderLine092Map());
            modelBuilder.Configurations.Add(new OrderLine093Map());
            modelBuilder.Configurations.Add(new OrderLine094Map());
            modelBuilder.Configurations.Add(new OrderLine095Map());
            modelBuilder.Configurations.Add(new OrderLine096Map());
            modelBuilder.Configurations.Add(new OrderLine097Map());
            modelBuilder.Configurations.Add(new OrderLine098Map());
            modelBuilder.Configurations.Add(new OrderLine099Map());
            modelBuilder.Configurations.Add(new OrderLine100Map());
        }
    }
}
