using CommunityToolkit.Mvvm.ComponentModel;
using MysticPartyTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MysticPartyTracker.ViewModels
{
    public partial class CharacterViewModel : ObservableObject
    {

        //public CharacterViewModel()
        //{
         //   CreateCharacterCommand = new Command(CreateCharacter);
        //}


        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private int _lvl;

        [ObservableProperty]
        private string _classe;

        [ObservableProperty]
        private string _raca;

        private ObservableCollection<Character> _characters = new ObservableCollection<Character>();
        public ObservableCollection<Character> Characters {
            get { return _characters; }
            set { _characters = value; }
        }
       
        public ICommand CreateCharacterCommand { get; }


        public void AddCharacter()
        {
            _characters.Add(new Character(Name, Lvl, Classe, Raca));
        }
    }
}
