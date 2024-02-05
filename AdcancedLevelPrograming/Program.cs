
#region OperatorOverloading

// var student = new Student();
// var book = new Book();
//
// var value = student + book;
//
// public class Student
// {
//     public string Name { get; set; }
//     public List<Book> Books { get; set; }
// }
//
// public class Book
// {
//     public string Name { get; set; }
//     public int PageCount { get; set; }
//
//
//     public static Student operator +(Student s, Book b)
//     {
//         s.Books.Add(b);
//         return s;
//     }
// }

#endregion

#region İmplicit/Explicit Operator

//Herhangi iki aynı olmayan sınıf içerisinde birbirine cast işlemini ister gizli(implicit) ister Explicit olacak şekilde tasarlayabiliriz
//Bunu yapmak için ise bahsi geçen iki sınıfın herhangi birinde aşağıda olan methodu tanımlamak yeterli olacaktır.
// b B = new b();
// a A = B;
//
// public class a
// {
//     public static implicit operator a(b B)
//     {
//         return new a();
//     }
// }
//
//
//
// public class b
// {
//     
//}

#endregion

#region Covariance & Contravariance

// Kodda sağ sol kavramının uç noktalarını anlamamızı sağlayan yapılardır. Bunun açıklaması ise kısaca şu şekildedir.
// Covariance => Kodda herhangi bir methodun veya bir sınıfın daha küçük bir sınıf verisi olarak alınmasına denir. 
// Örn => IEnumarable<object> Cars = new List<string>();
// şeklinde bir tanımlama yaparsak hem Ienumarable hem de object Covariance olmuş olur.

// Contravariance ise Convariance'ın birebir tersi olarak anlaşılabilir daha küçük yapıların daha büyük şekilde yazılmasına denir.

// Genelde çok kullanılmaz ama bilinmesinde ve yapılabildiğini bilinmesinde fayda vardır.

// Tür dönüşümlerinde sıkıntılar yaratabilir. object bir diziye strign bir dizi atandığında yine o diziye başka bir türde veriler atanabilir.
// Buda tür dönüşümlerinde sıkıntı olabilir.

// Interface ve class yapılanmalarında bu işlemleri kullanmak için gerekli olan keyword "out" 'dur. 
// Herhangi bir Generic Interface herhangi bir sınıfa implemente ediliyor ise ve bunu daha genel bir türden,
// daha spesifik bir türe doğru yapıyorsa bu işlemi Interface'de Generic yapının out keyword'ü ile işaretlenmesi sonucunda yapabilir.
// Bu işlemler sadece Interface ve Delegate olan yapılarda kullnaılır başka veri yapılarında kullanılamaz.

#endregion

#region Delegate Yapısı

// Delegate'ler herhangi bir methodu çağırdıktan sonra diğer opsiyonel methodu devreye sokmak için kullanılır.
// Kısaca Callback olayını yapmamızı sağlayan bir yapılanmadır. Bunun yanı sıra;

// Event Based Programing
// Fonksiyon Parametreleri
// Dinamik Metot Atamaları

// şeklinde de kullanılabilirler.

// Bir delegate nasıl tanımlanır => public delegate void X(int a, string b);

// Delegate'lerin sonuna handler yazılır, isimlendirme geleneğidir.

// Delegate'ler özünde bir classdır. Herhangi bir methodu delegate ile temsil etmek için delegate'den bir nesne üretmeniz gerekir.

// ÖNEMLİ!!! => Delegate'ler referans türlü yapılardır...
// ÖNEMLİ!!! => Delegate'lere public olsalar bile instance üzerinden erişilemez.

#region Delegate Tanımı
//// Geriye değer döndürmeyen ve Parametre almayan tüm methodları temsil edebilecek Delegate
//public delegate void XHandler();

//// Geriye int ve char tipinde bir tupple döndürecek ve parametre olarak da A türünde ve (string,int) şeklinde bir tupple alan methodları temsil edecek olan Delegate
//public delegate (int, char) YHandler(A a, (string,int) p);

//public class A
//{

//}
#endregion

#region Delegate ile method temsil etme

//XHandler xDelegate = (string a) => a + " Merhaba nasılsın ?";

//string deger = xDelegate.Invoke("Eyüp");

//Console.WriteLine(deger);

//public delegate string XHandler(string a);

// Bunlardan farklı olarak ise dışarıda herhangi bir method var ve delegate ile uyumulu ise direkt onun değerini de verebiliriz,
// istersek direkt new() operatörü ile de kullanabiliriz.

// Eğer delegate'leri kullanmak istersek direkt oluşturulan değerleri üzerinde işlem yapabiliriz. Değerin üzerinden
// Invoke() fonksiyonunun çağırarak ya da çağırmayarak işlemleri yaparız eğer çağırmazsak compiler kendi arka planda Invoke() fonksiyonunun çağırıcaktır.
// Invoke() fonksiyonu kullandığımız delegate'i senkron olarak çalıştırmaya yarar.

// Bir delegate'e birden fazla methodu temsil için verebiliriz bunu sağlamak için += operatörü yeterlidir.

// Delegate'ler Generic olarak yapılandırılabilir.


#endregion



#endregion

#region Event Yapısı

// Herhangi bir olaya tepki vermek için gerekli olan yapılardır. Bu olayların gerçekleştiği veya gerçekleşmediğini izlemeye yarayan,
// ve bunun sonrasında gerekli işlemleri yapmamızı sağlayan yapılardır. Aynı zamanda olayların kayıtlarını tutmamızı da sağlar.

// eventler delegate ile birlikte kullanılmalıdır. 

// Eventlerin türleri delegate'lerdir. Herhangi bir durumun olduğu anda herhangi birşey gerçekleştirmek istersek bunun eventlerin içinde yapabiliriz.


//using System.Xml.Serialization;


//MyEventPublisher publisher = new();
//publisher.MyEvent += () =>
//{
//    Console.WriteLine("Event Tetiklendi");
//};

//publisher.RaiseEvent();

//class MyEventPublisher
//{
//    public delegate void XHandler();
//    public event XHandler MyEvent;

//    public void RaiseEvent()
//    {

//         event fırlatılmış oldu...
//        MyEvent();
//}
//}

// Herhangi bir evente yeni bir delegate eklemek için += operatörünü kullanırız aynı zamanda herhangi bir methodu çıkarmak istersek de -= kullanmamız yeterlidir.
// Bu yapı Winform uygulamalarının arka kısmında işleyen yapı ile aynı yapıdadır.

#endregion

#region Delegate ve Event Örnek

// Belirli bir dizinde boyut  5MB' ı geçtiği takdirde uyaran bir olay(event) oluşturalım.

// string path = @"C:\Users\Eyup\RiderProjects";
//
// PathControl pathControl = new();
//
// pathControl.PathControlEvent += () =>
// {
//     Console.WriteLine("Boyut 50MB'ı aştı !!");
// };
//
// await pathControl.Control(path);
//
// class PathControl
// {
//     public delegate void PathHandler();
//     public event PathHandler PathControlEvent;
//
//     public async Task Control(string path)
//     {
//         while (true)
//         {
//             await Task.Delay(1000);
//             DirectoryInfo directoryInfo = new(path);
//             var files = directoryInfo.GetFiles();
//             var size = await Task.Run(() => directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length));
//             var sizeMB = (size / 1024) / 1024;
//
//
//             if (sizeMB > 50)
//                 PathControlEvent();
//         }
//     }
// }

// İleri seviye programalada eventler genelde microservice uygulamalarında kullanılır.

#endregion

#region Önceden Tanımlanmış Delegate Türleri

// Action => geriye değer dödürmeyen tüm methodları temsil eden delegate'dir. Parametre ya almaz ya da istediği kadar alır. Generic türü vardır.
// ÖRN => Action deneme = () => {}

// Action deneme = () => Console.WriteLine("Action");


// Func => Kesinlikle generic yapıdadır. Eğer birden fazla parametere alırsa son aldığı parametre türünde geriye değer döndürür.
// Generic olarak aldığı parametre türünde kesinlikle geriye değer döndürmelidir.
// ÖRN => Func<XClass> deneme = () => new();

// Func<string> deneme = () => "Func";


// Predicate => Generic olan ve Generic parametredeki türden parametre alan, geriye boolean türden veri dönen methodları temsi eden delegate'dir.
// ÖRN => Predicate<int> predicate = i => true;

#endregion

#region Anonymous Structures

#region Anonymous Objects

// Person nesensi herhangi bir alanda yalnızca bir kere kullanılacağı zaman (Person nesnesi üzerinde değil herhangi bir tip sınıfa tek seferlik
// ihtiyacımız var ise) kullanılması mantıklı olan yapılardır.

// var person = new
// {
//     Name = "Eyup",
//     Surname = "Kahraman"
// };

// Anonymous Objects'lerde prop'lar yalnızca readonly olarak ayarlanır herhangi bir manipülasyon yapılamaz yalnızca get işlemi yapılabilir.
#endregion

#region Anonymous Methods


// Delegate İle belirli bir methodu kullanma yani Anonymous değil.
// Topla topla = new Topla(Toplama);
//
// int Toplama(int a, int b)
// {
//     return a + b;
// }
// delegate int Topla(int a, int b);

// Delegate İle belirsiz bir methodu kullanma yani Anonymous.
// Topla topla = (a,b) => a + b;

// Anonymous methodları illa delegate ile kullanmak zorunda değiliz var keywordu ile de kullanabiliriz.
// var deneme = (int a,int b) => a + b;

#endregion

#region Anonymous Collection

// // Array
// using Microsoft.VisualBasic;
//
// var x = new[] { 3, 5 };
//
// // Collection
// var y = new Collection()
// {
//     new { a = 3 },
//     new { b = "Hello" }
// };

#endregion


#endregion

#region Expando Objects

//dynamic expandoObject = new ExpandoObject();

//expandoObject.Name = "Eyup";
//expandoObject.Surname = "Kahraman";
//expandoObject.City = "Istanbul";
//expandoObject.Age = 61;

// Şeklinde kullanılan yapılardır. Gerekli cevap verme işlemlerinde hazır bir yapı kullanmaktansa o an istenen verileri dönmeye yarayan bir yapıdır.

#endregion

#region Access Modifiers

// public
// private
// protected
// internal
// protected internal
// private protected

// şeklinde 6 tane erişim belirleyici vardır

#endregion

#region Özel Tanımlı Interfaceler

#region IComparer

//Person p1 = new() { Name = "Eyup", Age = 21 };
//Person p2 = new() { Name = "Kahraman", Age = 21 };
//
//public class AgeComparer : IComparer<Person>
//{
//    public int Compare(Person x, Person y)
//    {
//        if (ReferenceEquals(x, y)) return 0;
//        if (ReferenceEquals(null, y)) return 1;
//        if (ReferenceEquals(null, x)) return -1;
//        var nameComparison = string.Compare(x.Name, y.Name, StringComparison.Ordinal);
//        if (nameComparison != 0) return nameComparison;
//        
//        //Basit Şekilde Comparer etmek istersen aşağıdaki gibi yapabilirsin.
//        //Eğer değerler eşit ise sıfır döndürür. İlk değer büyük ise 1, ikinci değer büyük ise -1 döndürür.
//        return x.Age.CompareTo(y.Age);
//    }
//}

#endregion

#region IComparable

//IComparable interface'i ile bir nesneyi karşılaştırabiliriz. Bu interface'i kullanmak için IComparable<T> şeklinde bir yapılandırma yapmamız gerekir.
// Bu yapılandırma yapılırken T yerine karşılaştırılacak olan nesnenin türü yazılır. Bu interface'i kullanmak için CompareTo() methodunu kullanmamız gerekir.
// Bu İnterface'i sınıfın kendisine vermemiz gerekir generic olan parametresi ise kendi türünden olmalıdır.

//Person p1 = new() { Name = "Eyup", Age = 21 };
//Person p2 = new() { Name = "Kahraman", Age = 21 };
//
//var result = p1.CompareTo(p2);
//
#endregion

#region IClonable

//Örnek vermek gerekirse bir nesneyi kopyalamak istediğimizde kullanabiliriz. Özellikle Üretilecek olan nesnelerin Ctor'larında çok fazla parametre var ise
// ve bu parametrelerin hepsini tekrar tekrar yazmak istemiyorsak bu interface'i kullanabiliriz.


//public class Person : ICloneable şeklinde İstenilen class'a implemente edilir. gelen method kopyalama işlemini yapar
 
//Person p1 = new (){Name = "Eyup",Age = 21};
//Person p2 = (Person) p1.Clone();

#endregion

#region INotifyPropertyChanged

using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

//Person p1 = new() { Name = "Eyup", Age = 21 };

// INotifyPropertyChanged interface'i ile bir nesnenin property'si değiştiğinde bunu izleyebiliriz.
// Bu interface'i kullanmak için PropertyChangedEventHandler adında bir event tanımlamamız gerekir. Bu event ilgili interfae'i implemente ettiğimizde kendi içerisinde tanımlanır.
// Bu event'i kullanmak için ise PropertyChanged adında bir method tanımlamamız gerekir. Bu method ise PropertyChangedEventHandler adında bir parametre alır.
// Bu parametre ise PropertyChangedEventHandler adında bir delegate'dir. Bu delegate ise object ve PropertyChangedEventArgs adında iki parametre alır.
// Bu parametrelerden object olanı PropertyChangedEventHandler'ın sahibi olan nesnedir. PropertyChangedEventArgs ise değişen property'nin adını tutar.
// KUllanımı ise aşağıdaki gibidir.
//p1.PropertyChanged += (sender, args) =>
//{
//    Console.WriteLine(args.PropertyName);
//};

//yapılan bu işlemler ilgili class'ın içerisindeki prop'un get ve set'lerinin içerisinde yapılmalıdır.
//set methodunun içerisinde yapılması doğru olacaktır.
#endregion

#region IEnumarable

//Bir nesenenin üzerinden foreach döngüsü ile dolaşmak istediğimizde kullanabiliriz. 
// aslında forech döngüsü ile dolaşmak istediğimiz nesnenin içerisinde GetEnumerator() methodu olması yeterlidir.
// IEnumarable ile IQueryable arasındaki fark ise IQueryable'in veritabanı sorgularına daha ulaşmamış olması, IEnumrable ise veritabanı sorgularına ulaşmış olması 
// ve bellekte sorgulanabilir olarak tutulmasıdır. Bu sayede implemente edilen nesnelerin üzerinden ef core sorgularına benzer sorgular yapılabilir.


#endregion

#region IDesposable

// verilerin veya implemente edildiği class'ın bellekten silinmebilecek haline gelmesini sağlar. Tüm değerlerini null olarak ayarlar
// ve garbage collector tarafından silinmesini sağlar. 

#endregion

//public class Person : ICloneable, IComparable<Person> , INotifyPropertyChanged, IEnumerable, IDisposable
//{
//    public string Name { get; set; }
//
//    //INotifyPropertyChanged interface'i ile bir nesnenin property'si değiştiğinde bunu izleyebiliriz.
//    private int age;
//    public int Age
//    {
//        get
//        {
//            return age;
//        }
//        set
//        {
//            age = value;
//            PropertyChanged(this, new(nameof(age)));
//        }
//    }
//
//    //IComparable interface'i ile bir nesneyi karşılaştırabiliriz. 
//    public int CompareTo(Person? other)
//    {
//        if (ReferenceEquals(this, other)) return 0;
//        if (ReferenceEquals(null, other)) return 1;
//        var nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
//        if (nameComparison != 0) return nameComparison;
//        
//        //Basit Şekilde Comparer etmek istersen aşağıdaki gibi yapabilirsin.
//        return Age.CompareTo(other.Age);
//    }
//
//    //IClonable interface'i ile bir nesneyi kopyalamak istediğimizde kullanabiliriz.
//    public object Clone()
//    {
//        return this.MemberwiseClone();
//    }
//
//    public event PropertyChangedEventHandler? PropertyChanged;
//    
//    //IEnumarable interface'i ile bir nesnenin üzerinden foreach döngüsü ile dolaşmak istediğimizde kullanabiliriz.
//    public IEnumerator GetEnumerator()
//    {
//        throw new NotImplementedException();
//    }
//
//    
//    //IDisposable interface'i ile bir nesnenin bellekten silinmesini sağlar.
//    public void Dispose()
//    {
//        // gereken işlemler yapılır.
//    }
//}


#endregion

#region yield return

// yield return => bir methodun içerisinde birden fazla return ifadesi kullanmak istediğimizde kullanırız.
// yield return => methodun içerisindeki return ifadesinden sonra methodun çalışması durur ve methodun çağırıldığı yere değer döndürür.

//IEnumerable<string> Deneme()
//{
//    yield return "deneme";
//    yield return "Deneme2";
//    yield return "Deneme3";
//}

#endregion

#region Attribute Yapısı

// Attribute kavramı sınflara veya methodlara özel bir yapı eklemek için geliştirilen bir yapıdır.
// Bu yapılar genelde bir methodun veya sınıfın çalışma zamanında nasıl çalışacağını belirlemek için kullanılır.
// Custım attribute oluşturulabilir.

//[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
//class MyAttribute : Attribute
//{
//    public string stringValue { get; set; }
//    public int RETURN()
//    {
//        return 61;
//    }
//}
//
//
//[My]
//public class Trying
//{
//    
//}

//attribute kullanmak için ismindeki attribute alanını yazmaya gerek yoktur. Controller gibi.

//herhangi bir sınıfı veya methodu verilen attribute değeri ile elde etmek için yani attribute'üne göre sıralamak için
// Reflection kullanılır. Bunun için assambly seviyesinde sorgular yapılır 
// o anki güncel assambly'nin tüm bilgilerine ulaşmak için aşağıdaki işlem yapılır.

//Assembly assembly = Assembly.GetExecutingAssembly();
//assembly.GetTypes()
//    .Where(_=>_.GetCustomAttribute<MyAttribute>() is not null)
//    .ToList();

//şeklinde myattribute'ü olan tüm sınıfları getirir.

#endregion

#region Reflection

//reflection herhangi bir türlere ve bu türlerin verilerine erişmek için kullanılır.
//reflection yöntemi ile o anki çalışan tüm türlerin değerlerine ve hangi türde olduklarına o an dinamilk olarak erişebiliriz.
//bu sayede o anki değerleri okuyabilir ve üzerinden işlem yapabiliriz.
//Aynı zamanda erişilen sınıfların veya herhangi bir türün içerisindeki private olan method, field veya prop'lara hatta o anki değerlerine bile erişebiliriz.


//başka bir projeninde reflection'una o an arişebiliriz. Bunun için o projenin dll dosyasını projeye eklememiz yeterlidir. yani referans vermemiz gerekiyor.

//Assembly assembly = Assembly.GetExecutingAssembly(); // o an ki reflection'a ulaşmak.

//Assembly assembly1 = Assembly.Load(nameof("diğer projenin adı")); // başka bir projenin reflection'ına ulaşmak.


//typeof();  //methodu da aslında bir reflection methodudur. o anki türün reflection'ına ulaşmak için kullanılır.


// herhangi bir değerin içindeki prop'ları methodları veya memberları manipüle etmek istersek şöyle bir yapı kullanabiliriz:

var myclass = new MyClass();

Type type = typeof(MyClass);

var prop = type.GetProperty(nameof(MyClass.Deneme));

prop.SetValue(myclass, 61);

// bu sayede değeri manipüle etmiş oluruz.

//reflection ile bir methodu çalıştırmak istersek aşağıdaki gibi bir yapı kullanabiliriz.

var method = type.GetMethod(nameof(MyClass.DenemeMethod));
method.Invoke(myclass, null); //Bu şekilde methodu çalıştırmış oluruz. Eğer method parametre alıyorsa null yerine object dizisi ile parametereleri
//gödermemiz gerekir.

var method1 = type.GetMethod(nameof(MyClass.DenemeParameterMethod));
method1.Invoke(myclass, new object[] { 61 });
//şeklinde parametreleri veririz.


//bir tipin içerisindeki private verilere de erişim sağlayabiliriz. Bunun için aşağıdaki gibi bir yapı kullanabiliriz.

var members = type.GetMembers(BindingFlags.NonPublic | BindingFlags.Instance);

members.ToList().ForEach(_=> Console.WriteLine(_.Name)); // şeklinde sınıf veya herhangi bir tür üzerinde private olan verilere dahi ulaşmış oluruz.

public class MyClass
{
    public int Deneme { get; set; }
    
    public void DenemeMethod()
    {
        Console.WriteLine("Deneme");
    }
    
    public void DenemeParameterMethod(int a)
    {
        Console.WriteLine(a);
    }
}




#endregion