package my.classes;

import org.apache.activemq.ActiveMQConnectionFactory;

import my.classes.MyDataSet;
import my.classes.MyDataSet.SingleData;
import my.classes.Generator;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.Scanner;

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

/**
 * @author Esad
 *
 */
public class AMQProducer {
	static public String[] getUserURIQUE()
	{
		Scanner reader = new Scanner(System.in); 
		String[] res = new String[2];
		String dump;
		System.out.println("URI(empty for default 'tcp://localhost:61616'): ");
		dump = reader.nextLine();
		res[0] = (dump.length() ==0) ? "tcp://localhost:61616" : dump;

		System.out.println("Que(empty for default 'ProtoExample_1'): ");
		dump = reader.nextLine();
		res[1] = (dump.length() ==0) ? "ProtoExample_1" : dump;
		
		//reader.close();
		return res;
	}
	
	public static void run() {

        try {
            // Create a ConnectionFactory
        	String[] connprms = getUserURIQUE();
            ActiveMQConnectionFactory connectionFactory = new ActiveMQConnectionFactory(connprms[0]);

            // Create a Connection
            Connection connection = connectionFactory.createConnection();
            connection.start();

            // Create a Session
            Session session = connection.createSession(false, Session.AUTO_ACKNOWLEDGE);

            // Create the destination (Topic or Queue)
            Destination destination = session.createQueue(connprms[1]);

            // Create a MessageProducer from the Session to the Topic or Queue
            MessageProducer producer = session.createProducer(destination);
            producer.setDeliveryMode(DeliveryMode.PERSISTENT);
            
            int n=1; 
            Scanner readerC = new Scanner(System.in);
            while(n>0) {
            
            //User input : message count to generate
            
            System.out.println("Enter message count to produce(0 For exit): ");
             n = readerC.nextInt();
             if(n==0) {
            	 System.out.println("Program finished with input zero");
            	 break;
             }
            	
            //Generate data to send.
            Generator g = new Generator();
             MyDataSet.DataSet ds = g.Generate(n);
             
             for (SingleData single : ds.getSingleDataList()) {
                 // put data in the byteArray
                 byte[] data = single.toByteArray();

                 // Create a messages
                 BytesMessage message = session.createBytesMessage();
                 message.writeBytes(data);
                 producer.send(message);
			}


            // Tell the producer to send the message
          
            
            System.out.println("A dataset including "+n+" items sent.\n");
            
            }
            // Clean up
            readerC.close();
            session.close();
            connection.close();
            
        }
        catch (Exception e) {
            System.out.println("Caught: " + e);
            e.printStackTrace();
        }
    
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		run();
	}

}
