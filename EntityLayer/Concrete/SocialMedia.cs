using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class SocialMedia
    {
        [Key]
        public int SocialID { get; set; }   
        public string SocialName { get; set;}
        public string SocialIcon { get; set;}   
        public string SocialMediaUrl { get; set;}   
        public bool IsSocial { get; set;}   
    }
}
