using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P042_Praktika.InitialData
{
    public static class BookInitialData
    {
        public static readonly string DataSeedHtml =
   @"
<html>
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
    <tbody>
      <tr>
        <td>Historical fiction</td>
        <td>A Tale Of Two Cities</td>
        <td>Charles Dickens</td>
        <td>200 million</td>
        <td>20</td>
        <td>0 EUR</td>
        <td>20.97 EUR</td>
        <td>11.99 EUR</td>
        <td>6.81 EUR</td>
      </tr>
      <tr>
        <td>Adventure</td>
        <td>The Little Prince</td>
        <td>Antoine de Saint-Exupery</td>
        <td>0.2 billion</td>
        <td>16</td>
        <td>-</td>
        <td>$0</td>
        <td>$13.99</td>
        <td>$4.99</td>
      </tr>
      <tr>
        <td>Fantasy</td>
        <td>Harry Potter and the Philosopher's Stone</td>
        <td>JK Rowling</td>
        <td>12 million</td>
        <td>-</td>
        <td>0 PLN</td>
        <td>0 PLN</td>
        <td>188.22 PLN</td>
        <td>34.51 PLN</td>
      </tr>
      <tr>
        <td>Mystery</td>
        <td>And Then There Were None</td>
        <td>Agatha Christie</td>
        <td>10 million</td>
        <td>1</td>
        <td>-</td>
        <td>$0</td>
        <td>$13.99</td>
        <td>-</td>
      </tr>
      <tr>
        <td>Classics</td>
        <td>Dream Of The Red Chamber</td>
        <td>Cao Xueqin</td>
        <td>100000</td>
        <td>12</td>
        <td>13.36 EUR</td>
        <td>-</td>
        <td>20.57 EUR</td>
        <td>193.04 EUR</td>
      </tr>
      <tr>
        <td>Fantasy</td>
        <td>The Hobbit</td>
        <td>JRR Tolkien</td>
        <td>100000</td>
        <td>20</td>
        <td>-</td>
        <td>$0</td>
        <td>$13.99</td>
        <td>$4.99</td>
      </tr>
      <tr>
        <td>Fantasy</td>
        <td>The Lion, the Witch and the Wardrobe</td>
        <td>CS Lewis</td>
        <td>85000</td>
        <td>20</td>
        <td>-</td>
        <td>$0</td>
        <td>$13.99</td>
        <td>$4.99</td>
      </tr>
      <tr>
        <td>Adventure</td>
        <td>She: A History of Adventure</td>
        <td>H. Rider Haggard</td>
        <td>83 million</td>
        <td>20</td>
        <td>-</td>
        <td>$0</td>
        <td>$13.99</td>
        <td>$4.99</td>
      </tr>
      <tr>
        <td>Mystery</td>
        <td>The Da Vinci Code</td>
        <td>Dan Brown</td>
        <td>80 million</td>
        <td>0</td>
        <td>-</td>
        <td>$0</td>
        <td>$13.99</td>
        <td>$4.99</td>
      </tr>
      <tr>
        <td>Fantasy</td>
        <td>Harry Potter and the Chamber of Secrets</td>
        <td>JK Rowling</td>
        <td>77 million</td>
        <td>35</td>
        <td>$3.99</td>
        <td>$0</td>
        <td>$33.99</td>
        <td>-</td>
      </tr>
    </tbody>
  </table>
</html>
";
    }
}
