using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace H5_T1
{
    public class Book
    {
        private string _Title;
        private string _Author;
        private int _Pages;
        public string title
        {
            get {return _Title;}
            set {_Title = value;}
        }
        public string author
        {
            get {return _Author;}
            set {_Author = value;}
        }
        public int pages
        {
            set  {
                if (value < 0)
                _Pages = value;
            }
            get { return _Pages;}
        }
        public Book()
        {
        _Title = "Unknown";
        _Author = "Unknown";
        _Pages = 0;
        }
        public Book(string title, string author, int pages)
        {
            _Title = title;
            _Author = author;
            _Pages = pages;
        }
        public string GetDescription()
        {
            return $"Name: {title}, Author: {author}, Pages: {pages}";
        }
    }
}
