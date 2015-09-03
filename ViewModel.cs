using System.Collections.ObjectModel;
using System.Linq;

namespace SimpleGroupedTreeList
{
    public class ViewModel
    {
        public ObservableCollection<ResultGroup> GroupedList { get; set; }

        public ViewModel()
        {
            Model model = Model.Instance;


            GroupedList = new ObservableCollection<ResultGroup>();

            model.UnGroupedList.ForEach(result =>
            {
                if (GroupedList.All(x => x.Result != result.result))
                    GroupedList.Add(new ResultGroup(result.result));
            });

            foreach (ResultGroup group in GroupedList)
            {
                model.UnGroupedList.ToList().ForEach(x => { if (x.result == group.Result) group.Results.Add(x); });
            }
        }
    }

    public class ResultGroup
    {
        public ResultGroup(string result)
        {
            Results = new ObservableCollection<Result>();
            this.Result = result;
        }

        public string Result { get; set; }
        public ObservableCollection<Result> Results { get; set; } 
    }
}
