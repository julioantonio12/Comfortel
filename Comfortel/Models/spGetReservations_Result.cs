//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Comfortel.Models
{
    using System;
    
    public partial class spGetReservations_Result
    {
        public int Id { get; set; }
        public int NumAdults { get; set; }
        public int NumKids { get; set; }
        public System.DateTime DateBeg { get; set; }
        public System.DateTime DateEnd { get; set; }
        public int Status { get; set; }
        public float Total { get; set; }
        public string ReservationMedium { get; set; }
        public string ReservationCode { get; set; }
        public int IdRoom { get; set; }
        public int IdGuest { get; set; }
        public Nullable<int> Guest_Id { get; set; }
        public Nullable<int> Room_Id { get; set; }
    }
}