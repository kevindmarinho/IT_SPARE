using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT_SPARE.Models.ViewModel
{
    public class ModelUser : ModelLogin
    {
        public long T001_IDCOLABORADOR { get; set; }
        public string T001_NOME { get; set; }
        public long T001_CONTROLE { get; set; }
        public string T001_CRACHA { get; set; }
        public string T001_EMAIL { get; set; }
        public string T001_TELEFONE { get; set; }
        public string T001_CELULAR { get; set; }
        public string T001_TPCOLABORADOR { get; set; }
        public long T002_IDCENTROCUSTO { get; set; }
        public string T002_CODIGO_CC { get; set; }
        public string T002_DESCRICAO_CC { get; set; }
        public string T001_GESTORFUNC { get; set; }
        public string T001_GESTORNOME { get; set; }
        public List<ModelProfile> T009_PERFIL { get; set; }
        public List<ModelArea> T022_AREA { get; set; }
    }

    public class ModelLogin
    {
        public string T001_LOGIN { get; set; }
        public string T001_SENHA { get; set; }
    }

    public class ModelProfile
    {
        public int T009_IDPERFIL { get; set; }
        public string T009_DESCRICAO { get; set; }
    }

    public class ModelArea
    {
        public int T022_IDAREA { get; set; }
        public string T022_DESCRICAO { get; set; }
    }
}