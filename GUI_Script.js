//Unity Socket Server-CLient tutorial : http://unitybuster.blogspot.co.uk/2010/08/unity-3d-clientserver-socket-connection.html
private var textFieldString = "Socket Testing String";
private var myTCP; 
public var  pause; 


function Awake() {
 myTCP = gameObject.AddComponent(clientTcp);
 pause = false;
}

function OnGUI () {
 if(myTCP.socketReady==false){
  if (GUI.Button (Rect (20,10,80,20),"Connect")) {
   myTCP.setupSocketServer();
  }
}

 
 else {
 // myTCP.maintainConnection();

  if (GUI.Button (Rect (20,40,80,20), "Start Game")) {
   //myTCP.writeSocket("Meessage from the Server");
   myTCP.readSocket();


  }
  if (GUI.Button (Rect (20,70,80,20), "End Game")) {
      myTCP.writeSocket("End Finished");
      myTCP.closeSocket();
  }
  
  textFieldString = GUI.TextField (Rect (25, 100, 300, 30), textFieldString);
  
  if (GUI.Button (Rect (20,140,80,20),"Disconnect")) {
   myTCP.closeSocket();
   textFieldString = "Socket Disconnected...";
  }
 }


}

     
 
 
