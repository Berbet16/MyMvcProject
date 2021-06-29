using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messagedal;

        public MessageManager(IMessageDal messagedal)
        {
            _messagedal = messagedal;
        }

        public Message GetById(int id)
        {
            return _messagedal.Get(x => x.MessageId == id);
        }

        public List<Message> GetListInbox()
        {
            return _messagedal.List(x => x.ReceiverMail == "admin@gmail.com");
        }

        public List<Message> GetListSendbox()
        {
            return _messagedal.List(x => x.SenderMail == "admin@gmail.com");
        }

        public void MessageAdd(Message message)
        {
            _messagedal.Insert(message);
        }

        public void MessageDelete(Message message)
        {
            throw new NotImplementedException();
        }

        public void MessageUpdate(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
