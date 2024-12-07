using System;

namespace PetMatch.Models
{
    public class Adocao
    {
        public int Id { get; set; } // Identificador único da adoção

        // Relacionamento com o Usuário
        public int UsuarioId { get; set; } // Chave estrangeira para o usuário

        // Relacionamento com o Pet
        public int PetId { get; set; } // Chave estrangeira para o pet

        public StatusAdocao StatusAdocao { get; set; } // Status da adoção (enum)
        public DateTime DataInicio { get; set; } // Data de início da adoção
        public DateTime? DataFinalizacao { get; set; } // Data de finalização da adoção, pode ser nula

        // Propriedades de navegação
        public required Usuario Usuario { get; set; } // Navegação para o usuário (relacionamento)
        public required Pet Pet { get; set; } // Navegação para o pet (relacionamento)
    }

    // Enum para os status da adoção
    public enum StatusAdocao
    {
        Iniciado,  // Adoção foi iniciada
        EmAndamento,  // Adoção está em andamento
        Finalizado,  // Adoção foi finalizada
        Cancelado  // Adoção foi cancelada
    }
}
