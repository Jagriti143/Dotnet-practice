// using System;
// // delegate void PaymentDelegate(double amount);
// // class PaymentService{
// //     public void ProcessPayment(double amount){
// //         Console.WriteLine("Payment of "+amount+" Successfull");
// //     }
// //     public void RTGS(double amt){
// //         Console.WriteLine("RTGS amount: "+amt);
// //     }
// // }
// // static class PaymentExtensions{
// //     public static bool validateAmount(this double amt){
// //         return (amt>0 && amt<=1000000);
// //     }
// // }
// class Button{
//     public delegate void ClickHandler();
//     public event ClickHandler Clicked;
//     public void Click(){
//         Clicked?.Invoke();
//     }
// }
// class Program{
//     public static void Main(string[] args){
//         // PaymentService service=new PaymentService();
//         // PaymentDelegate payment=null;
//         // payment+=service.ProcessPayment;
//         // payment+=service.RTGS;
//         // payment(5000);
//         // double amount=5000;
//         // if(amount.validateAmount()){
//         //     payment(5000);
//         // }else{
//         //     Console.WriteLine("Invalid Payment");
//         // }
//         // Action<string> logActivity=message=>
//         // Console.WriteLine("Log Message: "+message);
//         // logActivity("Hello");
//         // logActivity("byee");

//         // Func<decimal,decimal,decimal> calculateDiscount=(price,discount)=>price-(price*discount/100);
//         // Console.WriteLine(calculateDiscount(1000,10));

//         // Predicate<int> isEligible=age=> age>=18;
//         // Console.WriteLine(isEligible(20));

//         Button btn=new Button();
//         btn.Clicked+=()=>Console.WriteLine("Subscriber method 1");
//         btn.Clicked+=()=>Console.WriteLine("Subscriber method 2");
//         btn.Clicked+=()=>Console.WriteLine("Subscriber method 3");
//         btn.Click();
//     }
// }


// using System;
// using System.Collections.Generic;

// namespace SmartHomeSecurity
// {
//     // 1. DEFINITION: The "Contract" for any security response.
//     // Any method responding to an alert must be void and take a string location.

//     public delegate void SecurityAction(string zone); // definition

//     public class MotionSensor
//     {
//         // The delegate instance (The Panic Button)
//         public SecurityAction OnEmergency; // instance creation

//         public void DetectIntruder(string zoneName)
//         {
//             Console.WriteLine($"[SENSOR] Motion detected in {zoneName}!");
            
//             // 3. INVOCATION: Triggering the Panic Button
//             if (OnEmergency != null)
//             {
//                 OnEmergency(zoneName); // string value = Main Lobby or panicSequence?
//             }
//         }
//     }

//     // Diverse classes that don't know about each other
//     public class AlarmSystem
//     {
//         public void SoundSiren(string zone) => Console.WriteLine($"[ALARM] WOO-OOO! High-decibel siren active in {zone}.");
//     }

//     public class PoliceNotifier
//     {
//         public void CallDispatch(string zone) => Console.WriteLine($"[POLICE] Notifying local precinct of intrusion in {zone}.");
//     }

//     class Program
//     {
//         static void Main()
//         {
//             // Objects Initialization
//             MotionSensor livingRoomSensor = new MotionSensor();
//             AlarmSystem siren = new AlarmSystem();
//             PoliceNotifier police = new PoliceNotifier();

//             // 2. INSTANTIATION & MULTICASTING
//             // We "Subscribe" different methods to the sensor's delegate
//             SecurityAction panicSequence = siren.SoundSiren; // Assignment of methods
//             panicSequence += police.CallDispatch;

//             // Linking the sequence to the sensor
//             livingRoomSensor.OnEmergency = panicSequence;
// 	// class_object.delegate_instance = delegate_instance_multicast

//             // Simulation
//             livingRoomSensor.DetectIntruder("Main Lobby");
//         }
//     }
// }

using System;
using System.Threading;
namespace CallbackDemo
{
    // STEP 1: Define the Delegate
    public delegate void DownloadFinishedHandler(string fileName);

    class FileDownloader
    {
        // STEP 2: Method that accepts the callback
        public void DownloadFile(string name, DownloadFinishedHandler callback)
        {
            Console.WriteLine($"Starting download: {name}...");
            
            // Simulating work
            Thread.Sleep(2000); 
            
            Console.WriteLine($"{name} download complete.");

            // STEP 3: Execute the Callback
            if (callback != null)
            {
                callback(name); 
            }
        }
    }

    class Program
    {
        // STEP 4: The actual Callback Method
        static void DisplayNotification(string file)
        {
            Console.WriteLine($"NOTIFICATION: You can now open {file}.");
        }

        static void Main()
        {
            // FileDownloader downloader = new FileDownloader();

            // // Pass the method 'DisplayNotification' as a callback
            // downloader.DownloadFile("Presentation.pdf", DisplayNotification);
            Comparison<int> sortDescending =(a,b)=>b.CompareTo(a) ;
            Console.WriteLine(sortDescending(5, 10)) ;
            Console.WriteLine(sortDescending(10,5)) ;
        }
    }
}
