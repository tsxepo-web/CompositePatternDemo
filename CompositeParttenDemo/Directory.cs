using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeParttenDemo
{
    class Directory : FileSystemItem
    {
        public List<FileSystemItem> Childrens { get; } = new();
        public Directory(string name) : base(name) { }

        public override decimal GetSizeinKB()
        {
            return this.Childrens.Sum(x => x.GetSizeinKB());
        }

        public void Add(FileSystemItem newNode)
        {
            this.Childrens.Add(newNode);
        }

        public void Remove(FileSystemItem deleteNode)
        {
            this.Childrens.Remove(deleteNode);
        }
    }
}
