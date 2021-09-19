using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal.Domain
{
    public interface IBinaryToDecimalService
    {
        public string TransformBinaryToDecimal(string binarySequence);
    }
}
