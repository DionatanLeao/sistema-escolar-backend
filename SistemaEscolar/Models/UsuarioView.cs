﻿using System.Web;

namespace SistemaEscolar.Models
{
    public class UsuarioView
    {
        public Usuario Usuario { get; set; }

        public HttpPostedFileBase Foto { get; set; }
    }
}