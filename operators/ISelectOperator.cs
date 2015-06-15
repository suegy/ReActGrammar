using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using react.Grammar.elements;
using react.Grammar.env;

namespace react.Grammar.operators
{
    public interface ISelectOperator
    {
        void AddPrograms(IProgram[] progs);

        void AddProgram(IProgram progs);

        void SetConfiguration(Configuration config);

        IProgram SelectIndividuum(GenoType genotype);

        bool Reset();

        void Empty();

    }
}
