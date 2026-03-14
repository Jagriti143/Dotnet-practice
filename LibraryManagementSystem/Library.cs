using System;
namespace LibraryData{
    class Library{
        public int bookID;
        public string bookTitle;
        private Dictionary<int, string> books = new Dictionary<int, string>();
        public string this[int bookID]{
            get{return books[bookID];}
            set{books[bookID]=value;}
        }
       public string this[string bookTitle]{
        get{return books.FirstOrDefault(e => e.Value == bookTitle).Value;}

       }

    }
}