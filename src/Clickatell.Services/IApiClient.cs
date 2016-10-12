using Clickatell.Services.Data;

namespace Clickatell.Services
{
    public interface IApiClient
    {
        /// <summary>
        /// Authenticate credentials supplied
        /// </summary>
        /// <returns>
        /// Success = If call was successfully made to Clickatell
        /// Result  = Service response
        /// </returns>
        Response Authenticate();

        /// <summary>
        /// Sends a message to the phonenumber(s) supplied.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>
        /// SendMessageResponse:
        /// Success = If call was successfully made to Clickatell
        /// Result  = Service response
        /// Messages[] = Message object which will have the APIMessageID(Guid created for message for reference) and To(The phonenumber)
        /// </returns>
        SendMessageResponse SendMessage(SendMessageRequest request);

        /// <summary>
        /// Get current credentials account balance
        /// </summary>
        /// <returns>
        /// BalanceResponse:
        /// Success = If call was successfully made to Clickatell
        /// Result  = Service response
        /// Credit  = Credits you have left for current credentials
        /// </returns>
        BalanceResponse GetBalance();

        /// <summary>
        /// Sends request with APIMessageID(s) to stop/delete a message. 
        /// Note the message will only be stopped if it is still in Clickatells queue.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>
        /// MessageStatusResponse:
        /// Success = If call was successfully made to Clickatell
        /// Result  = Service response
        /// MessageStatuses[]  = MessageStatus object which will have the current APIMessageID, Status and Description of the message.
        /// </returns>
        MessageStatusResponse StopMessage(APIMessageRequest request);

        /// <summary>
        /// Sends request with Phonenumbers to see if it is within coverage. (Coverage depends on your Clickatell account settings)
        /// </summary>
        /// <param name="request"></param>
        /// <returns>
        /// MessagCoverageResponse:
        /// Success = If call was successfully made to Clickatell
        /// Result  = Service response
        /// MessageCoverages[]  = MessageCoverage object which will have Routable(If it is within the coverage) and Destination(The phonenumber supplied).
        /// </returns>
        MessagCoverageResponse GetCoverage(MessageRequest request);

        /// <summary>
        /// Sends a request with APIMessageID(s) to see what the costs were for these phonenumber(s) sent.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>
        /// MessageChargeResponse:
        /// Success = If call was successfully made to Clickatell
        /// Result  = Service response
        /// MessageCharges[]  = MessageCharge object which will have the current APIMessageID and Charge of that call.
        /// </returns>
        MessageChargeResponse GetMessageCharge(APIMessageRequest request);

        /// <summary>
        /// Sends a request with APIMessageID(s) to see in what status the requested APIMessageID(s) are.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>
        /// MessageStatusResponse:
        /// Success = If call was successfully made to Clickatell
        /// Result  = Service response
        /// MessageStatuses[]  = MessageStatus object which will have the current APIMessageID, Status and Description of the message.
        /// </returns>
        MessageStatusResponse GetMessageStatus(APIMessageRequest request);
    }
}
