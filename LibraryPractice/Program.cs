using LibraryPractice;
// Default constructor parametre almadan çalıştırılan kod
Library book1 = new Library();
book1.BookName = "Adı Aylin";
book1.BookPageNum = 398;
book1.Name = "Ayşe";
book1.Surname = "Kulin";
book1.Publisher = "Remzi Kitapevi";
book1.Conclusion();

// Parametre alarak oluşturulan constructor.

Library book2 = new Library("Adı Aylin", 398, "Ayşe", "Kulin", "Remzi Kitapevi");
book2.Conclusion();

// --------------------Bilgilendirme----------------------

// Class = Nesne oluşturma şablonudur.

// Property = Fieldların erişimlerini kontrol etmek için kullanılır ve get, set erişim metotları ile tanımlanır.

// New = Bir sınıftan yeni bir nesne oluşturur.

// Constructor = Yapıcı metotlardır. Bir sınıfın nesnesi oluşturulduğunda çalışan metottur. Sınıfın başlangıç durumunu ayarlamak için kullanılır.
