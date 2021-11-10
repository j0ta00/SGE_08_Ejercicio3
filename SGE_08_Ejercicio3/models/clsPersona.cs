using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace MisClases
{
    public class clsPersona
    {

        #region atributos privados
        private String name;
        private String surname;
        private string idPersona;
        private DateTime fechaNacimiento;
        private string direccion;
        private string numeroTelefono;


        #endregion


        //Forma 1

        [Required(ErrorMessage = "Name Required!")]
        public string Name { get => name; set => name = value; }
        [MaxLength(40), Required(ErrorMessage = "Surname Required!")]
        public string Surname { get => surname; set =>surname=value; }
        [HiddenInput(DisplayValue = false)]
        public string IdPersona { get => idPersona; set => idPersona = value; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}" , ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        [MaxLength(200,ErrorMessage ="Max length is 200 characters")]
        public string Direccion { get => direccion; set => direccion = value; }
        [RegularExpression("(6|7)[ -]*([0-9][ -]*){8}", ErrorMessage ="Invalid Phone Number")]    
        public string NumeroTelefono { get => numeroTelefono; set => numeroTelefono = value; }

        public clsPersona()
        {
            idPersona = "";
            name = "";
            surname = "";
            fechaNacimiento = new DateTime();
            direccion = "";
            numeroTelefono = "";
        }

        public clsPersona(string idPersona,string name, string surname,DateTime fechaNacimiento, string direccion, string numeroTelefono)
        {
            this.idPersona = idPersona;
            this.name = name;
            this.surname = surname;
            this.fechaNacimiento = fechaNacimiento;
            this.direccion = direccion;
            this.numeroTelefono = numeroTelefono;
        }
    }
}
