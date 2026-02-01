using CommunityToolkit.Mvvm.Input;
using IPT102LasawangMauiApp.Models;

namespace IPT102LasawangMauiApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}