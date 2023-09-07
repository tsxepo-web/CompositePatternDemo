using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeParttenDemo
{
    public abstract class FileSystemItem
    {
        public string Name { get; }

        public FileSystemItem(string name)
        {
            this.Name = name;
        }

        public abstract decimal GetSizeinKB();
    }
}
