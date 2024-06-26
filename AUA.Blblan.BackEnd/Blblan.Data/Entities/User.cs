using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Blblan.Data.Entities;

public class User : IdentityUser<int>
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string FullName { get; set; }

    public ICollection<Conversation> Conversations { get; set; }
    
    public ICollection<Message> Subscriptions { get; set; }
}