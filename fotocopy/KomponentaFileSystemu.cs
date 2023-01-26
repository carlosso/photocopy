using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace photocopy
{
    public interface KomponentaFileSystemu
    {
        void prohledejAPridej(List<KomponentaFileSystemu> seznamKomponent, string[] maska);
        string getNazev();
        bool getJeAdresar();
    }
}
