using GetTogether.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetTogether.Data.Services.Communication
{
    public class VotacionResponse : BaseResponse
    {
        public Votacion Votacion { get; private set; }

        private VotacionResponse(bool success, string message, Votacion votacion) : base(success, message)
        {
            this.Votacion = votacion;
        }

        public VotacionResponse(Votacion votacion) : this(true, string.Empty, votacion) { }

        public VotacionResponse(string message) : this(false, message, null) { }
    }
}
