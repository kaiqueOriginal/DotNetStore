using System;
using System.Collections.Generic;
using System.Text;

namespace DomainProject.Enums
{
    public enum CorE
    {

    }

    public enum tensao
    {
        T127V,T220v
    }

    public enum Lado
    {
        Direita,Esquerda,Ambos
    }
    public enum Corrente
    {
        AC = 0, DC = 1
    }
    public enum TipoVara
    {
        Telescopica,Molinete,Carretilha,Fly
    }
    public enum TipoAcao
    {
        Rapida,Media,Lenta
    }
    public enum TipoRemedio
    {
        Comprimido,Liquido
    }
}
