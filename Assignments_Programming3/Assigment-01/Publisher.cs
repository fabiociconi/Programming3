//*         
//  Fabio Alexandre Ciconi
//  Student Number 300930989
//  Centennial College
//  15/05/2017
//*
namespace Assigment_01
{
    class Publisher
    {
        //delegate Publish Message
        public delegate void PublishMessageDel(string msg);

        //initialize publishmsg with null
        public PublishMessageDel publishmsg = null;

        //method to Publish message
        public void PublishMessage(string message)
        {
            publishmsg.Invoke(message);
        }
    }
}
