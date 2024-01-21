using CommunityToolkit.Mvvm.Messaging.Messages;

namespace GroupHeaderHorizontalOptionsNotAppliedCorrectly.ViewModels.Messages
{
    public class UpdateSelectedStoreItemsMessage : ValueChangedMessage<bool>
    {
        public UpdateSelectedStoreItemsMessage(bool value) : base(value)
        {
            
        }
    }
}
