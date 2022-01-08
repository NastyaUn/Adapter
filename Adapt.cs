using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Adapt : PDFFlie
    {
        private readonly Fb2File file;
        public Adapt(Fb2File fb2file)
        {
            this.file = fb2file;
        }
        public void OpenFile()
        {
            Console.WriteLine("Открыть и сохранить нечитаемый файл в формате .pdf");
        }
    }
}
