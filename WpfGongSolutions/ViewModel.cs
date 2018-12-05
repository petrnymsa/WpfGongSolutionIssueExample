using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfGongSolutions
{
    public class SampleModel
    {
        public string Name { get; set; }
        public bool IsSmall { get; set; }

        public SampleModel(string name, bool isSmall = false)
        {
            Name = name;
            IsSmall = isSmall;
        }
    }

    public class ViewModel
    {
        public ObservableCollection<SampleModel> Data { get; }

        public ViewModel()
        {
            Data = new ObservableCollection<SampleModel>();
            for(var i = 1; i < 7; i++) 
                Data.Add(new SampleModel($"Item-{i}", i % 2 != 0));
        }
    }
}
