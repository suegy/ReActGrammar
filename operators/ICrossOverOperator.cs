using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using react.Grammar.elements;

namespace react.Grammar.operators
{
    public interface ICrossOverOperator
    {
        IChromosome [] DoCross(IChromosome a_chrom, IChromosome b_chrom);

    }
}
