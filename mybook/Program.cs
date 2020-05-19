using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mybook
{
    class Book
    {
        public string name;
        public string publish_date;
        public string author;
        public string publisher;
        public string publisher_company;
        public string all_edit;
        public string project;
        public string edit;
        public string design;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book() {name="PHP 프로그래밍 입문", publish_date="2013년 5월 20일", author="황재호", publisher="김태헌", publisher_company="한빛아카데미(주)",
                                    all_edit="김현용",project="김이화",edit="김이화",design="여동일"};

            Console.WriteLine("책 이름 : " + book.name);
            Console.WriteLine("초판 발행 : " + book.publish_date);
            Console.WriteLine("지은이 : " + book.author);
            Console.WriteLine("펴낸이 : " + book.publisher);
            Console.WriteLine("펴낸곳 : " + book.publisher_company);
            Console.WriteLine("책임편집 : " + book.all_edit);
            Console.WriteLine("기획 : " + book.project);
            Console.WriteLine("편집 : " + book.edit);
            Console.WriteLine("디자인 : " + book.design);
        }
    }
}
