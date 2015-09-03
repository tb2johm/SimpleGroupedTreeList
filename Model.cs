using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGroupedTreeList
{
    

    public class Model
    {
        #region Singleton
        
        private static Model _instance;

        private Model()
        {
            UnGroupedList = new List<Result>() {
                new Result() {result = "Failed", description = "Test1"},
                new Result() {result = "Pass", description = "Test2"},
                new Result() {result = "Failed", description = "Test3"},
                new Result() {result = "Pass", description = "Test4" }};

        }

        public static Model Instance 
        {
            get { return _instance ?? (_instance = new Model()); }
        }

        #endregion


        public List<Result> UnGroupedList { get; set; }
    }
    
    public class Result
    {
        public string result { get; set; }
        public string description { get; set; }
    }
}
