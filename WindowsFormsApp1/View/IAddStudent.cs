using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.View
{
    public interface IAddStudent
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string IDCard { get; set; }
        string Message { get; set; }
    }
}
