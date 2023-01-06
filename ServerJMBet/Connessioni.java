import java.net.*;
import java.util.ArrayList;
import java.util.List;

public class Connessioni {
    ServerSocket serverSocket;
    List<JConnect> ListaConnessioni = new ArrayList<JConnect>();

    public Connessioni(ServerSocket sIn){
        serverSocket = sIn;
    }
    
    public ServerSocket getServerSocket() {
        return serverSocket;
    }

    void addClient(String id, Socket socket){
        ListaConnessioni.add(new JConnect(id, socket));
    }

    public void BroadcastMsg(String senderId, String msg){
        for (JConnect jConnect : ListaConnessioni) {
            System.out.print("Trying to send ["+ msg +"] to " + jConnect.socket + " - ");
            if (!jConnect.getNome().equals(senderId)){
                jConnect.SendMsg(msg);
                System.out.println("[Inviato]");
            }
            else
                System.out.println("[Non inviato]");
        }
    }

    void removeConnectionByID(String id){
        for (int i = 0; i < ListaConnessioni.size(); i++) {
            if (ListaConnessioni.get(i).getNome().equals(id)) {
                ListaConnessioni.remove(ListaConnessioni.get(i));
            }
        }
    }

    public void SendMsgTo(String Mittente, String Destinatario, String messaggio) {
        Boolean trovato = false;
        int x = 0;
        JConnect temp = ListaConnessioni.get(x);
        
        while (!trovato && x < ListaConnessioni.size()) {
            temp = ListaConnessioni.get(x);
            if (temp.getNome().equals(Destinatario)) {
                trovato = true;
                break;                
            }
            x++;
        }

        if (trovato) {
            temp.SendMsg(Mittente + " whispers:" + messaggio);
        }
    }
}
