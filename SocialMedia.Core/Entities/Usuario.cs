using System;
using System.Collections.Generic;

namespace SocialMedia.Core.Entities
{
    public partial class Usuario
    {
        public Usuario()
        {
            Comentario = new HashSet<Comentario>();
            Publicacion = new HashSet<Publicacion>();
        }

        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<Comentario> Comentario { get; set; }
        public virtual ICollection<Publicacion> Publicacion { get; set; }
    }
}
