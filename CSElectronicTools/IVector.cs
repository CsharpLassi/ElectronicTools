using System;

namespace CSElectronicTools
{
    public interface IVector
    {
        bool IsLocalVector{ get; }

        double Length();
    }
}

