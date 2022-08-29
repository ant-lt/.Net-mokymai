using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P042_Abstract
{
    public abstract class SearchEngine
    {
        public virtual string[] Result(string searchString)
        {
            return new string[] { "No result" };
        }

        public abstract string[] Search(string searchString);

    }

    public class GoogleSearchEngine : SearchEngine
    {
        public override string[] Search(string searchString)
        {
            return new string[] 
            {
                "Google result1",
                "Google result1"
            };
        }
    }

    public class DuckDuckGoSearchEngine : SearchEngine
    {
        public override string[] Search(string searchString)
        {
            return new string[]
            {
                "anonymous DuckDuckGo result 1",
                "anonymous DuckDuckGo result 2"
            };
        }

        public override string[] Result(string searchString)
        {
            return new string[]
            {
                "DuckDuckGo result method 1",

            };
        }
    }


}
