using System.Collections.Generic;
using GeneralDepartament.Models;

namespace GeneralDepartament.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ResponceApi.User User { get; set; }
    public List<string> Subdivisions { get; set; }
    public List<string> Fullnames { get; set; }

}