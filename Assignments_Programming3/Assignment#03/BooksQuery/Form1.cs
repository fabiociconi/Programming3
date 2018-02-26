using BooksModel;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BooksQuery
{
    public partial class Form1 : Form
    {
        private BooksEntities dbcontext = new BooksEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBoxResult.Text = "";
                    textBoxResult.AppendText("1.Get a list of all the titles and the authors who wrote them: ");

                    var titlesAuthors = from book in dbcontext.Titles
                                        from author in dbcontext.Authors
                                        orderby book.Title
                                        select new
                                        {
                                            book.Title,
                                            author.FirstName,
                                            author.LastName,
                                            book.ISBN,
                                            book.Copyright,
                                            book.EditionNumber
                                        };
                    foreach (var item in titlesAuthors)
                    {
                        textBoxResult.AppendText($"\r\n\t{item.Title,-50}" + $"{item.FirstName,-10}"
                            + $"{item.LastName,-10}" + $"{item.ISBN,-12}" + $"{item.Copyright,-10}");

                    }
                    break;

                case 1:
                    textBoxResult.Text = "";
                    textBoxResult.AppendText("2. Sort the results by title.  Each title sort the authors alphabetically by last name, then first name ");

                    var titlesAuthorsAlpha = from book in dbcontext.Titles
                                             from author in dbcontext.Authors
                                             orderby book.Title, author.LastName, author.FirstName
                                             select new
                                             {
                                                 book.Title,
                                                 author.FirstName,
                                                 author.LastName,
                                                 book.ISBN,
                                                 book.Copyright,
                                                 book.EditionNumber
                                             };
                    foreach (var item in titlesAuthorsAlpha)
                    {
                        textBoxResult.AppendText($"\r\n\t{item.Title,-50}" + $"{item.FirstName,-10}"
                            + $"{item.LastName,-10}" + $"{item.ISBN,-12}" + $"{item.Copyright,-10}");

                    }
                    break;

                case 2:
                    textBoxResult.Text = "";
                    textBoxResult.AppendText("3. Get a list of all the authors grouped by title, ");

                    var titlesAuthorsGroup =
                                              from author in dbcontext.Authors
                                              orderby author.LastName, author.FirstName
                                              //group new { book } by new { book.Title } into gr

                                              select new
                                              {
                                                  author.LastName,
                                                  author.FirstName,
                                                  bookTitle = from book in author.Titles
                                                              orderby book.Title
                                                              select book.Title
                                              };

                    foreach (var item in titlesAuthorsGroup)

                    {
                        textBoxResult.AppendText($"\r\n{item.LastName,-30}" + $"{item.FirstName,-30}");


                        foreach (var item2 in item.bookTitle)
                        {
                            textBoxResult.AppendText($"\r\n\t" + item2);


                        }
                    }

                    break;
            }
        }
    }
}
