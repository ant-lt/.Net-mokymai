using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P042_Praktika.Models.Concrete;

namespace P042_Praktika.Service
{
    public static class BookHtmlExtension
    {
        public static string ToHtml(this List<BookHtml> books)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var book in books)
            {
                sb.AppendLine($"<tr>");
                sb.AppendLine($"<td>{book.Genre}</td>");
                sb.AppendLine($"<td>{book.Title}</td>");
                sb.AppendLine($"<td>{book.Author}</td>");
                sb.AppendLine($"<td>{book.BooksSold}</td>");
                sb.AppendLine($"<td>{book.Qtty}</td>");
                sb.AppendLine($"<td>{book.EBookPrice}</td>");
                sb.AppendLine($"<td>{book.AudioPrice}</td>");
                sb.AppendLine($"<td>{book.HardcoverPrice}</td>");
                sb.AppendLine($"<td>{book.PaperbackPrice}</td>");
                sb.AppendLine($"</tr>");
            }


            return @"<html>
  <table>
    <thead>
      <tr>
        <th rowspan=""2"">Genre</th>
        <th rowspan=""2"">Title</th>
        <th rowspan=""2"">Author</th>
        <th rowspan=""2"">Books sold</th>
        <th rowspan=""2"">Qtty</th>
        <th colspan=""4"">Price</th>
      </tr>
      <tr>
        <th>E-Eook</th>
        <th>Audio</th>
        <th>Hardcover</th>
        <th>Paperback</th>
      </tr>
    </thead>
    <tbody>" +
    sb.ToString() +
    @"</tbody>
  </table>
</html>";

        }
    }
}
