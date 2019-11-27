using System;
namespace SydvestBo.UIfolder
{
    public abstract class Kategori
    {
        public virtual void Opret()
        {

        }
        public virtual void Vis()
        {

        }
        public virtual void Slet()
        {

        }
        public virtual void Opdater()
        {

        }
    }
    public class Udlejer : Kategori
    {

    }
    public class Feriebolig : Kategori
    {

    }
    public class Kontrakt : Kategori
    {

    }
}
