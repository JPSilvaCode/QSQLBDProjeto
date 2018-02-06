﻿using QSQLBDProjeto.RepositorioADO;
using QSQLBDProjeto.RepositorioEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSQLBDProjeto.Aplicacao
{
    public class UsuarioAplicacaoConstrutor
    {
        public static UsuarioAplicacao UsuarioApADO()
        {
            return new UsuarioAplicacao(new UsuarioAplicacaoADO());
        }

        public static UsuarioAplicacao UsuarioApEF()
        {
            return new UsuarioAplicacao(new UsuarioRepositorioEF());
        }
    }
}
