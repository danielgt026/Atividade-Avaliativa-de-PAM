using CommunityToolkit.Mvvm.ComponentModel;
using MysticPartyTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MysticPartyTracker.ViewModels
{
    public partial class SpellsViewModel : ObservableObject
    {
        private readonly ResultService _resultService;

        [ObservableProperty]
        private ObservableCollection<Spells> _results = new ObservableCollection<Spells>();

        public SpellsViewModel()
        {
            _resultService = new ResultService();
            GetResultAsyncCommand = new Command(async () => await GetResultAsync());
        }

        public ICommand GetResultAsyncCommand {  get; }  
        
        public async Task GetResultAsync()
        {
            Results = await _resultService.GetResultAsync();
        }
    }
}
