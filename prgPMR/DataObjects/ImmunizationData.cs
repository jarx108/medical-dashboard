using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prgPMR.DataObjects
{
    public class ImmunizationData(bool isAdd, bool isEdit) : DataInterface
    {
        public bool isAdd = isAdd;
        public bool isEdit = isEdit;
    }
}
