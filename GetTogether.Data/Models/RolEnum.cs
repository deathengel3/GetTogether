using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GetTogether.Data.Models
{
    public enum RolEnum : byte
    {
        [Description("Administrator")]
        Admin = 1,
        [Description("User")]
        User = 2
    }
}
