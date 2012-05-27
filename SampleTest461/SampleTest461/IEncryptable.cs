using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleTest461
{
    public interface IEncryptable
    {

         MyEncode GetMyEncode { get; }
         MyEncode GetMyDecode { get; }

    }
}
