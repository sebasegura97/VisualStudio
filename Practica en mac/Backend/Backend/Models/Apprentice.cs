using System;
namespace Backend.Models
{
    public class Apprentice
    {
        public string Name
        {
            get;
            set;
        }
        public int Id {
            set; get;           //Esta es la forma rapida de getters y setters
        }

        //public void SetId(int i)   -Getters y setters, para no acceder
        //{                           directamente al id, sino mediante este metodo.
        //    id = i;                 Esta es la forma larga de hacerlo en C#
        //}
        //public int GetId(){
        //    return id;
        //}
    }
}
