using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.DotNet.Build.Tasks
{
    interface IIsIncluded
    {
        bool IsIncluded { get; set; }
    }
}
