package activemq.helloworld.example;

import org.apache.activemq.ActiveMQConnectionFactory;

import java.io.BufferedReader;
import java.io.InputStreamReader;

import javax.jms.BytesMessage;
import javax.jms.Connection;
import javax.jms.DeliveryMode;
import javax.jms.Destination;
import javax.jms.ExceptionListener;
import javax.jms.JMSException;
import javax.jms.Message;
import javax.jms.MessageConsumer;
import javax.jms.MessageProducer;
import javax.jms.Session;
import javax.jms.TextMessage;

import google.proto.example.AddressBookProtos.AddressBook;
import google.proto.example.AddressBookProtos.Person;
import google.proto.example.ListPeople;
import google.proto.example.AddPerson;
 
/**
 * Hello world!
 */
public class App {
 
    public static void main(String[] args) throws Exception {
        thread(new HelloWorldProducer(), false);
        thread(new HelloWorldConsumer(), false);
        Thread.sleep(1000);
            }
 
    public static void thread(Runnable runnable, boolean daemon) {
        Thread brokerThread = new Thread(runnable);
        brokerThread.setDaemon(daemon);
        brokerThread.start();
    }
    
    
 
    public static class HelloWorldProducer implements Runnable {

        public void run() {
            try {
                // Create a ConnectionFactory
                ActiveMQConnectionFactory connectionFactory = new ActiveMQConnectionFactory("tcp://localhost:61616");
 
                // Create a Connection
                Connection connection = connectionFactory.createConnection();
                connection.start();
 
                // Create a Session
                Session session = connection.createSession(false, Session.AUTO_ACKNOWLEDGE);
 
                // Create the destination (Topic or Queue)
                Destination destination = session.createQueue("ProtoExample_1");
 
                // Create a MessageProducer from the Session to the Topic or Queue
                MessageProducer producer = session.createProducer(destination);
                producer.setDeliveryMode(DeliveryMode.NON_PERSISTENT);
           	 	///////////////////////////
                //Provides data to send.
                AddressBook.Builder addresBook = AddressBook.newBuilder();    
                addresBook.addPeople(AddPerson.PromptForAddress(new BufferedReader(new InputStreamReader(System.in)),
                       System.out));
                byte[] data = addresBook.build().toByteArray();

                //////////////////////////
                // Create a messages
                BytesMessage message = session.createBytesMessage();
                message.writeBytes(data);
 
                // Tell the producer to send the message
               // System.out.println("Sent message: "+ message.hashCode() + " : " + Thread.currentThread().getName());
                producer.send(message);
 
                // Clean up
                session.close();
                connection.close();
            }
            catch (Exception e) {
                System.out.println("Caught: " + e);
                e.printStackTrace();
            }
        }
    }
 
    public static class HelloWorldConsumer implements Runnable, ExceptionListener {
        public void run() {
            try {
 
                // Create a ConnectionFactory
                ActiveMQConnectionFactory connectionFactory = new ActiveMQConnectionFactory("tcp://localhost:61616");
 
                // Create a Connection
                Connection connection = connectionFactory.createConnection();
                connection.start();
 
                connection.setExceptionListener(this);
 
                // Create a Session
                Session session = connection.createSession(false, Session.AUTO_ACKNOWLEDGE);
 
                // Create the destination (Topic or Queue)
                Destination destination = session.createQueue("ProtoExample_1");
 
                // Create a MessageConsumer from the Session to the Topic or Queue
                MessageConsumer consumer = session.createConsumer(destination);
 
                // Wait for a message
                Message message = consumer.receive(1000);
 
                BytesMessage messagex = (BytesMessage)consumer.receive();
                int TEXT_LENGTH = new Long(messagex.getBodyLength()).intValue();
                byte[] textBytes = new byte[TEXT_LENGTH];
                messagex.readBytes(textBytes, TEXT_LENGTH);
                
                AddressBook adrs = AddressBook.parseFrom(textBytes);
                
                for (Person person: adrs.getPeopleList()) {
                    System.out.println("Person ID: " + person.getId());
                    System.out.println("  Name: " + person.getName());
                    if (person.getEmail()!= null) {
                      System.out.println("  E-mail address: " + person.getEmail());
                    }

                    for (Person.PhoneNumber phoneNumber : person.getPhonesList()) {
                      switch (phoneNumber.getType()) {
                        case MOBILE:
                          System.out.print("  Mobile phone #: ");
                          break;
                        case HOME:
                          System.out.print("  Home phone #: ");
                          break;
                        case WORK:
                          System.out.print("  Work phone #: ");
                          break;
                      }
                      System.out.println(phoneNumber.getNumber());
                    }
                  }
                
                consumer.close();
                session.close();
                connection.close();
            } catch (Exception e) {
                System.out.println("Caught: " + e);
                e.printStackTrace();
            }
        }
 
        public synchronized void onException(JMSException ex) {
            System.out.println("JMS Exception occured.  Shutting down client.");
        }
    }
}