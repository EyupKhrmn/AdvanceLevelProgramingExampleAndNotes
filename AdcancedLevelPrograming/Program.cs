
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

//string path = @"C:\Users\Eyup\RiderProjects";

//PathControl pathControl = new();

//pathControl.PathControlEvent += () =>
//{
//    Console.WriteLine("Boyut 50MB'ı aştı !!");
//};

//await pathControl.Control(path);

//class PathControl
//{
//    public delegate void PathHandler();
//    public event PathHandler PathControlEvent;

//    public async Task Control(string path)
//    {
//        while (true)
//        {
//            await Task.Delay(1000);
//            DirectoryInfo directoryInfo = new(path);
//            var files = directoryInfo.GetFiles();
//            var size = await Task.Run(() => directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length));
//            var sizeMB = (size / 1024) / 1024;


//            if (sizeMB > 50)
//                PathControlEvent();
//        }
//    }
//}


// İleri seviye programalada eventler genelde microservice uygulamalarında kullanılır.

#endregion
