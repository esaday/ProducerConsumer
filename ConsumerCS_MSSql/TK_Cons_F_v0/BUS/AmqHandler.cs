using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.Util;

namespace TK_Cons_F_v0.BUS
{
    /// <summary>
    /// ActiveMQ baglanti islemleri icin gerekli sinif
    /// </summary>
    class AmqHandler : IDisposable
    {

        private readonly string queName = "";
        private readonly IConnectionFactory connectionFactory;
        private readonly IConnection connection;
        private readonly ISession session;
        private readonly IMessageConsumer consumer;
        private bool isDisposed = false;

        public event EventHandler<MessageReceivedArgs> OnMessageReceived;

        /// <summary>
        /// Veri iletisimi icin baglanilacak brokerURI ve Queue ismi ile instance olusturur
        /// </summary>
        /// <param name="queueName">verinin alinacagi Que'nun ismi Or:ProtoExample_1</param>
        /// <param name="brokerUri">baglanılacak host ismi Or: tcp:\\localhost:61616 (varsayilan)</param>
        public AmqHandler(string queueName, string brokerUri)
        {
            queName = queueName;
            connectionFactory = new ConnectionFactory(brokerUri);
            connection = connectionFactory.CreateConnection();
            connection.Start();
            session = connection.CreateSession();
            IDestination destination = SessionUtil.GetDestination(session, queName);
            consumer = session.CreateConsumer(destination);
            consumer.Listener += new MessageListener(OnMessage);
        }

        /// <summary>
        /// her Mesaj geldiginde yapilacak islemler icin event.
        /// </summary>
        /// <param name="ds">C# sinifina parse edilmis mesaj</param>
        public virtual void OnRecieve(SingleData ds)
        {
            OnMessageReceived?.Invoke(ds, new MessageReceivedArgs() { });
        }

        /// <summary>
        /// Mesajın gelip parse edildigi event
        /// </summary>
        /// <param name="message">gelen mesaj</param>
        public void OnMessage(IMessage message)
        {
            IBytesMessage byteMessage = message as IBytesMessage;

            SingleData ds = SingleData.Parser.ParseFrom(byteMessage.Content);

            OnRecieve(ds);
        }



        #region IDisposable Members

        public void Dispose()
        {
            if (!this.isDisposed)
            {
                this.consumer.Dispose();
                this.session.Dispose();
                this.connection.Dispose();
                this.isDisposed = true;
            }
        }

        #endregion

    }

    public class MessageReceivedArgs : EventArgs
    {
        public DataSet MyData { get; set; }

    }
}

