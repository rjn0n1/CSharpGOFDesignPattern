namespace DesignPatterns.Structural.Adapter
{
    public interface INotificationService  
    {
        void Send(string message);
    }

    public class EmailNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email Sent {message}");
        }
    }

    public class SMSNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS Sent {message}");
        }
    }

    //client code original
    /*
    public class NotificationProcessor
    {
        private readonly INotificationService _notificationService;

        public NotificationProcessor(INotificationService notificationService) { 
            _notificationService = notificationService;
        }
        public void Send(string message) { 
            _notificationService.Send(message);
        }
    }
    */
    //New requirement comes to integrate with a 3rd party api to send sms for international
    //that have complete different method name
    //like 
    public class SmSGatewayClient
    {
        public void SendInternatiopnalSms(string phoneno, string text)
        {
            Console.WriteLine($"{text} sent to mobile {phoneno}");
        }
    }

    //if this need to be called from client.
    //you need to modifiy Notification processor.

    //modified client code
    public class NotificationProcessor
    {
        private readonly INotificationService _notificationService;
        private readonly SmSGatewayClient _smsgatewayClient;


        public NotificationProcessor(INotificationService notificationService)
        {
            _notificationService = notificationService;
            _smsgatewayClient = new SmSGatewayClient();
        }

    
        public void Send(string message)
        {
            _notificationService.Send(message);
        }

        //violeted ocp..need to test complete client code again
        public void SendThroughSmsGateway(string phoneno, string text)
        {
            this._smsgatewayClient.SendInternatiopnalSms(phoneno, text);
        }
    }
}
