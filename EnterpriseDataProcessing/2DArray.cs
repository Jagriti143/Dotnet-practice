// using System;
// using System.Collections;
// using System.Collections.Generic;
// class MainClass{
//     public static void Main(string[] args){
//         Console.WriteLine("Enter number of Products: ");
//         int n=int.Parse(Console.ReadLine());
//         int[] product_Price=new int[n];
//         Console.WriteLine("Enter the price of products:");
//         for(int i=0;i<n;i++){
//             int price=int.Parse(Console.ReadLine());
//             if(price>0){
//                 product_Price[i]=price;
//             }else{
//                 Console.WriteLine("price cannot be negative");
//                 i--;
//             }

//         }
//         int sum=0;
//         for(int i=0;i<n;i++){
//             sum+=product_Price[i];
//         }
//         double avg=(double)sum/n;
//         Console.WriteLine($"Average Price:{avg}");
//         Array.Sort(product_Price);
//         for(int i=0;i<n;i++){
//             if(product_Price[i]<avg){
//                 product_Price[i]=0;
//             }
//         }
//         Array.Resize(ref product_Price,product_Price.Length+5);
//         for(int i=n;i<product_Price.Length;i++){
//             product_Price[i]=(int)avg;
//         }
//         for(int i=0;i<product_Price.Length;i++){
//         Console.WriteLine($"Array Index:{i}, Product Price:{product_Price[i]}");
//         }
       

//         Console.WriteLine("Number of branches:");
//         int b=int.Parse(Console.ReadLine());
//         Console.WriteLine("Number of Months: ");
//         int m=int.Parse(Console.ReadLine());
//         int[,] arr=new int[b,m];
//         for(int i=0;i<arr.GetLength(0);i++){
//             for(int j=0;j<arr.GetLength(1);j++){
//                 int sales=int.Parse(Console.ReadLine());
//                 arr[i,j]=sales;
//             }
//         }


//         int total=0;
//         for(int i=0;i<arr.GetLength(0);i++){
//             int su=0;
//             for(int j=0;j<arr.GetLength(1);j++){
//                 su+=arr[i,j];


//             }
//             total+=su;
//             Console.WriteLine($"Total sales for branch {i} = {su}");
//         }
//         Console.WriteLine($"Total branches {total}");


//         int g=0;
//         for(int i=0;i<arr.GetLength(0);i++){
//             int maxi=0;
//             for(int j=0;j<arr.GetLength(1);j++){
//                 maxi=Math.Max(arr[i,j],maxi);
//             }
//             g=Math.Max(maxi,g);
//             Console.WriteLine($"Highsest Monthly sale in branch{i} = {maxi}");
//         }
//         Console.WriteLine($"Global Highest sale: {g}");

//         int[][] jagged_arr=new int[m][];
//         for(int i=0;i<arr.GetLength(0);i++){
//             int count=0;
//             for(int j=0;j<arr.GetLength(1);j++){
//                 if(arr[i,j]>=avg){
//                     count++;
//                 }
//             }
//             jagged_arr[i]=new int[count];
//             int index=0;
//             for(int j=0;j<arr.GetLength(1);j++){
//                 if(arr[i,j]>=avg){
//                     jagged_arr[i][index++]=arr[i,j];
//                 }
//             }
//         }
//         Console.WriteLine("Jagged Array");
//         for(int i=0;i<b;i++){
//             for(int j=0;j<jagged_arr[i].Length;j++){
//                 Console.Write(jagged_arr[i][j]+" ");
//             }
//             Console.WriteLine();
//         }

//     }
// }





// using System;
// using System.Collections;
// using System.Collections.Generic;
// class MainClass{
//     public static void Main(string[] args){
//         Console.WriteLine("Number of branches:");
//         int b=int.Parse(Console.ReadLine());
//         Console.WriteLine("Number of Months: ");
//         int m=int.Parse(Console.ReadLine());
//         int[,] arr=new int[b,m];
//         for(int i=0;i<arr.GetLength(0);i++){
//             for(int j=0;j<arr.GetLength(1);j++){
//                 int sales=int.Parse(Console.ReadLine());
//                 arr[i,j]=sales;
//             }
//         }
        
//         // for(int i=0;i<arr.GetLength(0);i++){
//         //     for(int j=0;j<arr.GetLength(1);j++){
//         //         Console.WriteLine(arr[i,j]);
//         //     }
//         // }
//         int total=0;
//         for(int i=0;i<arr.GetLength(0);i++){
//             int sum=0;
//             for(int j=0;j<arr.GetLength(1);j++){
//                 sum+=arr[i,j];


//             }
//             total+=sum;
//             Console.WriteLine($"Total sales for branch {i} = {sum}");
//         }
//         Console.WriteLine($"Total branches {total}");


//         int g=0;
//         for(int i=0;i<arr.GetLength(0);i++){
//             int maxi=0;
//             for(int j=0;j<arr.GetLength(1);j++){
//                 maxi=Math.Max(arr[i,j],maxi);
//             }
//             g=Math.Max(maxi,g);
//             Console.WriteLine($"Highsest Monthly sale in branch{i} = {maxi}");
//         }
//         Console.WriteLine($"Global Highest sale: {g}");


//     }
// }

