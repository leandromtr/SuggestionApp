
namespace SuggestionAppLibrary.DataAccess;

public interface ISuggestionData
{
    Task CreateSuggestion(SuggestionModel suggestion);
    Task<List<SuggestionModel>> GetAllApprovedSuggestions();
    Task<List<SuggestionModel>> GetAllSuggestionsWaitingForApproval();
    Task<SuggestionModel> GetSuggestion(string id);
    Task<List<SuggestionModel>> GetSuggestions();
    Task UpdateSuggestions(SuggestionModel suggestion);
    Task UpvoteSuggestion(string suggestionId, string userId);
}