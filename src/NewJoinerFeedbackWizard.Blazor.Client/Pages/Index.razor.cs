using Microsoft.AspNetCore.Components;
using NewJoinerFeedbackWizard.Dtos.User;
using NewJoinerFeedbackWizard.Interfaces;

namespace NewJoinerFeedbackWizard.Blazor.Client.Pages;

public partial class Index
{
    [Inject]
    private IUserAppService _userAppService { get; set; } = default!;
    UserDto? CurrentUser { get; set; }

    protected override void OnInitialized()
    {
        CurrentUser = _userAppService.GetCurrentUser();
    }
}
