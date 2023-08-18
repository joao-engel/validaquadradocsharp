using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    class Retangulo {
        public int LadoEsq;
        public int LadoSup;
        public int LadoDir;
        public int LadoInf;

        public bool Validador() {
            if (LadoEsq == LadoDir && LadoSup == LadoInf) {
                return true;
            }
            else {
                return false;
            }
        }

        public bool Comparador() {
            if (LadoSup != LadoEsq) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
