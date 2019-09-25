using GetTogether.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetTogether.Data.Services.Communication
{
    public class LugarResponse : BaseResponse
    {
        public Lugar Lugar { get; private set; }

        private LugarResponse(bool success, string message, Lugar lugar) : base(success, message)
        {
            this.Lugar = lugar;
        }

        public LugarResponse(Lugar lugar) : this(true, string.Empty, lugar) { }

        public LugarResponse(string message) : this(false, message, null) { }
    }
}
