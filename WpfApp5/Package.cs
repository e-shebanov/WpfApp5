using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public class Package
    {
        public int PackageId { get; set; }
        public DateTime Created { get; set; }

        public virtual ICollection<Pipe> Pipes
        { get; private set; } =
            new ObservableCollection<Pipe>();
    }
}
