using GetTogether.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetTogether.Data.Services.Communication
{
    public class OpcionComidaResponse : BaseResponse
    {
        public OpcionComida Opcion { get; private set; }

        private OpcionComidaResponse(bool success, string message, OpcionComida opcion) : base(success, message)
        {
            this.Opcion = opcion;
        }

        public OpcionComidaResponse(OpcionComida opcion) : this(true, string.Empty, opcion) { }

        public OpcionComidaResponse(string message) : this(false, message, null) { }
    }
}
