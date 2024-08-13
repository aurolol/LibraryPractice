using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPractice
{
    public class Library
    {

        //Burada default constructor parametre almadan çalıştırılan kod yazıyoruz.
        public string _bookName;
        public int _bookPageNum;
        public string _name;
        public string _surname;
        public string _publisher;
        public DateTime _registrationDate;

        public string BookName
        {
            get
            {
                return _bookName;
            }
            set
            {
                _bookName = value;
            }
        }
        public int BookPageNum
        {
            get
            {
                return _bookPageNum;
            }
            set
            {
                _bookPageNum = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        public string Publisher
        {
            get
            {
                return _publisher;
            }
            set
            {
                _publisher = value;
            }
        }
        public DateTime RegistrationDate
        {
            get
            {
                return _registrationDate;
            }
            set
            {
                _registrationDate = value;
            }
        }

        // Burada ise parametre vererek oluşturulan bir constructor oluşturuyoruz.

        public Library(string bookName, int bookPageNum, string name, string surname, string publisher)
        {
            _bookName = bookName;
            _bookPageNum = bookPageNum;
            _name = name;
            _surname = surname;
            _publisher = publisher;
        }
        public void Conclusion()
        {
            _registrationDate = DateTime.Now;
            Console.WriteLine($"{_name} {_surname}'in {_bookPageNum} sayfalık, {_publisher} yayınevinden çıkan {_bookName} kitabıdır.\nKayıt Tarihi: {_registrationDate}");
        }
    }
    
}








   



