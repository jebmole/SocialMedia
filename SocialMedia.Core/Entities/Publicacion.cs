using System;
using System.Collections.Generic;

namespace SocialMedia.Core.Entities
{
    public partial class Publicacion
    {
        public Publicacion()
        {
            Comentario = new HashSet<Comentario>();
        }

        public int IdPublicacion { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Comentario> Comentario { get; set; }
    }
}
