using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeParttenDemo
{
    public class FileItem : FileSystemItem
    {
        public long FileBytes { get; }
        public FileItem(string name, long fileBytes) : base(name)
        {
            FileBytes = fileBytes;
        }
        public override decimal GetSizeinKB()
        {
            return decimal.Divide(this.FileBytes, 1000);
        }
    }
}
