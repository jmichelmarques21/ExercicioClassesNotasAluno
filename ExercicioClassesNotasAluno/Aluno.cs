﻿using System;
using System.Globalization;

namespace ExercicioClassesNotasAluno {
    internal class Aluno {

        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public double Media() {
            return N1 + N2 + N3;
        }

        public double NotaRestante() {
            return 60.0 - Media();
        }



    }
}
