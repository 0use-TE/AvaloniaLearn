using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaLearn.ViewModels
{
    class ItemsControlViewModel:ViewModelBase
    {
        public record Crockery (string Title,int Number );
        public ObservableCollection<Crockery>? CrockeryList { get; set; }
        public ItemsControlViewModel()
        {
            CrockeryList = new ObservableCollection<Crockery>()
            {
                new Crockery("晚餐盘", 12),
                new Crockery("小碟", 12),
                new Crockery("早餐碗", 6),
                new Crockery("杯子", 10),
                new Crockery("茶碟", 10),
                new Crockery("马克杯", 6),
                new Crockery("牛奶壶", 1)
            };
        }
     

    }
}
