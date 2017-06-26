using System.ComponentModel.DataAnnotations;

namespace Productivity_Cards.Models
{
    public class Hero : BaseEntity
    {
        public int hero_id{get;set;}

        [Required]
        [MinLength(2)]
        public string name{get;set;}
        public int card_draw{get;set;}
        public int deck_size{get;set;}
        public int level{get;set;}
        public int mana{get;set;}
        public int mana_progression{get;set;}
        
        [Required]
        public string hero_class{get;set;}
        public string created_at{get;set;}
        public string updated_at{get;set;}
        public User user{get;set;}
        public Hero(){
            card_draw = 5;
            deck_size = 20;
            level = 1;
            mana = 0;
            mana_progression = 1;
        }

    }
}