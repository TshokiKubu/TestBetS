using BETSoft.MessageBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BETSoft.Services.OrderAPI.RabbitMQSender
{
    public interface IRabbitMQOrderMessageSender
    {
        void SendMessage(BaseMessage baseMessage, String queueName);
    }
}
