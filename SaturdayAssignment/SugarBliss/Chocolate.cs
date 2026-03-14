using System;
namespace Choco{
    class Chocolate{
        public string Flavour{get;set;}
        public int Quant{get;set;}
        public int PriceperUnit{get;set;}
        public double TotalPrice=0;
        public double DiscountedPrice=0;

        public bool ValidateChocolateFlavour(){
            if(Flavour=="Dark" ||Flavour=="Milk" || Flavour=="White"){
                return true;
            }
            return false;
        }


    }
}