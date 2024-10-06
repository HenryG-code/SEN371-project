public class Person{
   
    public int ID { get; set; }
    public string ClientName { get; set; }
    public string Phone { get; set; }

    public Person(int id, string clientName, string phone) {
        ID = id;
        ClientName = clientName;
        Phone = phone;
    }

}