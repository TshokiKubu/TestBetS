using BETSoft.MessageBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BETSoft.Services.ShoppingCartAPI.RabbitMQSender
{
    public interface IRabbitMQCartMessageSender
    {
        void SendMessage(BaseMessage baseMessage, String queueName);
    }
}
