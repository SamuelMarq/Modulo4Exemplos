using System;
using System.Collections.Generic;
using Recodme.Formacao.Modulo4Fichas.Common;

namespace Recodme.Formacao.Modulo4Fichas.Fichas.Exercicios
{
    public class Ficha26solucao
    {
    }

    public class Boat : IVehicle
    {
        bool _on;
        Volante _wheel;
        public void Start() {  _on = true; }
        public void TurnWheel(Volante d) { _wheel = d; }
        public void Break() { }
        public void ChangeGear(int g) { }
    }

    public interface IVehicle
    {
        void Start();
        void ChangeGear(int g);
        void Break();
        void TurnWheel(Volante d);
    }
}
