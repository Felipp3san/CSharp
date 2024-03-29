﻿using GestaoClix.Data;
using GestaoClix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoClix.Controllers
{
    internal class GestorTipo
    {
        Database database = Database.getInstance();

        public List<Tipo>? ListarTipos()
        {
            List<Tipo>? listaTipos = null;

            if (database.Movimento is not null)
                listaTipos = [.. database.Tipo];

            return listaTipos;
        }

        public Tipo? BuscarTipo(string idTipo)
        {

            Tipo? tipo = null;

            if (database.Tipo is not null)
                tipo = database.Tipo.Find(idTipo);

            return tipo;
        }
    }
}
