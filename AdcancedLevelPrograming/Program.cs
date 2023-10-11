
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



#endregion

Console.WriteLine();