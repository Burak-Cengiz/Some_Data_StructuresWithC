using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agaclar
{
    public class AgacIslemler
    {
        public Ikili_agac kok;
        public string dugumler;

        public AgacIslemler(Ikili_agac kok)
        {
            this.kok = kok;
        }
        
        public int YaprakSayisi()
        {
            return YaprakSayisi(kok);
        }

        public int YaprakSayisi(Ikili_agac dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                if ((dugum.sol == null && (dugum.sag == null)))
                {
                    count = 1;
                }
                else
                {
                    count = count + YaprakSayisi(dugum.sol) + YaprakSayisi(dugum.sag);
                }
            }
            return count;

        }

        public int DugumSayisi()
        {
            return DugumSayisi(kok);

        }

        public int DugumSayisi(Ikili_agac dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;

        }

        private void Ziyaret(Ikili_agac dugum)
        {
            dugumler += dugum.veri + " ";
        }

        public void Preorder(Ikili_agac dugum)
        {
            dugumler = "";
            PreOrderInt(dugum);
        }

        private void PreOrderInt(Ikili_agac dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }

        public void Ekle(int dugum)
        {
            Ikili_agac tempParent = new Ikili_agac(dugum);

            Ikili_agac tempSearch = kok;

            while(tempSearch != null)
            {
                tempParent = tempSearch;

                if (dugum == (int)tempSearch.veri)
                    return;
                else if (dugum < (int)tempSearch.veri)
                    tempSearch = tempSearch.sol;
                else 
                    tempSearch = tempSearch.sag;
            }

            Ikili_agac eklenecek = new Ikili_agac(dugum);
            if (kok == null)
                kok = eklenecek;
            else if (dugum < (int)tempParent.veri)
                tempParent.sol = eklenecek;
            else
                tempParent.sag = eklenecek;

        }

        public bool Sil(int deger)
        {
            Ikili_agac current = kok;
            Ikili_agac parent = kok;
            bool issol = true;

            while((int)current.veri != deger)
            {
                parent = current;
                if(deger < (int)current.veri)
                {
                    issol = true;
                    current= current.sol;
                }
                else
                {
                    issol = false;
                    current = current.sag;
                }
                if(current == null)
                    return false;
            }

            if (current.sol == null && current.sag == null)
            { 
                if (current == kok)
                    kok = null;
                else if (issol)
                    parent.sol = null;
                else
                    parent.sag = null;
            }
            else if(current.sag == null)
            {
                if (current == kok)
                    kok = current.sol;
                else if (issol)
                    parent.sol = current.sol;
                else
                    parent.sag = current.sol;
            }
            else if (current.sol == null)
            {
                if (current == kok)
                    kok = current.sag;
                else if (issol)
                    parent.sol = current.sag;
                else
                    parent.sag = current.sag;
            }
            else
            {
                Ikili_agac successor = Successor(kok,current);
                if (current == kok)
                    kok = successor;
                else if (issol)
                    parent.sol = successor;
                else
                    parent.sag = successor;
                successor.sol = current.sol;
            }
            return true;
        }

        public Ikili_agac Ara(int anahtar) 
        { 
            return AraInt(kok, anahtar); 
        }
        private Ikili_agac AraInt(Ikili_agac dugum, int anahtar) 
        { 
            if (dugum == null) 
                return null; 
            else if ((int)dugum.veri == anahtar) 
                return dugum; 
            else if ((int)dugum.veri > anahtar) 
                return (AraInt(dugum.sol, anahtar)); 
            else
                return(AraInt(dugum.sag, anahtar)); 
        }

        public Ikili_agac MinDeger() 
        { 
            Ikili_agac tempSol = kok; 
            while (tempSol.sol != null) 
                tempSol = tempSol.sol; 
            return tempSol; 
        }
        public Ikili_agac MinDeger(Ikili_agac dugum)
        {
            
            while (dugum.sol != null)
                dugum = dugum.sol;
            return dugum;
        }

        public Ikili_agac MaksDeger()
        {
            Ikili_agac tempSag = kok;
            while (tempSag != null)
                tempSag = tempSag.sol;
            return tempSag;
        }

        public Ikili_agac Successor(Ikili_agac root,Ikili_agac dugum)
        {
            if (dugum == null)
                return null;

            Ikili_agac cur = dugum, pre = null;
            if(dugum.sag != null)
            {
                return MinDeger(dugum.sag);
            }
            while (cur != null)
            {
                if ((int)cur.veri > (int)root.veri)
                {
                    pre = cur;
                    cur = cur.sol;
                }
                else
                    cur = cur.sag;

            }                             
            return pre;
        }
    }
}

