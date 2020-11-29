using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Book
    {
        public Author author;
        public Title title;
        public Content content;
        public void addauthor()
        {
            author = new Author();
            author.aut = "sddas";
            author.show();
        }
        public void addtitle()
        {

            title = new Title();
            title.tit = "sddas";
            title.show();
        }
        public void addcontent()
        {   content = new Content();
            content.con="sdafasdf";
            content.show();
           
        }


    }
}
