package my.classes;

import java.security.SecureRandom;
import java.util.Random;
import my.classes.MyDataSet.DataSet;
import my.classes.MyDataSet.SingleData;



public class Generator {
	
	static final String AB = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
	static SecureRandom rnd = new SecureRandom();
	static Random rndin = new Random();
	
	DataSet.Builder ds = DataSet.newBuilder();
			
			
	public DataSet Generate(int count)
	{	
		
	for (int i = 0; i < count; i++) {
		SingleData.Builder sData= SingleData.newBuilder();
		sData.setSomeText(randomString(rndin.nextInt(150)));
		sData.setSomeValue(rndin.nextInt(150));
		
		long millis = System.currentTimeMillis();
		sData.setTimeSeconds(millis);
		ds.addSingleData(sData.build());
		}
		return ds.build();
		
	}


	String randomString( int len ){
	   StringBuilder sb = new StringBuilder( len );
	   for( int i = 0; i < len; i++ ) 
	      sb.append( AB.charAt( rnd.nextInt(AB.length()) ) );
	   return sb.toString();
	}
	
}
