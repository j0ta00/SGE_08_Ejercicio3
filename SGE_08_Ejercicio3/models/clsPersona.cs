using System;

namespace MisClases
{
    public class clsPersona
    {

        #region atributos privados
        private String name;
        private String surname;
       


        #endregion


        //Forma 1
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set =>surname=value; }

        public clsPersona()
        {
            this.name = "";
        }
        public clsPersona(string name,string surname)
        {
            this.name = name;
            this.surname = surname;
        }
    }
}
