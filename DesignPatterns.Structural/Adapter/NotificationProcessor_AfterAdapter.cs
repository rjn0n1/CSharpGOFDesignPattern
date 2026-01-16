
namespace DesignPatterns.Structural.Adapter
{
    public class SmsNotificationAdapter : INotificationService
    {
        private readonly SmSGatewayClient _smsGatewayClient;

        public SmsNotificationAdapter(SmSGatewayClient smsGatewayClient)
        {
            _smsGatewayClient = smsGatewayClient;
        }

        public void Send(string message)
        {
            _smsGatewayClient.SendInternatiopnalSms("9999999999", message);
        }
    }



}
